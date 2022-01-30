using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmLists : Form
  {
    #region Designer

    private Button btnClose;
    private Button btnCreateFromTemp;
    private Button btnCreatePlaylist;
    private Button btnCreateQuickLists;
    private Button btnDown;
    private Button btnPath;
    private Button btnUp;
    private CheckBox chkColor;
    private CheckBox chkCreateCSV;
    private CheckBox chkCreateHTML;
    private CheckBox chkGridlines;
    private CheckBox chkRelativ;
    private ComboBox cmbWidth;
    private ListView ColumnsList;
    private GroupBox frameColumns;
    private GroupBox frameOptions;
    private GroupBox framePara;
    private GroupBox frameTAGInfo;
    private Label L1;
    private Label L2;
    private Label L3;
    private Label L4;
    private Label L5;
    private Label L6;
    private Label L7;
    private Label lblInfo1;
    private Label lblInfo2;
    private Label lblInfo3;
    private Label lblListWidth;
    private Label lblPath;
    private Label lblPlaylist;
    private Label lblTitleHTML;
    private RadioButton optID3V1;
    private RadioButton optID3V2;
    private System.Windows.Forms.ProgressBar ProgressBar;
    private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    private ListBox TemplatesList;
    private System.Windows.Forms.ToolTip ToolTip;
    private TextBox txtExtInfo;
    private TextBox txtPath;
    private TextBox txtTitleHTML;
    private NumericUpDown txtWidth;
    private IContainer components;
    public frmMain MainForm;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLists));
      this.btnClose = new System.Windows.Forms.Button();
      this.btnPath = new System.Windows.Forms.Button();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.lblPath = new System.Windows.Forms.Label();
      this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.btnCreatePlaylist = new System.Windows.Forms.Button();
      this.lblInfo1 = new System.Windows.Forms.Label();
      this.framePara = new System.Windows.Forms.GroupBox();
      this.L7 = new System.Windows.Forms.Label();
      this.L6 = new System.Windows.Forms.Label();
      this.L5 = new System.Windows.Forms.Label();
      this.L4 = new System.Windows.Forms.Label();
      this.L3 = new System.Windows.Forms.Label();
      this.L2 = new System.Windows.Forms.Label();
      this.L1 = new System.Windows.Forms.Label();
      this.chkRelativ = new System.Windows.Forms.CheckBox();
      this.txtExtInfo = new System.Windows.Forms.TextBox();
      this.lblPlaylist = new System.Windows.Forms.Label();
      this.TemplatesList = new System.Windows.Forms.ListBox();
      this.lblInfo2 = new System.Windows.Forms.Label();
      this.btnCreateFromTemp = new System.Windows.Forms.Button();
      this.lblInfo3 = new System.Windows.Forms.Label();
      this.chkCreateHTML = new System.Windows.Forms.CheckBox();
      this.chkCreateCSV = new System.Windows.Forms.CheckBox();
      this.frameOptions = new System.Windows.Forms.GroupBox();
      this.chkColor = new System.Windows.Forms.CheckBox();
      this.chkGridlines = new System.Windows.Forms.CheckBox();
      this.txtWidth = new System.Windows.Forms.NumericUpDown();
      this.cmbWidth = new System.Windows.Forms.ComboBox();
      this.lblListWidth = new System.Windows.Forms.Label();
      this.lblTitleHTML = new System.Windows.Forms.Label();
      this.frameTAGInfo = new System.Windows.Forms.GroupBox();
      this.optID3V1 = new System.Windows.Forms.RadioButton();
      this.optID3V2 = new System.Windows.Forms.RadioButton();
      this.txtTitleHTML = new System.Windows.Forms.TextBox();
      this.frameColumns = new System.Windows.Forms.GroupBox();
      this.ColumnsList = new System.Windows.Forms.ListView();
      this.btnUp = new System.Windows.Forms.Button();
      this.btnDown = new System.Windows.Forms.Button();
      this.btnCreateQuickLists = new System.Windows.Forms.Button();
      this.tabControl2 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.framePara.SuspendLayout();
      this.frameOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).BeginInit();
      this.frameTAGInfo.SuspendLayout();
      this.frameColumns.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.SystemColors.Control;
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnClose.Location = new System.Drawing.Point(447, 474);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(160, 24);
      this.btnClose.TabIndex = 16;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnPath
      // 
      this.btnPath.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnPath.Location = new System.Drawing.Point(456, 38);
      this.btnPath.Name = "btnPath";
      this.btnPath.Size = new System.Drawing.Size(152, 24);
      this.btnPath.TabIndex = 2;
      this.btnPath.Text = "&Select filename ...";
      this.btnPath.UseVisualStyleBackColor = false;
      this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
      // 
      // txtPath
      // 
      this.txtPath.BackColor = System.Drawing.SystemColors.Window;
      this.txtPath.Location = new System.Drawing.Point(16, 40);
      this.txtPath.MaxLength = 255;
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(432, 20);
      this.txtPath.TabIndex = 1;
      // 
      // lblPath
      // 
      this.lblPath.BackColor = System.Drawing.SystemColors.Menu;
      this.lblPath.ForeColor = System.Drawing.Color.Black;
      this.lblPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPath.Location = new System.Drawing.Point(16, 16);
      this.lblPath.Name = "lblPath";
      this.lblPath.Size = new System.Drawing.Size(320, 16);
      this.lblPath.TabIndex = 0;
      this.lblPath.Text = "&Path and Filename of the list(s) (without extension): ";
      // 
      // SaveFileDialog
      // 
      this.SaveFileDialog.Title = "Select the path and filename for the list";
      // 
      // ProgressBar
      // 
      this.ProgressBar.BackColor = System.Drawing.SystemColors.Control;
      this.ProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ProgressBar.Location = new System.Drawing.Point(16, 478);
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Size = new System.Drawing.Size(424, 16);
      this.ProgressBar.Step = 1;
      this.ProgressBar.TabIndex = 17;
      // 
      // btnCreatePlaylist
      // 
      this.btnCreatePlaylist.BackColor = System.Drawing.SystemColors.Control;
      this.btnCreatePlaylist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCreatePlaylist.Location = new System.Drawing.Point(6, 338);
      this.btnCreatePlaylist.Name = "btnCreatePlaylist";
      this.btnCreatePlaylist.Size = new System.Drawing.Size(592, 24);
      this.btnCreatePlaylist.TabIndex = 11;
      this.btnCreatePlaylist.Text = "Create Playlist";
      this.btnCreatePlaylist.UseVisualStyleBackColor = false;
      this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
      // 
      // lblInfo1
      // 
      this.lblInfo1.BackColor = System.Drawing.Color.Transparent;
      this.lblInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo1.Location = new System.Drawing.Point(462, 23);
      this.lblInfo1.Name = "lblInfo1";
      this.lblInfo1.Size = new System.Drawing.Size(128, 128);
      this.lblInfo1.TabIndex = 9;
      this.lblInfo1.Text = "M3U playlists can include some extended information with the format above you can" +
    " choose which information should be put into the playlist.";
      this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // framePara
      // 
      this.framePara.BackColor = System.Drawing.Color.Transparent;
      this.framePara.Controls.Add(this.L7);
      this.framePara.Controls.Add(this.L6);
      this.framePara.Controls.Add(this.L5);
      this.framePara.Controls.Add(this.L4);
      this.framePara.Controls.Add(this.L3);
      this.framePara.Controls.Add(this.L2);
      this.framePara.Controls.Add(this.L1);
      this.framePara.Location = new System.Drawing.Point(6, 55);
      this.framePara.Name = "framePara";
      this.framePara.Size = new System.Drawing.Size(440, 96);
      this.framePara.TabIndex = 8;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      // 
      // L7
      // 
      this.L7.BackColor = System.Drawing.Color.Transparent;
      this.L7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L7.Location = new System.Drawing.Point(8, 72);
      this.L7.Name = "L7";
      this.L7.Size = new System.Drawing.Size(160, 16);
      this.L7.TabIndex = 6;
      this.L7.Text = "<K> = Track number";
      this.L7.Click += new System.EventHandler(this.Label_Click);
      // 
      // L6
      // 
      this.L6.BackColor = System.Drawing.Color.Transparent;
      this.L6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L6.Location = new System.Drawing.Point(192, 40);
      this.L6.Name = "L6";
      this.L6.Size = new System.Drawing.Size(160, 16);
      this.L6.TabIndex = 5;
      this.L6.Text = "<G> = Genre";
      this.L6.Click += new System.EventHandler(this.Label_Click);
      // 
      // L5
      // 
      this.L5.BackColor = System.Drawing.Color.Transparent;
      this.L5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L5.Location = new System.Drawing.Point(192, 56);
      this.L5.Name = "L5";
      this.L5.Size = new System.Drawing.Size(160, 16);
      this.L5.TabIndex = 4;
      this.L5.Text = "<Y> = Year";
      this.L5.Click += new System.EventHandler(this.Label_Click);
      // 
      // L4
      // 
      this.L4.BackColor = System.Drawing.Color.Transparent;
      this.L4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L4.Location = new System.Drawing.Point(8, 56);
      this.L4.Name = "L4";
      this.L4.Size = new System.Drawing.Size(160, 16);
      this.L4.TabIndex = 3;
      this.L4.Text = "<C> = Comment";
      this.L4.Click += new System.EventHandler(this.Label_Click);
      // 
      // L3
      // 
      this.L3.BackColor = System.Drawing.Color.Transparent;
      this.L3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L3.Location = new System.Drawing.Point(8, 40);
      this.L3.Name = "L3";
      this.L3.Size = new System.Drawing.Size(160, 16);
      this.L3.TabIndex = 2;
      this.L3.Text = "<B> = Album";
      this.L3.Click += new System.EventHandler(this.Label_Click);
      // 
      // L2
      // 
      this.L2.BackColor = System.Drawing.Color.Transparent;
      this.L2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L2.Location = new System.Drawing.Point(192, 24);
      this.L2.Name = "L2";
      this.L2.Size = new System.Drawing.Size(160, 16);
      this.L2.TabIndex = 1;
      this.L2.Text = "<T> = Title";
      this.L2.Click += new System.EventHandler(this.Label_Click);
      // 
      // L1
      // 
      this.L1.BackColor = System.Drawing.Color.Transparent;
      this.L1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L1.Location = new System.Drawing.Point(8, 24);
      this.L1.Name = "L1";
      this.L1.Size = new System.Drawing.Size(160, 16);
      this.L1.TabIndex = 0;
      this.L1.Text = "<A> = Artist";
      this.L1.Click += new System.EventHandler(this.Label_Click);
      // 
      // chkRelativ
      // 
      this.chkRelativ.BackColor = System.Drawing.Color.Transparent;
      this.chkRelativ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkRelativ.Location = new System.Drawing.Point(6, 167);
      this.chkRelativ.Name = "chkRelativ";
      this.chkRelativ.Size = new System.Drawing.Size(584, 16);
      this.chkRelativ.TabIndex = 10;
      this.chkRelativ.Text = "Use &relative paths in playlist";
      this.chkRelativ.UseVisualStyleBackColor = false;
      // 
      // txtExtInfo
      // 
      this.txtExtInfo.Location = new System.Drawing.Point(6, 23);
      this.txtExtInfo.Name = "txtExtInfo";
      this.txtExtInfo.Size = new System.Drawing.Size(440, 20);
      this.txtExtInfo.TabIndex = 7;
      this.txtExtInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtInfo_KeyPress);
      // 
      // lblPlaylist
      // 
      this.lblPlaylist.BackColor = System.Drawing.Color.Transparent;
      this.lblPlaylist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPlaylist.Location = new System.Drawing.Point(6, 7);
      this.lblPlaylist.Name = "lblPlaylist";
      this.lblPlaylist.Size = new System.Drawing.Size(320, 16);
      this.lblPlaylist.TabIndex = 6;
      this.lblPlaylist.Text = "Format of extended playlist info:";
      // 
      // TemplatesList
      // 
      this.TemplatesList.Location = new System.Drawing.Point(6, 67);
      this.TemplatesList.Name = "TemplatesList";
      this.TemplatesList.Size = new System.Drawing.Size(240, 264);
      this.TemplatesList.Sorted = true;
      this.TemplatesList.TabIndex = 27;
      // 
      // lblInfo2
      // 
      this.lblInfo2.BackColor = System.Drawing.Color.Transparent;
      this.lblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo2.Location = new System.Drawing.Point(6, 3);
      this.lblInfo2.Name = "lblInfo2";
      this.lblInfo2.Size = new System.Drawing.Size(592, 56);
      this.lblInfo2.TabIndex = 26;
      this.lblInfo2.Text = resources.GetString("lblInfo2.Text");
      this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnCreateFromTemp
      // 
      this.btnCreateFromTemp.BackColor = System.Drawing.SystemColors.Control;
      this.btnCreateFromTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCreateFromTemp.Location = new System.Drawing.Point(6, 338);
      this.btnCreateFromTemp.Name = "btnCreateFromTemp";
      this.btnCreateFromTemp.Size = new System.Drawing.Size(592, 24);
      this.btnCreateFromTemp.TabIndex = 25;
      this.btnCreateFromTemp.Text = "Create from template";
      this.btnCreateFromTemp.UseVisualStyleBackColor = false;
      this.btnCreateFromTemp.Click += new System.EventHandler(this.btnCreateFromTemp_Click);
      // 
      // lblInfo3
      // 
      this.lblInfo3.BackColor = System.Drawing.Color.Transparent;
      this.lblInfo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo3.Location = new System.Drawing.Point(6, 3);
      this.lblInfo3.Name = "lblInfo3";
      this.lblInfo3.Size = new System.Drawing.Size(592, 40);
      this.lblInfo3.TabIndex = 31;
      this.lblInfo3.Text = "This option allows to cretae a HTML or CSV file without a template. Select the fi" +
    "le format(s) and choose the columns. ";
      this.lblInfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // chkCreateHTML
      // 
      this.chkCreateHTML.BackColor = System.Drawing.Color.Transparent;
      this.chkCreateHTML.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkCreateHTML.Location = new System.Drawing.Point(6, 59);
      this.chkCreateHTML.Name = "chkCreateHTML";
      this.chkCreateHTML.Size = new System.Drawing.Size(152, 16);
      this.chkCreateHTML.TabIndex = 29;
      this.chkCreateHTML.Text = "Create HTML list";
      this.chkCreateHTML.UseVisualStyleBackColor = false;
      // 
      // chkCreateCSV
      // 
      this.chkCreateCSV.BackColor = System.Drawing.Color.Transparent;
      this.chkCreateCSV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkCreateCSV.Location = new System.Drawing.Point(174, 59);
      this.chkCreateCSV.Name = "chkCreateCSV";
      this.chkCreateCSV.Size = new System.Drawing.Size(176, 16);
      this.chkCreateCSV.TabIndex = 30;
      this.chkCreateCSV.Text = "Create CSV list";
      this.chkCreateCSV.UseVisualStyleBackColor = false;
      // 
      // frameOptions
      // 
      this.frameOptions.BackColor = System.Drawing.Color.Transparent;
      this.frameOptions.Controls.Add(this.chkColor);
      this.frameOptions.Controls.Add(this.chkGridlines);
      this.frameOptions.Controls.Add(this.txtWidth);
      this.frameOptions.Controls.Add(this.cmbWidth);
      this.frameOptions.Controls.Add(this.lblListWidth);
      this.frameOptions.Location = new System.Drawing.Point(366, 171);
      this.frameOptions.Name = "frameOptions";
      this.frameOptions.Size = new System.Drawing.Size(232, 112);
      this.frameOptions.TabIndex = 25;
      this.frameOptions.TabStop = false;
      this.frameOptions.Text = "Options (HTML-List only)";
      // 
      // chkColor
      // 
      this.chkColor.BackColor = System.Drawing.Color.Transparent;
      this.chkColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkColor.Location = new System.Drawing.Point(16, 80);
      this.chkColor.Name = "chkColor";
      this.chkColor.Size = new System.Drawing.Size(208, 16);
      this.chkColor.TabIndex = 13;
      this.chkColor.Text = "&Color odd and even rows";
      this.chkColor.UseVisualStyleBackColor = false;
      // 
      // chkGridlines
      // 
      this.chkGridlines.BackColor = System.Drawing.Color.Transparent;
      this.chkGridlines.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkGridlines.Location = new System.Drawing.Point(16, 56);
      this.chkGridlines.Name = "chkGridlines";
      this.chkGridlines.Size = new System.Drawing.Size(208, 16);
      this.chkGridlines.TabIndex = 12;
      this.chkGridlines.Text = "Show &gridlines";
      this.chkGridlines.UseVisualStyleBackColor = false;
      // 
      // txtWidth
      // 
      this.txtWidth.Location = new System.Drawing.Point(88, 24);
      this.txtWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.txtWidth.Name = "txtWidth";
      this.txtWidth.Size = new System.Drawing.Size(72, 20);
      this.txtWidth.TabIndex = 10;
      // 
      // cmbWidth
      // 
      this.cmbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbWidth.ItemHeight = 13;
      this.cmbWidth.Items.AddRange(new object[] {
            "px",
            "%"});
      this.cmbWidth.Location = new System.Drawing.Point(168, 24);
      this.cmbWidth.Name = "cmbWidth";
      this.cmbWidth.Size = new System.Drawing.Size(56, 21);
      this.cmbWidth.TabIndex = 11;
      this.cmbWidth.SelectedIndexChanged += new System.EventHandler(this.cmbWidth_SelectedIndexChanged);
      // 
      // lblListWidth
      // 
      this.lblListWidth.BackColor = System.Drawing.Color.Transparent;
      this.lblListWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblListWidth.Location = new System.Drawing.Point(8, 26);
      this.lblListWidth.Name = "lblListWidth";
      this.lblListWidth.Size = new System.Drawing.Size(80, 16);
      this.lblListWidth.TabIndex = 9;
      this.lblListWidth.Text = "List &width";
      // 
      // lblTitleHTML
      // 
      this.lblTitleHTML.BackColor = System.Drawing.Color.Transparent;
      this.lblTitleHTML.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitleHTML.Location = new System.Drawing.Point(6, 291);
      this.lblTitleHTML.Name = "lblTitleHTML";
      this.lblTitleHTML.Size = new System.Drawing.Size(576, 16);
      this.lblTitleHTML.TabIndex = 26;
      this.lblTitleHTML.Text = "&Title of the list (HTML-List only)";
      // 
      // frameTAGInfo
      // 
      this.frameTAGInfo.BackColor = System.Drawing.Color.Transparent;
      this.frameTAGInfo.Controls.Add(this.optID3V1);
      this.frameTAGInfo.Controls.Add(this.optID3V2);
      this.frameTAGInfo.Location = new System.Drawing.Point(366, 83);
      this.frameTAGInfo.Name = "frameTAGInfo";
      this.frameTAGInfo.Size = new System.Drawing.Size(232, 80);
      this.frameTAGInfo.TabIndex = 24;
      this.frameTAGInfo.TabStop = false;
      this.frameTAGInfo.Text = "Choose TAG Ver. for creating list";
      // 
      // optID3V1
      // 
      this.optID3V1.BackColor = System.Drawing.Color.Transparent;
      this.optID3V1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optID3V1.Location = new System.Drawing.Point(16, 24);
      this.optID3V1.Name = "optID3V1";
      this.optID3V1.Size = new System.Drawing.Size(208, 16);
      this.optID3V1.TabIndex = 7;
      this.optID3V1.Text = "Use TAG Ver. &1 for creating the list";
      this.optID3V1.UseVisualStyleBackColor = false;
      // 
      // optID3V2
      // 
      this.optID3V2.BackColor = System.Drawing.Color.Transparent;
      this.optID3V2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optID3V2.Location = new System.Drawing.Point(16, 48);
      this.optID3V2.Name = "optID3V2";
      this.optID3V2.Size = new System.Drawing.Size(208, 16);
      this.optID3V2.TabIndex = 8;
      this.optID3V2.Text = "Use TAG Ver. &2 for creating the list";
      this.optID3V2.UseVisualStyleBackColor = false;
      // 
      // txtTitleHTML
      // 
      this.txtTitleHTML.Location = new System.Drawing.Point(6, 307);
      this.txtTitleHTML.Name = "txtTitleHTML";
      this.txtTitleHTML.Size = new System.Drawing.Size(592, 20);
      this.txtTitleHTML.TabIndex = 27;
      // 
      // frameColumns
      // 
      this.frameColumns.BackColor = System.Drawing.Color.Transparent;
      this.frameColumns.Controls.Add(this.ColumnsList);
      this.frameColumns.Controls.Add(this.btnUp);
      this.frameColumns.Controls.Add(this.btnDown);
      this.frameColumns.Location = new System.Drawing.Point(6, 83);
      this.frameColumns.Name = "frameColumns";
      this.frameColumns.Size = new System.Drawing.Size(352, 200);
      this.frameColumns.TabIndex = 23;
      this.frameColumns.TabStop = false;
      this.frameColumns.Text = "Select columns of the list";
      // 
      // ColumnsList
      // 
      this.ColumnsList.CheckBoxes = true;
      this.ColumnsList.FullRowSelect = true;
      this.ColumnsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      this.ColumnsList.Location = new System.Drawing.Point(8, 24);
      this.ColumnsList.MultiSelect = false;
      this.ColumnsList.Name = "ColumnsList";
      this.ColumnsList.Size = new System.Drawing.Size(216, 168);
      this.ColumnsList.TabIndex = 4;
      this.ColumnsList.UseCompatibleStateImageBehavior = false;
      this.ColumnsList.View = System.Windows.Forms.View.Details;
      // 
      // btnUp
      // 
      this.btnUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnUp.Location = new System.Drawing.Point(232, 80);
      this.btnUp.Name = "btnUp";
      this.btnUp.Size = new System.Drawing.Size(112, 24);
      this.btnUp.TabIndex = 5;
      this.btnUp.Text = "Column &up";
      this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
      // 
      // btnDown
      // 
      this.btnDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnDown.Location = new System.Drawing.Point(232, 112);
      this.btnDown.Name = "btnDown";
      this.btnDown.Size = new System.Drawing.Size(112, 24);
      this.btnDown.TabIndex = 6;
      this.btnDown.Text = "Column &down";
      this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
      // 
      // btnCreateQuickLists
      // 
      this.btnCreateQuickLists.BackColor = System.Drawing.Color.Transparent;
      this.btnCreateQuickLists.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCreateQuickLists.Location = new System.Drawing.Point(6, 339);
      this.btnCreateQuickLists.Name = "btnCreateQuickLists";
      this.btnCreateQuickLists.Size = new System.Drawing.Size(592, 24);
      this.btnCreateQuickLists.TabIndex = 28;
      this.btnCreateQuickLists.Text = "Create &lists";
      this.btnCreateQuickLists.UseVisualStyleBackColor = false;
      this.btnCreateQuickLists.Click += new System.EventHandler(this.btnCreateQuickLists_Click);
      // 
      // tabControl2
      // 
      this.tabControl2.Controls.Add(this.tabPage1);
      this.tabControl2.Controls.Add(this.tabPage2);
      this.tabControl2.Controls.Add(this.tabPage3);
      this.tabControl2.Location = new System.Drawing.Point(5, 66);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new System.Drawing.Size(616, 406);
      this.tabControl2.TabIndex = 126;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnCreatePlaylist);
      this.tabPage1.Controls.Add(this.lblPlaylist);
      this.tabPage1.Controls.Add(this.lblInfo1);
      this.tabPage1.Controls.Add(this.txtExtInfo);
      this.tabPage1.Controls.Add(this.framePara);
      this.tabPage1.Controls.Add(this.chkRelativ);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(608, 380);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "M3U Playlist";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.TemplatesList);
      this.tabPage2.Controls.Add(this.lblInfo2);
      this.tabPage2.Controls.Add(this.btnCreateFromTemp);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(608, 380);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Filelist from template";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.lblInfo3);
      this.tabPage3.Controls.Add(this.btnCreateQuickLists);
      this.tabPage3.Controls.Add(this.chkCreateHTML);
      this.tabPage3.Controls.Add(this.frameColumns);
      this.tabPage3.Controls.Add(this.chkCreateCSV);
      this.tabPage3.Controls.Add(this.txtTitleHTML);
      this.tabPage3.Controls.Add(this.frameOptions);
      this.tabPage3.Controls.Add(this.frameTAGInfo);
      this.tabPage3.Controls.Add(this.lblTitleHTML);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(608, 380);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Quick HTML/CSV Filelist";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // frmLists
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(626, 504);
      this.ControlBox = false;
      this.Controls.Add(this.btnPath);
      this.Controls.Add(this.tabControl2);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.ProgressBar);
      this.Controls.Add(this.lblPath);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmLists";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Create lists of selected files";
      this.framePara.ResumeLayout(false);
      this.frameOptions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).EndInit();
      this.frameTAGInfo.ResumeLayout(false);
      this.frameColumns.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public frmLists()
    {
      base.Load += new EventHandler(this.frmLists_Load);
      this.vstrComparePath = "*";
      this.vstrTemplatesPath = StringType.FromObject(Interaction.IIf(Application.StartupPath.EndsWith(@"\"), Application.StartupPath + @"Templetes\", Application.StartupPath + @"\Templetes\"));
      this.InitializeComponent();
      this.AddColumns();
      this.cmbWidth.SelectedIndex = 0;
      this.txtWidth.Minimum = decimal.Zero;
      this.txtWidth.Maximum = 4096M;
      this.txtWidth.Value = 600M;
    }

    #endregion

    #region Local variables

    private string vstrComparePath;
    private System.Windows.Forms.TabControl tabControl2;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private string vstrTemplatesPath;

    #endregion

    #region Events

    private void btnClose_Click(object sender, EventArgs e)
    {
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      string str = this.txtPath.Text.Trim(new char[] { ' ' });

      if ((str.LastIndexOf(".") > 0) & (str.LastIndexOf(".") > str.LastIndexOf(@"\")))
        str = str.Remove(str.LastIndexOf("."), str.Length - str.LastIndexOf("."));

      if (StringType.StrCmp(this.vstrComparePath, "*", false) == 0)
        Declarations.objSettings.ListPath = str;

      Declarations.objSettings.PlaylistRelPath = this.chkRelativ.Checked;
      Declarations.objSettings.ListStyle = 0;

      if (this.chkCreateHTML.Checked)
        Declarations.objSettings.ListStyle = (byte)(Declarations.objSettings.ListStyle | 1);

      if (this.chkCreateCSV.Checked)
        Declarations.objSettings.ListStyle = (byte)(Declarations.objSettings.ListStyle | 2);

      Declarations.objSettings.ListColumns = "";

      foreach (ListViewItem item in this.ColumnsList.Items)
        if (item.Checked)
        {
          Settings objSettings = Declarations.objSettings;
          objSettings.ListColumns = objSettings.ListColumns + item.Tag.ToString() + "-";
        }

      Declarations.objSettings.ListColumns = Declarations.objSettings.ListColumns.TrimEnd(new char[] { '-' });
      Declarations.objSettings.HTMLListTitle = this.txtTitleHTML.Text;
      Declarations.objSettings.HTMLListWidth = this.txtWidth.Text;
      Declarations.objSettings.HTMLListWidthUnit = this.cmbWidth.Text;
      Declarations.objSettings.HTMLGridlines = this.chkGridlines.Checked;
      Declarations.objSettings.HTMLColored = this.chkColor.Checked;
      Declarations.objSettings.ListExtInfo = this.txtExtInfo.Text.Trim();

      if (this.optID3V2.Checked)
        Declarations.objSettings.HTMLTAGVersion = 2;
      else
        Declarations.objSettings.HTMLTAGVersion = 1;

      this.Close();
    }

    private void btnCreateFromTemp_Click(object sender, EventArgs e)
    {
      if (this.TemplatesList.Items.Count != 0)
      {
        string str;

        if (this.TemplatesList.SelectedItem == null)
          this.TemplatesList.SelectedIndex = 0;

        string path = StringType.FromObject(ObjectType.StrCatObj(this.vstrTemplatesPath, this.TemplatesList.SelectedItem));
        string str2 = this.txtPath.Text.Trim(new char[] { ' ' });
        StreamReader reader = new StreamReader(path);
        ArrayList list2 = new ArrayList();
        ArrayList list3 = new ArrayList();
        ArrayList list = new ArrayList();
        byte num = 0;

        do
        {
          str = reader.ReadLine();

          if (!((str == null) | (StringType.StrCmp(str, "", false) == 0)))
          {
            str.TrimEnd(new char[] { '\r' });

            if (str.StartsWith("[ITLHEADER]"))
              num = 1;

            if (str.StartsWith("[ITLRECORD]"))
              num = 2;

            if (str.StartsWith("[ITLFOOTER]"))
              num = 3;

            if (str.StartsWith("[ITLEXTENSION]"))
              num = 4;

            if (!str.StartsWith("[ITL"))
            {
              switch (num)
              {
                case 1:
                  list2.Add(str);
                  break;

                case 2:
                  list3.Add(str);
                  break;

                case 3:
                  list.Add(str);
                  break;

                case 4:
                  str2 = str2 + "." + str.Trim();
                  num = 0;
                  break;
              }
            }
          }
        }

        while (str != null);
        reader.Close();

        try
        {
          File.Create(str2).Close();
          File.Delete(str2);
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidName"]), MsgBoxStyle.Exclamation, null);
          ProjectData.ClearProjectError();
          return;
        }

        this.Enabled = false;
        StreamWriter writer = new StreamWriter(str2);
        var enumerator4 = list2.GetEnumerator();

        while (enumerator4.MoveNext())
        {
          str = StringType.FromObject(enumerator4.Current);
          writer.WriteLine(str);
        }

        foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
        {
          var enumerator2 = list3.GetEnumerator();

          while (enumerator2.MoveNext())
          {
            str = StringType.FromObject(enumerator2.Current);

            if (str.IndexOf("%Filename%") > -1)
              str = str.Replace("%Filename%", this.GetTempData(item, "%Filename%", ""));

            if (str.IndexOf("%Subdirectory%") > -1)
              str = str.Replace("%Subdirectory%", this.GetTempData(item, "%Subdirectory%", ""));

            if (str.IndexOf("%Ver1%") > -1)
              str = str.Replace("%Ver1%", this.GetTempData(item, "%Ver1%", ""));

            if (str.IndexOf("%Ver2%") > -1)
              str = str.Replace("%Ver2%", this.GetTempData(item, "%Ver2%", ""));

            if (str.IndexOf("%Artist%") > -1)
              str = str.Replace("%Artist%", this.GetTempData(item, "%Artist%", ""));

            if (str.IndexOf("%Title%") > -1)
              str = str.Replace("%Title%", this.GetTempData(item, "%Title%", ""));

            if (str.IndexOf("%Album%") > -1)
              str = str.Replace("%Album%", this.GetTempData(item, "%Album%", ""));

            if (str.IndexOf("%Track%") > -1)
              str = str.Replace("%Track%", this.GetTempData(item, "%Track%", ""));

            if (str.IndexOf("%Position%") > -1)
              str = str.Replace("%Position%", this.GetTempData(item, "%Position%", ""));

            if (str.IndexOf("%Comment%") > -1)
              str = str.Replace("%Comment%", this.GetTempData(item, "%Comment%", ""));

            if (str.IndexOf("%Genre%") > -1)
              str = str.Replace("%Genre%", this.GetTempData(item, "%Genre%", ""));

            if (str.IndexOf("%Year%") > -1)
              str = str.Replace("%Year%", this.GetTempData(item, "%Year%", ""));

            if (str.IndexOf("%Rating%") > -1)
              str = str.Replace("%Rating%", this.GetTempData(item, "%Rating%", ""));

            if (str.IndexOf("%Duration%") > -1)
              str = str.Replace("%Duration%", this.GetTempData(item, "%DurationSec%", ""));

            if (str.IndexOf("%DurationSec%") > -1)
              str = str.Replace("%DurationSec%", this.GetTempData(item, "%Duration%", ""));

            if (str.IndexOf("%Bitrate%") > -1)
              str = str.Replace("%Bitrate%", this.GetTempData(item, "%Bitrate%", ""));

            if (str.IndexOf("%CBRVBR%") > -1)
              str = str.Replace("%CBRVBR%", this.GetTempData(item, "%CBRVBR%", ""));

            if (str.IndexOf("%Samplerate%") > -1)
              str = str.Replace("%Samplerate%", this.GetTempData(item, "%Samplerate%", ""));

            if (str.IndexOf("%Channel%") > -1)
              str = str.Replace("%Channel%", this.GetTempData(item, "%Channel%", ""));

            if (str.IndexOf("%Version%") > -1)
              str = str.Replace("%Version%", this.GetTempData(item, "%Version%", ""));

            if (str.IndexOf("%LastChanged%") > -1)
              str = str.Replace("%LastChanged%", this.GetTempData(item, "%LastChanged%", ""));

            if (str.IndexOf("%Composer%") > -1)
              str = str.Replace("%Composer%", this.GetTempData(item, "%Composer%", ""));

            if (str.IndexOf("%FileSize%") > -1)
              str = str.Replace("%FileSize%", this.GetTempData(item, "%FileSize%", ""));

            if (str.IndexOf("%BPM%") > -1)
              str = str.Replace("%BPM%", this.GetTempData(item, "%BPM%", ""));

            if (str.IndexOf("%FullFilename%") > -1)
              str = str.Replace("%FullFilename%", this.GetTempData(item, "%FullFilename%", str2));

            if (str.IndexOf("%RelFilename%") > -1)
              str = str.Replace("%RelFilename%", this.GetTempData(item, "%RelFilename%", str2));

            if (str.IndexOf("%CRC%") > -1)
              str = str.Replace("%CRC%", this.GetTempData(item, "%CRC%", ""));

            writer.WriteLine(str);
          }

          this.ProgressBar.PerformStep();
        }

        var enumerator = list.GetEnumerator();

        while (enumerator.MoveNext())
        {
          str = StringType.FromObject(enumerator.Current);
          writer.WriteLine(str);
        }

        writer.Close();
        this.Enabled = true;
        this.ProgressBar.Value = 0;
      }
    }

    private void btnCreatePlaylist_Click(object sender, EventArgs e)
    {
      string str = this.txtPath.Text.Trim(new char[] { ' ' });
      this.Enabled = false;
      string path = str + ".m3u";

      try
      {
        File.Create(path).Close();
        File.Delete(path);
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidName"]), MsgBoxStyle.Exclamation, null);
        this.Enabled = true;
        ProjectData.ClearProjectError();
        return;
      }

      this.CreatePlaylist(path);
      this.Enabled = true;
    }

    private void btnCreateQuickLists_Click(object sender, EventArgs e)
    {
      string str2;
      string str = this.txtPath.Text.Trim(new char[] { ' ' });
      this.Enabled = false;

      if (this.chkCreateHTML.Checked)
      {
        str2 = str + ".html";

        try
        {
          File.Create(str2).Close();
          File.Delete(str2);
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidName"]), MsgBoxStyle.Exclamation, null);
          this.Enabled = true;
          ProjectData.ClearProjectError();
          return;
        }

        switch (ID3Functions.FormatReplaceCheck(this.txtExtInfo.Text.Trim(), Declarations.FormatReplace.TAGToFilename | Declarations.FormatReplace.TAGVer2))
        {
          case Declarations.FormatReplaceFeedback.InvalidFormat:
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidFormat"]), MsgBoxStyle.Exclamation, null);
            return;

          case Declarations.FormatReplaceFeedback.InvalidCharFormat:
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidCharFormat"]), MsgBoxStyle.Exclamation, null);
            return;
        }

        this.CreateHTML(str2);
      }

      if (this.chkCreateCSV.Checked)
      {
        str2 = str + ".csv";

        try
        {
          File.Create(str2).Close();
          File.Delete(str2);
        }
        catch (Exception exception2)
        {
          ProjectData.SetProjectError(exception2);
          Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidName"]), MsgBoxStyle.Exclamation, null);
          this.Enabled = true;
          ProjectData.ClearProjectError();
          return;
        }

        string str3 = "";
        StreamWriter writer = new StreamWriter(str2, false, Encoding.Default);
        int count = this.ColumnsList.CheckedItems.Count;
        int num = 1;

        while (num <= count)
        {
          str3 = str3 + this.ColumnsList.CheckedItems[num - 1].Text + ";";
          num++;
        }

        str3 = str3.TrimEnd(new char[] { ';' });

        writer.WriteLine(str3);

        foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
        {
          str3 = "";
          int num2 = this.ColumnsList.CheckedItems.Count;

          for (num = 1; num <= num2; num++)
            str3 = str3 + "\"" + this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)).Replace("\"", "_") + "\"" + ";";

          str3 = str3.TrimEnd(new char[] { ';' });
          writer.WriteLine(str3);
          this.ProgressBar.PerformStep();
        }

        writer.Close();
      }

      this.Enabled = true;
      this.ProgressBar.Value = 0;
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
          if (item.Checked)
            item2.Checked = true;
          else
            item2.Checked = false;

          this.ColumnsList.Items.Insert(item.Index + 2, item2);
          item2.Selected = true;
          item2.Focused = true;
          this.ColumnsList.Focus();
          this.ColumnsList.Items.Remove(item);
          this.ColumnsList.EndUpdate();
        }
      }
    }

    private void btnPath_Click(object sender, EventArgs e)
    {
      this.SaveFileDialog.InitialDirectory = this.txtPath.Text;
      this.SaveFileDialog.Filter = "All files|*.*";

      if (this.SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        string str = this.SaveFileDialog.FileName.Trim(new char[] { ' ' });
        this.txtPath.Text = str;
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
          if (item.Checked)
            item2.Checked = true;
          else
            item2.Checked = false;

          this.ColumnsList.Items.Insert(item.Index - 1, item2);
          item2.Selected = true;
          item2.Focused = true;
          this.ColumnsList.Focus();
          this.ColumnsList.Items.Remove(item);
          this.ColumnsList.EndUpdate();
        }
      }
    }

    private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.cmbWidth.Text, "px", false) == 0)
      {
        this.txtWidth.Minimum = decimal.Zero;
        this.txtWidth.Maximum = 4096M;
        this.txtWidth.Value = 600M;
      }
      else
      {
        this.txtWidth.Value = 80M;
        this.txtWidth.Minimum = decimal.Zero;
        this.txtWidth.Maximum = 100M;
      }
    }

    private void frmLists_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      this.chkRelativ.Checked = Declarations.objSettings.PlaylistRelPath;
      this.txtExtInfo.Text = Declarations.objSettings.ListExtInfo;
      this.txtPath.Text = Declarations.objSettings.ListPath;
      this.txtTitleHTML.Text = Declarations.objSettings.HTMLListTitle;
      this.txtWidth.Text = Declarations.objSettings.HTMLListWidth;
      this.cmbWidth.Text = Declarations.objSettings.HTMLListWidthUnit;
      this.chkGridlines.Checked = Declarations.objSettings.HTMLGridlines;
      this.chkColor.Checked = Declarations.objSettings.HTMLColored;

      if (Declarations.objSettings.HTMLTAGVersion == 2)
        this.optID3V2.Checked = true;
      else
        this.optID3V2.Checked = false;

      if ((Declarations.objSettings.ListStyle & 1) == 1)
        this.chkCreateHTML.Checked = true;

      if ((Declarations.objSettings.ListStyle & 2) == 2)
        this.chkCreateCSV.Checked = true;

      string str = Declarations.objSettings.ListColumns + "-";

      foreach (ListViewItem item in this.ColumnsList.Items)
        if (str.IndexOf(item.Tag.ToString() + "-") > -1)
          item.Checked = true;

      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        if (StringType.StrCmp(this.vstrComparePath, "*", false) == 0)
          this.vstrComparePath = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "FI", new object[0], null, null), null, "DirectoryName", new object[0], null, null));

        if (ObjectType.ObjTst(this.vstrComparePath, LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "FI", new object[0], null, null), null, "DirectoryName", new object[0], null, null), false) != 0)
        {
          this.vstrComparePath = "*";
          break;
        }
      }

      if (StringType.StrCmp(this.vstrComparePath, "*", false) != 0)
        this.txtPath.Text = this.vstrComparePath + this.vstrComparePath.Substring(this.vstrComparePath.LastIndexOf(@"\"));

      DirectoryInfo info = new DirectoryInfo(this.vstrTemplatesPath);

      foreach (FileInfo info2 in info.GetFiles("*.itl"))
        this.TemplatesList.Items.Add(info2.Name);

      this.ProgressBar.Maximum = this.MainForm.MP3View.SelectedItems.Count;
      this.AddToolTips();
    }

    private void Label_Click(object sender, EventArgs e)
    {
      string selectedText = this.txtExtInfo.SelectedText;
      int selectionStart = this.txtExtInfo.SelectionStart;

      if (this.txtExtInfo.SelectionLength == 0)
      {
        this.txtExtInfo.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(this.txtExtInfo.Text.Substring(0, this.txtExtInfo.SelectionStart), LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 3 }, null, null)), this.txtExtInfo.Text.Substring(this.txtExtInfo.SelectionStart)));
        this.txtExtInfo.SelectionStart = selectionStart + 3;
      }
      else
      {
        string str2 = this.txtExtInfo.Text.Substring(0, selectionStart);
        this.txtExtInfo.Text = Strings.Replace(this.txtExtInfo.Text, selectedText, StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 3 }, null, null)), selectionStart + 1, 1, CompareMethod.Text);
        this.txtExtInfo.Text = str2 + this.txtExtInfo.Text;
        this.txtExtInfo.SelectionStart = selectionStart + 3;
      }
    }

    private void txtExtInfo_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '\\':
        case '|':
        case '"':
        case ';':
        case ',':
        case '*':
        case '?':
          e.Handled = true;
          this.txtExtInfo.SelectionStart = this.txtExtInfo.Text.Length;
          break;
      }
    }

    #endregion

    #region Class logic

    public void AddColumns()
    {
      int num;
      bool flag = false;
      this.ColumnsList.Columns.Add("Name", this.ColumnsList.Width - 0x19, HorizontalAlignment.Left);
      string[] array = Declarations.objSettings.ListColumns.Split(new char[] { '-' });
      int num2 = Declarations.objSettings.Columns.Rows.Count - 1;

      for (num = 0; num <= num2; num++)
      {
        DataRow row = Declarations.objSettings.Columns.Rows[num];
        ListViewItem item2 = new ListViewItem
        {
          Text = StringType.FromObject(Declarations.objResources.ResStrings["Col" + row["ID"].ToString().PadLeft(2, '0')])
        };

        if (Array.IndexOf(array, "Col" + row["ID"].ToString().PadLeft(2, '0')) > -1)
          item2.Checked = true;

        item2.Tag = RuntimeHelpers.GetObjectValue(row["ID"]);
        this.ColumnsList.Items.Add(item2);
      }

      num = 2;

      do
      {
        foreach (ListViewItem item in this.ColumnsList.Items)
        {
          if (ObjectType.ObjTst(item.Tag, num, false) == 0)
          {
            flag = true;
            break;
          }
        }

        if (!flag)
        {
          ListViewItem item3 = new ListViewItem(Convert.ToString(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["Col" + num.ToString().PadLeft(2, '0')])));

          if (Array.IndexOf(array, num.ToString()) > -1)
            item3.Checked = true;

          item3.Tag = num;
          this.ColumnsList.Items.Add(item3);
        }

        flag = false;
        num++;
      }

      while (num <= 0x17);
    }

    private void AddToolTips()
    {
      string vstrName = "frmLists";
      Control chkRelativ = this.chkRelativ;
      this.chkRelativ = (CheckBox)chkRelativ;
      this.ToolTip.SetToolTip(this.chkRelativ, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.btnPath;
      this.btnPath = (Button)chkRelativ;
      this.ToolTip.SetToolTip(this.btnPath, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.txtPath;
      this.txtPath = (TextBox)chkRelativ;
      this.ToolTip.SetToolTip(this.txtPath, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.chkColor;
      this.chkColor = (CheckBox)chkRelativ;
      this.ToolTip.SetToolTip(this.chkColor, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.chkGridlines;
      this.chkGridlines = (CheckBox)chkRelativ;
      this.ToolTip.SetToolTip(this.chkGridlines, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.txtWidth;
      this.txtWidth = (NumericUpDown)chkRelativ;
      this.ToolTip.SetToolTip(this.txtWidth, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.cmbWidth;
      this.cmbWidth = (ComboBox)chkRelativ;
      this.ToolTip.SetToolTip(this.cmbWidth, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.optID3V1;
      this.optID3V1 = (RadioButton)chkRelativ;
      this.ToolTip.SetToolTip(this.optID3V1, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.optID3V2;
      this.optID3V2 = (RadioButton)chkRelativ;
      this.ToolTip.SetToolTip(this.optID3V2, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.txtTitleHTML;
      this.txtTitleHTML = (TextBox)chkRelativ;
      this.ToolTip.SetToolTip(this.txtTitleHTML, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.ColumnsList;
      this.ColumnsList = (ListView)chkRelativ;
      this.ToolTip.SetToolTip(this.ColumnsList, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.btnUp;
      this.btnUp = (Button)chkRelativ;
      this.ToolTip.SetToolTip(this.btnUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));

      vstrName = "frmLists";
      chkRelativ = this.btnDown;
      this.btnDown = (Button)chkRelativ;
      this.ToolTip.SetToolTip(this.btnDown, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
    }

    private void CreateHTML(string vstrPath)
    {
      int vintNum = 0;
      HTMLList list = new HTMLList
      {
        TableWidth = this.txtWidth.Text + this.cmbWidth.Text
      };

      list.CreateHTMLFile(vstrPath, this.txtTitleHTML.Text + "   (created by <a href=" + "\"" + "http://www.id3-tagit.de" + "\"" + " target=_blank>ID3-TagIT </a> )");
      list.OpenGrid(this.chkGridlines.Checked);
      int count = this.ColumnsList.CheckedItems.Count;
      int num = 1;

      while (num <= count)
      {
        list.CellString((long)num, HTMLList.HTMLRowColor.HTMLRowGray, HTMLList.HTMLFontFormat.HTMLFontBold, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.ColumnsList.CheckedItems[num - 1].Text);
        num++;
      }

      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        vintNum++;

        int num4 = this.ColumnsList.CheckedItems.Count;

        for (num = 1; num <= num4; num++)
        {
          if (num == 1)
          {
            if (this.chkColor.Checked)
            {
              if (this.IsEven(vintNum))
                list.CellString((long)num, HTMLList.HTMLRowColor.HTMLRowGray, HTMLList.HTMLFontFormat.HTMLFontNormal, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)));
              else
                list.CellString((long)num, HTMLList.HTMLRowColor.HTMLRowWhite, HTMLList.HTMLFontFormat.HTMLFontNormal, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)));
            }
            else
              list.CellString((long)num, HTMLList.HTMLRowColor.HTMLRowWhite, HTMLList.HTMLFontFormat.HTMLFontNormal, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)));
          }
          else
            list.CellString((long)num, HTMLList.HTMLRowColor.HTMLRowWhite, HTMLList.HTMLFontFormat.HTMLFontNormal, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)));
        }

        this.ProgressBar.PerformStep();
      }

      list.CloseGrid();
      list.FinishHTMLFile();
      this.ProgressBar.Value = 0;
    }

    private void CreatePlaylist(string vstrPath)
    {
      StreamWriter writer = new StreamWriter(vstrPath, false, Encoding.Default);
      string vstrBaseDir = vstrPath.Substring(0, vstrPath.LastIndexOf(@"\"));
      writer.WriteLine("#EXTM3U");

      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        string str;
        MP3 tag = (MP3)item.Tag;
        string sLeft = "";

        if (tag.V2TAG.TAGHeaderPresent)
          sLeft = ID3Functions.FormatReplacedByTag(tag, this.txtExtInfo.Text.Trim(), 2);
        else if (tag.V1TAG.TAGPresent)
          sLeft = ID3Functions.FormatReplacedByTag(tag, this.txtExtInfo.Text.Trim(), 1);

        sLeft = sLeft.Trim();

        if (StringType.StrCmp(sLeft, "", false) != 0)
          str = "#EXTINF:" + StringType.FromInteger(tag.Duration) + "," + sLeft;
        else
          str = "#EXTINF:" + StringType.FromInteger(tag.Duration);

        writer.WriteLine(str);

        if (!this.chkRelativ.Checked)
          writer.WriteLine(tag.FI.FullName);
        else
          writer.WriteLine(Id3TagIT_Main.GetRelativePath(vstrBaseDir, tag.FI.FullName));

        this.ProgressBar.PerformStep();
      }

      writer.Flush();
      writer.Close();
      this.ProgressBar.Value = 0;
    }

    private string GetQuickData(ListViewItem lstItem, byte colID)
    {
      MP3 tag = (MP3)lstItem.Tag;

      switch (colID)
      {
        case 1:
          return tag.CurrentName;

        case 2:
          return StringType.FromObject(Interaction.IIf(Declarations.objSettings.CurrentPath.EndsWith(":"), tag.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath + @"\", ""), tag.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath, "")));

        case 3:
          return tag.V1TAG.TAGVersion.ToString().Replace("0", "-").Replace("1-", "1.0").Replace("11", "1.1");

        case 4:
          return tag.V2TAG.TAGVersion.ToString().Replace("2", "2.2").Replace("3", "2.3").Replace("4", "2.4").Replace("0", "-");

        case 5:
          if (!this.optID3V2.Checked)
            return tag.V1TAG.Artist;

          if (!tag.V2TAG.FrameExists("TPE1"))
            break;

          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPE1")), null, "Content", new object[0], null, null));

        case 6:
          if (!this.optID3V2.Checked)
            return tag.V1TAG.Title;

          if (!tag.V2TAG.FrameExists("TIT2"))
            break;

          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TIT2")), null, "Content", new object[0], null, null));

        case 7:
          if (!this.optID3V2.Checked)
            return tag.V1TAG.Album;

          if (!tag.V2TAG.FrameExists("TALB"))
            break;

          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TALB")), null, "Content", new object[0], null, null));

        case 8:
          if (!this.optID3V2.Checked)
            return tag.V1TAG.Tracknumber.ToString();

          if (!tag.V2TAG.FrameExists("TRCK"))
            break;

          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TRCK")), null, "Content", new object[0], null, null));

        case 9:
          if (!this.optID3V2.Checked || !tag.V2TAG.FrameExists("TPOS"))
            break;

          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPOS")), null, "Content", new object[0], null, null));

        case 10:
          if (!this.optID3V2.Checked)
            return tag.V1TAG.Comment;

          if (tag.V2TAG.FrameExists("COMM"))
          {
            var enumerator2 = tag.V2TAG.GetFrames("COMM").GetEnumerator();

            while (enumerator2.MoveNext())
              return LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator2.Current), null, "Content", new object[0], null, null).ToString();
          }

          break;

        case 11:
          if (!this.optID3V2.Checked)
            return tag.V1TAG.GenreText;

          if (!tag.V2TAG.FrameExists("TCON"))
            break;

          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCON")), null, "Content", new object[0], null, null));

        case 12:
          if (!this.optID3V2.Checked)
            return tag.V1TAG.Year.ToString();

          if (!tag.V2TAG.FrameExists("TYER"))
          {
            if (tag.V2TAG.FrameExists("TDRC"))
            {
              object objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TDRC"));

              try
              {
                return StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "SubString", new object[] { 0, 4 }, null, null));
              }
              catch (Exception exception1)
              {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
              }
            }

            break;
          }

          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TYER")), null, "Content", new object[0], null, null));

        case 13:
          if (this.optID3V2.Checked && tag.V2TAG.FrameExists("POPM"))
          {
            var enumerator = tag.V2TAG.GetFrames("POPM").GetEnumerator();

            while (enumerator.MoveNext())
              return LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator.Current), null, "Rating", new object[0], null, null).ToString();
          }

          break;

        case 14:
          return tag.DurationFormated;

        case 15:
          return StringType.FromInteger(tag.Bitrate);

        case 0x10:
          return StringType.FromObject(Interaction.IIf(tag.VBR, "VBR", "CBR"));

        case 0x11:
          return StringType.FromInteger(tag.Samplerate);

        case 0x12:
          return tag.ChannelText;

        case 0x13:
          return (tag.VersionText + " " + tag.LayerText);

        case 20:
          return tag.FI.LastWriteTime.ToString();

        case 0x15:
          if (!this.optID3V2.Checked || !tag.V2TAG.FrameExists("TCOM"))
            break;

          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCOM")), null, "Content", new object[0], null, null));

        case 0x16:
          {
            long num2 = tag.FI.Length / 0x400L;
            return num2.ToString();
          }

        case 0x17:
          {
            if (!this.optID3V2.Checked || !tag.V2TAG.FrameExists("TBPM"))
              break;

            string inputStr = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TBPM"), null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null));

            if (inputStr.Length < 4)
              return Conversion.Val(inputStr).ToString();

            double num = Conversion.Val(inputStr) / 100.0;
            return num.ToString();
          }
      }

      return "";
    }

    private string GetTempData(ListViewItem lstItem, string vstrVar, [Optional, DefaultParameterValue("")] string vstrPath)
    {
      string sLeft = vstrVar;
      MP3 tag = (MP3)lstItem.Tag;

      if (StringType.StrCmp(sLeft, "%Filename%", false) == 0)
        return tag.CurrentName;

      if (StringType.StrCmp(sLeft, "%FullFilename%", false) == 0)
        return tag.CurrentFullName;

      if (StringType.StrCmp(sLeft, "%Subdirectory%", false) == 0)
        return StringType.FromObject(Interaction.IIf(Declarations.objSettings.CurrentPath.EndsWith(":"), tag.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath + @"\", ""), tag.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath, "")));

      if (StringType.StrCmp(sLeft, "%Ver1%", false) == 0)
        return tag.V1TAG.TAGVersion.ToString().Replace("0", "-").Replace("1-", "1.0").Replace("11", "1.1");

      if (StringType.StrCmp(sLeft, "%Ver2%", false) == 0)
        return tag.V2TAG.TAGVersion.ToString().Replace("2", "2.2").Replace("3", "2.3").Replace("4", "2.4").Replace("0", "-");

      if (StringType.StrCmp(sLeft, "%Artist%", false) == 0)
      {
        if (!this.optID3V2.Checked)
          return tag.V1TAG.Artist;

        if (tag.V2TAG.FrameExists("TPE1"))
          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPE1")), null, "Content", new object[0], null, null));
      }
      else if (StringType.StrCmp(sLeft, "%Title%", false) == 0)
      {
        if (!this.optID3V2.Checked)
          return tag.V1TAG.Title;

        if (tag.V2TAG.FrameExists("TIT2"))
          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TIT2")), null, "Content", new object[0], null, null));
      }
      else if (StringType.StrCmp(sLeft, "%Album%", false) == 0)
      {
        if (!this.optID3V2.Checked)
          return tag.V1TAG.Album;

        if (tag.V2TAG.FrameExists("TALB"))
          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TALB")), null, "Content", new object[0], null, null));
      }
      else if (StringType.StrCmp(sLeft, "%Track%", false) == 0)
      {
        if (!this.optID3V2.Checked)
          return tag.V1TAG.Tracknumber.ToString();

        if (tag.V2TAG.FrameExists("TRCK"))
          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TRCK")), null, "Content", new object[0], null, null));
      }
      else if (StringType.StrCmp(sLeft, "%Position%", false) == 0)
      {
        if (this.optID3V2.Checked && tag.V2TAG.FrameExists("TPOS"))
          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPOS")), null, "Content", new object[0], null, null));
      }
      else if (StringType.StrCmp(sLeft, "%Comment%", false) == 0)
      {
        if (!this.optID3V2.Checked)
          return tag.V1TAG.Comment;

        if (tag.V2TAG.FrameExists("COMM"))
        {
          var enumerator2 = tag.V2TAG.GetFrames("COMM").GetEnumerator();

          while (enumerator2.MoveNext())
            return LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator2.Current), null, "Content", new object[0], null, null).ToString();
        }
      }
      else if (StringType.StrCmp(sLeft, "%Genre%", false) == 0)
      {
        if (!this.optID3V2.Checked)
          return tag.V1TAG.GenreText;

        if (tag.V2TAG.FrameExists("TCON"))
          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCON")), null, "Content", new object[0], null, null));
      }
      else if (StringType.StrCmp(sLeft, "%Year%", false) == 0)
      {
        if (!this.optID3V2.Checked)
          return tag.V1TAG.Year.ToString();

        if (tag.V2TAG.FrameExists("TYER"))
          return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TYER")), null, "Content", new object[0], null, null));

        if (tag.V2TAG.FrameExists("TDRC"))
        {
          object objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TDRC"));

          try
          {
            return StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "SubString", new object[] { 0, 4 }, null, null));
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
        }
      }
      else if (StringType.StrCmp(sLeft, "%Rating%", false) == 0)
      {
        if (this.optID3V2.Checked && tag.V2TAG.FrameExists("POPM"))
        {
          var enumerator = tag.V2TAG.GetFrames("POPM").GetEnumerator();

          while (enumerator.MoveNext())
            return LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator.Current), null, "Rating", new object[0], null, null).ToString();
        }
      }
      else
      {
        if (StringType.StrCmp(sLeft, "%Duration%", false) == 0)
          return tag.DurationFormated;

        if (StringType.StrCmp(sLeft, "%DurationSec%", false) == 0)
          return tag.Duration.ToString();

        if (StringType.StrCmp(sLeft, "%Bitrate%", false) == 0)
          return tag.Bitrate.ToString();

        if (StringType.StrCmp(sLeft, "%CBRVBR%", false) == 0)
          return StringType.FromObject(Interaction.IIf(tag.VBR, "VBR", "CBR"));

        if (StringType.StrCmp(sLeft, "%Samplerate%", false) == 0)
          return tag.Samplerate.ToString();

        if (StringType.StrCmp(sLeft, "%Channel%", false) == 0)
          return tag.ChannelText;

        if (StringType.StrCmp(sLeft, "%Version%", false) == 0)
          return (tag.VersionText + " " + tag.LayerText);

        if (StringType.StrCmp(sLeft, "%LastChanged%", false) == 0)
          return tag.FI.LastWriteTime.ToString();

        if (StringType.StrCmp(sLeft, "%Composer%", false) == 0)
        {
          if (this.optID3V2.Checked && tag.V2TAG.FrameExists("TCOM"))
            return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCOM")), null, "Content", new object[0], null, null));
        }
        else
        {
          if (StringType.StrCmp(sLeft, "%FileSize%", false) == 0)
          {
            long num2 = tag.FI.Length / 0x400L;
            return num2.ToString();
          }

          if (StringType.StrCmp(sLeft, "%BPM%", false) == 0)
          {
            if (this.optID3V2.Checked && tag.V2TAG.FrameExists("TBPM"))
            {
              string inputStr = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TBPM"), null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null));

              if (inputStr.Length >= 4)
              {
                double num = Conversion.Val(inputStr) / 100.0;
                return num.ToString();
              }

              return Conversion.Val(inputStr).ToString();
            }
          }
          else
          {
            if (StringType.StrCmp(sLeft, "%RelFilename%", false) == 0)
              return Id3TagIT_Main.GetRelativePath(vstrPath.Substring(0, vstrPath.LastIndexOf(@"\")), tag.FI.FullName);

            if (StringType.StrCmp(sLeft, "%CRC%", false) == 0)
            {
              if (tag.AudioCheckSum == 0)
                tag.CalcAudioCheckSum();

              if (tag.AudioCheckSum != 0)
                return tag.AudioCheckSum.ToString();

              return "";
            }
          }
        }
      }

      return "";
    }

    private bool IsEven(int vintNum)
    {
      return (vintNum % 2) == 0;
    }

    #endregion
  }
}