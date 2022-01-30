using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;

namespace ID3_TagIT
{
  [Serializable]
  public class V2TAGHeader
  {
    private int I = 0;
    private bool vbooExperimental = false;
    private bool vbooExtHeaderCRCPresent = false;
    private bool vbooExtHeaderPresent = false;
    private bool vbooExtHeaderRestrictPresent = false;
    private bool vbooExtHeaderTAGIsUpdate = false;
    private bool vbooFooterPresent = false;
    private bool vbooTAGHeaderPresent = false;
    private bool vbooUnsync = false;
    private byte vbytExtHeaderRestrictImageEnc = 0;
    private byte vbytExtHeaderRestrictImageSize = 0;
    private byte vbytExtHeaderRestrictTAGSize = 0;
    private byte vbytExtHeaderRestrictTextEnc = 0;
    private byte vbytExtHeaderRestrictTextSize = 0;
    private byte vbytTAGSubVersion = 0;
    private byte vbytTAGVersion = 0;
    private int vintExtHeaderPaddingSize = 0;
    private int vintExtHeaderSize = 0;
    private int vintTAGSize = 0;
    private long vlngExtHeaderCRCData = 0L;

    public byte[] CreateTAGHeader(MP3 MP3, byte[] abytTAG, int vintPadAdded)
    {
      byte[] buffer = null;
      int num;
      byte[] sourceArray = new byte[] { 0x49, 0x44, 0x33, 0, 0, 0, 0, 0, 0, 0 };
      int length = abytTAG.Length;
      CRC32 crc = new CRC32();
      this.vbooUnsync = Declarations.objSettings.WriteUnsync;
      sourceArray[3] = this.vbytTAGVersion;
      sourceArray[4] = this.vbytTAGSubVersion;

      if (this.vbooUnsync)
        sourceArray[5] = (byte)(sourceArray[5] | 0x80);

      if (this.vbooExperimental)
        sourceArray[5] = (byte)(sourceArray[5] | 0x20);

      if (this.vbooFooterPresent)
        sourceArray[5] = (byte)(sourceArray[5] | 0x10);

      if (this.vbooExtHeaderPresent)
      {
        int num2;
        byte[] buffer4 = null;
        sourceArray[5] = (byte)(sourceArray[5] | 0x40);

        switch (MP3.V2TAG.TAGVersion)
        {
          case 3:
            buffer4 = new byte[((abytTAG.Length - vintPadAdded) - 1) + 1];
            Array.Copy(abytTAG, 0, buffer4, 0, buffer4.Length);

            if (this.vbooExtHeaderCRCPresent)
            {
              buffer = new byte[14];
              buffer[3] = 10;
              buffer[4] = 0x80;
              num2 = crc.CRC_32(0, ref buffer4, (long)buffer4.GetUpperBound(0));
              num = 3;

              do
              {
                buffer[13 - num] = (byte)(((long)num2) / ((long)Math.Round(Math.Pow(256.0, (double)num))));
                num2 = (int)Math.Round((double)(num2 - ((((long)num2) / ((long)Math.Round(Math.Pow(256.0, (double)num)))) * Math.Pow(256.0, (double)num))));
                num += -1;
              }
              while (num >= 1);
              buffer[13] = (byte)num2;
              num = 3;

              do
              {
                buffer[9 - num] = (byte)(((long)vintPadAdded) / ((long)Math.Round(Math.Pow(256.0, (double)num))));
                vintPadAdded = (int)Math.Round((double)(vintPadAdded - ((((long)vintPadAdded) / ((long)Math.Round(Math.Pow(256.0, (double)num)))) * Math.Pow(256.0, (double)num))));
                num += -1;
              }
              while (num >= 1);
              buffer[9] = (byte)vintPadAdded;
              length += buffer.Length;
            }
            else
            {
              buffer = new byte[10];
              buffer[3] = 6;
              num = 3;
              do
              {
                buffer[9 - num] = (byte)(((long)vintPadAdded) / ((long)Math.Round(Math.Pow(256.0, (double)num))));
                vintPadAdded = (int)Math.Round((double)(vintPadAdded - ((((long)vintPadAdded) / ((long)Math.Round(Math.Pow(256.0, (double)num)))) * Math.Pow(256.0, (double)num))));
                num += -1;
              }
              while (num >= 1);
              buffer[9] = (byte)vintPadAdded;
              length += buffer.Length;
            }
            break;

          case 4:
            buffer = new byte[IntegerType.FromObject(ObjectType.AddObj(5, Interaction.IIf(this.vbooExtHeaderCRCPresent, 5, 0))) + 1];
            buffer[3] = ByteType.FromObject(ObjectType.AddObj(6, Interaction.IIf(this.vbooExtHeaderCRCPresent, 5, 0)));
            buffer[4] = 1;

            if (this.vbooExtHeaderTAGIsUpdate)
              buffer[5] = (byte)(buffer[5] | 0x40);

            if (this.vbooExtHeaderCRCPresent)
            {
              buffer[5] = (byte)(buffer[5] | 0x20);
              num2 = crc.CRC_32(0, ref buffer4, (long)buffer4.GetUpperBound(0));
              num = 4;
              do
              {
                buffer[10 - num] = (byte)(((long)num2) / ((long)Math.Round(Math.Pow(128.0, (double)num))));
                num2 = (int)Math.Round((double)(num2 - ((((long)num2) / ((long)Math.Round(Math.Pow(128.0, (double)num)))) * Math.Pow(128.0, (double)num))));
                num += -1;
              }
              while (num >= 1);
              buffer[10] = (byte)num2;
            }
            length += buffer.Length;
            break;
        }
      }

      if (!this.vbooExtHeaderPresent)
      {
        num = 3;
        do
        {
          sourceArray[9 - num] = (byte)(((long)length) / ((long)Math.Round(Math.Pow(128.0, (double)num))));
          length = (int)Math.Round((double)(length - ((((long)length) / ((long)Math.Round(Math.Pow(128.0, (double)num)))) * Math.Pow(128.0, (double)num))));
          num += -1;
        }
        while (num >= 1);
        sourceArray[9] = (byte)length;
        return sourceArray;
      }

      byte[] destinationArray = new byte[(buffer.Length + 9) + 1];
      num = 3;
      do
      {
        sourceArray[9 - num] = (byte)(((long)length) / ((long)Math.Round(Math.Pow(128.0, (double)num))));
        length = (int)Math.Round((double)(length - ((((long)length) / ((long)Math.Round(Math.Pow(128.0, (double)num)))) * Math.Pow(128.0, (double)num))));
        num += -1;
      }
      while (num >= 1);

      sourceArray[9] = (byte)length;
      Array.Copy(sourceArray, 0, destinationArray, 0, 10);
      Array.Copy(buffer, 0, destinationArray, 10, buffer.Length);
      return destinationArray;
    }

