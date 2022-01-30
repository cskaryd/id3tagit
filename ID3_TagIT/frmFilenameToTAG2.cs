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
  public class frmFilenameToTAG2 : Form
  {
    #region Designer

    private Button btnAdd;
    private Button btnCancel;
    private Button btnOK;
    private Button btnRemove;
    private CheckBox chkSaveName;
    private ComboBox cmbFormat;
    private GroupBox framePara;
    private Label L1;
    private Label L10;
    private Label L11;
    private Label L12;
    private Label L13;
    private Label L14;
    private Label L15;
    private Label L16;
    private Label L17;
    private Label L18;
    private Label L19;
    private Label L2;
    private Label L3;
    private Label L4;
    private Label L5;
    private Label L6;
    private Label L7;
    private Label L8;
    private Label L9;
    private Label lblDigits;
    private Label lblFormat;
    private Label lblInfo;
    private System.Windows.Forms.ToolTip ToolTip;
    private NumericUpDown txtDigits;
    private ArrayList alstFormat;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilenameToTAG2));
      this.lblInfo = new System.Windows.Forms.Label();
      this.lblDigits = new System.Windows.Forms.Label();
      this.txtDigits = new System.Windows.Forms.NumericUpDown();
      this.framePara = new System.Windows.Forms.GroupBox();
      this.L17 = new System.Windows.Forms.Label();
      this.L18 = new System.Windows.Forms.Label();
      this.L16 = new System.Windows.Forms.Label();
      this.L19 = new System.Windows.Forms.Label();
      this.L15 = new System.Windows.Forms.Label();
      this.L14 = new System.Windows.Forms.Label();
      this.L13 = new System.Windows.Forms.Label();
      this.L12 = new System.Windows.Forms.Label();
      this.L11 = new System.Windows.Forms.Label();
      this.L10 = new System.Windows.Forms.Label();
      this.L9 = new System.Windows.Forms.Label();
      this.L8 = new System.Windows.Forms.Label();
      this.L7 = new System.Windows.Forms.Label();
      this.L6 = new System.Windows.Forms.Label();
      this.L5 = new System.Windows.Forms.Label();
      this.L4 = new System.Windows.Forms.Label();
      this.L3 = new System.Windows.Forms.Label();
      this.L2 = new System.Windows.Forms.Label();
      this.L1 = new System.Windows.Forms.Label();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.cmbFormat = new System.Windows.Forms.ComboBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.lblFormat = new System.Windows.Forms.Label();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.chkSaveName = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).BeginInit();
      this.framePara.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblInfo
      // 
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 272);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(496, 56);
      this.lblInfo.TabIndex = 24;
      this.lblInfo.Text = resources.GetString("lblInfo.Text");
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblDigits
      // 
      this.lblDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDigits.Location = new System.Drawing.Point(104, 64);
      this.lblDigits.Name = "lblDigits";
      this.lblDigits.Size = new System.Drawing.Size(184, 16);
      this.lblDigits.TabIndex = 21;
      this.lblDigits.Text = "&Number of digits of track numbers:";
      // 
      // txtDigits
      // 
      this.txtDigits.Location = new System.Drawing.Point(312, 64);
      this.txtDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Name = "txtDigits";
      this.txtDigits.Size = new System.Drawing.Size(64, 20);
      this.txtDigits.TabIndex = 22;
      this.txtDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Validated += new System.EventHandler(this.txtDigits_Validated);
      // 
      // framePara
      // 
      this.framePara.Controls.Add(this.L17);
      this.framePara.Controls.Add(this.L18);
      this.framePara.Controls.Add(this.L16);
      this.framePara.Controls.Add(this.L19);
      this.framePara.Controls.Add(this.L15);
      this.framePara.Controls.Add(this.L14);
      this.framePara.Controls.Add(this.L13);
      this.framePara.Controls.Add(this.L12);
      this.framePara.Controls.Add(this.L11);
      this.framePara.Controls.Add(this.L10);
      this.framePara.Controls.Add(this.L9);
      this.framePara.Controls.Add(this.L8);
      this.framePara.Controls.Add(this.L7);
      this.framePara.Controls.Add(this.L6);
      this.framePara.Controls.Add(this.L5);
      this.framePara.Controls.Add(this.L4);
      this.framePara.Controls.Add(this.L3);
      this.framePara.Controls.Add(this.L2);
      this.framePara.Controls.Add(this.L1);
      this.framePara.Location = new System.Drawing.Point(8, 112);
      this.framePara.Name = "framePara";
      this.framePara.Size = new System.Drawing.Size(496, 152);
      this.framePara.TabIndex = 23;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      // 
      // L17
      // 
      this.L17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L17.Location = new System.Drawing.Point(8, 88);
      this.L17.Name = "L17";
      this.L17.Size = new System.Drawing.Size(152, 16);
      this.L17.TabIndex = 18;
      this.L17.Text = "<R> = Composer";
      this.L17.Click += new System.EventHandler(this.Label_Click);
      // 
      // L18
      // 
      this.L18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L18.Location = new System.Drawing.Point(328, 104);
      this.L18.Name = "L18";
      this.L18.Size = new System.Drawing.Size(152, 16);
      this.L18.TabIndex = 17;
      this.L18.Text = "<X> = Unused";
      this.L18.Click += new System.EventHandler(this.Label_Click);
      // 
      // L16
      // 
      this.L16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L16.Location = new System.Drawing.Point(8, 104);
      this.L16.Name = "L16";
      this.L16.Size = new System.Drawing.Size(160, 16);
      this.L16.TabIndex = 16;
      this.L16.Text = "<E> = Beats/minute (BPM)";
      this.L16.Click += new System.EventHandler(this.Label_Click);
      // 
      // L19
      // 
      this.L19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L19.Location = new System.Drawing.Point(24, 128);
      this.L19.Name = "L19";
      this.L19.Size = new System.Drawing.Size(136, 16);
      this.L19.TabIndex = 15;
      this.L19.Text = "\\ = Folder";
      // 
      // L15
      // 
      this.L15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L15.Location = new System.Drawing.Point(328, 88);
      this.L15.Name = "L15";
      this.L15.Size = new System.Drawing.Size(160, 16);
      this.L15.TabIndex = 14;
      this.L15.Text = "<O> = Band / Orchestra";
      this.L15.Click += new System.EventHandler(this.Label_Click);
      // 
      // L14
      // 
      this.L14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L14.Location = new System.Drawing.Point(168, 88);
      this.L14.Name = "L14";
      this.L14.Size = new System.Drawing.Size(160, 16);
      this.L14.TabIndex = 13;
      this.L14.Text = "<S> = Subtitle";
      this.L14.Click += new System.EventHandler(this.Label_Click);
      // 
      // L13
      // 
      this.L13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L13.Location = new System.Drawing.Point(168, 104);
      this.L13.Name = "L13";
      this.L13.Size = new System.Drawing.Size(160, 16);
      this.L13.TabIndex = 12;
      this.L13.Text = "<M> = Modified / Remixed by";
      this.L13.Click += new System.EventHandler(this.Label_Click);
      // 
      // L12
      // 
      this.L12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L12.Location = new System.Drawing.Point(328, 72);
      this.L12.Name = "L12";
      this.L12.Size = new System.Drawing.Size(160, 16);
      this.L12.TabIndex = 11;
      this.L12.Text = "<N> = Conductor";
      this.L12.Click += new System.EventHandler(this.Label_Click);
      // 
      // L11
      // 
      this.L11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L11.Location = new System.Drawing.Point(168, 72);
      this.L11.Name = "L11";
      this.L11.Size = new System.Drawing.Size(160, 16);
      this.L11.TabIndex = 10;
      this.L11.Text = "<p> = Total number of medias";
      this.L11.Click += new System.EventHandler(this.Label_Click);
      // 
      // L10
      // 
      this.L10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L10.Location = new System.Drawing.Point(8, 72);
      this.L10.Name = "L10";
      this.L10.Size = new System.Drawing.Size(160, 16);
      this.L10.TabIndex = 9;
      this.L10.Text = "<P> = Position in media set";
      this.L10.Click += new System.EventHandler(this.Label_Click);
      // 
      // L9
      // 
      this.L9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L9.Location = new System.Drawing.Point(328, 56);
      this.L9.Name = "L9";
      this.L9.Size = new System.Drawing.Size(160, 16);
      this.L9.TabIndex = 8;
      this.L9.Text = "<U> = Content Group";
      this.L9.Click += new System.EventHandler(this.Label_Click);
      // 
      // L8
      // 
      this.L8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L8.Location = new System.Drawing.Point(168, 56);
      this.L8.Name = "L8";
      this.L8.Size = new System.Drawing.Size(160, 16);
      this.L8.TabIndex = 7;
      this.L8.Text = "<k> = Total number of tracks";
      this.L8.Click += new System.EventHandler(this.Label_Click);
      // 
      // L7
      // 
      this.L7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L7.Location = new System.Drawing.Point(8, 56);
      this.L7.Name = "L7";
      this.L7.Size = new System.Drawing.Size(160, 16);
      this.L7.TabIndex = 6;
      this.L7.Text = "<K> = Track number";
      this.L7.Click += new System.EventHandler(this.Label_Click);
      // 
      // L6
      // 
      this.L6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L6.Location = new System.Drawing.Point(328, 40);
      this.L6.Name = "L6";
      this.L6.Size = new System.Drawing.Size(160, 16);
      this.L6.TabIndex = 5;
      this.L6.Text = "<G> = First Genre";
      this.L6.Click += new System.EventHandler(this.Label_Click);
      // 
      // L5
      // 
      this.L5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L5.Location = new System.Drawing.Point(168, 40);
      this.L5.Name = "L5";
      this.L5.Size = new System.Drawing.Size(160, 16);
      this.L5.TabIndex = 4;
      this.L5.Text = "<Y> = Year";
      this.L5.Click += new System.EventHandler(this.Label_Click);
      // 
      // L4
      // 
      this.L4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L4.Location = new System.Drawing.Point(8, 40);
      this.L4.Name = "L4";
      this.L4.Size = new System.Drawing.Size(160, 16);
      this.L4.TabIndex = 3;
      this.L4.Text = "<C> = Comment";
      this.L4.Click += new System.EventHandler(this.Label_Click);
      // 
      // L3
      // 
      this.L3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L3.Location = new System.Drawing.Point(328, 24);
      this.L3.Name = "L3";
      this.L3.Size = new System.Drawing.Size(160, 16);
      this.L3.TabIndex = 2;
      this.L3.Text = "<B> = Album";
      this.L3.Click += new System.EventHandler(this.Label_Click);
      // 
      // L2
      // 
      this.L2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L2.Location = new System.Drawing.Point(168, 24);
      this.L2.Name = "L2";
      this.L2.Size = new System.Drawing.Size(160, 16);
      this.L2.TabIndex = 1;
      this.L2.Text = "<T> = Title";
      this.L2.Click += new System.EventHandler(this.Label_Click);
      // 
      // L1
      // 
      this.L1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L1.Location = new System.Drawing.Point(8, 24);
      this.L1.Name = "L1";
      this.L1.Size = new System.Drawing.Size(160, 16);
      this.L1.TabIndex = 0;
      this.L1.Text = "<A> = Artist";
      this.L1.Click += new System.EventHandler(this.Label_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemove.Location = new System.Drawing.Point(312, 32);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(192, 24);
      this.btnRemove.TabIndex = 18;
      this.btnRemove.Text = "&Remove format from list";
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(104, 32);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(192, 24);
      this.btnAdd.TabIndex = 17;
      this.btnAdd.Text = "&Add format to list";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // cmbFormat
      // 
      this.cmbFormat.ItemHeight = 13;
      this.cmbFormat.Location = new System.Drawing.Point(104, 8);
      this.cmbFormat.Name = "cmbFormat";
      this.cmbFormat.Size = new System.Drawing.Size(400, 21);
      this.cmbFormat.TabIndex = 16;
      this.cmbFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFormat_KeyPress);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(384, 336);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 26;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(256, 336);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 25;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblFormat
      // 
      this.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblFormat.Location = new System.Drawing.Point(8, 8);
      this.lblFormat.Name = "lblFormat";
      this.lblFormat.Size = new System.Drawing.Size(96, 16);
      this.lblFormat.TabIndex = 15;
      this.lblFormat.Text = "&Format:";
      // 
      // chkSaveName
      // 
      this.chkSaveName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkSaveName.Location = new System.Drawing.Point(104, 88);
      this.chkSaveName.Name = "chkSaveName";
      this.chkSaveName.Size = new System.Drawing.Size(392, 16);
      this.chkSaveName.TabIndex = 23;
      this.chkSaveName.Text = "Save filename to original filename entry";
      // 
      // frmFilenameToTAG2
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(514, 365);
      this.ControlBox = false;
      this.Controls.Add(this.chkSaveName);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.lblDigits);
      this.Controls.Add(this.txtDigits);
      this.Controls.Add(this.framePara);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.cmbFormat);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.lblFormat);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmFilenameToTAG2";
      this.ShowInTaskbar = false;
      this.Text = "Filename -> TAG Ver. 2";
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).EndInit();
      this.framePara.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    public frmFilenameToTAG2(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmFilenameToTAG2_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Events

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.cmbFormat.Text, "", false) != 0)
        this.cmbFormat.Items.Add(this.cmbFormat.Text);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      FilenameToTAGFormat format = new FilenameToTAGFormat();
      ArrayList list = new ArrayList();
      string vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });

      if (vstrFormat.IndexOf(":") >= 0)
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });

      if (vstrFormat.StartsWith(@"\"))
        vstrFormat = vstrFormat.Substring(1);

      switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.FilenameToTAG | Declarations.FormatReplace.TAGVer2))
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

      byte tracknumberDigitsTAG = Declarations.objSettings.TracknumberDigitsTAG;
      Declarations.objSettings.FT2Formats.Rows.Clear();
      Declarations.objSettings.FT2Format = this.cmbFormat.Text;
      Declarations.objSettings.TracknumberDigitsTAG = Convert.ToByte(this.txtDigits.Value);

      int num3 = this.cmbFormat.Items.Count - 1;
      for (int i = 0; i <= num3; i++)
      {
        DataRow row = Declarations.objSettings.FT2Formats.NewRow();
        row["Format"] = this.cmbFormat.Items[i].ToString();
        Declarations.objSettings.FT2Formats.Rows.Add(row);
      }

      Declarations.objSettings.SaveOFilename = this.chkSaveName.Checked;
      format.Create(vstrFormat, 2);
      this.alstFormat = format.Parts;
      this.MainForm.MP3View.BeginUpdate();
      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.FilenameTAGV2CB);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref ownerForm, ref cB);
      progress.SetStateFilenameTAG();
      progress.List = list;
      progress.ShowDialog(this);
      this.MainForm.MP3View.EndUpdate();

      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
      }

      progress.Close();
      Declarations.objSettings.TracknumberDigitsTAG = tracknumberDigitsTAG;
      ownerForm = this;
      Id3TagIT_Main.SaveFormSettings(ref ownerForm);
      this.Close();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      this.cmbFormat.Items.Remove(this.cmbFormat.Text);
    }

    private void cmbFormat_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '|':
        case '"':
        case '/':
        case '*':
        case '?':
          e.Handled = true;
          break;
      }
    }

    private void frmFilenameToTAG2_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
      int num2 = Declarations.objSettings.FT2Formats.Rows.Count - 1;

      for (int i = 0; i <= num2; i++)
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.FT2Formats.Rows[i]["Format"]));

      this.cmbFormat.Text = Declarations.objSettings.FT2Format;
      this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);
      this.chkSaveName.Checked = Declarations.objSettings.SaveOFilename;
      this.AddToolTips();
    }

    private void Label_Click(object sender, EventArgs e)
    {
      string selectedText = this.cmbFormat.SelectedText;
      int selectionStart = this.cmbFormat.SelectionStart;

      if (this.cmbFormat.SelectionLength == 0)
      {
        this.cmbFormat.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(this.cmbFormat.Text.Substring(0, this.cmbFormat.SelectionStart), LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 3 }, null, null)), this.cmbFormat.Text.Substring(this.cmbFormat.SelectionStart)));
        this.cmbFormat.SelectionStart = selectionStart + 3;
      }
      else
      {
        string str2 = this.cmbFormat.Text.Substring(0, selectionStart);
        this.cmbFormat.Text = Strings.Replace(this.cmbFormat.Text, selectedText, StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 3 }, null, null)), selectionStart + 1, 1, CompareMethod.Text);
        this.cmbFormat.Text = str2 + this.cmbFormat.Text;
        this.cmbFormat.SelectionStart = selectionStart + 3;
      }
    }

    private void txtDigits_Validated(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Minimum) < 0)
        this.txtDigits.Value = this.txtDigits.Minimum;

      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Maximum) > 0)
        this.txtDigits.Value = this.txtDigits.Maximum;
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmFilenameToTAG2";
      Control txtDigits = this.txtDigits;
      this.txtDigits = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmFilenameToTAG2";
      txtDigits = this.btnRemove;
      this.btnRemove = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmFilenameToTAG2";
      txtDigits = this.btnAdd;
      this.btnAdd = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmFilenameToTAG2";
      txtDigits = this.cmbFormat;
      this.cmbFormat = (ComboBox)txtDigits;
      this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmFilenameToTAG2";
      txtDigits = this.chkSaveName;
      this.chkSaveName = (CheckBox)txtDigits;
      this.ToolTip.SetToolTip(this.chkSaveName, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
    }

    private void FilenameTAGV2CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        frmProg.Infos.Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null));
        ListViewItem item2 = item;
        MP3 tag = (MP3)item2.Tag;
        ID3Functions.FilenameToTAG(ref tag, this.alstFormat, 2);
        item2.Tag = tag;

        if (this.chkSaveName.Checked)
        {
          MP3 mp = (MP3)item.Tag;
          mp.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TOFN", mp.CurrentName));
        }

        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    #endregion
  }
}