namespace ID3_TagIT
{
  using DevComponents.DotNetBar;
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.ComponentModel;
  using System.Data;
  using System.Diagnostics;
  using System.Drawing;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public class frmCompareFileTAG : Form
  {
    [AccessedThroughProperty("BalloonTip1")]
    private BalloonTip _BalloonTip1;
    [AccessedThroughProperty("btnAdd")]
    private Button _btnAdd;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnRemove")]
    private Button _btnRemove;
    [AccessedThroughProperty("chkIgnoreCase")]
    private CheckBox _chkIgnoreCase;
    [AccessedThroughProperty("chkReplaceUnderScore")]
    private CheckBox _chkReplaceUnderScore;
    [AccessedThroughProperty("cmbFormat")]
    private ComboBox _cmbFormat;
    [AccessedThroughProperty("framePara")]
    private GroupBox _framePara;
    [AccessedThroughProperty("L1")]
    private Label _L1;
    [AccessedThroughProperty("L10")]
    private Label _L10;
    [AccessedThroughProperty("L11")]
    private Label _L11;
    [AccessedThroughProperty("L12")]
    private Label _L12;
    [AccessedThroughProperty("L13")]
    private Label _L13;
    [AccessedThroughProperty("L14")]
    private Label _L14;
    [AccessedThroughProperty("L15")]
    private Label _L15;
    [AccessedThroughProperty("L16")]
    private Label _L16;
    [AccessedThroughProperty("L17")]
    private Label _L17;
    [AccessedThroughProperty("L18")]
    private Label _L18;
    [AccessedThroughProperty("L19")]
    private Label _L19;
    [AccessedThroughProperty("L2")]
    private Label _L2;
    [AccessedThroughProperty("L20")]
    private Label _L20;
    [AccessedThroughProperty("L3")]
    private Label _L3;
    [AccessedThroughProperty("L4")]
    private Label _L4;
    [AccessedThroughProperty("L5")]
    private Label _L5;
    [AccessedThroughProperty("L6")]
    private Label _L6;
    [AccessedThroughProperty("L7")]
    private Label _L7;
    [AccessedThroughProperty("L8")]
    private Label _L8;
    [AccessedThroughProperty("L9")]
    private Label _L9;
    [AccessedThroughProperty("lblDigits")]
    private Label _lblDigits;
    [AccessedThroughProperty("lblFormat")]
    private Label _lblFormat;
    [AccessedThroughProperty("lblInfo")]
    private Label _lblInfo;
    [AccessedThroughProperty("optTAGV1")]
    private RadioButton _optTAGV1;
    [AccessedThroughProperty("optTAGV2")]
    private RadioButton _optTAGV2;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("txtDigits")]
    private NumericUpDown _txtDigits;
    private IContainer components;
    private frmMain MainForm;

