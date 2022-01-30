using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class FreeDB
  {
    private TcpClient Client;
    private string ClientHostname = "";
    private string ClientName = "";
    private string ClientVersion = "";
    private int FreeDBPort = IntegerType.FromString("8880");
    private string FreeDBServer = "freedb.freedb.org";
    private NetworkStream NetStream;
    private string Username = "";
    private bool vbooConnected = false;

    public FreeDB(string vstrUsername, string vstrClientHostname, string vstrClientName, string vstrClientVersion, string vstrFreeDBServer, int vintFreeDBPort)
    {
      this.Username = vstrUsername;
      this.ClientHostname = vstrClientHostname;
      this.ClientName = vstrClientName;
      this.ClientVersion = vstrClientVersion;
      this.FreeDBServer = vstrFreeDBServer;
      this.FreeDBPort = vintFreeDBPort;
    }

    public string CalcDiskID(int[] TracksLength)
    {
      string vstrCommand = "";
      string str3 = "";
      int num3 = 150;
      int num2 = 0;

      if (!this.vbooConnected)
        return string.Empty;

      vstrCommand = "discid " + TracksLength.Length.ToString() + " ";

      foreach (int num in TracksLength)
      {
        vstrCommand = vstrCommand + num3.ToString() + " ";
        num3 += num * 0x4b;
        num2 += num;
      }

      vstrCommand = vstrCommand + num2.ToString() + "\r\n";

      str3 = this.SendCommand(vstrCommand).Replace("\r\n", "");

      if (StringType.StrCmp(str3.Substring(0, 3), "200", false) == 0)
        return str3.Replace("200 Disc ID is ", "");

      return "00000000";
    }

    public void CloseConnection([Optional, DefaultParameterValue("")] ref string ReturnedMessage)
    {
      string str2 = "";
      string vstrCommand = "";

      if (this.vbooConnected)
      {
        vstrCommand = "quit\r\n";
        str2 = this.SendCommand(vstrCommand);
        ReturnedMessage = str2;
        this.vbooConnected = false;
        this.Client.Close();
      }
    }

    public FreeDBConnectResult ConnectToServer([Optional, DefaultParameterValue("")] ref string ReturnedMessage)
    {
      FreeDBConnectResult connectionFailed;
      string vstrCommand = "";
      string str2 = "";
      int length = 0;

      if (this.vbooConnected)
        return FreeDBConnectResult.ConnectionFailed;

      this.Client = new TcpClient();
      try
      {
        this.Client.Connect(this.FreeDBServer, this.FreeDBPort);
        this.NetStream = this.Client.GetStream();
        goto Label_007D;
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        this.Client.Close();
        ReturnedMessage = exception.Message;
        connectionFailed = FreeDBConnectResult.ConnectionFailed;
        ProjectData.ClearProjectError();
        return connectionFailed;
      }

      Label_0078:
      Application.DoEvents();

      Label_007D:
      if (!this.NetStream.DataAvailable)
        goto Label_0078;

      if (this.NetStream.DataAvailable)
      {
        byte[] buffer = new byte[(this.Client.ReceiveBufferSize - 1) + 1];
        length = this.NetStream.Read(buffer, 0, buffer.Length);
        str2 = Encoding.Default.GetString(buffer).Substring(0, length);
      }

      ReturnedMessage = str2;

      if (StringType.StrCmp(str2.Substring(0, 1), "4", false) == 0)
      {
        this.Client.Close();
        return FreeDBConnectResult.ConnectionFailed;
      }

      vstrCommand = "cddb hello " + this.Username + " " + this.ClientHostname + " " + this.ClientName + " " + this.ClientVersion.ToString() + "\r\n";
      str2 = this.SendCommand(vstrCommand);
      ReturnedMessage = ReturnedMessage + str2;
      string sLeft = str2.Substring(0, 3);

      if (StringType.StrCmp(sLeft, "200", false) == 0)
      {
        this.vbooConnected = true;
        return FreeDBConnectResult.ConnectionSucessful;
      }

      if (StringType.StrCmp(sLeft, "402", false) == 0)
        return FreeDBConnectResult.ConnectionAlreadyExists;

      if (StringType.StrCmp(sLeft, "431", false) == 0)
      {
        this.Client.Close();
        return FreeDBConnectResult.ConnectionFailed;
      }

      return FreeDBConnectResult.ConnectionFailed;
    }

    public string[] GetCategoryList()
    {
      string[] strArray2 = null;
      string vstrCommand = "";
      string str2 = "";

      if (this.vbooConnected)
      {
        vstrCommand = "cddb lscat\r\n";
        str2 = this.SendCommand(vstrCommand);

        if (str2.StartsWith("210"))
        {
          str2 = str2.Substring(str2.IndexOf("\r\n") + 2);
          return str2.Substring(0, str2.LastIndexOf(".") - 2).Replace("\r\n", "|").Split(new char[] { '|' });
        }
      }

      return strArray2;
    }

    public string[] GetSitesList()
    {
      string[] strArray2 = null;
      string vstrCommand = "";
      string str2 = "";

      if (this.vbooConnected)
      {
        vstrCommand = "sites\r\n";
        str2 = this.SendCommand(vstrCommand);

        if (str2.StartsWith("210"))
        {
          str2 = str2.Substring(str2.IndexOf("\r\n") + 2);
          return str2.Substring(0, str2.LastIndexOf(".") - 2).Replace("\r\n", "|").Split(new char[] { '|' });
        }
      }

      return strArray2;
    }

    public string HTMLCalcDiskID(int[] TracksLength)
    {
      string vstrCommand = "";
      string str3 = "";
      int num3 = 150;
      int num2 = 0;
      vstrCommand = "discid+" + TracksLength.Length.ToString() + "+";

      foreach (int num in TracksLength)
      {
        vstrCommand = vstrCommand + num3.ToString() + "+";
        num3 += num * 0x4b;
        num2 += num;
      }

      vstrCommand = vstrCommand + num2.ToString();
      str3 = this.SendHTMLCommand(vstrCommand).Replace("\r\n", "");

      if (StringType.StrCmp(str3.Substring(0, 3), "200", false) == 0)
        return str3.Replace("200 Disc ID is ", "");

      return "00000000";
    }

    public string[] HTMLGetCategoryList()
    {
      string[] strArray2 = null;
      string vstrCommand = "";
      string str2 = "";
      vstrCommand = "cddb+lscat";
      str2 = this.SendHTMLCommand(vstrCommand);

      if (str2.StartsWith("210"))
      {
        str2 = str2.Substring(str2.IndexOf("\r\n") + 2);
        return str2.Substring(0, str2.LastIndexOf(".") - 2).Replace("\r\n", "|").Split(new char[] { '|' });
      }

      return strArray2;
    }

    public string[] HTMLGetSitesList()
    {
      string[] strArray2 = null;
      string vstrCommand = "";
      string str2 = "";
      vstrCommand = "cddb+sites";
      str2 = this.SendHTMLCommand(vstrCommand);

      if (str2.StartsWith("210"))
      {
        str2 = str2.Substring(str2.IndexOf("\r\n") + 2);
        return str2.Substring(0, str2.LastIndexOf(".") - 2).Replace("\r\n", "|").Split(new char[] { '|' });
      }

      return strArray2;
    }

    public FreeDBQueryResult HTMLQuery(string DiscID, int[] TracksLength, ref ArrayList ReturnedMatches)
    {
      string vstrCommand = "";
      string str3 = "";
      int num3 = 150;
      int num2 = 0;
      vstrCommand = "cddb+query+" + DiscID + "+" + TracksLength.Length.ToString() + "+";

      foreach (int num in TracksLength)
      {
        vstrCommand = vstrCommand + num3.ToString() + "+";
        num3 += num * 0x4b;
        num2 += num;
      }

      vstrCommand = vstrCommand + num2.ToString();
      str3 = this.SendHTMLCommand(vstrCommand).Replace("\r\n", "|");
      string sLeft = str3.Substring(0, 3);

      if (StringType.StrCmp(sLeft, "200", false) == 0)
      {
        str3 = str3.Substring(5).Replace("|", "");

        FreeDBQueryItem item = new FreeDBQueryItem
        {
          Category = str3.Substring(0, str3.IndexOf(" "))
        };

        str3 = str3.Substring(str3.IndexOf(" ") + 1);
        item.DiscID = str3.Substring(0, str3.IndexOf(" "));
        item.DTitle = str3.Substring(str3.IndexOf(" ") + 1);
        ReturnedMatches.Add(item);

        return FreeDBQueryResult.FoundExactMatch;
      }

      if (StringType.StrCmp(sLeft, "211", false) != 0)
        return FreeDBQueryResult.FoundInexactMatches;

      str3 = str3.Substring(0, str3.LastIndexOf(".") - 2);

      foreach (string str2 in str3.Substring(str3.IndexOf("|") + 1).Split(new char[] { '|' }))
      {
        FreeDBQueryItem item2 = new FreeDBQueryItem
        {
          Category = str2.Substring(0, str2.IndexOf(" "))
        };

        var _str2 = str2.Substring(str2.IndexOf(" ") + 1);

        item2.DiscID = _str2.Substring(0, _str2.IndexOf(" "));
        item2.DTitle = _str2.Substring(_str2.IndexOf(" ") + 1);

        ReturnedMatches.Add(item2);
      }

      return FreeDBQueryResult.FoundInexactMatches;
    }

    public string HTMLRead(string Category, string DiscID, ref string ReturnedArtist, ref string ReturnedAlbum, ref ArrayList ReturnedTracks, ref string ReturnedYear)
    {
      string vstrCommand = "";
      string str4 = "";
      string str3 = "";
      ArrayList list = new ArrayList();
      vstrCommand = "cddb+read+" + Category + "+" + DiscID;
      str4 = this.SendHTMLCommand(vstrCommand);

      try
      {
        str3 = str4.Substring(str4.IndexOf("DTITLE=") + 7);
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        str3 = "";
        ProjectData.ClearProjectError();
      }

      if (StringType.StrCmp(str3, "", false) != 0)
      {
        try
        {
          ReturnedArtist = str3.Substring(0, str3.IndexOf(" / "));
          str3 = str3.Substring(str3.IndexOf(" / ") + 3);
        }
        catch (Exception exception2)
        {
          ProjectData.SetProjectError(exception2);
          ReturnedArtist = "";
          ProjectData.ClearProjectError();
        }

        try
        {
          ReturnedAlbum = str3.Substring(0, str3.IndexOf("\r\n"));
          str3 = str3.Substring(str3.IndexOf("\r\n") + 2);
        }
        catch (Exception exception3)
        {
          ProjectData.SetProjectError(exception3);
          ReturnedAlbum = "";
          ProjectData.ClearProjectError();
        }

        str3 = str3.Replace("\r\n", "|");
        str3 = str3.Substring(0, str3.LastIndexOf("|"));
      }

      foreach (string _str3 in str3.Split(new char[] { '|' }))
      {
        if (_str3.StartsWith("T"))
          list.Add(_str3.Substring(_str3.IndexOf("=") - 2).Replace("TTITLE", "0"));

        else
        {
          if (!_str3.StartsWith("EXTD"))
            break;

          if (_str3.IndexOf("YEAR:") > 0)
          {
            ReturnedYear = _str3.Substring(_str3.IndexOf("YEAR:") + 5).Trim(new char[] { ' ' });

            if (ReturnedYear.Length > 4)
              ReturnedYear = Conversion.Val(ReturnedYear.Substring(0, 4)).ToString();
          }
          else
            ReturnedYear = "";
        }
      }

      string sLeft = "";

      foreach (string _str3 in list)
        sLeft = sLeft + "|" + _str3;

      sLeft = sLeft + "|";

      if (list.Count > 0)
      {
        byte num3 = (byte)(list.Count - 1);

        for (byte i = 0; i <= num3; i = (byte)(i + 1))
        {
          if (StringType.StrCmp(sLeft, "|", false) == 0)
            return str4;

          sLeft = sLeft.Replace("|" + i.ToString().PadLeft(2, '0') + "=", "");
          ReturnedTracks.Add(sLeft.Substring(0, sLeft.IndexOf("|")));
          sLeft = sLeft.Substring(sLeft.IndexOf("|"));
        }
      }

      return str4;
    }

    public FreeDBQueryResult Query(string DiscID, int[] TracksLength, ref ArrayList ReturnedMatches)
    {
      FreeDBQueryResult result;
      string vstrCommand = "";
      string str3 = "";
      int num3 = 150;
      int num2 = 0;

      if (!this.vbooConnected)
        return FreeDBQueryResult.NoHandshake;

      vstrCommand = "cddb query " + DiscID + " " + TracksLength.Length.ToString() + " ";

      foreach (int num in TracksLength)
      {
        vstrCommand = vstrCommand + num3.ToString() + " ";
        num3 += num * 0x4b;
        num2 += num;
      }

      vstrCommand = vstrCommand + num2.ToString() + "\r\n";
      str3 = this.SendCommand(vstrCommand).Replace("\r\n", "|");
      string sLeft = str3.Substring(0, 3);

      if (StringType.StrCmp(sLeft, "200", false) == 0)
      {
        str3 = str3.Substring(5).Replace("|", "");

        FreeDBQueryItem item = new FreeDBQueryItem
        {
          Category = str3.Substring(0, str3.IndexOf(" "))
        };

        str3 = str3.Substring(str3.IndexOf(" ") + 1);
        item.DiscID = str3.Substring(0, str3.IndexOf(" "));
        item.DTitle = str3.Substring(str3.IndexOf(" ") + 1);
        ReturnedMatches.Add(item);

        return FreeDBQueryResult.FoundExactMatch;
      }

      if (StringType.StrCmp(sLeft, "211", false) != 0)
        return FreeDBQueryResult.FoundInexactMatches;

      str3 = str3.Substring(0, str3.LastIndexOf(".") - 2);

      foreach (string str2 in str3.Substring(str3.IndexOf("|") + 1).Split(new char[] { '|' }))
      {
        FreeDBQueryItem item2 = new FreeDBQueryItem
        {
          Category = str2.Substring(0, str2.IndexOf(" "))
        };

        var _str2 = str2.Substring(str2.IndexOf(" ") + 1);

        item2.DiscID = _str2.Substring(0, _str2.IndexOf(" "));
        item2.DTitle = _str2.Substring(_str2.IndexOf(" ") + 1);

        ReturnedMatches.Add(item2);
      }

      return FreeDBQueryResult.FoundInexactMatches;
    }

    public string Read(string Category, string DiscID, ref string ReturnedArtist, ref string ReturnedAlbum, ref ArrayList ReturnedTracks, ref string ReturnedYear)
    {
      string vstrCommand = "";
      string str4 = "";
      string str3 = "";
      ArrayList list = new ArrayList();

      if (!this.vbooConnected)
        return string.Empty;

      vstrCommand = "cddb read " + Category + " " + DiscID + "\r\n";
      str4 = this.SendCommand(vstrCommand);

      try
      {
        str3 = str4.Substring(str4.IndexOf("DTITLE=") + 7);
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        str3 = "";
        ProjectData.ClearProjectError();
      }

      if (StringType.StrCmp(str3, "", false) != 0)
      {
        try
        {
          ReturnedArtist = str3.Substring(0, str3.IndexOf(" / "));
          str3 = str3.Substring(str3.IndexOf(" / ") + 3);
        }
        catch (Exception exception2)
        {
          ProjectData.SetProjectError(exception2);
          ReturnedArtist = "";
          ProjectData.ClearProjectError();
        }

        try
        {
          ReturnedAlbum = str3.Substring(0, str3.IndexOf("\r\n"));
          str3 = str3.Substring(str3.IndexOf("\r\n") + 2);
        }
        catch (Exception exception3)
        {
          ProjectData.SetProjectError(exception3);
          ReturnedAlbum = "";
          ProjectData.ClearProjectError();
        }

        str3 = str3.Replace("\r\n", "|");
        str3 = str3.Substring(0, str3.LastIndexOf("|"));
      }

      foreach (string _str3 in str3.Split(new char[] { '|' }))
      {
        if (_str3.StartsWith("T"))
          list.Add(_str3.Substring(_str3.IndexOf("=") - 2).Replace("TTITLE", "0"));
        else
        {
          if (!_str3.StartsWith("EXTD"))
            break;

          if (_str3.IndexOf("YEAR:") > 0)
          {
            ReturnedYear = _str3.Substring(_str3.IndexOf("YEAR:") + 5).Trim(new char[] { ' ' });
            if (ReturnedYear.Length > 4)
              ReturnedYear = Conversion.Val(ReturnedYear.Substring(0, 4)).ToString();
          }
          else
            ReturnedYear = "";
        }
      }

      string sLeft = "";

      foreach (string _str3 in list)
        sLeft = sLeft + "|" + _str3;

      sLeft = sLeft + "|";

      if (list.Count > 0)
      {
        byte num3 = (byte)(list.Count - 1);

        for (byte i = 0; i <= num3; i = (byte)(i + 1))
        {
          if (StringType.StrCmp(sLeft, "|", false) == 0)
            return str4;

          sLeft = sLeft.Replace("|" + i.ToString().PadLeft(2, '0') + "=", "");
          ReturnedTracks.Add(sLeft.Substring(0, sLeft.IndexOf("|")));
          sLeft = sLeft.Substring(sLeft.IndexOf("|"));
        }
      }

      return str4;
    }

    private string SendCommand(string vstrCommand)
    {
      string str2 = "";
      int length = 0;
      byte[] bytes = Encoding.Default.GetBytes(vstrCommand.ToCharArray());
      this.NetStream.Write(bytes, 0, bytes.Length);

      while (!this.NetStream.DataAvailable)
        Application.DoEvents();

      if (this.NetStream.DataAvailable)
      {
        byte[] buffer = new byte[(this.Client.ReceiveBufferSize - 1) + 1];
        length = this.NetStream.Read(buffer, 0, buffer.Length);
        str2 = Encoding.Default.GetString(buffer).Substring(0, length);
      }

      return str2;
    }

    private string SendHTMLCommand(string vstrCommand)
    {
      string str2 = "";
      string requestUriString = "";

      requestUriString = "http://" + Declarations.objSettings.FreeDBServer + "/~cddb/cddb.cgi?cmd=" + vstrCommand + "&hello=" + Declarations.objSettings.FreeDBUser + "+www.id3-tagit.de+ID3-TagIT+3.x&proto=1";

      try
      {
        str2 = new StreamReader(WebRequest.Create(requestUriString).GetResponse().GetResponseStream(), Encoding.Default, true).ReadToEnd();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
        return "999";
      }

      return str2;
    }

    public bool Connected
    {
      get
      {
        return this.vbooConnected;
      }
    }

    public enum FreeDBConnectResult
    {
      ConnectionFailed,
      ConnectionSucessful,
      ConnectionAlreadyExists
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FreeDBQueryItem
    {
      public string Category;
      public string DiscID;
      public string DTitle;
    }

    public enum FreeDBQueryResult
    {
      NoMatchFound,
      FoundExactMatch,
      FoundInexactMatches,
      DatabaseCorrupt,
      NoHandshake
    }
  }
}