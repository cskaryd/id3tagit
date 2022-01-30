using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ID3_TagIT
{
  [Serializable]
  public class V1TAG
  {
    private int I = 0;
    private bool vbooTAGPresent = false;
    private byte vbytGenre = 0xff;
    private byte vbytTAGVersion = 0;
    private byte vbytTracknumber = 0;
    private int vintYear = 0;
    private string vstrAlbum = "";
    private string vstrArtist = "";
    private string vstrComment = "";
    private string vstrTitle = "";

    public V1TAG Clone()
    {
      BinaryFormatter formatter = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      formatter.Serialize(serializationStream, this);
      serializationStream.Position = 0L;
      return (V1TAG)formatter.Deserialize(serializationStream);
    }

    public void ReadTAG(ref MP3 MP3)
    {
      byte[] destinationArray = new byte[30];
      byte[] buffer = new byte[0x1c];
      byte[] buffer4 = new byte[4];
      byte[] buffer2 = new byte[3];

      if (MP3.FI.Length >= 0x80L)
      {
        byte[] sourceArray = MP3.ReadData(-128, SeekOrigin.End, 0x80);
        Array.Copy(sourceArray, buffer2, 3);

        if (StringType.StrCmp(Encoding.ASCII.GetString(buffer2).Substring(0, 3).ToUpper(), "TAG", false) == 0)
        {
          this.vbooTAGPresent = true;
          Array.Copy(sourceArray, 3, destinationArray, 0, 30);
          this.vstrTitle = Encoding.Default.GetString(destinationArray).Replace("\0", "").Trim(new char[] { ' ' });
          Array.Copy(sourceArray, 0x21, destinationArray, 0, 30);
          this.vstrArtist = Encoding.Default.GetString(destinationArray).Replace("\0", "").Trim(new char[] { ' ' });
          Array.Copy(sourceArray, 0x3f, destinationArray, 0, 30);
          this.vstrAlbum = Encoding.Default.GetString(destinationArray).Replace("\0", "").Trim(new char[] { ' ' });
          Array.Copy(sourceArray, 0x5d, buffer4, 0, 4);
          this.vintYear = (int)Math.Round(Conversion.Val(Encoding.ASCII.GetString(buffer4).Replace("\0", "")));

          if ((sourceArray[0x7d] == 0) & (sourceArray[0x7e] != 0))
          {
            this.vbytTAGVersion = 11;
            Array.Copy(sourceArray, 0x61, buffer, 0, 0x1c);
            this.vstrComment = Encoding.Default.GetString(buffer).Replace("\0", "").Trim(new char[] { ' ' });
            this.vbytTracknumber = sourceArray[0x7e];
          }
          else
          {
            this.vbytTAGVersion = 10;
            Array.Copy(sourceArray, 0x61, destinationArray, 0, 30);
            this.vstrComment = Encoding.Default.GetString(destinationArray).Replace("\0", "").Trim(new char[] { ' ' });
            this.vbytTracknumber = 0;
          }

          this.vbytGenre = sourceArray[0x7f];
        }
        else
        {
          this.vbooTAGPresent = false;
          this.vbytTAGVersion = 0;
          this.vstrTitle = "";
          this.vstrArtist = "";
          this.vstrAlbum = "";
          this.vintYear = 0;
          this.vstrComment = "";
          this.vbytTracknumber = 0;
          this.vbytGenre = 0xff;
        }
      }
    }

    public int WriteTAG(ref MP3 MP3)
    {
      V1TAG vtag = new V1TAG();
      byte[] array = new byte[0x80];
      byte[] buffer6 = new byte[4];
      Array.Clear(array, 0, 0x80);
      Array.Clear(buffer6, 0, 4);
      byte[] bytes = Encoding.Default.GetBytes(this.vstrTitle);
      byte[] buffer2 = Encoding.Default.GetBytes(this.vstrArtist);
      byte[] buffer = Encoding.Default.GetBytes(this.vstrAlbum);

      if (this.vintYear > 0)
        buffer6 = Encoding.ASCII.GetBytes(this.vintYear.ToString());

      byte[] buffer3 = Encoding.Default.GetBytes(this.vstrComment);

      if (this.TAGPresent)
      {
        Array.Copy(Encoding.ASCII.GetBytes("TAG"), array, 3);
        object[] args = new object[] { bytes, 0, array, 3, RuntimeHelpers.GetObjectValue(Interaction.IIf(bytes.Length > 30, 30, bytes.Length)) };
        bool[] copyBack = new bool[] { true, false, true, false, false };
        LateBinding.LateCall(null, typeof(Array), "Copy", args, null, copyBack);

        if (copyBack[2])
          array = (byte[])args[2];

        if (copyBack[0])
          bytes = (byte[])args[0];

        object[] objArray2 = new object[] { buffer2, 0, array, 0x21, RuntimeHelpers.GetObjectValue(Interaction.IIf(buffer2.Length > 30, 30, buffer2.Length)) };
        copyBack = new bool[] { true, false, true, false, false };
        LateBinding.LateCall(null, typeof(Array), "Copy", objArray2, null, copyBack);

        if (copyBack[2])
          array = (byte[])objArray2[2];

        if (copyBack[0])
          buffer2 = (byte[])objArray2[0];

        objArray2 = new object[] { buffer, 0, array, 0x3f, RuntimeHelpers.GetObjectValue(Interaction.IIf(buffer.Length > 30, 30, buffer.Length)) };
        copyBack = new bool[] { true, false, true, false, false };
        LateBinding.LateCall(null, typeof(Array), "Copy", objArray2, null, copyBack);

        if (copyBack[2])
          array = (byte[])objArray2[2];

        if (copyBack[0])
          buffer = (byte[])objArray2[0];

        objArray2 = new object[] { buffer6, 0, array, 0x5d, RuntimeHelpers.GetObjectValue(Interaction.IIf(buffer6.Length > 4, 4, buffer6.Length)) };
        copyBack = new bool[] { true, false, true, false, false };
        LateBinding.LateCall(null, typeof(Array), "Copy", objArray2, null, copyBack);

        if (copyBack[2])
          array = (byte[])objArray2[2];

        if (copyBack[0])
          buffer6 = (byte[])objArray2[0];

        if (this.vbytTAGVersion == 11)
        {
          objArray2 = new object[] { buffer3, 0, array, 0x61, RuntimeHelpers.GetObjectValue(Interaction.IIf(buffer3.Length > 0x1c, 0x1c, buffer3.Length)) };
          copyBack = new bool[] { true, false, true, false, false };
          LateBinding.LateCall(null, typeof(Array), "Copy", objArray2, null, copyBack);

          if (copyBack[2])
            array = (byte[])objArray2[2];

          if (copyBack[0])
            buffer3 = (byte[])objArray2[0];

          array[0x7d] = 0;
          array[0x7e] = this.vbytTracknumber;
        }
        else
        {
          objArray2 = new object[] { buffer3, 0, array, 0x61, RuntimeHelpers.GetObjectValue(Interaction.IIf(buffer3.Length > 30, 30, buffer3.Length)) };
          copyBack = new bool[] { true, false, true, false, false };
          LateBinding.LateCall(null, typeof(Array), "Copy", objArray2, null, copyBack);

          if (copyBack[2])
            array = (byte[])objArray2[2];

          if (copyBack[0])
            buffer3 = (byte[])objArray2[0];
        }
        array[0x7f] = this.vbytGenre;
      }

      if (!MP3.OpenFileStreamRW())
        return -1;

      MP3.OpenBinaryReader();
      vtag.ReadTAG(ref MP3);
      MP3.CloseBinaryReader();

      if (vtag.TAGPresent)
      {
        if (!this.TAGPresent)
          return 0x80;

        if (!MP3.OpenFileStreamRW())
          return -1;

        MP3.OpenBinaryWriter();
        MP3.WriteData(-128, SeekOrigin.End, array);
        MP3.CloseBinaryWriter();
      }
      else if (this.TAGPresent)
      {
        if (!MP3.OpenFileStreamRW())
          return -1;

        MP3.OpenBinaryWriter();
        MP3.WriteData(0, SeekOrigin.End, array);
        MP3.CloseBinaryWriter();
      }

      MP3.CloseFileStream();
      return 0;
    }

    public string Album
    {
      get
      {
        return this.vstrAlbum;
      }
      set
      {
        this.vstrAlbum = Strings.Left(value, 30).Trim(new char[] { ' ' });
      }
    }

    public string Artist
    {
      get
      {
        return this.vstrArtist;
      }
      set
      {
        this.vstrArtist = Strings.Left(value, 30).Trim(new char[] { ' ' });
      }
    }

    public string Comment
    {
      get
      {
        return this.vstrComment;
      }
      set
      {
        if (this.vbytTAGVersion <= 10)
          this.vstrComment = Strings.Left(value, 30).Trim(new char[] { ' ' });
        else
          this.vstrComment = Strings.Left(value, 0x1c).Trim(new char[] { ' ' });
      }
    }

    public byte GenreByte
    {
      get
      {
        return this.vbytGenre;
      }
      set
      {
        this.vbytGenre = value;
      }
    }

    public string GenreText
    {
      get
      {
        if (this.vbytGenre < 0x94)
          return Declarations.astrGenreLookup[this.vbytGenre];

        return "< undefined >";
      }
      set
      {
        this.vbytGenre = ID3Functions.GetV1GenreByName(value);
      }
    }

    public bool TAGPresent
    {
      get
      {
        return this.vbooTAGPresent;
      }
      set
      {
        if (value & !this.vbooTAGPresent)
        {
          if (this.vbytTracknumber == 0)
            this.vbytTAGVersion = 10;
          else
            this.vbytTAGVersion = 11;
        }

        this.vbooTAGPresent = value;
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

    public string Title
    {
      get
      {
        return this.vstrTitle;
      }
      set
      {
        this.vstrTitle = Strings.Left(value, 30).Trim(new char[] { ' ' });
      }
    }

    public byte Tracknumber
    {
      get
      {
        return this.vbytTracknumber;
      }
      set
      {
        this.vbytTracknumber = value;

        if (value > 0)
        {
          this.vbytTAGVersion = 11;
          this.vstrComment = Strings.Left(this.vstrComment, 0x1c).Trim(new char[] { ' ' });
        }
        else
          this.vbytTAGVersion = 10;
      }
    }

    public int Year
    {
      get
      {
        return this.vintYear;
      }
      set
      {
        this.vintYear = value;
      }
    }
  }
}