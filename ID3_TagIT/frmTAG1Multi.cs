using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmTAG1Multi : Form
  {
    #region Designer

    private Button btnCancel;
    private Button btnOK;
    private CheckBox CheckBox1;
    private CheckBox CheckBox2;
    private CheckBox CheckBox3;
    private CheckBox CheckBox4;
    private CheckBox CheckBox5;
    private CheckBox CheckBox6;
    private CheckBox CheckBox7;
    private ComboBoxAutoComplete cmbArtist;
    private ComboBoxAutoComplete cmbGenre;
    private Label lblAlbum;
    private Label lblArtist;
    private Label lblComment;
    private Label lblGenre;
    private Label lblInfoStar;
    private Label lblTitle;
    private Label lblTrack;
    private Label lblYear;
    private System.Windows.Forms.ToolTip ToolTip;
    private System.Windows.Forms.TextBox txtAlbum;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.TextBox txtTitle;
    private MaskedTextBox txtTrack;
    private MaskedTextBox txtYear;
    private IContainer components;
    private Panel pnlCommands;
    private LinkLabel lblSwapTtlAlb;
    private LinkLabel lblSwapArtAlb;
    private LinkLabel lblSwapArtTtl;
    private Label lblCommand;
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
      this.CheckBox1 = new System.Windows.Forms.CheckBox();
      this.CheckBox2 = new System.Windows.Forms.CheckBox();
      this.CheckBox3 = new System.Windows.Forms.CheckBox();
      this.CheckBox4 = new System.Windows.Forms.CheckBox();
      this.CheckBox5 = new System.Windows.Forms.CheckBox();
      this.CheckBox6 = new System.Windows.Forms.CheckBox();
      this.CheckBox7 = new System.Windows.Forms.CheckBox();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.cmbGenre = new ID3_TagIT.ComboBoxAutoComplete();
      this.cmbArtist = new ID3_TagIT.ComboBoxAutoComplete();
      this.txtYear = new System.Windows.Forms.MaskedTextBox();
      this.txtTrack = new System.Windows.Forms.MaskedTextBox();
      this.lblInfoStar = new System.Windows.Forms.Label();
      this.pnlCommands = new System.Windows.Forms.Panel();
      this.lblSwapTtlAlb = new System.Windows.Forms.LinkLabel();
      this.lblSwapArtAlb = new System.Windows.Forms.LinkLabel();
      this.lblSwapArtTtl = new System.Windows.Forms.LinkLabel();
      this.lblCommand = new System.Windows.Forms.Label();
      this.pnlCommands.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(488, 244);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(112, 24);
      this.btnCancel.TabIndex = 24;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(368, 244);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(112, 24);
      this.btnOK.TabIndex = 23;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblGenre
      // 
      this.lblGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblGenre.Location = new System.Drawing.Point(160, 128);
      this.lblGenre.Name = "lblGenre";
      this.lblGenre.Size = new System.Drawing.Size(144, 16);
      this.lblGenre.TabIndex = 15;
      this.lblGenre.Text = "&Genres:";
      // 
      // txtAlbum
      // 
      this.txtAlbum.Location = new System.Drawing.Point(312, 56);
      this.txtAlbum.MaxLength = 30;
      this.txtAlbum.Name = "txtAlbum";
      this.txtAlbum.Size = new System.Drawing.Size(264, 20);
      this.txtAlbum.TabIndex = 7;
      this.txtAlbum.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.txtAlbum.Enter += new System.EventHandler(this.Select_Enter);
      // 
      // lblComment
      // 
      this.lblComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblComment.Location = new System.Drawing.Point(160, 152);
      this.lblComment.Name = "lblComment";
      this.lblComment.Size = new System.Drawing.Size(144, 16);
      this.lblComment.TabIndex = 18;
      this.lblComment.Text = "&Comment:";
      // 
      // lblTitle
      // 
      this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitle.Location = new System.Drawing.Point(160, 32);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(144, 16);
      this.lblTitle.TabIndex = 3;
      this.lblTitle.Text = "&Title:";
      // 
      // lblAlbum
      // 
      this.lblAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAlbum.Location = new System.Drawing.Point(160, 56);
      this.lblAlbum.Name = "lblAlbum";
      this.lblAlbum.Size = new System.Drawing.Size(144, 16);
      this.lblAlbum.TabIndex = 6;
      this.lblAlbum.Text = "Al&bum:";
      // 
      // lblYear
      // 
      this.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblYear.Location = new System.Drawing.Point(160, 80);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new System.Drawing.Size(144, 16);
      this.lblYear.TabIndex = 9;
      this.lblYear.Text = "&Year:";
      // 
      // lblTrack
      // 
      this.lblTrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTrack.Location = new System.Drawing.Point(160, 104);
      this.lblTrack.Name = "lblTrack";
      this.lblTrack.Size = new System.Drawing.Size(144, 16);
      this.lblTrack.TabIndex = 12;
      this.lblTrack.Text = "&Track number:";
      // 
      // lblArtist
      // 
      this.lblArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtist.Location = new System.Drawing.Point(160, 8);
      this.lblArtist.Name = "lblArtist";
      this.lblArtist.Size = new System.Drawing.Size(144, 16);
      this.lblArtist.TabIndex = 0;
      this.lblArtist.Text = "Lead &Artist:";
      // 
      // txtComment
      // 
      this.txtComment.Location = new System.Drawing.Point(312, 152);
      this.txtComment.MaxLength = 30;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(264, 20);
      this.txtComment.TabIndex = 19;
      this.txtComment.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.txtComment.Enter += new System.EventHandler(this.Select_Enter);
      // 
      // txtTitle
      // 
      this.txtTitle.Location = new System.Drawing.Point(312, 32);
      this.txtTitle.MaxLength = 30;
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new System.Drawing.Size(264, 20);
      this.txtTitle.TabIndex = 4;
      this.txtTitle.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.txtTitle.Enter += new System.EventHandler(this.Select_Enter);
      // 
      // CheckBox1
      // 
      this.CheckBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox1.Location = new System.Drawing.Point(584, 10);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new System.Drawing.Size(16, 16);
      this.CheckBox1.TabIndex = 2;
      // 
      // CheckBox2
      // 
      this.CheckBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox2.Location = new System.Drawing.Point(584, 34);
      this.CheckBox2.Name = "CheckBox2";
      this.CheckBox2.Size = new System.Drawing.Size(16, 16);
      this.CheckBox2.TabIndex = 5;
      // 
      // CheckBox3
      // 
      this.CheckBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox3.Location = new System.Drawing.Point(584, 58);
      this.CheckBox3.Name = "CheckBox3";
      this.CheckBox3.Size = new System.Drawing.Size(16, 16);
      this.CheckBox3.TabIndex = 8;
      // 
      // CheckBox4
      // 
      this.CheckBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox4.Location = new System.Drawing.Point(384, 82);
      this.CheckBox4.Name = "CheckBox4";
      this.CheckBox4.Size = new System.Drawing.Size(16, 16);
      this.CheckBox4.TabIndex = 11;
      // 
      // CheckBox5
      // 
      this.CheckBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox5.Location = new System.Drawing.Point(384, 106);
      this.CheckBox5.Name = "CheckBox5";
      this.CheckBox5.Size = new System.Drawing.Size(16, 16);
      this.CheckBox5.TabIndex = 14;
      // 
      // CheckBox6
      // 
      this.CheckBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox6.Location = new System.Drawing.Point(584, 130);
      this.CheckBox6.Name = "CheckBox6";
      this.CheckBox6.Size = new System.Drawing.Size(16, 16);
      this.CheckBox6.TabIndex = 17;
      // 
      // CheckBox7
      // 
      this.CheckBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox7.Location = new System.Drawing.Point(584, 154);
      this.CheckBox7.Name = "CheckBox7";
      this.CheckBox7.Size = new System.Drawing.Size(16, 16);
      this.CheckBox7.TabIndex = 20;
      // 
      // cmbGenre
      // 
      this.cmbGenre.Autocomplete = true;
      this.cmbGenre.ItemHeight = 13;
      this.cmbGenre.ListItemsOnly = true;
      this.cmbGenre.Location = new System.Drawing.Point(312, 128);
      this.cmbGenre.Name = "cmbGenre";
      this.cmbGenre.Size = new System.Drawing.Size(264, 21);
      this.cmbGenre.TabIndex = 16;
      this.cmbGenre.SelectedIndexChanged += new System.EventHandler(this.cmbArtist_SelectedIndexChanged);
      this.cmbGenre.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.cmbGenre.Enter += new System.EventHandler(this.Select_Enter);
      // 
      // cmbArtist
      // 
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.ItemHeight = 13;
      this.cmbArtist.Location = new System.Drawing.Point(312, 8);
      this.cmbArtist.MaxLength = 30;
      this.cmbArtist.Name = "cmbArtist";
      this.cmbArtist.Size = new System.Drawing.Size(264, 21);
      this.cmbArtist.TabIndex = 1;
      this.cmbArtist.SelectedIndexChanged += new System.EventHandler(this.cmbArtist_SelectedIndexChanged);
      this.cmbArtist.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.cmbArtist.Enter += new System.EventHandler(this.Select_Enter);
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(312, 80);
      this.txtYear.Mask = "0000";
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(64, 20);
      this.txtYear.TabIndex = 10;
      this.txtYear.ValidatingType = typeof(int);
      this.txtYear.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.txtYear.Enter += new System.EventHandler(this.Select_Enter);
      this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
      // 
      // txtTrack
      // 
      this.txtTrack.Location = new System.Drawing.Point(312, 104);
      this.txtTrack.Mask = "000";
      this.txtTrack.Name = "txtTrack";
      this.txtTrack.Size = new System.Drawing.Size(64, 20);
      this.txtTrack.TabIndex = 13;
      this.txtTrack.ValidatingType = typeof(int);
      this.txtTrack.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.txtTrack.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTrack.Leave += new System.EventHandler(this.txtTrack_Leave);
      this.txtTrack.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrack_Validating);
      // 
      // lblInfoStar
      // 
      this.lblInfoStar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfoStar.Location = new System.Drawing.Point(160, 184);
      this.lblInfoStar.Name = "lblInfoStar";
      this.lblInfoStar.Size = new System.Drawing.Size(440, 48);
      this.lblInfoStar.TabIndex = 21;
      this.lblInfoStar.Text = "You can use the following parameters to enter the information from one field into" +
    " another: <A>=Artist, <T>=Title, <B>=Album, <C>=Comment, <K>=Tracknumber, <Y>=Ye" +
    "ar, <G>=Genre";
      this.lblInfoStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnlCommands
      // 
      this.pnlCommands.Controls.Add(this.lblSwapTtlAlb);
      this.pnlCommands.Controls.Add(this.lblSwapArtAlb);
      this.pnlCommands.Controls.Add(this.lblSwapArtTtl);
      this.pnlCommands.Controls.Add(this.lblCommand);
      this.pnlCommands.Location = new System.Drawing.Point(12, 12);
      this.pnlCommands.Name = "pnlCommands";
      this.pnlCommands.Size = new System.Drawing.Size(135, 102);
      this.pnlCommands.TabIndex = 112;
      // 
      // lblSwapTtlAlb
      // 
      this.lblSwapTtlAlb.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblSwapTtlAlb.AutoSize = true;
      this.lblSwapTtlAlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapTtlAlb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapTtlAlb.Location = new System.Drawing.Point(22, 73);
      this.lblSwapTtlAlb.Name = "lblSwapTtlAlb";
      this.lblSwapTtlAlb.Size = new System.Drawing.Size(89, 13);
      this.lblSwapTtlAlb.TabIndex = 5;
      this.lblSwapTtlAlb.TabStop = true;
      this.lblSwapTtlAlb.Text = "Swap Title-Album";
      this.lblSwapTtlAlb.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapTtlAlb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSwapTtlAlb_LinkClicked);
      // 
      // lblSwapArtAlb
      // 
      this.lblSwapArtAlb.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblSwapArtAlb.AutoSize = true;
      this.lblSwapArtAlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtAlb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtAlb.Location = new System.Drawing.Point(22, 52);
      this.lblSwapArtAlb.Name = "lblSwapArtAlb";
      this.lblSwapArtAlb.Size = new System.Drawing.Size(92, 13);
      this.lblSwapArtAlb.TabIndex = 4;
      this.lblSwapArtAlb.TabStop = true;
      this.lblSwapArtAlb.Text = "Swap Artist-Album";
      this.lblSwapArtAlb.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtAlb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSwapArtAlb_LinkClicked);
      // 
      // lblSwapArtTtl
      // 
      this.lblSwapArtTtl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblSwapArtTtl.AutoSize = true;
      this.lblSwapArtTtl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtTtl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtTtl.Location = new System.Drawing.Point(22, 31);
      this.lblSwapArtTtl.Name = "lblSwapArtTtl";
      this.lblSwapArtTtl.Size = new System.Drawing.Size(83, 13);
      this.lblSwapArtTtl.TabIndex = 3;
      this.lblSwapArtTtl.TabStop = true;
      this.lblSwapArtTtl.Text = "Swap Artist-Title";
      this.lblSwapArtTtl.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtTtl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSwapArtTtl_LinkClicked);
      // 
      // lblCommand
      // 
      this.lblCommand.AutoSize = true;
      this.lblCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblCommand.Location = new System.Drawing.Point(11, 9);
      this.lblCommand.Name = "lblCommand";
      this.lblCommand.Size = new System.Drawing.Size(68, 15);
      this.lblCommand.TabIndex = 0;
      this.lblCommand.Text = "Commands";
      // 
      // frmTAG1Multi
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(611, 280);
      this.ControlBox = false;
      this.Controls.Add(this.pnlCommands);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.lblInfoStar);
      this.Controls.Add(this.txtYear);
      this.Controls.Add(this.txtTrack);
      this.Controls.Add(this.cmbGenre);
      this.Controls.Add(this.cmbArtist);
      this.Controls.Add(this.txtAlbum);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.txtTitle);
      this.Controls.Add(this.CheckBox7);
      this.Controls.Add(this.CheckBox6);
      this.Controls.Add(this.CheckBox5);
      this.Controls.Add(this.CheckBox4);
      this.Controls.Add(this.CheckBox3);
      this.Controls.Add(this.CheckBox2);
      this.Controls.Add(this.CheckBox1);
      this.Controls.Add(this.lblGenre);
      this.Controls.Add(this.lblComment);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.lblAlbum);
      this.Controls.Add(this.lblYear);
      this.Controls.Add(this.lblTrack);
      this.Controls.Add(this.lblArtist);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG1Multi";
      this.ShowInTaskbar = false;
      this.Text = "Multiple Edit TAG Ver. 1";
      this.pnlCommands.ResumeLayout(false);
      this.pnlCommands.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    public frmTAG1Multi(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG1Multi_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Events

    private void btnOK_Click(object sender, EventArgs e)
    {
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      this.SaveToTAG();
      this.Close();
    }

    private void cmbArtist_SelectedIndexChanged(object sender, EventArgs e)
    {
      object obj2 = LateBinding.LateGet(sender, null, "Name", new object[0], null, null);

      if (ObjectType.ObjTst(obj2, "cmbArtist", false) == 0)
        this.CheckBox1.Checked = true;
      else if (ObjectType.ObjTst(obj2, "cmbGenre", false) == 0)
        this.CheckBox6.Checked = true;
    }

    private void frmTAG1Multi_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;

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
      this.AddToolTips();
      //this.UpdateI18n(); FIXME - do language stuff later
      this.cmbArtist.Select();
      this.cmbArtist.Focus();
    }

    private void lblSwapArtAlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
    }

    private void lblSwapArtTtl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtTitle.Text;
      this.txtTitle.Text = text;
    }

    private void lblSwapTtlAlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = this.txtTitle.Text;
      this.txtTitle.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
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

    private void txt_TextChanged(object sender, EventArgs e)
    {
      object obj2 = LateBinding.LateGet(sender, null, "Name", new object[0], null, null);

      if (ObjectType.ObjTst(obj2, "cmbArtist", false) == 0)
        this.CheckBox1.Checked = true;
      else if (ObjectType.ObjTst(obj2, "txtTitle", false) == 0)
        this.CheckBox2.Checked = true;
      else if (ObjectType.ObjTst(obj2, "txtAlbum", false) == 0)
        this.CheckBox3.Checked = true;
      else if (ObjectType.ObjTst(obj2, "txtYear", false) == 0)
        this.CheckBox4.Checked = true;
      else if (ObjectType.ObjTst(obj2, "txtTrack", false) == 0)
        this.CheckBox5.Checked = true;
      else if (ObjectType.ObjTst(obj2, "cmbGenre", false) == 0)
        this.CheckBox6.Checked = true;
      else if (ObjectType.ObjTst(obj2, "txtComment", false) == 0)
        this.CheckBox7.Checked = true;
    }

    private void txtTrack_Leave(object sender, EventArgs e)
    {
      if (Conversion.Val(this.txtTrack.Text) > 0.0)
      {
        if (this.txtComment.TextLength > 0x1c)
          this.txtComment.Text = this.txtComment.Text.Substring(0, 0x1c);

        this.txtComment.MaxLength = 0x1c;
      }
      else
        this.txtComment.MaxLength = 30;
    }

    private void txtTrack_Validating(object sender, CancelEventArgs e)
    {
      if ((int)txtTrack.ValidateText() < 0 || (int)txtTrack.ValidateText() > 255)
        e.Cancel = true;
    }

    private void txtYear_Validating(object sender, CancelEventArgs e)
    {
      if ((int)txtYear.ValidateText() < 1800 || (int)txtYear.ValidateText() > 2100)
        e.Cancel = true;
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmTAG1Multi";
      Control objControl = this.CheckBox1;
      this.CheckBox1 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox1, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox2;
      this.CheckBox2 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox2, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox3;
      this.CheckBox3 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox3, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox4;
      this.CheckBox4 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox4, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox5;
      this.CheckBox5 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox5, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox6;
      this.CheckBox6 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox6, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox7;
      this.CheckBox7 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox7, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1";
      objControl = this.txtAlbum;
      this.txtAlbum = (System.Windows.Forms.TextBox)objControl;
      this.ToolTip.SetToolTip(this.txtAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1";
      objControl = this.txtComment;
      this.txtComment = (System.Windows.Forms.TextBox)objControl;
      this.ToolTip.SetToolTip(this.txtComment, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1";
      objControl = this.txtTitle;
      this.txtTitle = (System.Windows.Forms.TextBox)objControl;
      this.ToolTip.SetToolTip(this.txtTitle, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1";
      objControl = this.txtTrack;
      this.txtTrack = (MaskedTextBox)objControl;
      this.ToolTip.SetToolTip(this.txtTrack, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1";
      objControl = this.txtYear;
      this.txtYear = (MaskedTextBox)objControl;
      this.ToolTip.SetToolTip(this.txtYear, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1";
      objControl = this.cmbArtist;
      this.cmbArtist = (ComboBoxAutoComplete)objControl;
      this.ToolTip.SetToolTip(this.cmbArtist, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTAG1";
      objControl = this.cmbGenre;
      this.cmbGenre = (ComboBoxAutoComplete)objControl;
      this.ToolTip.SetToolTip(this.cmbGenre, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
    }

    private string CheckReplace(V1TAG V1ReplaceTAG, string vstrEntry)
    {
      if ((vstrEntry.IndexOf("<") >= 0) && (vstrEntry.IndexOf(">") >= 0))
      {
        vstrEntry = vstrEntry.Replace("<A>", V1ReplaceTAG.Artist);
        vstrEntry = vstrEntry.Replace("<T>", V1ReplaceTAG.Title);
        vstrEntry = vstrEntry.Replace("<B>", V1ReplaceTAG.Album);
        vstrEntry = vstrEntry.Replace("<Y>", V1ReplaceTAG.Year.ToString());
        vstrEntry = vstrEntry.Replace("<K>", V1ReplaceTAG.Tracknumber.ToString());
        vstrEntry = vstrEntry.Replace("<C>", V1ReplaceTAG.Comment);
        vstrEntry = vstrEntry.Replace("<G>", V1ReplaceTAG.GenreText);

        return vstrEntry;
      }

      return vstrEntry;
    }

    private void FillForm()
    {
      byte num = 0;
      this.cmbArtist.Autocomplete = false;

      if (this.MainForm.MP3View.SelectedItems.Count > 0)
      {
        MP3 tag = (MP3)this.MainForm.MP3View.SelectedItems[0].Tag;

        foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
        {
          MP3 mp2 = (MP3)item.Tag;

          if (tag != mp2)
          {
            if ((((num & 1) == 0) && (StringType.StrCmp(mp2.V1TAG.Artist.ToLower(), tag.V1TAG.Artist.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Artist, "", false) == 0))
              num = (byte)(num | 1);

            if ((((num & 2) == 0) && (StringType.StrCmp(mp2.V1TAG.Title.ToLower(), tag.V1TAG.Title.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Title, "", false) == 0))
              num = (byte)(num | 2);

            if ((((num & 4) == 0) && (StringType.StrCmp(mp2.V1TAG.Album.ToLower(), tag.V1TAG.Album.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Album, "", false) == 0))
              num = (byte)(num | 4);

            if ((((num & 8) == 0) && (mp2.V1TAG.Year != tag.V1TAG.Year)) | (mp2.V1TAG.Year == 0))
              num = (byte)(num | 8);

            if ((((num & 0x10) == 0) && (StringType.StrCmp(mp2.V1TAG.GenreText.ToLower(), tag.V1TAG.GenreText.ToLower(), false) != 0)) | (mp2.V1TAG.GenreByte == 0xff))
              num = (byte)(num | 0x10);

            if ((((num & 0x20) == 0) && (StringType.StrCmp(mp2.V1TAG.Comment.ToLower(), tag.V1TAG.Comment.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Comment, "", false) == 0))
              num = (byte)(num | 0x20);

            if (num == 0x3f)
              break;
          }
        }

        if (num != 0x3f)
        {
          if ((num & 1) == 0)
            this.cmbArtist.Text = tag.V1TAG.Artist;

          if ((num & 2) == 0)
            this.txtTitle.Text = tag.V1TAG.Title;

          if ((num & 4) == 0)
            this.txtAlbum.Text = tag.V1TAG.Album;

          try
          {
            if ((num & 8) == 0)
              this.txtYear.Text = StringType.FromObject(Interaction.IIf(tag.V1TAG.Year == 0, "", tag.V1TAG.Year.ToString()));
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }

          if ((num & 0x10) == 0)
            this.cmbGenre.Text = tag.V1TAG.GenreText;

          if ((num & 0x20) == 0)
            this.txtComment.Text = tag.V1TAG.Comment;
        }
      }

      this.CheckBox1.Checked = false;
      this.CheckBox2.Checked = false;
      this.CheckBox3.Checked = false;
      this.CheckBox4.Checked = false;
      this.CheckBox5.Checked = false;
      this.CheckBox6.Checked = false;
      this.CheckBox7.Checked = false;
      this.cmbArtist.Autocomplete = true;
    }

    private void Multi1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        object obj2;
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        MP3 tag = (MP3)item.Tag;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        frmProg.lblInfo.Text = tag.CurrentFullName.Replace("&", "&&");
        V1TAG vtag = tag.V1TAG.Clone();

        if (this.CheckBox1.Checked)
        {
          if (StringType.StrCmp(tag.V1TAG.Artist, this.cmbArtist.Text, false) != 0)
          {
            tag.V1TAG.Artist = this.CheckReplace(vtag, this.cmbArtist.Text);
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }

          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = ID3Functions.CreateTextFrame("TPE1", tag.V1TAG.Artist);

            if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);

            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }

        if (this.CheckBox2.Checked)
        {
          if (StringType.StrCmp(tag.V1TAG.Title, this.txtTitle.Text, false) != 0)
          {
            tag.V1TAG.Title = this.CheckReplace(vtag, this.txtTitle.Text);
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }

          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = ID3Functions.CreateTextFrame("TIT2", tag.V1TAG.Title);

            if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);

            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }

        if (this.CheckBox3.Checked)
        {
          if (StringType.StrCmp(tag.V1TAG.Album, this.txtAlbum.Text, false) != 0)
          {
            tag.V1TAG.Album = this.CheckReplace(vtag, this.txtAlbum.Text);
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }

          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = ID3Functions.CreateTextFrame("TALB", tag.V1TAG.Album);

            if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);

            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }

        if (this.CheckBox4.Checked)
        {
          if (tag.V1TAG.Year != Conversion.Val(this.txtYear.Text))
          {
            tag.V1TAG.Year = (int)Math.Round(Conversion.Val(this.txtYear.Text));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }

          if (Declarations.objSettings.SynchronizeTAGs)
          {
            if (!tag.V2TAG.TAGHeaderPresent)
              tag.V2TAG.TAGHeaderPresent = true;

            if (tag.V2TAG.TAGVersion == DoubleType.FromString("3"))
            {
              obj2 = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text.PadLeft(4, '0'));

              if (StringType.StrCmp(this.txtYear.Text, "", false) == 0)
                LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);

              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
            else
            {
              obj2 = ID3Functions.CreateTextFrame("TDRC", this.txtYear.Text.PadLeft(4, '0'));

              if (StringType.StrCmp(this.txtYear.Text, "", false) == 0)
                LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);

              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
          }
        }

        if (this.CheckBox5.Checked)
        {
          if (tag.V1TAG.Tracknumber != Conversion.Val(this.txtTrack.Text))
          {
            tag.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(this.txtTrack.Text));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }

          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = ID3Functions.CreateTextFrame("TRCK", this.txtTrack.Text.PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'));

            if (Conversion.Val(this.txtTrack.Text) == 0.0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);

            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }

        if (this.CheckBox6.Checked)
        {
          if (tag.V1TAG.GenreByte != ID3Functions.GetV1GenreByName(this.cmbGenre.Text))
          {
            tag.V1TAG.GenreText = this.cmbGenre.Text;
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }

          if (Declarations.objSettings.SynchronizeTAGs)
          {
            string text = this.cmbGenre.Text;

            foreach (DataRow row in Declarations.objSettings.Genres.Rows)
            {
              if (ObjectType.ObjTst(row["V1V2"], ID3Functions.GetV1GenreByName(this.cmbGenre.Text), false) == 0)
              {
                text = row["Name"].ToString();
                break;
              }
            }

            obj2 = ID3Functions.CreateTextFrame("TCON", text);

            if (StringType.StrCmp(this.cmbGenre.Text.Trim(new char[] { ' ' }), "", false) == 0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);

            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }

        if (this.CheckBox7.Checked)
        {
          if (StringType.StrCmp(tag.V1TAG.Comment, this.txtComment.Text, false) != 0)
          {
            tag.V1TAG.Comment = this.CheckReplace(vtag, this.txtComment.Text);
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }

          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = new V2LDCFrame();
            LateBinding.LateSet(obj2, null, "FID", new object[] { "COMM" }, null);
            LateBinding.LateSet(obj2, null, "Language", new object[] { Declarations.astrLanLookup[Declarations.objSettings.V2Language].Substring(0, 3) }, null);
            LateBinding.LateSet(obj2, null, "Descriptor", new object[] { Declarations.objSettings.TransferCommentD }, null);
            LateBinding.LateSet(obj2, null, "Content", new object[] { tag.V1TAG.Comment }, null);

            if (StringType.StrCmp(this.txtComment.Text, "", false) == 0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);

            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }

        if (tag.V2TAG.Changed)
        {
          if (!tag.V2TAG.TAGHeaderPresent)
            tag.V2TAG.TAGHeaderPresent = true;

          tag.Changed = true;
        }

        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void SaveToTAG()
    {
      ArrayList list = new ArrayList();
      this.MainForm.MP3View.BeginUpdate();
      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.Multi1CB);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref ownerForm, ref cB);

      progress.SetStateMultiple();
      progress.List = list;
      progress.ShowDialog(this);
      this.MainForm.MP3View.EndUpdate();

      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
      }

      ownerForm = this;
      Id3TagIT_Main.SaveFormSettings(ref ownerForm);
      this.Close();
    }

    // FIXME This simply does the i18n text swaps.  Do this later.
    //private void UpdateI18n()
    //{
    //  IEnumerator enumerator = null;

    //  try
    //  {
    //    enumerator = this.SelectionBar.Groups.GetEnumerator();

    //    while (enumerator.MoveNext())
    //    {
    //      ExplorerBarGroupItem current = (ExplorerBarGroupItem)enumerator.Current;
    //      current.Text = StringType.FromObject(Declarations.objResources.SelectionBar[current.Name]);

    //      try
    //      {
    //        foreach (ButtonItem item in current.SubItems)
    //          item.Text = StringType.FromObject(Declarations.objResources.SelectionBar[item.Name]);

    //        continue;
    //      }
    //      catch (Exception exception1)
    //      {
    //        ProjectData.SetProjectError(exception1);
    //        ProjectData.ClearProjectError();
    //        continue;
    //      }
    //    }
    //  }
    //  finally
    //  {
    //    if (enumerator is IDisposable)
    //      ((IDisposable)enumerator).Dispose();
    //  }
    //}

    #endregion
  }
}