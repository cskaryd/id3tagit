using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmPreferences : Form
  {
    #region Designer

    private Button btnAdd;
    private Button btnBrowse;
    private Button btnDown;
    private Button btnRemove;
    private Button btnUp;
    private DataGridTextBoxColumn C1;
    private DataGridTextBoxColumn C2;
    private DataGridTextBoxColumn C3;
    private DataGridBoolColumn C4;
    private DataGridTextBoxColumn C5;
    private CheckBox chkAudioChecksumCalc;
    private CheckBox chkDefault;
    private CheckBox chkExplorerContext;
    private CheckBox chkIgnoreWrite;
    private CheckBox chkMouseRenaming;
    private CheckBox chkProxy;
    private CheckBox chkRestore;
    private CheckBox chkSaveOnExit;
    private CheckBox chkSingle;
    private CheckBox chkUnSync;
    private CheckBox chkWinXPThemes;
    private ComboBox cmbPlay;
    private ComboBox cmbShell;
    private ComboBox cmbV23Enc;
    private ComboBox cmbV24Enc;
    private ComboBox cmbYearFormat;
    private Button ColorChangedBack;
    private Button ColorChangedText;
    private Button ColorCompareBack;
    private Button ColorCompareText;
    private System.Windows.Forms.ColorDialog ColorDialog;
    private Button ColorDoubleBack;
    private Button ColorDoubleText;
    private ListView ColumnsList;
    private GroupBox frameDoubleClick;
    private GroupBox frameEnum;
    private GroupBox frameSelection;
    private GroupBox grpProxy;
    private Label Label1;
    private Label Label10;
    private Label Label2;
    private Label Label3;
    private Label Label4;
    private Label Label5;
    private Label Label6;
    private Label Label7;
    private Label Label8;
    private Label Label9;
    private Label lbl1;
    private Label lbl2;
    private Label lblDescript;
    private Label lblDescription;
    private Label lblDigits;
    private Label lblEnumSep;
    private Label lblFormat;
    private Label lblP;
    private Label lblParameters;
    private Label lblPath;
    private Label lblPlay;
    private Label lblPort;
    private Label lblServer;
    private Label lblTextEncInfo;
    private Label lblTracknumbers;
    private Label lblUsername;
    private Label lblV23;
    private Label lblV24;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    private RadioButton optAdd;
    private RadioButton optEditCur;
    private RadioButton optEditV1;
    private RadioButton optEditV2;
    private RadioButton optSingle;
    private RadioButton optUse23;
    private RadioButton optUse24;
    private MaskedTextBox Port;
    private System.Windows.Forms.TextBox Server;
    private DataGridTableStyle Style;
    private DataGrid ToolGrid;
    private System.Windows.Forms.ToolTip ToolTip;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.TextBox txtEnumSep;
    private NumericUpDown txtFDigits;
    private System.Windows.Forms.TextBox txtParameters;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.TextBox txtProxyPassword;
    private MaskedTextBox txtProxyPort;
    private System.Windows.Forms.TextBox txtProxyServer;
    private System.Windows.Forms.TextBox txtProxyUser;
    private NumericUpDown txtStartNr;
    private NumericUpDown txtTFDigits;
    private NumericUpDown txtTTDigits;
    private System.Windows.Forms.TextBox Username;
    private IContainer components;
    private Button btnCancel;
    private Button btnOK;
    private System.Windows.Forms.TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private TabPage tabPage6;
    private frmMain MainForm;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    //ResourceManager manager = new ResourceManager(typeof(frmPreferences));
    //this.C4.NullValue = RuntimeHelpers.GetObjectValue(manager.GetObject("C4.NullValue"));
    //this.Settings.Icon = (Icon)manager.GetObject("Settings.Icon");
    //this.Columns.Icon = (Icon)manager.GetObject("Columns.Icon");
    //this.Tools.Icon = (Icon)manager.GetObject("Tools.Icon");
    //this.Colors.Icon = (Icon)manager.GetObject("Colors.Icon");
    //this.FreeDB.Icon = (Icon)manager.GetObject("FreeDB.Icon");

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblPlay = new System.Windows.Forms.Label();
      this.cmbPlay = new System.Windows.Forms.ComboBox();
      this.chkExplorerContext = new System.Windows.Forms.CheckBox();
      this.frameEnum = new System.Windows.Forms.GroupBox();
      this.lbl2 = new System.Windows.Forms.Label();
      this.txtFDigits = new System.Windows.Forms.NumericUpDown();
      this.lblEnumSep = new System.Windows.Forms.Label();
      this.txtEnumSep = new System.Windows.Forms.TextBox();
      this.lbl1 = new System.Windows.Forms.Label();
      this.txtStartNr = new System.Windows.Forms.NumericUpDown();
      this.chkMouseRenaming = new System.Windows.Forms.CheckBox();
      this.chkRestore = new System.Windows.Forms.CheckBox();
      this.lblTracknumbers = new System.Windows.Forms.Label();
      this.txtTFDigits = new System.Windows.Forms.NumericUpDown();
      this.frameSelection = new System.Windows.Forms.GroupBox();
      this.optAdd = new System.Windows.Forms.RadioButton();
      this.optSingle = new System.Windows.Forms.RadioButton();
      this.chkSaveOnExit = new System.Windows.Forms.CheckBox();
      this.frameDoubleClick = new System.Windows.Forms.GroupBox();
      this.optEditCur = new System.Windows.Forms.RadioButton();
      this.optEditV1 = new System.Windows.Forms.RadioButton();
      this.optEditV2 = new System.Windows.Forms.RadioButton();
      this.chkIgnoreWrite = new System.Windows.Forms.CheckBox();
      this.lblDescript = new System.Windows.Forms.Label();
      this.ColumnsList = new System.Windows.Forms.ListView();
      this.btnUp = new System.Windows.Forms.Button();
      this.btnDown = new System.Windows.Forms.Button();
      this.lblTextEncInfo = new System.Windows.Forms.Label();
      this.lblFormat = new System.Windows.Forms.Label();
      this.cmbYearFormat = new System.Windows.Forms.ComboBox();
      this.lblDigits = new System.Windows.Forms.Label();
      this.txtTTDigits = new System.Windows.Forms.NumericUpDown();
      this.lblV24 = new System.Windows.Forms.Label();
      this.lblV23 = new System.Windows.Forms.Label();
      this.cmbV24Enc = new System.Windows.Forms.ComboBox();
      this.cmbV23Enc = new System.Windows.Forms.ComboBox();
      this.chkSingle = new System.Windows.Forms.CheckBox();
      this.chkUnSync = new System.Windows.Forms.CheckBox();
      this.optUse24 = new System.Windows.Forms.RadioButton();
      this.optUse23 = new System.Windows.Forms.RadioButton();
      this.Port = new System.Windows.Forms.MaskedTextBox();
      this.grpProxy = new System.Windows.Forms.GroupBox();
      this.txtProxyPort = new System.Windows.Forms.MaskedTextBox();
      this.txtProxyPassword = new System.Windows.Forms.TextBox();
      this.Label10 = new System.Windows.Forms.Label();
      this.txtProxyUser = new System.Windows.Forms.TextBox();
      this.Label9 = new System.Windows.Forms.Label();
      this.Label8 = new System.Windows.Forms.Label();
      this.txtProxyServer = new System.Windows.Forms.TextBox();
      this.Label7 = new System.Windows.Forms.Label();
      this.chkProxy = new System.Windows.Forms.CheckBox();
      this.lblUsername = new System.Windows.Forms.Label();
      this.Username = new System.Windows.Forms.TextBox();
      this.lblPort = new System.Windows.Forms.Label();
      this.lblServer = new System.Windows.Forms.Label();
      this.Server = new System.Windows.Forms.TextBox();
      this.chkWinXPThemes = new System.Windows.Forms.CheckBox();
      this.Label5 = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.ColorCompareText = new System.Windows.Forms.Button();
      this.ColorCompareBack = new System.Windows.Forms.Button();
      this.Label4 = new System.Windows.Forms.Label();
      this.Label3 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.ColorChangedBack = new System.Windows.Forms.Button();
      this.ColorDoubleText = new System.Windows.Forms.Button();
      this.ColorDoubleBack = new System.Windows.Forms.Button();
      this.ColorChangedText = new System.Windows.Forms.Button();
      this.ToolGrid = new System.Windows.Forms.DataGrid();
      this.Style = new System.Windows.Forms.DataGridTableStyle();
      this.C1 = new System.Windows.Forms.DataGridTextBoxColumn();
      this.C2 = new System.Windows.Forms.DataGridTextBoxColumn();
      this.C3 = new System.Windows.Forms.DataGridTextBoxColumn();
      this.C4 = new System.Windows.Forms.DataGridBoolColumn();
      this.C5 = new System.Windows.Forms.DataGridTextBoxColumn();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.lblP = new System.Windows.Forms.Label();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.cmbShell = new System.Windows.Forms.ComboBox();
      this.txtParameters = new System.Windows.Forms.TextBox();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.chkDefault = new System.Windows.Forms.CheckBox();
      this.lblParameters = new System.Windows.Forms.Label();
      this.lblPath = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.ColorDialog = new System.Windows.Forms.ColorDialog();
      this.chkAudioChecksumCalc = new System.Windows.Forms.CheckBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.tabPage6 = new System.Windows.Forms.TabPage();
      this.frameEnum.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtFDigits)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartNr)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTFDigits)).BeginInit();
      this.frameSelection.SuspendLayout();
      this.frameDoubleClick.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtTTDigits)).BeginInit();
      this.grpProxy.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ToolGrid)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.tabPage6.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblPlay
      // 
      this.lblPlay.BackColor = System.Drawing.SystemColors.Control;
      this.lblPlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPlay.Location = new System.Drawing.Point(14, 301);
      this.lblPlay.Name = "lblPlay";
      this.lblPlay.Size = new System.Drawing.Size(272, 16);
      this.lblPlay.TabIndex = 18;
      this.lblPlay.Text = "Shell command for PLA&Y function:";
      // 
      // cmbPlay
      // 
      this.cmbPlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbPlay.ItemHeight = 13;
      this.cmbPlay.Location = new System.Drawing.Point(286, 299);
      this.cmbPlay.Name = "cmbPlay";
      this.cmbPlay.Size = new System.Drawing.Size(248, 21);
      this.cmbPlay.TabIndex = 19;
      // 
      // chkExplorerContext
      // 
      this.chkExplorerContext.BackColor = System.Drawing.SystemColors.Control;
      this.chkExplorerContext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkExplorerContext.Location = new System.Drawing.Point(14, 247);
      this.chkExplorerContext.Name = "chkExplorerContext";
      this.chkExplorerContext.Size = new System.Drawing.Size(520, 16);
      this.chkExplorerContext.TabIndex = 16;
      this.chkExplorerContext.Text = "Show \"ID3-TagIT\" in the folder context menu of the Windows &Explorer";
      this.chkExplorerContext.UseVisualStyleBackColor = false;
      // 
      // frameEnum
      // 
      this.frameEnum.BackColor = System.Drawing.SystemColors.Control;
      this.frameEnum.Controls.Add(this.lbl2);
      this.frameEnum.Controls.Add(this.txtFDigits);
      this.frameEnum.Controls.Add(this.lblEnumSep);
      this.frameEnum.Controls.Add(this.txtEnumSep);
      this.frameEnum.Controls.Add(this.lbl1);
      this.frameEnum.Controls.Add(this.txtStartNr);
      this.frameEnum.Location = new System.Drawing.Point(222, 83);
      this.frameEnum.Name = "frameEnum";
      this.frameEnum.Size = new System.Drawing.Size(312, 104);
      this.frameEnum.TabIndex = 10;
      this.frameEnum.TabStop = false;
      this.frameEnum.Text = "Enumerating mode";
      // 
      // lbl2
      // 
      this.lbl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lbl2.Location = new System.Drawing.Point(8, 72);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(224, 16);
      this.lbl2.TabIndex = 7;
      this.lbl2.Text = "Number of digits of filename enumeration:";
      // 
      // txtFDigits
      // 
      this.txtFDigits.Location = new System.Drawing.Point(239, 70);
      this.txtFDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtFDigits.Name = "txtFDigits";
      this.txtFDigits.Size = new System.Drawing.Size(64, 20);
      this.txtFDigits.TabIndex = 8;
      this.txtFDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lblEnumSep
      // 
      this.lblEnumSep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblEnumSep.Location = new System.Drawing.Point(8, 48);
      this.lblEnumSep.Name = "lblEnumSep";
      this.lblEnumSep.Size = new System.Drawing.Size(224, 16);
      this.lblEnumSep.TabIndex = 5;
      this.lblEnumSep.Text = "Separator:";
      // 
      // txtEnumSep
      // 
      this.txtEnumSep.Location = new System.Drawing.Point(239, 46);
      this.txtEnumSep.Name = "txtEnumSep";
      this.txtEnumSep.Size = new System.Drawing.Size(64, 20);
      this.txtEnumSep.TabIndex = 6;
      this.txtEnumSep.Text = " - ";
      // 
      // lbl1
      // 
      this.lbl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lbl1.Location = new System.Drawing.Point(8, 24);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(224, 16);
      this.lbl1.TabIndex = 0;
      this.lbl1.Text = "Number to start with:";
      // 
      // txtStartNr
      // 
      this.txtStartNr.Location = new System.Drawing.Point(239, 22);
      this.txtStartNr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.txtStartNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtStartNr.Name = "txtStartNr";
      this.txtStartNr.Size = new System.Drawing.Size(64, 20);
      this.txtStartNr.TabIndex = 1;
      this.txtStartNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // chkMouseRenaming
      // 
      this.chkMouseRenaming.BackColor = System.Drawing.SystemColors.Control;
      this.chkMouseRenaming.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkMouseRenaming.Location = new System.Drawing.Point(14, 199);
      this.chkMouseRenaming.Name = "chkMouseRenaming";
      this.chkMouseRenaming.Size = new System.Drawing.Size(248, 16);
      this.chkMouseRenaming.TabIndex = 12;
      this.chkMouseRenaming.Text = "Enable &Renaming by mouse click";
      this.chkMouseRenaming.UseVisualStyleBackColor = false;
      // 
      // chkRestore
      // 
      this.chkRestore.BackColor = System.Drawing.SystemColors.Control;
      this.chkRestore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkRestore.Location = new System.Drawing.Point(14, 223);
      this.chkRestore.Name = "chkRestore";
      this.chkRestore.Size = new System.Drawing.Size(248, 16);
      this.chkRestore.TabIndex = 14;
      this.chkRestore.Text = "&Restore date of file after tagging";
      this.chkRestore.UseVisualStyleBackColor = false;
      // 
      // lblTracknumbers
      // 
      this.lblTracknumbers.BackColor = System.Drawing.SystemColors.Control;
      this.lblTracknumbers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTracknumbers.Location = new System.Drawing.Point(14, 333);
      this.lblTracknumbers.Name = "lblTracknumbers";
      this.lblTracknumbers.Size = new System.Drawing.Size(272, 16);
      this.lblTracknumbers.TabIndex = 20;
      this.lblTracknumbers.Text = "Number of &digits of track numbers in filenames:";
      // 
      // txtTFDigits
      // 
      this.txtTFDigits.Location = new System.Drawing.Point(286, 331);
      this.txtTFDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtTFDigits.Name = "txtTFDigits";
      this.txtTFDigits.Size = new System.Drawing.Size(64, 20);
      this.txtTFDigits.TabIndex = 21;
      this.txtTFDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // frameSelection
      // 
      this.frameSelection.BackColor = System.Drawing.SystemColors.Control;
      this.frameSelection.Controls.Add(this.optAdd);
      this.frameSelection.Controls.Add(this.optSingle);
      this.frameSelection.Location = new System.Drawing.Point(6, 83);
      this.frameSelection.Name = "frameSelection";
      this.frameSelection.Size = new System.Drawing.Size(200, 104);
      this.frameSelection.TabIndex = 5;
      this.frameSelection.TabStop = false;
      this.frameSelection.Text = "Selection mode";
      // 
      // optAdd
      // 
      this.optAdd.BackColor = System.Drawing.Color.Transparent;
      this.optAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAdd.Location = new System.Drawing.Point(16, 48);
      this.optAdd.Name = "optAdd";
      this.optAdd.Size = new System.Drawing.Size(176, 16);
      this.optAdd.TabIndex = 1;
      this.optAdd.Text = "&Add to selection";
      this.optAdd.UseVisualStyleBackColor = false;
      // 
      // optSingle
      // 
      this.optSingle.BackColor = System.Drawing.Color.Transparent;
      this.optSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optSingle.Location = new System.Drawing.Point(16, 24);
      this.optSingle.Name = "optSingle";
      this.optSingle.Size = new System.Drawing.Size(176, 16);
      this.optSingle.TabIndex = 3;
      this.optSingle.Text = "&New selection";
      this.optSingle.UseVisualStyleBackColor = false;
      // 
      // chkSaveOnExit
      // 
      this.chkSaveOnExit.BackColor = System.Drawing.SystemColors.Control;
      this.chkSaveOnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkSaveOnExit.Location = new System.Drawing.Point(278, 223);
      this.chkSaveOnExit.Name = "chkSaveOnExit";
      this.chkSaveOnExit.Size = new System.Drawing.Size(256, 16);
      this.chkSaveOnExit.TabIndex = 15;
      this.chkSaveOnExit.Text = "&Save folder on exit";
      this.chkSaveOnExit.UseVisualStyleBackColor = false;
      // 
      // frameDoubleClick
      // 
      this.frameDoubleClick.BackColor = System.Drawing.SystemColors.Control;
      this.frameDoubleClick.Controls.Add(this.optEditCur);
      this.frameDoubleClick.Controls.Add(this.optEditV1);
      this.frameDoubleClick.Controls.Add(this.optEditV2);
      this.frameDoubleClick.Location = new System.Drawing.Point(6, 3);
      this.frameDoubleClick.Name = "frameDoubleClick";
      this.frameDoubleClick.Size = new System.Drawing.Size(528, 72);
      this.frameDoubleClick.TabIndex = 0;
      this.frameDoubleClick.TabStop = false;
      this.frameDoubleClick.Text = " Double click open command ";
      // 
      // optEditCur
      // 
      this.optEditCur.BackColor = System.Drawing.Color.Transparent;
      this.optEditCur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optEditCur.Location = new System.Drawing.Point(16, 48);
      this.optEditCur.Name = "optEditCur";
      this.optEditCur.Size = new System.Drawing.Size(496, 16);
      this.optEditCur.TabIndex = 2;
      this.optEditCur.Text = "Open \'Edit TAG Ver. &X\' dialog corresponding to current view";
      this.optEditCur.UseVisualStyleBackColor = false;
      // 
      // optEditV1
      // 
      this.optEditV1.BackColor = System.Drawing.Color.Transparent;
      this.optEditV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optEditV1.Location = new System.Drawing.Point(16, 24);
      this.optEditV1.Name = "optEditV1";
      this.optEditV1.Size = new System.Drawing.Size(240, 16);
      this.optEditV1.TabIndex = 0;
      this.optEditV1.Text = "Open \'Edit TAG Ver. &1\' dialog";
      this.optEditV1.UseVisualStyleBackColor = false;
      // 
      // optEditV2
      // 
      this.optEditV2.BackColor = System.Drawing.Color.Transparent;
      this.optEditV2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optEditV2.Location = new System.Drawing.Point(272, 24);
      this.optEditV2.Name = "optEditV2";
      this.optEditV2.Size = new System.Drawing.Size(240, 16);
      this.optEditV2.TabIndex = 1;
      this.optEditV2.Text = "Open \'Edit TAG Ver. &2\' dialog";
      this.optEditV2.UseVisualStyleBackColor = false;
      // 
      // chkIgnoreWrite
      // 
      this.chkIgnoreWrite.BackColor = System.Drawing.SystemColors.Control;
      this.chkIgnoreWrite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkIgnoreWrite.Location = new System.Drawing.Point(278, 199);
      this.chkIgnoreWrite.Name = "chkIgnoreWrite";
      this.chkIgnoreWrite.Size = new System.Drawing.Size(256, 16);
      this.chkIgnoreWrite.TabIndex = 13;
      this.chkIgnoreWrite.Text = "&Ignore write protection";
      this.chkIgnoreWrite.UseVisualStyleBackColor = false;
      // 
      // lblDescript
      // 
      this.lblDescript.BackColor = System.Drawing.Color.Transparent;
      this.lblDescript.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblDescript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDescript.Location = new System.Drawing.Point(278, 270);
      this.lblDescript.Name = "lblDescript";
      this.lblDescript.Size = new System.Drawing.Size(256, 88);
      this.lblDescript.TabIndex = 3;
      this.lblDescript.Text = "Only checked columns will be displayed . You can reorder the columns by moving th" +
    "em  up or down. The filename column will always be visible.";
      this.lblDescript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ColumnsList
      // 
      this.ColumnsList.CheckBoxes = true;
      this.ColumnsList.FullRowSelect = true;
      this.ColumnsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      this.ColumnsList.Location = new System.Drawing.Point(6, 6);
      this.ColumnsList.MultiSelect = false;
      this.ColumnsList.Name = "ColumnsList";
      this.ColumnsList.Size = new System.Drawing.Size(256, 352);
      this.ColumnsList.TabIndex = 2;
      this.ColumnsList.UseCompatibleStateImageBehavior = false;
      this.ColumnsList.View = System.Windows.Forms.View.Details;
      this.ColumnsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ColumnsList_ItemCheck);
      // 
      // btnUp
      // 
      this.btnUp.BackColor = System.Drawing.SystemColors.Control;
      this.btnUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnUp.Location = new System.Drawing.Point(278, 158);
      this.btnUp.Name = "btnUp";
      this.btnUp.Size = new System.Drawing.Size(128, 24);
      this.btnUp.TabIndex = 1;
      this.btnUp.Text = "Column &up";
      this.btnUp.UseVisualStyleBackColor = false;
      this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
      // 
      // btnDown
      // 
      this.btnDown.BackColor = System.Drawing.SystemColors.Control;
      this.btnDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnDown.Location = new System.Drawing.Point(278, 190);
      this.btnDown.Name = "btnDown";
      this.btnDown.Size = new System.Drawing.Size(128, 24);
      this.btnDown.TabIndex = 1;
      this.btnDown.Text = "Column &down";
      this.btnDown.UseVisualStyleBackColor = false;
      this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
      // 
      // lblTextEncInfo
      // 
      this.lblTextEncInfo.BackColor = System.Drawing.Color.Transparent;
      this.lblTextEncInfo.Location = new System.Drawing.Point(16, 261);
      this.lblTextEncInfo.Name = "lblTextEncInfo";
      this.lblTextEncInfo.Size = new System.Drawing.Size(528, 48);
      this.lblTextEncInfo.TabIndex = 16;
      this.lblTextEncInfo.Text = "NOTE: The text encoding will only be used for new TAG Ver. 2 frames. Already pres" +
    "ent frames will not be changed when the TAG is saved.";
      // 
      // lblFormat
      // 
      this.lblFormat.BackColor = System.Drawing.Color.Transparent;
      this.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblFormat.Location = new System.Drawing.Point(16, 136);
      this.lblFormat.Name = "lblFormat";
      this.lblFormat.Size = new System.Drawing.Size(200, 16);
      this.lblFormat.TabIndex = 8;
      this.lblFormat.Text = "&Format of year entry:";
      // 
      // cmbYearFormat
      // 
      this.cmbYearFormat.ItemHeight = 13;
      this.cmbYearFormat.Items.AddRange(new object[] {
            "YYYY",
            "YYYY-MM",
            "YYYY-MM-DD"});
      this.cmbYearFormat.Location = new System.Drawing.Point(224, 134);
      this.cmbYearFormat.Name = "cmbYearFormat";
      this.cmbYearFormat.Size = new System.Drawing.Size(320, 21);
      this.cmbYearFormat.TabIndex = 9;
      // 
      // lblDigits
      // 
      this.lblDigits.BackColor = System.Drawing.Color.Transparent;
      this.lblDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDigits.Location = new System.Drawing.Point(16, 173);
      this.lblDigits.Name = "lblDigits";
      this.lblDigits.Size = new System.Drawing.Size(296, 16);
      this.lblDigits.TabIndex = 10;
      this.lblDigits.Text = "Number of digits of track numbers in Ver. 2 TAGs:";
      // 
      // txtTTDigits
      // 
      this.txtTTDigits.Location = new System.Drawing.Point(320, 171);
      this.txtTTDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtTTDigits.Name = "txtTTDigits";
      this.txtTTDigits.Size = new System.Drawing.Size(64, 20);
      this.txtTTDigits.TabIndex = 11;
      this.txtTTDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lblV24
      // 
      this.lblV24.BackColor = System.Drawing.Color.Transparent;
      this.lblV24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblV24.Location = new System.Drawing.Point(16, 232);
      this.lblV24.Name = "lblV24";
      this.lblV24.Size = new System.Drawing.Size(200, 16);
      this.lblV24.TabIndex = 14;
      this.lblV24.Text = "Text encoding for TAG Ver. 2.4:";
      // 
      // lblV23
      // 
      this.lblV23.BackColor = System.Drawing.Color.Transparent;
      this.lblV23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblV23.Location = new System.Drawing.Point(16, 208);
      this.lblV23.Name = "lblV23";
      this.lblV23.Size = new System.Drawing.Size(200, 16);
      this.lblV23.TabIndex = 12;
      this.lblV23.Text = "Text encoding for TAG Ver. 2.3:";
      // 
      // cmbV24Enc
      // 
      this.cmbV24Enc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbV24Enc.ItemHeight = 13;
      this.cmbV24Enc.Items.AddRange(new object[] {
            "ANSI-Encoding (Default)",
            "UTF-16 (LE) Encoding with BOM (Default for Unicode Encoding)",
            "UTF-16 (BE) Encoding without BOM",
            "UTF-8 Encoding"});
      this.cmbV24Enc.Location = new System.Drawing.Point(224, 230);
      this.cmbV24Enc.Name = "cmbV24Enc";
      this.cmbV24Enc.Size = new System.Drawing.Size(320, 21);
      this.cmbV24Enc.TabIndex = 15;
      // 
      // cmbV23Enc
      // 
      this.cmbV23Enc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbV23Enc.ItemHeight = 13;
      this.cmbV23Enc.Items.AddRange(new object[] {
            "ANSI-Encoding (Default)",
            "UTF-16 (LE) Encoding with BOM (Default for Unicode Encoding)"});
      this.cmbV23Enc.Location = new System.Drawing.Point(224, 206);
      this.cmbV23Enc.Name = "cmbV23Enc";
      this.cmbV23Enc.Size = new System.Drawing.Size(320, 21);
      this.cmbV23Enc.TabIndex = 13;
      // 
      // chkSingle
      // 
      this.chkSingle.BackColor = System.Drawing.Color.Transparent;
      this.chkSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkSingle.Location = new System.Drawing.Point(16, 95);
      this.chkSingle.Name = "chkSingle";
      this.chkSingle.Size = new System.Drawing.Size(240, 16);
      this.chkSingle.TabIndex = 7;
      this.chkSingle.Text = "Allow onl&y one genre / comment";
      this.chkSingle.UseVisualStyleBackColor = false;
      // 
      // chkUnSync
      // 
      this.chkUnSync.BackColor = System.Drawing.Color.Transparent;
      this.chkUnSync.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkUnSync.Location = new System.Drawing.Point(16, 71);
      this.chkUnSync.Name = "chkUnSync";
      this.chkUnSync.Size = new System.Drawing.Size(240, 16);
      this.chkUnSync.TabIndex = 6;
      this.chkUnSync.Text = "Write &unsync. version 2 TAGs";
      this.chkUnSync.UseVisualStyleBackColor = false;
      // 
      // optUse24
      // 
      this.optUse24.BackColor = System.Drawing.Color.Transparent;
      this.optUse24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optUse24.Location = new System.Drawing.Point(16, 38);
      this.optUse24.Name = "optUse24";
      this.optUse24.Size = new System.Drawing.Size(464, 16);
      this.optUse24.TabIndex = 5;
      this.optUse24.Text = "Use Ver. 2.&4 for new TAGs of TAG Ver. 2";
      this.optUse24.UseVisualStyleBackColor = false;
      // 
      // optUse23
      // 
      this.optUse23.BackColor = System.Drawing.Color.Transparent;
      this.optUse23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optUse23.Location = new System.Drawing.Point(16, 14);
      this.optUse23.Name = "optUse23";
      this.optUse23.Size = new System.Drawing.Size(464, 16);
      this.optUse23.TabIndex = 4;
      this.optUse23.Text = "Use Ver. 2.&3 for new TAGs of TAG Ver. 2";
      this.optUse23.UseVisualStyleBackColor = false;
      // 
      // Port
      // 
      this.Port.Location = new System.Drawing.Point(102, 30);
      this.Port.Mask = "00000";
      this.Port.Name = "Port";
      this.Port.Size = new System.Drawing.Size(100, 20);
      this.Port.TabIndex = 9;
      this.Port.Text = "8880";
      this.Port.ValidatingType = typeof(int);
      // 
      // grpProxy
      // 
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
      this.grpProxy.Location = new System.Drawing.Point(6, 118);
      this.grpProxy.Name = "grpProxy";
      this.grpProxy.Size = new System.Drawing.Size(527, 128);
      this.grpProxy.TabIndex = 13;
      this.grpProxy.TabStop = false;
      this.grpProxy.Text = "Proxy settings ";
      // 
      // txtProxyPort
      // 
      this.txtProxyPort.Location = new System.Drawing.Point(128, 46);
      this.txtProxyPort.Mask = "00000";
      this.txtProxyPort.Name = "txtProxyPort";
      this.txtProxyPort.Size = new System.Drawing.Size(100, 20);
      this.txtProxyPort.TabIndex = 3;
      this.txtProxyPort.ValidatingType = typeof(int);
      // 
      // txtProxyPassword
      // 
      this.txtProxyPassword.Location = new System.Drawing.Point(128, 94);
      this.txtProxyPassword.Name = "txtProxyPassword";
      this.txtProxyPassword.Size = new System.Drawing.Size(392, 20);
      this.txtProxyPassword.TabIndex = 7;
      // 
      // Label10
      // 
      this.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label10.Location = new System.Drawing.Point(16, 96);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(104, 16);
      this.Label10.TabIndex = 6;
      this.Label10.Text = "Pa&ssword:";
      // 
      // txtProxyUser
      // 
      this.txtProxyUser.Location = new System.Drawing.Point(128, 70);
      this.txtProxyUser.Name = "txtProxyUser";
      this.txtProxyUser.Size = new System.Drawing.Size(392, 20);
      this.txtProxyUser.TabIndex = 5;
      // 
      // Label9
      // 
      this.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label9.Location = new System.Drawing.Point(16, 72);
      this.Label9.Name = "Label9";
      this.Label9.Size = new System.Drawing.Size(104, 16);
      this.Label9.TabIndex = 4;
      this.Label9.Text = "User&name:";
      // 
      // Label8
      // 
      this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label8.Location = new System.Drawing.Point(16, 48);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(104, 16);
      this.Label8.TabIndex = 2;
      this.Label8.Text = "P&ort:";
      // 
      // txtProxyServer
      // 
      this.txtProxyServer.Location = new System.Drawing.Point(128, 22);
      this.txtProxyServer.Name = "txtProxyServer";
      this.txtProxyServer.Size = new System.Drawing.Size(392, 20);
      this.txtProxyServer.TabIndex = 1;
      // 
      // Label7
      // 
      this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label7.Location = new System.Drawing.Point(16, 24);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(104, 16);
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Pro&xy Server:";
      // 
      // chkProxy
      // 
      this.chkProxy.BackColor = System.Drawing.Color.Transparent;
      this.chkProxy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkProxy.Location = new System.Drawing.Point(5, 93);
      this.chkProxy.Name = "chkProxy";
      this.chkProxy.Size = new System.Drawing.Size(176, 16);
      this.chkProxy.TabIndex = 12;
      this.chkProxy.Text = "Use Proxy server";
      this.chkProxy.UseVisualStyleBackColor = false;
      this.chkProxy.CheckedChanged += new System.EventHandler(this.chkProxy_CheckedChanged);
      // 
      // lblUsername
      // 
      this.lblUsername.BackColor = System.Drawing.Color.Transparent;
      this.lblUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblUsername.Location = new System.Drawing.Point(6, 56);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(96, 16);
      this.lblUsername.TabIndex = 10;
      this.lblUsername.Text = "&Username:";
      // 
      // Username
      // 
      this.Username.Location = new System.Drawing.Point(102, 54);
      this.Username.Name = "Username";
      this.Username.Size = new System.Drawing.Size(431, 20);
      this.Username.TabIndex = 11;
      // 
      // lblPort
      // 
      this.lblPort.BackColor = System.Drawing.Color.Transparent;
      this.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPort.Location = new System.Drawing.Point(6, 32);
      this.lblPort.Name = "lblPort";
      this.lblPort.Size = new System.Drawing.Size(96, 16);
      this.lblPort.TabIndex = 8;
      this.lblPort.Text = "&Port:";
      // 
      // lblServer
      // 
      this.lblServer.BackColor = System.Drawing.Color.Transparent;
      this.lblServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblServer.Location = new System.Drawing.Point(6, 8);
      this.lblServer.Name = "lblServer";
      this.lblServer.Size = new System.Drawing.Size(96, 16);
      this.lblServer.TabIndex = 6;
      this.lblServer.Text = "&Server:";
      // 
      // Server
      // 
      this.Server.Location = new System.Drawing.Point(102, 6);
      this.Server.Name = "Server";
      this.Server.Size = new System.Drawing.Size(431, 20);
      this.Server.TabIndex = 7;
      // 
      // chkWinXPThemes
      // 
      this.chkWinXPThemes.BackColor = System.Drawing.Color.Transparent;
      this.chkWinXPThemes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkWinXPThemes.Location = new System.Drawing.Point(14, 351);
      this.chkWinXPThemes.Name = "chkWinXPThemes";
      this.chkWinXPThemes.Size = new System.Drawing.Size(480, 16);
      this.chkWinXPThemes.TabIndex = 12;
      this.chkWinXPThemes.Text = "Use Windows XP menu style";
      this.chkWinXPThemes.UseVisualStyleBackColor = false;
      // 
      // Label5
      // 
      this.Label5.BackColor = System.Drawing.Color.Transparent;
      this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label5.Location = new System.Drawing.Point(6, 179);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(336, 16);
      this.Label5.TabIndex = 11;
      this.Label5.Text = "Text color of mismatches Filename<->TAG  files:";
      // 
      // Label6
      // 
      this.Label6.BackColor = System.Drawing.Color.Transparent;
      this.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label6.Location = new System.Drawing.Point(6, 147);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(336, 16);
      this.Label6.TabIndex = 10;
      this.Label6.Text = "Background color of mismatches Filename<->TAG  files:";
      // 
      // ColorCompareText
      // 
      this.ColorCompareText.BackColor = System.Drawing.SystemColors.Control;
      this.ColorCompareText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ColorCompareText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ColorCompareText.Location = new System.Drawing.Point(366, 175);
      this.ColorCompareText.Name = "ColorCompareText";
      this.ColorCompareText.Size = new System.Drawing.Size(24, 24);
      this.ColorCompareText.TabIndex = 9;
      this.ColorCompareText.UseVisualStyleBackColor = false;
      this.ColorCompareText.Click += new System.EventHandler(this.ColorChangedBack_Click);
      // 
      // ColorCompareBack
      // 
      this.ColorCompareBack.BackColor = System.Drawing.SystemColors.Control;
      this.ColorCompareBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ColorCompareBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ColorCompareBack.Location = new System.Drawing.Point(366, 143);
      this.ColorCompareBack.Name = "ColorCompareBack";
      this.ColorCompareBack.Size = new System.Drawing.Size(24, 24);
      this.ColorCompareBack.TabIndex = 8;
      this.ColorCompareBack.UseVisualStyleBackColor = false;
      this.ColorCompareBack.Click += new System.EventHandler(this.ColorChangedBack_Click);
      // 
      // Label4
      // 
      this.Label4.BackColor = System.Drawing.Color.Transparent;
      this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label4.Location = new System.Drawing.Point(6, 115);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(336, 16);
      this.Label4.TabIndex = 7;
      this.Label4.Text = "Text color of duplicate files:";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.Transparent;
      this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label3.Location = new System.Drawing.Point(6, 83);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(336, 16);
      this.Label3.TabIndex = 6;
      this.Label3.Text = "Background color of duplicate files:";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.Transparent;
      this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label2.Location = new System.Drawing.Point(6, 51);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(336, 16);
      this.Label2.TabIndex = 5;
      this.Label2.Text = "Text color of changed files:";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label1.Location = new System.Drawing.Point(6, 19);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(336, 16);
      this.Label1.TabIndex = 4;
      this.Label1.Text = "Background color of changed files:";
      // 
      // ColorChangedBack
      // 
      this.ColorChangedBack.BackColor = System.Drawing.SystemColors.Control;
      this.ColorChangedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ColorChangedBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ColorChangedBack.Location = new System.Drawing.Point(366, 15);
      this.ColorChangedBack.Name = "ColorChangedBack";
      this.ColorChangedBack.Size = new System.Drawing.Size(24, 24);
      this.ColorChangedBack.TabIndex = 0;
      this.ColorChangedBack.UseVisualStyleBackColor = false;
      this.ColorChangedBack.Click += new System.EventHandler(this.ColorChangedBack_Click);
      // 
      // ColorDoubleText
      // 
      this.ColorDoubleText.BackColor = System.Drawing.SystemColors.Control;
      this.ColorDoubleText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ColorDoubleText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ColorDoubleText.Location = new System.Drawing.Point(366, 111);
      this.ColorDoubleText.Name = "ColorDoubleText";
      this.ColorDoubleText.Size = new System.Drawing.Size(24, 24);
      this.ColorDoubleText.TabIndex = 3;
      this.ColorDoubleText.UseVisualStyleBackColor = false;
      this.ColorDoubleText.Click += new System.EventHandler(this.ColorChangedBack_Click);
      // 
      // ColorDoubleBack
      // 
      this.ColorDoubleBack.BackColor = System.Drawing.SystemColors.Control;
      this.ColorDoubleBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ColorDoubleBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ColorDoubleBack.Location = new System.Drawing.Point(366, 79);
      this.ColorDoubleBack.Name = "ColorDoubleBack";
      this.ColorDoubleBack.Size = new System.Drawing.Size(24, 24);
      this.ColorDoubleBack.TabIndex = 2;
      this.ColorDoubleBack.UseVisualStyleBackColor = false;
      this.ColorDoubleBack.Click += new System.EventHandler(this.ColorChangedBack_Click);
      // 
      // ColorChangedText
      // 
      this.ColorChangedText.BackColor = System.Drawing.SystemColors.Control;
      this.ColorChangedText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ColorChangedText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ColorChangedText.Location = new System.Drawing.Point(366, 47);
      this.ColorChangedText.Name = "ColorChangedText";
      this.ColorChangedText.Size = new System.Drawing.Size(24, 24);
      this.ColorChangedText.TabIndex = 1;
      this.ColorChangedText.UseVisualStyleBackColor = false;
      this.ColorChangedText.Click += new System.EventHandler(this.ColorChangedBack_Click);
      // 
      // ToolGrid
      // 
      this.ToolGrid.AllowNavigation = false;
      this.ToolGrid.CaptionVisible = false;
      this.ToolGrid.DataMember = "";
      this.ToolGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.ToolGrid.Location = new System.Drawing.Point(6, 182);
      this.ToolGrid.Name = "ToolGrid";
      this.ToolGrid.ParentRowsVisible = false;
      this.ToolGrid.ReadOnly = true;
      this.ToolGrid.RowHeadersVisible = false;
      this.ToolGrid.Size = new System.Drawing.Size(528, 184);
      this.ToolGrid.TabIndex = 11;
      this.ToolGrid.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.Style});
      // 
      // Style
      // 
      this.Style.DataGrid = this.ToolGrid;
      this.Style.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.C5});
      this.Style.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      // 
      // C1
      // 
      this.C1.Format = "";
      this.C1.FormatInfo = null;
      this.C1.HeaderText = "Tool description";
      this.C1.MappingName = "ToolDescription";
      this.C1.Width = 75;
      // 
      // C2
      // 
      this.C2.Format = "";
      this.C2.FormatInfo = null;
      this.C2.HeaderText = "Tool path";
      this.C2.MappingName = "ToolPath";
      this.C2.Width = 75;
      // 
      // C3
      // 
      this.C3.Format = "";
      this.C3.FormatInfo = null;
      this.C3.HeaderText = "Tool parameters";
      this.C3.MappingName = "ToolParameter";
      this.C3.Width = 85;
      // 
      // C4
      // 
      this.C4.HeaderText = "Default Player";
      this.C4.MappingName = "DefaultPlayer";
      this.C4.Width = 75;
      // 
      // C5
      // 
      this.C5.Format = "";
      this.C5.FormatInfo = null;
      this.C5.HeaderText = "Shell command";
      this.C5.MappingName = "ShellCommand";
      this.C5.Width = 85;
      // 
      // btnRemove
      // 
      this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
      this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemove.Location = new System.Drawing.Point(278, 150);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(256, 24);
      this.btnRemove.TabIndex = 10;
      this.btnRemove.Text = "Remove tool from list";
      this.btnRemove.UseVisualStyleBackColor = false;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(6, 150);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(256, 24);
      this.btnAdd.TabIndex = 9;
      this.btnAdd.Text = "Add tool to list";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // lblP
      // 
      this.lblP.BackColor = System.Drawing.Color.Transparent;
      this.lblP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblP.Location = new System.Drawing.Point(134, 86);
      this.lblP.Name = "lblP";
      this.lblP.Size = new System.Drawing.Size(312, 16);
      this.lblP.TabIndex = 8;
      this.lblP.Text = "%P = MP3-Path";
      // 
      // btnBrowse
      // 
      this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
      this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnBrowse.Location = new System.Drawing.Point(454, 38);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(80, 20);
      this.btnBrowse.TabIndex = 4;
      this.btnBrowse.Text = "&Browse";
      this.btnBrowse.UseVisualStyleBackColor = false;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // cmbShell
      // 
      this.cmbShell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbShell.ItemHeight = 13;
      this.cmbShell.Location = new System.Drawing.Point(230, 110);
      this.cmbShell.Name = "cmbShell";
      this.cmbShell.Size = new System.Drawing.Size(208, 21);
      this.cmbShell.TabIndex = 7;
      // 
      // txtParameters
      // 
      this.txtParameters.Location = new System.Drawing.Point(136, 62);
      this.txtParameters.Name = "txtParameters";
      this.txtParameters.Size = new System.Drawing.Size(304, 20);
      this.txtParameters.TabIndex = 5;
      // 
      // txtPath
      // 
      this.txtPath.Location = new System.Drawing.Point(136, 38);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(304, 20);
      this.txtPath.TabIndex = 3;
      // 
      // txtDescription
      // 
      this.txtDescription.Location = new System.Drawing.Point(136, 14);
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(304, 20);
      this.txtDescription.TabIndex = 1;
      // 
      // chkDefault
      // 
      this.chkDefault.BackColor = System.Drawing.Color.Transparent;
      this.chkDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkDefault.Location = new System.Drawing.Point(6, 112);
      this.chkDefault.Name = "chkDefault";
      this.chkDefault.Size = new System.Drawing.Size(216, 16);
      this.chkDefault.TabIndex = 6;
      this.chkDefault.Text = "Use &Windows default MP3-Player:";
      this.chkDefault.UseVisualStyleBackColor = false;
      this.chkDefault.CheckedChanged += new System.EventHandler(this.chkDefault_CheckedChanged);
      // 
      // lblParameters
      // 
      this.lblParameters.BackColor = System.Drawing.Color.Transparent;
      this.lblParameters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblParameters.Location = new System.Drawing.Point(6, 64);
      this.lblParameters.Name = "lblParameters";
      this.lblParameters.Size = new System.Drawing.Size(120, 16);
      this.lblParameters.TabIndex = 4;
      this.lblParameters.Text = "Tool &parameters:";
      // 
      // lblPath
      // 
      this.lblPath.BackColor = System.Drawing.Color.Transparent;
      this.lblPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPath.Location = new System.Drawing.Point(6, 40);
      this.lblPath.Name = "lblPath";
      this.lblPath.Size = new System.Drawing.Size(120, 16);
      this.lblPath.TabIndex = 2;
      this.lblPath.Text = "Tool &path:";
      // 
      // lblDescription
      // 
      this.lblDescription.BackColor = System.Drawing.Color.Transparent;
      this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDescription.Location = new System.Drawing.Point(6, 16);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(120, 16);
      this.lblDescription.TabIndex = 0;
      this.lblDescription.Text = "Tool &description:";
      // 
      // ColorDialog
      // 
      this.ColorDialog.AnyColor = true;
      // 
      // chkAudioChecksumCalc
      // 
      this.chkAudioChecksumCalc.BackColor = System.Drawing.SystemColors.Control;
      this.chkAudioChecksumCalc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkAudioChecksumCalc.Location = new System.Drawing.Point(14, 271);
      this.chkAudioChecksumCalc.Name = "chkAudioChecksumCalc";
      this.chkAudioChecksumCalc.Size = new System.Drawing.Size(520, 16);
      this.chkAudioChecksumCalc.TabIndex = 17;
      this.chkAudioChecksumCalc.Text = "&Calculate Audiochecksum in the background";
      this.chkAudioChecksumCalc.UseVisualStyleBackColor = false;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(422, 410);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 101;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.SystemColors.Control;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(294, 410);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 100;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Controls.Add(this.tabPage5);
      this.tabControl1.Controls.Add(this.tabPage6);
      this.tabControl1.Location = new System.Drawing.Point(4, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(560, 400);
      this.tabControl1.TabIndex = 121;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.chkAudioChecksumCalc);
      this.tabPage1.Controls.Add(this.frameDoubleClick);
      this.tabPage1.Controls.Add(this.chkIgnoreWrite);
      this.tabPage1.Controls.Add(this.frameEnum);
      this.tabPage1.Controls.Add(this.chkMouseRenaming);
      this.tabPage1.Controls.Add(this.chkExplorerContext);
      this.tabPage1.Controls.Add(this.chkRestore);
      this.tabPage1.Controls.Add(this.cmbPlay);
      this.tabPage1.Controls.Add(this.lblTracknumbers);
      this.tabPage1.Controls.Add(this.lblPlay);
      this.tabPage1.Controls.Add(this.txtTFDigits);
      this.tabPage1.Controls.Add(this.chkSaveOnExit);
      this.tabPage1.Controls.Add(this.frameSelection);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(552, 374);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Settings";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.lblV24);
      this.tabPage2.Controls.Add(this.optUse23);
      this.tabPage2.Controls.Add(this.lblV23);
      this.tabPage2.Controls.Add(this.txtTTDigits);
      this.tabPage2.Controls.Add(this.cmbV24Enc);
      this.tabPage2.Controls.Add(this.lblDigits);
      this.tabPage2.Controls.Add(this.lblTextEncInfo);
      this.tabPage2.Controls.Add(this.cmbYearFormat);
      this.tabPage2.Controls.Add(this.chkSingle);
      this.tabPage2.Controls.Add(this.cmbV23Enc);
      this.tabPage2.Controls.Add(this.chkUnSync);
      this.tabPage2.Controls.Add(this.lblFormat);
      this.tabPage2.Controls.Add(this.optUse24);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(552, 374);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "TAG Ver. 2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.btnUp);
      this.tabPage3.Controls.Add(this.ColumnsList);
      this.tabPage3.Controls.Add(this.btnDown);
      this.tabPage3.Controls.Add(this.lblDescript);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(552, 374);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Columns";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.lblUsername);
      this.tabPage4.Controls.Add(this.lblServer);
      this.tabPage4.Controls.Add(this.Username);
      this.tabPage4.Controls.Add(this.chkProxy);
      this.tabPage4.Controls.Add(this.lblPort);
      this.tabPage4.Controls.Add(this.grpProxy);
      this.tabPage4.Controls.Add(this.Port);
      this.tabPage4.Controls.Add(this.Server);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(552, 374);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "FreeDB";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.ColorDoubleText);
      this.tabPage5.Controls.Add(this.Label1);
      this.tabPage5.Controls.Add(this.ColorDoubleBack);
      this.tabPage5.Controls.Add(this.ColorChangedText);
      this.tabPage5.Controls.Add(this.chkWinXPThemes);
      this.tabPage5.Controls.Add(this.ColorChangedBack);
      this.tabPage5.Controls.Add(this.Label5);
      this.tabPage5.Controls.Add(this.Label2);
      this.tabPage5.Controls.Add(this.Label6);
      this.tabPage5.Controls.Add(this.Label3);
      this.tabPage5.Controls.Add(this.ColorCompareText);
      this.tabPage5.Controls.Add(this.Label4);
      this.tabPage5.Controls.Add(this.ColorCompareBack);
      this.tabPage5.Location = new System.Drawing.Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage5.Size = new System.Drawing.Size(552, 374);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Colors";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // tabPage6
      // 
      this.tabPage6.Controls.Add(this.btnBrowse);
      this.tabPage6.Controls.Add(this.lblDescription);
      this.tabPage6.Controls.Add(this.cmbShell);
      this.tabPage6.Controls.Add(this.lblP);
      this.tabPage6.Controls.Add(this.txtParameters);
      this.tabPage6.Controls.Add(this.btnAdd);
      this.tabPage6.Controls.Add(this.txtPath);
      this.tabPage6.Controls.Add(this.lblParameters);
      this.tabPage6.Controls.Add(this.txtDescription);
      this.tabPage6.Controls.Add(this.btnRemove);
      this.tabPage6.Controls.Add(this.chkDefault);
      this.tabPage6.Controls.Add(this.lblPath);
      this.tabPage6.Controls.Add(this.ToolGrid);
      this.tabPage6.Location = new System.Drawing.Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage6.Size = new System.Drawing.Size(552, 374);
      this.tabPage6.TabIndex = 5;
      this.tabPage6.Text = "Tools";
      this.tabPage6.UseVisualStyleBackColor = true;
      // 
      // frmPreferences
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(566, 440);
      this.ControlBox = false;
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.btnCancel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmPreferences";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Preferences";
      this.frameEnum.ResumeLayout(false);
      this.frameEnum.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtFDigits)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartNr)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTFDigits)).EndInit();
      this.frameSelection.ResumeLayout(false);
      this.frameDoubleClick.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtTTDigits)).EndInit();
      this.grpProxy.ResumeLayout(false);
      this.grpProxy.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ToolGrid)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      this.tabPage5.ResumeLayout(false);
      this.tabPage6.ResumeLayout(false);
      this.tabPage6.PerformLayout();
      this.ResumeLayout(false);

    }

    public frmPreferences(frmMain Main)
    {
      base.Load += new EventHandler(this.frmOptions_Load);
      this.ColumnSettingsChanged = false;
      this.vbooChecking = false;
      this.InitializeComponent();
      this.MainForm = Main;
      this.AddColumns();
    }

    #endregion

    #region Local variables

    private bool ColumnSettingsChanged;
    private bool vbooChecking;

    #endregion

    #region Events

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (((StringType.StrCmp(this.txtDescription.Text, "", false) == 0) & (StringType.StrCmp(this.txtPath.Text, "", false) == 0)) & !this.chkDefault.Checked)
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["ToolMissing"]), MsgBoxStyle.Exclamation, null);
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
          this.txtDescription.Text = this.txtPath.Text.Substring(this.txtPath.Text.LastIndexOf(@"\") + 1, (this.txtPath.Text.LastIndexOf(".") - this.txtPath.Text.LastIndexOf(@"\")) - 1);

        if (StringType.StrCmp(this.txtParameters.Text, "", false) == 0)
          this.txtParameters.Text = "%P";
      }
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
      this.ColumnsList.BeginUpdate();

      if (this.ColumnsList.SelectedItems.Count == 1)
      {
        ListViewItem item = this.ColumnsList.SelectedItems[0];
        if (item.Index == (this.ColumnsList.Items.Count - 1))
          this.ColumnsList.EndUpdate();
        else
        {
          ListViewItem item2 = (ListViewItem)item.Clone();

          item2.Checked = item.Checked;
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
        Declarations.objSettings.EditDialog = 1;
      else if (this.optEditV2.Checked)
        Declarations.objSettings.EditDialog = 2;
      else
        Declarations.objSettings.EditDialog = 3;

      if (this.optUse23.Checked)
        Declarations.objSettings.NewV2Version = 3;
      else
        Declarations.objSettings.NewV2Version = 4;

      if (this.optSingle.Checked)
        Declarations.objSettings.SelectionMode = 1;
      else
        Declarations.objSettings.SelectionMode = 2;

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

      try
      {
        RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT", true);
        string executablePath = Application.ExecutablePath;

        if (Declarations.objSettings.ExplorerContext)
        {
          if (key != null)
            Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).DeleteSubKeyTree("ID3-TagIT");

          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).CreateSubKey("ID3-TagIT");
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT", true).CreateSubKey("command");
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT\command", true).SetValue(null, "\"" + executablePath + "\"" + " " + "\"" + "/P=%1" + "\"");
        }

        if (!Declarations.objSettings.ExplorerContext & (key != null))
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).DeleteSubKeyTree("ID3-TagIT");
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
          this.ColumnsList.EndUpdate();
        else
        {
          ListViewItem item2 = (ListViewItem)item.Clone();
          item2.Checked = item.Checked;
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
      this.grpProxy.Enabled = this.chkProxy.Checked;
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
            e.NewValue = CheckState.Checked;
        }

        this.vbooChecking = false;
      }
    }

    private void frmOptions_Load(object sender, EventArgs e)
    {
      Process process = new Process();
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
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
        this.optEditV1.Checked = true;
      else if (Declarations.objSettings.EditDialog == 2)
        this.optEditV2.Checked = true;
      else
        this.optEditCur.Checked = true;

      if (Declarations.objSettings.NewV2Version == 3)
        this.optUse23.Checked = true;
      else
        this.optUse24.Checked = true;

      if (Declarations.objSettings.SelectionMode == 1)
        this.optSingle.Checked = true;
      else
        this.optAdd.Checked = true;

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
      this.AddToolTips();
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

    #endregion

    #region Class logic

    public void AddColumns()
    {
      bool flag = false;
      int num = 0;
      this.ColumnsList.Columns.Add("Name", this.ColumnsList.Width - 0x19, HorizontalAlignment.Left);

      foreach (int num3 in Id3TagIT_Main.GetColumnOrder(this.MainForm.MP3View))
      {
        ListViewItem item2 = new ListViewItem();
        ArrayList list = new ArrayList();
        ColumnHeader header = this.MainForm.MP3View.Columns[num3];

        if (header == this.MainForm.colHFilename)
          list.Add(1);
        if (header == this.MainForm.colHSubDir)
          list.Add(2);
        if (header == this.MainForm.colHTAGVer1)
          list.Add(3);
        if (header == this.MainForm.colHTAGVer2)
          list.Add(4);
        if (header == this.MainForm.colHArtist)
          list.Add(5);
        if (header == this.MainForm.colHTitle)
          list.Add(6);
        if (header == this.MainForm.colHAlbum)
          list.Add(7);
        if (header == this.MainForm.colHTrack)
          list.Add(8);
        if (header == this.MainForm.colHPosMedia)
          list.Add(9);
        if (header == this.MainForm.colHComment)
          list.Add(10);
        if (header == this.MainForm.colHGenre)
          list.Add(11);
        if (header == this.MainForm.colHYear)
          list.Add(12);
        if (header == this.MainForm.colHRating)
          list.Add(13);
        if (header == this.MainForm.colHDuration)
          list.Add(14);
        if (header == this.MainForm.colHBitrate)
          list.Add(15);
        if (header == this.MainForm.colHVBR)
          list.Add(0x10);
        if (header == this.MainForm.colHSamplerate)
          list.Add(0x11);
        if (header == this.MainForm.colHChannel)
          list.Add(0x12);
        if (header == this.MainForm.colHVersion)
          list.Add(0x13);
        if (header == this.MainForm.colHDate)
          list.Add(20);
        if (header == this.MainForm.colHComposer)
          list.Add(0x15);
        if (header == this.MainForm.colHFileSize)
          list.Add(0x16);
        if (header == this.MainForm.colHBPM)
          list.Add(0x17);
        if (header == this.MainForm.colHPicCount)
          list.Add(0x18);
        if (header == this.MainForm.colHAudioCheckSum)
          list.Add(0x19);
        if (header == this.MainForm.colHCreateDate)
          list.Add(0x1a);

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
          ArrayList list2 = new ArrayList { num, 150 };

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

    #endregion
  }
}