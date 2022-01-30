namespace ID3_TagIT
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    [Serializable]
    public class V2TextFrame : V2FrameHeader
    {
        private byte vbytEncoding = 0xff;
        private string vstrContent = "";

        public V2TextFrame Clone()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream serializationStream = new MemoryStream();
            formatter.Serialize(serializationStream, this);
            serializationStream.Position = 0L;
            return (V2TextFrame) formatter.Deserialize(serializationStream);
        }

        public byte[] CreateFrame(MP3 MP3)
        {
            byte[] buffer;
            byte[] buffer2;
            byte[] buffer3;
            byte[] bytes;
            int length;
            switch (MP3.V2TAG.TAGVersion)
            {
                case 3:
                    if (this.vbytEncoding == 0xff)
                    {
                        this.vbytEncoding = Declarations.objSettings.V23Encoding;
                    }
                    this.vstrContent = this.vstrContent + "\0";
                    switch (this.vbytEncoding)
                    {
                        case 0:
                            bytes = Encoding.Default.GetBytes(this.vstrContent);
                            buffer = new byte[bytes.Length + 1];
                            buffer[0] = this.vbytEncoding;
                            Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                            goto Label_00F2;

                        case 1:
                            bytes = new UnicodeEncoding(false, true).GetBytes(this.vstrContent);
                            buffer = new byte[(bytes.Length + 2) + 1];
                            buffer[0] = this.vbytEncoding;
                            buffer[1] = 0xff;
                            buffer[2] = 0xfe;
                            Array.Copy(bytes, 0, buffer, 3, bytes.Length);
                            goto Label_00F2;
                    }
                    break;

                case 4:
                    if (this.vbytEncoding == 0xff)
                    {
                        this.vbytEncoding = Declarations.objSettings.V24Encoding;
                    }
                    this.FUnsyncUsed = Declarations.objSettings.WriteUnsync;
                    this.vstrContent = this.vstrContent + "\0";
                    switch (this.vbytEncoding)
                    {
                        case 0:
                            bytes = Encoding.Default.GetBytes(this.vstrContent);
                            buffer = new byte[bytes.Length + 1];
                            buffer[0] = this.vbytEncoding;
                            Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                            break;

                        case 1:
                            bytes = new UnicodeEncoding(false, true).GetBytes(this.vstrContent);
                            buffer = new byte[(bytes.Length + 2) + 1];
                            buffer[0] = this.vbytEncoding;
                            buffer[1] = 0xff;
                            buffer[2] = 0xfe;
                            Array.Copy(bytes, 0, buffer, 3, bytes.Length);
                            break;

                        case 2:
                            bytes = new UnicodeEncoding(true, false).GetBytes(this.vstrContent);
                            buffer = new byte[bytes.Length + 1];
                            buffer[0] = this.vbytEncoding;
                            Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                            break;

                        case 3:
                            bytes = new UTF8Encoding().GetBytes(this.vstrContent);
                            buffer = new byte[bytes.Length + 1];
                            buffer[0] = this.vbytEncoding;
                            Array.Copy(bytes, 0, buffer, 1, bytes.Length);
                            break;
                    }
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
        Label_00F2:;
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
            if (this.FSize < 2L)
            {
                MemoryStream stream = mstrTAG;
                stream.Position += this.FSize;
                return false;
            }
            byte[] buffer = new byte[((int) ((this.FSize - 1L) - this.FNumberOfInfoBytes)) + 1];
            mstrTAG.Read(buffer, 0, (int) (this.FSize - this.FNumberOfInfoBytes));
            if (!this.FEncrypted)
            {
                try
                {
                    byte[] buffer2;
                    Encoding encoding;
                    if (this.FUnsyncUsed)
                    {
                        buffer = ID3Functions.RemoveUnsync(buffer);
                    }
                    if (this.FCompressed && !ID3Functions.ZLibDecompress(this.FDataLength, ref buffer))
                    {
                        return false;
                    }
                    this.vbytEncoding = buffer[0];
                    switch (this.vbytEncoding)
                    {
                        case 0:
                            buffer2 = new byte[(buffer.GetUpperBound(0) - 1) + 1];
                            Array.Copy(buffer, 1, buffer2, 0, buffer2.Length);
                            this.vstrContent = Encoding.Default.GetString(buffer2).Trim(new char[] { '\0' });
                            goto Label_022E;

                        case 1:
                            if (!((buffer[1] == 0xfe) & (buffer[2] == 0xff)))
                            {
                                break;
                            }
                            encoding = new UnicodeEncoding(true, true);
                            goto Label_0146;

                        case 2:
                            encoding = new UnicodeEncoding(true, false);
                            buffer2 = new byte[(buffer.GetUpperBound(0) - 1) + 1];
                            Array.Copy(buffer, 1, buffer2, 0, buffer2.Length);
                            this.vstrContent = encoding.GetString(buffer2).Trim(new char[] { '\0' });
                            goto Label_022E;

                        case 3:
                            encoding = new UTF8Encoding();
                            buffer2 = new byte[(buffer.GetUpperBound(0) - 1) + 1];
                            Array.Copy(buffer, 1, buffer2, 0, buffer2.Length);
                            this.vstrContent = encoding.GetString(buffer2).Trim(new char[] { '\0' });
                            goto Label_022E;

                        default:
                            goto Label_022E;
                    }
                    encoding = new UnicodeEncoding(false, true);
                Label_0146:
                    buffer2 = new byte[(buffer.GetUpperBound(0) - 3) + 1];
                    Array.Copy(buffer, 3, buffer2, 0, buffer2.Length);
                    this.vstrContent = encoding.GetString(buffer2).Trim(new char[] { '\0' });
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    ProjectData.ClearProjectError();
                    return false;
                }
            }
        Label_022E:
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