    public bool GetTAGHeader(ref MP3 MP3)
    {
      if (MP3.FI.Length < 10L)
        return false;

      byte[] abytBuffer = MP3.ReadData(0, SeekOrigin.Begin, 10);
      if (StringType.StrCmp(StringType.FromChar(Convert.ToChar(abytBuffer[0])) + StringType.FromChar(Convert.ToChar(abytBuffer[1])) + StringType.FromChar(Convert.ToChar(abytBuffer[2])), "ID3", false) != 0)
      {
        this.vbooTAGHeaderPresent = false;
        this.vbooUnsync = false;
        this.vbooExperimental = false;
        this.vbooFooterPresent = false;
        this.vbytTAGVersion = 0;
        this.vbytTAGSubVersion = 0;
        this.vintTAGSize = 0;
        this.vbooExtHeaderPresent = false;
        this.vintExtHeaderSize = 0;
        this.vintExtHeaderPaddingSize = 0;
        this.vbooExtHeaderTAGIsUpdate = false;
        this.vbooExtHeaderCRCPresent = false;
        this.vlngExtHeaderCRCData = 0L;
        this.vbooExtHeaderRestrictPresent = false;
        this.vbytExtHeaderRestrictTAGSize = 0;
        this.vbytExtHeaderRestrictTextEnc = 0;
        this.vbytExtHeaderRestrictTextSize = 0;
        this.vbytExtHeaderRestrictImageEnc = 0;
        this.vbytExtHeaderRestrictImageSize = 0;
      }
      else
      {
        this.vbooTAGHeaderPresent = true;
        this.vintTAGSize = 0;
        this.I = 3;

        do
        {
          this.vintTAGSize = (int)Math.Round((double)(this.vintTAGSize + (Math.Pow(128.0, (double)this.I) * abytBuffer[9 - this.I])));
          this.I += -1;
        }

        while (this.I >= 0);

        if ((this.vintTAGSize + 10) > MP3.FI.Length)
        {
          this.vbooTAGHeaderPresent = false;
          return false;
        }

        this.vbytTAGVersion = abytBuffer[3];
        this.vbytTAGSubVersion = abytBuffer[4];

        if ((abytBuffer[5] & 0x80) > 0)
          this.vbooUnsync = true;
        else
          this.vbooUnsync = false;

        if ((abytBuffer[5] & 0x40) > 0)
          this.vbooExtHeaderPresent = true;
        else
          this.vbooExtHeaderPresent = false;

        if ((abytBuffer[5] & 0x20) > 0)
          this.vbooExperimental = true;
        else
          this.vbooExperimental = false;

        if (((abytBuffer[5] & 0x10) > 0) & (this.vbytTAGVersion > 3))
          this.vbooFooterPresent = true;
        else
          this.vbooFooterPresent = false;

        if (this.vbooExtHeaderPresent)
        {
          abytBuffer = MP3.ReadData(10, SeekOrigin.Begin, this.TAGSize);
          if ((this.TAGVersion == 3) & this.Unsynchronisation)
            abytBuffer = ID3Functions.RemoveUnsync(abytBuffer);

          this.vintExtHeaderSize = 0;
          switch (this.vbytTAGVersion)
          {
            case 3:
              this.I = 3;
              do
              {
                this.vintExtHeaderSize = (int)Math.Round((double)(this.vintExtHeaderSize + (Math.Pow(256.0, (double)this.I) * abytBuffer[3 - this.I])));
                this.I += -1;
              }

              while (this.I >= 0);

              if ((this.vintExtHeaderSize - 10) >= this.TAGSize)
              {
                this.vbooExtHeaderPresent = false;
                this.vintExtHeaderSize = 0;
                this.vintExtHeaderPaddingSize = 0;
                this.vbooExtHeaderTAGIsUpdate = false;
                this.vbooExtHeaderCRCPresent = false;
                this.vlngExtHeaderCRCData = 0L;
                this.vbooExtHeaderRestrictPresent = false;
                this.vbytExtHeaderRestrictTAGSize = 0;
                this.vbytExtHeaderRestrictTextEnc = 0;
                this.vbytExtHeaderRestrictTextSize = 0;
                this.vbytExtHeaderRestrictImageEnc = 0;
                this.vbytExtHeaderRestrictImageSize = 0;
                MP3.BinReader.BaseStream.Seek(10L, SeekOrigin.Begin);

                return true;
              }

              if ((abytBuffer[4] & 0x80) > 0)
                this.vbooExtHeaderCRCPresent = true;
              else
                this.vbooExtHeaderCRCPresent = false;

              this.I = 3;
              do
              {
                this.vintExtHeaderPaddingSize = (int)Math.Round((double)(this.vintExtHeaderPaddingSize + (Math.Pow(256.0, (double)this.I) * abytBuffer[9 - this.I])));
                this.I += -1;
              }

              while (this.I >= 0);
              this.vlngExtHeaderCRCData = 0L;

              if (this.vbooExtHeaderCRCPresent)
              {
                this.I = 3;
                do
                {
                  this.vlngExtHeaderCRCData = (long)Math.Round((double)(this.vlngExtHeaderCRCData + (Math.Pow(256.0, (double)this.I) * abytBuffer[(this.vintExtHeaderSize + 4) - this.I])));
                  this.I += -1;
                }
                while (this.I >= 0);
              }

              MP3.BinReader.BaseStream.Seek((long)((10 + this.vintExtHeaderSize) + 4), SeekOrigin.Begin);
              break;

            case 4:
              byte num;
              this.I = 3;

              do
              {
                this.vintExtHeaderSize = (int)Math.Round((double)(this.vintExtHeaderSize + (Math.Pow(128.0, (double)this.I) * abytBuffer[3 - this.I])));
                this.I += -1;
              }

              while (this.I >= 0);

              if ((this.vintExtHeaderSize - 10) >= this.TAGSize)
              {
                this.vbooExtHeaderPresent = false;
                this.vintExtHeaderSize = 0;
                this.vintExtHeaderPaddingSize = 0;
                this.vbooExtHeaderTAGIsUpdate = false;
                this.vbooExtHeaderCRCPresent = false;
                this.vlngExtHeaderCRCData = 0L;
                this.vbooExtHeaderRestrictPresent = false;
                this.vbytExtHeaderRestrictTAGSize = 0;
                this.vbytExtHeaderRestrictTextEnc = 0;
                this.vbytExtHeaderRestrictTextSize = 0;
                this.vbytExtHeaderRestrictImageEnc = 0;
                this.vbytExtHeaderRestrictImageSize = 0;
                MP3.BinReader.BaseStream.Seek(10L, SeekOrigin.Begin);
                return true;
              }

              if ((abytBuffer[5] & 0x40) > 0)
              {
                this.vbooExtHeaderTAGIsUpdate = true;
                num = 7;
              }
              else
              {
                this.vbooExtHeaderTAGIsUpdate = false;
                num = 6;
              }

              if ((abytBuffer[5] & 0x20) > 0)
              {
                this.vbooExtHeaderCRCPresent = true;
                this.I = 4;
                do
                {
                  this.vlngExtHeaderCRCData = (long)Math.Round((double)(this.vlngExtHeaderCRCData + (Math.Pow(128.0, (double)this.I) * abytBuffer[(num + 5) - this.I])));
                  this.I += -1;
                }
                while (this.I >= 0);
                num = (byte)(num + 6);
              }
              else
              {
                this.vbooExtHeaderCRCPresent = false;
                this.vlngExtHeaderCRCData = 0L;
              }

              if ((abytBuffer[1] & 0x10) > 0)
              {
                this.vbooExtHeaderRestrictPresent = true;
                this.vbytExtHeaderRestrictTAGSize = (byte)((abytBuffer[num + 1] & 0xc0) / 0x40);
                this.vbytExtHeaderRestrictTextEnc = (byte)((abytBuffer[num + 1] & 0x20) / 0x20);
                this.vbytExtHeaderRestrictTextSize = (byte)((abytBuffer[num + 1] & 0x18) / 8);
                this.vbytExtHeaderRestrictImageEnc = (byte)((abytBuffer[num + 1] & 4) / 4);
                this.vbytExtHeaderRestrictImageSize = (byte)(abytBuffer[num + 1] & 3);
              }
              else
              {
                this.vbooExtHeaderRestrictPresent = false;
                this.vbytExtHeaderRestrictTAGSize = 0;
                this.vbytExtHeaderRestrictTextEnc = 0;
                this.vbytExtHeaderRestrictTextSize = 0;
                this.vbytExtHeaderRestrictImageEnc = 0;
                this.vbytExtHeaderRestrictImageSize = 0;
              }

              MP3.BinReader.BaseStream.Seek((long)(10 + this.vintExtHeaderSize), SeekOrigin.Begin);
              break;
          }
        }
      }
      return true;
    }

