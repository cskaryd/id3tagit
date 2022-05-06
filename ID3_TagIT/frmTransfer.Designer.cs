using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmTransfer : Form
  {
    #region Designer

    private Button btnCancel;
    private Button btnDeselectAll;
    private Button btnOK;
    private Button btnSelectAll;
    private CheckBox chkAlbum;
    private CheckBox chkArtist;
    private CheckBox chkComment;
    private CheckBox chkExists;
    private CheckBox chkGenre;
    private CheckBox chkTitle;
    private CheckBox chkTrack;
    private CheckBox chkYear;
    private System.Windows.Forms.GroupBox GroupBox;
    private Label lblComment;
    private RadioButton opt12;
    private RadioButton opt21;
    private RadioButton optConvert34;
    private RadioButton optConvert43;
    private System.Windows.Forms.ToolTip ToolTip;
    private TextBox txtCommentD;
    private IContainer components;
    private frmMain MainForm;

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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.opt12 = new System.Windows.Forms.RadioButton();
      this.opt21 = new System.Windows.Forms.RadioButton();
      this.optConvert34 = new System.Windows.Forms.RadioButton();
      this.optConvert43 = new System.Windows.Forms.RadioButton();
      this.GroupBox = new System.Windows.Forms.GroupBox();
      this.chkExists = new System.Windows.Forms.CheckBox();
      this.txtCommentD = new System.Windows.Forms.TextBox();
      this.lblComment = new System.Windows.Forms.Label();
      this.chkYear = new System.Windows.Forms.CheckBox();
      this.chkGenre = new System.Windows.Forms.CheckBox();
      this.chkTrack = new System.Windows.Forms.CheckBox();
      this.chkComment = new System.Windows.Forms.CheckBox();
      this.chkAlbum = new System.Windows.Forms.CheckBox();
      this.chkTitle = new System.Windows.Forms.CheckBox();
      this.chkArtist = new System.Windows.Forms.CheckBox();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.btnSelectAll = new System.Windows.Forms.Button();
      this.btnDeselectAll = new System.Windows.Forms.Button();
      this.GroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(352, 232);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(112, 24);
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(232, 232);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(112, 24);
      this.btnOK.TabIndex = 3;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // opt12
      // 
      this.opt12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.opt12.Location = new System.Drawing.Point(16, 16);
      this.opt12.Name = "opt12";
      this.opt12.Size = new System.Drawing.Size(232, 16);
      this.opt12.TabIndex = 5;
      this.opt12.Text = "Transfer TAG Ver 1. -> Ver. 2";
      this.opt12.CheckedChanged += new System.EventHandler(this.opt12_CheckedChanged);
      // 
      // opt21
      // 
      this.opt21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.opt21.Location = new System.Drawing.Point(248, 16);
      this.opt21.Name = "opt21";
      this.opt21.Size = new System.Drawing.Size(224, 16);
      this.opt21.TabIndex = 6;
      this.opt21.Text = "Transfer TAG Ver 2. -> Ver. 1";
      this.opt21.CheckedChanged += new System.EventHandler(this.opt21_CheckedChanged);
      // 
      // optConvert34
      // 
      this.optConvert34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optConvert34.Location = new System.Drawing.Point(16, 40);
      this.optConvert34.Name = "optConvert34";
      this.optConvert34.Size = new System.Drawing.Size(232, 16);
      this.optConvert34.TabIndex = 7;
      this.optConvert34.Text = "Convert TAG Ver. 2.3 to Ver. 2.4";
      this.optConvert34.CheckedChanged += new System.EventHandler(this.optConvert_CheckedChanged);
      // 
      // optConvert43
      // 
      this.optConvert43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optConvert43.Location = new System.Drawing.Point(248, 40);
      this.optConvert43.Name = "optConvert43";
      this.optConvert43.Size = new System.Drawing.Size(224, 16);
      this.optConvert43.TabIndex = 8;
      this.optConvert43.Text = "Convert TAG Ver. 2.4 to Ver. 2.3";
      this.optConvert43.CheckedChanged += new System.EventHandler(this.optConvert_CheckedChanged);
      // 
      // GroupBox
      // 
      this.GroupBox.Controls.Add(this.chkExists);
      this.GroupBox.Controls.Add(this.txtCommentD);
      this.GroupBox.Controls.Add(this.lblComment);
      this.GroupBox.Controls.Add(this.chkYear);
      this.GroupBox.Controls.Add(this.chkGenre);
      this.GroupBox.Controls.Add(this.chkTrack);
      this.GroupBox.Controls.Add(this.chkComment);
      this.GroupBox.Controls.Add(this.chkAlbum);
      this.GroupBox.Controls.Add(this.chkTitle);
      this.GroupBox.Controls.Add(this.chkArtist);
      this.GroupBox.Location = new System.Drawing.Point(8, 72);
      this.GroupBox.Name = "GroupBox";
      this.GroupBox.Size = new System.Drawing.Size(456, 152);
      this.GroupBox.TabIndex = 9;
      this.GroupBox.TabStop = false;
      this.GroupBox.Text = "TAG fields to transfer";
      // 
      // chkExists
      // 
      this.chkExists.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkExists.Location = new System.Drawing.Point(16, 128);
      this.chkExists.Name = "chkExists";
      this.chkExists.Size = new System.Drawing.Size(400, 16);
      this.chkExists.TabIndex = 9;
      this.chkExists.Text = "Do not overwrite existing TAG entries";
      // 
      // txtCommentD
      // 
      this.txtCommentD.Location = new System.Drawing.Point(168, 94);
      this.txtCommentD.Name = "txtCommentD";
      this.txtCommentD.Size = new System.Drawing.Size(272, 20);
      this.txtCommentD.TabIndex = 8;
      // 
      // lblComment
      // 
      this.lblComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblComment.Location = new System.Drawing.Point(16, 96);
      this.lblComment.Name = "lblComment";
      this.lblComment.Size = new System.Drawing.Size(152, 16);
      this.lblComment.TabIndex = 7;
      this.lblComment.Text = "Comment &descriptor:";
      // 
      // chkYear
      // 
      this.chkYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkYear.Location = new System.Drawing.Point(16, 72);
      this.chkYear.Name = "chkYear";
      this.chkYear.Size = new System.Drawing.Size(120, 16);
      this.chkYear.TabIndex = 6;
      this.chkYear.Text = "Year";
      // 
      // chkGenre
      // 
      this.chkGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkGenre.Location = new System.Drawing.Point(312, 48);
      this.chkGenre.Name = "chkGenre";
      this.chkGenre.Size = new System.Drawing.Size(128, 16);
      this.chkGenre.TabIndex = 5;
      this.chkGenre.Text = "Genre";
      // 
      // chkTrack
      // 
      this.chkTrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkTrack.Location = new System.Drawing.Point(160, 48);
      this.chkTrack.Name = "chkTrack";
      this.chkTrack.Size = new System.Drawing.Size(128, 16);
      this.chkTrack.TabIndex = 4;
      this.chkTrack.Text = "Track number";
      // 
      // chkComment
      // 
      this.chkComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkComment.Location = new System.Drawing.Point(16, 48);
      this.chkComment.Name = "chkComment";
      this.chkComment.Size = new System.Drawing.Size(120, 16);
      this.chkComment.TabIndex = 3;
      this.chkComment.Text = "Comment";
      // 
      // chkAlbum
      // 
      this.chkAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkAlbum.Location = new System.Drawing.Point(312, 24);
      this.chkAlbum.Name = "chkAlbum";
      this.chkAlbum.Size = new System.Drawing.Size(128, 16);
      this.chkAlbum.TabIndex = 2;
      this.chkAlbum.Text = "Album";
      // 
      // chkTitle
      // 
      this.chkTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkTitle.Location = new System.Drawing.Point(160, 24);
      this.chkTitle.Name = "chkTitle";
      this.chkTitle.Size = new System.Drawing.Size(128, 16);
      this.chkTitle.TabIndex = 1;
      this.chkTitle.Text = "Title";
      // 
      // chkArtist
      // 
      this.chkArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkArtist.Location = new System.Drawing.Point(16, 24);
      this.chkArtist.Name = "chkArtist";
      this.chkArtist.Size = new System.Drawing.Size(120, 16);
      this.chkArtist.TabIndex = 0;
      this.chkArtist.Text = "Artist";
      // 
      // btnSelectAll
      // 
      this.btnSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnSelectAll.Location = new System.Drawing.Point(8, 232);
      this.btnSelectAll.Name = "btnSelectAll";
      this.btnSelectAll.Size = new System.Drawing.Size(96, 23);
      this.btnSelectAll.TabIndex = 5;
      this.btnSelectAll.Text = "Select all";
      this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
      // 
      // btnDeselectAll
      // 
      this.btnDeselectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnDeselectAll.Location = new System.Drawing.Point(112, 232);
      this.btnDeselectAll.Name = "btnDeselectAll";
      this.btnDeselectAll.Size = new System.Drawing.Size(96, 23);
      this.btnDeselectAll.TabIndex = 6;
      this.btnDeselectAll.Text = "Deselect all";
      this.btnDeselectAll.Click += new System.EventHandler(this.btnDeSelectAll_Click);
      // 
      // frmTransfer
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(474, 262);
      this.ControlBox = false;
      this.Controls.Add(this.btnDeselectAll);
      this.Controls.Add(this.btnSelectAll);
      this.Controls.Add(this.GroupBox);
      this.Controls.Add(this.optConvert43);
      this.Controls.Add(this.optConvert34);
      this.Controls.Add(this.opt21);
      this.Controls.Add(this.opt12);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTransfer";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Transfer / Convert TAGs";
      this.GroupBox.ResumeLayout(false);
      this.GroupBox.PerformLayout();
      this.ResumeLayout(false);
    }

    public frmTransfer(frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTransfer_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion
  }
}