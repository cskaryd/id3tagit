namespace ID3_TagIT
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public class frmSearch : Form
    {
        [AccessedThroughProperty("btnClose")]
        private Button _btnClose;
        [AccessedThroughProperty("btnReplace")]
        private Button _btnReplace;
        [AccessedThroughProperty("btnSelect")]
        private Button _btnSelect;
        [AccessedThroughProperty("chkAlbum")]
        private CheckBox _chkAlbum;
        [AccessedThroughProperty("chkArtist")]
        private CheckBox _chkArtist;
        [AccessedThroughProperty("chkCase")]
        private CheckBox _chkCase;
        [AccessedThroughProperty("chkComment")]
        private CheckBox _chkComment;
        [AccessedThroughProperty("chkFilename")]
        private CheckBox _chkFilename;
        [AccessedThroughProperty("chkGenre")]
        private CheckBox _chkGenre;
        [AccessedThroughProperty("chkRegExpress")]
        private CheckBox _chkRegExpress;
        [AccessedThroughProperty("chkSelected")]
        private CheckBox _chkSelected;
        [AccessedThroughProperty("chkTitle")]
        private CheckBox _chkTitle;
        [AccessedThroughProperty("chkTracknumber")]
        private CheckBox _chkTracknumber;
        [AccessedThroughProperty("chkVer1")]
        private CheckBox _chkVer1;
        [AccessedThroughProperty("chkVer2")]
        private CheckBox _chkVer2;
        [AccessedThroughProperty("chkYear")]
        private CheckBox _chkYear;
        [AccessedThroughProperty("FrameMode")]
        private GroupBox _FrameMode;
        [AccessedThroughProperty("frameTAGOptions")]
        private GroupBox _frameTAGOptions;
        [AccessedThroughProperty("lblReplace")]
        private Label _lblReplace;
        [AccessedThroughProperty("lblSearch")]
        private Label _lblSearch;
        [AccessedThroughProperty("LinkLabel")]
        private System.Windows.Forms.LinkLabel _LinkLabel;
        [AccessedThroughProperty("optAND")]
        private RadioButton _optAND;
        [AccessedThroughProperty("optOR")]
        private RadioButton _optOR;
        [AccessedThroughProperty("ProgressBar")]
        private System.Windows.Forms.ProgressBar _ProgressBar;
        [AccessedThroughProperty("ToolTip")]
        private System.Windows.Forms.ToolTip _ToolTip;
        [AccessedThroughProperty("txtReplace")]
        private TextBox _txtReplace;
        [AccessedThroughProperty("txtSearch")]
        private TextBox _txtSearch;
        private IContainer components;
        public frmMain MainForm;

        public frmSearch()
        {
            base.Load += new EventHandler(this.frmSearch_Load);
            this.InitializeComponent();
        }

        private void AddToolTips()
        {
            string vstrName = "frmSearch";
            Control txtSearch = this.txtSearch;
            this.txtSearch = (TextBox) txtSearch;
            this.ToolTip.SetToolTip(this.txtSearch, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.txtReplace;
            this.txtReplace = (TextBox) txtSearch;
            this.ToolTip.SetToolTip(this.txtReplace, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.btnSelect;
            this.btnSelect = (Button) txtSearch;
            this.ToolTip.SetToolTip(this.btnSelect, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.btnReplace;
            this.btnReplace = (Button) txtSearch;
            this.ToolTip.SetToolTip(this.btnReplace, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkFilename;
            this.chkFilename = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkFilename, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkVer1;
            this.chkVer1 = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkVer1, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkVer2;
            this.chkVer2 = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkVer2, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkRegExpress;
            this.chkRegExpress = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkRegExpress, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkSelected;
            this.chkSelected = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkSelected, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkCase;
            this.chkCase = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkCase, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.optAND;
            this.optAND = (RadioButton) txtSearch;
            this.ToolTip.SetToolTip(this.optAND, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.optOR;
            this.optOR = (RadioButton) txtSearch;
            this.ToolTip.SetToolTip(this.optOR, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkArtist;
            this.chkArtist = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkArtist, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkTitle;
            this.chkTitle = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkTitle, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkAlbum;
            this.chkAlbum = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkTracknumber;
            this.chkTracknumber = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkTracknumber, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkYear;
            this.chkYear = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkYear, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkGenre;
            this.chkGenre = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkGenre, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
            vstrName = "frmSearch";
            txtSearch = this.chkComment;
            this.chkComment = (CheckBox) txtSearch;
            this.ToolTip.SetToolTip(this.chkComment, Declarations.objResources.GetToolTip(ref vstrName, ref txtSearch));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form form = this;
            Main.SaveFormSettings(ref form);
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
                                this.SR(ref item, ref text, ref str, ref uNDO);
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
                                this.SR(ref item, ref text, ref str, ref uNDO);
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
                        {
                            this.SearchSelect(ref item, ref text);
                        }
                    }
                    else
                    {
                        foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
                        {
                            this.SearchSelect(ref item, ref text);
                        }
                    }
                    try
                    {
                        if (this.MainForm.MP3View.FocusedItem == null)
                        {
                            this.MainForm.MP3View.SelectedItems[0].Focused = true;
                        }
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
            Main.RestoreFormSettings(ref objForm);
            objForm = this;
            Main.WindowsXPCheck(ref objForm);
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

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
            this.lblSearch = new Label();
            this.lblReplace = new Label();
            this.txtSearch = new TextBox();
            this.txtReplace = new TextBox();
            this.btnSelect = new Button();
            this.btnReplace = new Button();
            this.btnClose = new Button();
            this.chkFilename = new CheckBox();
            this.chkVer1 = new CheckBox();
            this.chkVer2 = new CheckBox();
            this.FrameMode = new GroupBox();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.chkRegExpress = new CheckBox();
            this.chkSelected = new CheckBox();
            this.chkCase = new CheckBox();
            this.optAND = new RadioButton();
            this.optOR = new RadioButton();
            this.frameTAGOptions = new GroupBox();
            this.chkArtist = new CheckBox();
            this.chkTitle = new CheckBox();
            this.chkAlbum = new CheckBox();
            this.chkTracknumber = new CheckBox();
            this.chkYear = new CheckBox();
            this.chkGenre = new CheckBox();
            this.chkComment = new CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FrameMode.SuspendLayout();
            this.frameTAGOptions.SuspendLayout();
            this.SuspendLayout();
            this.lblSearch.ImeMode = ImeMode.NoControl;
            Point point = new Point(8, 8);
            this.lblSearch.Location = point;
            this.lblSearch.Name = "lblSearch";
            Size size = new Size(0x60, 0x10);
            this.lblSearch.Size = size;
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "&Search for:";
            this.lblReplace.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x22);
            this.lblReplace.Location = point;
            this.lblReplace.Name = "lblReplace";
            size = new Size(0x60, 0x10);
            this.lblReplace.Size = size;
            this.lblReplace.TabIndex = 0;
            this.lblReplace.Text = "&Replace by:";
            point = new Point(0x68, 6);
            this.txtSearch.Location = point;
            this.txtSearch.Name = "txtSearch";
            size = new Size(0x180, 20);
            this.txtSearch.Size = size;
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "";
            point = new Point(0x68, 0x20);
            this.txtReplace.Location = point;
            this.txtReplace.Name = "txtReplace";
            size = new Size(0x180, 20);
            this.txtReplace.Size = size;
            this.txtReplace.TabIndex = 1;
            this.txtReplace.Text = "";
            this.btnSelect.ImeMode = ImeMode.NoControl;
            point = new Point(8, 320);
            this.btnSelect.Location = point;
            this.btnSelect.Name = "btnSelect";
            size = new Size(0x90, 0x18);
            this.btnSelect.Size = size;
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Search and S&elect";
            this.btnReplace.ImeMode = ImeMode.NoControl;
            point = new Point(0xb0, 320);
            this.btnReplace.Location = point;
            this.btnReplace.Name = "btnReplace";
            size = new Size(0x90, 0x18);
            this.btnReplace.Size = size;
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Search and Re&place";
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = ImeMode.NoControl;
            point = new Point(0x178, 320);
            this.btnClose.Location = point;
            this.btnClose.Name = "btnClose";
            size = new Size(0x70, 0x18);
            this.btnClose.Size = size;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Clo&se";
            this.chkFilename.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x40);
            this.chkFilename.Location = point;
            this.chkFilename.Name = "chkFilename";
            size = new Size(0x90, 0x10);
            this.chkFilename.Size = size;
            this.chkFilename.TabIndex = 7;
            this.chkFilename.Text = "Search in &Filename";
            this.chkVer1.ImeMode = ImeMode.NoControl;
            point = new Point(0xb0, 0x40);
            this.chkVer1.Location = point;
            this.chkVer1.Name = "chkVer1";
            size = new Size(0x98, 0x10);
            this.chkVer1.Size = size;
            this.chkVer1.TabIndex = 10;
            this.chkVer1.Text = "Search in TAG Ver. &1";
            this.chkVer2.ImeMode = ImeMode.NoControl;
            point = new Point(0x150, 0x40);
            this.chkVer2.Location = point;
            this.chkVer2.Name = "chkVer2";
            size = new Size(0x98, 0x10);
            this.chkVer2.Size = size;
            this.chkVer2.TabIndex = 9;
            this.chkVer2.Text = "Search in TAG Ver. &2";
            this.FrameMode.Controls.Add(this.LinkLabel);
            this.FrameMode.Controls.Add(this.chkRegExpress);
            this.FrameMode.Controls.Add(this.chkSelected);
            this.FrameMode.Controls.Add(this.chkCase);
            this.FrameMode.Controls.Add(this.optAND);
            this.FrameMode.Controls.Add(this.optOR);
            point = new Point(8, 0x60);
            this.FrameMode.Location = point;
            this.FrameMode.Name = "FrameMode";
            size = new Size(480, 0x60);
            this.FrameMode.Size = size;
            this.FrameMode.TabIndex = 11;
            this.FrameMode.TabStop = false;
            this.FrameMode.Text = "Search options";
            this.LinkLabel.ImeMode = ImeMode.NoControl;
            LinkArea area = new LinkArea(0, 50);
            this.LinkLabel.LinkArea = area;
            point = new Point(0xd0, 0x48);
            this.LinkLabel.Location = point;
            this.LinkLabel.Name = "LinkLabel";
            size = new Size(0x108, 0x10);
            this.LinkLabel.Size = size;
            this.LinkLabel.TabIndex = 0x12;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "http://www.regular-expressions.info/reference.html";
            this.chkRegExpress.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x48);
            this.chkRegExpress.Location = point;
            this.chkRegExpress.Name = "chkRegExpress";
            size = new Size(0xc0, 0x10);
            this.chkRegExpress.Size = size;
            this.chkRegExpress.TabIndex = 0x11;
            this.chkRegExpress.Text = "&Use regular expressions";
            this.chkSelected.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x30);
            this.chkSelected.Location = point;
            this.chkSelected.Name = "chkSelected";
            size = new Size(0xd0, 0x10);
            this.chkSelected.Size = size;
            this.chkSelected.TabIndex = 0x10;
            this.chkSelected.Text = "Search selected files only";
            this.chkCase.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x18);
            this.chkCase.Location = point;
            this.chkCase.Name = "chkCase";
            size = new Size(0xd0, 0x10);
            this.chkCase.Size = size;
            this.chkCase.TabIndex = 15;
            this.chkCase.Text = "Search case sensitive";
            this.optAND.ImeMode = ImeMode.NoControl;
            point = new Point(0xe0, 0x18);
            this.optAND.Location = point;
            this.optAND.Name = "optAND";
            size = new Size(0xf8, 0x10);
            this.optAND.Size = size;
            this.optAND.TabIndex = 3;
            this.optAND.Text = "Search AN&D ('Search and Select' only)";
            this.optOR.ImeMode = ImeMode.NoControl;
            point = new Point(0xe0, 0x30);
            this.optOR.Location = point;
            this.optOR.Name = "optOR";
            size = new Size(0xf8, 0x10);
            this.optOR.Size = size;
            this.optOR.TabIndex = 2;
            this.optOR.Text = "Search &OR  ('Search and Select' only)";
            this.frameTAGOptions.Controls.Add(this.chkArtist);
            this.frameTAGOptions.Controls.Add(this.chkTitle);
            this.frameTAGOptions.Controls.Add(this.chkAlbum);
            this.frameTAGOptions.Controls.Add(this.chkTracknumber);
            this.frameTAGOptions.Controls.Add(this.chkYear);
            this.frameTAGOptions.Controls.Add(this.chkGenre);
            this.frameTAGOptions.Controls.Add(this.chkComment);
            point = new Point(8, 200);
            this.frameTAGOptions.Location = point;
            this.frameTAGOptions.Name = "frameTAGOptions";
            size = new Size(480, 0x58);
            this.frameTAGOptions.Size = size;
            this.frameTAGOptions.TabIndex = 12;
            this.frameTAGOptions.TabStop = false;
            this.frameTAGOptions.Text = "TAG fields to search in";
            this.chkArtist.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x10);
            this.chkArtist.Location = point;
            this.chkArtist.Name = "chkArtist";
            size = new Size(0x80, 0x10);
            this.chkArtist.Size = size;
            this.chkArtist.TabIndex = 20;
            this.chkArtist.Text = "&Artist";
            this.chkTitle.ImeMode = ImeMode.NoControl;
            point = new Point(8, 40);
            this.chkTitle.Location = point;
            this.chkTitle.Name = "chkTitle";
            size = new Size(0x80, 0x10);
            this.chkTitle.Size = size;
            this.chkTitle.TabIndex = 0x16;
            this.chkTitle.Text = "&Title";
            this.chkAlbum.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x40);
            this.chkAlbum.Location = point;
            this.chkAlbum.Name = "chkAlbum";
            size = new Size(0x80, 0x10);
            this.chkAlbum.Size = size;
            this.chkAlbum.TabIndex = 0x15;
            this.chkAlbum.Text = "Al&bum";
            this.chkTracknumber.ImeMode = ImeMode.NoControl;
            point = new Point(0x148, 0x10);
            this.chkTracknumber.Location = point;
            this.chkTracknumber.Name = "chkTracknumber";
            size = new Size(0x88, 0x10);
            this.chkTracknumber.Size = size;
            this.chkTracknumber.TabIndex = 0x11;
            this.chkTracknumber.Text = "Trac&knumber";
            this.chkYear.ImeMode = ImeMode.NoControl;
            point = new Point(0xa8, 0x40);
            this.chkYear.Location = point;
            this.chkYear.Name = "chkYear";
            size = new Size(0x90, 0x10);
            this.chkYear.Size = size;
            this.chkYear.TabIndex = 0x10;
            this.chkYear.Text = "&Year";
            this.chkGenre.ImeMode = ImeMode.NoControl;
            point = new Point(0xa8, 0x10);
            this.chkGenre.Location = point;
            this.chkGenre.Name = "chkGenre";
            size = new Size(0x90, 0x10);
            this.chkGenre.Size = size;
            this.chkGenre.TabIndex = 0x13;
            this.chkGenre.Text = "&Genre (Ver. 2 only)";
            this.chkComment.ImeMode = ImeMode.NoControl;
            point = new Point(0xa8, 40);
            this.chkComment.Location = point;
            this.chkComment.Name = "chkComment";
            size = new Size(0x90, 0x10);
            this.chkComment.Size = size;
            this.chkComment.TabIndex = 0x12;
            this.chkComment.Text = "&Comment";
            this.ProgressBar.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x128);
            this.ProgressBar.Location = point;
            this.ProgressBar.Name = "ProgressBar";
            size = new Size(480, 0x10);
            this.ProgressBar.Size = size;
            this.ProgressBar.Step = 0x19;
            this.ProgressBar.TabIndex = 13;
            this.AcceptButton = this.btnSelect;
            size = new Size(5, 13);
            this.AutoScaleBaseSize = size;
            this.CancelButton = this.btnClose;
            size = new Size(0x1f2, 350);
            this.ClientSize = size;
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
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.ShowInTaskbar = false;
            this.Text = "Search and Replace";
            this.FrameMode.ResumeLayout(false);
            this.frameTAGOptions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.LinkLabel.Text);
        }

        private void SearchSelect(ref ListViewItem lstItem, ref string vstrSearchString)
        {
            bool flag;
            MP3 mp2;
            RegexOptions none = RegexOptions.None;
            if (!this.chkCase.Checked)
            {
                none |= RegexOptions.IgnoreCase;
            }
            if (!this.optOR.Checked)
            {
                mp2 = (MP3) lstItem.Tag;
                lstItem.Selected = false;
                flag = false;
                if (this.chkFilename.Checked)
                {
                    if (!Regex.IsMatch(mp2.CurrentName, vstrSearchString, none))
                    {
                        flag = true;
                    }
                    else if (!((((((this.chkArtist.Checked | this.chkTitle.Checked) | this.chkAlbum.Checked) | this.chkComment.Checked) | this.chkYear.Checked) | this.chkTracknumber.Checked) | this.chkGenre.Checked))
                    {
                        lstItem.Selected = true;
                    }
                }
                flag = false;
                if ((this.chkVer1.Checked & mp2.V1TAG.TAGPresent) & !flag)
                {
                    if ((!flag && this.chkArtist.Checked) && !Regex.IsMatch(mp2.V1TAG.Artist, vstrSearchString, none))
                    {
                        flag = true;
                    }
                    if ((!flag && this.chkTitle.Checked) && !Regex.IsMatch(mp2.V1TAG.Title, vstrSearchString, none))
                    {
                        flag = true;
                    }
                    if ((!flag && this.chkAlbum.Checked) && !Regex.IsMatch(mp2.V1TAG.Album, vstrSearchString, none))
                    {
                        flag = true;
                    }
                    if ((!flag && this.chkComment.Checked) && !Regex.IsMatch(mp2.V1TAG.Comment, vstrSearchString, none))
                    {
                        flag = true;
                    }
                    if (!flag && this.chkYear.Checked)
                    {
                        if (!Regex.IsMatch(mp2.V1TAG.Year.ToString(), vstrSearchString, none))
                        {
                            flag = true;
                        }
                        if (mp2.V1TAG.Year <= 0)
                        {
                            flag = true;
                        }
                    }
                    if (!flag && this.chkTracknumber.Checked)
                    {
                        if (!Regex.IsMatch(mp2.V1TAG.Tracknumber.ToString(), vstrSearchString, none))
                        {
                            flag = true;
                        }
                        if (mp2.V1TAG.Tracknumber <= 0)
                        {
                            flag = true;
                        }
                    }
                    if ((!flag && this.chkGenre.Checked) && !Regex.IsMatch(mp2.V1TAG.GenreText, vstrSearchString, none))
                    {
                        flag = true;
                    }
                    if (!flag)
                    {
                        lstItem.Selected = true;
                    }
                }
                flag = false;
                if (!((this.chkVer2.Checked & mp2.V2TAG.TAGHeaderPresent) & !flag))
                {
                    return;
                }
                if (!flag && this.chkArtist.Checked)
                {
                    flag = true;
                    if (mp2.V2TAG.FrameExists("TPE1") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null)), vstrSearchString, none))
                    {
                        flag = false;
                    }
                }
                if (!flag && this.chkTitle.Checked)
                {
                    flag = true;
                    if (mp2.V2TAG.FrameExists("TIT2") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null)), vstrSearchString, none))
                    {
                        flag = false;
                    }
                }
                if (!flag && this.chkAlbum.Checked)
                {
                    flag = true;
                    if (mp2.V2TAG.FrameExists("TALB") && Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(mp2.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null)), vstrSearchString, none))
                    {
                        flag = false;
                    }
                }
                if (!flag && this.chkComment.Checked)
                {
                    flag = true;
                    using (IEnumerator enumerator = mp2.V2TAG.GetFrames("COMM").GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            if (Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator.Current), null, "Content", new object[0], null, null)), vstrSearchString, none))
                            {
                                flag = false;
                                goto Label_0941;
                            }
                        }
                    }
                }
                goto Label_0941;
            }
            MP3 tag = (MP3) lstItem.Tag;
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
            {
                return;
            }
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
                using (IEnumerator enumerator2 = tag.V2TAG.GetFrames("COMM").GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        if (Regex.IsMatch(StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator2.Current), null, "Content", new object[0], null, null)), vstrSearchString, none))
                        {
                            lstItem.Selected = true;
                            flag = true;
                            goto Label_03CB;
                        }
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

        private void SR(ref ListViewItem lstItem, ref string vstrSearchString, ref string vstrReplaceString, ref ArrayList UNDO)
        {
            bool flag2 = false;
            string str = "";
            bool flag = false;
            RegexOptions none = RegexOptions.None;
            if (!this.chkCase.Checked)
            {
                none |= RegexOptions.IgnoreCase;
            }
            MP3 tag = (MP3) lstItem.Tag;
            Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3) lstItem.Tag, (V1TAG) LateBinding.LateGet(LateBinding.LateGet(lstItem.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG) LateBinding.LateGet(LateBinding.LateGet(lstItem.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(lstItem.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(lstItem.Tag, null, "Changed", new object[0], null, null)));
            if (this.chkFilename.Checked)
            {
                str = Regex.Replace(tag.CurrentName, vstrSearchString, vstrReplaceString, none).Replace("<", "_").Replace(">", "_").Replace("|", "_").Replace("\"", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace(":", "_").Replace(@"\", "_");
                if (str.Length > 0xff)
                {
                    ListViewItem item2 = new ListViewItem {
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
                        ListViewItem item = new ListViewItem {
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
                            tag.V1TAG.Tracknumber = (byte) Convert.ToInt32(str);
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
                    using (IEnumerator enumerator = tag.V2TAG.GetFrames("COMM").GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
                            str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, vstrReplaceString, none);
                            if (BooleanType.FromObject(ObjectType.NotObj(Interaction.IIf(this.chkCase.Checked, str.Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))), str.ToLower().Equals(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null)))))))
                            {
                                LateBinding.LateSet(objectValue, null, "Content", new object[] { str }, null);
                                flag2 = true;
                                tag.Changed = true;
                            }
                        }
                    }
                }
                if (this.chkYear.Checked & Information.IsNumeric(vstrReplaceString))
                {
                    if (tag.V2TAG.FrameExists("TYER"))
                    {
                        objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TYER"));
                        if ((Information.IsNumeric(vstrReplaceString) & (Conversion.Val((string) vstrReplaceString) > 1000.0)) & (Conversion.Val((string) vstrReplaceString) < 10000.0))
                        {
                            str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, Math.Floor(Conversion.Val((string) vstrReplaceString)).ToString(), none);
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
                        if ((Information.IsNumeric(vstrReplaceString) & (Conversion.Val((string) vstrReplaceString) > 1000.0)) & (Conversion.Val((string) vstrReplaceString) < 10000.0))
                        {
                            str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, Math.Floor(Conversion.Val((string) vstrReplaceString)).ToString(), none);
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
                    else if (Conversion.Val((string) vstrReplaceString) >= 0.0)
                    {
                        str = Regex.Replace(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), vstrSearchString, Math.Floor(Conversion.Val((string) vstrReplaceString)).ToString(), none);
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

        internal virtual Button btnClose
        {
            get
            {
                return this._btnClose;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnClose != null)
                {
                    this._btnClose.Click -= new EventHandler(this.btnClose_Click);
                }
                this._btnClose = value;
                if (this._btnClose != null)
                {
                    this._btnClose.Click += new EventHandler(this.btnClose_Click);
                }
            }
        }

        internal virtual Button btnReplace
        {
            get
            {
                return this._btnReplace;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnReplace != null)
                {
                    this._btnReplace.Click -= new EventHandler(this.btnReplace_Click);
                }
                this._btnReplace = value;
                if (this._btnReplace != null)
                {
                    this._btnReplace.Click += new EventHandler(this.btnReplace_Click);
                }
            }
        }

        internal virtual Button btnSelect
        {
            get
            {
                return this._btnSelect;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnSelect != null)
                {
                    this._btnSelect.Click -= new EventHandler(this.btnSelect_Click);
                }
                this._btnSelect = value;
                if (this._btnSelect != null)
                {
                    this._btnSelect.Click += new EventHandler(this.btnSelect_Click);
                }
            }
        }

        internal virtual CheckBox chkAlbum
        {
            get
            {
                return this._chkAlbum;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkAlbum != null)
                {
                }
                this._chkAlbum = value;
                if (this._chkAlbum != null)
                {
                }
            }
        }

        internal virtual CheckBox chkArtist
        {
            get
            {
                return this._chkArtist;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkArtist != null)
                {
                }
                this._chkArtist = value;
                if (this._chkArtist != null)
                {
                }
            }
        }

        internal virtual CheckBox chkCase
        {
            get
            {
                return this._chkCase;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkCase != null)
                {
                }
                this._chkCase = value;
                if (this._chkCase != null)
                {
                }
            }
        }

        internal virtual CheckBox chkComment
        {
            get
            {
                return this._chkComment;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkComment != null)
                {
                }
                this._chkComment = value;
                if (this._chkComment != null)
                {
                }
            }
        }

        internal virtual CheckBox chkFilename
        {
            get
            {
                return this._chkFilename;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkFilename != null)
                {
                }
                this._chkFilename = value;
                if (this._chkFilename != null)
                {
                }
            }
        }

        internal virtual CheckBox chkGenre
        {
            get
            {
                return this._chkGenre;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkGenre != null)
                {
                }
                this._chkGenre = value;
                if (this._chkGenre != null)
                {
                }
            }
        }

        internal virtual CheckBox chkRegExpress
        {
            get
            {
                return this._chkRegExpress;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkRegExpress != null)
                {
                }
                this._chkRegExpress = value;
                if (this._chkRegExpress != null)
                {
                }
            }
        }

        internal virtual CheckBox chkSelected
        {
            get
            {
                return this._chkSelected;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkSelected != null)
                {
                }
                this._chkSelected = value;
                if (this._chkSelected != null)
                {
                }
            }
        }

        internal virtual CheckBox chkTitle
        {
            get
            {
                return this._chkTitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkTitle != null)
                {
                }
                this._chkTitle = value;
                if (this._chkTitle != null)
                {
                }
            }
        }

        internal virtual CheckBox chkTracknumber
        {
            get
            {
                return this._chkTracknumber;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkTracknumber != null)
                {
                }
                this._chkTracknumber = value;
                if (this._chkTracknumber != null)
                {
                }
            }
        }

        internal virtual CheckBox chkVer1
        {
            get
            {
                return this._chkVer1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkVer1 != null)
                {
                    this._chkVer1.CheckedChanged -= new EventHandler(this.chkVer_CheckedChanged);
                }
                this._chkVer1 = value;
                if (this._chkVer1 != null)
                {
                    this._chkVer1.CheckedChanged += new EventHandler(this.chkVer_CheckedChanged);
                }
            }
        }

        internal virtual CheckBox chkVer2
        {
            get
            {
                return this._chkVer2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkVer2 != null)
                {
                    this._chkVer2.CheckedChanged -= new EventHandler(this.chkVer_CheckedChanged);
                }
                this._chkVer2 = value;
                if (this._chkVer2 != null)
                {
                    this._chkVer2.CheckedChanged += new EventHandler(this.chkVer_CheckedChanged);
                }
            }
        }

        internal virtual CheckBox chkYear
        {
            get
            {
                return this._chkYear;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkYear != null)
                {
                }
                this._chkYear = value;
                if (this._chkYear != null)
                {
                }
            }
        }

        internal virtual GroupBox FrameMode
        {
            get
            {
                return this._FrameMode;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._FrameMode != null)
                {
                }
                this._FrameMode = value;
                if (this._FrameMode != null)
                {
                }
            }
        }

        internal virtual GroupBox frameTAGOptions
        {
            get
            {
                return this._frameTAGOptions;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._frameTAGOptions != null)
                {
                }
                this._frameTAGOptions = value;
                if (this._frameTAGOptions != null)
                {
                }
            }
        }

        internal virtual Label lblReplace
        {
            get
            {
                return this._lblReplace;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblReplace != null)
                {
                }
                this._lblReplace = value;
                if (this._lblReplace != null)
                {
                }
            }
        }

        internal virtual Label lblSearch
        {
            get
            {
                return this._lblSearch;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblSearch != null)
                {
                }
                this._lblSearch = value;
                if (this._lblSearch != null)
                {
                }
            }
        }

        internal virtual System.Windows.Forms.LinkLabel LinkLabel
        {
            get
            {
                return this._LinkLabel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._LinkLabel != null)
                {
                    this._LinkLabel.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
                }
                this._LinkLabel = value;
                if (this._LinkLabel != null)
                {
                    this._LinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
                }
            }
        }

        internal virtual RadioButton optAND
        {
            get
            {
                return this._optAND;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optAND != null)
                {
                }
                this._optAND = value;
                if (this._optAND != null)
                {
                }
            }
        }

        internal virtual RadioButton optOR
        {
            get
            {
                return this._optOR;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optOR != null)
                {
                }
                this._optOR = value;
                if (this._optOR != null)
                {
                }
            }
        }

        internal virtual System.Windows.Forms.ProgressBar ProgressBar
        {
            get
            {
                return this._ProgressBar;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._ProgressBar != null)
                {
                }
                this._ProgressBar = value;
                if (this._ProgressBar != null)
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

        internal virtual TextBox txtReplace
        {
            get
            {
                return this._txtReplace;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtReplace != null)
                {
                }
                this._txtReplace = value;
                if (this._txtReplace != null)
                {
                }
            }
        }

        internal virtual TextBox txtSearch
        {
            get
            {
                return this._txtSearch;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtSearch != null)
                {
                }
                this._txtSearch = value;
                if (this._txtSearch != null)
                {
                }
            }
        }
    }
}

