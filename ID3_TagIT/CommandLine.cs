using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ID3_TagIT
{
  public class CommandLine
  {
    private bool mvarSave = true;
    private bool mvarAutoModus = false;
    private string mvarPath = "";
    private string mvarFilename = "";
    private string mvarDataFilePath = "";

    public void Resolve()
    {
      string str = "";
      string sLeft = "";

      sLeft = Interaction.Command().Trim(new char[] { ' ' });

      if (StringType.StrCmp(sLeft, "", false) != 0)
      {
        if (StringType.StrCmp(Strings.Mid(sLeft, 1, 1), "\"", false) == 0)
          sLeft = Strings.Mid(sLeft, 2);

        if (StringType.StrCmp(Strings.Mid(sLeft, Strings.Len(sLeft), 1), "\"", false) == 0)
          sLeft = Strings.Mid(sLeft, 1, Strings.Len(sLeft) - 1);

        sLeft = Strings.Trim(sLeft);

        while (Strings.InStr(1, sLeft, "/", CompareMethod.Text) != 0)
        {
          string str3 = Strings.UCase(Strings.Mid(sLeft, Strings.InStr(1, sLeft, "/", CompareMethod.Text), 3));

          if (StringType.StrCmp(str3, "/P=", false) == 0)
          {
            this.mvarPath = Strings.Trim(Strings.Mid(sLeft, Strings.InStr(1, sLeft, "/", CompareMethod.Text) + 3, IntegerType.FromObject(Interaction.IIf(Strings.InStr(4, sLeft, "/", CompareMethod.Text) == 0, Strings.Len(sLeft), Strings.InStr(4, sLeft, "/", CompareMethod.Text) - 4))));

            if (StringType.StrCmp(Strings.Mid(this.mvarPath, 1, 1), "\"", false) == 0)
              this.mvarPath = Strings.Mid(this.mvarPath, 2);
            if (StringType.StrCmp(Strings.Mid(this.mvarPath, Strings.Len(this.mvarPath), 1), "\"", false) == 0)
              this.mvarPath = Strings.Mid(this.mvarPath, 1, Strings.Len(this.mvarPath) - 1);
            if (StringType.StrCmp(Strings.Right(this.mvarPath, 1), @"\", false) == 0)
              this.mvarFilename = "";
            else if (StringType.StrCmp(Strings.LCase(Strings.Right(this.mvarPath, 4)), ".mp3", false) == 0)
            {
              this.mvarFilename = Strings.Mid(this.mvarPath, Strings.InStrRev(this.mvarPath, @"\", -1, CompareMethod.Text) + 1);
              this.mvarPath = Strings.Left(this.mvarPath, Strings.InStrRev(this.mvarPath, @"\", -1, CompareMethod.Text));
            }
          }
          else if (StringType.StrCmp(str3, "/I=", false) == 0)
          {
            this.mvarDataFilePath = Strings.Mid(sLeft, Strings.InStr(1, sLeft, "/", CompareMethod.Text) + 3, IntegerType.FromObject(Interaction.IIf(Strings.InStr(4, sLeft, "/", CompareMethod.Text) == 0, Strings.Len(sLeft), Strings.InStr(4, sLeft, "/", CompareMethod.Text) - 4)));

            if (StringType.StrCmp(Strings.Mid(this.mvarDataFilePath, 1, 1), "\"", false) == 0)
              this.mvarDataFilePath = Strings.Mid(this.mvarDataFilePath, 2);
            if (StringType.StrCmp(Strings.Mid(this.mvarDataFilePath, Strings.Len(this.mvarDataFilePath), 1), "\"", false) == 0)
              this.mvarDataFilePath = Strings.Mid(this.mvarDataFilePath, 1, Strings.Len(this.mvarDataFilePath) - 1);

            this.mvarDataFilePath = Strings.Trim(this.mvarDataFilePath);
          }
          else if (StringType.StrCmp(str3, "/A=", false) == 0)
          {
            str = Strings.Mid(sLeft, Strings.InStr(1, sLeft, "/", CompareMethod.Text) + 3, IntegerType.FromObject(Interaction.IIf(Strings.InStr(4, sLeft, "/", CompareMethod.Text) == 0, Strings.Len(sLeft), Strings.InStr(4, sLeft, "/", CompareMethod.Text) - 4)));

            if (StringType.StrCmp(Strings.Mid(str, 1, 1), "\"", false) == 0)
              str = Strings.Mid(str, 2);
            if (StringType.StrCmp(Strings.Mid(str, Strings.Len(str), 1), "\"", false) == 0)
              str = Strings.Mid(str, 1, Strings.Len(str) - 1);
            if (StringType.StrCmp(Strings.UCase(Strings.Trim(str)), "TRUE", false) == 0)
              this.mvarAutoModus = true;
          }
          else if (StringType.StrCmp(str3, "/S=", false) == 0)
          {
            str = Strings.Mid(sLeft, Strings.InStr(1, sLeft, "/", CompareMethod.Text) + 3, IntegerType.FromObject(Interaction.IIf(Strings.InStr(4, sLeft, "/", CompareMethod.Text) == 0, Strings.Len(sLeft), Strings.InStr(4, sLeft, "/", CompareMethod.Text) - 4)));

            if (StringType.StrCmp(Strings.Mid(str, 1, 1), "\"", false) == 0)
              str = Strings.Mid(str, 2);
            if (StringType.StrCmp(Strings.Mid(str, Strings.Len(str), 1), "\"", false) == 0)
              str = Strings.Mid(str, 1, Strings.Len(str) - 1);
            if (StringType.StrCmp(Strings.UCase(Strings.Trim(str)), "NO", false) == 0)
              this.mvarSave = false;
          }

          if (Strings.InStr(2, sLeft, "/", CompareMethod.Text) != 0)
            sLeft = Strings.Mid(sLeft, Strings.InStr(2, sLeft, "/", CompareMethod.Text));
          else
            sLeft = "";
        }
      }
    }

    public bool AutoModus
    {
      get
      {
        return this.mvarAutoModus;
      }
    }

    public string DataFilePath
    {
      get
      {
        return this.mvarDataFilePath;
      }
    }

    public string Filename
    {
      get
      {
        return this.mvarFilename;
      }
    }

    public string Path
    {
      get
      {
        return this.mvarPath;
      }
    }

    public bool Save
    {
      get
      {
        return this.mvarSave;
      }
    }
  }
}