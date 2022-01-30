namespace ID3_TagIT
{
  using AMS.TextBox;
  using DevComponents.DotNetBar;
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using Microsoft.Win32;
  using System;
  using System.Collections;
  using System.ComponentModel;
  using System.Data;
  using System.Diagnostics;
  using System.Drawing;
  using System.Resources;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public class frmPreferences : Form
  {
    [AccessedThroughProperty("btnAdd")]
    private Button _btnAdd;
    [AccessedThroughProperty("btnBrowse")]
    private Button _btnBrowse;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnDown")]
    private Button _btnDown;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnRemove")]
    private Button _btnRemove;
    [AccessedThroughProperty("btnUp")]
    private Button _btnUp;
    [AccessedThroughProperty("ButtomPanel")]
    private PanelEx _ButtomPanel;
    [AccessedThroughProperty("C1")]
    private DataGridTextBoxColumn _C1;
    [AccessedThroughProperty("C2")]
    private DataGridTextBoxColumn _C2;
    [AccessedThroughProperty("C3")]
    private DataGridTextBoxColumn _C3;
    [AccessedThroughProperty("C4")]
    private DataGridBoolColumn _C4;
    [AccessedThroughProperty("C5")]
    private DataGridTextBoxColumn _C5;
    [AccessedThroughProperty("chkAudioChecksumCalc")]
    private CheckBox _chkAudioChecksumCalc;
    [AccessedThroughProperty("chkDefault")]
    private CheckBox _chkDefault;
    [AccessedThroughProperty("chkExplorerContext")]
    private CheckBox _chkExplorerContext;
    [AccessedThroughProperty("chkIgnoreWrite")]
    private CheckBox _chkIgnoreWrite;
    [AccessedThroughProperty("chkMouseRenaming")]
    private CheckBox _chkMouseRenaming;
    [AccessedThroughProperty("chkProxy")]
    private CheckBox _chkProxy;
    [AccessedThroughProperty("chkRestore")]
    private CheckBox _chkRestore;
    [AccessedThroughProperty("chkSaveOnExit")]
    private CheckBox _chkSaveOnExit;
    [AccessedThroughProperty("chkSingle")]
    private CheckBox _chkSingle;
    [AccessedThroughProperty("chkUnSync")]
    private CheckBox _chkUnSync;
    [AccessedThroughProperty("chkWinXPThemes")]
    private CheckBox _chkWinXPThemes;
    [AccessedThroughProperty("cmbPlay")]
    private ComboBox _cmbPlay;
    [AccessedThroughProperty("cmbShell")]
    private ComboBox _cmbShell;
    [AccessedThroughProperty("cmbV23Enc")]
    private ComboBox _cmbV23Enc;
    [AccessedThroughProperty("cmbV24Enc")]
    private ComboBox _cmbV24Enc;
    [AccessedThroughProperty("cmbYearFormat")]
    private ComboBox _cmbYearFormat;
    [AccessedThroughProperty("ColorChangedBack")]
    private Button _ColorChangedBack;
    [AccessedThroughProperty("ColorChangedText")]
    private Button _ColorChangedText;
    [AccessedThroughProperty("ColorCompareBack")]
    private Button _ColorCompareBack;
    [AccessedThroughProperty("ColorCompareText")]
    private Button _ColorCompareText;
    [AccessedThroughProperty("ColorDialog")]
    private System.Windows.Forms.ColorDialog _ColorDialog;
    [AccessedThroughProperty("ColorDoubleBack")]
    private Button _ColorDoubleBack;
    [AccessedThroughProperty("ColorDoubleText")]
    private Button _ColorDoubleText;
    [AccessedThroughProperty("Colors")]
    private TabItem _Colors;
    [AccessedThroughProperty("Columns")]
    private TabItem _Columns;
    [AccessedThroughProperty("ColumnsList")]
    private ListView _ColumnsList;
    [AccessedThroughProperty("frameDoubleClick")]
    private GroupBox _frameDoubleClick;
    [AccessedThroughProperty("frameEnum")]
    private GroupBox _frameEnum;
    [AccessedThroughProperty("frameSelection")]
    private GroupBox _frameSelection;
    [AccessedThroughProperty("FreeDB")]
    private TabItem _FreeDB;
    [AccessedThroughProperty("grpProxy")]
    private GroupBox _grpProxy;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("lbl1")]
    private Label _lbl1;
    [AccessedThroughProperty("lbl2")]
    private Label _lbl2;
    [AccessedThroughProperty("lblDescript")]
    private Label _lblDescript;
    [AccessedThroughProperty("lblDescription")]
    private Label _lblDescription;
    [AccessedThroughProperty("lblDigits")]
    private Label _lblDigits;
    [AccessedThroughProperty("lblEnumSep")]
    private Label _lblEnumSep;
    [AccessedThroughProperty("lblFormat")]
    private Label _lblFormat;
    [AccessedThroughProperty("lblP")]
    private Label _lblP;
    [AccessedThroughProperty("lblParameters")]
    private Label _lblParameters;
    [AccessedThroughProperty("lblPath")]
    private Label _lblPath;
    [AccessedThroughProperty("lblPlay")]
    private Label _lblPlay;
    [AccessedThroughProperty("lblPort")]
    private Label _lblPort;
    [AccessedThroughProperty("lblServer")]
    private Label _lblServer;
    [AccessedThroughProperty("lblTextEncInfo")]
    private Label _lblTextEncInfo;
    [AccessedThroughProperty("lblTracknumbers")]
    private Label _lblTracknumbers;
    [AccessedThroughProperty("lblUsername")]
    private Label _lblUsername;
    [AccessedThroughProperty("lblV23")]
    private Label _lblV23;
    [AccessedThroughProperty("lblV24")]
    private Label _lblV24;
    [AccessedThroughProperty("OpenFileDialog")]
    private System.Windows.Forms.OpenFileDialog _OpenFileDialog;
    [AccessedThroughProperty("optAdd")]
    private RadioButton _optAdd;
    [AccessedThroughProperty("optEditCur")]
    private RadioButton _optEditCur;
    [AccessedThroughProperty("optEditV1")]
    private RadioButton _optEditV1;
    [AccessedThroughProperty("optEditV2")]
    private RadioButton _optEditV2;
    [AccessedThroughProperty("optSingle")]
    private RadioButton _optSingle;
    [AccessedThroughProperty("optUse23")]
    private RadioButton _optUse23;
    [AccessedThroughProperty("optUse24")]
    private RadioButton _optUse24;
    [AccessedThroughProperty("Port")]
    private NumericTextBox _Port;
    [AccessedThroughProperty("Server")]
    private System.Windows.Forms.TextBox _Server;
    [AccessedThroughProperty("Settings")]
    private TabItem _Settings;
    [AccessedThroughProperty("Style")]
    private DataGridTableStyle _Style;
    [AccessedThroughProperty("TabControl")]
    private DevComponents.DotNetBar.TabControl _TabControl;
    [AccessedThroughProperty("TabControlPanel1")]
    private TabControlPanel _TabControlPanel1;
    [AccessedThroughProperty("TabControlPanel2")]
    private TabControlPanel _TabControlPanel2;
    [AccessedThroughProperty("TabControlPanel3")]
    private TabControlPanel _TabControlPanel3;
    [AccessedThroughProperty("TabControlPanel4")]
    private TabControlPanel _TabControlPanel4;
    [AccessedThroughProperty("TabControlPanel5")]
    private TabControlPanel _TabControlPanel5;
    [AccessedThroughProperty("TabControlPanel6")]
    private TabControlPanel _TabControlPanel6;
    [AccessedThroughProperty("ToolGrid")]
    private DataGrid _ToolGrid;
    [AccessedThroughProperty("Tools")]
    private TabItem _Tools;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("txtDescription")]
    private System.Windows.Forms.TextBox _txtDescription;
    [AccessedThroughProperty("txtEnumSep")]
    private System.Windows.Forms.TextBox _txtEnumSep;
    [AccessedThroughProperty("txtFDigits")]
    private NumericUpDown _txtFDigits;
    [AccessedThroughProperty("txtParameters")]
    private System.Windows.Forms.TextBox _txtParameters;
    [AccessedThroughProperty("txtPath")]
    private System.Windows.Forms.TextBox _txtPath;
    [AccessedThroughProperty("txtProxyPassword")]
    private System.Windows.Forms.TextBox _txtProxyPassword;
    [AccessedThroughProperty("txtProxyPort")]
    private NumericTextBox _txtProxyPort;
    [AccessedThroughProperty("txtProxyServer")]
    private System.Windows.Forms.TextBox _txtProxyServer;
    [AccessedThroughProperty("txtProxyUser")]
    private System.Windows.Forms.TextBox _txtProxyUser;
    [AccessedThroughProperty("txtStartNr")]
    private NumericUpDown _txtStartNr;
    [AccessedThroughProperty("txtTFDigits")]
    private NumericUpDown _txtTFDigits;
    [AccessedThroughProperty("txtTTDigits")]
    private NumericUpDown _txtTTDigits;
    [AccessedThroughProperty("Username")]
    private System.Windows.Forms.TextBox _Username;
    [AccessedThroughProperty("Ver2")]
    private TabItem _Ver2;
    private bool ColumnSettingsChanged;
    private IContainer components;
    private frmMain MainForm;
    private bool vbooChecking;

    public frmPreferences(frmMain Main)
    {
      base.Load += new EventHandler(this.frmOptions_Load);
      this.ColumnSettingsChanged = false;
      this.vbooChecking = false;
      this.InitializeComponent();
      this.MainForm = Main;
      this.AddColumns();
    }

    public void AddColumns()
    {
      bool flag = false;
      int num = 0;
      this.ColumnsList.Columns.Add("Name", this.ColumnsList.Width - 0x19, HorizontalAlignment.Left);
      num3 = 0;
      foreach (int num3 in Main.GetColumnOrder(this.MainForm.MP3View))
      {
        ListViewItem item2 = new ListViewItem();
        ArrayList list = new ArrayList();
        ColumnHeader header = this.MainForm.MP3View.Columns[num3];
        if (header == this.MainForm.colHFilename)
        {
          list.Add(1);
        }
        if (header == this.MainForm.colHSubDir)
        {
          list.Add(2);
        }
        if (header == this.MainForm.colHTAGVer1)
        {
          list.Add(3);
        }
        if (header == this.MainForm.colHTAGVer2)
        {
          list.Add(4);
        }
        if (header == this.MainForm.colHArtist)
        {
          list.Add(5);
        }
        if (header == this.MainForm.colHTitle)
        {
          list.Add(6);
        }
        if (header == this.MainForm.colHAlbum)
        {
          list.Add(7);
        }
        if (header == this.MainForm.colHTrack)
        {
          list.Add(8);
        }
        if (header == this.MainForm.colHPosMedia)
        {
          list.Add(9);
        }
        if (header == this.MainForm.colHComment)
        {
          list.Add(10);
        }
        if (header == this.MainForm.colHGenre)
        {
          list.Add(11);
        }
        if (header == this.MainForm.colHYear)
        {
          list.Add(12);
        }
        if (header == this.MainForm.colHRating)
        {
          list.Add(13);
        }
        if (header == this.MainForm.colHDuration)
        {
          list.Add(14);
        }
        if (header == this.MainForm.colHBitrate)
        {
          list.Add(15);
        }
        if (header == this.MainForm.colHVBR)
        {
          list.Add(0x10);
        }
        if (header == this.MainForm.colHSamplerate)
        {
          list.Add(0x11);
        }
        if (header == this.MainForm.colHChannel)
        {
          list.Add(0x12);
        }
        if (header == this.MainForm.colHVersion)
        {
          list.Add(0x13);
        }
        if (header == this.MainForm.colHDate)
        {
          list.Add(20);
        }
        if (header == this.MainForm.colHComposer)
        {
          list.Add(0x15);
        }
        if (header == this.MainForm.colHFileSize)
        {
          list.Add(0x16);
        }
        if (header == this.MainForm.colHBPM)
        {
          list.Add(0x17);
        }
        if (header == this.MainForm.colHPicCount)
        {
          list.Add(0x18);
        }
        if (header == this.MainForm.colHAudioCheckSum)
        {
          list.Add(0x19);
        }
        if (header == this.MainForm.colHCreateDate)
        {
          list.Add(0x1a);
        }
        list.Add(header.Width);
        list.Add(header.TextAlign.ToString());
        item2.Text = header.Text;
        item2.Checked = true;
        item2.Tag = list;
        this.ColumnsList.Items.Add(item2);
      }
      num = 2;
      do
      {
        foreach (ListViewItem item in this.ColumnsList.Items)
        {
          if (ObjectType.ObjTst(LateBinding.LateIndexGet(item.Tag, new object[] { 0 }, null), num, false) == 0)
          {
            flag = true;
            break;
          }
        }
        if (!flag)
        {
          ListViewItem item3 = new ListViewItem(Convert.ToString(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["Col" + num.ToString().PadLeft(2, '0')])));
          ArrayList list2 = new ArrayList {
                        num,
                        150
                    };
          switch (num)
          {
            case 8:
            case 9:
            case 12:
            case 13:
            case 15:
            case 0x11:
            case 0x16:
            case 0x17:
            case 0x18:
            case 0x19:
              list2.Add("Right");
              break;

            default:
              list2.Add("Left");
              break;
          }
          item3.Checked = false;
          item3.Tag = list2;
          this.ColumnsList.Items.Add(item3);
        }
        flag = false;
        num++;
      }
      while (num <= 0x1a);
    }

    private void AddToolTips()
    {
      string vstrName = "frmPreferences";
      Control cmbPlay = this.cmbPlay;
      this.cmbPlay = (ComboBox)cmbPlay;
      this.ToolTip.SetToolTip(this.cmbPlay, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkExplorerContext;
      this.chkExplorerContext = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkExplorerContext, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.txtFDigits;
      this.txtFDigits = (NumericUpDown)cmbPlay;
      this.ToolTip.SetToolTip(this.txtFDigits, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.txtEnumSep;
      this.txtEnumSep = (System.Windows.Forms.TextBox)cmbPlay;
      this.ToolTip.SetToolTip(this.txtEnumSep, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.txtStartNr;
      this.txtStartNr = (NumericUpDown)cmbPlay;
      this.ToolTip.SetToolTip(this.txtStartNr, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkMouseRenaming;
      this.chkMouseRenaming = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkMouseRenaming, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkRestore;
      this.chkRestore = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkRestore, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.txtTFDigits;
      this.txtTFDigits = (NumericUpDown)cmbPlay;
      this.ToolTip.SetToolTip(this.txtTFDigits, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.optAdd;
      this.optAdd = (RadioButton)cmbPlay;
      this.ToolTip.SetToolTip(this.optAdd, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.optSingle;
      this.optSingle = (RadioButton)cmbPlay;
      this.ToolTip.SetToolTip(this.optSingle, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkSaveOnExit;
      this.chkSaveOnExit = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkSaveOnExit, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.optEditCur;
      this.optEditCur = (RadioButton)cmbPlay;
      this.ToolTip.SetToolTip(this.optEditCur, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.optEditV1;
      this.optEditV1 = (RadioButton)cmbPlay;
      this.ToolTip.SetToolTip(this.optEditV1, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.optEditV2;
      this.optEditV2 = (RadioButton)cmbPlay;
      this.ToolTip.SetToolTip(this.optEditV2, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkIgnoreWrite;
      this.chkIgnoreWrite = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkIgnoreWrite, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkAudioChecksumCalc;
      this.chkAudioChecksumCalc = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkAudioChecksumCalc, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.ColumnsList;
      this.ColumnsList = (ListView)cmbPlay;
      this.ToolTip.SetToolTip(this.ColumnsList, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.btnUp;
      this.btnUp = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.btnUp, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.btnDown;
      this.btnDown = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.btnDown, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.cmbYearFormat;
      this.cmbYearFormat = (ComboBox)cmbPlay;
      this.ToolTip.SetToolTip(this.cmbYearFormat, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.txtTTDigits;
      this.txtTTDigits = (NumericUpDown)cmbPlay;
      this.ToolTip.SetToolTip(this.txtTTDigits, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.cmbV24Enc;
      this.cmbV24Enc = (ComboBox)cmbPlay;
      this.ToolTip.SetToolTip(this.cmbV24Enc, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.cmbV23Enc;
      this.cmbV23Enc = (ComboBox)cmbPlay;
      this.ToolTip.SetToolTip(this.cmbV23Enc, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkSingle;
      this.chkSingle = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkSingle, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkUnSync;
      this.chkUnSync = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkUnSync, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.optUse24;
      this.optUse24 = (RadioButton)cmbPlay;
      this.ToolTip.SetToolTip(this.optUse24, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.optUse23;
      this.optUse23 = (RadioButton)cmbPlay;
      this.ToolTip.SetToolTip(this.optUse23, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.ColorCompareText;
      this.ColorCompareText = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.ColorCompareText, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.ColorCompareBack;
      this.ColorCompareBack = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.ColorCompareBack, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.ColorChangedBack;
      this.ColorChangedBack = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.ColorChangedBack, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.ColorDoubleText;
      this.ColorDoubleText = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.ColorDoubleText, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.ColorDoubleBack;
      this.ColorDoubleBack = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.ColorDoubleBack, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.ColorChangedText;
      this.ColorChangedText = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.ColorChangedText, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.btnRemove;
      this.btnRemove = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.btnAdd;
      this.btnAdd = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.btnBrowse;
      this.btnBrowse = (Button)cmbPlay;
      this.ToolTip.SetToolTip(this.btnBrowse, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.cmbShell;
      this.cmbShell = (ComboBox)cmbPlay;
      this.ToolTip.SetToolTip(this.cmbShell, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.txtParameters;
      this.txtParameters = (System.Windows.Forms.TextBox)cmbPlay;
      this.ToolTip.SetToolTip(this.txtParameters, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.txtPath;
      this.txtPath = (System.Windows.Forms.TextBox)cmbPlay;
      this.ToolTip.SetToolTip(this.txtPath, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.txtDescription;
      this.txtDescription = (System.Windows.Forms.TextBox)cmbPlay;
      this.ToolTip.SetToolTip(this.txtDescription, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
      vstrName = "frmPreferences";
      cmbPlay = this.chkDefault;
      this.chkDefault = (CheckBox)cmbPlay;
      this.ToolTip.SetToolTip(this.chkDefault, Declarations.objResources.GetToolTip(ref vstrName, ref cmbPlay));
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (((StringType.StrCmp(this.txtDescription.Text, "", false) == 0) & (StringType.StrCmp(this.txtPath.Text, "", false) == 0)) & !this.chkDefault.Checked)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["ToolMissing"]), MsgBoxStyle.Exclamation, null);
      }
      else
      {
        DataRow row = Declarations.objSettings.Tools.NewRow();
        if (this.chkDefault.Checked)
        {
          row["ToolDescription"] = this.txtDescription.Text;
          row["DefaultPlayer"] = this.chkDefault.Checked;
          row["ShellCommand"] = this.cmbShell.Text;
        }
        else
        {
          row["ToolDescription"] = this.txtDescription.Text;
          row["ToolPath"] = this.txtPath.Text;
          row["ToolParameter"] = this.txtParameters.Text;
          row["DefaultPlayer"] = this.chkDefault.Checked;
        }
        Declarations.objSettings.Tools.Rows.Add(row);
      }
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      this.OpenFileDialog.InitialDirectory = this.txtPath.Text;
      this.OpenFileDialog.DefaultExt = "exe";
      this.OpenFileDialog.Filter = "EXE|*.exe";
      if (this.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        this.txtPath.Text = this.OpenFileDialog.FileName;
        if (StringType.StrCmp(this.txtDescription.Text, "", false) == 0)
        {
          this.txtDescription.Text = this.txtPath.Text.Substring(this.txtPath.Text.LastIndexOf(@"\") + 1, (this.txtPath.Text.LastIndexOf(".") - this.txtPath.Text.LastIndexOf(@"\")) - 1);
        }
        if (StringType.StrCmp(this.txtParameters.Text, "", false) == 0)
        {
          this.txtParameters.Text = "%P";
        }
      }
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
      this.ColumnsList.BeginUpdate();
      if (this.ColumnsList.SelectedItems.Count == 1)
      {
        ListViewItem item = this.ColumnsList.SelectedItems[0];
        if (item.Index == (this.ColumnsList.Items.Count - 1))
        {
          this.ColumnsList.EndUpdate();
        }
        else
        {
          ListViewItem item2 = (ListViewItem)item.Clone();
          if (item.Checked)
          {
            item2.Checked = true;
          }
          else
          {
            item2.Checked = false;
          }
          this.ColumnsList.Items.Insert(item.Index + 2, item2);
          item2.Selected = true;
          item2.Focused = true;
          this.ColumnsList.Focus();
          this.ColumnsList.Items.Remove(item);
          this.ColumnsList.EndUpdate();
          this.ColumnSettingsChanged = true;
        }
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (this.optEditV1.Checked)
      {
        Declarations.objSettings.EditDialog = 1;
      }
      else if (this.optEditV2.Checked)
      {
        Declarations.objSettings.EditDialog = 2;
      }
      else
      {
        Declarations.objSettings.EditDialog = 3;
      }
      if (this.optUse23.Checked)
      {
        Declarations.objSettings.NewV2Version = 3;
      }
      else
      {
        Declarations.objSettings.NewV2Version = 4;
      }
      if (this.optSingle.Checked)
      {
        Declarations.objSettings.SelectionMode = 1;
      }
      else
      {
        Declarations.objSettings.SelectionMode = 2;
      }
      Declarations.objSettings.EnumSeparator = this.txtEnumSep.Text;
      Declarations.objSettings.WriteUnsync = this.chkUnSync.Checked;
      Declarations.objSettings.SingleGC = this.chkSingle.Checked;
      Declarations.objSettings.V2YearOnly = (byte)this.cmbYearFormat.SelectedIndex;
      Declarations.objSettings.V23Encoding = (byte)this.cmbV23Enc.SelectedIndex;
      Declarations.objSettings.V24Encoding = (byte)this.cmbV24Enc.SelectedIndex;
      Declarations.objSettings.TracknumberDigitsFilename = Convert.ToByte(this.txtTFDigits.Value);
      Declarations.objSettings.TracknumberDigitsTAG = Convert.ToByte(this.txtTTDigits.Value);
      Declarations.objSettings.FilenumberDigits = Convert.ToByte(this.txtFDigits.Value);
      Declarations.objSettings.FilenumberStart = Convert.ToInt32(this.txtStartNr.Value);
      Declarations.objSettings.Play = this.cmbPlay.Text;
      Declarations.objSettings.ExplorerContext = this.chkExplorerContext.Checked;
      Declarations.objSettings.SaveFolder = this.chkSaveOnExit.Checked;
      Declarations.objSettings.IgnoreWrite = this.chkIgnoreWrite.Checked;
      Declarations.objSettings.AudioChecksumCalc = this.chkAudioChecksumCalc.Checked;
      Declarations.objSettings.RestoreDate = this.chkRestore.Checked;
      Declarations.objSettings.MouseFilenameEditing = this.chkMouseRenaming.Checked;
      this.MainForm.MP3View.LabelEdit = this.chkMouseRenaming.Checked;
      Declarations.objSettings.FreeDBUser = this.Username.Text;
      Declarations.objSettings.FreeDBServer = this.Server.Text;
      Declarations.objSettings.FreeDBPort = (int)Math.Round(Conversion.Val(this.Port.Text));
      Declarations.objSettings.FreeDBProxyUser = this.txtProxyUser.Text;
      Declarations.objSettings.FreeDBProxyServer = this.txtProxyServer.Text;
      Declarations.objSettings.FreeDBProxyPort = (int)Math.Round(Conversion.Val(this.txtProxyPort.Text));
      Declarations.objSettings.FreeDBProxyPassword = this.txtProxyPassword.Text;
      Declarations.objSettings.FreeDBProxyUse = this.chkProxy.Checked;
      Declarations.objSettings.ColorChangedBack = this.ColorChangedBack.BackColor.ToArgb();
      Declarations.objSettings.ColorChangedText = this.ColorChangedText.BackColor.ToArgb();
      Declarations.objSettings.ColorDoubleBack = this.ColorDoubleBack.BackColor.ToArgb();
      Declarations.objSettings.ColorDoubleText = this.ColorDoubleText.BackColor.ToArgb();
      Declarations.objSettings.ColorCompareBack = this.ColorCompareBack.BackColor.ToArgb();
      Declarations.objSettings.ColorCompareText = this.ColorCompareText.BackColor.ToArgb();
      Declarations.objSettings.UseThemes = this.chkWinXPThemes.Checked;
      Bar bar = new Bar();
      if (this.chkWinXPThemes.Checked)
      {
        foreach (Bar bar in this.MainForm.DotNetBarManager.Bars)
        {
          bar.ThemeAware = true;
          bar.Refresh();
        }
      }
      else
      {
        foreach (Bar bar in this.MainForm.DotNetBarManager.Bars)
        {
          bar.ThemeAware = false;
          bar.Refresh();
        }
      }
      try
      {
        RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT", true);
        string executablePath = Application.ExecutablePath;
        if (Declarations.objSettings.ExplorerContext)
        {
          if (key != null)
          {
            Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).DeleteSubKeyTree("ID3-TagIT");
          }
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).CreateSubKey("ID3-TagIT");
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT", true).CreateSubKey("command");
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT\command", true).SetValue(null, "\"" + executablePath + "\"" + " " + "\"" + "/P=%1" + "\"");
        }
        if (!Declarations.objSettings.ExplorerContext & (key != null))
        {
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).DeleteSubKeyTree("ID3-TagIT");
        }
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
      if (this.ColumnSettingsChanged)
      {
        Declarations.objSettings.Columns.Rows.Clear();
        foreach (ListViewItem item in this.ColumnsList.CheckedItems)
        {
          DataRow row = Declarations.objSettings.Columns.NewRow();
          int num2 = 0;
          do
          {
            row[num2] = RuntimeHelpers.GetObjectValue(LateBinding.LateIndexGet(item.Tag, new object[] { num2 }, null));
            num2++;
          }
          while (num2 <= 2);
          Declarations.objSettings.Columns.Rows.Add(row);
        }
        this.MainForm.SortedColumn = 0;
        this.Hide();
        Application.DoEvents();
        this.MainForm.MP3View_AddColumns();
        this.MainForm.MP3View_FillColumns(ref Declarations.MP3s);
        this.ToolGrid.DataSource = null;
      }
      this.Close();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      try
      {
        Declarations.objSettings.Tools.Rows[this.ToolGrid.CurrentRowIndex].Delete();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
    }

    private void btnUp_Click(object sender, EventArgs e)
    {
      this.ColumnsList.BeginUpdate();
      if (this.ColumnsList.SelectedItems.Count == 1)
      {
        ListViewItem item = this.ColumnsList.SelectedItems[0];
        if (item.Index == 0)
        {
          this.ColumnsList.EndUpdate();
        }
        else
        {
          ListViewItem item2 = (ListViewItem)item.Clone();
          if (item.Checked)
          {
            item2.Checked = true;
          }
          else
          {
            item2.Checked = false;
          }
          this.ColumnsList.Items.Insert(item.Index - 1, item2);
          item2.Selected = true;
          item2.Focused = true;
          this.ColumnsList.Focus();
          this.ColumnsList.Items.Remove(item);
          this.ColumnsList.EndUpdate();
          this.ColumnSettingsChanged = true;
        }
      }
    }

    private void chkDefault_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkDefault.Checked)
      {
        this.cmbShell.Enabled = true;
        this.txtPath.Enabled = false;
        this.txtParameters.Enabled = false;
      }
      else
      {
        this.cmbShell.Enabled = false;
        this.txtPath.Enabled = true;
        this.txtParameters.Enabled = true;
      }
    }

    private void chkProxy_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkProxy.Checked)
      {
        this.grpProxy.Enabled = true;
      }
      else
      {
        this.grpProxy.Enabled = false;
      }
    }

    private void ColorChangedBack_Click(object sender, EventArgs e)
    {
      this.ColorDialog.Color = (System.Drawing.Color)LateBinding.LateGet(sender, null, "BackColor", new object[0], null, null);
      this.ColorDialog.ShowDialog();
      LateBinding.LateSet(sender, null, "BackColor", new object[] { this.ColorDialog.Color }, null);
    }

    private void ColumnsList_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (!this.vbooChecking)
      {
        this.vbooChecking = true;
        if (this.Visible)
        {
          this.ColumnSettingsChanged = true;
          if (ObjectType.ObjTst(LateBinding.LateIndexGet(this.ColumnsList.Items[e.Index].Tag, new object[] { 0 }, null), 1, false) == 0)
          {
            e.NewValue = CheckState.Checked;
          }
        }
        this.vbooChecking = false;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void frmOptions_Load(object sender, EventArgs e)
    {
      Process process = new Process();
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
      this.ColorChangedBack.FlatStyle = FlatStyle.Flat;
      this.ColorChangedText.FlatStyle = FlatStyle.Flat;
      this.ColorDoubleBack.FlatStyle = FlatStyle.Flat;
      this.ColorDoubleText.FlatStyle = FlatStyle.Flat;
      this.ColorCompareBack.FlatStyle = FlatStyle.Flat;
      this.ColorCompareText.FlatStyle = FlatStyle.Flat;
      this.ColorChangedBack.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedBack);
      this.ColorChangedText.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedText);
      this.ColorDoubleBack.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorDoubleBack);
      this.ColorDoubleText.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorDoubleText);
      this.ColorCompareBack.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorCompareBack);
      this.ColorCompareText.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorCompareText);
      if (Declarations.objSettings.EditDialog == 1)
      {
        this.optEditV1.Checked = true;
      }
      else if (Declarations.objSettings.EditDialog == 2)
      {
        this.optEditV2.Checked = true;
      }
      else
      {
        this.optEditCur.Checked = true;
      }
      if (Declarations.objSettings.NewV2Version == 3)
      {
        this.optUse23.Checked = true;
      }
      else
      {
        this.optUse24.Checked = true;
      }
      if (Declarations.objSettings.SelectionMode == 1)
      {
        this.optSingle.Checked = true;
      }
      else
      {
        this.optAdd.Checked = true;
      }
      this.txtEnumSep.Text = Declarations.objSettings.EnumSeparator;
      this.chkUnSync.Checked = Declarations.objSettings.WriteUnsync;
      this.chkSingle.Checked = Declarations.objSettings.SingleGC;
      this.cmbYearFormat.SelectedIndex = Declarations.objSettings.V2YearOnly;
      this.cmbV23Enc.SelectedIndex = Declarations.objSettings.V23Encoding;
      this.cmbV24Enc.SelectedIndex = Declarations.objSettings.V24Encoding;
      this.txtTFDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);
      this.txtTTDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsTAG);
      this.txtFDigits.Value = new decimal(Declarations.objSettings.FilenumberDigits);
      this.txtStartNr.Value = new decimal(Declarations.objSettings.FilenumberStart);
      this.chkExplorerContext.Checked = Declarations.objSettings.ExplorerContext;
      this.chkSaveOnExit.Checked = Declarations.objSettings.SaveFolder;
      this.chkIgnoreWrite.Checked = Declarations.objSettings.IgnoreWrite;
      this.chkAudioChecksumCalc.Checked = Declarations.objSettings.AudioChecksumCalc;
      this.chkRestore.Checked = Declarations.objSettings.RestoreDate;
      this.chkMouseRenaming.Checked = Declarations.objSettings.MouseFilenameEditing;
      this.Username.Text = Declarations.objSettings.FreeDBUser;
      this.Server.Text = Declarations.objSettings.FreeDBServer;
      this.Port.Text = Declarations.objSettings.FreeDBPort.ToString();
      this.txtProxyUser.Text = Declarations.objSettings.FreeDBProxyUser;
      this.txtProxyServer.Text = Declarations.objSettings.FreeDBProxyServer;
      this.txtProxyPort.Text = Declarations.objSettings.FreeDBProxyPort.ToString();
      this.txtProxyPassword.Text = Declarations.objSettings.FreeDBProxyPassword;
      this.chkProxy.Checked = Declarations.objSettings.FreeDBProxyUse;
      this.chkWinXPThemes.Checked = Declarations.objSettings.UseThemes;
      this.cmbShell.Enabled = false;
      this.txtPath.Enabled = true;
      this.txtParameters.Enabled = true;
      process.StartInfo.FileName = "Test.m3u";
      foreach (string str in process.StartInfo.Verbs)
      {
        this.cmbPlay.Items.Add(str);
        this.cmbShell.Items.Add(str);
      }
      try
      {
        this.cmbPlay.SelectedIndex = 0;
        this.cmbPlay.Text = Declarations.objSettings.Play;
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        try
        {
          this.cmbPlay.SelectedIndex = 0;
        }
        catch (Exception exception2)
        {
          ProjectData.SetProjectError(exception2);
          ProjectData.ClearProjectError();
        }
        ProjectData.ClearProjectError();
      }
      this.ToolGrid.DataSource = Declarations.objSettings.Tools;
      this.ToolGrid.TableStyles[0].MappingName = Declarations.objSettings.Tools.TableName;
      this.Port.ModifyFlags(0x10, true);
      this.txtProxyPort.ModifyFlags(0x10, true);
      this.AddToolTips();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      ResourceManager manager = new ResourceManager(typeof(frmPreferences));
      this.lblPlay = new Label();
      this.cmbPlay = new ComboBox();
      this.chkExplorerContext = new CheckBox();
      this.frameEnum = new GroupBox();
      this.lbl2 = new Label();
      this.txtFDigits = new NumericUpDown();
      this.lblEnumSep = new Label();
      this.txtEnumSep = new System.Windows.Forms.TextBox();
      this.lbl1 = new Label();
      this.txtStartNr = new NumericUpDown();
      this.chkMouseRenaming = new CheckBox();
      this.chkRestore = new CheckBox();
      this.lblTracknumbers = new Label();
      this.txtTFDigits = new NumericUpDown();
      this.frameSelection = new GroupBox();
      this.optAdd = new RadioButton();
      this.optSingle = new RadioButton();
      this.chkSaveOnExit = new CheckBox();
      this.frameDoubleClick = new GroupBox();
      this.optEditCur = new RadioButton();
      this.optEditV1 = new RadioButton();
      this.optEditV2 = new RadioButton();
      this.chkIgnoreWrite = new CheckBox();
      this.lblDescript = new Label();
      this.ColumnsList = new ListView();
      this.btnUp = new Button();
      this.btnDown = new Button();
      this.lblTextEncInfo = new Label();
      this.lblFormat = new Label();
      this.cmbYearFormat = new ComboBox();
      this.lblDigits = new Label();
      this.txtTTDigits = new NumericUpDown();
      this.lblV24 = new Label();
      this.lblV23 = new Label();
      this.cmbV24Enc = new ComboBox();
      this.cmbV23Enc = new ComboBox();
      this.chkSingle = new CheckBox();
      this.chkUnSync = new CheckBox();
      this.optUse24 = new RadioButton();
      this.optUse23 = new RadioButton();
      this.Port = new NumericTextBox();
      this.grpProxy = new GroupBox();
      this.txtProxyPort = new NumericTextBox();
      this.txtProxyPassword = new System.Windows.Forms.TextBox();
      this.Label10 = new Label();
      this.txtProxyUser = new System.Windows.Forms.TextBox();
      this.Label9 = new Label();
      this.Label8 = new Label();
      this.txtProxyServer = new System.Windows.Forms.TextBox();
      this.Label7 = new Label();
      this.chkProxy = new CheckBox();
      this.lblUsername = new Label();
      this.Username = new System.Windows.Forms.TextBox();
      this.lblPort = new Label();
      this.lblServer = new Label();
      this.Server = new System.Windows.Forms.TextBox();
      this.chkWinXPThemes = new CheckBox();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.ColorCompareText = new Button();
      this.ColorCompareBack = new Button();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.ColorChangedBack = new Button();
      this.ColorDoubleText = new Button();
      this.ColorDoubleBack = new Button();
      this.ColorChangedText = new Button();
      this.ToolGrid = new DataGrid();
      this.Style = new DataGridTableStyle();
      this.C1 = new DataGridTextBoxColumn();
      this.C2 = new DataGridTextBoxColumn();
      this.C3 = new DataGridTextBoxColumn();
      this.C4 = new DataGridBoolColumn();
      this.C5 = new DataGridTextBoxColumn();
      this.btnRemove = new Button();
      this.btnAdd = new Button();
      this.lblP = new Label();
      this.btnBrowse = new Button();
      this.cmbShell = new ComboBox();
      this.txtParameters = new System.Windows.Forms.TextBox();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.chkDefault = new CheckBox();
      this.lblParameters = new Label();
      this.lblPath = new Label();
      this.lblDescription = new Label();
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.ColorDialog = new System.Windows.Forms.ColorDialog();
      this.ButtomPanel = new PanelEx();
      this.TabControl = new DevComponents.DotNetBar.TabControl();
      this.TabControlPanel1 = new TabControlPanel();
      this.chkAudioChecksumCalc = new CheckBox();
      this.Settings = new TabItem(this.components);
      this.TabControlPanel3 = new TabControlPanel();
      this.Ver2 = new TabItem(this.components);
      this.TabControlPanel2 = new TabControlPanel();
      this.Columns = new TabItem(this.components);
      this.TabControlPanel6 = new TabControlPanel();
      this.Tools = new TabItem(this.components);
      this.TabControlPanel5 = new TabControlPanel();
      this.Colors = new TabItem(this.components);
      this.TabControlPanel4 = new TabControlPanel();
      this.FreeDB = new TabItem(this.components);
      this.frameEnum.SuspendLayout();
      this.txtFDigits.BeginInit();
      this.txtStartNr.BeginInit();
      this.txtTFDigits.BeginInit();
      this.frameSelection.SuspendLayout();
      this.frameDoubleClick.SuspendLayout();
      this.txtTTDigits.BeginInit();
      this.grpProxy.SuspendLayout();
      this.ToolGrid.BeginInit();
      this.ButtomPanel.SuspendLayout();
      ((ISupportInitialize)this.TabControl).BeginInit();
      this.TabControl.SuspendLayout();
      this.TabControlPanel1.SuspendLayout();
      this.TabControlPanel3.SuspendLayout();
      this.TabControlPanel2.SuspendLayout();
      this.TabControlPanel6.SuspendLayout();
      this.TabControlPanel5.SuspendLayout();
      this.TabControlPanel4.SuspendLayout();
      this.SuspendLayout();
      this.lblPlay.BackColor = System.Drawing.Color.Transparent;
      this.lblPlay.ImeMode = ImeMode.NoControl;
      Point point = new Point(0x10, 0x132);
      this.lblPlay.Location = point;
      this.lblPlay.Name = "lblPlay";
      Size size = new Size(0x110, 0x10);
      this.lblPlay.Size = size;
      this.lblPlay.TabIndex = 0x12;
      this.lblPlay.Text = "Shell command for PLA&Y function:";
      this.cmbPlay.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbPlay.ItemHeight = 13;
      point = new Point(0x120, 0x130);
      this.cmbPlay.Location = point;
      this.cmbPlay.Name = "cmbPlay";
      size = new Size(0xf8, 0x15);
      this.cmbPlay.Size = size;
      this.cmbPlay.TabIndex = 0x13;
      this.chkExplorerContext.BackColor = System.Drawing.Color.Transparent;
      this.chkExplorerContext.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0xfc);
      this.chkExplorerContext.Location = point;
      this.chkExplorerContext.Name = "chkExplorerContext";
      size = new Size(520, 0x10);
      this.chkExplorerContext.Size = size;
      this.chkExplorerContext.TabIndex = 0x10;
      this.chkExplorerContext.Text = "Show \"ID3-TagIT\" in the folder context menu of the Windows &Explorer";
      this.frameEnum.BackColor = System.Drawing.Color.Transparent;
      this.frameEnum.Controls.Add(this.lbl2);
      this.frameEnum.Controls.Add(this.txtFDigits);
      this.frameEnum.Controls.Add(this.lblEnumSep);
      this.frameEnum.Controls.Add(this.txtEnumSep);
      this.frameEnum.Controls.Add(this.lbl1);
      this.frameEnum.Controls.Add(this.txtStartNr);
      point = new Point(0xe0, 0x58);
      this.frameEnum.Location = point;
      this.frameEnum.Name = "frameEnum";
      size = new Size(0x138, 0x68);
      this.frameEnum.Size = size;
      this.frameEnum.TabIndex = 10;
      this.frameEnum.TabStop = false;
      this.frameEnum.Text = "Enumerating mode";
      this.lbl2.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x48);
      this.lbl2.Location = point;
      this.lbl2.Name = "lbl2";
      size = new Size(0xe0, 0x10);
      this.lbl2.Size = size;
      this.lbl2.TabIndex = 7;
      this.lbl2.Text = "Number of digits of filename enumeration:";
      point = new Point(0xef, 70);
      this.txtFDigits.Location = point;
      decimal num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtFDigits.Minimum = num;
      this.txtFDigits.Name = "txtFDigits";
      size = new Size(0x40, 20);
      this.txtFDigits.Size = size;
      this.txtFDigits.TabIndex = 8;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtFDigits.Value = num;
      this.lblEnumSep.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x30);
      this.lblEnumSep.Location = point;
      this.lblEnumSep.Name = "lblEnumSep";
      size = new Size(0xe0, 0x10);
      this.lblEnumSep.Size = size;
      this.lblEnumSep.TabIndex = 5;
      this.lblEnumSep.Text = "Separator:";
      point = new Point(0xef, 0x2e);
      this.txtEnumSep.Location = point;
      this.txtEnumSep.Name = "txtEnumSep";
      size = new Size(0x40, 20);
      this.txtEnumSep.Size = size;
      this.txtEnumSep.TabIndex = 6;
      this.txtEnumSep.Text = " - ";
      this.lbl1.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x18);
      this.lbl1.Location = point;
      this.lbl1.Name = "lbl1";
      size = new Size(0xe0, 0x10);
      this.lbl1.Size = size;
      this.lbl1.TabIndex = 0;
      this.lbl1.Text = "Number to start with:";
      point = new Point(0xef, 0x16);
      this.txtStartNr.Location = point;
      num = new decimal(new int[] { 0x989680, 0, 0, 0 });
      this.txtStartNr.Maximum = num;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtStartNr.Minimum = num;
      this.txtStartNr.Name = "txtStartNr";
      size = new Size(0x40, 20);
      this.txtStartNr.Size = size;
      this.txtStartNr.TabIndex = 1;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtStartNr.Value = num;
      this.chkMouseRenaming.BackColor = System.Drawing.Color.Transparent;
      this.chkMouseRenaming.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0xcc);
      this.chkMouseRenaming.Location = point;
      this.chkMouseRenaming.Name = "chkMouseRenaming";
      size = new Size(0xf8, 0x10);
      this.chkMouseRenaming.Size = size;
      this.chkMouseRenaming.TabIndex = 12;
      this.chkMouseRenaming.Text = "Enable &Renaming by mouse click";
      this.chkRestore.BackColor = System.Drawing.Color.Transparent;
      this.chkRestore.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0xe4);
      this.chkRestore.Location = point;
      this.chkRestore.Name = "chkRestore";
      size = new Size(0xf8, 0x10);
      this.chkRestore.Size = size;
      this.chkRestore.TabIndex = 14;
      this.chkRestore.Text = "&Restore date of file after tagging";
      this.lblTracknumbers.BackColor = System.Drawing.Color.Transparent;
      this.lblTracknumbers.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x152);
      this.lblTracknumbers.Location = point;
      this.lblTracknumbers.Name = "lblTracknumbers";
      size = new Size(0x110, 0x10);
      this.lblTracknumbers.Size = size;
      this.lblTracknumbers.TabIndex = 20;
      this.lblTracknumbers.Text = "Number of &digits of track numbers in filenames:";
      point = new Point(0x120, 0x150);
      this.txtTFDigits.Location = point;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtTFDigits.Minimum = num;
      this.txtTFDigits.Name = "txtTFDigits";
      size = new Size(0x40, 20);
      this.txtTFDigits.Size = size;
      this.txtTFDigits.TabIndex = 0x15;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtTFDigits.Value = num;
      this.frameSelection.BackColor = System.Drawing.Color.Transparent;
      this.frameSelection.Controls.Add(this.optAdd);
      this.frameSelection.Controls.Add(this.optSingle);
      point = new Point(8, 0x58);
      this.frameSelection.Location = point;
      this.frameSelection.Name = "frameSelection";
      size = new Size(200, 0x68);
      this.frameSelection.Size = size;
      this.frameSelection.TabIndex = 5;
      this.frameSelection.TabStop = false;
      this.frameSelection.Text = "Selection mode";
      this.optAdd.BackColor = System.Drawing.Color.Transparent;
      this.optAdd.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x30);
      this.optAdd.Location = point;
      this.optAdd.Name = "optAdd";
      size = new Size(0xb0, 0x10);
      this.optAdd.Size = size;
      this.optAdd.TabIndex = 1;
      this.optAdd.Text = "&Add to selection";
      this.optSingle.BackColor = System.Drawing.Color.Transparent;
      this.optSingle.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x18);
      this.optSingle.Location = point;
      this.optSingle.Name = "optSingle";
      size = new Size(0xb0, 0x10);
      this.optSingle.Size = size;
      this.optSingle.TabIndex = 3;
      this.optSingle.Text = "&New selection";
      this.chkSaveOnExit.BackColor = System.Drawing.Color.Transparent;
      this.chkSaveOnExit.ImeMode = ImeMode.NoControl;
      point = new Point(280, 0xe4);
      this.chkSaveOnExit.Location = point;
      this.chkSaveOnExit.Name = "chkSaveOnExit";
      size = new Size(0x100, 0x10);
      this.chkSaveOnExit.Size = size;
      this.chkSaveOnExit.TabIndex = 15;
      this.chkSaveOnExit.Text = "&Save folder on exit";
      this.frameDoubleClick.BackColor = System.Drawing.Color.Transparent;
      this.frameDoubleClick.Controls.Add(this.optEditCur);
      this.frameDoubleClick.Controls.Add(this.optEditV1);
      this.frameDoubleClick.Controls.Add(this.optEditV2);
      point = new Point(8, 8);
      this.frameDoubleClick.Location = point;
      this.frameDoubleClick.Name = "frameDoubleClick";
      size = new Size(0x210, 0x48);
      this.frameDoubleClick.Size = size;
      this.frameDoubleClick.TabIndex = 0;
      this.frameDoubleClick.TabStop = false;
      this.frameDoubleClick.Text = " Double click open command ";
      this.optEditCur.BackColor = System.Drawing.Color.Transparent;
      this.optEditCur.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x30);
      this.optEditCur.Location = point;
      this.optEditCur.Name = "optEditCur";
      size = new Size(0x1f0, 0x10);
      this.optEditCur.Size = size;
      this.optEditCur.TabIndex = 2;
      this.optEditCur.Text = "Open 'Edit TAG Ver. &X' dialog corresponding to current view";
      this.optEditV1.BackColor = System.Drawing.Color.Transparent;
      this.optEditV1.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x18);
      this.optEditV1.Location = point;
      this.optEditV1.Name = "optEditV1";
      size = new Size(240, 0x10);
      this.optEditV1.Size = size;
      this.optEditV1.TabIndex = 0;
      this.optEditV1.Text = "Open 'Edit TAG Ver. &1' dialog";
      this.optEditV2.BackColor = System.Drawing.Color.Transparent;
      this.optEditV2.ImeMode = ImeMode.NoControl;
      point = new Point(0x110, 0x18);
      this.optEditV2.Location = point;
      this.optEditV2.Name = "optEditV2";
      size = new Size(240, 0x10);
      this.optEditV2.Size = size;
      this.optEditV2.TabIndex = 1;
      this.optEditV2.Text = "Open 'Edit TAG Ver. &2' dialog";
      this.chkIgnoreWrite.BackColor = System.Drawing.Color.Transparent;
      this.chkIgnoreWrite.ImeMode = ImeMode.NoControl;
      point = new Point(280, 0xcc);
      this.chkIgnoreWrite.Location = point;
      this.chkIgnoreWrite.Name = "chkIgnoreWrite";
      size = new Size(0x100, 0x10);
      this.chkIgnoreWrite.Size = size;
      this.chkIgnoreWrite.TabIndex = 13;
      this.chkIgnoreWrite.Text = "&Ignore write protection";
      this.lblDescript.BackColor = System.Drawing.Color.Transparent;
      this.lblDescript.BorderStyle = BorderStyle.Fixed3D;
      this.lblDescript.ImeMode = ImeMode.NoControl;
      point = new Point(280, 0x110);
      this.lblDescript.Location = point;
      this.lblDescript.Name = "lblDescript";
      size = new Size(0x100, 0x58);
      this.lblDescript.Size = size;
      this.lblDescript.TabIndex = 3;
      this.lblDescript.Text = "Only checked columns will be displayed . You can reorder the columns by moving them  up or down. The filename column will always be visible.";
      this.lblDescript.TextAlign = ContentAlignment.MiddleCenter;
      this.ColumnsList.CheckBoxes = true;
      this.ColumnsList.FullRowSelect = true;
      this.ColumnsList.HeaderStyle = ColumnHeaderStyle.None;
      point = new Point(8, 8);
      this.ColumnsList.Location = point;
      this.ColumnsList.MultiSelect = false;
      this.ColumnsList.Name = "ColumnsList";
      size = new Size(0x100, 0x160);
      this.ColumnsList.Size = size;
      this.ColumnsList.TabIndex = 2;
      this.ColumnsList.View = View.Details;
      this.btnUp.BackColor = SystemColors.Control;
      this.btnUp.ImeMode = ImeMode.NoControl;
      point = new Point(280, 160);
      this.btnUp.Location = point;
      this.btnUp.Name = "btnUp";
      size = new Size(0x80, 0x18);
      this.btnUp.Size = size;
      this.btnUp.TabIndex = 1;
      this.btnUp.Text = "Column &up";
      this.btnDown.BackColor = SystemColors.Control;
      this.btnDown.ImeMode = ImeMode.NoControl;
      point = new Point(280, 0xc0);
      this.btnDown.Location = point;
      this.btnDown.Name = "btnDown";
      size = new Size(0x80, 0x18);
      this.btnDown.Size = size;
      this.btnDown.TabIndex = 1;
      this.btnDown.Text = "Column &down";
      this.lblTextEncInfo.BackColor = System.Drawing.Color.Transparent;
      point = new Point(8, 0x107);
      this.lblTextEncInfo.Location = point;
      this.lblTextEncInfo.Name = "lblTextEncInfo";
      size = new Size(0x210, 0x30);
      this.lblTextEncInfo.Size = size;
      this.lblTextEncInfo.TabIndex = 0x10;
      this.lblTextEncInfo.Text = "NOTE: The text encoding will only be used for new TAG Ver. 2 frames. Already present frames will not be changed when the TAG is saved.";
      this.lblFormat.BackColor = System.Drawing.Color.Transparent;
      this.lblFormat.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x8a);
      this.lblFormat.Location = point;
      this.lblFormat.Name = "lblFormat";
      size = new Size(200, 0x10);
      this.lblFormat.Size = size;
      this.lblFormat.TabIndex = 8;
      this.lblFormat.Text = "&Format of year entry:";
      this.cmbYearFormat.ItemHeight = 13;
      this.cmbYearFormat.Items.AddRange(new object[] { "YYYY", "YYYY-MM", "YYYY-MM-DD" });
      point = new Point(0xd8, 0x88);
      this.cmbYearFormat.Location = point;
      this.cmbYearFormat.Name = "cmbYearFormat";
      size = new Size(320, 0x15);
      this.cmbYearFormat.Size = size;
      this.cmbYearFormat.TabIndex = 9;
      this.lblDigits.BackColor = System.Drawing.Color.Transparent;
      this.lblDigits.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xaf);
      this.lblDigits.Location = point;
      this.lblDigits.Name = "lblDigits";
      size = new Size(0x128, 0x10);
      this.lblDigits.Size = size;
      this.lblDigits.TabIndex = 10;
      this.lblDigits.Text = "Number of digits of track numbers in Ver. 2 TAGs:";
      point = new Point(0x138, 0xad);
      this.txtTTDigits.Location = point;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtTTDigits.Minimum = num;
      this.txtTTDigits.Name = "txtTTDigits";
      size = new Size(0x40, 20);
      this.txtTTDigits.Size = size;
      this.txtTTDigits.TabIndex = 11;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtTTDigits.Value = num;
      this.lblV24.BackColor = System.Drawing.Color.Transparent;
      this.lblV24.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xea);
      this.lblV24.Location = point;
      this.lblV24.Name = "lblV24";
      size = new Size(200, 0x10);
      this.lblV24.Size = size;
      this.lblV24.TabIndex = 14;
      this.lblV24.Text = "Text encoding for TAG Ver. 2.4:";
      this.lblV23.BackColor = System.Drawing.Color.Transparent;
      this.lblV23.ImeMode = ImeMode.NoControl;
      point = new Point(8, 210);
      this.lblV23.Location = point;
      this.lblV23.Name = "lblV23";
      size = new Size(200, 0x10);
      this.lblV23.Size = size;
      this.lblV23.TabIndex = 12;
      this.lblV23.Text = "Text encoding for TAG Ver. 2.3:";
      this.cmbV24Enc.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbV24Enc.ItemHeight = 13;
      this.cmbV24Enc.Items.AddRange(new object[] { "ANSI-Encoding (Default)", "UTF-16 (LE) Encoding with BOM (Default for Unicode Encoding)", "UTF-16 (BE) Encoding without BOM", "UTF-8 Encoding" });
      point = new Point(0xd8, 0xe8);
      this.cmbV24Enc.Location = point;
      this.cmbV24Enc.Name = "cmbV24Enc";
      size = new Size(320, 0x15);
      this.cmbV24Enc.Size = size;
      this.cmbV24Enc.TabIndex = 15;
      this.cmbV23Enc.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbV23Enc.ItemHeight = 13;
      this.cmbV23Enc.Items.AddRange(new object[] { "ANSI-Encoding (Default)", "UTF-16 (LE) Encoding with BOM (Default for Unicode Encoding)" });
      point = new Point(0xd8, 0xd0);
      this.cmbV23Enc.Location = point;
      this.cmbV23Enc.Name = "cmbV23Enc";
      size = new Size(320, 0x15);
      this.cmbV23Enc.Size = size;
      this.cmbV23Enc.TabIndex = 13;
      this.chkSingle.BackColor = System.Drawing.Color.Transparent;
      this.chkSingle.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x61);
      this.chkSingle.Location = point;
      this.chkSingle.Name = "chkSingle";
      size = new Size(240, 0x10);
      this.chkSingle.Size = size;
      this.chkSingle.TabIndex = 7;
      this.chkSingle.Text = "Allow onl&y one genre / comment";
      this.chkUnSync.BackColor = System.Drawing.Color.Transparent;
      this.chkUnSync.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x49);
      this.chkUnSync.Location = point;
      this.chkUnSync.Name = "chkUnSync";
      size = new Size(240, 0x10);
      this.chkUnSync.Size = size;
      this.chkUnSync.TabIndex = 6;
      this.chkUnSync.Text = "Write &unsync. version 2 TAGs";
      this.optUse24.BackColor = System.Drawing.Color.Transparent;
      this.optUse24.ImeMode = ImeMode.NoControl;
      point = new Point(8, 40);
      this.optUse24.Location = point;
      this.optUse24.Name = "optUse24";
      size = new Size(0x1d0, 0x10);
      this.optUse24.Size = size;
      this.optUse24.TabIndex = 5;
      this.optUse24.Text = "Use Ver. 2.&4 for new TAGs of TAG Ver. 2";
      this.optUse23.BackColor = System.Drawing.Color.Transparent;
      this.optUse23.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x10);
      this.optUse23.Location = point;
      this.optUse23.Name = "optUse23";
      size = new Size(0x1d0, 0x10);
      this.optUse23.Size = size;
      this.optUse23.TabIndex = 4;
      this.optUse23.Text = "Use Ver. 2.&3 for new TAGs of TAG Ver. 2";
      this.Port.AllowNegative = false;
      this.Port.DigitsInGroup = 0;
      this.Port.Flags = 0x10010;
      point = new Point(0x69, 0x21);
      this.Port.Location = point;
      this.Port.MaxDecimalPlaces = 0;
      this.Port.MaxLength = 5;
      this.Port.MaxWholeDigits = 5;
      this.Port.Name = "Port";
      this.Port.Prefix = "";
      this.Port.RangeMax = 65535.0;
      this.Port.RangeMin = 0.0;
      this.Port.TabIndex = 9;
      this.Port.Text = "8880";
      this.grpProxy.BackColor = System.Drawing.Color.Transparent;
      this.grpProxy.Controls.Add(this.txtProxyPort);
      this.grpProxy.Controls.Add(this.txtProxyPassword);
      this.grpProxy.Controls.Add(this.Label10);
      this.grpProxy.Controls.Add(this.txtProxyUser);
      this.grpProxy.Controls.Add(this.Label9);
      this.grpProxy.Controls.Add(this.Label8);
      this.grpProxy.Controls.Add(this.txtProxyServer);
      this.grpProxy.Controls.Add(this.Label7);
      this.grpProxy.Enabled = false;
      point = new Point(9, 0x79);
      this.grpProxy.Location = point;
      this.grpProxy.Name = "grpProxy";
      size = new Size(0x20f, 0x80);
      this.grpProxy.Size = size;
      this.grpProxy.TabIndex = 13;
      this.grpProxy.TabStop = false;
      this.grpProxy.Text = "Proxy settings ";
      this.txtProxyPort.AllowNegative = false;
      this.txtProxyPort.DigitsInGroup = 0;
      this.txtProxyPort.Flags = 0x10010;
      point = new Point(0x80, 0x2e);
      this.txtProxyPort.Location = point;
      this.txtProxyPort.MaxDecimalPlaces = 0;
      this.txtProxyPort.MaxLength = 5;
      this.txtProxyPort.MaxWholeDigits = 5;
      this.txtProxyPort.Name = "txtProxyPort";
      this.txtProxyPort.Prefix = "";
      this.txtProxyPort.RangeMax = 65535.0;
      this.txtProxyPort.RangeMin = 0.0;
      this.txtProxyPort.TabIndex = 3;
      point = new Point(0x80, 0x5e);
      this.txtProxyPassword.Location = point;
      this.txtProxyPassword.Name = "txtProxyPassword";
      size = new Size(0x188, 20);
      this.txtProxyPassword.Size = size;
      this.txtProxyPassword.TabIndex = 7;
      this.txtProxyPassword.Text = "";
      this.Label10.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x60);
      this.Label10.Location = point;
      this.Label10.Name = "Label10";
      size = new Size(0x68, 0x10);
      this.Label10.Size = size;
      this.Label10.TabIndex = 6;
      this.Label10.Text = "Pa&ssword:";
      point = new Point(0x80, 70);
      this.txtProxyUser.Location = point;
      this.txtProxyUser.Name = "txtProxyUser";
      size = new Size(0x188, 20);
      this.txtProxyUser.Size = size;
      this.txtProxyUser.TabIndex = 5;
      this.txtProxyUser.Text = "";
      this.Label9.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x48);
      this.Label9.Location = point;
      this.Label9.Name = "Label9";
      size = new Size(0x68, 0x10);
      this.Label9.Size = size;
      this.Label9.TabIndex = 4;
      this.Label9.Text = "User&name:";
      this.Label8.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x30);
      this.Label8.Location = point;
      this.Label8.Name = "Label8";
      size = new Size(0x68, 0x10);
      this.Label8.Size = size;
      this.Label8.TabIndex = 2;
      this.Label8.Text = "P&ort:";
      point = new Point(0x80, 0x16);
      this.txtProxyServer.Location = point;
      this.txtProxyServer.Name = "txtProxyServer";
      size = new Size(0x188, 20);
      this.txtProxyServer.Size = size;
      this.txtProxyServer.TabIndex = 1;
      this.txtProxyServer.Text = "";
      this.Label7.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x18);
      this.Label7.Location = point;
      this.Label7.Name = "Label7";
      size = new Size(0x68, 0x10);
      this.Label7.Size = size;
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Pro&xy Server:";
      this.chkProxy.BackColor = System.Drawing.Color.Transparent;
      this.chkProxy.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x60);
      this.chkProxy.Location = point;
      this.chkProxy.Name = "chkProxy";
      size = new Size(0xb0, 0x10);
      this.chkProxy.Size = size;
      this.chkProxy.TabIndex = 12;
      this.chkProxy.Text = "Use Proxy server";
      this.lblUsername.BackColor = System.Drawing.Color.Transparent;
      this.lblUsername.ImeMode = ImeMode.NoControl;
      point = new Point(9, 0x3b);
      this.lblUsername.Location = point;
      this.lblUsername.Name = "lblUsername";
      size = new Size(0x60, 0x10);
      this.lblUsername.Size = size;
      this.lblUsername.TabIndex = 10;
      this.lblUsername.Text = "&Username:";
      point = new Point(0x69, 0x39);
      this.Username.Location = point;
      this.Username.Name = "Username";
      size = new Size(0x1af, 20);
      this.Username.Size = size;
      this.Username.TabIndex = 11;
      this.Username.Text = "";
      this.lblPort.BackColor = System.Drawing.Color.Transparent;
      this.lblPort.ImeMode = ImeMode.NoControl;
      point = new Point(9, 0x23);
      this.lblPort.Location = point;
      this.lblPort.Name = "lblPort";
      size = new Size(0x60, 0x10);
      this.lblPort.Size = size;
      this.lblPort.TabIndex = 8;
      this.lblPort.Text = "&Port:";
      this.lblServer.BackColor = System.Drawing.Color.Transparent;
      this.lblServer.ImeMode = ImeMode.NoControl;
      point = new Point(9, 11);
      this.lblServer.Location = point;
      this.lblServer.Name = "lblServer";
      size = new Size(0x60, 0x10);
      this.lblServer.Size = size;
      this.lblServer.TabIndex = 6;
      this.lblServer.Text = "&Server:";
      point = new Point(0x69, 9);
      this.Server.Location = point;
      this.Server.Name = "Server";
      size = new Size(0x1af, 20);
      this.Server.Size = size;
      this.Server.TabIndex = 7;
      this.Server.Text = "";
      this.chkWinXPThemes.BackColor = System.Drawing.Color.Transparent;
      this.chkWinXPThemes.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x158);
      this.chkWinXPThemes.Location = point;
      this.chkWinXPThemes.Name = "chkWinXPThemes";
      size = new Size(480, 0x10);
      this.chkWinXPThemes.Size = size;
      this.chkWinXPThemes.TabIndex = 12;
      this.chkWinXPThemes.Text = "Use Windows XP menu style";
      this.Label5.BackColor = System.Drawing.Color.Transparent;
      this.Label5.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xac);
      this.Label5.Location = point;
      this.Label5.Name = "Label5";
      size = new Size(0x150, 0x10);
      this.Label5.Size = size;
      this.Label5.TabIndex = 11;
      this.Label5.Text = "Text color of mismatches Filename<->TAG  files:";
      this.Label6.BackColor = System.Drawing.Color.Transparent;
      this.Label6.ImeMode = ImeMode.NoControl;
      point = new Point(8, 140);
      this.Label6.Location = point;
      this.Label6.Name = "Label6";
      size = new Size(0x150, 0x10);
      this.Label6.Size = size;
      this.Label6.TabIndex = 10;
      this.Label6.Text = "Background color of mismatches Filename<->TAG  files:";
      this.ColorCompareText.BackColor = SystemColors.Control;
      this.ColorCompareText.FlatStyle = FlatStyle.Flat;
      this.ColorCompareText.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 0xa8);
      this.ColorCompareText.Location = point;
      this.ColorCompareText.Name = "ColorCompareText";
      size = new Size(0x18, 0x18);
      this.ColorCompareText.Size = size;
      this.ColorCompareText.TabIndex = 9;
      this.ColorCompareBack.BackColor = SystemColors.Control;
      this.ColorCompareBack.FlatStyle = FlatStyle.Flat;
      this.ColorCompareBack.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 0x88);
      this.ColorCompareBack.Location = point;
      this.ColorCompareBack.Name = "ColorCompareBack";
      size = new Size(0x18, 0x18);
      this.ColorCompareBack.Size = size;
      this.ColorCompareBack.TabIndex = 8;
      this.Label4.BackColor = System.Drawing.Color.Transparent;
      this.Label4.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x6c);
      this.Label4.Location = point;
      this.Label4.Name = "Label4";
      size = new Size(0x150, 0x10);
      this.Label4.Size = size;
      this.Label4.TabIndex = 7;
      this.Label4.Text = "Text color of duplicate files:";
      this.Label3.BackColor = System.Drawing.Color.Transparent;
      this.Label3.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x4c);
      this.Label3.Location = point;
      this.Label3.Name = "Label3";
      size = new Size(0x150, 0x10);
      this.Label3.Size = size;
      this.Label3.TabIndex = 6;
      this.Label3.Text = "Background color of duplicate files:";
      this.Label2.BackColor = System.Drawing.Color.Transparent;
      this.Label2.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x2c);
      this.Label2.Location = point;
      this.Label2.Name = "Label2";
      size = new Size(0x150, 0x10);
      this.Label2.Size = size;
      this.Label2.TabIndex = 5;
      this.Label2.Text = "Text color of changed files:";
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.ImeMode = ImeMode.NoControl;
      point = new Point(8, 12);
      this.Label1.Location = point;
      this.Label1.Name = "Label1";
      size = new Size(0x150, 0x10);
      this.Label1.Size = size;
      this.Label1.TabIndex = 4;
      this.Label1.Text = "Background color of changed files:";
      this.ColorChangedBack.BackColor = SystemColors.Control;
      this.ColorChangedBack.FlatStyle = FlatStyle.Flat;
      this.ColorChangedBack.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 8);
      this.ColorChangedBack.Location = point;
      this.ColorChangedBack.Name = "ColorChangedBack";
      size = new Size(0x18, 0x18);
      this.ColorChangedBack.Size = size;
      this.ColorChangedBack.TabIndex = 0;
      this.ColorDoubleText.BackColor = SystemColors.Control;
      this.ColorDoubleText.FlatStyle = FlatStyle.Flat;
      this.ColorDoubleText.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 0x68);
      this.ColorDoubleText.Location = point;
      this.ColorDoubleText.Name = "ColorDoubleText";
      size = new Size(0x18, 0x18);
      this.ColorDoubleText.Size = size;
      this.ColorDoubleText.TabIndex = 3;
      this.ColorDoubleBack.BackColor = SystemColors.Control;
      this.ColorDoubleBack.FlatStyle = FlatStyle.Flat;
      this.ColorDoubleBack.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 0x48);
      this.ColorDoubleBack.Location = point;
      this.ColorDoubleBack.Name = "ColorDoubleBack";
      size = new Size(0x18, 0x18);
      this.ColorDoubleBack.Size = size;
      this.ColorDoubleBack.TabIndex = 2;
      this.ColorChangedText.BackColor = SystemColors.Control;
      this.ColorChangedText.FlatStyle = FlatStyle.Flat;
      this.ColorChangedText.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 40);
      this.ColorChangedText.Location = point;
      this.ColorChangedText.Name = "ColorChangedText";
      size = new Size(0x18, 0x18);
      this.ColorChangedText.Size = size;
      this.ColorChangedText.TabIndex = 1;
      this.ToolGrid.AllowNavigation = false;
      this.ToolGrid.CaptionVisible = false;
      this.ToolGrid.DataMember = "";
      this.ToolGrid.HeaderForeColor = SystemColors.ControlText;
      point = new Point(8, 0xb0);
      this.ToolGrid.Location = point;
      this.ToolGrid.Name = "ToolGrid";
      this.ToolGrid.ParentRowsVisible = false;
      this.ToolGrid.ReadOnly = true;
      this.ToolGrid.RowHeadersVisible = false;
      size = new Size(0x210, 0xb8);
      this.ToolGrid.Size = size;
      this.ToolGrid.TabIndex = 11;
      this.ToolGrid.TableStyles.AddRange(new DataGridTableStyle[] { this.Style });
      this.Style.DataGrid = this.ToolGrid;
      this.Style.GridColumnStyles.AddRange(new DataGridColumnStyle[] { this.C1, this.C2, this.C3, this.C4, this.C5 });
      this.Style.HeaderForeColor = SystemColors.ControlText;
      this.Style.MappingName = "";
      this.C1.Format = "";
      this.C1.FormatInfo = null;
      this.C1.HeaderText = "Tool description";
      this.C1.MappingName = "ToolDescription";
      this.C1.Width = 0x4b;
      this.C2.Format = "";
      this.C2.FormatInfo = null;
      this.C2.HeaderText = "Tool path";
      this.C2.MappingName = "ToolPath";
      this.C2.Width = 0x4b;
      this.C3.Format = "";
      this.C3.FormatInfo = null;
      this.C3.HeaderText = "Tool parameters";
      this.C3.MappingName = "ToolParameter";
      this.C3.Width = 0x55;
      this.C4.FalseValue = false;
      this.C4.HeaderText = "Default Player";
      this.C4.MappingName = "DefaultPlayer";
      this.C4.NullValue = RuntimeHelpers.GetObjectValue(manager.GetObject("C4.NullValue"));
      this.C4.TrueValue = true;
      this.C4.Width = 0x4b;
      this.C5.Format = "";
      this.C5.FormatInfo = null;
      this.C5.HeaderText = "Shell command";
      this.C5.MappingName = "ShellCommand";
      this.C5.Width = 0x55;
      this.btnRemove.BackColor = SystemColors.Control;
      this.btnRemove.ImeMode = ImeMode.NoControl;
      point = new Point(280, 0x90);
      this.btnRemove.Location = point;
      this.btnRemove.Name = "btnRemove";
      size = new Size(0x100, 0x18);
      this.btnRemove.Size = size;
      this.btnRemove.TabIndex = 10;
      this.btnRemove.Text = "Remove tool from list";
      this.btnAdd.BackColor = SystemColors.Control;
      this.btnAdd.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x90);
      this.btnAdd.Location = point;
      this.btnAdd.Name = "btnAdd";
      size = new Size(0x100, 0x18);
      this.btnAdd.Size = size;
      this.btnAdd.TabIndex = 9;
      this.btnAdd.Text = "Add tool to list";
      this.lblP.BackColor = System.Drawing.Color.Transparent;
      this.lblP.ImeMode = ImeMode.NoControl;
      point = new Point(0x88, 80);
      this.lblP.Location = point;
      this.lblP.Name = "lblP";
      size = new Size(0x138, 0x10);
      this.lblP.Size = size;
      this.lblP.TabIndex = 8;
      this.lblP.Text = "%P = MP3-Path";
      this.btnBrowse.BackColor = SystemColors.Control;
      this.btnBrowse.ImeMode = ImeMode.NoControl;
      point = new Point(0x1c8, 0x20);
      this.btnBrowse.Location = point;
      this.btnBrowse.Name = "btnBrowse";
      size = new Size(80, 20);
      this.btnBrowse.Size = size;
      this.btnBrowse.TabIndex = 4;
      this.btnBrowse.Text = "&Browse";
      this.cmbShell.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbShell.ItemHeight = 13;
      point = new Point(0xe8, 0x68);
      this.cmbShell.Location = point;
      this.cmbShell.Name = "cmbShell";
      size = new Size(0xd0, 0x15);
      this.cmbShell.Size = size;
      this.cmbShell.TabIndex = 7;
      point = new Point(0x8a, 0x38);
      this.txtParameters.Location = point;
      this.txtParameters.Name = "txtParameters";
      size = new Size(0x130, 20);
      this.txtParameters.Size = size;
      this.txtParameters.TabIndex = 5;
      this.txtParameters.Text = "";
      point = new Point(0x8a, 0x20);
      this.txtPath.Location = point;
      this.txtPath.Name = "txtPath";
      size = new Size(0x130, 20);
      this.txtPath.Size = size;
      this.txtPath.TabIndex = 3;
      this.txtPath.Text = "";
      point = new Point(0x8a, 8);
      this.txtDescription.Location = point;
      this.txtDescription.Name = "txtDescription";
      size = new Size(0x130, 20);
      this.txtDescription.Size = size;
      this.txtDescription.TabIndex = 1;
      this.txtDescription.Text = "";
      this.chkDefault.BackColor = System.Drawing.Color.Transparent;
      this.chkDefault.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x6a);
      this.chkDefault.Location = point;
      this.chkDefault.Name = "chkDefault";
      size = new Size(0xd8, 0x10);
      this.chkDefault.Size = size;
      this.chkDefault.TabIndex = 6;
      this.chkDefault.Text = "Use &Windows default MP3-Player:";
      this.lblParameters.BackColor = System.Drawing.Color.Transparent;
      this.lblParameters.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x3a);
      this.lblParameters.Location = point;
      this.lblParameters.Name = "lblParameters";
      size = new Size(120, 0x10);
      this.lblParameters.Size = size;
      this.lblParameters.TabIndex = 4;
      this.lblParameters.Text = "Tool &parameters:";
      this.lblPath.BackColor = System.Drawing.Color.Transparent;
      this.lblPath.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x22);
      this.lblPath.Location = point;
      this.lblPath.Name = "lblPath";
      size = new Size(120, 0x10);
      this.lblPath.Size = size;
      this.lblPath.TabIndex = 2;
      this.lblPath.Text = "Tool &path:";
      this.lblDescription.BackColor = System.Drawing.Color.Transparent;
      this.lblDescription.ImeMode = ImeMode.NoControl;
      point = new Point(8, 10);
      this.lblDescription.Location = point;
      this.lblDescription.Name = "lblDescription";
      size = new Size(120, 0x10);
      this.lblDescription.Size = size;
      this.lblDescription.TabIndex = 0;
      this.lblDescription.Text = "Tool &description:";
      this.btnOK.BackColor = SystemColors.Control;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0x120, 8);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(120, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 100;
      this.btnOK.Text = "&OK";
      this.btnCancel.BackColor = SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      point = new Point(0x1a0, 8);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(120, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x65;
      this.btnCancel.Text = "&Cancel";
      this.ColorDialog.AnyColor = true;
      this.ButtomPanel.AntiAlias = true;
      this.ButtomPanel.Controls.Add(this.btnOK);
      this.ButtomPanel.Controls.Add(this.btnCancel);
      this.ButtomPanel.Dock = DockStyle.Bottom;
      point = new Point(0, 400);
      this.ButtomPanel.Location = point;
      this.ButtomPanel.Name = "ButtomPanel";
      size = new Size(0x222, 40);
      this.ButtomPanel.Size = size;
      this.ButtomPanel.Style.BackColor1.Color = System.Drawing.Color.White;
      this.ButtomPanel.Style.BackColor2.Color = System.Drawing.Color.White;
      this.ButtomPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
      this.ButtomPanel.Style.BorderWidth = 0;
      this.ButtomPanel.Style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.ButtomPanel.Style.ForeColor.Color = System.Drawing.Color.Black;
      this.ButtomPanel.Style.GradientAngle = 90;
      this.ButtomPanel.Style.LineAlignment = StringAlignment.Near;
      this.ButtomPanel.Style.MarginBottom = 2;
      this.ButtomPanel.Style.MarginLeft = 7;
      this.ButtomPanel.Style.MarginRight = 2;
      this.ButtomPanel.Style.MarginTop = 2;
      this.ButtomPanel.TabIndex = 0x77;
      this.TabControl.CanReorderTabs = true;
      this.TabControl.Controls.Add(this.TabControlPanel1);
      this.TabControl.Controls.Add(this.TabControlPanel3);
      this.TabControl.Controls.Add(this.TabControlPanel2);
      this.TabControl.Controls.Add(this.TabControlPanel6);
      this.TabControl.Controls.Add(this.TabControlPanel5);
      this.TabControl.Controls.Add(this.TabControlPanel4);
      this.TabControl.Dock = DockStyle.Fill;
      point = new Point(0, 0);
      this.TabControl.Location = point;
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
      this.TabControl.SelectedTabIndex = 0;
      size = new Size(0x222, 400);
      this.TabControl.Size = size;
      this.TabControl.Style = eTabStripStyle.VS2005Document;
      this.TabControl.TabIndex = 120;
      this.TabControl.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
      this.TabControl.Tabs.Add(this.Settings);
      this.TabControl.Tabs.Add(this.Ver2);
      this.TabControl.Tabs.Add(this.Columns);
      this.TabControl.Tabs.Add(this.FreeDB);
      this.TabControl.Tabs.Add(this.Colors);
      this.TabControl.Tabs.Add(this.Tools);
      this.TabControlPanel1.AntiAlias = true;
      this.TabControlPanel1.Controls.Add(this.chkAudioChecksumCalc);
      this.TabControlPanel1.Controls.Add(this.chkIgnoreWrite);
      this.TabControlPanel1.Controls.Add(this.chkMouseRenaming);
      this.TabControlPanel1.Controls.Add(this.chkRestore);
      this.TabControlPanel1.Controls.Add(this.lblTracknumbers);
      this.TabControlPanel1.Controls.Add(this.txtTFDigits);
      this.TabControlPanel1.Controls.Add(this.frameSelection);
      this.TabControlPanel1.Controls.Add(this.chkSaveOnExit);
      this.TabControlPanel1.Controls.Add(this.frameDoubleClick);
      this.TabControlPanel1.Controls.Add(this.lblPlay);
      this.TabControlPanel1.Controls.Add(this.cmbPlay);
      this.TabControlPanel1.Controls.Add(this.chkExplorerContext);
      this.TabControlPanel1.Controls.Add(this.frameEnum);
      this.TabControlPanel1.Dock = DockStyle.Fill;
      this.TabControlPanel1.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel1.Location = point;
      this.TabControlPanel1.Name = "TabControlPanel1";
      size = new Size(0x222, 0x176);
      this.TabControlPanel1.Size = size;
      this.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(0xf3, 0xf4, 250);
      this.TabControlPanel1.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel1.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel1.Style.GradientAngle = 90;
      this.TabControlPanel1.TabIndex = 1;
      this.TabControlPanel1.TabItem = this.Settings;
      this.chkAudioChecksumCalc.BackColor = System.Drawing.Color.Transparent;
      this.chkAudioChecksumCalc.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x114);
      this.chkAudioChecksumCalc.Location = point;
      this.chkAudioChecksumCalc.Name = "chkAudioChecksumCalc";
      size = new Size(520, 0x10);
      this.chkAudioChecksumCalc.Size = size;
      this.chkAudioChecksumCalc.TabIndex = 0x11;
      this.chkAudioChecksumCalc.Text = "&Calculate Audiochecksum in the background";
      this.Settings.AttachedControl = this.TabControlPanel1;
      this.Settings.Icon = (Icon)manager.GetObject("Settings.Icon");
      this.Settings.Name = "Settings";
      this.Settings.Text = "Settings";
      this.TabControlPanel3.AntiAlias = true;
      this.TabControlPanel3.Controls.Add(this.lblV24);
      this.TabControlPanel3.Controls.Add(this.lblV23);
      this.TabControlPanel3.Controls.Add(this.cmbV24Enc);
      this.TabControlPanel3.Controls.Add(this.lblTextEncInfo);
      this.TabControlPanel3.Controls.Add(this.chkSingle);
      this.TabControlPanel3.Controls.Add(this.chkUnSync);
      this.TabControlPanel3.Controls.Add(this.optUse24);
      this.TabControlPanel3.Controls.Add(this.lblFormat);
      this.TabControlPanel3.Controls.Add(this.cmbV23Enc);
      this.TabControlPanel3.Controls.Add(this.optUse23);
      this.TabControlPanel3.Controls.Add(this.cmbYearFormat);
      this.TabControlPanel3.Controls.Add(this.lblDigits);
      this.TabControlPanel3.Controls.Add(this.txtTTDigits);
      this.TabControlPanel3.Dock = DockStyle.Fill;
      this.TabControlPanel3.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel3.Location = point;
      this.TabControlPanel3.Name = "TabControlPanel3";
      size = new Size(0x222, 0x176);
      this.TabControlPanel3.Size = size;
      this.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(0xf3, 0xf4, 250);
      this.TabControlPanel3.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel3.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel3.Style.GradientAngle = 90;
      this.TabControlPanel3.TabIndex = 3;
      this.TabControlPanel3.TabItem = this.Ver2;
      this.Ver2.AttachedControl = this.TabControlPanel3;
      this.Ver2.Name = "Ver2";
      this.Ver2.Text = "TAG Ver. 2";
      this.TabControlPanel2.AntiAlias = true;
      this.TabControlPanel2.Controls.Add(this.btnUp);
      this.TabControlPanel2.Controls.Add(this.btnDown);
      this.TabControlPanel2.Controls.Add(this.lblDescript);
      this.TabControlPanel2.Controls.Add(this.ColumnsList);
      this.TabControlPanel2.Dock = DockStyle.Fill;
      this.TabControlPanel2.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel2.Location = point;
      this.TabControlPanel2.Name = "TabControlPanel2";
      size = new Size(0x222, 0x176);
      this.TabControlPanel2.Size = size;
      this.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(0xf3, 0xf4, 250);
      this.TabControlPanel2.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel2.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel2.Style.GradientAngle = 90;
      this.TabControlPanel2.TabIndex = 2;
      this.TabControlPanel2.TabItem = this.Columns;
      this.Columns.AttachedControl = this.TabControlPanel2;
      this.Columns.Icon = (Icon)manager.GetObject("Columns.Icon");
      this.Columns.Name = "Columns";
      this.Columns.Text = "Columns";
      this.TabControlPanel6.AntiAlias = true;
      this.TabControlPanel6.Controls.Add(this.btnBrowse);
      this.TabControlPanel6.Controls.Add(this.cmbShell);
      this.TabControlPanel6.Controls.Add(this.txtParameters);
      this.TabControlPanel6.Controls.Add(this.txtPath);
      this.TabControlPanel6.Controls.Add(this.txtDescription);
      this.TabControlPanel6.Controls.Add(this.chkDefault);
      this.TabControlPanel6.Controls.Add(this.ToolGrid);
      this.TabControlPanel6.Controls.Add(this.lblPath);
      this.TabControlPanel6.Controls.Add(this.btnRemove);
      this.TabControlPanel6.Controls.Add(this.lblDescription);
      this.TabControlPanel6.Controls.Add(this.lblParameters);
      this.TabControlPanel6.Controls.Add(this.btnAdd);
      this.TabControlPanel6.Controls.Add(this.lblP);
      this.TabControlPanel6.Dock = DockStyle.Fill;
      this.TabControlPanel6.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel6.Location = point;
      this.TabControlPanel6.Name = "TabControlPanel6";
      size = new Size(0x222, 0x176);
      this.TabControlPanel6.Size = size;
      this.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(0xf3, 0xf4, 250);
      this.TabControlPanel6.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel6.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel6.Style.GradientAngle = 90;
      this.TabControlPanel6.TabIndex = 6;
      this.TabControlPanel6.TabItem = this.Tools;
      this.Tools.AttachedControl = this.TabControlPanel6;
      this.Tools.Icon = (Icon)manager.GetObject("Tools.Icon");
      this.Tools.Name = "Tools";
      this.Tools.Text = "Tools";
      this.TabControlPanel5.AntiAlias = true;
      this.TabControlPanel5.Controls.Add(this.ColorDoubleText);
      this.TabControlPanel5.Controls.Add(this.ColorDoubleBack);
      this.TabControlPanel5.Controls.Add(this.chkWinXPThemes);
      this.TabControlPanel5.Controls.Add(this.Label5);
      this.TabControlPanel5.Controls.Add(this.Label6);
      this.TabControlPanel5.Controls.Add(this.ColorCompareText);
      this.TabControlPanel5.Controls.Add(this.ColorCompareBack);
      this.TabControlPanel5.Controls.Add(this.Label4);
      this.TabControlPanel5.Controls.Add(this.Label3);
      this.TabControlPanel5.Controls.Add(this.Label2);
      this.TabControlPanel5.Controls.Add(this.Label1);
      this.TabControlPanel5.Controls.Add(this.ColorChangedBack);
      this.TabControlPanel5.Controls.Add(this.ColorChangedText);
      this.TabControlPanel5.Dock = DockStyle.Fill;
      this.TabControlPanel5.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel5.Location = point;
      this.TabControlPanel5.Name = "TabControlPanel5";
      size = new Size(0x222, 0x176);
      this.TabControlPanel5.Size = size;
      this.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(0xf3, 0xf4, 250);
      this.TabControlPanel5.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel5.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel5.Style.GradientAngle = 90;
      this.TabControlPanel5.TabIndex = 5;
      this.TabControlPanel5.TabItem = this.Colors;
      this.Colors.AttachedControl = this.TabControlPanel5;
      this.Colors.Icon = (Icon)manager.GetObject("Colors.Icon");
      this.Colors.Name = "Colors";
      this.Colors.Text = "Colors";
      this.TabControlPanel4.AntiAlias = true;
      this.TabControlPanel4.Controls.Add(this.lblUsername);
      this.TabControlPanel4.Controls.Add(this.Username);
      this.TabControlPanel4.Controls.Add(this.lblPort);
      this.TabControlPanel4.Controls.Add(this.lblServer);
      this.TabControlPanel4.Controls.Add(this.Server);
      this.TabControlPanel4.Controls.Add(this.Port);
      this.TabControlPanel4.Controls.Add(this.grpProxy);
      this.TabControlPanel4.Controls.Add(this.chkProxy);
      this.TabControlPanel4.Dock = DockStyle.Fill;
      this.TabControlPanel4.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel4.Location = point;
      this.TabControlPanel4.Name = "TabControlPanel4";
      size = new Size(0x222, 0x176);
      this.TabControlPanel4.Size = size;
      this.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(0xf3, 0xf4, 250);
      this.TabControlPanel4.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel4.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel4.Style.GradientAngle = 90;
      this.TabControlPanel4.TabIndex = 4;
      this.TabControlPanel4.TabItem = this.FreeDB;
      this.FreeDB.AttachedControl = this.TabControlPanel4;
      this.FreeDB.Icon = (Icon)manager.GetObject("FreeDB.Icon");
      this.FreeDB.Name = "FreeDB";
      this.FreeDB.Text = "FreeDB";
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      size = new Size(0x222, 440);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add(this.TabControl);
      this.Controls.Add(this.ButtomPanel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmPreferences";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Preferences";
      this.frameEnum.ResumeLayout(false);
      this.txtFDigits.EndInit();
      this.txtStartNr.EndInit();
      this.txtTFDigits.EndInit();
      this.frameSelection.ResumeLayout(false);
      this.frameDoubleClick.ResumeLayout(false);
      this.txtTTDigits.EndInit();
      this.grpProxy.ResumeLayout(false);
      this.ToolGrid.EndInit();
      this.ButtomPanel.ResumeLayout(false);
      ((ISupportInitialize)this.TabControl).EndInit();
      this.TabControl.ResumeLayout(false);
      this.TabControlPanel1.ResumeLayout(false);
      this.TabControlPanel3.ResumeLayout(false);
      this.TabControlPanel2.ResumeLayout(false);
      this.TabControlPanel6.ResumeLayout(false);
      this.TabControlPanel5.ResumeLayout(false);
      this.TabControlPanel4.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void txtEnumSept_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '\\':
        case '|':
        case '"':
        case '/':
        case '*':
        case '?':
        case '<':
        case '>':
          e.Handled = true;
          break;
      }
    }

    internal virtual Button btnAdd
    {
      get
      {
        return this._btnAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAdd != null)
        {
          this._btnAdd.Click -= new EventHandler(this.btnAdd_Click);
        }
        this._btnAdd = value;
        if (this._btnAdd != null)
        {
          this._btnAdd.Click += new EventHandler(this.btnAdd_Click);
        }
      }
    }

    internal virtual Button btnBrowse
    {
      get
      {
        return this._btnBrowse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnBrowse != null)
        {
          this._btnBrowse.Click -= new EventHandler(this.btnBrowse_Click);
        }
        this._btnBrowse = value;
        if (this._btnBrowse != null)
        {
          this._btnBrowse.Click += new EventHandler(this.btnBrowse_Click);
        }
      }
    }

    internal virtual Button btnCancel
    {
      get
      {
        return this._btnCancel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnCancel != null)
        {
        }
        this._btnCancel = value;
        if (this._btnCancel != null)
        {
        }
      }
    }

    internal virtual Button btnDown
    {
      get
      {
        return this._btnDown;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnDown != null)
        {
          this._btnDown.Click -= new EventHandler(this.btnDown_Click);
        }
        this._btnDown = value;
        if (this._btnDown != null)
        {
          this._btnDown.Click += new EventHandler(this.btnDown_Click);
        }
      }
    }

    internal virtual Button btnOK
    {
      get
      {
        return this._btnOK;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnOK != null)
        {
          this._btnOK.Click -= new EventHandler(this.btnOK_Click);
        }
        this._btnOK = value;
        if (this._btnOK != null)
        {
          this._btnOK.Click += new EventHandler(this.btnOK_Click);
        }
      }
    }

    internal virtual Button btnRemove
    {
      get
      {
        return this._btnRemove;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemove != null)
        {
          this._btnRemove.Click -= new EventHandler(this.btnRemove_Click);
        }
        this._btnRemove = value;
        if (this._btnRemove != null)
        {
          this._btnRemove.Click += new EventHandler(this.btnRemove_Click);
        }
      }
    }

    internal virtual Button btnUp
    {
      get
      {
        return this._btnUp;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnUp != null)
        {
          this._btnUp.Click -= new EventHandler(this.btnUp_Click);
        }
        this._btnUp = value;
        if (this._btnUp != null)
        {
          this._btnUp.Click += new EventHandler(this.btnUp_Click);
        }
      }
    }

    internal virtual PanelEx ButtomPanel
    {
      get
      {
        return this._ButtomPanel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ButtomPanel != null)
        {
        }
        this._ButtomPanel = value;
        if (this._ButtomPanel != null)
        {
        }
      }
    }

    internal virtual DataGridTextBoxColumn C1
    {
      get
      {
        return this._C1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._C1 != null)
        {
        }
        this._C1 = value;
        if (this._C1 != null)
        {
        }
      }
    }

    internal virtual DataGridTextBoxColumn C2
    {
      get
      {
        return this._C2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._C2 != null)
        {
        }
        this._C2 = value;
        if (this._C2 != null)
        {
        }
      }
    }

    internal virtual DataGridTextBoxColumn C3
    {
      get
      {
        return this._C3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._C3 != null)
        {
        }
        this._C3 = value;
        if (this._C3 != null)
        {
        }
      }
    }

    internal virtual DataGridBoolColumn C4
    {
      get
      {
        return this._C4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._C4 != null)
        {
        }
        this._C4 = value;
        if (this._C4 != null)
        {
        }
      }
    }

    internal virtual DataGridTextBoxColumn C5
    {
      get
      {
        return this._C5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._C5 != null)
        {
        }
        this._C5 = value;
        if (this._C5 != null)
        {
        }
      }
    }

    internal virtual CheckBox chkAudioChecksumCalc
    {
      get
      {
        return this._chkAudioChecksumCalc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkAudioChecksumCalc != null)
        {
        }
        this._chkAudioChecksumCalc = value;
        if (this._chkAudioChecksumCalc != null)
        {
        }
      }
    }

    internal virtual CheckBox chkDefault
    {
      get
      {
        return this._chkDefault;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkDefault != null)
        {
          this._chkDefault.CheckedChanged -= new EventHandler(this.chkDefault_CheckedChanged);
        }
        this._chkDefault = value;
        if (this._chkDefault != null)
        {
          this._chkDefault.CheckedChanged += new EventHandler(this.chkDefault_CheckedChanged);
        }
      }
    }

    internal virtual CheckBox chkExplorerContext
    {
      get
      {
        return this._chkExplorerContext;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkExplorerContext != null)
        {
        }
        this._chkExplorerContext = value;
        if (this._chkExplorerContext != null)
        {
        }
      }
    }

    internal virtual CheckBox chkIgnoreWrite
    {
      get
      {
        return this._chkIgnoreWrite;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkIgnoreWrite != null)
        {
        }
        this._chkIgnoreWrite = value;
        if (this._chkIgnoreWrite != null)
        {
        }
      }
    }

    internal virtual CheckBox chkMouseRenaming
    {
      get
      {
        return this._chkMouseRenaming;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkMouseRenaming != null)
        {
        }
        this._chkMouseRenaming = value;
        if (this._chkMouseRenaming != null)
        {
        }
      }
    }

    internal virtual CheckBox chkProxy
    {
      get
      {
        return this._chkProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkProxy != null)
        {
          this._chkProxy.CheckedChanged -= new EventHandler(this.chkProxy_CheckedChanged);
        }
        this._chkProxy = value;
        if (this._chkProxy != null)
        {
          this._chkProxy.CheckedChanged += new EventHandler(this.chkProxy_CheckedChanged);
        }
      }
    }

    internal virtual CheckBox chkRestore
    {
      get
      {
        return this._chkRestore;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkRestore != null)
        {
        }
        this._chkRestore = value;
        if (this._chkRestore != null)
        {
        }
      }
    }

    internal virtual CheckBox chkSaveOnExit
    {
      get
      {
        return this._chkSaveOnExit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkSaveOnExit != null)
        {
        }
        this._chkSaveOnExit = value;
        if (this._chkSaveOnExit != null)
        {
        }
      }
    }

    internal virtual CheckBox chkSingle
    {
      get
      {
        return this._chkSingle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkSingle != null)
        {
        }
        this._chkSingle = value;
        if (this._chkSingle != null)
        {
        }
      }
    }

    internal virtual CheckBox chkUnSync
    {
      get
      {
        return this._chkUnSync;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkUnSync != null)
        {
        }
        this._chkUnSync = value;
        if (this._chkUnSync != null)
        {
        }
      }
    }

    internal virtual CheckBox chkWinXPThemes
    {
      get
      {
        return this._chkWinXPThemes;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkWinXPThemes != null)
        {
        }
        this._chkWinXPThemes = value;
        if (this._chkWinXPThemes != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbPlay
    {
      get
      {
        return this._cmbPlay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbPlay != null)
        {
        }
        this._cmbPlay = value;
        if (this._cmbPlay != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbShell
    {
      get
      {
        return this._cmbShell;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbShell != null)
        {
        }
        this._cmbShell = value;
        if (this._cmbShell != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbV23Enc
    {
      get
      {
        return this._cmbV23Enc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbV23Enc != null)
        {
        }
        this._cmbV23Enc = value;
        if (this._cmbV23Enc != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbV24Enc
    {
      get
      {
        return this._cmbV24Enc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbV24Enc != null)
        {
        }
        this._cmbV24Enc = value;
        if (this._cmbV24Enc != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbYearFormat
    {
      get
      {
        return this._cmbYearFormat;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbYearFormat != null)
        {
        }
        this._cmbYearFormat = value;
        if (this._cmbYearFormat != null)
        {
        }
      }
    }

    internal virtual Button ColorChangedBack
    {
      get
      {
        return this._ColorChangedBack;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColorChangedBack != null)
        {
          this._ColorChangedBack.Click -= new EventHandler(this.ColorChangedBack_Click);
        }
        this._ColorChangedBack = value;
        if (this._ColorChangedBack != null)
        {
          this._ColorChangedBack.Click += new EventHandler(this.ColorChangedBack_Click);
        }
      }
    }

    internal virtual Button ColorChangedText
    {
      get
      {
        return this._ColorChangedText;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColorChangedText != null)
        {
          this._ColorChangedText.Click -= new EventHandler(this.ColorChangedBack_Click);
        }
        this._ColorChangedText = value;
        if (this._ColorChangedText != null)
        {
          this._ColorChangedText.Click += new EventHandler(this.ColorChangedBack_Click);
        }
      }
    }

    internal virtual Button ColorCompareBack
    {
      get
      {
        return this._ColorCompareBack;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColorCompareBack != null)
        {
          this._ColorCompareBack.Click -= new EventHandler(this.ColorChangedBack_Click);
        }
        this._ColorCompareBack = value;
        if (this._ColorCompareBack != null)
        {
          this._ColorCompareBack.Click += new EventHandler(this.ColorChangedBack_Click);
        }
      }
    }

    internal virtual Button ColorCompareText
    {
      get
      {
        return this._ColorCompareText;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColorCompareText != null)
        {
          this._ColorCompareText.Click -= new EventHandler(this.ColorChangedBack_Click);
        }
        this._ColorCompareText = value;
        if (this._ColorCompareText != null)
        {
          this._ColorCompareText.Click += new EventHandler(this.ColorChangedBack_Click);
        }
      }
    }

    internal virtual System.Windows.Forms.ColorDialog ColorDialog
    {
      get
      {
        return this._ColorDialog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColorDialog != null)
        {
        }
        this._ColorDialog = value;
        if (this._ColorDialog != null)
        {
        }
      }
    }

    internal virtual Button ColorDoubleBack
    {
      get
      {
        return this._ColorDoubleBack;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColorDoubleBack != null)
        {
          this._ColorDoubleBack.Click -= new EventHandler(this.ColorChangedBack_Click);
        }
        this._ColorDoubleBack = value;
        if (this._ColorDoubleBack != null)
        {
          this._ColorDoubleBack.Click += new EventHandler(this.ColorChangedBack_Click);
        }
      }
    }

    internal virtual Button ColorDoubleText
    {
      get
      {
        return this._ColorDoubleText;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColorDoubleText != null)
        {
          this._ColorDoubleText.Click -= new EventHandler(this.ColorChangedBack_Click);
        }
        this._ColorDoubleText = value;
        if (this._ColorDoubleText != null)
        {
          this._ColorDoubleText.Click += new EventHandler(this.ColorChangedBack_Click);
        }
      }
    }

    internal virtual TabItem Colors
    {
      get
      {
        return this._Colors;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Colors != null)
        {
        }
        this._Colors = value;
        if (this._Colors != null)
        {
        }
      }
    }

    internal virtual TabItem Columns
    {
      get
      {
        return this._Columns;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Columns != null)
        {
        }
        this._Columns = value;
        if (this._Columns != null)
        {
        }
      }
    }

    internal virtual ListView ColumnsList
    {
      get
      {
        return this._ColumnsList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnsList != null)
        {
          this._ColumnsList.ItemCheck -= new ItemCheckEventHandler(this.ColumnsList_ItemCheck);
        }
        this._ColumnsList = value;
        if (this._ColumnsList != null)
        {
          this._ColumnsList.ItemCheck += new ItemCheckEventHandler(this.ColumnsList_ItemCheck);
        }
      }
    }

    internal virtual GroupBox frameDoubleClick
    {
      get
      {
        return this._frameDoubleClick;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._frameDoubleClick != null)
        {
        }
        this._frameDoubleClick = value;
        if (this._frameDoubleClick != null)
        {
        }
      }
    }

    internal virtual GroupBox frameEnum
    {
      get
      {
        return this._frameEnum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._frameEnum != null)
        {
        }
        this._frameEnum = value;
        if (this._frameEnum != null)
        {
        }
      }
    }

    internal virtual GroupBox frameSelection
    {
      get
      {
        return this._frameSelection;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._frameSelection != null)
        {
        }
        this._frameSelection = value;
        if (this._frameSelection != null)
        {
        }
      }
    }

    internal virtual TabItem FreeDB
    {
      get
      {
        return this._FreeDB;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._FreeDB != null)
        {
        }
        this._FreeDB = value;
        if (this._FreeDB != null)
        {
        }
      }
    }

    internal virtual GroupBox grpProxy
    {
      get
      {
        return this._grpProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._grpProxy != null)
        {
        }
        this._grpProxy = value;
        if (this._grpProxy != null)
        {
        }
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label1 != null)
        {
        }
        this._Label1 = value;
        if (this._Label1 != null)
        {
        }
      }
    }

    internal virtual Label Label10
    {
      get
      {
        return this._Label10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label10 != null)
        {
        }
        this._Label10 = value;
        if (this._Label10 != null)
        {
        }
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label2 != null)
        {
        }
        this._Label2 = value;
        if (this._Label2 != null)
        {
        }
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label3 != null)
        {
        }
        this._Label3 = value;
        if (this._Label3 != null)
        {
        }
      }
    }

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label4 != null)
        {
        }
        this._Label4 = value;
        if (this._Label4 != null)
        {
        }
      }
    }

    internal virtual Label Label5
    {
      get
      {
        return this._Label5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label5 != null)
        {
        }
        this._Label5 = value;
        if (this._Label5 != null)
        {
        }
      }
    }

    internal virtual Label Label6
    {
      get
      {
        return this._Label6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label6 != null)
        {
        }
        this._Label6 = value;
        if (this._Label6 != null)
        {
        }
      }
    }

    internal virtual Label Label7
    {
      get
      {
        return this._Label7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label7 != null)
        {
        }
        this._Label7 = value;
        if (this._Label7 != null)
        {
        }
      }
    }

    internal virtual Label Label8
    {
      get
      {
        return this._Label8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label8 != null)
        {
        }
        this._Label8 = value;
        if (this._Label8 != null)
        {
        }
      }
    }

    internal virtual Label Label9
    {
      get
      {
        return this._Label9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label9 != null)
        {
        }
        this._Label9 = value;
        if (this._Label9 != null)
        {
        }
      }
    }

    internal virtual Label lbl1
    {
      get
      {
        return this._lbl1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lbl1 != null)
        {
        }
        this._lbl1 = value;
        if (this._lbl1 != null)
        {
        }
      }
    }

    internal virtual Label lbl2
    {
      get
      {
        return this._lbl2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lbl2 != null)
        {
        }
        this._lbl2 = value;
        if (this._lbl2 != null)
        {
        }
      }
    }

    internal virtual Label lblDescript
    {
      get
      {
        return this._lblDescript;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblDescript != null)
        {
        }
        this._lblDescript = value;
        if (this._lblDescript != null)
        {
        }
      }
    }

    internal virtual Label lblDescription
    {
      get
      {
        return this._lblDescription;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblDescription != null)
        {
        }
        this._lblDescription = value;
        if (this._lblDescription != null)
        {
        }
      }
    }

    internal virtual Label lblDigits
    {
      get
      {
        return this._lblDigits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblDigits != null)
        {
        }
        this._lblDigits = value;
        if (this._lblDigits != null)
        {
        }
      }
    }

    internal virtual Label lblEnumSep
    {
      get
      {
        return this._lblEnumSep;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblEnumSep != null)
        {
        }
        this._lblEnumSep = value;
        if (this._lblEnumSep != null)
        {
        }
      }
    }

    internal virtual Label lblFormat
    {
      get
      {
        return this._lblFormat;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblFormat != null)
        {
        }
        this._lblFormat = value;
        if (this._lblFormat != null)
        {
        }
      }
    }

    internal virtual Label lblP
    {
      get
      {
        return this._lblP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblP != null)
        {
        }
        this._lblP = value;
        if (this._lblP != null)
        {
        }
      }
    }

    internal virtual Label lblParameters
    {
      get
      {
        return this._lblParameters;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblParameters != null)
        {
        }
        this._lblParameters = value;
        if (this._lblParameters != null)
        {
        }
      }
    }

    internal virtual Label lblPath
    {
      get
      {
        return this._lblPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPath != null)
        {
        }
        this._lblPath = value;
        if (this._lblPath != null)
        {
        }
      }
    }

    internal virtual Label lblPlay
    {
      get
      {
        return this._lblPlay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPlay != null)
        {
        }
        this._lblPlay = value;
        if (this._lblPlay != null)
        {
        }
      }
    }

    internal virtual Label lblPort
    {
      get
      {
        return this._lblPort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPort != null)
        {
        }
        this._lblPort = value;
        if (this._lblPort != null)
        {
        }
      }
    }

    internal virtual Label lblServer
    {
      get
      {
        return this._lblServer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblServer != null)
        {
        }
        this._lblServer = value;
        if (this._lblServer != null)
        {
        }
      }
    }

    internal virtual Label lblTextEncInfo
    {
      get
      {
        return this._lblTextEncInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTextEncInfo != null)
        {
        }
        this._lblTextEncInfo = value;
        if (this._lblTextEncInfo != null)
        {
        }
      }
    }

    internal virtual Label lblTracknumbers
    {
      get
      {
        return this._lblTracknumbers;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTracknumbers != null)
        {
        }
        this._lblTracknumbers = value;
        if (this._lblTracknumbers != null)
        {
        }
      }
    }

    internal virtual Label lblUsername
    {
      get
      {
        return this._lblUsername;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblUsername != null)
        {
        }
        this._lblUsername = value;
        if (this._lblUsername != null)
        {
        }
      }
    }

    internal virtual Label lblV23
    {
      get
      {
        return this._lblV23;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblV23 != null)
        {
        }
        this._lblV23 = value;
        if (this._lblV23 != null)
        {
        }
      }
    }

    internal virtual Label lblV24
    {
      get
      {
        return this._lblV24;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblV24 != null)
        {
        }
        this._lblV24 = value;
        if (this._lblV24 != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.OpenFileDialog OpenFileDialog
    {
      get
      {
        return this._OpenFileDialog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._OpenFileDialog != null)
        {
        }
        this._OpenFileDialog = value;
        if (this._OpenFileDialog != null)
        {
        }
      }
    }

    internal virtual RadioButton optAdd
    {
      get
      {
        return this._optAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optAdd != null)
        {
        }
        this._optAdd = value;
        if (this._optAdd != null)
        {
        }
      }
    }

    internal virtual RadioButton optEditCur
    {
      get
      {
        return this._optEditCur;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optEditCur != null)
        {
        }
        this._optEditCur = value;
        if (this._optEditCur != null)
        {
        }
      }
    }

    internal virtual RadioButton optEditV1
    {
      get
      {
        return this._optEditV1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optEditV1 != null)
        {
        }
        this._optEditV1 = value;
        if (this._optEditV1 != null)
        {
        }
      }
    }

    internal virtual RadioButton optEditV2
    {
      get
      {
        return this._optEditV2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optEditV2 != null)
        {
        }
        this._optEditV2 = value;
        if (this._optEditV2 != null)
        {
        }
      }
    }

    internal virtual RadioButton optSingle
    {
      get
      {
        return this._optSingle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optSingle != null)
        {
        }
        this._optSingle = value;
        if (this._optSingle != null)
        {
        }
      }
    }

    internal virtual RadioButton optUse23
    {
      get
      {
        return this._optUse23;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optUse23 != null)
        {
        }
        this._optUse23 = value;
        if (this._optUse23 != null)
        {
        }
      }
    }

    internal virtual RadioButton optUse24
    {
      get
      {
        return this._optUse24;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optUse24 != null)
        {
        }
        this._optUse24 = value;
        if (this._optUse24 != null)
        {
        }
      }
    }

    internal virtual NumericTextBox Port
    {
      get
      {
        return this._Port;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Port != null)
        {
        }
        this._Port = value;
        if (this._Port != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox Server
    {
      get
      {
        return this._Server;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Server != null)
        {
        }
        this._Server = value;
        if (this._Server != null)
        {
        }
      }
    }

    internal virtual TabItem Settings
    {
      get
      {
        return this._Settings;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Settings != null)
        {
        }
        this._Settings = value;
        if (this._Settings != null)
        {
        }
      }
    }

    internal virtual DataGridTableStyle Style
    {
      get
      {
        return this._Style;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Style != null)
        {
        }
        this._Style = value;
        if (this._Style != null)
        {
        }
      }
    }

    internal virtual DevComponents.DotNetBar.TabControl TabControl
    {
      get
      {
        return this._TabControl;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControl != null)
        {
        }
        this._TabControl = value;
        if (this._TabControl != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel1
    {
      get
      {
        return this._TabControlPanel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel1 != null)
        {
        }
        this._TabControlPanel1 = value;
        if (this._TabControlPanel1 != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel2
    {
      get
      {
        return this._TabControlPanel2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel2 != null)
        {
        }
        this._TabControlPanel2 = value;
        if (this._TabControlPanel2 != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel3
    {
      get
      {
        return this._TabControlPanel3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel3 != null)
        {
        }
        this._TabControlPanel3 = value;
        if (this._TabControlPanel3 != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel4
    {
      get
      {
        return this._TabControlPanel4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel4 != null)
        {
        }
        this._TabControlPanel4 = value;
        if (this._TabControlPanel4 != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel5
    {
      get
      {
        return this._TabControlPanel5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel5 != null)
        {
        }
        this._TabControlPanel5 = value;
        if (this._TabControlPanel5 != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel6
    {
      get
      {
        return this._TabControlPanel6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel6 != null)
        {
        }
        this._TabControlPanel6 = value;
        if (this._TabControlPanel6 != null)
        {
        }
      }
    }

    internal virtual DataGrid ToolGrid
    {
      get
      {
        return this._ToolGrid;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ToolGrid != null)
        {
        }
        this._ToolGrid = value;
        if (this._ToolGrid != null)
        {
        }
      }
    }

    internal virtual TabItem Tools
    {
      get
      {
        return this._Tools;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Tools != null)
        {
        }
        this._Tools = value;
        if (this._Tools != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.ToolTip ToolTip
    {
      get
      {
        return this._ToolTip;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ToolTip != null)
        {
        }
        this._ToolTip = value;
        if (this._ToolTip != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtDescription
    {
      get
      {
        return this._txtDescription;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtDescription != null)
        {
        }
        this._txtDescription = value;
        if (this._txtDescription != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtEnumSep
    {
      get
      {
        return this._txtEnumSep;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtEnumSep != null)
        {
        }
        this._txtEnumSep = value;
        if (this._txtEnumSep != null)
        {
        }
      }
    }

    internal virtual NumericUpDown txtFDigits
    {
      get
      {
        return this._txtFDigits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtFDigits != null)
        {
        }
        this._txtFDigits = value;
        if (this._txtFDigits != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtParameters
    {
      get
      {
        return this._txtParameters;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtParameters != null)
        {
        }
        this._txtParameters = value;
        if (this._txtParameters != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtPath
    {
      get
      {
        return this._txtPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPath != null)
        {
        }
        this._txtPath = value;
        if (this._txtPath != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtProxyPassword
    {
      get
      {
        return this._txtProxyPassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtProxyPassword != null)
        {
        }
        this._txtProxyPassword = value;
        if (this._txtProxyPassword != null)
        {
        }
      }
    }

    internal virtual NumericTextBox txtProxyPort
    {
      get
      {
        return this._txtProxyPort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtProxyPort != null)
        {
        }
        this._txtProxyPort = value;
        if (this._txtProxyPort != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtProxyServer
    {
      get
      {
        return this._txtProxyServer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtProxyServer != null)
        {
        }
        this._txtProxyServer = value;
        if (this._txtProxyServer != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtProxyUser
    {
      get
      {
        return this._txtProxyUser;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtProxyUser != null)
        {
        }
        this._txtProxyUser = value;
        if (this._txtProxyUser != null)
        {
        }
      }
    }

    internal virtual NumericUpDown txtStartNr
    {
      get
      {
        return this._txtStartNr;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtStartNr != null)
        {
        }
        this._txtStartNr = value;
        if (this._txtStartNr != null)
        {
        }
      }
    }

    internal virtual NumericUpDown txtTFDigits
    {
      get
      {
        return this._txtTFDigits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTFDigits != null)
        {
        }
        this._txtTFDigits = value;
        if (this._txtTFDigits != null)
        {
        }
      }
    }

    internal virtual NumericUpDown txtTTDigits
    {
      get
      {
        return this._txtTTDigits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTTDigits != null)
        {
        }
        this._txtTTDigits = value;
        if (this._txtTTDigits != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox Username
    {
      get
      {
        return this._Username;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Username != null)
        {
        }
        this._Username = value;
        if (this._Username != null)
        {
        }
      }
    }

    internal virtual TabItem Ver2
    {
      get
      {
        return this._Ver2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Ver2 != null)
        {
        }
        this._Ver2 = value;
        if (this._Ver2 != null)
        {
        }
      }
    }
  }
}