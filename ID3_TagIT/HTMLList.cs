namespace ID3_TagIT
{
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.IO;
  using System.Text;

  public class HTMLList
  {
    private FileInfo objFileInfo;
    private StreamWriter objHTMLFile;
    private string vstrWidth = "";

    public void CellString(long vlngColumn, HTMLRowColor RC, HTMLFontFormat FF, HTMLFontColor FC, HTMLAlignment A, bool vbooCloseRow, string vstrEntry)
    {
      this.objHTMLFile.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(Strings.Space(8), Interaction.IIf(vlngColumn == 1L, "<tr bgcolor=" + this.GetRowColor(RC) + ">", "")), "<td"), this.GetAlign(A)), ">"));
      this.objHTMLFile.WriteLine(Strings.Space(10) + "<font color=" + this.GetFontColor(FC) + ">" + this.GetFontOpen(FF));
      if (StringType.StrCmp(vstrEntry, "", false) != 0)
      {
        string str = null;
        int num2 = Strings.Len(vstrEntry);
        for (int i = 1; i <= num2; i++)
        {
          if ((StringType.StrCmp(Strings.Mid(vstrEntry, i, 1), "\r", false) == 0) | (StringType.StrCmp(Strings.Mid(vstrEntry, i, 1), "\n", false) == 0))
          {
            if (StringType.StrCmp(Strings.Mid(vstrEntry, i + 1, 1), "\n", false) != 0)
            {
              this.objHTMLFile.WriteLine(Strings.Space(14) + str + "<br>");
              str = "";
            }
          }
          else
          {
            str = StringType.FromObject(ObjectType.StrCatObj(str, Interaction.IIf((StringType.StrCmp(Strings.Mid(vstrEntry, i, 1), " ", false) == 0) & (StringType.StrCmp(Strings.Mid(vstrEntry, i + 1, 1), " ", false) == 0), "&nbsp;", Strings.Mid(vstrEntry, i, 1))));
          }
        }
        this.objHTMLFile.WriteLine(Strings.Space(14) + str);
      }
      else
      {
        this.objHTMLFile.WriteLine(Strings.Space(14) + "&nbsp;");
      }
      this.objHTMLFile.WriteLine(Strings.Space(10) + this.GetFontClose(FF) + "</font>");
      this.objHTMLFile.WriteLine(ObjectType.StrCatObj(Strings.Space(8) + "</td>", Interaction.IIf(vbooCloseRow, "</tr>", "")));
    }

    public void CloseGrid()
    {
      this.objHTMLFile.WriteLine("      </table>");
      this.objHTMLFile.WriteLine("    </td></tr>");
      this.objHTMLFile.WriteLine("  </table>");
      this.objHTMLFile.WriteLine("  </p>");
    }

    public void CreateHTMLFile(string vstrFilename, string vstrTitle)
    {
      this.objHTMLFile = new StreamWriter(vstrFilename.Trim(new char[] { ' ' }), false, Encoding.Default);
      if (StringType.StrCmp(this.vstrWidth, "", false) == 0)
      {
        this.vstrWidth = "600";
      }
      this.objHTMLFile.WriteLine("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\">");
      this.objHTMLFile.WriteLine("<html>");
      this.objHTMLFile.WriteLine("<head>");
      this.objHTMLFile.WriteLine("  <title>ID3-TagIT List (www.id3-tagit.de)</title>");
      this.objHTMLFile.WriteLine("  <meta http-equiv=\" Content-Type\" content=\"text/html; charset=iso-8859-1\">");
      this.objHTMLFile.WriteLine("  <meta name=\" GENERATOR\" content=\"ID3-TagIT - http://www.id3-tagit.de\">");
      this.objHTMLFile.WriteLine("  <title>ID3-TagIT - Filelist</title>");
      this.objHTMLFile.WriteLine("  <style type=\"text/css\"><!--");
      this.objHTMLFile.WriteLine("    h1 { font-family: Verdana; font-size: 14pt }");
      this.objHTMLFile.WriteLine("    body { font-family: Verdana; font-size: 8pt }");
      this.objHTMLFile.WriteLine("    table { font-family: Verdana; font-size: 9pt }");
      this.objHTMLFile.WriteLine("    a {color: #0033FF; text-decoration: none }");
      this.objHTMLFile.WriteLine("    a:hover {color: #FF0033; text-decoration: none}");
      this.objHTMLFile.WriteLine("    -->");
      this.objHTMLFile.WriteLine("  </style>");
      this.objHTMLFile.WriteLine("</head>");
      this.objHTMLFile.WriteLine("\r\n");
      this.objHTMLFile.WriteLine("<body marginwidth=10 marginheight=10 leftmargin=10 topmargin=10 bgcolor=#FFFFFF text=#000000>");
      this.objHTMLFile.WriteLine("  <p align=center>");
      this.objHTMLFile.WriteLine("    <table border=0 cellpadding=0 cellspacing=0 width=" + this.vstrWidth + " bgcolor=#000000>");
      this.objHTMLFile.WriteLine("      <tr><td>");
      this.objHTMLFile.WriteLine("        <table border=0 cellpadding=5 cellspacing=1 width=100%>");
      this.objHTMLFile.WriteLine("          <tr><td bgcolor=#CCCCCC>");
      this.objHTMLFile.WriteLine("            <h1>" + vstrTitle + "<h1>");
      this.objHTMLFile.WriteLine("          </td></tr>");
      this.objHTMLFile.WriteLine("        </table>");
      this.objHTMLFile.WriteLine("      </td></tr>");
      this.objHTMLFile.WriteLine("    </table>");
      this.objHTMLFile.WriteLine("  </p>");
    }

    public void FinishHTMLFile()
    {
      this.objHTMLFile.WriteLine("</body>");
      this.objHTMLFile.WriteLine("</html>");
      this.objHTMLFile.Flush();
      this.objHTMLFile.Close();
    }

    private string GetAlign(HTMLAlignment A)
    {
      switch (A)
      {
        case HTMLAlignment.HTMLGeneral:
          return "";

        case HTMLAlignment.HTMLCenter:
          return " align=center";

        case HTMLAlignment.HTMLLeftJustify:
          return " align=left";

        case HTMLAlignment.HTMLRightJustify:
          return " align=right";
      }
      return "";
    }

    private string GetFontClose(HTMLFontFormat FF)
    {
      switch (FF)
      {
        case HTMLFontFormat.HTMLFontNormal:
          return "";

        case HTMLFontFormat.HTMLFontBold:
          return "</b>";

        case HTMLFontFormat.HTMLFontItalic:
          return "</i>";

        case HTMLFontFormat.HTMLFontBoldItalic:
          return "</i></b>";
      }
      return "";
    }

    private string GetFontColor(HTMLFontColor FC)
    {
      switch (FC)
      {
        case HTMLFontColor.HTMLFontBlack:
          return "#000000";

        case HTMLFontColor.HTMLFontBlue:
          return "#0000FF";

        case HTMLFontColor.HTMLFontGray:
          return "#999999";

        case HTMLFontColor.HTMLFontWhite:
          return "#FFFFFF";
      }
      return "#000000";
    }

    private string GetFontOpen(HTMLFontFormat FF)
    {
      switch (FF)
      {
        case HTMLFontFormat.HTMLFontNormal:
          return "";

        case HTMLFontFormat.HTMLFontBold:
          return "<b>";

        case HTMLFontFormat.HTMLFontItalic:
          return "<i>";

        case HTMLFontFormat.HTMLFontBoldItalic:
          return "<b><i>";
      }
      return "";
    }

    private string GetRowColor(HTMLRowColor RC)
    {
      switch (RC)
      {
        case HTMLRowColor.HTMLRowBlack:
          return "#000000";

        case HTMLRowColor.HTMLRowBlue:
          return "#0000FF";

        case HTMLRowColor.HTMLRowGray:
          return "#CCCCCC";

        case HTMLRowColor.HTMLRowWhite:
          return "#FFFFFF";
      }
      return "#FFFFFF";
    }

    public void OpenGrid(object vbooGridlines)
    {
      this.objHTMLFile.WriteLine("  <p align=center>");
      this.objHTMLFile.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj("  <table border=0 cellpadding=0 cellspacing=0 width=" + this.vstrWidth + " bgcolor=", Interaction.IIf(BooleanType.FromObject(vbooGridlines), "#999999", "#FFFFFF")), ">"));
      this.objHTMLFile.WriteLine("    <tr><td>");
      this.objHTMLFile.WriteLine("      <table border=0 cellpadding=3 cellspacing=1 width=100%>");
    }

    public string TableWidth
    {
      set
      {
        this.vstrWidth = value;
      }
    }

    public enum HTMLAlignment
    {
      HTMLGeneral,
      HTMLCenter,
      HTMLLeftJustify,
      HTMLRightJustify
    }

    public enum HTMLFontColor
    {
      HTMLFontBlack = 1,
      HTMLFontBlue = 2,
      HTMLFontGray = 3,
      HTMLFontWhite = 4
    }

    public enum HTMLFontFormat
    {
      HTMLFontNormal,
      HTMLFontBold,
      HTMLFontItalic,
      HTMLFontBoldItalic
    }

    public enum HTMLRowColor
    {
      HTMLRowBlack = 1,
      HTMLRowBlue = 2,
      HTMLRowGray = 3,
      HTMLRowWhite = 4
    }
  }
}