    public frmCompareFileTAG(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG2ToFilename_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    private void AddToolTips()
    {
      string vstrName = "frmCompareFileTAG";
      Control txtDigits = this.txtDigits;
      this.txtDigits = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
      vstrName = "frmCompareFileTAG";
      txtDigits = this.btnRemove;
      this.btnRemove = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
      vstrName = "frmCompareFileTAG";
      txtDigits = this.btnAdd;
      this.btnAdd = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
      vstrName = "frmCompareFileTAG";
      txtDigits = this.cmbFormat;
      this.cmbFormat = (ComboBox)txtDigits;
      this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
      vstrName = "frmCompareFileTAG";
      txtDigits = this.optTAGV1;
      this.optTAGV1 = (RadioButton)txtDigits;
      this.ToolTip.SetToolTip(this.optTAGV1, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
      vstrName = "frmCompareFileTAG";
      txtDigits = this.optTAGV2;
      this.optTAGV2 = (RadioButton)txtDigits;
      this.ToolTip.SetToolTip(this.optTAGV2, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
      vstrName = "frmCompareFileTAG";
      txtDigits = this.chkReplaceUnderScore;
      this.chkReplaceUnderScore = (CheckBox)txtDigits;
      this.ToolTip.SetToolTip(this.chkReplaceUnderScore, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
      vstrName = "frmCompareFileTAG";
      txtDigits = this.chkIgnoreCase;
      this.chkIgnoreCase = (CheckBox)txtDigits;
      this.ToolTip.SetToolTip(this.chkIgnoreCase, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.cmbFormat.Text, "", false) != 0)
      {
        this.cmbFormat.Items.Add(this.cmbFormat.Text);
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      string vstrFormat = "";
      vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });
      if (vstrFormat.IndexOf(":") >= 0)
      {
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });
      }
      if (this.optTAGV2.Checked)
      {
        switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.CompareTAGFilename | Declarations.FormatReplace.TAGVer2))
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
      }
      else
      {
        switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.CompareTAGFilename | Declarations.FormatReplace.TAGVer1))
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
      }
      Form form = this;
      Main.SaveFormSettings(ref form);
      if (this.optTAGV2.Checked)
      {
        Declarations.objSettings.CompareFileTAGVersion = 2;
      }
      else
      {
        Declarations.objSettings.CompareFileTAGVersion = 1;
      }
      Declarations.objSettings.CompareFormats.Rows.Clear();
      Declarations.objSettings.CompareFormat = this.cmbFormat.Text;
      Declarations.objSettings.CompareFileTAGReplace = this.chkReplaceUnderScore.Checked;
      Declarations.objSettings.CompareFileTAGIgnoreCase = this.chkIgnoreCase.Checked;
      Declarations.objSettings.TracknumberDigitsFilename = Convert.ToByte(this.txtDigits.Value);
      int num2 = this.cmbFormat.Items.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        DataRow row = Declarations.objSettings.CompareFormats.NewRow();
        row["Format"] = this.cmbFormat.Items[i].ToString();
        Declarations.objSettings.CompareFormats.Rows.Add(row);
      }
      this.MainForm.MP3View.BeginUpdate();
      form = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.CompareFileTAGCB);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.Items.Count, 1, ref form, ref cB);
      progress.SetStateCompareFileTAG();
      progress.String01 = vstrFormat;
      progress.ShowDialog(this);
      this.MainForm.MP3View.EndUpdate();
      form = this;
      Main.SaveFormSettings(ref form);
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

    private void CompareFileTAGCB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.Items)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        MP3 tag = (MP3)item.Tag;
        frmProg.Infos.Text = tag.CurrentFullName;
        string sLeft = ID3Functions.FormatReplacedByTag(tag, frmProg.String01, ByteType.FromObject(Interaction.IIf(this.optTAGV1.Checked, 1, 2))) + tag.FI.Extension;
        if (this.chkReplaceUnderScore.Checked)
        {
          sLeft = sLeft.Replace("<", "_").Replace(">", "_").Replace("|", "_").Replace("\"", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace(":", "_").Trim(new char[] { ' ' });
        }
        if (this.chkIgnoreCase.Checked)
        {
          sLeft = sLeft.ToLower();
        }
        if (StringType.StrCmp(sLeft, "", false) != 0)
        {
          tag.FileTAGCompare = false;
          item.BackColor = SystemColors.Window;
          item.ForeColor = SystemColors.WindowText;
          if (tag.Changed)
          {
            item.BackColor = Color.FromArgb(Declarations.objSettings.ColorChangedBack);
            item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorChangedText);
          }
          if (tag.Doubled)
          {
            item.BackColor = Color.FromArgb(Declarations.objSettings.ColorDoubleBack);
            item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorDoubleText);
          }
          if (this.chkIgnoreCase.Checked)
          {
            if (!tag.CurrentFullName.ToLower().EndsWith(sLeft))
            {
              tag.FileTAGCompare = true;
              item.BackColor = Color.FromArgb(Declarations.objSettings.ColorCompareBack);
              item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorCompareText);
            }
          }
          else if (!tag.CurrentFullName.EndsWith(sLeft))
          {
            tag.FileTAGCompare = true;
            item.BackColor = Color.FromArgb(Declarations.objSettings.ColorCompareBack);
            item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorCompareText);
          }
        }
        frmProg.ProgressBar.PerformStep();
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

    private void frmTAG2ToFilename_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
      int num2 = Declarations.objSettings.CompareFormats.Rows.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.CompareFormats.Rows[i]["Format"]));
      }
      this.cmbFormat.Text = Declarations.objSettings.CompareFormat;
      this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);
      if (Declarations.objSettings.CompareFileTAGVersion == 1)
      {
        this.optTAGV1.Checked = true;
      }
      else
      {
        this.optTAGV2.Checked = true;
      }
      this.chkReplaceUnderScore.Checked = Declarations.objSettings.CompareFileTAGReplace;
      this.chkIgnoreCase.Checked = Declarations.objSettings.CompareFileTAGIgnoreCase;
      this.AddToolTips();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      this.lblInfo = new Label();
      this.lblDigits = new Label();
      this.txtDigits = new NumericUpDown();
      this.framePara = new GroupBox();
      this.L19 = new Label();
      this.L18 = new Label();
      this.L20 = new Label();
      this.L13 = new Label();
      this.L16 = new Label();
      this.L15 = new Label();
      this.L14 = new Label();
      this.L17 = new Label();
      this.L12 = new Label();
      this.L11 = new Label();
      this.L10 = new Label();
      this.L9 = new Label();
      this.L8 = new Label();
      this.L7 = new Label();
      this.L6 = new Label();
      this.L5 = new Label();
      this.L4 = new Label();
      this.L3 = new Label();
      this.L2 = new Label();
      this.L1 = new Label();
      this.btnRemove = new Button();
      this.btnAdd = new Button();
      this.cmbFormat = new ComboBox();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.lblFormat = new Label();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.optTAGV1 = new RadioButton();
      this.optTAGV2 = new RadioButton();
      this.chkReplaceUnderScore = new CheckBox();
      this.chkIgnoreCase = new CheckBox();
      this.BalloonTip1 = new BalloonTip();
      this.txtDigits.BeginInit();
      this.framePara.SuspendLayout();
      this.SuspendLayout();
      this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = ImeMode.NoControl;
      Point point = new Point(8, 320);
      this.lblInfo.Location = point;
      this.lblInfo.Name = "lblInfo";
      Size size = new Size(0x1f0, 40);
      this.lblInfo.Size = size;
      this.lblInfo.TabIndex = 0x22;
      this.lblInfo.Text = "This function compares the current filename with the filename created by the format. If there is a mismatch the file will marked.";
      this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
      this.lblDigits.ImeMode = ImeMode.NoControl;
      point = new Point(0x69, 0x41);
      this.lblDigits.Location = point;
      this.lblDigits.Name = "lblDigits";
      size = new Size(0xb8, 0x10);
      this.lblDigits.Size = size;
      this.lblDigits.TabIndex = 0x1f;
      this.lblDigits.Text = "&Number of digits of track numbers:";
      point = new Point(0x139, 0x3f);
      this.txtDigits.Location = point;
      decimal num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Minimum = num;
      this.txtDigits.Name = "txtDigits";
      size = new Size(0x40, 20);
      this.txtDigits.Size = size;
      this.txtDigits.TabIndex = 0x20;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Value = num;
      this.framePara.Controls.Add(this.L19);
      this.framePara.Controls.Add(this.L18);
      this.framePara.Controls.Add(this.L20);
      this.framePara.Controls.Add(this.L13);
      this.framePara.Controls.Add(this.L16);
      this.framePara.Controls.Add(this.L15);
      this.framePara.Controls.Add(this.L14);
      this.framePara.Controls.Add(this.L17);
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
      point = new Point(9, 0x5f);
      this.framePara.Location = point;
      this.framePara.Name = "framePara";
      size = new Size(0x1f0, 0x91);
      this.framePara.Size = size;
      this.framePara.TabIndex = 0x21;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      this.L19.ImeMode = ImeMode.NoControl;
      point = new Point(12, 120);
      this.L19.Location = point;
      this.L19.Name = "L19";
      size = new Size(0x98, 0x10);
      this.L19.Size = size;
      this.L19.TabIndex = 0x3a;
      this.L19.Text = "<I> = Bitrate";
      this.L18.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x68);
      this.L18.Location = point;
      this.L18.Name = "L18";
      size = new Size(0x98, 0x10);
      this.L18.Size = size;
      this.L18.TabIndex = 0x39;
      this.L18.Text = "<1> = First letter of artist";
      this.L20.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 120);
      this.L20.Location = point;
      this.L20.Name = "L20";
      size = new Size(0x98, 0x10);
      this.L20.Size = size;
      this.L20.TabIndex = 0x38;
      this.L20.Text = @"\ = Folder";
      this.L13.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x58);
      this.L13.Location = point;
      this.L13.Name = "L13";
      size = new Size(0x98, 0x10);
      this.L13.Size = size;
      this.L13.TabIndex = 0x25;
      this.L13.Text = "<R> = Composer";
      this.L16.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x68);
      this.L16.Location = point;
      this.L16.Name = "L16";
      size = new Size(0x98, 0x10);
      this.L16.Size = size;
      this.L16.TabIndex = 0x10;
      this.L16.Text = "<E> = Beats/minute (BPM)";
      this.L15.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x58);
      this.L15.Location = point;
      this.L15.Name = "L15";
      size = new Size(160, 0x10);
      this.L15.Size = size;
      this.L15.TabIndex = 14;
      this.L15.Text = "<O> = Band / Orchestra";
      this.L14.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x58);
      this.L14.Location = point;
      this.L14.Name = "L14";
      size = new Size(160, 0x10);
      this.L14.Size = size;
      this.L14.TabIndex = 13;
      this.L14.Text = "<S> = Subtitle";
      this.L17.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x68);
      this.L17.Location = point;
      this.L17.Name = "L17";
      size = new Size(160, 0x10);
      this.L17.Size = size;
      this.L17.TabIndex = 12;
      this.L17.Text = "<M> = Modified / Remixed by";
      this.L12.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x48);
      this.L12.Location = point;
      this.L12.Name = "L12";
      size = new Size(160, 0x10);
      this.L12.Size = size;
      this.L12.TabIndex = 11;
      this.L12.Text = "<N> = Conductor";
      this.L11.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x48);
      this.L11.Location = point;
      this.L11.Name = "L11";
      size = new Size(160, 0x10);
      this.L11.Size = size;
      this.L11.TabIndex = 10;
      this.L11.Text = "<p> = Total number of medias";
      this.L10.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x48);
      this.L10.Location = point;
      this.L10.Name = "L10";
      size = new Size(160, 0x10);
      this.L10.Size = size;
      this.L10.TabIndex = 9;
      this.L10.Text = "<P> = Position in media set";
      this.L9.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x38);
      this.L9.Location = point;
      this.L9.Name = "L9";
      size = new Size(160, 0x10);
      this.L9.Size = size;
      this.L9.TabIndex = 8;
      this.L9.Text = "<U> = Content Group";
      this.L8.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x38);
      this.L8.Location = point;
      this.L8.Name = "L8";
      size = new Size(160, 0x10);
      this.L8.Size = size;
      this.L8.TabIndex = 7;
      this.L8.Text = "<k> = Total number of tracks";
      this.L7.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.L7.Location = point;
      this.L7.Name = "L7";
      size = new Size(160, 0x10);
      this.L7.Size = size;
      this.L7.TabIndex = 6;
      this.L7.Text = "<K> = Track number";
      this.L6.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 40);
      this.L6.Location = point;
      this.L6.Name = "L6";
      size = new Size(160, 0x10);
      this.L6.Size = size;
      this.L6.TabIndex = 5;
      this.L6.Text = "<G> = First Genre";
      this.L5.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 40);
      this.L5.Location = point;
      this.L5.Name = "L5";
      size = new Size(160, 0x10);
      this.L5.Size = size;
      this.L5.TabIndex = 4;
      this.L5.Text = "<Y> = Year";
      this.L4.ImeMode = ImeMode.NoControl;
      point = new Point(8, 40);
      this.L4.Location = point;
      this.L4.Name = "L4";
      size = new Size(160, 0x10);
      this.L4.Size = size;
      this.L4.TabIndex = 3;
      this.L4.Text = "<C> = Comment";
      this.L3.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x18);
      this.L3.Location = point;
      this.L3.Name = "L3";
      size = new Size(160, 0x10);
      this.L3.Size = size;
      this.L3.TabIndex = 2;
      this.L3.Text = "<B> = Album";
      this.L2.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x18);
      this.L2.Location = point;
      this.L2.Name = "L2";
      size = new Size(160, 0x10);
      this.L2.Size = size;
      this.L2.TabIndex = 1;
      this.L2.Text = "<T> = Title";
      this.L1.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x18);
      this.L1.Location = point;
      this.L1.Name = "L1";
      size = new Size(160, 0x10);
      this.L1.Size = size;
      this.L1.TabIndex = 0;
      this.L1.Text = "<A> = Artist";
      this.btnRemove.ImeMode = ImeMode.NoControl;
      point = new Point(0x139, 0x1f);
      this.btnRemove.Location = point;
      this.btnRemove.Name = "btnRemove";
      size = new Size(0xc0, 0x18);
      this.btnRemove.Size = size;
      this.btnRemove.TabIndex = 30;
      this.btnRemove.Text = "&Remove format from list";
      this.btnAdd.ImeMode = ImeMode.NoControl;
      point = new Point(0x69, 0x1f);
      this.btnAdd.Location = point;
      this.btnAdd.Name = "btnAdd";
      size = new Size(0xc0, 0x18);
      this.btnAdd.Size = size;
      this.btnAdd.TabIndex = 0x1d;
      this.btnAdd.Text = "&Add format to list";
      this.cmbFormat.ItemHeight = 13;
      point = new Point(0x69, 7);
      this.cmbFormat.Location = point;
      this.cmbFormat.Name = "cmbFormat";
      size = new Size(400, 0x15);
      this.cmbFormat.Size = size;
      this.cmbFormat.TabIndex = 0x1c;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      point = new Point(0x180, 0x170);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(120, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x24;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0x100, 0x170);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(120, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 0x23;
      this.btnOK.Text = "&OK";
      this.lblFormat.ImeMode = ImeMode.NoControl;
      point = new Point(9, 7);
      this.lblFormat.Location = point;
      this.lblFormat.Name = "lblFormat";
      size = new Size(0x60, 0x10);
      this.lblFormat.Size = size;
      this.lblFormat.TabIndex = 0x1b;
      this.lblFormat.Text = "&Format:";
      this.optTAGV1.ImeMode = ImeMode.NoControl;
      point = new Point(0x18, 0xf8);
      this.optTAGV1.Location = point;
      this.optTAGV1.Name = "optTAGV1";
      size = new Size(0xe0, 0x10);
      this.optTAGV1.Size = size;
      this.optTAGV1.TabIndex = 0x26;
      this.optTAGV1.Text = "Use TAG Ver. 1 for comparing";
      this.optTAGV2.ImeMode = ImeMode.NoControl;
      point = new Point(0x108, 0xf8);
      this.optTAGV2.Location = point;
      this.optTAGV2.Name = "optTAGV2";
      size = new Size(0xe0, 0x10);
      this.optTAGV2.Size = size;
      this.optTAGV2.TabIndex = 0x25;
      this.optTAGV2.Text = "Use TAG Ver. 2 for comparing";
      this.chkReplaceUnderScore.ImeMode = ImeMode.NoControl;
      point = new Point(0x18, 0x110);
      this.chkReplaceUnderScore.Location = point;
      this.chkReplaceUnderScore.Name = "chkReplaceUnderScore";
      size = new Size(0x1d0, 0x10);
      this.chkReplaceUnderScore.Size = size;
      this.chkReplaceUnderScore.TabIndex = 0x27;
      this.chkReplaceUnderScore.Text = "Replace characters not allowed in filenames by \"_\"";
      this.chkIgnoreCase.ImeMode = ImeMode.NoControl;
      point = new Point(0x18, 0x128);
      this.chkIgnoreCase.Location = point;
      this.chkIgnoreCase.Name = "chkIgnoreCase";
      size = new Size(0x1d0, 0x10);
      this.chkIgnoreCase.Size = size;
      this.chkIgnoreCase.TabIndex = 40;
      this.chkIgnoreCase.Text = "Ignore case during comparing";
      this.BalloonTip1.Style = eBallonStyle.Alert;
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(0x202, 0x18d);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add(this.chkIgnoreCase);
      this.Controls.Add(this.chkReplaceUnderScore);
      this.Controls.Add(this.optTAGV1);
      this.Controls.Add(this.optTAGV2);
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
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmCompareFileTAG";
      this.ShowInTaskbar = false;
      this.Text = "Compare filename with TAG entries";
      this.txtDigits.EndInit();
      this.framePara.ResumeLayout(false);
      this.ResumeLayout(false);
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

    private void optTAG_CheckedChanged(object sender, EventArgs e)
    {
      if (this.optTAGV2.Checked)
      {
        this.L8.Visible = true;
        this.L9.Visible = true;
        this.L10.Visible = true;
        this.L11.Visible = true;
        this.L12.Visible = true;
        this.L13.Visible = true;
        this.L14.Visible = true;
        this.L15.Visible = true;
        this.L16.Visible = true;
        this.L17.Visible = true;
      }
      else
      {
        this.L8.Visible = false;
        this.L9.Visible = false;
        this.L10.Visible = false;
        this.L11.Visible = false;
        this.L12.Visible = false;
        this.L13.Visible = false;
        this.L14.Visible = false;
        this.L15.Visible = false;
        this.L16.Visible = false;
        this.L17.Visible = false;
      }
    }

    private void txtDigits_Validated(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Minimum) < 0)
      {
        this.txtDigits.Value = this.txtDigits.Minimum;
      }
      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Maximum) > 0)
      {
        this.txtDigits.Value = this.txtDigits.Maximum;
      }
    }

    internal virtual BalloonTip BalloonTip1
    {
      get
      {
        return this._BalloonTip1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._BalloonTip1 != null)
        {
        }
        this._BalloonTip1 = value;
        if (this._BalloonTip1 != null)
        {
        }
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

    internal virtual CheckBox chkIgnoreCase
    {
      get
      {
        return this._chkIgnoreCase;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkIgnoreCase != null)
        {
        }
        this._chkIgnoreCase = value;
        if (this._chkIgnoreCase != null)
        {
        }
      }
    }

    internal virtual CheckBox chkReplaceUnderScore
    {
      get
      {
        return this._chkReplaceUnderScore;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkReplaceUnderScore != null)
        {
        }
        this._chkReplaceUnderScore = value;
        if (this._chkReplaceUnderScore != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbFormat
    {
      get
      {
        return this._cmbFormat;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbFormat != null)
        {
          this._cmbFormat.KeyPress -= new KeyPressEventHandler(this.cmbFormat_KeyPress);
        }
        this._cmbFormat = value;
        if (this._cmbFormat != null)
        {
          this._cmbFormat.KeyPress += new KeyPressEventHandler(this.cmbFormat_KeyPress);
        }
      }
    }

    internal virtual GroupBox framePara
    {
      get
      {
        return this._framePara;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._framePara != null)
        {
        }
        this._framePara = value;
        if (this._framePara != null)
        {
        }
      }
    }

    internal virtual Label L1
    {
      get
      {
        return this._L1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L1 != null)
        {
          this._L1.Click -= new EventHandler(this.Label_Click);
        }
        this._L1 = value;
        if (this._L1 != null)
        {
          this._L1.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L10
    {
      get
      {
        return this._L10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L10 != null)
        {
          this._L10.Click -= new EventHandler(this.Label_Click);
        }
        this._L10 = value;
        if (this._L10 != null)
        {
          this._L10.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L11
    {
      get
      {
        return this._L11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L11 != null)
        {
          this._L11.Click -= new EventHandler(this.Label_Click);
        }
        this._L11 = value;
        if (this._L11 != null)
        {
          this._L11.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L12
    {
      get
      {
        return this._L12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L12 != null)
        {
          this._L12.Click -= new EventHandler(this.Label_Click);
        }
        this._L12 = value;
        if (this._L12 != null)
        {
          this._L12.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L13
    {
      get
      {
        return this._L13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L13 != null)
        {
        }
        this._L13 = value;
        if (this._L13 != null)
        {
        }
      }
    }

    internal virtual Label L14
    {
      get
      {
        return this._L14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L14 != null)
        {
          this._L14.Click -= new EventHandler(this.Label_Click);
        }
        this._L14 = value;
        if (this._L14 != null)
        {
          this._L14.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L15
    {
      get
      {
        return this._L15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L15 != null)
        {
          this._L15.Click -= new EventHandler(this.Label_Click);
        }
        this._L15 = value;
        if (this._L15 != null)
        {
          this._L15.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L16
    {
      get
      {
        return this._L16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L16 != null)
        {
          this._L16.Click -= new EventHandler(this.Label_Click);
        }
        this._L16 = value;
        if (this._L16 != null)
        {
          this._L16.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L17
    {
      get
      {
        return this._L17;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L17 != null)
        {
          this._L17.Click -= new EventHandler(this.Label_Click);
        }
        this._L17 = value;
        if (this._L17 != null)
        {
          this._L17.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L18
    {
      get
      {
        return this._L18;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L18 != null)
        {
        }
        this._L18 = value;
        if (this._L18 != null)
        {
        }
      }
    }

    internal virtual Label L19
    {
      get
      {
        return this._L19;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L19 != null)
        {
        }
        this._L19 = value;
        if (this._L19 != null)
        {
        }
      }
    }

    internal virtual Label L2
    {
      get
      {
        return this._L2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L2 != null)
        {
          this._L2.Click -= new EventHandler(this.Label_Click);
        }
        this._L2 = value;
        if (this._L2 != null)
        {
          this._L2.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L20
    {
      get
      {
        return this._L20;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L20 != null)
        {
        }
        this._L20 = value;
        if (this._L20 != null)
        {
        }
      }
    }

    internal virtual Label L3
    {
      get
      {
        return this._L3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L3 != null)
        {
          this._L3.Click -= new EventHandler(this.Label_Click);
        }
        this._L3 = value;
        if (this._L3 != null)
        {
          this._L3.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L4
    {
      get
      {
        return this._L4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L4 != null)
        {
          this._L4.Click -= new EventHandler(this.Label_Click);
        }
        this._L4 = value;
        if (this._L4 != null)
        {
          this._L4.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L5
    {
      get
      {
        return this._L5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L5 != null)
        {
          this._L5.Click -= new EventHandler(this.Label_Click);
        }
        this._L5 = value;
        if (this._L5 != null)
        {
          this._L5.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L6
    {
      get
      {
        return this._L6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L6 != null)
        {
          this._L6.Click -= new EventHandler(this.Label_Click);
        }
        this._L6 = value;
        if (this._L6 != null)
        {
          this._L6.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L7
    {
      get
      {
        return this._L7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L7 != null)
        {
          this._L7.Click -= new EventHandler(this.Label_Click);
        }
        this._L7 = value;
        if (this._L7 != null)
        {
          this._L7.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L8
    {
      get
      {
        return this._L8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L8 != null)
        {
          this._L8.Click -= new EventHandler(this.Label_Click);
        }
        this._L8 = value;
        if (this._L8 != null)
        {
          this._L8.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L9
    {
      get
      {
        return this._L9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L9 != null)
        {
          this._L9.Click -= new EventHandler(this.Label_Click);
        }
        this._L9 = value;
        if (this._L9 != null)
        {
          this._L9.Click += new EventHandler(this.Label_Click);
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

    internal virtual Label lblInfo
    {
      get
      {
        return this._lblInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblInfo != null)
        {
        }
        this._lblInfo = value;
        if (this._lblInfo != null)
        {
        }
      }
    }

    internal virtual RadioButton optTAGV1
    {
      get
      {
        return this._optTAGV1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optTAGV1 != null)
        {
          this._optTAGV1.CheckedChanged -= new EventHandler(this.optTAG_CheckedChanged);
        }
        this._optTAGV1 = value;
        if (this._optTAGV1 != null)
        {
          this._optTAGV1.CheckedChanged += new EventHandler(this.optTAG_CheckedChanged);
        }
      }
    }

    internal virtual RadioButton optTAGV2
    {
      get
      {
        return this._optTAGV2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optTAGV2 != null)
        {
          this._optTAGV2.CheckedChanged -= new EventHandler(this.optTAG_CheckedChanged);
        }
        this._optTAGV2 = value;
        if (this._optTAGV2 != null)
        {
          this._optTAGV2.CheckedChanged += new EventHandler(this.optTAG_CheckedChanged);
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

    internal virtual NumericUpDown txtDigits
    {
      get
      {
        return this._txtDigits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtDigits != null)
        {
          this._txtDigits.Validated -= new EventHandler(this.txtDigits_Validated);
        }
        this._txtDigits = value;
        if (this._txtDigits != null)
        {
          this._txtDigits.Validated += new EventHandler(this.txtDigits_Validated);
        }
      }
    }
  }
}