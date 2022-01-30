using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmSearch : Form
  {
    private Button btnClose;
    private Button btnReplace;
    private Button btnSelect;
    private CheckBox chkAlbum;
    private CheckBox chkArtist;
    private CheckBox chkCase;
    private CheckBox chkComment;
    private CheckBox chkFilename;
    private CheckBox chkGenre;
    private CheckBox chkRegExpress;
    private CheckBox chkSelected;
    private CheckBox chkTitle;
    private CheckBox chkTracknumber;
    private CheckBox chkVer1;
    private CheckBox chkVer2;
    private CheckBox chkYear;
    private GroupBox FrameMode;
    private GroupBox frameTAGOptions;
    private Label lblReplace;
    private Label lblSearch;
    private System.Windows.Forms.LinkLabel LinkLabel;
    private RadioButton optAND;
    private RadioButton optOR;
    private System.Windows.Forms.ProgressBar ProgressBar;
    private System.Windows.Forms.ToolTip ToolTip;
    private TextBox txtReplace;
    private TextBox txtSearch;
    private IContainer components;
    public frmMain MainForm;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblSearch = new System.Windows.Forms.Label();
      this.lblReplace = new System.Windows.Forms.Label();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.txtReplace = new System.Windows.Forms.TextBox();
      this.btnSelect = new System.Windows.Forms.Button();
      this.btnReplace = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.chkFilename = new System.Windows.Forms.CheckBox();
      this.chkVer1 = new System.Windows.Forms.CheckBox();
      this.chkVer2 = new System.Windows.Forms.CheckBox();
      this.FrameMode = new System.Windows.Forms.GroupBox();
      this.LinkLabel = new System.Windows.Forms.LinkLabel();
      this.chkRegExpress = new System.Windows.Forms.CheckBox();
      this.chkSelected = new System.Windows.Forms.CheckBox();
      this.chkCase = new System.Windows.Forms.CheckBox();
      this.optAND = new System.Windows.Forms.RadioButton();
      this.optOR = new System.Windows.Forms.RadioButton();
      this.frameTAGOptions = new System.Windows.Forms.GroupBox();
      this.chkArtist = new System.Windows.Forms.CheckBox();
      this.chkTitle = new System.Windows.Forms.CheckBox();
      this.chkAlbum = new System.Windows.Forms.CheckBox();
      this.chkTracknumber = new System.Windows.Forms.CheckBox();
      this.chkYear = new System.Windows.Forms.CheckBox();
      this.chkGenre = new System.Windows.Forms.CheckBox();
      this.chkComment = new System.Windows.Forms.CheckBox();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.FrameMode.SuspendLayout();
      this.frameTAGOptions.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblSearch
      // 
      this.lblSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblSearch.Location = new System.Drawing.Point(8, 8);
      this.lblSearch.Name = "lblSearch";
      this.lblSearch.Size = new System.Drawing.Size(96, 16);
      this.lblSearch.TabIndex = 0;
      this.lblSearch.Text = "&Search for:";
      // 
      // lblReplace
      // 
      this.lblReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblReplace.Location = new System.Drawing.Point(8, 34);
      this.lblReplace.Name = "lblReplace";
      this.lblReplace.Size = new System.Drawing.Size(96, 16);
      this.lblReplace.TabIndex = 0;
      this.lblReplace.Text = "&Replace by:";
      // 
      // txtSearch
      // 
      this.txtSearch.Location = new System.Drawing.Point(104, 6);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(384, 20);
      this.txtSearch.TabIndex = 1;
      // 
      // txtReplace
      // 
      this.txtReplace.Location = new System.Drawing.Point(104, 32);
      this.txtReplace.Name = "txtReplace";
      this.txtReplace.Size = new System.Drawing.Size(384, 20);
      this.txtReplace.TabIndex = 1;
      // 
      // btnSelect
      // 
      this.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnSelect.Location = new System.Drawing.Point(8, 320);
      this.btnSelect.Name = "btnSelect";
      this.btnSelect.Size = new System.Drawing.Size(144, 24);
      this.btnSelect.TabIndex = 3;
      this.btnSelect.Text = "Search and S&elect";
      this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
      // 
      // btnReplace
      // 
      this.btnReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnReplace.Location = new System.Drawing.Point(176, 320);
      this.btnReplace.Name = "btnReplace";
      this.btnReplace.Size = new System.Drawing.Size(144, 24);
      this.btnReplace.TabIndex = 3;
      this.btnReplace.Text = "Search and Re&place";
      this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnClose.Location = new System.Drawing.Point(376, 320);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(112, 24);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Clo&se";
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // chkFilename
      // 
      this.chkFilename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkFilename.Location = new System.Drawing.Point(16, 64);
      this.chkFilename.Name = "chkFilename";
      this.chkFilename.Size = new System.Drawing.Size(144, 16);
      this.chkFilename.TabIndex = 7;
      this.chkFilename.Text = "Search in &Filename";
      // 
      // chkVer1
      // 
      this.chkVer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkVer1.Location = new System.Drawing.Point(176, 64);
      this.chkVer1.Name = "chkVer1";
      this.chkVer1.Size = new System.Drawing.Size(152, 16);
      this.chkVer1.TabIndex = 10;
      this.chkVer1.Text = "Search in TAG Ver. &1";
      this.chkVer1.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
      // 
      // chkVer2
      // 
      this.chkVer2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkVer2.Location = new System.Drawing.Point(336, 64);
      this.chkVer2.Name = "chkVer2";
      this.chkVer2.Size = new System.Drawing.Size(152, 16);
      this.chkVer2.TabIndex = 9;
      this.chkVer2.Text = "Search in TAG Ver. &2";
      this.chkVer2.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
      // 
      // FrameMode
      // 
      this.FrameMode.Controls.Add(this.LinkLabel);
      this.FrameMode.Controls.Add(this.chkRegExpress);
      this.FrameMode.Controls.Add(this.chkSelected);
      this.FrameMode.Controls.Add(this.chkCase);
      this.FrameMode.Controls.Add(this.optAND);
      this.FrameMode.Controls.Add(this.optOR);
      this.FrameMode.Location = new System.Drawing.Point(8, 96);
      this.FrameMode.Name = "FrameMode";
      this.FrameMode.Size = new System.Drawing.Size(480, 96);
      this.FrameMode.TabIndex = 11;
      this.FrameMode.TabStop = false;
      this.FrameMode.Text = "Search options";
      // 
      // LinkLabel
      // 
      this.LinkLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.LinkLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 50);
      this.LinkLabel.Location = new System.Drawing.Point(208, 72);
      this.LinkLabel.Name = "LinkLabel";
      this.LinkLabel.Size = new System.Drawing.Size(264, 16);
      this.LinkLabel.TabIndex = 18;
      this.LinkLabel.TabStop = true;
      this.LinkLabel.Text = "http://www.regular-expressions.info/reference.html";
      this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
      // 
      // chkRegExpress
      // 
      this.chkRegExpress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkRegExpress.Location = new System.Drawing.Point(8, 72);
      this.chkRegExpress.Name = "chkRegExpress";
      this.chkRegExpress.Size = new System.Drawing.Size(192, 16);
      this.chkRegExpress.TabIndex = 17;
      this.chkRegExpress.Text = "&Use regular expressions";
      // 
      // chkSelected
      // 
      this.chkSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkSelected.Location = new System.Drawing.Point(8, 48);
      this.chkSelected.Name = "chkSelected";
      this.chkSelected.Size = new System.Drawing.Size(208, 16);
      this.chkSelected.TabIndex = 16;
      this.chkSelected.Text = "Search selected files only";
      // 
      // chkCase
      // 
      this.chkCase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkCase.Location = new System.Drawing.Point(8, 24);
      this.chkCase.Name = "chkCase";
      this.chkCase.Size = new System.Drawing.Size(208, 16);
      this.chkCase.TabIndex = 15;
      this.chkCase.Text = "Search case sensitive";
      // 
      // optAND
      // 
      this.optAND.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAND.Location = new System.Drawing.Point(224, 24);
      this.optAND.Name = "optAND";
      this.optAND.Size = new System.Drawing.Size(248, 16);
      this.optAND.TabIndex = 3;
      this.optAND.Text = "Search AN&D (\'Search and Select\' only)";
      // 
      // optOR
      // 
      this.optOR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optOR.Location = new System.Drawing.Point(224, 48);
      this.optOR.Name = "optOR";
      this.optOR.Size = new System.Drawing.Size(248, 16);
      this.optOR.TabIndex = 2;
      this.optOR.Text = "Search &OR  (\'Search and Select\' only)";
      // 
      // frameTAGOptions
      // 
      this.frameTAGOptions.Controls.Add(this.chkArtist);
      this.frameTAGOptions.Controls.Add(this.chkTitle);
      this.frameTAGOptions.Controls.Add(this.chkAlbum);
      this.frameTAGOptions.Controls.Add(this.chkTracknumber);
      this.frameTAGOptions.Controls.Add(this.chkYear);
      this.frameTAGOptions.Controls.Add(this.chkGenre);
      this.frameTAGOptions.Controls.Add(this.chkComment);
      this.frameTAGOptions.Location = new System.Drawing.Point(8, 200);
      this.frameTAGOptions.Name = "frameTAGOptions";
      this.frameTAGOptions.Size = new System.Drawing.Size(480, 88);
      this.frameTAGOptions.TabIndex = 12;
      this.frameTAGOptions.TabStop = false;
      this.frameTAGOptions.Text = "TAG fields to search in";
      // 
      // chkArtist
      // 
      this.chkArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkArtist.Location = new System.Drawing.Point(8, 16);
      this.chkArtist.Name = "chkArtist";
      this.chkArtist.Size = new System.Drawing.Size(128, 16);
      this.chkArtist.TabIndex = 20;
      this.chkArtist.Text = "&Artist";
      // 
      // chkTitle
      // 
      this.chkTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkTitle.Location = new System.Drawing.Point(8, 40);
      this.chkTitle.Name = "chkTitle";
      this.chkTitle.Size = new System.Drawing.Size(128, 16);
      this.chkTitle.TabIndex = 22;
      this.chkTitle.Text = "&Title";
      // 
      // chkAlbum
      // 
      this.chkAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkAlbum.Location = new System.Drawing.Point(8, 64);
      this.chkAlbum.Name = "chkAlbum";
      this.chkAlbum.Size = new System.Drawing.Size(128, 16);
      this.chkAlbum.TabIndex = 21;
      this.chkAlbum.Text = "Al&bum";
      // 
      // chkTracknumber
      // 
      this.chkTracknumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkTracknumber.Location = new System.Drawing.Point(328, 16);
      this.chkTracknumber.Name = "chkTracknumber";
      this.chkTracknumber.Size = new System.Drawing.Size(136, 16);
      this.chkTracknumber.TabIndex = 17;
      this.chkTracknumber.Text = "Trac&knumber";
      // 
      // chkYear
      // 
      this.chkYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkYear.Location = new System.Drawing.Point(168, 64);
      this.chkYear.Name = "chkYear";
      this.chkYear.Size = new System.Drawing.Size(144, 16);
      this.chkYear.TabIndex = 16;
      this.chkYear.Text = "&Year";
      // 
      // chkGenre
      // 
      this.chkGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkGenre.Location = new System.Drawing.Point(168, 16);
      this.chkGenre.Name = "chkGenre";
      this.chkGenre.Size = new System.Drawing.Size(144, 16);
      this.chkGenre.TabIndex = 19;
      this.chkGenre.Text = "&Genre (Ver. 2 only)";
      // 
      // chkComment
      // 
      this.chkComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkComment.Location = new System.Drawing.Point(168, 40);
      this.chkComment.Name = "chkComment";
      this.chkComment.Size = new System.Drawing.Size(144, 16);
      this.chkComment.TabIndex = 18;
      this.chkComment.Text = "&Comment";
      // 
      // ProgressBar
      // 
      this.ProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ProgressBar.Location = new System.Drawing.Point(8, 296);
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Size = new System.Drawing.Size(480, 16);
      this.ProgressBar.Step = 25;
      this.ProgressBar.TabIndex = 13;
      // 
      // frmSearch
      // 
      this.AcceptButton = this.btnSelect;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(498, 350);
      this.ControlBox = false;
      this.Controls.Add(this.ProgressBar);
      this.Controls.Add(this.frameTAGOptions);
      this.Controls.Add(this.FrameMode);
      this.Controls.Add(this.chkVer1);
      this.Controls.Add(this.chkVer2);
      this.Controls.Add(this.chkFilename);
      this.Controls.Add(this.btnSelect);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.txtReplace);
      this.Controls.Add(this.lblSearch);
      this.Controls.Add(this.lblReplace);
      this.Controls.Add(this.btnReplace);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmSearch";
      this.ShowInTaskbar = false;
      this.Text = "Search and Replace";
      this.FrameMode.ResumeLayout(false);
      this.frameTAGOptions.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public frmSearch()
    {
      base.Load += new EventHandler(this.frmSearch_Load);
      this.InitializeComponent();
    }

    private void AddToolTips()
    {
      string vstrName = "frmSearch";
      Control txtSearch = this.txtSearch;
      this.txtSearch = (TextBox)txtSearch;
      this.ToolTip.SetToolTip(this.txtSearch, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.txtReplace;
      this.txtReplace = (TextBox)txtSearch;
      this.ToolTip.SetToolTip(this.txtReplace, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.btnSelect;
      this.btnSelect = (Button)txtSearch;
      this.ToolTip.SetToolTip(this.btnSelect, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.btnReplace;
      this.btnReplace = (Button)txtSearch;
      this.ToolTip.SetToolTip(this.btnReplace, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkFilename;
      this.chkFilename = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkFilename, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkVer1;
      this.chkVer1 = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkVer1, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkVer2;
      this.chkVer2 = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkVer2, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkRegExpress;
      this.chkRegExpress = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkRegExpress, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkSelected;
      this.chkSelected = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkSelected, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkCase;
      this.chkCase = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkCase, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.optAND;
      this.optAND = (RadioButton)txtSearch;
      this.ToolTip.SetToolTip(this.optAND, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.optOR;
      this.optOR = (RadioButton)txtSearch;
      this.ToolTip.SetToolTip(this.optOR, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkArtist;
      this.chkArtist = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkArtist, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkTitle;
      this.chkTitle = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkTitle, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkAlbum;
      this.chkAlbum = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkTracknumber;
      this.chkTracknumber = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkTracknumber, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkYear;
      this.chkYear = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkYear, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkGenre;
      this.chkGenre = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkGenre, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
      vstrName = "frmSearch";
      txtSearch = this.chkComment;
      this.chkComment = (CheckBox)txtSearch;
      this.ToolTip.SetToolTip(this.chkComment, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      Declarations.objSettings.SearchSearchText = this.txtSearch.Text;
      Declarations.objSettings.SearchReplaceText = this.txtReplace.Text;
      Declarations.objSettings.SearchVer1 = this.chkVer1.Checked;
      Declarations.objSettings.SearchVer2 = this.chkVer2.Checked;
      Declarations.objSettings.SearchRegExpression = this.chkRegExpress.Checked;
      Declarations.objSettings.SearchCase = this.chkCase.Checked;
      Declarations.objSettings.SearchSelected = this.chkSelected.Checked;
      Declarations.objSettings.SearchAndOr = this.optAND.Checked;
      Declarations.objSettings.SearchFilename = this.chkFilename.Checked;
      Declarations.objSettings.SearchArtist = this.chkArtist.Checked;
      Declarations.objSettings.SearchTitle = this.chkTitle.Checked;
      Declarations.objSettings.SearchAlbum = this.chkAlbum.Checked;
      Declarations.objSettings.SearchComment = this.chkComment.Checked;
      Declarations.objSettings.SearchYear = this.chkYear.Checked;
      Declarations.objSettings.SearchGenre = this.chkGenre.Checked;
      Declarations.objSettings.SearchTracknumber = this.chkTracknumber.Checked;
      this.Close();
    }

    private void btnReplace_Click(object sender, EventArgs e)
    {
      ArrayList uNDO = new ArrayList();
      int num = 0;
      if (((this.chkFilename.Checked | this.chkVer1.Checked) | this.chkVer2.Checked) && !(!((((((this.chkArtist.Checked | this.chkTitle.Checked) | this.chkAlbum.Checked) | this.chkComment.Checked) | this.chkYear.Checked) | this.chkTracknumber.Checked) | this.chkGenre.Checked) & !this.chkFilename.Checked))
      {
        string text = this.txtSearch.Text;
        string str = this.txtReplace.Text;
        if (!BooleanType.FromObject(ObjectType.BitOrObj(StringType.StrCmp(text, "", false) == 0, Interaction.IIf(this.chkCase.Checked, text.Equals(str), text.ToLower().Equals(str.ToLower())))))
        {
          if (!this.chkRegExpress.Checked)
          {
            text = Regex.Escape(text);
          }
          else
          {
            try
            {
              Regex.IsMatch("Test", text, RegexOptions.None);
            }
            catch (Exception exception1)
            {
              ProjectData.SetProjectError(exception1);
              Exception exception = exception1;
              Interaction.MsgBox(exception.Message, MsgBoxStyle.ApplicationModal, null);
              ProjectData.ClearProjectError();
              return;
            }
          }
          if (!BooleanType.FromObject(ObjectType.BitOrObj(StringType.StrCmp(text, "", false) == 0, Interaction.IIf(this.chkCase.Checked, text.Equals(str), text.ToLower().Equals(str.ToLower())))))
          {
            this.btnSelect.Enabled = false;
            this.btnReplace.Enabled = false;
            this.btnClose.Enabled = false;
            Application.DoEvents();
            this.MainForm.MP3View.BeginUpdate();
            if (!this.chkSelected.Checked)
            {
              this.ProgressBar.Maximum = this.MainForm.MP3View.Items.Count;
              foreach (ListViewItem item in this.MainForm.MP3View.Items)
              {
                num++;
                this.SR(item, ref text, ref str, ref uNDO);
                if ((num % 0x19) == 0)
                {
                  this.ProgressBar.PerformStep();
                }
              }
            }
            else
            {
              this.ProgressBar.Maximum = this.MainForm.MP3View.SelectedItems.Count;
              foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
              {
                num++;
                this.SR(item, ref text, ref str, ref uNDO);
                if ((num % 0x19) == 0)
                {
                  this.ProgressBar.PerformStep();
                }
              }
            }
            this.ProgressBar.Value = this.ProgressBar.Maximum;
            this.MainForm.MP3View.EndUpdate();
            this.btnSelect.Enabled = true;
            this.btnReplace.Enabled = true;
            this.btnClose.Enabled = true;
            this.ProgressBar.Value = 0;
            if (uNDO.Count > 0)
            {
              Declarations.UNDOList.Add(uNDO);
              this.MainForm.UnDoEnable(true, true);
            }
          }
        }
      }
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
      if (((this.chkFilename.Checked | this.chkVer1.Checked) | this.chkVer2.Checked) && ((((((this.chkArtist.Checked | this.chkTitle.Checked) | this.chkAlbum.Checked) | this.chkComment.Checked) | this.chkYear.Checked) | this.chkTracknumber.Checked) | this.chkGenre.Checked))
      {
        string text = this.txtSearch.Text;
        if (StringType.StrCmp(text, "", false) != 0)
        {
          if (!this.chkRegExpress.Checked)
          {
            text = Regex.Escape(text);
          }
          else
          {
            try
            {
              Regex.IsMatch("Test", text, RegexOptions.None);
            }
            catch (Exception exception1)
            {
              ProjectData.SetProjectError(exception1);
              Exception exception = exception1;
              Interaction.MsgBox(exception.Message, MsgBoxStyle.ApplicationModal, null);
              ProjectData.ClearProjectError();
              return;
            }
          }
          if (!this.chkSelected.Checked)
          {
            foreach (ListViewItem item in this.MainForm.MP3View.Items)
              this.SearchSelect(item, ref text);
          }
          else
          {
            foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
              this.SearchSelect(item, ref text);
          }
          try
          {
            if (this.MainForm.MP3View.FocusedItem == null)
              this.MainForm.MP3View.SelectedItems[0].Focused = true;
          }
          catch (Exception exception2)
          {
            ProjectData.SetProjectError(exception2);
            ProjectData.ClearProjectError();
          }
        }
      }
    }

    private void chkVer_CheckedChanged(object sender, EventArgs e)
    {
      this.frameTAGOptions.Enabled = this.chkVer1.Checked | this.chkVer2.Checked;
      if (Declarations.objSettings.SynchronizeTAGs)
      {
        if (sender == this.chkVer1)
        {
          if (this.chkVer1.Checked)
          {
            this.chkVer2.Checked = true;
          }
          else
          {
            this.chkVer2.Checked = false;
          }
          if (this.chkVer2.Checked)
          {
            this.chkVer1.Checked = true;
          }
          else
          {
            this.chkVer1.Checked = false;
          }
        }
        else
        {
          if (this.chkVer2.Checked)
          {
            this.chkVer1.Checked = true;
          }
          else
          {
            this.chkVer1.Checked = false;
          }
          if (this.chkVer1.Checked)
          {
            this.chkVer2.Checked = true;
          }
          else
          {
            this.chkVer2.Checked = false;
          }
        }
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

    private void frmSearch_Load(object sender, EventArgs e)
    {
      this.Owner = this.MainForm;
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
      this.txtSearch.Text = Declarations.objSettings.SearchSearchText;
      this.txtReplace.Text = Declarations.objSettings.SearchReplaceText;
      this.chkVer1.Checked = Declarations.objSettings.SearchVer1;
      this.chkVer2.Checked = Declarations.objSettings.SearchVer2;
      this.chkRegExpress.Checked = Declarations.objSettings.SearchRegExpression;
      this.chkCase.Checked = Declarations.objSettings.SearchCase;
      this.chkSelected.Checked = Declarations.objSettings.SearchSelected;
      this.optAND.Checked = Declarations.objSettings.SearchAndOr;
      this.optOR.Checked = !Declarations.objSettings.SearchAndOr;
      this.chkFilename.Checked = Declarations.objSettings.SearchFilename;
      this.chkArtist.Checked = Declarations.objSettings.SearchArtist;
      this.chkTitle.Checked = Declarations.objSettings.SearchTitle;
      this.chkAlbum.Checked = Declarations.objSettings.SearchAlbum;
      this.chkComment.Checked = Declarations.objSettings.SearchComment;
      this.chkYear.Checked = Declarations.objSettings.SearchYear;
      this.chkGenre.Checked = Declarations.objSettings.SearchGenre;
      this.chkTracknumber.Checked = Declarations.objSettings.SearchTracknumber;
      this.frameTAGOptions.Enabled = this.chkVer1.Checked | this.chkVer2.Checked;
      this.AddToolTips();
    }

    private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(this.LinkLabel.Text);
    }

    private void SearchSelect(ListViewItem lstItem, ref string vstrSearchString)
    {
      MP3 mp2;
      bool flag;
      RegexOptions none = RegexOptions.None;

      if (!this.chkCase.Checked)
        none |= RegexOptions.IgnoreCase;

      if (!this.optOR.Checked)
      {
        mp2 = (MP3)lstItem.Tag;
        lstItem.Selected = false;
        flag = false;
        if (this.chkFilename.Checked)
        {
          if (!Regex.IsMatch(mp2.CurrentName, vstrSearchString, none))
            flag = true;
          else if (!((((((this.chkArtist.Checked | this.chkTitle.Checked) | this.chkAlbum.Checked) | this.chkComment.Checked) | this.chkYear.Checked) | this.chkTracknumber.Checked) | this.chkGenre.Checked))
            lstItem.Selected = true;
        }
        flag = false;
        if ((this.chkVer1.Checked & mp2.V1TAG.TAGPresent) & !flag)
        {
          if ((!flag && this.chkArtist.Checked) && !Regex.IsMatch(mp2.V1TAG.Artist, vstrSearchString, none))
            flag = true;
          if ((!flag && this.chkTitle.Checked) && !Regex.IsMatch(mp2.V1TAG.Title, vstrSearchString, none))
            flag = true;
          if ((!flag && this.chkAlbum.Checked) && !Regex.IsMatch(mp2.V1TAG.Album, vstrSearchString, none))
            flag = true;
          if ((!flag && this.chkComment.Checked) && !Regex.IsMatch(mp2.V1TAG.Comment, vstrSearchString, none))
            flag = true;
          if (!flag && this.chkYear.Checked)
          {
            if (!Regex.IsMatch(mp2.V1TAG.Year.ToString(), vstrSearchString, none))
              flag = true;
            if (mp2.V1TAG.Year <= 0)
              flag = true;
          }
          if (!flag && this.chkTracknumber.Checked)
          {
            if (!Regex.IsMatch(mp2.V1TAG.Tracknumber.ToString(), vstrSearchString, none))
              flag = true;
            if (mp2.V1TAG.Tracknumber <= 0)
              flag = true;
          }
          if ((!flag && this.chkGenre.Checked) && !Regex.IsMatch(mp2.V1TAG.GenreText, vstrSearchString, none))
            flag = true;
          if (!flag)
            lstItem.Selected = true;
        }
        flag = false;
        if (!((this.chkVer2.Checked & mp2.V2TAG.TAGHeaderPresent) & !flag))
          return;
        if (!flag && this.chkArtist.Checked)
        {
          flag = true;
          if (mp2.V2TAG.FrameExists("TPE1") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null)), vstrSearchString, none))
            flag = false;
        }
        if (!flag && this.chkTitle.Checked)
        {
          flag = true;
          if (mp2.V2TAG.FrameExists("TIT2") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null)), vstrSearchString, none))
            flag = false;
        }
        if (!flag && this.chkAlbum.Checked)
        {
          flag = true;
          if (mp2.V2TAG.FrameExists("TALB") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null)), vstrSearchString, none))
            flag = false;
        }
        if (!flag && this.chkComment.Checked)
        {
          flag = true;
          foreach (var frameItem in mp2.V2TAG.GetFrames("COMM"))
          {
            if (Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(frameItem), null, "Content", new object[0], null, null)), vstrSearchString, none))
            {
              flag = false;
              goto Label_0941;
            }
          }
        }
        goto Label_0941;
      }
      MP3 tag = (MP3)lstItem.Tag;
      flag = false;
      lstItem.Selected = false;
      if (this.chkFilename.Checked && Regex.IsMatch(tag.CurrentName, vstrSearchString, none))
      {
        lstItem.Selected = true;
        flag = true;
      }
      if ((this.chkVer1.Checked & tag.V1TAG.TAGPresent) & !flag)
      {
        if ((!flag && this.chkArtist.Checked) && Regex.IsMatch(tag.V1TAG.Artist, vstrSearchString, none))
        {
          lstItem.Selected = true;
          flag = true;
        }
        if ((!flag && this.chkTitle.Checked) && Regex.IsMatch(tag.V1TAG.Title, vstrSearchString, none))
        {
          lstItem.Selected = true;
          flag = true;
        }
        if ((!flag && this.chkAlbum.Checked) && Regex.IsMatch(tag.V1TAG.Album, vstrSearchString, none))
        {
          lstItem.Selected = true;
          flag = true;
        }
        if ((!flag && this.chkComment.Checked) && Regex.IsMatch(tag.V1TAG.Comment, vstrSearchString, none))
        {
          lstItem.Selected = true;
          flag = true;
        }
        if (((!flag && this.chkYear.Checked) & (tag.V1TAG.Year > 0)) && Regex.IsMatch(tag.V1TAG.Year.ToString(), vstrSearchString, none))
        {
          lstItem.Selected = true;
          flag = true;
        }
        if (((!flag && this.chkTracknumber.Checked) & (tag.V1TAG.Tracknumber > 0)) && Regex.IsMatch(tag.V1TAG.Tracknumber.ToString(), vstrSearchString, none))
        {
          lstItem.Selected = true;
          flag = true;
        }
        if ((!flag && this.chkGenre.Checked) && Regex.IsMatch(tag.V1TAG.GenreText, vstrSearchString, none))
        {
          lstItem.Selected = true;
          flag = true;
        }
      }
      if (!((this.chkVer2.Checked & tag.V2TAG.TAGHeaderPresent) & !flag))
        return;
      if ((!flag && this.chkArtist.Checked) && (tag.V2TAG.FrameExists("TPE1") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null)), vstrSearchString, none)))
      {
        lstItem.Selected = true;
        flag = true;
      }
      if ((!flag && this.chkTitle.Checked) && (tag.V2TAG.FrameExists("TIT2") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null)), vstrSearchString, none)))
      {
        lstItem.Selected = true;
        flag = true;
      }
      if ((!flag && this.chkAlbum.Checked) && (tag.V2TAG.FrameExists("TALB") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null)), vstrSearchString, none)))
      {
        lstItem.Selected = true;
        flag = true;
      }
      if (!flag && this.chkComment.Checked)
      {
        foreach (var frameItem in tag.V2TAG.GetFrames("COMM"))
        {
          if (Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(frameItem), null, "Content", new object[0], null, null)), vstrSearchString, none))
          {
            lstItem.Selected = true;
            flag = true;
            goto Label_03CB;
          }
        }
      }
      Label_03CB:
      if (!flag && this.chkYear.Checked)
      {
        if (tag.V2TAG.FrameExists("TYER") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null)), vstrSearchString, none))
        {
          lstItem.Selected = true;
          flag = true;
        }
        if (tag.V2TAG.FrameExists("TDRC"))
        {
          try
          {
            if (Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TDRC"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 4 }, null, null)), vstrSearchString, none))
            {
              lstItem.Selected = true;
              flag = true;
            }
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
        }
      }
      if ((!flag && this.chkTracknumber.Checked) && (tag.V2TAG.FrameExists("TRCK") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null)), vstrSearchString, none)))
      {
        lstItem.Selected = true;
        flag = true;
      }
      if ((!flag && this.chkGenre.Checked) && (tag.V2TAG.FrameExists("TCON") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null)), vstrSearchString, none)))
      {
        lstItem.Selected = true;
        flag = true;
      }
      return;
      Label_0941:
      if (!flag && this.chkYear.Checked)
      {
        flag = true;
        if (mp2.V2TAG.FrameExists("TYER") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null)), vstrSearchString, none))
        {
          flag = false;
        }
        if (mp2.V2TAG.FrameExists("TDRC"))
        {
          try
          {
            if (Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(mp2.V2TAG.GetFrame("TDRC"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 4 }, null, null)), vstrSearchString, none))
            {
              flag = false;
            }
          }
          catch (Exception exception2)
          {
            ProjectData.SetProjectError(exception2);
            ProjectData.ClearProjectError();
          }
        }
      }
      if (!flag && this.chkTracknumber.Checked)
      {
        flag = true;
        if (mp2.V2TAG.FrameExists("TRCK") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null)), vstrSearchString, none))
        {
          flag = false;
        }
      }
      if (!flag && this.chkGenre.Checked)
      {
        flag = true;
        if (mp2.V2TAG.FrameExists("TCON") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null)), vstrSearchString, none))
        {
          flag = false;
        }
      }
      if (!flag)
      {
        lstItem.Selected = true;
      }
    }

    private void SR(ListViewItem lstItem, ref string vstrSearchString, ref string vstrReplaceString, ref ArrayList UNDO)
    {
      bool flag2 = false;
      string str = "";
      bool flag = false;
      RegexOptions none = RegexOptions.None;
      if (!this.chkCase.Checked)
      {
        none |= RegexOptions.IgnoreCase;
      }
      MP3 tag = (MP3)lstItem.Tag;
      Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)lstItem.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(lstItem.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(lstItem.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(lstItem.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(lstItem.Tag, null, "Changed", new object[0], null, null)));
      if (this.chkFilename.Checked)
      {
        str = Regex.Replace(tag.CurrentName, vstrSearchString, vstrReplaceString, none).Replace("<", "_").Replace(">", "_").Replace("|", "_").Replace("\"", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace(":", "_").Replace(@"\", "_");
        if (str.Length > 0xff)
        {
          ListViewItem item2 = new ListViewItem
          {
            Text = StringType.FromObject(LateBinding.LateGet(lstItem.Tag, null, "CurrentFullName", new object[0], null, null)),
            SubItems = { Declarations.objResources.ResStrings["InvalidPathLength"].ToString() }
          };
          this.MainForm.ErrorMsg.Items.Insert(0, item2);
          this.MainForm.SplitterBottom.Expanded = true;
        }
        else
        {
          string newValue = tag.CurrentFullName.Substring(0, tag.CurrentFullName.LastIndexOf(@"\") + 1) + str + tag.FI.Extension;
          foreach (MP3 mp2 in Declarations.MP3s)
          {
            if ((StringType.StrCmp(newValue.ToLower(), mp2.CurrentFullName.ToLower(), false) == 0) && (mp2 != tag))
            {
              flag = true;
              break;
            }
          }
          if (!flag)
          {
            tag.CurrentName = str;
            flag2 = true;
            tag.Changed = true;
          }
          else
          {
            ListViewItem item = new ListViewItem
            {
              Text = tag.CurrentFullName,
              SubItems = { Declarations.objResources.ResStrings["FileAlreadyExistsRename"].ToString().Replace("%1", newValue).Replace("%2", tag.CurrentFullName).Replace("%C", "") }
            };
            this.MainForm.ErrorMsg.Items.Insert(0, item);
            this.MainForm.SplitterBottom.Expanded = true;
          }
        }
      }
      if (this.chkVer1.Checked & tag.V1TAG.TAGPresent)
      {
        if (this.chkArtist.Checked)
        {
          str = Regex.Replace(tag.V1TAG.Artist, vstrSearchString, vstrReplaceString, none);
          if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(tag.V1TAG.Artist), str.ToLower().Equals(tag.V1TAG.Artist.ToLower())))))
          {
            tag.V1TAG.Artist = str;
            flag2 = true;
            tag.Changed = true;
          }
        }
        if (this.chkTitle.Checked)
        {
          str = Regex.Replace(tag.V1TAG.Title, vstrSearchString, vstrReplaceString, none);
          if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(tag.V1TAG.Title), str.ToLower().Equals(tag.V1TAG.Title.ToLower())))))
          {
            tag.V1TAG.Title = str;
            flag2 = true;
            tag.Changed = true;
          }
        }
        if (this.chkAlbum.Checked)
        {
          str = Regex.Replace(tag.V1TAG.Album, vstrSearchString, vstrReplaceString, none);
          if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(tag.V1TAG.Album), str.ToLower().Equals(tag.V1TAG.Album.ToLower())))))
          {
            tag.V1TAG.Album = str;
            flag2 = true;
            tag.Changed = true;
          }
        }
        if (this.chkComment.Checked)
        {
          str = Regex.Replace(tag.V1TAG.Comment, vstrSearchString, vstrReplaceString, none);
          if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(tag.V1TAG.Comment), str.ToLower().Equals(tag.V1TAG.Comment.ToLower())))))
          {
            tag.V1TAG.Comment = str;
            flag2 = true;
            tag.Changed = true;
          }
        }
        if ((this.chkYear.Checked & (tag.V1TAG.Year > 0)) && Information.IsNumeric(vstrReplaceString))
        {
          try
          {
            str = Regex.Replace(tag.V1TAG.Year.ToString(), vstrSearchString, vstrReplaceString, none);
            if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(tag.V1TAG.Year.ToString()), str.ToLower().Equals(tag.V1TAG.Year.ToString().ToLower())))))
            {
              tag.V1TAG.Year = Convert.ToInt32(str);
              flag2 = true;
              tag.Changed = true;
            }
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
        }
        if ((this.chkTracknumber.Checked & (tag.V1TAG.Tracknumber > 0)) && Information.IsNumeric(vstrReplaceString))
        {
          try
          {
            str = Regex.Replace(tag.V1TAG.Tracknumber.ToString(), vstrSearchString, vstrReplaceString, none);
            if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(tag.V1TAG.Tracknumber.ToString()), str.ToLower().Equals(tag.V1TAG.Tracknumber.ToString().ToLower())))))
            {
              tag.V1TAG.Tracknumber = (byte)Convert.ToInt32(str);
              flag2 = true;
              tag.Changed = true;
            }
          }
          catch (Exception exception2)
          {
            ProjectData.SetProjectError(exception2);
            ProjectData.ClearProjectError();
          }
        }
      }
      if (this.chkVer2.Checked & tag.V2TAG.TAGHeaderPresent)
      {
        object objectValue;
        if (this.chkArtist.Checked && tag.V2TAG.FrameExists("TPE1"))
        {
          objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPE1"));
          str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, vstrReplaceString, none);
          if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))), str.ToLower().Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null)))))))
          {
            LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
            flag2 = true;
            tag.Changed = true;
          }
        }
        if (this.chkTitle.Checked && tag.V2TAG.FrameExists("TIT2"))
        {
          objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TIT2"));
          str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, vstrReplaceString, none);
          if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))), str.ToLower().Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null)))))))
          {
            LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
            flag2 = true;
            tag.Changed = true;
          }
        }
        if (this.chkAlbum.Checked && tag.V2TAG.FrameExists("TALB"))
        {
          objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TALB"));
          str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, vstrReplaceString, none);
          if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))), str.ToLower().Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null)))))))
          {
            LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
            flag2 = true;
            tag.Changed = true;
          }
        }
        if (this.chkComment.Checked)
        {
          foreach (var frameItem in tag.V2TAG.GetFrames("COMM"))
          {
            objectValue = RuntimeHelpers.GetObjectValue(frameItem);
            str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, vstrReplaceString, none);
            if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))), str.ToLower().Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null)))))))
            {
              LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
              flag2 = true;
              tag.Changed = true;
            }
          }
        }
        if (this.chkYear.Checked & Information.IsNumeric(vstrReplaceString))
        {
          if (tag.V2TAG.FrameExists("TYER"))
          {
            objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TYER"));
            if ((Information.IsNumeric(vstrReplaceString) & (Conversion.Val((string)vstrReplaceString) > 1000.0)) & (Conversion.Val((string)vstrReplaceString) < 10000.0))
            {
              str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, Math.Floor(Conversion.Val((string)vstrReplaceString)).ToString(), none);
              if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))), str.ToLower().Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null)))))))
              {
                LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
                flag2 = true;
                tag.Changed = true;
              }
            }
          }
          if (tag.V2TAG.FrameExists("TDRC"))
          {
            objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TDRC"));
            if ((Information.IsNumeric(vstrReplaceString) & (Conversion.Val((string)vstrReplaceString) > 1000.0)) & (Conversion.Val((string)vstrReplaceString) < 10000.0))
            {
              str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, Math.Floor(Conversion.Val((string)vstrReplaceString)).ToString(), none);
              if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))), str.ToLower().Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null)))))))
              {
                LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
                flag2 = true;
                tag.Changed = true;
              }
            }
          }
        }
        if ((this.chkTracknumber.Checked & (Information.IsNumeric(vstrReplaceString) | (StringType.StrCmp(vstrReplaceString, "", false) == 0))) && tag.V2TAG.FrameExists("TRCK"))
        {
          objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TRCK"));
          if (StringType.StrCmp(vstrReplaceString, "", false) == 0)
          {
            str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, vstrReplaceString, none);
            LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
            if (StringType.StrCmp(str, "", false) == 0)
            {
              tag.V2TAG.RemoveFrame("TRCK");
            }
            flag2 = true;
            tag.Changed = true;
          }
          else if (Conversion.Val((string)vstrReplaceString) >= 0.0)
          {
            str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, Math.Floor(Conversion.Val((string)vstrReplaceString)).ToString(), none);
            LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
            flag2 = true;
            tag.Changed = true;
          }
        }
        if (this.chkGenre.Checked && tag.V2TAG.FrameExists("TCON"))
        {
          objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCON"));
          str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, vstrReplaceString, none);
          if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))), str.ToLower().Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null)))))))
          {
            LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
            flag2 = true;
            tag.Changed = true;
          }
        }
      }
      if (flag2)
      {
        UNDO.Add(@do);
        this.MainForm.UpdateListItem(lstItem, false);
      }
    }
  }
}