    public bool Experimental
    {
      get
      {
        return this.vbooExperimental;
      }
      set
      {
        this.vbooExperimental = value;
      }
    }

    public int ExtendedHeaderCRCData
    {
      get
      {
        return (int)this.vlngExtHeaderCRCData;
      }
      set
      {
        this.vlngExtHeaderCRCData = value;
      }
    }

    public bool ExtendedHeaderCRCPresent
    {
      get
      {
        return this.vbooExtHeaderCRCPresent;
      }
      set
      {
        this.vbooExtHeaderCRCPresent = value;
      }
    }

    public int ExtendedHeaderPaddingSize
    {
      get
      {
        return this.vintExtHeaderPaddingSize;
      }
      set
      {
        this.vintExtHeaderPaddingSize = value;
      }
    }

    public bool ExtendedHeaderPresent
    {
      get
      {
        return this.vbooExtHeaderPresent;
      }
      set
      {
        this.vbooExtHeaderPresent = value;
      }
    }

    public byte ExtendedHeaderRestrictImageEnc
    {
      get
      {
        return this.vbytExtHeaderRestrictImageEnc;
      }
      set
      {
        this.vbytExtHeaderRestrictImageEnc = value;
      }
    }

    public byte ExtendedHeaderRestrictImageSize
    {
      get
      {
        return this.vbytExtHeaderRestrictImageSize;
      }
      set
      {
        this.vbytExtHeaderRestrictImageSize = value;
      }
    }

