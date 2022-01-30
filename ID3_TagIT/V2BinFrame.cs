namespace ID3_TagIT
{
  using System;
  using System.IO;
  using System.Runtime.Serialization.Formatters.Binary;

  [Serializable]
  public class V2BinFrame : V2FrameHeader
  {
    private byte[] abytBinary;

    public V2BinFrame Clone()
    {
      BinaryFormatter formatter = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      formatter.Serialize(serializationStream, this);
      serializationStream.Position = 0L;
      return (V2BinFrame)formatter.Deserialize(serializationStream);
    }

    public byte[] CreateFrame(MP3 MP3)
    {
      byte[] abytBinary;
      byte[] buffer2;
      byte[] buffer3;
      switch (MP3.V2TAG.TAGVersion)
      {
        case 3:
          abytBinary = this.abytBinary;
          buffer3 = this.CreateFrameHeader(MP3, abytBinary, abytBinary.Length);
          buffer2 = new byte[((buffer3.Length + abytBinary.Length) - 1) + 1];
          Array.Copy(buffer3, 0, buffer2, 0, buffer3.Length);
          Array.Copy(abytBinary, 0, buffer2, buffer3.Length, abytBinary.Length);
          return buffer2;

        case 4:
          this.FUnsyncUsed = Declarations.objSettings.WriteUnsync;
          abytBinary = this.abytBinary;
          if (this.FUnsyncUsed)
          {
            abytBinary = ID3Functions.DoUnsync(abytBinary);
          }
          buffer3 = this.CreateFrameHeader(MP3, abytBinary, abytBinary.Length);
          buffer2 = new byte[((buffer3.Length + abytBinary.Length) - 1) + 1];
          Array.Copy(buffer3, 0, buffer2, 0, buffer3.Length);
          Array.Copy(abytBinary, 0, buffer2, buffer3.Length, abytBinary.Length);
          return buffer2;
      }
      return buffer2;
    }

    public bool GetFrame(ref MP3 MP3, ref MemoryStream mstrTAG)
    {
      if (!this.GetFrameHeader(ref MP3, ref mstrTAG))
      {
        return false;
      }
      if (this.FSize == 0L)
      {
        return false;
      }
      byte[] buffer = new byte[((int)((this.FSize - 1L) - this.FNumberOfInfoBytes)) + 1];
      mstrTAG.Read(buffer, 0, (int)(this.FSize - this.FNumberOfInfoBytes));
      if (!this.FEncrypted)
      {
        if (this.FUnsyncUsed)
        {
          buffer = ID3Functions.RemoveUnsync(buffer);
        }
        if (this.FCompressed && !ID3Functions.ZLibDecompress(this.FDataLength, ref buffer))
        {
          return false;
        }
        this.abytBinary = new byte[buffer.GetUpperBound(0) + 1];
        Array.Copy(buffer, 0, this.abytBinary, 0, this.abytBinary.Length);
      }
      return true;
    }

    public byte[] BinaryData
    {
      get
      {
        return this.abytBinary;
      }
      set
      {
        this.abytBinary = value;
      }
    }
  }
}