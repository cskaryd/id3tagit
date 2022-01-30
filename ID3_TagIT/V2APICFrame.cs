using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ID3_TagIT
{
  [Serializable]
  public class V2APICFrame : V2FrameHeader
  {
    private bool vbooInclude = true;
    private byte vbytEncoding = 0xff;
    private byte vbytPicType = 0;
    private int vintDataLength = 0;
    private int vintDataStart = 0;
    private string vstrDescriptor = "";
    private string vstrMIMETyp = "";
    private string vstrPath = "";
    private string vstrTempPath = "";

    public V2APICFrame Clone()
    {
      BinaryFormatter formatter = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      formatter.Serialize(serializationStream, this);
      serializationStream.Position = 0L;
      return (V2APICFrame)formatter.Deserialize(serializationStream);
    }

    public byte[] CreateFrame(MP3 MP3)
    {
      byte[] buffer = null;
      byte[] buffer2 = null;
      byte[] buffer3 = null;
      byte[] buffer4 = null;
      byte[] bytes = null;
      Encoding encoding;
      int length;

      switch (MP3.V2TAG.TAGVersion)
      {
        case 3:
          if (this.vbytEncoding == 0xff)
          {
            this.vbytEncoding = Declarations.objSettings.V23Encoding;
          }
          this.vstrMIMETyp = this.vstrMIMETyp + "\0";
          this.vstrDescriptor = this.vstrDescriptor + "\0";
          switch (this.vbytEncoding)
          {
            case 0:
              bytes = Encoding.ASCII.GetBytes(this.vstrMIMETyp);
              buffer4 = Encoding.Default.GetBytes(this.vstrDescriptor);
              if (!(((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) == 0) & (StringType.StrCmp(this.vstrTempPath, "", false) == 0)) & this.vbooInclude))
              {
                if ((StringType.StrCmp(this.vstrTempPath, "", false) != 0) & this.vbooInclude)
                {
                  FileStream stream2 = new FileStream(this.vstrTempPath, FileMode.Open, FileAccess.Read);
                  stream2.Seek(0L, SeekOrigin.Begin);
                  byte[] array = new byte[((int)(stream2.Length - 1L)) + 1];
                  stream2.Read(array, 0, array.Length);
                  stream2.Close();
                  buffer = new byte[(((bytes.Length + buffer4.Length) + 1) + array.Length) + 1];
                  buffer[0] = this.vbytEncoding;
                  Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                  buffer[bytes.Length + 1] = this.vbytPicType;
                  Array.Copy(buffer4, 0, buffer, 2 + bytes.Length, buffer4.Length);
                  Array.Copy(array, 0, buffer, (2 + bytes.Length) + buffer4.Length, array.Length);
                }
                else if ((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) != 0) & this.vbooInclude)
                {
                  FileStream stream3 = new FileStream(this.vstrPath, FileMode.Open, FileAccess.Read);
                  stream3.Seek(0L, SeekOrigin.Begin);
                  byte[] buffer9 = new byte[((int)(stream3.Length - 1L)) + 1];
                  stream3.Read(buffer9, 0, buffer9.Length);
                  stream3.Close();
                  buffer = new byte[(((bytes.Length + buffer4.Length) + 1) + buffer9.Length) + 1];
                  buffer[0] = this.vbytEncoding;
                  Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                  buffer[bytes.Length + 1] = this.vbytPicType;
                  Array.Copy(buffer4, 0, buffer, 2 + bytes.Length, buffer4.Length);
                  Array.Copy(buffer9, 0, buffer, (2 + bytes.Length) + buffer4.Length, buffer9.Length);
                }
                else if ((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) != 0) & !this.vbooInclude)
                {
                  byte[] sourceArray = Encoding.Default.GetBytes(this.vstrPath);
                  buffer = new byte[(((bytes.Length + buffer4.Length) + 1) + sourceArray.Length) + 1];
                  buffer[0] = this.vbytEncoding;
                  Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                  buffer[bytes.Length + 1] = this.vbytPicType;
                  Array.Copy(buffer4, 0, buffer, 2 + bytes.Length, buffer4.Length);
                  Array.Copy(sourceArray, 0, buffer, (2 + bytes.Length) + buffer4.Length, sourceArray.Length);
                }
              }
              else
              {
                FileStream stream = new FileStream(MP3.FI.FullName, FileMode.Open, FileAccess.Read);
                stream.Seek((long)this.vintDataStart, SeekOrigin.Begin);
                byte[] buffer7 = new byte[(this.vintDataLength - 1) + 1];
                stream.Read(buffer7, 0, this.vintDataLength);
                stream.Close();
                buffer = new byte[(((bytes.Length + buffer4.Length) + 1) + buffer7.Length) + 1];
                buffer[0] = this.vbytEncoding;
                Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                buffer[bytes.Length + 1] = this.vbytPicType;
                Array.Copy(buffer4, 0, buffer, 2 + bytes.Length, buffer4.Length);
                Array.Copy(buffer7, 0, buffer, (2 + bytes.Length) + buffer4.Length, buffer7.Length);
              }
              goto Label_08F7;

            case 1:
              encoding = new UnicodeEncoding(false, true);
              bytes = Encoding.ASCII.GetBytes(this.vstrMIMETyp);
              buffer4 = encoding.GetBytes(this.vstrDescriptor);
              if (!(((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) == 0) & (StringType.StrCmp(this.vstrTempPath, "", false) == 0)) & this.vbooInclude))
              {
                if ((StringType.StrCmp(this.vstrTempPath, "", false) != 0) & this.vbooInclude)
                {
                  FileStream stream5 = new FileStream(this.vstrTempPath, FileMode.Open, FileAccess.Read);
                  stream5.Seek(0L, SeekOrigin.Begin);
                  byte[] buffer12 = new byte[((int)(stream5.Length - 1L)) + 1];
                  stream5.Read(buffer12, 0, buffer12.Length);
                  stream5.Close();
                  buffer = new byte[(((bytes.Length + buffer4.Length) + 3) + buffer12.Length) + 1];
                  buffer[0] = this.vbytEncoding;
                  Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                  buffer[bytes.Length + 1] = this.vbytPicType;
                  buffer[bytes.Length + 2] = 0xff;
                  buffer[bytes.Length + 3] = 0xfe;
                  Array.Copy(buffer4, 0, buffer, 4 + bytes.Length, buffer4.Length);
                  Array.Copy(buffer12, 0, buffer, (4 + bytes.Length) + buffer4.Length, buffer12.Length);
                }
                else if ((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) != 0) & this.vbooInclude)
                {
                  FileStream stream6 = new FileStream(this.vstrPath, FileMode.Open, FileAccess.Read);
                  stream6.Seek(0L, SeekOrigin.Begin);
                  byte[] buffer13 = new byte[((int)(stream6.Length - 1L)) + 1];
                  stream6.Read(buffer13, 0, buffer13.Length);
                  stream6.Close();
                  buffer = new byte[(((bytes.Length + buffer4.Length) + 3) + buffer13.Length) + 1];
                  buffer[0] = this.vbytEncoding;
                  Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                  buffer[bytes.Length + 1] = this.vbytPicType;
                  buffer[bytes.Length + 2] = 0xff;
                  buffer[bytes.Length + 3] = 0xfe;
                  Array.Copy(buffer4, 0, buffer, 4 + bytes.Length, buffer4.Length);
                  Array.Copy(buffer13, 0, buffer, (4 + bytes.Length) + buffer4.Length, buffer13.Length);
                }
                else if ((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) != 0) & !this.vbooInclude)
                {
                  byte[] buffer14 = Encoding.Default.GetBytes(this.vstrPath);
                  buffer = new byte[(((bytes.Length + buffer4.Length) + 3) + buffer14.Length) + 1];
                  buffer[0] = this.vbytEncoding;
                  Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                  buffer[bytes.Length + 1] = this.vbytPicType;
                  buffer[bytes.Length + 2] = 0xff;
                  buffer[bytes.Length + 3] = 0xfe;
                  Array.Copy(buffer4, 0, buffer, 4 + bytes.Length, buffer4.Length);
                  Array.Copy(buffer14, 0, buffer, (4 + bytes.Length) + buffer4.Length, buffer14.Length);
                }
              }
              else
              {
                FileStream stream4 = new FileStream(MP3.FI.FullName, FileMode.Open, FileAccess.Read);
                stream4.Seek((long)this.vintDataStart, SeekOrigin.Begin);
                byte[] buffer11 = new byte[(this.vintDataLength - 1) + 1];
                stream4.Read(buffer11, 0, this.vintDataLength);
                stream4.Close();
                buffer = new byte[(((bytes.Length + buffer4.Length) + 3) + buffer11.Length) + 1];
                buffer[0] = this.vbytEncoding;
                Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                buffer[bytes.Length + 1] = this.vbytPicType;
                buffer[bytes.Length + 2] = 0xff;
                buffer[bytes.Length + 3] = 0xfe;
                Array.Copy(buffer4, 0, buffer, 4 + bytes.Length, buffer4.Length);
                Array.Copy(buffer11, 0, buffer, (4 + bytes.Length) + buffer4.Length, buffer11.Length);
              }
              goto Label_08F7;
          }
          break;

        case 4:
          if (this.vbytEncoding == 0xff)
          {
            this.vbytEncoding = Declarations.objSettings.V24Encoding;
          }
          this.FUnsyncUsed = Declarations.objSettings.WriteUnsync;
          this.vstrMIMETyp = this.vstrMIMETyp + "\0";
          this.vstrDescriptor = this.vstrDescriptor + "\0";
          switch (this.vbytEncoding)
          {
            case 0:
            case 2:
            case 3:
              switch (this.vbytEncoding)
              {
                case 0:
                  bytes = Encoding.ASCII.GetBytes(this.vstrMIMETyp);
                  buffer4 = Encoding.Default.GetBytes(this.vstrDescriptor);
                  break;

                case 2:
                  encoding = new UnicodeEncoding(true, false);
                  bytes = Encoding.ASCII.GetBytes(this.vstrMIMETyp);
                  buffer4 = encoding.GetBytes(this.vstrDescriptor);
                  break;

                case 3:
                  encoding = new UTF8Encoding();
                  bytes = Encoding.ASCII.GetBytes(this.vstrMIMETyp);
                  buffer4 = encoding.GetBytes(this.vstrDescriptor);
                  break;
              }
              if (((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) == 0) & (StringType.StrCmp(this.vstrTempPath, "", false) == 0)) & this.vbooInclude)
              {
                FileStream stream7 = new FileStream(MP3.FI.FullName, FileMode.Open, FileAccess.Read);
                stream7.Seek((long)this.vintDataStart, SeekOrigin.Begin);
                byte[] buffer15 = new byte[(this.vintDataLength - 1) + 1];
                stream7.Read(buffer15, 0, this.vintDataLength);
                stream7.Close();
                buffer = new byte[(((bytes.Length + buffer4.Length) + 1) + buffer15.Length) + 1];
                buffer[0] = this.vbytEncoding;
                Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                buffer[bytes.Length + 1] = this.vbytPicType;
                Array.Copy(buffer4, 0, buffer, 2 + bytes.Length, buffer4.Length);
                Array.Copy(buffer15, 0, buffer, (2 + bytes.Length) + buffer4.Length, buffer15.Length);
              }
              else if ((StringType.StrCmp(this.vstrTempPath, "", false) != 0) & this.vbooInclude)
              {
                FileStream stream8 = new FileStream(this.vstrTempPath, FileMode.Open, FileAccess.Read);
                stream8.Seek(0L, SeekOrigin.Begin);
                byte[] buffer16 = new byte[((int)(stream8.Length - 1L)) + 1];
                stream8.Read(buffer16, 0, buffer16.Length);
                stream8.Close();
                buffer = new byte[(((bytes.Length + buffer4.Length) + 1) + buffer16.Length) + 1];
                buffer[0] = this.vbytEncoding;
                Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                buffer[bytes.Length + 1] = this.vbytPicType;
                Array.Copy(buffer4, 0, buffer, 2 + bytes.Length, buffer4.Length);
                Array.Copy(buffer16, 0, buffer, (2 + bytes.Length) + buffer4.Length, buffer16.Length);
              }
              else if ((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) != 0) & this.vbooInclude)
              {
                FileStream stream9 = new FileStream(this.vstrPath, FileMode.Open, FileAccess.Read);
                stream9.Seek(0L, SeekOrigin.Begin);
                byte[] buffer17 = new byte[((int)(stream9.Length - 1L)) + 1];
                stream9.Read(buffer17, 0, buffer17.Length);
                stream9.Close();
                buffer = new byte[(((bytes.Length + buffer4.Length) + 1) + buffer17.Length) + 1];
                buffer[0] = this.vbytEncoding;
                Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                buffer[bytes.Length + 1] = this.vbytPicType;
                Array.Copy(buffer4, 0, buffer, 2 + bytes.Length, buffer4.Length);
                Array.Copy(buffer17, 0, buffer, (2 + bytes.Length) + buffer4.Length, buffer17.Length);
              }
              else if ((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) != 0) & !this.vbooInclude)
              {
                byte[] buffer18 = Encoding.Default.GetBytes(this.vstrPath);
                buffer = new byte[(((bytes.Length + buffer4.Length) + 1) + buffer18.Length) + 1];
                buffer[0] = this.vbytEncoding;
                Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                buffer[bytes.Length + 1] = this.vbytPicType;
                Array.Copy(buffer4, 0, buffer, 2 + bytes.Length, buffer4.Length);
                Array.Copy(buffer18, 0, buffer, (2 + bytes.Length) + buffer4.Length, buffer18.Length);
              }
              break;

            case 1:
              {
                encoding = new UnicodeEncoding(false, true);
                bytes = Encoding.ASCII.GetBytes(this.vstrMIMETyp);
                buffer4 = encoding.GetBytes(this.vstrDescriptor);
                if (!(((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) == 0) & (StringType.StrCmp(this.vstrTempPath, "", false) == 0)) & this.vbooInclude))
                {
                  if ((StringType.StrCmp(this.vstrTempPath, "", false) != 0) & this.vbooInclude)
                  {
                    FileStream stream11 = new FileStream(this.vstrTempPath, FileMode.Open, FileAccess.Read);
                    stream11.Seek(0L, SeekOrigin.Begin);
                    byte[] buffer20 = new byte[((int)(stream11.Length - 1L)) + 1];
                    stream11.Read(buffer20, 0, buffer20.Length);
                    stream11.Close();
                    buffer = new byte[(((bytes.Length + buffer4.Length) + 3) + buffer20.Length) + 1];
                    buffer[0] = this.vbytEncoding;
                    Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                    buffer[bytes.Length + 1] = this.vbytPicType;
                    buffer[bytes.Length + 2] = 0xff;
                    buffer[bytes.Length + 3] = 0xfe;
                    Array.Copy(buffer4, 0, buffer, 4 + bytes.Length, buffer4.Length);
                    Array.Copy(buffer20, 0, buffer, (4 + bytes.Length) + buffer4.Length, buffer20.Length);
                  }
                  else if ((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) != 0) & this.vbooInclude)
                  {
                    FileStream stream12 = new FileStream(this.vstrPath, FileMode.Open, FileAccess.Read);
                    stream12.Seek(0L, SeekOrigin.Begin);
                    byte[] buffer21 = new byte[((int)(stream12.Length - 1L)) + 1];
                    stream12.Read(buffer21, 0, buffer21.Length);
                    stream12.Close();
                    buffer = new byte[(((bytes.Length + buffer4.Length) + 3) + buffer21.Length) + 1];
                    buffer[0] = this.vbytEncoding;
                    Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                    buffer[bytes.Length + 1] = this.vbytPicType;
                    buffer[bytes.Length + 2] = 0xff;
                    buffer[bytes.Length + 3] = 0xfe;
                    Array.Copy(buffer4, 0, buffer, 4 + bytes.Length, buffer4.Length);
                    Array.Copy(buffer21, 0, buffer, (4 + bytes.Length) + buffer4.Length, buffer21.Length);
                  }
                  else if ((StringType.StrCmp(this.vstrPath, MP3.FI.FullName, false) != 0) & !this.vbooInclude)
                  {
                    byte[] buffer22 = Encoding.Default.GetBytes(this.vstrPath);
                    buffer = new byte[(((bytes.Length + buffer4.Length) + 3) + buffer22.Length) + 1];
                    buffer[0] = this.vbytEncoding;
                    Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                    buffer[bytes.Length + 1] = this.vbytPicType;
                    buffer[bytes.Length + 2] = 0xff;
                    buffer[bytes.Length + 3] = 0xfe;
                    Array.Copy(buffer4, 0, buffer, 4 + bytes.Length, buffer4.Length);
                    Array.Copy(buffer22, 0, buffer, (4 + bytes.Length) + buffer4.Length, buffer22.Length);
                  }
                  break;
                }
                FileStream stream10 = new FileStream(MP3.FI.FullName, FileMode.Open, FileAccess.Read);
                stream10.Seek((long)this.vintDataStart, SeekOrigin.Begin);
                byte[] buffer19 = new byte[(this.vintDataLength - 1) + 1];
                stream10.Read(buffer19, 0, this.vintDataLength);
                stream10.Close();
                buffer = new byte[(((bytes.Length + buffer4.Length) + 3) + buffer19.Length) + 1];
                buffer[0] = this.vbytEncoding;
                Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                buffer[bytes.Length + 1] = this.vbytPicType;
                buffer[bytes.Length + 2] = 0xff;
                buffer[bytes.Length + 3] = 0xfe;
                Array.Copy(buffer4, 0, buffer, 4 + bytes.Length, buffer4.Length);
                Array.Copy(buffer19, 0, buffer, (4 + bytes.Length) + buffer4.Length, buffer19.Length);
                break;
              }
          }
          this.vstrDescriptor = this.vstrDescriptor.TrimEnd(new char[] { '\0' });
          this.vstrMIMETyp = this.vstrMIMETyp.TrimEnd(new char[] { '\0' });
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
      Label_08F7:;
      this.vstrDescriptor = this.vstrDescriptor.TrimEnd(new char[] { '\0' });
      this.vstrMIMETyp = this.vstrMIMETyp.TrimEnd(new char[] { '\0' });
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
      if (this.FSize < 5L)
      {
        MemoryStream stream = mstrTAG;
        stream.Position += this.FSize;
        return false;
      }
      byte[] buffer = new byte[((int)((this.FSize - 1L) - this.FNumberOfInfoBytes)) + 1];
      mstrTAG.Read(buffer, 0, (int)(this.FSize - this.FNumberOfInfoBytes));
      if (!this.FEncrypted)
      {
        bool flag;
        try
        {
          byte[] buffer2;
          byte[] buffer3;
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
          try
          {
            this.vbytEncoding = buffer[0];
            num = Array.IndexOf(buffer, (byte)0, 1);
            buffer2 = new byte[(num - 1) + 1];
            Array.Copy(buffer, 1, buffer2, 0, num - 1);
            this.vstrMIMETyp = Encoding.ASCII.GetString(buffer2).Trim(new char[] { '\0' });
            this.vbytPicType = buffer[num + 1];
            if (this.vstrMIMETyp.EndsWith("-->"))
            {
              this.vbooInclude = false;
            }
            else
            {
              this.vbooInclude = true;
            }
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            flag = false;
            ProjectData.ClearProjectError();
            return flag;
          }
          buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 2) + 1];
          Array.Copy(buffer, num + 2, buffer2, 0, buffer2.Length);
          buffer = new byte[buffer2.GetUpperBound(0) + 1];
          Array.Copy(buffer2, buffer, buffer2.Length);
          if ((this.vbytEncoding == 0) | (this.vbytEncoding == 3))
          {
            num = Array.IndexOf(buffer, (byte)0, 0);
          }
          else
          {
            int upperBound = buffer.GetUpperBound(0);
            num = 0;
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
              buffer2 = new byte[(num - 1) + 1];
              Array.Copy(buffer, buffer2, buffer2.Length);
              this.vstrDescriptor = Encoding.Default.GetString(buffer2).Trim(new char[] { '\0' });
              if (this.vstrMIMETyp.EndsWith("-->"))
              {
                goto Label_036D;
              }
              if (MP3.V2TAG.Unsynchronisation | this.FUnsyncUsed)
              {
                goto Label_0318;
              }
              this.vintDataStart = (((10 + MP3.V2TAG.ExtendedHeaderSize) + ((int)mstrTAG.Position)) - buffer.GetUpperBound(0)) + num;
              this.vintDataLength = buffer.GetUpperBound(0) - num;
              if (!((this.vintDataLength < 1) | (this.vintDataStart < 10)))
              {
                break;
              }
              return false;

            case 1:
              if (!((buffer[0] == 0xfe) & (buffer[1] == 0xff)))
              {
                goto Label_03E5;
              }
              encoding = new UnicodeEncoding(true, true);
              goto Label_03ED;

            case 2:
              encoding = new UnicodeEncoding(true, false);
              buffer2 = new byte[(num - 1) + 1];
              Array.Copy(buffer, buffer2, buffer2.Length);
              this.vstrDescriptor = encoding.GetString(buffer2).Trim(new char[] { '\0' });
              if (this.vstrMIMETyp.EndsWith("-->"))
              {
                goto Label_082C;
              }
              if (MP3.V2TAG.Unsynchronisation | this.FUnsyncUsed)
              {
                goto Label_07D7;
              }
              this.vintDataStart = (int)(((((10 + MP3.V2TAG.ExtendedHeaderSize) + mstrTAG.Position) - buffer.GetUpperBound(0)) + num) + 1L);
              this.vintDataLength = (buffer.GetUpperBound(0) - num) - 1;
              if (!((this.vintDataLength < 1) | (this.vintDataStart < 10)))
              {
                goto Label_07B9;
              }
              return false;

            case 3:
              encoding = new UTF8Encoding();
              buffer2 = new byte[(num - 1) + 1];
              Array.Copy(buffer, buffer2, buffer2.Length);
              this.vstrDescriptor = encoding.GetString(buffer2).Trim(new char[] { '\0' });
              if (this.vstrMIMETyp.EndsWith("-->"))
              {
                goto Label_09B7;
              }
              if (MP3.V2TAG.Unsynchronisation | this.FUnsyncUsed)
              {
                goto Label_0965;
              }
              this.vintDataStart = (((10 + MP3.V2TAG.ExtendedHeaderSize) + ((int)mstrTAG.Position)) - buffer.GetUpperBound(0)) + num;
              this.vintDataLength = buffer.GetUpperBound(0) - num;
              if (!((this.vintDataLength < 1) | (this.vintDataStart < 10)))
              {
                goto Label_0947;
              }
              return false;

            default:
              goto Label_0A1A;
          }
          this.vstrPath = MP3.FI.FullName;
          this.vbooInclude = true;
          goto Label_0A1A;
          Label_0318:
          buffer3 = new byte[((buffer.GetUpperBound(0) - num) - 1) + 1];
          Array.Copy(buffer, num + 1, buffer3, 0, buffer3.Length);
          this.vstrTempPath = Id3TagIT_Main.CreateTempFile(buffer3, "");
          this.vstrPath = MP3.FI.FullName;
          this.vbooInclude = true;
          goto Label_0A1A;
          Label_036D:
          buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 1) + 1];
          Array.Copy(buffer, num + 1, buffer2, 0, buffer2.Length);
          this.vstrPath = Encoding.Default.GetString(buffer2).Trim(new char[] { '\0' });
          this.vbooInclude = false;
          goto Label_0A1A;
          Label_03E5:
          encoding = new UnicodeEncoding(false, true);
          Label_03ED:
          if (num == 0)
          {
            this.vstrDescriptor = "";
            if (!this.vstrMIMETyp.EndsWith("-->"))
            {
              if (!(MP3.V2TAG.Unsynchronisation | this.FUnsyncUsed))
              {
                this.vintDataStart = (((10 + MP3.V2TAG.ExtendedHeaderSize) + ((int)mstrTAG.Position)) - buffer.GetUpperBound(0)) + num;
                this.vintDataLength = buffer.GetUpperBound(0) - num;
                if ((this.vintDataLength < 1) | (this.vintDataStart < 10))
                {
                  return false;
                }
                this.vstrPath = MP3.FI.FullName;
                this.vbooInclude = true;
              }
              else
              {
                buffer3 = new byte[((buffer.GetUpperBound(0) - num) - 2) + 1];
                Array.Copy(buffer, num + 2, buffer3, 0, buffer3.Length);
                this.vstrTempPath = Id3TagIT_Main.CreateTempFile(buffer3, "");
                this.vstrPath = MP3.FI.FullName;
                this.vbooInclude = true;
              }
            }
            else
            {
              buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 2) + 1];
              Array.Copy(buffer, num + 2, buffer2, 0, buffer2.Length);
              this.vstrPath = Encoding.Default.GetString(buffer2).Trim(new char[] { '\0' });
              this.vbooInclude = false;
            }
          }
          else
          {
            buffer2 = new byte[(num - 3) + 1];
            Array.Copy(buffer, 2, buffer2, 0, buffer2.Length);
            this.vstrDescriptor = encoding.GetString(buffer2).Trim(new char[] { '\0' });
            if (!this.vstrMIMETyp.EndsWith("-->"))
            {
              if (!(MP3.V2TAG.Unsynchronisation | this.FUnsyncUsed))
              {
                this.vintDataStart = (int)(((((10 + MP3.V2TAG.ExtendedHeaderSize) + mstrTAG.Position) - buffer.GetUpperBound(0)) + num) + 1L);
                this.vintDataLength = (buffer.GetUpperBound(0) - num) - 1;
                if ((this.vintDataLength < 1) | (this.vintDataStart < 10))
                {
                  return false;
                }
                this.vstrPath = MP3.FI.FullName;
                this.vbooInclude = true;
              }
              else
              {
                buffer3 = new byte[((buffer.GetUpperBound(0) - num) - 2) + 1];
                Array.Copy(buffer, num + 2, buffer3, 0, buffer3.Length);
                this.vstrTempPath = Id3TagIT_Main.CreateTempFile(buffer3, "");
                this.vstrPath = MP3.FI.FullName;
                this.vbooInclude = true;
              }
            }
            else
            {
              buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 2) + 1];
              Array.Copy(buffer, num + 2, buffer2, 0, buffer2.Length);
              this.vstrPath = Encoding.Default.GetString(buffer2).Trim(new char[] { '\0' });
              this.vbooInclude = false;
            }
          }
          goto Label_0A1A;
          Label_07B9:
          this.vstrPath = MP3.FI.FullName;
          this.vbooInclude = true;
          goto Label_0A1A;
          Label_07D7:
          buffer3 = new byte[((buffer.GetUpperBound(0) - num) - 2) + 1];
          Array.Copy(buffer, num + 2, buffer3, 0, buffer3.Length);
          this.vstrTempPath = Id3TagIT_Main.CreateTempFile(buffer3, "");
          this.vstrPath = MP3.FI.FullName;
          this.vbooInclude = true;
          goto Label_0A1A;
          Label_082C:
          buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 2) + 1];
          Array.Copy(buffer, num + 2, buffer2, 0, buffer2.Length);
          this.vstrPath = Encoding.Default.GetString(buffer2).Trim(new char[] { '\0' });
          this.vbooInclude = false;
          goto Label_0A1A;
          Label_0947:
          this.vstrPath = MP3.FI.FullName;
          this.vbooInclude = true;
          goto Label_0A1A;
          Label_0965:
          buffer3 = new byte[((buffer.GetUpperBound(0) - num) - 1) + 1];
          Array.Copy(buffer, num + 1, buffer3, 0, buffer3.Length);
          this.vstrTempPath = Id3TagIT_Main.CreateTempFile(buffer3, "");
          this.vstrPath = MP3.FI.FullName;
          this.vbooInclude = true;
          goto Label_0A1A;
          Label_09B7:
          buffer2 = new byte[((buffer.GetUpperBound(0) - num) - 1) + 1];
          Array.Copy(buffer, num + 1, buffer2, 0, buffer2.Length);
          this.vstrPath = Encoding.Default.GetString(buffer2).Trim(new char[] { '\0' });
          this.vbooInclude = false;
        }
        catch (Exception exception2)
        {
          ProjectData.SetProjectError(exception2);
          flag = false;
          ProjectData.ClearProjectError();
          return flag;
        }
      }
      Label_0A1A:;
      this.vstrDescriptor = this.vstrDescriptor.Trim(new char[] { CharType.FromString(Strings.Space(1)) });
      return true;
    }

    public int DataLength
    {
      get
      {
        return this.vintDataLength;
      }
      set
      {
        this.vintDataLength = value;
      }
    }

    public int DataStart
    {
      get
      {
        return this.vintDataStart;
      }
      set
      {
        this.vintDataStart = value;
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

    public bool Include
    {
      get
      {
        return this.vbooInclude;
      }
      set
      {
        this.vbooInclude = value;
      }
    }

    public string MIMEType
    {
      get
      {
        return this.vstrMIMETyp;
      }
      set
      {
        this.vstrMIMETyp = value.Trim(new char[] { ' ' });
      }
    }

    public string Path
    {
      get
      {
        return this.vstrPath;
      }
      set
      {
        this.vstrPath = value.Trim(new char[] { ' ' });
      }
    }

    public byte PicType
    {
      get
      {
        return this.vbytPicType;
      }
      set
      {
        this.vbytPicType = value;
      }
    }

    public string TempPath
    {
      get
      {
        return this.vstrTempPath;
      }
      set
      {
        this.vstrTempPath = value.Trim(new char[] { ' ' });
      }
    }
  }
}