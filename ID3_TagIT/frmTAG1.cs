using AMS.TextBox;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmTAG1 : Form
  {
    #region Designer

    private Button btnCancel;
    private ButtonItem btnExport;
    private ButtonItem btnGet;
    private ButtonItem btnImport;
    private ButtonItem btnNext;
    private Button btnOK;
    private ButtonItem btnPrev;
    private ButtonItem btnSwapAA;
    private ButtonItem btnSwapAT;
    private ButtonItem btnSwapTA;
    private ComboBoxAutoComplete cmbArtist;
    private ComboBoxAutoComplete cmbGenre;
    private Label lblAlbum;
    private Label lblArtist;
    private Label lblComment;
    private Label lblGenre;
    private Label lblTitle;
    private Label lblTrack;
    private Label lblYear;
    private ExplorerBar SelectionBar;
    private ButtonItem TAGV2ButtonItem1;
    private ButtonItem TAGV2ButtonItem10;
    private ButtonItem TAGV2ButtonItem2;
    private ButtonItem TAGV2ButtonItem3;
    private ButtonItem TAGV2ButtonItem4;
    private ButtonItem TAGV2ButtonItem5;
    private ButtonItem TAGV2ButtonItem6;
    private ButtonItem TAGV2ButtonItem7;
    private ButtonItem TAGV2ButtonItem8;
    private ButtonItem TAGV2ButtonItem9;
    private ExplorerBarGroupItem TAGV2grpCommands;
    private System.Windows.Forms.ToolTip ToolTip;
    private System.Windows.Forms.TextBox txtAlbum;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.TextBox txtTitle;
    private NumericTextBox txtTrack;
    private NumericTextBox txtYear;
    private IContainer components;
    private Control FocusedControl;
    private frmMain MainForm;
    private Label lblSelected;
    private System.Windows.Forms.TextBox txtSelected;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

//FIXME
//this.btnNext.Icon = (Icon)manager.GetObject("btnNext.Icon");
//this.btnNext.Icon = (Icon)(new ResourceManager("Icons", this.GetType().Assembly).GetObject("btnNext.Icon"));
//this.btnPrev.Icon = (Icon)manager.GetObject("btnPrev.Icon");
//this.btnPrev.Icon = (Icon)(new ResourceManager("Icons", this.GetType().Assembly).GetObject("btnPrev.Icon"));

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTAG1));
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.lblGenre = new System.Windows.Forms.Label();
      this.txtAlbum = new System.Windows.Forms.TextBox();
      this.lblComment = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblAlbum = new System.Windows.Forms.Label();
      this.lblYear = new System.Windows.Forms.Label();
      this.lblTrack = new System.Windows.Forms.Label();
      this.lblArtist = new System.Windows.Forms.Label();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.txtTitle = new System.Windows.Forms.TextBox();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.cmbArtist = new ID3_TagIT.ComboBoxAutoComplete();
      this.cmbGenre = new ID3_TagIT.ComboBoxAutoComplete();
      this.txtTrack = new AMS.TextBox.NumericTextBox();
      this.txtYear = new AMS.TextBox.NumericTextBox();
      this.SelectionBar = new DevComponents.DotNetBar.ExplorerBar();
      this.TAGV2grpCommands = new DevComponents.DotNetBar.ExplorerBarGroupItem();
      this.btnPrev = new DevComponents.DotNetBar.ButtonItem();
      this.btnNext = new DevComponents.DotNetBar.ButtonItem();
      this.btnSwapAT = new DevComponents.DotNetBar.ButtonItem();
      this.btnSwapAA = new DevComponents.DotNetBar.ButtonItem();
      this.btnSwapTA = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem7 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem8 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem10 = new DevComponents.DotNetBar.ButtonItem();
      this.btnImport = new DevComponents.DotNetBar.ButtonItem();
      this.btnExport = new DevComponents.DotNetBar.ButtonItem();
      this.btnGet = new DevComponents.DotNetBar.ButtonItem();
      this.lblSelected = new System.Windows.Forms.Label();
      this.txtSelected = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.SelectionBar)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(504, 236);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(112, 24);
      this.btnCancel.TabIndex = 16;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(384, 236);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(112, 24);
      this.btnOK.TabIndex = 15;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblGenre
      // 
      this.lblGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblGenre.Location = new System.Drawing.Point(176, 176);
      this.lblGenre.Name = "lblGenre";
      this.lblGenre.Size = new System.Drawing.Size(144, 16);
      this.lblGenre.TabIndex = 10;
      this.lblGenre.Text = "&Genres:";
      // 
      // txtAlbum
      // 
      this.txtAlbum.Location = new System.Drawing.Point(328, 102);
      this.txtAlbum.MaxLength = 30;
      this.txtAlbum.Name = "txtAlbum";
      this.txtAlbum.Size = new System.Drawing.Size(288, 20);
      this.txtAlbum.TabIndex = 5;
      this.txtAlbum.Enter += new System.EventHandler(this.Select_Enter);
      this.txtAlbum.Leave += new System.EventHandler(this.Focus_Leave);
      // 
      // lblComment
      // 
      this.lblComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblComment.Location = new System.Drawing.Point(176, 200);
      this.lblComment.Name = "lblComment";
      this.lblComment.Size = new System.Drawing.Size(144, 16);
      this.lblComment.TabIndex = 12;
      this.lblComment.Text = "&Comment:";
      // 
      // lblTitle
      // 
      this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitle.Location = new System.Drawing.Point(176, 80);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(144, 16);
      this.lblTitle.TabIndex = 2;
      this.lblTitle.Text = "&Title:";
      // 
      // lblAlbum
      // 
      this.lblAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAlbum.Location = new System.Drawing.Point(176, 104);
      this.lblAlbum.Name = "lblAlbum";
      this.lblAlbum.Size = new System.Drawing.Size(144, 16);
      this.lblAlbum.TabIndex = 4;
      this.lblAlbum.Text = "Al&bum:";
      // 
      // lblYear
      // 
      this.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblYear.Location = new System.Drawing.Point(176, 128);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new System.Drawing.Size(144, 16);
      this.lblYear.TabIndex = 6;
      this.lblYear.Text = "&Year:";
      // 
      // lblTrack
      // 
      this.lblTrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTrack.Location = new System.Drawing.Point(176, 152);
      this.lblTrack.Name = "lblTrack";
      this.lblTrack.Size = new System.Drawing.Size(144, 16);
      this.lblTrack.TabIndex = 8;
      this.lblTrack.Text = "&Track number:";
      // 
      // lblArtist
      // 
      this.lblArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtist.Location = new System.Drawing.Point(176, 56);
      this.lblArtist.Name = "lblArtist";
      this.lblArtist.Size = new System.Drawing.Size(144, 16);
      this.lblArtist.TabIndex = 0;
      this.lblArtist.Text = "Lead &Artist:";
      // 
      // txtComment
      // 
      this.txtComment.Location = new System.Drawing.Point(328, 198);
      this.txtComment.MaxLength = 30;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(288, 20);
      this.txtComment.TabIndex = 13;
      this.txtComment.Enter += new System.EventHandler(this.Select_Enter);
      this.txtComment.Leave += new System.EventHandler(this.Focus_Leave);
      // 
      // txtTitle
      // 
      this.txtTitle.Location = new System.Drawing.Point(328, 78);
      this.txtTitle.MaxLength = 30;
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new System.Drawing.Size(288, 20);
      this.txtTitle.TabIndex = 3;
      this.txtTitle.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTitle.Leave += new System.EventHandler(this.Focus_Leave);
      // 
      // cmbArtist
      // 
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.ItemHeight = 13;
      this.cmbArtist.Location = new System.Drawing.Point(328, 54);
      this.cmbArtist.MaxLength = 30;
      this.cmbArtist.Name = "cmbArtist";
      this.cmbArtist.Size = new System.Drawing.Size(288, 21);
      this.cmbArtist.TabIndex = 1;
      this.cmbArtist.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbArtist.Leave += new System.EventHandler(this.Focus_Leave);
      // 
      // cmbGenre
      // 
      this.cmbGenre.Autocomplete = true;
      this.cmbGenre.ItemHeight = 13;
      this.cmbGenre.ListItemsOnly = true;
      this.cmbGenre.Location = new System.Drawing.Point(328, 174);
      this.cmbGenre.Name = "cmbGenre";
      this.cmbGenre.Size = new System.Drawing.Size(288, 21);
      this.cmbGenre.TabIndex = 11;
      this.cmbGenre.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbGenre.Leave += new System.EventHandler(this.Focus_Leave);
      // 
      // txtTrack
      // 
      this.txtTrack.AllowNegative = true;
      this.txtTrack.DigitsInGroup = 0;
      this.txtTrack.Flags = 16;
      this.txtTrack.Location = new System.Drawing.Point(328, 150);
      this.txtTrack.MaxDecimalPlaces = 0;
      this.txtTrack.MaxLength = 3;
      this.txtTrack.MaxWholeDigits = 3;
      this.txtTrack.Name = "txtTrack";
      this.txtTrack.Prefix = "";
      this.txtTrack.RangeMax = 255D;
      this.txtTrack.RangeMin = 1D;
      this.txtTrack.Size = new System.Drawing.Size(64, 20);
      this.txtTrack.TabIndex = 9;
      this.txtTrack.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTrack.Leave += new System.EventHandler(this.Focus_Leave);
      // 
      // txtYear
      // 
      this.txtYear.AllowNegative = true;
      this.txtYear.DigitsInGroup = 0;
      this.txtYear.Flags = 16;
      this.txtYear.Location = new System.Drawing.Point(328, 126);
      this.txtYear.MaxDecimalPlaces = 0;
      this.txtYear.MaxLength = 4;
      this.txtYear.MaxWholeDigits = 4;
      this.txtYear.Name = "txtYear";
      this.txtYear.Prefix = "";
      this.txtYear.RangeMax = 9999D;
      this.txtYear.RangeMin = 1800D;
      this.txtYear.Size = new System.Drawing.Size(64, 20);
      this.txtYear.TabIndex = 7;
      this.txtYear.Enter += new System.EventHandler(this.Select_Enter);
      this.txtYear.Leave += new System.EventHandler(this.Focus_Leave);
      // 
      // SelectionBar
      // 
      this.SelectionBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
      this.SelectionBar.AllowUserCustomize = false;
      this.SelectionBar.AntiAlias = true;
      this.SelectionBar.BackColor = System.Drawing.SystemColors.Control;
      this.SelectionBar.BackgroundStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground;
      this.SelectionBar.BackgroundStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2;
      this.SelectionBar.BackgroundStyle.GradientAngle = 90;
      this.SelectionBar.Dock = System.Windows.Forms.DockStyle.Left;
      this.SelectionBar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.SelectionBar.GroupImages = null;
      this.SelectionBar.Groups.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TAGV2grpCommands});
      this.SelectionBar.Images = null;
      this.SelectionBar.Location = new System.Drawing.Point(0, 0);
      this.SelectionBar.Name = "SelectionBar";
      this.SelectionBar.Size = new System.Drawing.Size(168, 272);
      this.SelectionBar.TabIndex = 17;
      this.SelectionBar.Text = "Select TAG section";
      // 
      // TAGV2grpCommands
      // 
      this.TAGV2grpCommands.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
      this.TAGV2grpCommands.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.TAGV2grpCommands.BackgroundStyle.BorderColor.Color = System.Drawing.Color.White;
      this.TAGV2grpCommands.CanCustomize = false;
      this.TAGV2grpCommands.Expanded = true;
      this.TAGV2grpCommands.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.White;
      this.TAGV2grpCommands.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
      this.TAGV2grpCommands.HeaderHotStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.TAGV2grpCommands.HeaderHotStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2grpCommands.HeaderStyle.BackColor1.Color = System.Drawing.Color.White;
      this.TAGV2grpCommands.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
      this.TAGV2grpCommands.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.TAGV2grpCommands.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2grpCommands.Name = "TAGV2grpCommands";
      this.TAGV2grpCommands.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.Blue;
      this.TAGV2grpCommands.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPrev,
            this.btnNext,
            this.btnSwapAT,
            this.btnSwapAA,
            this.btnSwapTA});
      this.TAGV2grpCommands.Text = "Commands";
      // 
      // btnPrev
      // 
      this.btnPrev.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnPrev.HotFontUnderline = true;
      this.btnPrev.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnPrev.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnPrev.Icon = ((System.Drawing.Icon)(resources.GetObject("btnPrev.Icon")));
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
      this.btnPrev.Text = "Previous File";
      this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
      // 
      // btnNext
      // 
      this.btnNext.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnNext.HotFontUnderline = true;
      this.btnNext.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnNext.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnNext.Icon = ((System.Drawing.Icon)(resources.GetObject("btnNext.Icon")));
      this.btnNext.Name = "btnNext";
      this.btnNext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
      this.btnNext.Text = "Next File";
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // btnSwapAT
      // 
      this.btnSwapAT.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnSwapAT.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSwapAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnSwapAT.HotFontUnderline = true;
      this.btnSwapAT.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnSwapAT.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnSwapAT.Name = "btnSwapAT";
      this.btnSwapAT.Text = "Swap Artist-Title";
      this.btnSwapAT.Click += new System.EventHandler(this.btnSwapAT_Click);
      // 
      // btnSwapAA
      // 
      this.btnSwapAA.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnSwapAA.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSwapAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnSwapAA.HotFontUnderline = true;
      this.btnSwapAA.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnSwapAA.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnSwapAA.Name = "btnSwapAA";
      this.btnSwapAA.Text = "Swap Artist-Album";
      this.btnSwapAA.Click += new System.EventHandler(this.btnSwapAA_Click);
      // 
      // btnSwapTA
      // 
      this.btnSwapTA.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnSwapTA.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSwapTA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnSwapTA.HotFontUnderline = true;
      this.btnSwapTA.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnSwapTA.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnSwapTA.Name = "btnSwapTA";
      this.btnSwapTA.Text = "Swap Title-Album";
      this.btnSwapTA.Click += new System.EventHandler(this.btnSwapTA_Click);
      // 
      // TAGV2ButtonItem1
      // 
      this.TAGV2ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem1.HotFontUnderline = true;
      this.TAGV2ButtonItem1.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem1.Name = "TAGV2ButtonItem1";
      this.TAGV2ButtonItem1.Text = "Main Entries";
      // 
      // TAGV2ButtonItem2
      // 
      this.TAGV2ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem2.HotFontUnderline = true;
      this.TAGV2ButtonItem2.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem2.Name = "TAGV2ButtonItem2";
      this.TAGV2ButtonItem2.Text = "Detailed information";
      // 
      // TAGV2ButtonItem3
      // 
      this.TAGV2ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem3.HotFontUnderline = true;
      this.TAGV2ButtonItem3.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem3.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem3.Name = "TAGV2ButtonItem3";
      this.TAGV2ButtonItem3.Text = "Original information";
      // 
      // TAGV2ButtonItem4
      // 
      this.TAGV2ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem4.HotFontUnderline = true;
      this.TAGV2ButtonItem4.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem4.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem4.Name = "TAGV2ButtonItem4";
      this.TAGV2ButtonItem4.Text = "Involved people";
      // 
      // TAGV2ButtonItem5
      // 
      this.TAGV2ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem5.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem5.HotFontUnderline = true;
      this.TAGV2ButtonItem5.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem5.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem5.Name = "TAGV2ButtonItem5";
      this.TAGV2ButtonItem5.Text = "Web information";
      // 
      // TAGV2ButtonItem6
      // 
      this.TAGV2ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem6.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem6.HotFontUnderline = true;
      this.TAGV2ButtonItem6.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem6.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem6.Name = "TAGV2ButtonItem6";
      this.TAGV2ButtonItem6.Text = "Pictures";
      // 
      // TAGV2ButtonItem7
      // 
      this.TAGV2ButtonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem7.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem7.HotFontUnderline = true;
      this.TAGV2ButtonItem7.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem7.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem7.Name = "TAGV2ButtonItem7";
      this.TAGV2ButtonItem7.Text = "Lyrics";
      // 
      // TAGV2ButtonItem8
      // 
      this.TAGV2ButtonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem8.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem8.HotFontUnderline = true;
      this.TAGV2ButtonItem8.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem8.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem8.Name = "TAGV2ButtonItem8";
      this.TAGV2ButtonItem8.Text = "Rating";
      // 
      // TAGV2ButtonItem9
      // 
      this.TAGV2ButtonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem9.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem9.HotFontUnderline = true;
      this.TAGV2ButtonItem9.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem9.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem9.Name = "TAGV2ButtonItem9";
      this.TAGV2ButtonItem9.Text = "User defined information";
      // 
      // TAGV2ButtonItem10
      // 
      this.TAGV2ButtonItem10.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem10.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem10.HotFontUnderline = true;
      this.TAGV2ButtonItem10.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem10.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem10.Name = "TAGV2ButtonItem10";
      this.TAGV2ButtonItem10.Text = "Not supported frames";
      // 
      // btnImport
      // 
      this.btnImport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnImport.HotFontUnderline = true;
      this.btnImport.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnImport.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnImport.Name = "btnImport";
      this.btnImport.Text = "Transfer from Ver. 1";
      // 
      // btnExport
      // 
      this.btnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnExport.HotFontUnderline = true;
      this.btnExport.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnExport.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnExport.Name = "btnExport";
      this.btnExport.Text = "Transfer to Ver. 1";
      // 
      // btnGet
      // 
      this.btnGet.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnGet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnGet.HotFontUnderline = true;
      this.btnGet.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnGet.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnGet.Name = "btnGet";
      this.btnGet.Text = "Get from filename";
      // 
      // lblSelected
      // 
      this.lblSelected.BackColor = System.Drawing.SystemColors.Control;
      this.lblSelected.ForeColor = System.Drawing.Color.Black;
      this.lblSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblSelected.Location = new System.Drawing.Point(176, 13);
      this.lblSelected.Name = "lblSelected";
      this.lblSelected.Size = new System.Drawing.Size(152, 16);
      this.lblSelected.TabIndex = 19;
      this.lblSelected.Text = "Selected file:";
      // 
      // txtSelected
      // 
      this.txtSelected.BackColor = System.Drawing.SystemColors.Control;
      this.txtSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtSelected.ForeColor = System.Drawing.Color.Black;
      this.txtSelected.Location = new System.Drawing.Point(176, 29);
      this.txtSelected.Name = "txtSelected";
      this.txtSelected.ReadOnly = true;
      this.txtSelected.Size = new System.Drawing.Size(440, 13);
      this.txtSelected.TabIndex = 20;
      // 
      // frmTAG1
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(626, 272);
      this.ControlBox = false;
      this.Controls.Add(this.txtSelected);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.lblSelected);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.txtYear);
      this.Controls.Add(this.txtTrack);
      this.Controls.Add(this.cmbGenre);
      this.Controls.Add(this.cmbArtist);
      this.Controls.Add(this.lblGenre);
      this.Controls.Add(this.txtAlbum);
      this.Controls.Add(this.lblComment);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.lblAlbum);
      this.Controls.Add(this.lblYear);
      this.Controls.Add(this.lblTrack);
      this.Controls.Add(this.lblArtist);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.txtTitle);
      this.Controls.Add(this.SelectionBar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG1";
      this.ShowInTaskbar = false;
      this.Text = "Edit TAG Ver. 1";
      ((System.ComponentModel.ISupportInitialize)(this.SelectionBar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    public frmTAG1(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG1_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Local variables

    private ID3_TagIT.MP3 MP3;

    #endregion

    #region Events

    private void btnNext_Click(object sender, EventArgs e)
    {
      this.SaveToTAG();

      if (this.MainForm.MP3View.FocusedItem.Index < (this.MainForm.MP3View.Items.Count - 1))
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.FocusedItem.Index + 1].Focused = true;
        this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
        this.ClearForm();
        this.FillForm();
      
        // FIXME
        //if (this.ActiveControl == this.btnNext)
        //  this.FocusedControl.Focus();
      }

      // FIXME
      //else if (this.ActiveControl == this.btnNext)
      //  this.FocusedControl.Focus();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      this.SaveToTAG();
      this.Close();
    }

    private void btnPrev_Click(object sender, EventArgs e)
    {
      this.SaveToTAG();

      if (this.MainForm.MP3View.FocusedItem.Index != 0)
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.FocusedItem.Index - 1].Focused = true;
        this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
        this.ClearForm();
        this.FillForm();

        // FIXME
        //if (this.ActiveControl == this.btnPrev)
        //  this.FocusedControl.Focus();
      }

      // FIXME
      //else if (this.ActiveControl == this.btnPrev)
      //  this.FocusedControl.Focus();
    }

    private void btnSwapAA_Click(object sender, EventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
    }

    private void btnSwapAT_Click(object sender, EventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtTitle.Text;
      this.txtTitle.Text = text;
    }

    private void btnSwapTA_Click(object sender, EventArgs e)
    {
      string text = this.txtTitle.Text;
      this.txtTitle.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
    }

    private void Focus_Leave(object sender, EventArgs e)
    {
      this.FocusedControl = (Control)sender;
    }

    private void frmTAG1_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);

      if (this.MainForm.MP3View.FocusedItem == null)
        this.MainForm.MP3View.Items[this.MainForm.MP3View.SelectedItems[0].Index].Focused = true;

      this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.SelectedItems[0].Tag;
      this.FocusedControl = this.cmbArtist;

      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
        this.cmbArtist.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

      this.cmbGenre.Items.Add("");

      foreach (DataRow row in Declarations.objSettings.Genres.Rows)
        this.cmbGenre.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

      foreach (string str in Declarations.astrGenreLookup)
        this.cmbGenre.Items.Add(str);

      this.cmbGenre.Sorted = true;
      this.cmbGenre.Sorted = false;
      this.FillForm();
      this.AddSelectionBar();
      this.AddToolTips();
      this.cmbArtist.Select();
      this.cmbArtist.Focus();
    }

    private void Select_Enter(object sender, EventArgs e)
    {
      object[] objArray3 = new object[2];
      objArray3[0] = 0;
      object o = sender;
      object[] args = new object[0];
      string[] paramnames = null;
      objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(o, null, "Text", args, paramnames, null), null, "Length", new object[0], null, null));
      object[] objArray2 = objArray3;
      bool[] copyBack = new bool[] { false, true };
      LateBinding.LateCall(sender, null, "Select", objArray2, null, copyBack);

      if (copyBack[1])
        LateBinding.LateSetComplex(LateBinding.LateGet(o, null, "Text", args, paramnames, null), null, "Length", new object[] { RuntimeHelpers.GetObjectValue(objArray2[1]) }, null, true, true);
    }

    #endregion

    private void AddSelectionBar()
    {
      IEnumerator enumerator = null;

      try
      {
        enumerator = this.SelectionBar.Groups.GetEnumerator();

        while (enumerator.MoveNext())
        {
          ExplorerBarGroupItem current = (ExplorerBarGroupItem)enumerator.Current;
          current.Text = StringType.FromObject(Declarations.objResources.SelectionBar[current.Name]);

          try
          {
            foreach (ButtonItem item in current.SubItems)
              item.Text = StringType.FromObject(Declarations.objResources.SelectionBar[item.Name]);

            continue;
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
            continue;
          }
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          ((IDisposable)enumerator).Dispose();
      }
    }

    private void AddToolTips()
    {
      string vstrName = "frmTAG1";
      Control txtAlbum = this.txtAlbum;
      this.txtAlbum = (System.Windows.Forms.TextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));

      vstrName = "frmTAG1";
      txtAlbum = this.txtComment;
      this.txtComment = (System.Windows.Forms.TextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtComment, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));

      vstrName = "frmTAG1";
      txtAlbum = this.txtTitle;
      this.txtTitle = (System.Windows.Forms.TextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtTitle, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));

      vstrName = "frmTAG1";
      txtAlbum = this.txtTrack;
      this.txtTrack = (NumericTextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtTrack, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));

      vstrName = "frmTAG1";
      txtAlbum = this.txtYear;
      this.txtYear = (NumericTextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtYear, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));

      vstrName = "frmTAG1";
      txtAlbum = this.cmbArtist;
      this.cmbArtist = (ComboBoxAutoComplete)txtAlbum;
      this.ToolTip.SetToolTip(this.cmbArtist, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));

      vstrName = "frmTAG1";
      txtAlbum = this.cmbGenre;
      this.cmbGenre = (ComboBoxAutoComplete)txtAlbum;
      this.ToolTip.SetToolTip(this.cmbGenre, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));
    }

    private void ClearForm()
    {
      this.cmbArtist.Text = "";
      this.txtTitle.Text = "";
      this.txtAlbum.Text = "";
      this.txtTrack.Text = "";
      this.txtYear.Text = "";
      this.cmbGenre.Text = "";
      this.txtComment.Text = "";
    }

    private void FillForm()
    {
      this.cmbArtist.Autocomplete = false;

      if (this.MP3.V1TAG.TAGVersion < 11)
        this.txtComment.MaxLength = 30;
      else
        this.txtComment.MaxLength = 0x1c;

      this.txtSelected.Text = this.MP3.CurrentFullName;
      this.cmbArtist.Text = this.MP3.V1TAG.Artist;
      this.txtTitle.Text = this.MP3.V1TAG.Title;
      this.txtAlbum.Text = this.MP3.V1TAG.Album;

      try
      {
        this.txtTrack.Text = StringType.FromObject(Interaction.IIf(this.MP3.V1TAG.Tracknumber == 0, "", this.MP3.V1TAG.Tracknumber.ToString()));
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }

      try
      {
        this.txtYear.Text = StringType.FromObject(Interaction.IIf(this.MP3.V1TAG.Year == 0, "", this.MP3.V1TAG.Year.ToString()));
      }
      catch (Exception exception2)
      {
        ProjectData.SetProjectError(exception2);
        ProjectData.ClearProjectError();
      }

      this.cmbGenre.Text = this.MP3.V1TAG.GenreText;
      this.txtComment.Text = this.MP3.V1TAG.Comment;
      this.cmbArtist.Autocomplete = true;
    }

    private void SaveToTAG()
    {
      ArrayList list = new ArrayList();
      Declarations.UnDoReDo @do = new Declarations.UnDoReDo(this.MP3, this.MP3.V1TAG.Clone(), this.MP3.V2TAG.Clone(), this.MP3.CurrentFullName, this.MP3.Changed);
      list.Add(@do);
      Declarations.UNDOList.Add(list);
      this.MainForm.UnDoEnable(true, true);

      if (StringType.StrCmp(this.MP3.V1TAG.Artist, this.cmbArtist.Text, false) != 0)
      {
        this.MP3.V1TAG.Artist = this.cmbArtist.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }

      if (StringType.StrCmp(this.MP3.V1TAG.Title, this.txtTitle.Text, false) != 0)
      {
        this.MP3.V1TAG.Title = this.txtTitle.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }

      if (StringType.StrCmp(this.MP3.V1TAG.Album, this.txtAlbum.Text, false) != 0)
      {
        this.MP3.V1TAG.Album = this.txtAlbum.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }

      if (this.MP3.V1TAG.Year != Conversion.Val(this.txtYear.Text))
      {
        this.MP3.V1TAG.Year = (int)Math.Round(Conversion.Val(this.txtYear.Text));
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }

      if (this.MP3.V1TAG.Tracknumber != Conversion.Val(this.txtTrack.Text))
      {
        this.MP3.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(this.txtTrack.Text));
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }

      if (this.MP3.V1TAG.GenreByte != ID3Functions.GetV1GenreByName(this.cmbGenre.Text))
      {
        this.MP3.V1TAG.GenreText = this.cmbGenre.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }

      if (StringType.StrCmp(this.MP3.V1TAG.Comment, this.txtComment.Text, false) != 0)
      {
        this.MP3.V1TAG.Comment = this.txtComment.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }

      if (Declarations.objSettings.SynchronizeTAGs)
      {
        object o = ID3Functions.CreateTextFrame("TPE1", this.cmbArtist.Text);

        if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TIT2", this.txtTitle.Text);

        if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TALB", this.txtAlbum.Text);

        if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        string text = this.cmbGenre.Text;

        foreach (DataRow row in Declarations.objSettings.Genres.Rows)
          if (ObjectType.ObjTst(row["V1V2"], ID3Functions.GetV1GenreByName(this.cmbGenre.Text), false) == 0)
          {
            text = row["Name"].ToString();
            break;
          }

        o = ID3Functions.CreateTextFrame("TCON", text);

        if (StringType.StrCmp(this.cmbGenre.Text.Trim(new char[] { ' ' }), "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = new V2LDCFrame();
        LateBinding.LateSet(o, null, "FID", new object[] { "COMM" }, null);
        LateBinding.LateSet(o, null, "Language", new object[] { Declarations.astrLanLookup[Declarations.objSettings.V2Language].Substring(0, 3) }, null);
        LateBinding.LateSet(o, null, "Descriptor", new object[] { Declarations.objSettings.TransferCommentD }, null);
        LateBinding.LateSet(o, null, "Content", new object[] { this.txtComment.Text }, null);

        if (StringType.StrCmp(this.txtComment.Text, "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));

        if (StringType.StrCmp(this.txtYear.Text, "", false) != 0)
        {
          if (!this.MP3.V2TAG.TAGHeaderPresent)
            this.MP3.V2TAG.TAGHeaderPresent = true;

          if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
          {
            o = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text.PadLeft(4, '0'));
            this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
          }
          else
          {
            o = ID3Functions.CreateTextFrame("TDRC", this.txtYear.Text.PadLeft(4, '0'));
            this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
          }
        }
        else if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
        {
          o = ID3Functions.CreateTextFrame("TYER", "0000");
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TDRC", "0000");
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }

        if (StringType.StrCmp(this.txtTrack.Text, "", false) != 0)
        {
          o = ID3Functions.CreateTextFrame("TRCK", this.txtTrack.Text.PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'));
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TRCK", "0");
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }

        if (this.MP3.V2TAG.Changed)
        {
          if (!this.MP3.V2TAG.TAGHeaderPresent)
            this.MP3.V2TAG.TAGHeaderPresent = true;

          this.MP3.Changed = true;
        }
      }

      this.MainForm.UpdateListItem(this.MainForm.MP3View.FocusedItem, false);
    }
  }
}