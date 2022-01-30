namespace ID3_TagIT
{
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.Collections;
  using System.Data;
  using System.IO;
  using System.Runtime.Serialization.Formatters.Binary;
  using System.Windows.Forms;

  public class Settings
  {
    private ArrayList alstColumns = new ArrayList();
    private ArrayList alstFavNodes = new ArrayList();
    private ArrayList alstForms = new ArrayList();
    private DataSet ArtistLibrary = new DataSet("ArtistLibrary");
    private DataTable ArtistTable;
    private DataSet ColumnsLibrary = new DataSet("ColumnsLibrary");
    private DataTable ColumnsTable;
    private DataSet CommDLibrary = new DataSet("CommDescriptorsLibrary");
    private DataTable CommDTable;
    private DataTable CompareFormatTable;
    private DataSet ExceptionsLibrary = new DataSet("ExceptionsLibrary");
    private DataTable ExceptionsTable;
    private string FirstPath;
    private DataSet FormatsLibrary = new DataSet("FormatsLibrary");
    private DataTable FormsTable;
    private DataTable FT1Table;
    private DataTable FT2Table;
    private DataSet GenreLibrary = new DataSet("GenreLibrary");
    private DataTable GenreTable;
    private DataTable OrganizeTable;
    private DataTable SelectFormatTable;
    private DataRow SettingsRow;
    public DataTable SettingsTable;
    private DataTable T1FTable;
    private DataTable T2FTable;
    private DataSet ToolsLibrary = new DataSet("ToolsLibrary");
    private DataTable ToolsTable;
    private DataSet TotalSettings = new DataSet("Settings");

    public void ReadSettings()
    {
      DataColumn column;
      string path = (Declarations.vstrUserAppData + @"\Settings.xml").Replace(@"\\", @"\");
      string str = (Declarations.vstrUserAppData + @"\Libraries\Library-Artists.xml").Replace(@"\\", @"\");
      string str7 = (Declarations.vstrUserAppData + @"\Libraries\Library-Genres.xml").Replace(@"\\", @"\");
      string str6 = (Declarations.vstrUserAppData + @"\Libraries\Library-Formats.xml").Replace(@"\\", @"\");
      string str9 = (Declarations.vstrUserAppData + @"\Libraries\Library-Tools.xml").Replace(@"\\", @"\");
      string str2 = (Declarations.vstrUserAppData + @"\Libraries\Library-Columns.xml").Replace(@"\\", @"\");
      string str4 = (Declarations.vstrUserAppData + @"\Libraries\Library-Exceptions.xml").Replace(@"\\", @"\");
      string str5 = (Declarations.vstrUserAppData + @"\Libraries\Library-Favourites.xml").Replace(@"\\", @"\");
      string str3 = (Declarations.vstrUserAppData + @"\Libraries\Library-CommDescriptors.xml").Replace(@"\\", @"\");
      if (File.Exists(str))
      {
        this.ArtistLibrary.ReadXml(str);
        this.ArtistTable = this.ArtistLibrary.Tables["Artists"];
      }
      else
      {
        DataTable table = new DataTable("Artists");
        column = new DataColumn("Name", typeof(string));
        table.Columns.Add(column);
        this.ArtistLibrary.Tables.Add(table);
        this.ArtistTable = this.ArtistLibrary.Tables["Artists"];
      }
      if (File.Exists(str4))
      {
        this.ExceptionsLibrary.ReadXml(str4);
        this.ExceptionsTable = this.ExceptionsLibrary.Tables["Exceptions"];
      }
      else
      {
        DataTable table2 = new DataTable("Exceptions");
        column = new DataColumn("Name", typeof(string));
        table2.Columns.Add(column);
        this.ExceptionsLibrary.Tables.Add(table2);
        this.ExceptionsTable = this.ExceptionsLibrary.Tables["Exceptions"];
      }
      if (File.Exists(str7))
      {
        this.GenreLibrary.ReadXml(str7);
        this.GenreTable = this.GenreLibrary.Tables["Genres"];
      }
      else
      {
        DataTable table3 = new DataTable("Genres");
        column = new DataColumn("Name", typeof(string));
        table3.Columns.Add(column);
        column = new DataColumn("V1V2", typeof(byte));
        table3.Columns.Add(column);
        column = new DataColumn("V2V1", typeof(byte));
        table3.Columns.Add(column);
        this.GenreLibrary.Tables.Add(table3);
        UniqueConstraint constraint = new UniqueConstraint("GenreCons", this.GenreLibrary.Tables["Genres"].Columns["Name"], true);
        this.GenreLibrary.Tables["Genres"].Constraints.Add(constraint);
        this.GenreTable = this.GenreLibrary.Tables["Genres"];
      }
      if (File.Exists(str6))
      {
        this.FormatsLibrary.ReadXml(str6);
        this.OrganizeTable = this.FormatsLibrary.Tables[0];
        this.T1FTable = this.FormatsLibrary.Tables[1];
        this.FT1Table = this.FormatsLibrary.Tables[2];
        this.T2FTable = this.FormatsLibrary.Tables[3];
        this.FT2Table = this.FormatsLibrary.Tables[4];
        this.SelectFormatTable = this.FormatsLibrary.Tables[5];
        this.CompareFormatTable = this.FormatsLibrary.Tables[6];
      }
      if (File.Exists(str9))
      {
        this.ToolsLibrary.ReadXml(str9);
        this.ToolsTable = this.ToolsLibrary.Tables[0];
      }
      if (File.Exists(str3))
      {
        this.CommDLibrary.ReadXml(str3);
        this.CommDTable = this.CommDLibrary.Tables[0];
      }
      if (File.Exists(str2))
      {
        this.ColumnsLibrary.ReadXml(str2);
        this.ColumnsTable = this.ColumnsLibrary.Tables[0];
      }
      if (File.Exists(path))
      {
        this.TotalSettings.ReadXml(path);
        this.SettingsTable = this.TotalSettings.Tables[0];
        this.FormsTable = this.TotalSettings.Tables[1];
        this.SettingsRow = this.SettingsTable.Rows[0];
        this.FirstPath = this.CurrentPath;
      }
      try
      {
        IEnumerator enumerator = null;
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream serializationStream = new FileStream(str5, FileMode.OpenOrCreate);
        ArrayList list = (ArrayList)formatter.Deserialize(serializationStream);
        serializationStream.Close();
        try
        {
          enumerator = list.GetEnumerator();
          while (enumerator.MoveNext())
          {
            this.alstFavNodes.Add(((Favourite)enumerator.Current).CreateNode());
          }
        }
        finally
        {
          if (enumerator is IDisposable)
            ((IDisposable)enumerator).Dispose();
        }
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
    }

    public void WriteSettings()
    {
      string fileName = (Declarations.vstrUserAppData + @"\Settings.xml").Replace(@"\\", @"\");
      string str = (Declarations.vstrUserAppData + @"\Libraries\Library-Artists.xml").Replace(@"\\", @"\");
      string str7 = (Declarations.vstrUserAppData + @"\Libraries\Library-Genres.xml").Replace(@"\\", @"\");
      string str6 = (Declarations.vstrUserAppData + @"\Libraries\Library-Formats.xml").Replace(@"\\", @"\");
      string str9 = (Declarations.vstrUserAppData + @"\Libraries\Library-Tools.xml").Replace(@"\\", @"\");
      string str2 = (Declarations.vstrUserAppData + @"\Libraries\Library-Columns.xml").Replace(@"\\", @"\");
      string str4 = (Declarations.vstrUserAppData + @"\Libraries\Library-Exceptions.xml").Replace(@"\\", @"\");
      string path = (Declarations.vstrUserAppData + @"\Libraries\Library-Favourites.xml").Replace(@"\\", @"\");
      string str3 = (Declarations.vstrUserAppData + @"\Libraries\Library-CommDescriptors.xml").Replace(@"\\", @"\");
      if (!this.SaveFolder)
      {
        this.CurrentPath = this.FirstPath;
      }
      this.TotalSettings.WriteXml(fileName, XmlWriteMode.WriteSchema);
      this.ArtistLibrary.WriteXml(str, XmlWriteMode.WriteSchema);
      this.ExceptionsLibrary.WriteXml(str4, XmlWriteMode.WriteSchema);
      this.GenreLibrary.WriteXml(str7, XmlWriteMode.WriteSchema);
      this.FormatsLibrary.WriteXml(str6, XmlWriteMode.WriteSchema);
      this.ToolsLibrary.WriteXml(str9, XmlWriteMode.WriteSchema);
      this.ColumnsLibrary.WriteXml(str2, XmlWriteMode.WriteSchema);
      this.CommDLibrary.WriteXml(str3, XmlWriteMode.WriteSchema);
      BinaryFormatter formatter = new BinaryFormatter();
      FileStream serializationStream = new FileStream(path, FileMode.OpenOrCreate);
      ArrayList graph = new ArrayList();
      foreach (TreeNode node in this.alstFavNodes)
      {
        Favourite favourite = new Favourite();
        favourite.CreateFromNode(node);
        graph.Add(favourite);
      }
      formatter.Serialize(serializationStream, graph);
      serializationStream.Close();
    }

    public DataTable Artists
    {
      get
      {
        return this.ArtistTable;
      }
    }

    public bool AudioChecksumCalc
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["AudioChecksumCalc"]);
      }
      set
      {
        this.SettingsRow["AudioChecksumCalc"] = value;
      }
    }

    public int ColorChangedBack
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["ColorChangedBack"]);
      }
      set
      {
        this.SettingsRow["ColorChangedBack"] = value;
      }
    }

    public int ColorChangedText
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["ColorChangedText"]);
      }
      set
      {
        this.SettingsRow["ColorChangedText"] = value;
      }
    }

    public int ColorCompareBack
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["ColorCompareBack"]);
      }
      set
      {
        this.SettingsRow["ColorCompareBack"] = value;
      }
    }

    public int ColorCompareText
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["ColorCompareText"]);
      }
      set
      {
        this.SettingsRow["ColorCompareText"] = value;
      }
    }

    public int ColorDoubleBack
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["ColorDoubleBack"]);
      }
      set
      {
        this.SettingsRow["ColorDoubleBack"] = value;
      }
    }

    public int ColorDoubleText
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["ColorDoubleText"]);
      }
      set
      {
        this.SettingsRow["ColorDoubleText"] = value;
      }
    }

    public DataTable Columns
    {
      get
      {
        return this.ColumnsTable;
      }
    }

    public DataTable CommDescriptors
    {
      get
      {
        return this.CommDTable;
      }
    }

    public bool CompareFileTAGIgnoreCase
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["CompareFileTAGIgnoreCase"]);
      }
      set
      {
        this.SettingsRow["CompareFileTAGIgnoreCase"] = value;
      }
    }

    public bool CompareFileTAGReplace
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["CompareFileTAGReplace"]);
      }
      set
      {
        this.SettingsRow["CompareFileTAGReplace"] = value;
      }
    }

    public byte CompareFileTAGVersion
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["CompareFileTAGVersion"]);
      }
      set
      {
        this.SettingsRow["CompareFileTAGVersion"] = value;
      }
    }

    public string CompareFormat
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["CompareFormat"]);
      }
      set
      {
        this.SettingsRow["CompareFormat"] = value;
      }
    }

    public DataTable CompareFormats
    {
      get
      {
        return this.CompareFormatTable;
      }
    }

    public byte CompareMethod
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["CompareMethod"]);
      }
      set
      {
        this.SettingsRow["CompareMethod"] = value;
      }
    }

    public byte CompareTAGVersion
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["CompareTAGVersion"]);
      }
      set
      {
        this.SettingsRow["CompareTAGVersion"] = value;
      }
    }

    public bool ConvertAlbum
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertAlbum"]);
      }
      set
      {
        this.SettingsRow["ConvertAlbum"] = value;
      }
    }

    public bool ConvertAlwaysFirst
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertAlwaysFirst"]);
      }
      set
      {
        this.SettingsRow["ConvertAlwaysFirst"] = value;
      }
    }

    public bool ConvertArtist
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertArtist"]);
      }
      set
      {
        this.SettingsRow["ConvertArtist"] = value;
      }
    }

    public bool ConvertComment
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertComment"]);
      }
      set
      {
        this.SettingsRow["ConvertComment"] = value;
      }
    }

    public bool ConvertFilename
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertFilename"]);
      }
      set
      {
        this.SettingsRow["ConvertFilename"] = value;
      }
    }

    public byte ConvertMethod
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["ConvertMethod"]);
      }
      set
      {
        this.SettingsRow["ConvertMethod"] = value;
      }
    }

    public bool ConvertReplace20Space
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertReplace20Space"]);
      }
      set
      {
        this.SettingsRow["ConvertReplace20Space"] = value;
      }
    }

    public bool ConvertReplaceSpace20
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertReplaceSpace20"]);
      }
      set
      {
        this.SettingsRow["ConvertReplaceSpace20"] = value;
      }
    }

    public bool ConvertReplaceSpaceUnder
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertReplaceSpaceUnder"]);
      }
      set
      {
        this.SettingsRow["ConvertReplaceSpaceUnder"] = value;
      }
    }

    public bool ConvertReplaceUnderSpace
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertReplaceUnderSpace"]);
      }
      set
      {
        this.SettingsRow["ConvertReplaceUnderSpace"] = value;
      }
    }

    public bool ConvertSeparat
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertSeparat"]);
      }
      set
      {
        this.SettingsRow["ConvertSeparat"] = value;
      }
    }

    public string ConvertSeparator
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["ConvertSeparator"]);
      }
      set
      {
        this.SettingsRow["ConvertSeparator"] = value;
      }
    }

    public bool ConvertTitle
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertTitle"]);
      }
      set
      {
        this.SettingsRow["ConvertTitle"] = value;
      }
    }

    public bool ConvertVer1
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertVer1"]);
      }
      set
      {
        this.SettingsRow["ConvertVer1"] = value;
      }
    }

    public bool ConvertVer2
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ConvertVer2"]);
      }
      set
      {
        this.SettingsRow["ConvertVer2"] = value;
      }
    }

    public string CurrentPath
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["Path"]);
      }
      set
      {
        this.SettingsRow["Path"] = value;
      }
    }

    public byte EditDialog
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["EditDialog"]);
      }
      set
      {
        this.SettingsRow["EditDialog"] = value;
      }
    }

    public bool EnumFile
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["EnumFile"]);
      }
      set
      {
        this.SettingsRow["EnumFile"] = value;
      }
    }

    public string EnumSeparator
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["EnumSeparator"]);
      }
      set
      {
        this.SettingsRow["EnumSeparator"] = value;
      }
    }

    public bool EnumVer1
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["EnumVer1"]);
      }
      set
      {
        this.SettingsRow["EnumVer1"] = value;
      }
    }

    public bool EnumVer2
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["EnumVer2"]);
      }
      set
      {
        this.SettingsRow["EnumVer2"] = value;
      }
    }

    public bool ErrorExpanded
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ErrorExpanded"]);
      }
      set
      {
        this.SettingsRow["ErrorExpanded"] = value;
      }
    }

    public int ErrorHeight
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["ErrorHeight"]);
      }
      set
      {
        this.SettingsRow["ErrorHeight"] = value;
      }
    }

    public DataTable Exceptions
    {
      get
      {
        return this.ExceptionsTable;
      }
    }

    public bool ExplorerContext
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ExplorerContext"]);
      }
      set
      {
        this.SettingsRow["ExplorerContext"] = value;
      }
    }

    public ArrayList FavNodes
    {
      get
      {
        return this.alstFavNodes;
      }
    }

    public byte FilenumberDigits
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["FilenumberDigits"]);
      }
      set
      {
        this.SettingsRow["FilenumberDigits"] = value;
      }
    }

    public int FilenumberStart
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["FilenumberStart"]);
      }
      set
      {
        this.SettingsRow["FilenumberStart"] = value;
      }
    }

    public DataTable Forms
    {
      get
      {
        return this.FormsTable;
      }
    }

    public string FreeDBLastSearch
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["FreeDBLastSearch"]);
      }
      set
      {
        this.SettingsRow["FreeDBLastSearch"] = value;
      }
    }

    public int FreeDBPort
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["FreeDBPort"]);
      }
      set
      {
        this.SettingsRow["FreeDBPort"] = value;
      }
    }

    public string FreeDBProxyPassword
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["FreeDBProxyPassword"]);
      }
      set
      {
        this.SettingsRow["FreeDBProxyPassword"] = value;
      }
    }

    public int FreeDBProxyPort
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["FreeDBProxyPort"]);
      }
      set
      {
        this.SettingsRow["FreeDBProxyPort"] = value;
      }
    }

    public string FreeDBProxyServer
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["FreeDBProxyServer"]);
      }
      set
      {
        this.SettingsRow["FreeDBProxyServer"] = value;
      }
    }

    public bool FreeDBProxyUse
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["FreeDBProxyUse"]);
      }
      set
      {
        this.SettingsRow["FreeDBProxyUse"] = value;
      }
    }

    public string FreeDBProxyUser
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["FreeDBProxyUser"]);
      }
      set
      {
        this.SettingsRow["FreeDBProxyUser"] = value;
      }
    }

    public byte FreeDBSearchOptions
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["FreeDBSearchOptions"]);
      }
      set
      {
        this.SettingsRow["FreeDBSearchOptions"] = value;
      }
    }

    public string FreeDBServer
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["FreeDBServer"]);
      }
      set
      {
        this.SettingsRow["FreeDBServer"] = value;
      }
    }

    public bool FreeDBSingleArtist
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["FreeDBSingleArtist"]);
      }
      set
      {
        this.SettingsRow["FreeDBSingleArtist"] = value;
      }
    }

    public string FreeDBUser
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["FreeDBUser"]);
      }
      set
      {
        this.SettingsRow["FreeDBUser"] = value;
      }
    }

    public bool FreeDBWrite1
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["FreeDBWrite1"]);
      }
      set
      {
        this.SettingsRow["FreeDBWrite1"] = value;
      }
    }

    public bool FreeDBWrite2
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["FreeDBWrite2"]);
      }
      set
      {
        this.SettingsRow["FreeDBWrite2"] = value;
      }
    }

    public string FT1Format
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["FT1Format"]);
      }
      set
      {
        this.SettingsRow["FT1Format"] = value;
      }
    }

    public DataTable FT1Formats
    {
      get
      {
        return this.FT1Table;
      }
    }

    public string FT2Format
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["FT2Format"]);
      }
      set
      {
        this.SettingsRow["FT2Format"] = value;
      }
    }

    public DataTable FT2Formats
    {
      get
      {
        return this.FT2Table;
      }
    }

    public DataTable Genres
    {
      get
      {
        return this.GenreTable;
      }
    }

    public bool HTMLColored
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["HTMLColored"]);
      }
      set
      {
        this.SettingsRow["HTMLColored"] = value;
      }
    }

    public bool HTMLGridlines
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["HTMLGridlines"]);
      }
      set
      {
        this.SettingsRow["HTMLGridlines"] = value;
      }
    }

    public string HTMLListTitle
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["HTMLListTitle"]);
      }
      set
      {
        this.SettingsRow["HTMLListTitle"] = value;
      }
    }

    public string HTMLListWidth
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["HTMLListWidth"]);
      }
      set
      {
        this.SettingsRow["HTMLListWidth"] = value;
      }
    }

    public string HTMLListWidthUnit
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["HTMLListWidthUnit"]);
      }
      set
      {
        this.SettingsRow["HTMLListWidthUnit"] = value;
      }
    }

    public byte HTMLTAGVersion
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["HTMLTAGVersion"]);
      }
      set
      {
        this.SettingsRow["HTMLTAGVersion"] = value;
      }
    }

    public bool IgnoreWrite
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["IgnoreWrite"]);
      }
      set
      {
        this.SettingsRow["IgnoreWrite"] = value;
      }
    }

    public byte Language
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["Language"]);
      }
      set
      {
        this.SettingsRow["Language"] = value;
      }
    }

    public string ListColumns
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["ListColumns"]);
      }
      set
      {
        this.SettingsRow["ListColumns"] = value;
      }
    }

    public string ListExtInfo
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["ListExtInfo"]);
      }
      set
      {
        this.SettingsRow["ListExtInfo"] = value;
      }
    }

    public string ListPath
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["ListPath"]);
      }
      set
      {
        this.SettingsRow["ListPath"] = value;
      }
    }

    public byte ListStyle
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["ListStyle"]);
      }
      set
      {
        this.SettingsRow["ListStyle"] = value;
      }
    }

    public bool MouseFilenameEditing
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["MouseFilenameEditing"]);
      }
      set
      {
        this.SettingsRow["MouseFilenameEditing"] = value;
      }
    }

    public string MoveCopyPath
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["MoveCopyPath"]);
      }
      set
      {
        this.SettingsRow["MoveCopyPath"] = value;
      }
    }

    public bool NavPanExpanded
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["NavPanExpanded"]);
      }
      set
      {
        this.SettingsRow["NavPanExpanded"] = value;
      }
    }

    public int NavPanWidth
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["NavPanWidth"]);
      }
      set
      {
        this.SettingsRow["NavPanWidth"] = value;
      }
    }

    public byte NewV2Version
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["NewV2Version"]);
      }
      set
      {
        this.SettingsRow["NewV2Version"] = value;
      }
    }

    public bool OrganizeCopy
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["OrganizeCopy"]);
      }
      set
      {
        this.SettingsRow["OrganizeCopy"] = value;
      }
    }

    public string OrganizeFormat
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["OrganizeFormat"]);
      }
      set
      {
        this.SettingsRow["OrganizeFormat"] = value;
      }
    }

    public DataTable OrganizeFormats
    {
      get
      {
        return this.OrganizeTable;
      }
    }

    public bool OrganizeOverwrite
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["OrganizeOverwrite"]);
      }
      set
      {
        this.SettingsRow["OrganizeOverwrite"] = value;
      }
    }

    public string OrganizePath
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["OrganizePath"]);
      }
      set
      {
        this.SettingsRow["OrganizePath"] = value;
      }
    }

    public byte OrganizeVersion
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["OrganizeVersion"]);
      }
      set
      {
        this.SettingsRow["OrganizeVersion"] = value;
      }
    }

    public bool OwnGenreOnly
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["OwnGenreOnly"]);
      }
      set
      {
        this.SettingsRow["OwnGenreOnly"] = value;
      }
    }

    public string Play
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["Play"]);
      }
      set
      {
        this.SettingsRow["Play"] = value;
      }
    }

    public bool PlaylistRelPath
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["PlaylistRelPath"]);
      }
      set
      {
        this.SettingsRow["PlaylistRelPath"] = value;
      }
    }

    public bool QuickFilenameEditing
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["QuickFilenameEditing"]);
      }
      set
      {
        this.SettingsRow["QuickFilenameEditing"] = value;
      }
    }

    public bool RebuildOFilename
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["RebuildOFilename"]);
      }
      set
      {
        this.SettingsRow["RebuildOFilename"] = value;
      }
    }

    public bool RestoreDate
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["RestoreDate"]);
      }
      set
      {
        this.SettingsRow["RestoreDate"] = value;
      }
    }

    public bool SaveFolder
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SaveFolder"]);
      }
      set
      {
        this.SettingsRow["SaveFolder"] = value;
      }
    }

    public bool SaveOFilename
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SaveOFilename"]);
      }
      set
      {
        this.SettingsRow["SaveOFilename"] = value;
      }
    }

    public bool ScanSubDirs
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["ScanSubDirs"]);
      }
      set
      {
        this.SettingsRow["ScanSubDirs"] = value;
      }
    }

    public bool SearchAlbum
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchAlbum"]);
      }
      set
      {
        this.SettingsRow["SearchAlbum"] = value;
      }
    }

    public bool SearchAndOr
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchAndOr"]);
      }
      set
      {
        this.SettingsRow["SearchAndOr"] = value;
      }
    }

    public bool SearchArtist
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchArtist"]);
      }
      set
      {
        this.SettingsRow["SearchArtist"] = value;
      }
    }

    public bool SearchCase
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchCase"]);
      }
      set
      {
        this.SettingsRow["SearchCase"] = value;
      }
    }

    public bool SearchComment
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchComment"]);
      }
      set
      {
        this.SettingsRow["SearchComment"] = value;
      }
    }

    public bool SearchFilename
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchFilename"]);
      }
      set
      {
        this.SettingsRow["SearchFilename"] = value;
      }
    }

    public bool SearchGenre
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchGenre"]);
      }
      set
      {
        this.SettingsRow["SearchGenre"] = value;
      }
    }

    public bool SearchRegExpression
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchRegExpression"]);
      }
      set
      {
        this.SettingsRow["SearchRegExpression"] = value;
      }
    }

    public string SearchReplaceText
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["SearchReplaceText"]);
      }
      set
      {
        this.SettingsRow["SearchReplaceText"] = value;
      }
    }

    public string SearchSearchText
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["SearchSearchText"]);
      }
      set
      {
        this.SettingsRow["SearchSearchText"] = value;
      }
    }

    public bool SearchSelected
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchSelected"]);
      }
      set
      {
        this.SettingsRow["SearchSelected"] = value;
      }
    }

    public bool SearchTitle
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchTitle"]);
      }
      set
      {
        this.SettingsRow["SearchTitle"] = value;
      }
    }

    public bool SearchTracknumber
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchTracknumber"]);
      }
      set
      {
        this.SettingsRow["SearchTracknumber"] = value;
      }
    }

    public bool SearchVer1
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchVer1"]);
      }
      set
      {
        this.SettingsRow["SearchVer1"] = value;
      }
    }

    public bool SearchVer2
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchVer2"]);
      }
      set
      {
        this.SettingsRow["SearchVer2"] = value;
      }
    }

    public bool SearchYear
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SearchYear"]);
      }
      set
      {
        this.SettingsRow["SearchYear"] = value;
      }
    }

    public string SelectFormat
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["SelectFormat"]);
      }
      set
      {
        this.SettingsRow["SelectFormat"] = value;
      }
    }

    public DataTable SelectFormats
    {
      get
      {
        return this.SelectFormatTable;
      }
    }

    public byte SelectionMode
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["SelectionMode"]);
      }
      set
      {
        this.SettingsRow["SelectionMode"] = value;
      }
    }

    public bool SideBarExpanded
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SideBarExpanded"]);
      }
      set
      {
        this.SettingsRow["SideBarExpanded"] = value;
      }
    }

    public int SideBarWidth
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["SideBarWidth"]);
      }
      set
      {
        this.SettingsRow["SideBarWidth"] = value;
      }
    }

    public bool SingleGC
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SingleGC"]);
      }
      set
      {
        this.SettingsRow["SingleGC"] = value;
      }
    }

    public string SplitSeparator
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["SplitSeparator"]);
      }
      set
      {
        this.SettingsRow["SplitSeparator"] = value;
      }
    }

    public bool SynchronizeTAGs
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["SynchronizeTAGs"]);
      }
      set
      {
        this.SettingsRow["SynchronizeTAGs"] = value;
      }
    }

    public string T1FFormat
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["T1FFormat"]);
      }
      set
      {
        this.SettingsRow["T1FFormat"] = value;
      }
    }

    public DataTable T1FFormats
    {
      get
      {
        return this.T1FTable;
      }
    }

    public string T2FFormat
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["T2FFormat"]);
      }
      set
      {
        this.SettingsRow["T2FFormat"] = value;
      }
    }

    public DataTable T2FFormats
    {
      get
      {
        return this.T2FTable;
      }
    }

    public DataTable Tools
    {
      get
      {
        return this.ToolsTable;
      }
    }

    public byte TracknumberDigitsFilename
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["TracknumberDigitsFilename"]);
      }
      set
      {
        this.SettingsRow["TracknumberDigitsFilename"] = value;
      }
    }

    public byte TracknumberDigitsTAG
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["TracknumberDigitsTAG"]);
      }
      set
      {
        this.SettingsRow["TracknumberDigitsTAG"] = value;
      }
    }

    public bool TransferAlbum12
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferAlbum12"]);
      }
      set
      {
        this.SettingsRow["TransferAlbum12"] = value;
      }
    }

    public bool TransferAlbum21
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferAlbum21"]);
      }
      set
      {
        this.SettingsRow["TransferAlbum21"] = value;
      }
    }

    public bool TransferArtist12
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferArtist12"]);
      }
      set
      {
        this.SettingsRow["TransferArtist12"] = value;
      }
    }

    public bool TransferArtist21
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferArtist21"]);
      }
      set
      {
        this.SettingsRow["TransferArtist21"] = value;
      }
    }

    public bool TransferComment12
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferComment12"]);
      }
      set
      {
        this.SettingsRow["TransferComment12"] = value;
      }
    }

    public bool TransferComment21
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferComment21"]);
      }
      set
      {
        this.SettingsRow["TransferComment21"] = value;
      }
    }

    public string TransferCommentD
    {
      get
      {
        return StringType.FromObject(this.SettingsRow["TransferCommentD"]);
      }
      set
      {
        this.SettingsRow["TransferCommentD"] = value;
      }
    }

    public bool TransferGenre12
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferGenre12"]);
      }
      set
      {
        this.SettingsRow["TransferGenre12"] = value;
      }
    }

    public bool TransferGenre21
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferGenre21"]);
      }
      set
      {
        this.SettingsRow["TransferGenre21"] = value;
      }
    }

    public bool TransferKeep12
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferKeep12"]);
      }
      set
      {
        this.SettingsRow["TransferKeep12"] = value;
      }
    }

    public bool TransferKeep21
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferKeep21"]);
      }
      set
      {
        this.SettingsRow["TransferKeep21"] = value;
      }
    }

    public byte TransferMethod
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["TransferMethod"]);
      }
      set
      {
        this.SettingsRow["TransferMethod"] = value;
      }
    }

    public bool TransferTitle12
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferTitle12"]);
      }
      set
      {
        this.SettingsRow["TransferTitle12"] = value;
      }
    }

    public bool TransferTitle21
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferTitle21"]);
      }
      set
      {
        this.SettingsRow["TransferTitle21"] = value;
      }
    }

    public bool TransferTrack12
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferTrack12"]);
      }
      set
      {
        this.SettingsRow["TransferTrack12"] = value;
      }
    }

    public bool TransferTrack21
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferTrack21"]);
      }
      set
      {
        this.SettingsRow["TransferTrack21"] = value;
      }
    }

    public bool TransferYear12
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferYear12"]);
      }
      set
      {
        this.SettingsRow["TransferYear12"] = value;
      }
    }

    public bool TransferYear21
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["TransferYear21"]);
      }
      set
      {
        this.SettingsRow["TransferYear21"] = value;
      }
    }

    public bool UseThemes
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["UseThemes"]);
      }
      set
      {
        this.SettingsRow["UseThemes"] = value;
      }
    }

    public byte V23Encoding
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["V23Encoding"]);
      }
      set
      {
        this.SettingsRow["V23Encoding"] = value;
      }
    }

    public byte V24Encoding
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["V24Encoding"]);
      }
      set
      {
        this.SettingsRow["V24Encoding"] = value;
      }
    }

    public int V2Language
    {
      get
      {
        return IntegerType.FromObject(this.SettingsRow["V2Language"]);
      }
      set
      {
        this.SettingsRow["V2Language"] = value;
      }
    }

    public byte V2YearOnly
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["V2YearOnly"]);
      }
      set
      {
        this.SettingsRow["V2YearOnly"] = value;
      }
    }

    public byte VersionToShow
    {
      get
      {
        return ByteType.FromObject(this.SettingsRow["VersionToShow"]);
      }
      set
      {
        this.SettingsRow["VersionToShow"] = value;
      }
    }

    public bool WriteUnsync
    {
      get
      {
        return BooleanType.FromObject(this.SettingsRow["WriteUnsync"]);
      }
      set
      {
        this.SettingsRow["WriteUnsync"] = value;
      }
    }

    [Serializable]
    private class Favourite
    {
      private ArrayList alstDirs = new ArrayList();
      private string vstrName;

      public void CreateFromNode(TreeNode objNode)
      {
        IEnumerator enumerator = null;
        TreeNode current = new TreeNode();
        this.vstrName = objNode.Text;
        try
        {
          enumerator = objNode.Nodes.GetEnumerator();
          while (enumerator.MoveNext())
          {
            current = (TreeNode)enumerator.Current;
            this.alstDirs.Add(current.Text);
          }
        }
        finally
        {
          if (enumerator is IDisposable)
            ((IDisposable)enumerator).Dispose();
        }
      }

      public TreeNode CreateNode()
      {
        TreeNode node2 = new TreeNode(this.vstrName);
        var enumerator = this.alstDirs.GetEnumerator();
        while (enumerator.MoveNext())
        {
          string text = StringType.FromObject(enumerator.Current);
          node2.Nodes.Add(text);
        }
        return node2;
      }

      public ArrayList FavDirs
      {
        get
        {
          return this.alstDirs;
        }
        set
        {
          this.alstDirs = value;
        }
      }

      public string FavName
      {
        get
        {
          return this.vstrName;
        }
        set
        {
          this.vstrName = value;
        }
      }
    }
  }
}