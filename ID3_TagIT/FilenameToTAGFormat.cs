using Microsoft.VisualBasic.CompilerServices;
using System.Collections;

namespace ID3_TagIT
{
  public class FilenameToTAGFormat
  {
    private ArrayList alstFormatParts = new ArrayList();

    public void Create(string vstrFormat, byte vbytTAGVersion)
    {
      int num;
      this.alstFormatParts.Clear();
      string[] strArray = vstrFormat.Split(new char[] { '\\' });
      int upperBound = strArray.GetUpperBound(0);

      for (num = 0; num <= upperBound; num++)
      {
        if (!strArray[num].StartsWith("<"))
          strArray[num] = "<X>" + strArray[num];
        if (!strArray[num].EndsWith(">"))
        {
          int index = num;
          strArray[index] = strArray[index] + "<X>";
        }
      }
      for (num = strArray.GetUpperBound(0); num >= 0; num += -1)
      {
        FormatPart part = new FormatPart();
        part.Create(strArray[num], vbytTAGVersion);
        this.alstFormatParts.Add(part);
      }
    }

    public ArrayList Parts
    {
      get
      {
        return this.alstFormatParts;
      }
    }

    private class FormatPart
    {
      private ArrayList alstFormatParameters = new ArrayList();
      private string[] astrFormatDelimiters;

      public void Create(string vstrFormatPart, byte vbytTAGVersion)
      {
        string str = vstrFormatPart;
        str = str.Replace("<A>", "\x0001").Replace("<T>", "\x0001").Replace("<B>", "\x0001").Replace("<K>", "\x0001").Replace("<G>", "\x0001").Replace("<C>", "\x0001").Replace("<Y>", "\x0001").Replace("<X>", "\x0001");

        if (vbytTAGVersion == 2)
          str = str.Replace("<O>", "\x0001").Replace("<N>", "\x0001").Replace("<M>", "\x0001").Replace("<R>", "\x0001").Replace("<U>", "\x0001").Replace("<S>", "\x0001").Replace("<P>", "\x0001").Replace("<E>", "\x0001").Replace("<p>", "\x0001").Replace("<k>", "\x0001");

        this.astrFormatDelimiters = str.Split(new char[] { '\x0001' });
        str = vstrFormatPart;
        int upperBound = this.astrFormatDelimiters.GetUpperBound(0);

        for (int i = 0; i <= upperBound; i++)
        {
          if ((i == this.astrFormatDelimiters.GetUpperBound(0)) | (StringType.StrCmp(this.astrFormatDelimiters[i], "", false) != 0))
          {
            this.alstFormatParameters.Add(str.Substring(str.IndexOf("<"), 3));
            str = str.Substring(str.IndexOf("<") + 3);
          }
        }
      }

      public string[] Delimiters
      {
        get
        {
          return this.astrFormatDelimiters;
        }
      }

      public ArrayList Parameters
      {
        get
        {
          return this.alstFormatParameters;
        }
      }
    }
  }
}