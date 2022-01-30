namespace ID3_TagIT
{
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.IO;
  using System.Runtime.Serialization.Formatters.Binary;
  using System.Text;

  [Serializable]
  public class V2WebFrame : V2FrameHeader
  {
    private string vstrContent = "";

    public V2WebFrame Clone()
    {
      BinaryFormatter formatter = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      formatter.Serialize(serializationStream, this);
      serializationStream.Position = 0L;
      return (V2WebFrame)formatter.Deserialize(serializationStream);
    }

    public byte[] CreateFrame(MP3 MP3)
    {
      byte[] bytes;
      byte[] buffer2;
      byte[] buffer3;
      switch (MP3.V2TAG.TAGVersion)
      {
        case 3:
          this.vstrContent = this.vstrContent + "\0";
          bytes = Encoding.Default.GetBytes(this.vstrContent);
          buffer3 = this.CreateFrameHeader(MP3, bytes, this.vstrContent.Length);
          this.vstrContent = this.vstrContent.TrimEnd(new char[] { '\0' });
          buffer2 = new byte[((buffer3.Length + bytes.Length) - 1) + 1];
          Array.Copy(buffer3, 0, buffer2, 0, buffer3.Length);
          Array.Copy(bytes, 0, buffer2, buffer3.Length, bytes.Length);
          return buffer2;

        case 4:
          this.FUnsyncUsed = Declarations.objSettings.WriteUnsync;
          this.vstrContent = this.vstrContent + "\0";
          bytes = Encoding.Default.GetBytes(this.vstrContent);
          this.vstrContent = this.vstrContent.TrimEnd(new char[] { '\0' });
          if (this.FUnsyncUsed)
          {
            bytes = ID3Functions.DoUnsync(bytes);
          }
          buffer3 = this.CreateFrameHeader(MP3, bytes, this.vstrContent.Length);
          buffer2 = new byte[((buffer3.Length + bytes.Length) - 1) + 1];
          Array.Copy(buffer3, 0, buffer2, 0, buffer3.Length);
          Array.Copy(bytes, 0, buffer2, buffer3.Length, bytes.Length);
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
      if (this.FSize < 1L)
      {
        return false;
      }
      byte[] buffer = new byte[((int)((this.FSize - 1L) - this.FNumberOfInfoBytes)) + 1];
      mstrTAG.Read(buffer, 0, (int)(this.FSize - this.FNumberOfInfoBytes));
      if (!this.FEncrypted)
      {
        try
        {
          if (this.FUnsyncUsed)
          {
            buffer = ID3Functions.RemoveUnsync(buffer);
          }
          if (this.FCompressed && !ID3Functions.ZLibDecompress(this.FDataLength, ref buffer))
          {
            return false;
          }
          byte[] destinationArray = new byte[buffer.GetUpperBound(0) + 1];
          Array.Copy(buffer, 0, destinationArray, 0, destinationArray.Length);
          this.vstrContent = Encoding.Default.GetString(destinationArray).Trim(new char[] { '\0' });
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          ProjectData.ClearProjectError();
          return false;
        }
      }
      if (StringType.StrCmp(this.vstrContent, "", false) == 0)
      {
        return false;
      }
      this.vstrContent = this.vstrContent.Trim(new char[] { CharType.FromString(Strings.Space(1)) });
      return true;
    }

    public string Content
    {
      get
      {
        return this.vstrContent;
      }
      set
      {
        this.vstrContent = value.Trim(new char[] { ' ' });
      }
    }
  }
}