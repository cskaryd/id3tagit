namespace ID3_TagIT
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    [Serializable]
    public class V2POPMFrame : V2FrameHeader
    {
        private byte vbytRating = 0;
        private int vintCounter = 0;
        private string vstrUser = "";

        public V2POPMFrame Clone()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream serializationStream = new MemoryStream();
            formatter.Serialize(serializationStream, this);
            serializationStream.Position = 0L;
            return (V2POPMFrame) formatter.Deserialize(serializationStream);
        }

        public byte[] CreateFrame(MP3 MP3)
        {
            string str = "";
            if (this.vintCounter > 0)
            {
                int vintCounter = this.vintCounter;
                int num2 = (int) Math.Round(Math.Floor((double) (Math.Log((double) vintCounter) / Math.Log(256.0))));
                for (int i = num2; i >= 0; i += -1)
                {
                    str = str + StringType.FromChar(Strings.Chr((int) (((long) vintCounter) / ((long) Math.Round(Math.Pow(256.0, (double) i))))));
                    vintCounter = (int) Math.Round((double) (vintCounter - ((((long) vintCounter) / ((long) Math.Round(Math.Pow(256.0, (double) i)))) * Math.Pow(256.0, (double) i))));
                }
            }
            else
            {
                str = "\0\0\0\0";
            }
            this.vstrUser = this.vstrUser + "\0";
            byte[] bytes = Encoding.Default.GetBytes(this.vstrUser);
            byte[] sourceArray = Encoding.Default.GetBytes(str.PadLeft(4, '\0'));
            this.vstrUser = this.vstrUser.TrimEnd(new char[] { '\0' });
            byte[] destinationArray = new byte[(bytes.Length + sourceArray.Length) + 1];
            Array.Copy(bytes, 0, destinationArray, 0, bytes.Length);
            destinationArray[bytes.Length] = this.vbytRating;
            Array.Copy(sourceArray, 0, destinationArray, 1 + bytes.Length, sourceArray.Length);
            int length = destinationArray.Length;
            if (MP3.V2TAG.TAGVersion == 4)
            {
                this.FUnsyncUsed = Declarations.objSettings.WriteUnsync;
                if (this.FUnsyncUsed)
                {
                    destinationArray = ID3Functions.DoUnsync(destinationArray);
                }
            }
            byte[] buffer3 = this.CreateFrameHeader(MP3, destinationArray, length);
            byte[] buffer2 = new byte[((buffer3.Length + destinationArray.Length) - 1) + 1];
            Array.Copy(buffer3, 0, buffer2, 0, buffer3.Length);
            Array.Copy(destinationArray, 0, buffer2, buffer3.Length, destinationArray.Length);
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
            byte[] buffer = new byte[((int) ((this.FSize - 1L) - this.FNumberOfInfoBytes)) + 1];
            mstrTAG.Read(buffer, 0, (int) (this.FSize - this.FNumberOfInfoBytes));
            if (!this.FEncrypted)
            {
                try
                {
                    byte[] buffer2;
                    if (this.FUnsyncUsed)
                    {
                        buffer = ID3Functions.RemoveUnsync(buffer);
                    }
                    if (this.FCompressed && !ID3Functions.ZLibDecompress(this.FDataLength, ref buffer))
                    {
                        return false;
                    }
                    int num3 = Array.IndexOf(buffer, (byte) 0, 0);
                    if ((num3 < 0) | (num3 == buffer.GetUpperBound(0)))
                    {
                        return false;
                    }
                    if (num3 == 0)
                    {
                        this.vstrUser = "";
                    }
                    else
                    {
                        buffer2 = new byte[(num3 - 1) + 1];
                        Array.Copy(buffer, 0, buffer2, 0, buffer2.Length);
                        this.vstrUser = Encoding.Default.GetString(buffer2);
                    }
                    this.vbytRating = buffer[num3 + 1];
                    if (buffer.GetUpperBound(0) > (num3 + 1))
                    {
                        buffer2 = new byte[((buffer.GetUpperBound(0) - num3) - 2) + 1];
                        Array.Copy(buffer, num3 + 2, buffer2, 0, buffer2.Length);
                        this.vintCounter = 0;
                        int index = 0;
                        for (int i = buffer2.GetUpperBound(0); i >= 0; i += -1)
                        {
                            this.vintCounter = (int) Math.Round((double) (this.vintCounter + (buffer2[index] * Math.Pow(256.0, (double) i))));
                            index++;
                        }
                    }
                    else
                    {
                        this.vintCounter = 0;
                    }
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    ProjectData.ClearProjectError();
                    return false;
                }
            }
            this.vstrUser = this.vstrUser.Trim(new char[] { CharType.FromString(Strings.Space(1)) });
            return true;
        }

        public int Counter
        {
            get
            {
                return this.vintCounter;
            }
            set
            {
                this.vintCounter = value;
            }
        }

        public byte Rating
        {
            get
            {
                return this.vbytRating;
            }
            set
            {
                this.vbytRating = value;
            }
        }

        public string User
        {
            get
            {
                return this.vstrUser;
            }
            set
            {
                this.vstrUser = value.Trim(new char[] { ' ' });
            }
        }
    }
}