    public bool ExtendedHeaderRestrictPresent
    {
      get
      {
        return this.vbooExtHeaderRestrictPresent;
      }
      set
      {
        this.vbooExtHeaderRestrictPresent = value;
      }
    }

    public byte ExtendedHeaderRestrictTAGSize
    {
      get
      {
        return this.vbytExtHeaderRestrictTAGSize;
      }
      set
      {
        this.vbytExtHeaderRestrictTAGSize = value;
      }
    }

    public byte ExtendedHeaderRestrictTextEnc
    {
      get
      {
        return this.vbytExtHeaderRestrictTextEnc;
      }
      set
      {
        this.vbytExtHeaderRestrictTextEnc = value;
      }
    }

    public byte ExtendedHeaderRestrictTextSize
    {
      get
      {
        return this.vbytExtHeaderRestrictTextSize;
      }
      set
      {
        this.vbytExtHeaderRestrictTextSize = value;
      }
    }

    public int ExtendedHeaderSize
    {
      get
      {
        return this.vintExtHeaderSize;
      }
      set
      {
        this.vintExtHeaderSize = value;
      }
    }

    public bool ExtendedHeaderTAGIsUpdate
    {
      get
      {
        return this.vbooExtHeaderTAGIsUpdate;
      }
      set
      {
        this.vbooExtHeaderTAGIsUpdate = value;
      }
    }

