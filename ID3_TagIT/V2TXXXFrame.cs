namespace ID3_TagIT
{
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.IO;
  using System.Runtime.Serialization.Formatters.Binary;
  using System.Text;

  [Serializable]
  public class V2TXXXFrame : V2FrameHeader
  {
    private byte vbytEncoding = 0xff;
    private string vstrContent = "";
    private string vstrDescriptor = "";

    public V2TXXXFrame Clone()
    {
      BinaryFormatter formatter = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      formatter.Serialize(serializationStream, this);
      serializationStream.Position = 0L;
      return (V2TXXXFrame)formatter.Deserialize(serializationStream);
    }

    public byte[] CreateFrame(MP3 MP3)
    {
      byte[] buffer;
      byte[] buffer2;
      byte[] buffer3;
      byte[] buffer4;
      byte[] bytes;
      Encoding encoding;
      int length;
      switch (MP3.V2TAG.TAGVersion)
      {
        case 3:
          if (this.vbytEncoding == 0xff)
          {
            this.vbytEncoding = Declarations.objSettings.V23Encoding;
          }
          this.vstrDescriptor = this.vstrDescriptor + "\0";
          this.vstrContent = this.vstrContent + "\0";
          switch (this.vbytEncoding)
          {
            case 0:
              bytes = Encoding.Default.GetBytes(this.vstrDescriptor);
              buffer4 = Encoding.Default.GetBytes(this.vstrContent);
              buffer = new byte[(bytes.Length + buffer4.Length) + 1];
              buffer[0] = this.vbytEncoding;
              Array.Copy(bytes, 0, buffer, 1, bytes.Length);
              Array.Copy(buffer4, 0, buffer, 1 + bytes.Length, buffer4.Length);
              goto Label_018E;

            case 1:
              encoding = new UnicodeEncoding(false, true);
              bytes = encoding.GetBytes(this.vstrDescriptor);
              buffer4 = encoding.GetBytes(this.vstrContent);
              buffer = new byte[((bytes.Length + buffer4.Length) + 4) + 1];
              buffer[0] = this.vbytEncoding;
              buffer[1] = 0xff;
              buffer[2] = 0xfe;
              Array.Copy(bytes, 0, buffer, 3, bytes.Length);
              buffer[3 + bytes.Length] = 0xff;
              buffer[4 + bytes.Length] = 0xfe;
              Array.Copy(buffer4, 0, buffer, 5 + bytes.Length, buffer4.Length);
              goto Label_018E;
          }
          break;

        case 4:
          if (this.vbytEncoding == 0xff)
          {
            this.vbytEncoding = Declarations.objSettings.V24Encoding;
          }
          this.FUnsyncUsed = Declarations.objSettings.WriteUnsync;
          this.vstrDescriptor = this.vstrDescriptor + "\0";
          this.vstrContent = this.vstrContent + "\0";
          switch (this.vbytEncoding)
          {
            case 0:
              bytes = Encoding.Default.GetBytes(this.vstrDescriptor);
              buffer4 = Encoding.Default.GetBytes(this.vstrContent);
              buffer = new byte[(bytes.Length + buffer4.Length) + 1];
              buffer[0] = this.vbytEncoding;
              Array.Copy(bytes, 0, buffer, 1, bytes.Length);
              Array.Copy(buffer4, 0, buffer, 1 + bytes.Length, buffer4.Length);
              break;

            case 1:
              encoding = new UnicodeEncoding(false, true);
              bytes = encoding.GetBytes(this.vstrDescriptor);
              buffer4 = encoding.GetBytes(this.vstrContent);
              buffer = new byte[((bytes.Length + buffer4.Length) + 4) + 1];
              buffer[0] = this.vbytEncoding;
              buffer[1] = 0xff;
              buffer[2] = 0xfe;
              Array.Copy(bytes, 0, buffer, 3, bytes.Length);
              buffer[3 + bytes.Length] = 0xff;
              buffer[4 + bytes.Length] = 0xfe;
              Array.Copy(buffer4, 0, buffer, 5 + bytes.Length, buffer4.Length);
              break;

            case 2:
              encoding = new UnicodeEncoding(true, false);
              bytes = encoding.GetBytes(this.vstrDescriptor);
              buffer4 = encoding.GetBytes(this.vstrContent);
              buffer = new byte[(bytes.Length + buffer4.Length) + 1];
              buffer[0] = this.vbytEncoding;
              Array.Copy(bytes, 0, buffer, 1, bytes.Length);
              Array.Copy(buffer4, 0, buffer, 1 + bytes.Length, buffer4.Length);
              break;

            case 3:
              encoding = new UTF8Encoding();
              bytes = encoding.GetBytes(this.vstrDescriptor);
              buffer4 = encoding.GetBytes(this.vstrContent);
              buffer = new byte[(bytes.Length + buffer4.Length) + 1];
              buffer[0] = this.vbytEncoding;
              Array.Copy(bytes, 0, buffer, 1, bytes.Length);
              Array.Copy(buffer4, 0, buffer, 1 + bytes.Length, buffer4.Length);
              break;
          }
          this.vstrDescriptor = this.vstrDescriptor.TrimEnd(new char[] { '\0' });
          this.vstrContent = this.vstrContent.TrimEnd(new char[] { '\0' });
          length = buffer.Length;
          if (this.FUnsyncUsed)
          {
            buffer = ID3Functions.DoUnsync(buffer);
          }
          buffer3 = this.CreateFrameHeader(MP3, buffer, length);
          buffer2 = new byte[((buffer3.Length + buffer.Length) - 1) + 1];
          Array.Copy(buffer3, 0, buffer2, 0, buffer3.Length);
          Array.Copy(buffer, 0, buffer2, buffer3.Length, buffer.Length);
          return buffer2;

        default:
          return buffer2;
      }
      Label_018E:;
      this.vstrDescriptor = this.vstrDescriptor.TrimEnd(new char[] { '\0' });
      this.vstrContent = this.vstrContent.TrimEnd(new char[] { '\0' });
      length = buffer.Length;
      buffer3 = this.CreateFrameHeader(MP3, buffer, length);
      buffer2 = new byte[((buffer3.Length + buffer.Length) - 1) + 1];
      Array.Copy(buffer3, 0, buffer2, 0, buffer3.Length);
      Array.Copy(buffer, 0, buffer2, buffer3.Length, buffer.Length);
      return buffer2;
    }

    public bool GetFrame(ref MP3 MP3, ref MemoryStream mstrTAG)
    {
      if (!this.GetFrameHeader(ref MP3, ref mstrTAG))
      {
        return false;
      }
      if (this.FSize < 3L)
      {
        MemoryStream stream = mstrTAG;
        stream.Position += this.FSize;
        return false;
      }
      byte[] buffer = new byte[((int)((this.FSize - 1L) - this.FNumberOfInfoBytes)) + 1];
      mstrTAG.Read(buffer, 0, (int)(this.FSize - this.FNumberOfInfoBytes));
      if (!this.FEncrypted)
      {
        try
        {
          byte[] buffer2;
          Encoding encoding;
          int num;
          if (this.FUnsyncUsed)
          {
            buffer = ID3Functions.RemoveUnsync(buffer);
          }
          if (this.FCompressed && !ID3Functions.ZLibDecompress(this.FDataLength, ref buffer))
          {
            return false;
          }
          this.vbytEncoding = buffer[0];
          if ((this.vbytEncoding == 0) | (this.vbytEncoding == 3))
          {
            num = Array.IndexOf(buffer, (byte)0, 1);
          }
          else
          {
            int upperBound = buffer.GetUpperBound(0);
            num = 1;
            while (num <= upperBound)
            {
              if ((buffer[num] == 0) & (buffer[num + 1] == 0))
              {
                break;
              }
              num += 2;
            }
          }
          if (((num < 0) | (num == buffer.GetUpperBound(0))) | ((num >= (buffer.GetUpperBound(0) - 1)) & ((this.vbytEncoding == 1) | (this.vbytEncoding == 2))))
          {
            return false;
          }
          switch (this.vbytEncoding)
          {
            case 0:
              buffer2 = new byte[(num - 2) + 1];
              Array.Copy(buffer, 1, buffer2, 0, num - 1);
              this.vstrDescriptor = Encoding.Default.GetString(buffer2);
              buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 1) + 1];
              Array.Copy(buffer, num + 1, buffer2, 0, buffer2.Length);
              this.vstrContent = Encoding.Default.GetString(buffer2).Trim(new char[] { '\0' });
              goto Label_0389;

            case 1:
              if (!((buffer[1] == 0xfe) & (buffer[2] == 0xff)))
              {
                break;
              }
              encoding = new UnicodeEncoding(true, true);
              goto Label_0208;

            case 2:
              encoding = new UnicodeEncoding(true, false);
              buffer2 = new byte[(num - 2) + 1];
              Array.Copy(buffer, 1, buffer2, 0, num - 1);
              this.vstrDescriptor = encoding.GetString(buffer2);
              buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 2) + 1];
              Array.Copy(buffer, num + 2, buffer2, 0, buffer2.Length);
              this.vstrContent = encoding.GetString(buffer2).Trim(new char[] { '\0' });
              goto Label_0389;

            case 3:
              encoding = new UTF8Encoding();
              buffer2 = new byte[(num - 2) + 1];
              Array.Copy(buffer, 1, buffer2, 0, num - 1);
              this.vstrDescriptor = encoding.GetString(buffer2);
              buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 1) + 1];
              Array.Copy(buffer, num + 1, buffer2, 0, buffer2.Length);
              this.vstrContent = encoding.GetString(buffer2).Trim(new char[] { '\0' });
              goto Label_0389;

            default:
              goto Label_0389;
          }
          encoding = new UnicodeEncoding(false, true);
          Label_0208:
          if (num == 1)
          {
            this.vstrDescriptor = "";
          }
          else
          {
            buffer2 = new byte[(num - 4) + 1];
            Array.Copy(buffer, 3, buffer2, 0, num - 3);
            this.vstrDescriptor = encoding.GetString(buffer2);
          }
          buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 4) + 1];
          Array.Copy(buffer, num + 4, buffer2, 0, buffer2.Length);
          this.vstrContent = encoding.GetString(buffer2).Trim(new char[] { '\0' });
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          ProjectData.ClearProjectError();
          return false;
        }
      }
      Label_0389:
      if (StringType.StrCmp(this.vstrContent, "", false) == 0)
      {
        return false;
      }
      this.vstrDescriptor = this.vstrDescriptor.Trim(new char[] { CharType.FromString(Strings.Space(1)) });
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

    public string Descriptor
    {
      get
      {
        return this.vstrDescriptor;
      }
      set
      {
        this.vstrDescriptor = value.Trim(new char[] { ' ' });
      }
    }

    public byte EncodingByte
    {
      get
      {
        return this.vbytEncoding;
      }
      set
      {
        this.vbytEncoding = value;
      }
    }
  }
}