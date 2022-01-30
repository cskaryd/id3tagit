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
  public class frmTAG1 : Form
  {
    #region Designer

    private Button btnCancel;
    private Button btnOK;
    private ComboBoxAutoComplete cmbArtist;
    private ComboBoxAutoComplete cmbGenre;
    private Label lblAlbum;
    private Label lblArtist;
    private Label lblComment;
    private Label lblGenre;
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
    private Control FocusedControl;
    private frmMain MainForm;
    private Label lblSelected;
    private LinkLabel lnkNext;
    private LinkLabel lnkPrevious;
    private LinkLabel lnkSwapAT;
    private LinkLabel lnkSwapAA;
    private LinkLabel lnkSwapTA;
    private Panel pnlActions;
    private System.Windows.Forms.TextBox txtSelected;

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
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.txtTrack = new System.Windows.Forms.MaskedTextBox();
      this.txtYear = new System.Windows.Forms.MaskedTextBox();
      this.lblSelected = new System.Windows.Forms.Label();
      this.txtSelected = new System.Windows.Forms.TextBox();
      this.lnkNext = new System.Windows.Forms.LinkLabel();
      this.lnkPrevious = new System.Windows.Forms.LinkLabel();
      this.lnkSwapAT = new System.Windows.Forms.LinkLabel();
      this.lnkSwapAA = new System.Windows.Forms.LinkLabel();
      this.lnkSwapTA = new System.Windows.Forms.LinkLabel();
      this.pnlActions = new System.Windows.Forms.Panel();
      this.cmbGenre = new ID3_TagIT.ComboBoxAutoComplete();
      this.cmbArtist = new ID3_TagIT.ComboBoxAutoComplete();
      this.pnlActions.SuspendLayout();
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
      // txtTrack
      // 
      this.txtTrack.Location = new System.Drawing.Point(328, 150);
      this.txtTrack.Mask = "000";
      this.txtTrack.Name = "txtTrack";
      this.txtTrack.Size = new System.Drawing.Size(64, 20);
      this.txtTrack.TabIndex = 9;
      this.txtTrack.ValidatingType = typeof(int);
      this.txtTrack.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTrack.Leave += new System.EventHandler(this.Focus_Leave);
      this.txtTrack.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrack_Validating);
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(328, 126);
      this.txtYear.Mask = "0000";
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(64, 20);
      this.txtYear.TabIndex = 7;
      this.txtYear.ValidatingType = typeof(int);
      this.txtYear.Enter += new System.EventHandler(this.Select_Enter);
      this.txtYear.Leave += new System.EventHandler(this.Focus_Leave);
      this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
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
      // lnkNext
      // 
      this.lnkNext.BackColor = System.Drawing.SystemColors.ControlDark;
      this.lnkNext.Image = global::Properties.Resources.Next;
      this.lnkNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkNext.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.lnkNext.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
      this.lnkNext.Location = new System.Drawing.Point(17, 180);
      this.lnkNext.Name = "lnkNext";
      this.lnkNext.Size = new System.Drawing.Size(120, 17);
      this.lnkNext.TabIndex = 0;
      this.lnkNext.TabStop = true;
      this.lnkNext.Text = "       Next File";
      this.lnkNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNext_LinkClicked);
      // 
      // lnkPrevious
      // 
      this.lnkPrevious.BackColor = System.Drawing.SystemColors.ControlDark;
      this.lnkPrevious.Image = global::Properties.Resources.Previous;
      this.lnkPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkPrevious.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.lnkPrevious.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
      this.lnkPrevious.Location = new System.Drawing.Point(17, 160);
      this.lnkPrevious.Name = "lnkPrevious";
      this.lnkPrevious.Size = new System.Drawing.Size(120, 17);
      this.lnkPrevious.TabIndex = 1;
      this.lnkPrevious.TabStop = true;
      this.lnkPrevious.Text = "       Previous File";
      this.lnkPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkPrevious.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrevious_LinkClicked);
      // 
      // lnkSwapAT
      // 
      this.lnkSwapAT.BackColor = System.Drawing.SystemColors.ControlDark;
      this.lnkSwapAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkSwapAT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.lnkSwapAT.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
      this.lnkSwapAT.Location = new System.Drawing.Point(17, 200);
      this.lnkSwapAT.Name = "lnkSwapAT";
      this.lnkSwapAT.Size = new System.Drawing.Size(120, 17);
      this.lnkSwapAT.TabIndex = 21;
      this.lnkSwapAT.TabStop = true;
      this.lnkSwapAT.Text = "       Swap Artist-Title";
      this.lnkSwapAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkSwapAT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSwapAT_LinkClicked);
      // 
      // lnkSwapAA
      // 
      this.lnkSwapAA.BackColor = System.Drawing.SystemColors.ControlDark;
      this.lnkSwapAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkSwapAA.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.lnkSwapAA.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
      this.lnkSwapAA.Location = new System.Drawing.Point(17, 220);
      this.lnkSwapAA.Name = "lnkSwapAA";
      this.lnkSwapAA.Size = new System.Drawing.Size(120, 17);
      this.lnkSwapAA.TabIndex = 22;
      this.lnkSwapAA.TabStop = true;
      this.lnkSwapAA.Text = "       Swap Artist-Album";
      this.lnkSwapAA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkSwapAA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSwapAA_LinkClicked);
      // 
      // lnkSwapTA
      // 
      this.lnkSwapTA.BackColor = System.Drawing.SystemColors.ControlDark;
      this.lnkSwapTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkSwapTA.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.lnkSwapTA.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
      this.lnkSwapTA.Location = new System.Drawing.Point(17, 240);
      this.lnkSwapTA.Name = "lnkSwapTA";
      this.lnkSwapTA.Size = new System.Drawing.Size(120, 17);
      this.lnkSwapTA.TabIndex = 23;
      this.lnkSwapTA.TabStop = true;
      this.lnkSwapTA.Text = "       Swap Title-Album";
      this.lnkSwapTA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lnkSwapTA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSwapTA_LinkClicked);
      // 
      // pnlActions
      // 
      this.pnlActions.BackColor = System.Drawing.SystemColors.ControlDark;
      this.pnlActions.Controls.Add(this.lnkPrevious);
      this.pnlActions.Controls.Add(this.lnkSwapTA);
      this.pnlActions.Controls.Add(this.lnkNext);
      this.pnlActions.Controls.Add(this.lnkSwapAA);
      this.pnlActions.Controls.Add(this.lnkSwapAT);
      this.pnlActions.Location = new System.Drawing.Point(0, 0);
      this.pnlActions.Name = "pnlActions";
      this.pnlActions.Size = new System.Drawing.Size(151, 273);
      this.pnlActions.TabIndex = 24;
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
      // frmTAG1
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(626, 272);
      this.ControlBox = false;
      this.Controls.Add(this.pnlActions);
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
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG1";
      this.ShowInTaskbar = false;
      this.Text = "Edit TAG Ver. 1";
      this.pnlActions.ResumeLayout(false);
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

    private void btnOK_Click(object sender, EventArgs e)
    {
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      this.SaveToTAG();
      this.Close();
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
      //this.AddSelectionBar();
      this.AddToolTips();
      this.cmbArtist.Select();
      this.cmbArtist.Focus();
    }

    private void lnkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.SaveToTAG();

      if (this.MainForm.MP3View.FocusedItem.Index < (this.MainForm.MP3View.Items.Count - 1))
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.FocusedItem.Index + 1].Focused = true;
        this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
        this.ClearForm();
        this.FillForm();

        if (this.ActiveControl == this.lnkNext)
          this.FocusedControl.Focus();
      }
      else if (this.ActiveControl == this.lnkNext)
        this.FocusedControl.Focus();
    }

    private void lnkPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.SaveToTAG();

      if (this.MainForm.MP3View.FocusedItem.Index != 0)
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.FocusedItem.Index - 1].Focused = true;
        this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
        this.ClearForm();
        this.FillForm();

        if (this.ActiveControl == this.lnkPrevious)
          this.FocusedControl.Focus();
      }
      else if (this.ActiveControl == this.lnkPrevious)
        this.FocusedControl.Focus();
    }

    private void lnkSwapAA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
    }

    private void lnkSwapAT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtTitle.Text;
      this.txtTitle.Text = text;
    }

    private void lnkSwapTA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

    //private void AddSelectionBar()
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
      this.txtTrack = (MaskedTextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtTrack, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));

      vstrName = "frmTAG1";
      txtAlbum = this.txtYear;
      this.txtYear = (MaskedTextBox)txtAlbum;
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

    #endregion
  }
}