    public bool FooterPresent
    {
      get
      {
        return this.vbooFooterPresent;
      }
      set
      {
        this.vbooFooterPresent = value;
      }
    }

    public bool TAGHeaderPresent
    {
      get
      {
        return this.vbooTAGHeaderPresent;
      }
      set
      {
        if (!this.vbooTAGHeaderPresent & value)
        {
          this.vbooTAGHeaderPresent = false;
          this.vbytTAGVersion = Declarations.objSettings.NewV2Version;
          this.vbytTAGSubVersion = 0;
          this.vbooUnsync = false;
          this.vbooExtHeaderPresent = false;
          this.vbooExperimental = false;
          this.vbooFooterPresent = false;
          this.vintTAGSize = 0;
          this.vintExtHeaderSize = 0;
          this.vintExtHeaderPaddingSize = 0;
          this.vbooExtHeaderTAGIsUpdate = false;
          this.vbooExtHeaderCRCPresent = false;
          this.vlngExtHeaderCRCData = 0L;
          this.vbooExtHeaderRestrictPresent = false;
          this.vbytExtHeaderRestrictTAGSize = 0;
          this.vbytExtHeaderRestrictTextEnc = 0;
          this.vbytExtHeaderRestrictTextSize = 0;
          this.vbytExtHeaderRestrictImageEnc = 0;
          this.vbytExtHeaderRestrictImageSize = 0;
        }

        this.vbooTAGHeaderPresent = value;
      }
    }

    public int TAGSize
    {
      get
      {
        return this.vintTAGSize;
      }
      set
      {
        this.vintTAGSize = value;
      }
    }

    public byte TAGSubVersion
    {
      get
      {
        return this.vbytTAGSubVersion;
      }
      set
      {
        this.vbytTAGSubVersion = value;
      }
    }

    public byte TAGVersion
    {
      get
      {
        return this.vbytTAGVersion;
      }
      set
      {
        this.vbytTAGVersion = value;
      }
    }

    public bool Unsynchronisation
    {
      get
      {
        return this.vbooUnsync;
      }
      set
      {
        this.vbooUnsync = value;
      }
    }
  }
}