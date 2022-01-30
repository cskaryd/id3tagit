namespace ID3_TagIT
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;

    [Serializable]
    public class V2FrameHeader
    {
        private int I = 0;
        private bool vbooCompressed = false;
        private bool vbooDataLenIndPresent = false;
        private bool vbooEncrypted = false;
        private bool vbooFileAlter = false;
        private bool vbooGroupIDPresent = false;
        private bool vbooReadOnly = false;
        private bool vbooRemove = false;
        private bool vbooTAGAlter = false;
        private bool vbooUnsyncUsed = false;
        private byte vbytEncryption = 0;
        private byte vbytGroupID = 0;
        private byte vbytNumberOfInfoBytes = 0;
        private int vintDataLength = 0;
        private long vlngFrameSize = 0L;
        private string vstrFrameID;

        public byte[] CreateFrameHeader(MP3 MP3, byte[] abytContent, int vintPurSize)
        {
            byte[] buffer;
            int num;
            long length = abytContent.Length;
            byte num2 = 0;
            byte num3 = 0;
            switch (MP3.V2TAG.TAGVersion)
            {
                case 3:
                    if (this.vbooDataLenIndPresent)
                    {
                        this.vbooDataLenIndPresent = false;
                        this.vbooCompressed = false;
                        this.vintDataLength = 0;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes - 4);
                        break;
                    }
                    if (this.vbooCompressed)
                    {
                        this.vbooCompressed = false;
                        this.vintDataLength = 0;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes - 4);
                    }
                    break;

                case 4:
                    if (this.vbooCompressed)
                    {
                        this.vbooCompressed = false;
                    }
                    if (this.vbooEncrypted)
                    {
                        this.vbooEncrypted = false;
                        this.vbytEncryption = 0;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes - 1);
                    }
                    if (this.vbooDataLenIndPresent && !((this.vbooCompressed | this.vbooEncrypted) | this.vbooUnsyncUsed))
                    {
                        this.vbooDataLenIndPresent = false;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes - 4);
                        this.vintDataLength = 0;
                    }
                    length += this.vbytNumberOfInfoBytes;
                    buffer = new byte[(9 + this.vbytNumberOfInfoBytes) + 1];
                    num = 0;
                    do
                    {
                        buffer[num] = (byte) Strings.Asc(this.vstrFrameID.Substring(num, 1));
                        num++;
                    }
                    while (num <= 3);
                    num = 3;
                    do
                    {
                        buffer[7 - num] = (byte) (length / ((long) Math.Round(Math.Pow(128.0, (double) num))));
                        length = (long) Math.Round((double) (length - ((length / ((long) Math.Round(Math.Pow(128.0, (double) num)))) * Math.Pow(128.0, (double) num))));
                        num += -1;
                    }
                    while (num >= 1);
                    buffer[7] = (byte) length;
                    num2 = ByteType.FromObject(ObjectType.BitOrObj(ByteType.FromObject(ObjectType.BitOrObj(ByteType.FromObject(ObjectType.BitOrObj(num2, Interaction.IIf(this.vbooTAGAlter, 0x40, 0))), Interaction.IIf(this.vbooFileAlter, 0x20, 0))), Interaction.IIf(this.vbooReadOnly, 0x10, 0)));
                    num3 = ByteType.FromObject(ObjectType.BitOrObj(ByteType.FromObject(ObjectType.BitOrObj(ByteType.FromObject(ObjectType.BitOrObj(num3, Interaction.IIf(this.vbooGroupIDPresent, 0x40, 0))), Interaction.IIf(this.vbooUnsyncUsed, 2, 0))), Interaction.IIf(this.vbooDataLenIndPresent, 1, 0)));
                    buffer[8] = num2;
                    buffer[9] = num3;
                    if (this.vbooGroupIDPresent)
                    {
                        buffer[10] = this.vbytGroupID;
                    }
                    if (this.vbooDataLenIndPresent)
                    {
                        num = 3;
                        do
                        {
                            buffer[buffer.GetUpperBound(0) - num] = (byte) (((long) vintPurSize) / ((long) Math.Round(Math.Pow(128.0, (double) num))));
                            vintPurSize = (int) Math.Round((double) (vintPurSize - ((((long) vintPurSize) / ((long) Math.Round(Math.Pow(128.0, (double) num)))) * Math.Pow(128.0, (double) num))));
                            num += -1;
                        }
                        while (num >= 1);
                        buffer[buffer.GetUpperBound(0)] = (byte) vintPurSize;
                    }
                    return buffer;

                default:
                    return buffer;
            }
            if (this.vbooEncrypted)
            {
                this.vbooEncrypted = false;
                this.vbytEncryption = 0;
                this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes - 1);
            }
            this.vbooUnsyncUsed = false;
            length += this.vbytNumberOfInfoBytes;
            buffer = new byte[(9 + this.vbytNumberOfInfoBytes) + 1];
            num = 0;
            do
            {
                buffer[num] = (byte) Strings.Asc(this.vstrFrameID.Substring(num, 1));
                num++;
            }
            while (num <= 3);
            num = 3;
            do
            {
                buffer[7 - num] = (byte) (length / ((long) Math.Round(Math.Pow(256.0, (double) num))));
                length = (long) Math.Round((double) (length - ((length / ((long) Math.Round(Math.Pow(256.0, (double) num)))) * Math.Pow(256.0, (double) num))));
                num += -1;
            }
            while (num >= 1);
            buffer[7] = (byte) length;
            num2 = ByteType.FromObject(ObjectType.BitOrObj(ByteType.FromObject(ObjectType.BitOrObj(ByteType.FromObject(ObjectType.BitOrObj(num2, Interaction.IIf(this.vbooTAGAlter, 0x80, 0))), Interaction.IIf(this.vbooFileAlter, 0x40, 0))), Interaction.IIf(this.vbooReadOnly, 0x20, 0)));
            num3 = ByteType.FromObject(ObjectType.BitOrObj(num3, Interaction.IIf(this.vbooGroupIDPresent, 0x20, 0)));
            buffer[8] = num2;
            buffer[9] = num3;
            if (this.vbooGroupIDPresent)
            {
                buffer[10] = this.vbytGroupID;
            }
            return buffer;
        }

        public bool GetFrameHeader(ref MP3 MP3, ref MemoryStream mstrTAG)
        {
            byte[] buffer = new byte[10];
            this.vbytNumberOfInfoBytes = 0;
            mstrTAG.Read(buffer, 0, 10);
            this.vstrFrameID = StringType.FromChar(Convert.ToChar(buffer[0])) + StringType.FromChar(Convert.ToChar(buffer[1])) + StringType.FromChar(Convert.ToChar(buffer[2])) + StringType.FromChar(Convert.ToChar(buffer[3]));
            switch (MP3.V2TAG.TAGVersion)
            {
                case 3:
                    this.vlngFrameSize = 0L;
                    this.I = 3;
                    do
                    {
                        this.vlngFrameSize = (long) Math.Round((double) (this.vlngFrameSize + (Math.Pow(256.0, (double) this.I) * buffer[7 - this.I])));
                        this.I += -1;
                    }
                    while (this.I >= 0);
                    if (this.vlngFrameSize > (mstrTAG.Length - mstrTAG.Position))
                    {
                        return false;
                    }
                    this.vbytNumberOfInfoBytes = 0;
                    if ((buffer[8] & 0x80) > 0)
                    {
                        this.vbooTAGAlter = true;
                    }
                    else
                    {
                        this.vbooTAGAlter = false;
                    }
                    if ((buffer[8] & 0x40) > 0)
                    {
                        this.vbooFileAlter = true;
                    }
                    else
                    {
                        this.vbooFileAlter = false;
                    }
                    if ((buffer[8] & 0x20) > 0)
                    {
                        this.vbooReadOnly = true;
                    }
                    else
                    {
                        this.vbooReadOnly = false;
                    }
                    if ((buffer[9] & 0x80) > 0)
                    {
                        this.vbooCompressed = true;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes + 4);
                    }
                    else
                    {
                        this.vbooCompressed = false;
                    }
                    if ((buffer[9] & 0x40) > 0)
                    {
                        this.vbooEncrypted = true;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes + 1);
                    }
                    else
                    {
                        this.vbooEncrypted = false;
                    }
                    if ((buffer[9] & 0x20) > 0)
                    {
                        this.vbooGroupIDPresent = true;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes + 1);
                    }
                    else
                    {
                        this.vbooGroupIDPresent = false;
                    }
                    if (this.vbytNumberOfInfoBytes > 0)
                    {
                        this.vintDataLength = 0;
                        buffer = new byte[(this.vbytNumberOfInfoBytes - 1) + 1];
                        mstrTAG.Read(buffer, 0, this.vbytNumberOfInfoBytes);
                        if (!this.vbooCompressed)
                        {
                            this.vintDataLength = 0;
                            if (this.vbooEncrypted)
                            {
                                this.vbytEncryption = buffer[0];
                                if (this.vbooGroupIDPresent)
                                {
                                    this.vbytGroupID = buffer[1];
                                }
                                else
                                {
                                    this.vbytGroupID = 0;
                                }
                            }
                            else
                            {
                                this.vbytEncryption = 0;
                                if (this.vbooGroupIDPresent)
                                {
                                    this.vbytGroupID = buffer[0];
                                }
                                else
                                {
                                    this.vbytGroupID = 0;
                                }
                            }
                            break;
                        }
                        this.I = 3;
                        do
                        {
                            this.vintDataLength = (int) Math.Round((double) (this.vintDataLength + (Math.Pow(256.0, (double) this.I) * buffer[3 - this.I])));
                            this.I += -1;
                        }
                        while (this.I >= 0);
                        if (this.vbooEncrypted)
                        {
                            this.vbytEncryption = buffer[4];
                            if (this.vbooGroupIDPresent)
                            {
                                this.vbytGroupID = buffer[5];
                            }
                            else
                            {
                                this.vbytGroupID = 0;
                            }
                        }
                        else
                        {
                            this.vbytEncryption = 0;
                            if (this.vbooGroupIDPresent)
                            {
                                this.vbytGroupID = buffer[4];
                            }
                            else
                            {
                                this.vbytGroupID = 0;
                            }
                        }
                    }
                    break;

                case 4:
                    this.vlngFrameSize = 0L;
                    this.I = 3;
                    do
                    {
                        this.vlngFrameSize = (long) Math.Round((double) (this.vlngFrameSize + (Math.Pow(128.0, (double) this.I) * buffer[7 - this.I])));
                        this.I += -1;
                    }
                    while (this.I >= 0);
                    if (this.vlngFrameSize > (mstrTAG.Length - mstrTAG.Position))
                    {
                        return false;
                    }
                    this.vbytNumberOfInfoBytes = 0;
                    if ((buffer[8] & 0x40) > 0)
                    {
                        this.vbooTAGAlter = true;
                    }
                    else
                    {
                        this.vbooTAGAlter = false;
                    }
                    if ((buffer[8] & 0x20) > 0)
                    {
                        this.vbooFileAlter = true;
                    }
                    else
                    {
                        this.vbooFileAlter = false;
                    }
                    if ((buffer[8] & 0x10) > 0)
                    {
                        this.vbooReadOnly = true;
                    }
                    else
                    {
                        this.vbooReadOnly = false;
                    }
                    if ((buffer[9] & 0x40) > 0)
                    {
                        this.vbooGroupIDPresent = true;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes + 1);
                    }
                    else
                    {
                        this.vbooGroupIDPresent = false;
                    }
                    if ((buffer[9] & 8) > 0)
                    {
                        this.vbooCompressed = true;
                    }
                    else
                    {
                        this.vbooCompressed = false;
                    }
                    if ((buffer[9] & 4) > 0)
                    {
                        this.vbooEncrypted = true;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes + 1);
                    }
                    else
                    {
                        this.vbooEncrypted = false;
                    }
                    if ((buffer[9] & 2) > 0)
                    {
                        this.vbooUnsyncUsed = true;
                    }
                    else
                    {
                        this.vbooUnsyncUsed = false;
                    }
                    if ((buffer[9] & 1) > 0)
                    {
                        this.vbooDataLenIndPresent = true;
                        this.vbytNumberOfInfoBytes = (byte) (this.vbytNumberOfInfoBytes + 4);
                    }
                    else
                    {
                        this.vbooDataLenIndPresent = false;
                    }
                    if (this.vbytNumberOfInfoBytes > 0)
                    {
                        this.vintDataLength = 0;
                        buffer = new byte[(this.vbytNumberOfInfoBytes - 1) + 1];
                        mstrTAG.Read(buffer, 0, this.vbytNumberOfInfoBytes);
                        if (this.vbooGroupIDPresent)
                        {
                            this.vbytGroupID = buffer[0];
                            if (this.vbooEncrypted)
                            {
                                this.vbytEncryption = buffer[1];
                                if (this.vbooDataLenIndPresent)
                                {
                                    this.I = 3;
                                    do
                                    {
                                        this.vintDataLength = (int) Math.Round((double) (this.vintDataLength + (Math.Pow(128.0, (double) this.I) * buffer[buffer.GetUpperBound(0) - this.I])));
                                        this.I += -1;
                                    }
                                    while (this.I >= 0);
                                }
                            }
                            else
                            {
                                this.vbytEncryption = 0;
                                if (this.vbooDataLenIndPresent)
                                {
                                    this.I = 3;
                                    do
                                    {
                                        this.vintDataLength = (int) Math.Round((double) (this.vintDataLength + (Math.Pow(128.0, (double) this.I) * buffer[buffer.GetUpperBound(0) - this.I])));
                                        this.I += -1;
                                    }
                                    while (this.I >= 0);
                                }
                            }
                        }
                        else
                        {
                            this.vbytGroupID = 0;
                            if (this.vbooEncrypted)
                            {
                                this.vbytEncryption = buffer[0];
                                if (this.vbooDataLenIndPresent)
                                {
                                    this.I = 3;
                                    do
                                    {
                                        this.vintDataLength = (int) Math.Round((double) (this.vintDataLength + (Math.Pow(128.0, (double) this.I) * buffer[buffer.GetUpperBound(0) - this.I])));
                                        this.I += -1;
                                    }
                                    while (this.I >= 0);
                                }
                            }
                            else
                            {
                                this.vbytEncryption = 0;
                                if (this.vbooDataLenIndPresent)
                                {
                                    this.I = 3;
                                    do
                                    {
                                        this.vintDataLength = (int) Math.Round((double) (this.vintDataLength + (Math.Pow(128.0, (double) this.I) * buffer[buffer.GetUpperBound(0) - this.I])));
                                        this.I += -1;
                                    }
                                    while (this.I >= 0);
                                }
                            }
                        }
                    }
                    break;
            }
            return true;
        }

        public bool FCompressed
        {
            get
            {
                return this.vbooCompressed;
            }
            set
            {
                this.vbooCompressed = value;
            }
        }

        public int FDataLength
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

        public bool FDataLenIndPresent
        {
            get
            {
                return this.vbooDataLenIndPresent;
            }
            set
            {
                this.vbooDataLenIndPresent = value;
            }
        }

        public bool FEncrypted
        {
            get
            {
                return this.vbooEncrypted;
            }
            set
            {
                this.vbooEncrypted = value;
            }
        }

        public byte FEncryption
        {
            get
            {
                return this.vbytEncryption;
            }
            set
            {
                this.vbytEncryption = value;
            }
        }

        public bool FFileAlter
        {
            get
            {
                return this.vbooFileAlter;
            }
            set
            {
                this.vbooFileAlter = value;
            }
        }

        public byte FGroupID
        {
            get
            {
                return this.vbytGroupID;
            }
            set
            {
                this.vbytGroupID = value;
            }
        }

        public bool FGroupIDPresent
        {
            get
            {
                return this.vbooGroupIDPresent;
            }
            set
            {
                this.vbooGroupIDPresent = value;
            }
        }

        public string FID
        {
            get
            {
                return this.vstrFrameID;
            }
            set
            {
                this.vstrFrameID = value;
            }
        }

        public byte FNumberOfInfoBytes
        {
            get
            {
                return this.vbytNumberOfInfoBytes;
            }
            set
            {
                this.vbytNumberOfInfoBytes = value;
            }
        }

        public bool FReadOnly
        {
            get
            {
                return this.vbooReadOnly;
            }
            set
            {
                this.vbooReadOnly = value;
            }
        }

        public long FSize
        {
            get
            {
                return this.vlngFrameSize;
            }
            set
            {
                this.vlngFrameSize = value;
            }
        }

        public bool FTAGAlter
        {
            get
            {
                return this.vbooTAGAlter;
            }
            set
            {
                this.vbooTAGAlter = value;
            }
        }

        public bool FUnsyncUsed
        {
            get
            {
                return this.vbooUnsyncUsed;
            }
            set
            {
                this.vbooUnsyncUsed = value;
            }
        }

        public bool Remove
        {
            get
            {
                return this.vbooRemove;
            }
            set
            {
                this.vbooRemove = value;
            }
        }
    }
}

