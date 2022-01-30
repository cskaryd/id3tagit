using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;

namespace ID3_TagIT
{
  public class MP3Frame
  {
    private bool vbooVBR = false;
    private byte vbytBitrateValue = 0;
    private byte vbytChannel = 0;
    private byte vbytCopyrightBit = 0;
    private byte vbytEmphasis = 0;
    private byte vbytLayer = 0;
    private byte vbytOriginal = 0;
    private byte vbytPadding = 0;
    private byte vbytPrivateBit = 0;
    private byte vbytProtectionBit;
    private byte vbytSamplerateValue = 0;
    private byte vbytVersion = 0;
    private int vintBitrate = 0;
    private int vintFrameLength = 0;
    private int vintNumberOfFrames = 0;
    private int vintSamplerate = 0;
    private string vstrVBRType = "";

    public bool GetFrame(ref FileStream FStream, ref byte[] abytHeader, bool vbooCheckVBR)
    {
      byte num2 = 0;
      this.vbytVersion = (byte)((0x18 & abytHeader[1]) / 8);
      this.vbytLayer = (byte)((6 & abytHeader[1]) / 2);
      this.vbytProtectionBit = ByteType.FromObject(Interaction.IIf((1 & abytHeader[1]) > 0, 1, 0));
      this.vbytBitrateValue = (byte)((240 & abytHeader[2]) / 0x10);
      this.vbytSamplerateValue = (byte)((12 & abytHeader[2]) / 4);
      this.vbytPadding = ByteType.FromObject(Interaction.IIf((2 & abytHeader[2]) > 0, 1, 0));
      this.vbytPrivateBit = ByteType.FromObject(Interaction.IIf((1 & abytHeader[2]) > 0, 1, 0));
      this.vbytChannel = (byte)((0xc0 & abytHeader[3]) / 0x40);
      this.vbytCopyrightBit = ByteType.FromObject(Interaction.IIf((8 & abytHeader[3]) > 0, 1, 0));
      this.vbytOriginal = ByteType.FromObject(Interaction.IIf((4 & abytHeader[3]) > 0, 1, 0));
      this.vbytEmphasis = (byte)(3 & abytHeader[3]);
      this.vintBitrate = Declarations.aintBitrateLookup[((this.vbytVersion & 1) * 4) | this.vbytLayer, this.vbytBitrateValue] * 0x3e8;
      this.vintSamplerate = Declarations.aintFreqLookup[this.vbytVersion, this.vbytSamplerateValue];

      if ((((this.vintBitrate != 0xf3e58) & (this.vintBitrate != 0)) & (this.vintSamplerate != 0x1869f)) & (this.vintSamplerate != 0))
      {
        if (this.vbytLayer != 3)
        {
          if (!((this.vbytLayer == 2) | (this.vbytLayer == 1)))
          {
            this.vintFrameLength = 0;
            return false;
          }

          if (this.vbytVersion == 3)
            this.vintFrameLength = (int)Math.Round((double)(Conversion.Fix((double)(((double)(0x90 * this.vintBitrate)) / ((double)this.vintSamplerate))) + this.vbytPadding));
          else
            this.vintFrameLength = (int)Math.Round((double)(Conversion.Fix((double)(((double)(0x48 * this.vintBitrate)) / ((double)this.vintSamplerate))) + this.vbytPadding));
        }
        else if (this.vbytVersion == 3)
          this.vintFrameLength = (int)Math.Round((double)(Conversion.Fix((double)(((double)(0x30 * this.vintBitrate)) / ((double)this.vintSamplerate))) + (this.vbytPadding * 4)));
        else
          this.vintFrameLength = (int)Math.Round((double)(Conversion.Fix((double)(((double)(0x18 * this.vintBitrate)) / ((double)this.vintSamplerate))) + (this.vbytPadding * 4)));
      }
      else
      {
        this.vintFrameLength = 0;
        return false;
      }

      FStream.Seek((long)(this.vintFrameLength - 4), SeekOrigin.Current);

      if ((FStream.ReadByte() == 0xff) & (FStream.ReadByte() >= 240))
        FStream.Seek((long)(2 - this.vintFrameLength), SeekOrigin.Current);
      else
      {
        FStream.Seek((long)(2 - this.vintFrameLength), SeekOrigin.Current);
        return false;
      }

      this.vbooVBR = false;

      if (vbooCheckVBR)
      {
        int num;
        byte[] array = new byte[4];
        FStream.Seek(0x20L, SeekOrigin.Current);
        if (FStream.Read(array, 0, 4) < 4)
          return false;

        this.vstrVBRType = StringType.FromChar(Strings.Chr(array[0])) + StringType.FromChar(Strings.Chr(array[1])) + StringType.FromChar(Strings.Chr(array[2])) + StringType.FromChar(Strings.Chr(array[3]));
        if (StringType.StrCmp(this.vstrVBRType, "VBRI", false) == 0)
        {
          this.vbooVBR = true;
          this.vintNumberOfFrames = 0;
          FStream.Seek(10L, SeekOrigin.Current);
          if (FStream.Read(array, 0, 4) < 4)
            return false;
          num = 0;
          do
          {
            this.vintNumberOfFrames = (int)Math.Round((double)(this.vintNumberOfFrames + (array[num] * Math.Pow(256.0, (double)(3 - num)))));
            num++;
          }
          while (num <= 3);
          num2 = 50;
        }
        else
        {
          if (this.vbytVersion == 3)
          {
            if (this.vbytChannel != 3)
              num2 = 40;
            else
            {
              FStream.Seek(-19L, SeekOrigin.Current);
              if (FStream.Read(array, 0, 4) < 4)
                return false;
              num2 = 0x15;
            }
          }
          else if (this.vbytChannel != 3)
          {
            FStream.Seek(-19L, SeekOrigin.Current);
            if (FStream.Read(array, 0, 4) < 4)
              return false;
            num2 = 0x15;
          }
          else
          {
            FStream.Seek(-27L, SeekOrigin.Current);
            if (FStream.Read(array, 0, 4) < 4)
              return false;
            num2 = 13;
          }
          this.vstrVBRType = StringType.FromChar(Strings.Chr(array[0])) + StringType.FromChar(Strings.Chr(array[1])) + StringType.FromChar(Strings.Chr(array[2])) + StringType.FromChar(Strings.Chr(array[3]));
          if (StringType.StrCmp(this.vstrVBRType, "Xing", false) == 0)
          {
            this.vbooVBR = true;
            this.vintNumberOfFrames = 0;
            FStream.Seek(4L, SeekOrigin.Current);
            if (FStream.Read(array, 0, 4) < 4)
              return false;
            num = 0;
            do
            {
              this.vintNumberOfFrames = (int)Math.Round((double)(this.vintNumberOfFrames + (array[num] * Math.Pow(256.0, (double)(3 - num)))));
              num++;
            }
            while (num <= 3);
            num2 = (byte)(num2 + 8);
          }
        }
      }
      FStream.Seek((long)(-1 * num2), SeekOrigin.Current);
      return true;
    }

