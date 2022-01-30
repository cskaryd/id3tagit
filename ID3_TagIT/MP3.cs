namespace ID3_TagIT
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    public class MP3 : FileOperations
    {
        private int I;
        private byte J;
        public ID3_TagIT.V1TAG V1TAG;
        public ID3_TagIT.V2TAG V2TAG;
        private bool vbooChanged;
        private bool vbooDouble;
        private bool vbooFileTAGCompare;
        private bool vbooSelected;
        private bool vbooVBR;
        private byte vbytChannel;
        private byte vbytLayer;
        private byte vbytVersion;
        private int vintAudioCheckSum;
        private int vintBitrate;
        private int vintDuration;
        private int vintDurationMS;
        private int vintNumberOfFrames;
        private int vintSamplerate;

        public MP3(string vstrFullFilename) : base(vstrFullFilename)
        {
            this.V1TAG = new ID3_TagIT.V1TAG();
            this.V2TAG = new ID3_TagIT.V2TAG();
            this.vbooChanged = false;
            this.vbooDouble = false;
            this.vbooFileTAGCompare = false;
            this.vbooSelected = false;
            this.vintAudioCheckSum = 0;
            this.vbooVBR = false;
            this.vbytVersion = 0;
            this.vbytLayer = 0;
            this.vintBitrate = 0;
            this.vintSamplerate = 0;
            this.vbytChannel = 0;
            this.vintNumberOfFrames = 0;
            this.vintDuration = 0;
            this.vintDurationMS = 0;
            this.I = 0;
            this.J = 0;
        }

        public void CalcAudioCheckSum()
        {
            int vintStart = 0;
            int length = 0;
            CRC32 crc = new CRC32();
            this.vintAudioCheckSum = 0;
            if (this.OpenFileStreamR())
            {
                this.OpenBinaryReader();
                length = (int) this.FI.Length;
                vintStart = 0;
                if (this.V1TAG.TAGPresent)
                {
                    length -= 0x80;
                }
                if (this.V2TAG.TAGHeaderPresent)
                {
                    vintStart = IntegerType.FromObject(Interaction.IIf(this.V2TAG.FooterPresent, this.V2TAG.TAGSize + 20, this.V2TAG.TAGSize + 10));
                }
                this.vintAudioCheckSum = crc.CRC32(0, ref this.FStream, vintStart, length - vintStart);
                this.CloseBinaryReader();
                this.CloseFileStream();
            }
            else
            {
                this.vintAudioCheckSum = 0;
            }
        }

        public MP3 Clone()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream serializationStream = new MemoryStream();
            formatter.Serialize(serializationStream, this);
            serializationStream.Position = 0L;
            return (MP3) formatter.Deserialize(serializationStream);
        }

        public bool ExploreMP3()
        {
            if (this.OpenFileStreamR())
            {
                this.OpenBinaryReader();
                this.ReadV1TAG();
                this.ReadV2TAG();
                this.GetMP3Header(IntegerType.FromObject(Interaction.IIf(this.V2TAG.TAGSize == 0, 0, this.V2TAG.TAGSize + 10)));
                this.CloseBinaryReader();
                this.CloseFileStream();
                return true;
            }
            return false;
        }

        public bool ExploreMP3TAGs()
        {
            if (this.OpenFileStreamR())
            {
                this.OpenBinaryReader();
                this.ReadV1TAG();
                this.ReadV2TAG();
                this.CloseBinaryReader();
                this.CloseFileStream();
                return true;
            }
            return false;
        }

        public void GetMP3Header(int vintStartPos)
        {
            MP3Frame frame;
            byte samplerateValue;
            if (vintStartPos >= (this.FI.Length - 4L))
            {
                return;
            }
            bool flag = false;
            byte[] array = new byte[4];
            this.FStream.Seek((long) vintStartPos, SeekOrigin.Begin);
            if (this.FStream.Read(array, 0, 4) < 4)
            {
                return;
            }
            int index = 1;
        Label_0046:
            if ((array[0] == 0xff) & (array[1] >= 240))
            {
                frame = new MP3Frame();
                if (!frame.GetFrame(ref this.FStream, ref array, true))
                {
                    this.FStream.Seek(-3L, SeekOrigin.Current);
                    if (this.FStream.Read(array, 0, 4) < 4)
                    {
                        return;
                    }
                    goto Label_010C;
                }
                flag = true;
                this.vbytVersion = frame.Version;
                this.vbytLayer = frame.Layer;
                this.vintSamplerate = frame.Samplerate;
                this.vbytChannel = frame.Channel;
                samplerateValue = frame.SamplerateValue;
                goto Label_011B;
            }
            this.FStream.Seek(-3L, SeekOrigin.Current);
            if (this.FStream.Read(array, 0, 4) < 4)
            {
                return;
            }
        Label_010C:
            index++;
            if (index <= 0x1000)
            {
                goto Label_0046;
            }
        Label_011B:
            if (!flag)
            {
                return;
            }
            if (frame.VBR)
            {
                this.vbooVBR = true;
                this.vintNumberOfFrames = frame.NumberOfFrames;
                if (this.vintNumberOfFrames != 0)
                {
                    this.vintBitrate = Convert.ToInt32(ObjectType.MulObj(ObjectType.DivObj(((double) (this.FI.Length - this.FStream.Position)) / ((double) this.vintNumberOfFrames), Interaction.IIf(this.vbytLayer == 3, 12, 0x90)), this.vintSamplerate));
                }
                else
                {
                    this.vintBitrate = frame.Bitrate;
                }
                if ((((this.vintBitrate != 0xf3e58) & (this.vintBitrate != 0)) & (this.vintSamplerate != 0x1869f)) & (this.vintSamplerate != 0))
                {
                    if ((this.vbytLayer == 1) | (this.vbytLayer == 2))
                    {
                        this.vintDuration = (int) Math.Round((double) Conversion.Fix((float) (this.vintNumberOfFrames * Declarations.asinBaseLenLayer23[samplerateValue])));
                        this.vintDurationMS = (int) Math.Round((double) Conversion.Fix((float) ((this.vintNumberOfFrames * Declarations.asinBaseLenLayer23[samplerateValue]) * 1000f)));
                    }
                    else if (this.vbytLayer == 3)
                    {
                        this.vintDuration = (int) Math.Round((double) Conversion.Fix((float) (this.vintNumberOfFrames * Declarations.asinBaseLenLayer1[samplerateValue])));
                        this.vintDurationMS = (int) Math.Round((double) Conversion.Fix((float) ((this.vintNumberOfFrames * Declarations.asinBaseLenLayer1[samplerateValue]) * 1000f)));
                    }
                }
            }
            else
            {
                int[] numArray = new int[450];
                int num4 = 0;
                int num3 = 0;
                long num6 = 0L;
                int num5 = 0;
                numArray[0] = frame.Bitrate;
                this.FStream.Seek((long) (frame.FrameLength - 4), SeekOrigin.Current);
                do
                {
                    MP3Frame frame2 = new MP3Frame();
                    if (this.FStream.Read(array, 0, 4) < 4)
                    {
                        numArray = (int[]) Utils.CopyArray((Array) numArray, new int[num4 + 1]);
                        break;
                    }
                    if ((array[0] == 0xff) & (array[1] >= 240))
                    {
                        if (frame2.GetFrame(ref this.FStream, ref array, false))
                        {
                            num4++;
                            num5 = 0;
                            numArray[num4] = frame2.Bitrate;
                            if (numArray[num4] != numArray[num4 - 1])
                            {
                                num3++;
                            }
                            this.FStream.Seek((long) (frame2.FrameLength - 4), SeekOrigin.Current);
                        }
                        else
                        {
                            this.FStream.Seek(-3L, SeekOrigin.Current);
                            num5++;
                        }
                    }
                    else
                    {
                        this.FStream.Seek(-3L, SeekOrigin.Current);
                        num5++;
                    }
                }
                while (((num4 != 80) || (num3 != 0)) && ((num5 <= 0x1000) && (num4 != 0x1c1)));
                this.vbooVBR = num3 >= 7;
                if (!this.vbooVBR)
                {
                    this.vintBitrate = Declarations.aintBitrateLookup[((this.vbytVersion & 1) * 4) | this.vbytLayer, frame.BitrateValue] * 0x3e8;
                }
                else
                {
                    int num8 = num4;
                    for (index = 0; index <= num8; index++)
                    {
                        num6 += numArray[index];
                    }
                    Array.Sort(numArray);
                    byte num7 = 0;
                    for (index = num4; index >= 1; index += -1)
                    {
                        if (numArray[index] != numArray[index - 1])
                        {
                            num7 = (byte) (num7 + 1);
                        }
                        if (num7 == 2)
                        {
                            num6 += numArray[index - 1] * (num4 / 2);
                            num4 += num4 / 2;
                            break;
                        }
                    }
                    this.vintBitrate = Convert.ToInt32((double) (Math.Round((double) ((((double) num6) / 1000.0) / ((double) num4)), 0) * 1000.0));
                }
                if ((((this.vintBitrate != 0xf3e58) & (this.vintBitrate != 0)) & (this.vintSamplerate != 0x1869f)) & (this.vintSamplerate != 0))
                {
                    this.vintDuration = (int) Math.Round(Conversion.Fix((double) (((double) ((this.FI.Length - vintStartPos) * 8L)) / ((double) this.vintBitrate))));
                    this.vintDurationMS = (int) Math.Round(Conversion.Fix((double) (((double) ((this.FI.Length - vintStartPos) * 0x1f40L)) / ((double) this.vintBitrate))));
                }
            }
        }

        public void ReadV1TAG()
        {
            MP3 mp = this;
            this.V1TAG.ReadTAG(ref mp);
        }

        public void ReadV2TAG()
        {
            MP3 mp = this;
            this.V2TAG.ReadTAG(ref mp);
        }

        public void RemoveV1TAG()
        {
            this.V1TAG = null;
            this.V1TAG = new ID3_TagIT.V1TAG();
        }

        public void RemoveV2TAG()
        {
            this.V2TAG = null;
            this.V2TAG = new ID3_TagIT.V2TAG();
        }

        public bool WriteChanges()
        {
            int num;
            bool flag = false;
            this.FI.Refresh();
            if ((this.FI.Attributes & FileAttributes.ReadOnly) > 0)
            {
                if (!Declarations.objSettings.IgnoreWrite)
                {
                    return false;
                }
                flag = true;
                this.FI.Attributes ^= FileAttributes.ReadOnly;
            }
            DateTime lastWriteTime = this.FI.LastWriteTime;
            if (!this.OpenFileStreamRW())
            {
                return false;
            }
            this.CloseFileStream();
            MP3 mp = this;
            int vintRelEnd = this.V1TAG.WriteTAG(ref mp);
            this.FI.Refresh();
            if (vintRelEnd == -1)
            {
                return false;
            }
            if (this.V2TAG.TAGVersion != 2)
            {
                mp = this;
                num = this.V2TAG.WriteTAG(ref mp);
                this.FI.Refresh();
                if (num == -1)
                {
                    return false;
                }
            }
            else
            {
                num = 0;
            }
            if (((num + vintRelEnd) != 0) && !this.TrimFile(num, vintRelEnd))
            {
                return false;
            }
            if (StringType.StrCmp(this.FI.FullName, this.CurrentFullName, false) != 0)
            {
                try
                {
                    this.FI.MoveTo(this.CurrentFullName);
                    this.FI.Refresh();
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    this.FI.Refresh();
                    if (Declarations.objSettings.RestoreDate)
                    {
                        this.FI.LastWriteTime = lastWriteTime;
                    }
                    if (flag)
                    {
                        this.FI.Attributes ^= FileAttributes.ReadOnly;
                    }
                    this.FI.Refresh();
                    ProjectData.ClearProjectError();
                    return false;
                }
                foreach (V2APICFrame frame in this.V2TAG.GetFrames("APIC"))
                {
                    if (frame.Include)
                    {
                        frame.Path = this.FI.FullName;
                    }
                }
            }
            if (Declarations.objSettings.RestoreDate)
            {
                this.FI.LastWriteTime = lastWriteTime;
            }
            if (flag)
            {
                this.FI.Attributes ^= FileAttributes.ReadOnly;
            }
            this.Changed = false;
            this.FI.Refresh();
            return true;
        }

        public int AudioCheckSum
        {
            get
            {
                return this.vintAudioCheckSum;
            }
            set
            {
                this.vintAudioCheckSum = value;
            }
        }

        public int Bitrate
        {
            get
            {
                return this.vintBitrate;
            }
        }

        public bool Changed
        {
            get
            {
                return this.vbooChanged;
            }
            set
            {
                this.vbooChanged = value;
            }
        }

        public byte Channel
        {
            get
            {
                return this.vbytChannel;
            }
        }

        public string ChannelText
        {
            get
            {
                string str;
                switch (this.vbytChannel)
                {
                    case 0:
                        return "Stereo";

                    case 1:
                        return "Joint Stereo";

                    case 2:
                        return "Dual Channel";

                    case 3:
                        return "Mono";
                }
                return str;
            }
        }

        public bool Doubled
        {
            get
            {
                return this.vbooDouble;
            }
            set
            {
                this.vbooDouble = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.vintDuration;
            }
        }

        public string DurationFormated
        {
            get
            {
                int num = this.vintDuration / 0xe10;
                num = (this.vintDuration - ((this.vintDuration / 0xe10) * 0xe10)) / 60;
                string introduced3 = num.ToString().PadLeft(2, '0') + ":";
                num = (this.vintDuration - ((this.vintDuration / 0xe10) * 0xe10)) - (((this.vintDuration - ((this.vintDuration / 0xe10) * 0xe10)) / 60) * 60);
                string introduced4 = introduced3 + num.ToString().PadLeft(2, '0') + ":";
                return (introduced4 + num.ToString().PadLeft(2, '0'));
            }
        }

        public int DurationMS
        {
            get
            {
                return this.vintDurationMS;
            }
        }

        public bool FileTAGCompare
        {
            get
            {
                return this.vbooFileTAGCompare;
            }
            set
            {
                this.vbooFileTAGCompare = value;
            }
        }

        public byte Layer
        {
            get
            {
                return this.vbytLayer;
            }
        }

        public string LayerText
        {
            get
            {
                string str;
                switch (this.vbytLayer)
                {
                    case 1:
                        return "Layer III";

                    case 2:
                        return "Layer II";

                    case 3:
                        return "Layer I";
                }
                return str;
            }
        }

        public int NumberOfFrames
        {
            get
            {
                return this.vintNumberOfFrames;
            }
        }

        public int Samplerate
        {
            get
            {
                return this.vintSamplerate;
            }
        }

        public bool Selected
        {
            get
            {
                return this.vbooSelected;
            }
            set
            {
                this.vbooSelected = value;
            }
        }

        public bool VBR
        {
            get
            {
                return this.vbooVBR;
            }
        }

        public byte Version
        {
            get
            {
                return this.vbytVersion;
            }
        }

        public string VersionText
        {
            get
            {
                string str;
                switch (this.vbytVersion)
                {
                    case 0:
                        return "MPEG-2.5";

                    case 1:
                        return str;

                    case 2:
                        return "MPEG-2.0";

                    case 3:
                        return "MPEG-1.0";
                }
                return str;
            }
        }
    }
}