    public int Bitrate
    {
      get
      {
        return this.vintBitrate;
      }
    }

    public byte BitrateValue
    {
      get
      {
        return this.vbytBitrateValue;
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
        string str = string.Empty;

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

    public byte CopyrightBit
    {
      get
      {
        return this.vbytCopyrightBit;
      }
    }

    public string CopyrightBitText
    {
      get
      {
        if (this.vbytCopyrightBit == 0)
          return "Not copyrighted";

        return "Copyrighted";
      }
    }

    public byte Emphasis
    {
      get
      {
        return this.vbytEmphasis;
      }
    }

    public string EmphasisText
    {
      get
      {
        string str = string.Empty;

        switch (this.vbytEmphasis)
        {
          case 0:
            return "None";

          case 1:
            return "50/15 ms";

          case 2:
            return "Reserved";

          case 3:
            return "CCIT J.17";
        }

        return str;
      }
    }

    public int FrameLength
    {
      get
      {
        return this.vintFrameLength;
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
        string str = string.Empty;

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

    public byte Original
    {
      get
      {
        return this.vbytOriginal;
      }
    }

    public string OriginalText
    {
      get
      {
        if (this.vbytOriginal == 0)
        {
          return "Copy";
        }
        return "Original";
      }
    }

    public byte Padding
    {
      get
      {
        return this.vbytPadding;
      }
    }

    public byte PrivateBit
    {
      get
      {
        return this.vbytPrivateBit;
      }
    }

    public byte ProtectionBit
    {
      get
      {
        return this.vbytProtectionBit;
      }
    }

    public string ProtectionBitText
    {
      get
      {
        if (this.vbytProtectionBit == 0)
        {
          return "Protected";
        }
        return "Not Protected";
      }
    }

    public int Samplerate
    {
      get
      {
        return this.vintSamplerate;
      }
    }

    public byte SamplerateValue
    {
      get
      {
        return this.vbytSamplerateValue;
      }
    }

    public bool VBR
    {
      get
      {
        return this.vbooVBR;
      }
    }

    public string VBRType
    {
      get
      {
        return this.vstrVBRType;
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
        string str = string.Empty;

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