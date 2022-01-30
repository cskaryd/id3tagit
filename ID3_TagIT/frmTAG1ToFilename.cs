using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmTAG1ToFilename : Form
  {
    #region Designer

    private Button btnAdd;
    private Button btnCancel;
    private Button btnOK;
    private Button btnRemove;
    private ComboBox cmbFormat;
    private GroupBox framePara;
    private Label L1;
    private Label L17;
    private Label L18;
    private Label L2;
    private Label L3;
    private Label L4;
    private Label L5;
    private Label L6;
    private Label L7;
    private Label lbl1;
    private Label lbl2;
    private Label lblDigits;
    private Label lblFormat;
    private Label lblInfo;
    private System.Windows.Forms.ToolTip ToolTip;
    private NumericUpDown txtDigits;
    private NumericUpDown txtFDigits;
    private NumericUpDown txtStartNr;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTAG1ToFilename));
      this.lblInfo = new System.Windows.Forms.Label();
      this.lblDigits = new System.Windows.Forms.Label();
      this.txtDigits = new System.Windows.Forms.NumericUpDown();
      this.framePara = new System.Windows.Forms.GroupBox();
      this.lbl2 = new System.Windows.Forms.Label();
      this.txtFDigits = new System.Windows.Forms.NumericUpDown();
      this.lbl1 = new System.Windows.Forms.Label();
      this.txtStartNr = new System.Windows.Forms.NumericUpDown();
      this.L18 = new System.Windows.Forms.Label();
      this.L17 = new System.Windows.Forms.Label();
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
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).BeginInit();
      this.framePara.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtFDigits)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartNr)).BeginInit();
      this.SuspendLayout();
      // 
      // lblInfo
      // 
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 240);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(496, 56);
      this.lblInfo.TabIndex = 44;
      this.lblInfo.Text = resources.GetString("lblInfo.Text");
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblDigits
      // 
      this.lblDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDigits.Location = new System.Drawing.Point(105, 65);
      this.lblDigits.Name = "lblDigits";
      this.lblDigits.Size = new System.Drawing.Size(184, 16);
      this.lblDigits.TabIndex = 41;
      this.lblDigits.Text = "&Number of digits of track numbers:";
      // 
      // txtDigits
      // 
      this.txtDigits.Location = new System.Drawing.Point(313, 63);
      this.txtDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Name = "txtDigits";
      this.txtDigits.Size = new System.Drawing.Size(64, 20);
      this.txtDigits.TabIndex = 42;
      this.ToolTip.SetToolTip(this.txtDigits, "Select number of digits of track numbers");
      this.txtDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Validated += new System.EventHandler(this.txtDigits_Validated);
      // 
      // framePara
      // 
      this.framePara.Controls.Add(this.lbl2);
      this.framePara.Controls.Add(this.txtFDigits);
      this.framePara.Controls.Add(this.lbl1);
      this.framePara.Controls.Add(this.txtStartNr);
      this.framePara.Controls.Add(this.L18);
      this.framePara.Controls.Add(this.L17);
      this.framePara.Controls.Add(this.L7);
      this.framePara.Controls.Add(this.L6);
      this.framePara.Controls.Add(this.L5);
      this.framePara.Controls.Add(this.L4);
      this.framePara.Controls.Add(this.L3);
      this.framePara.Controls.Add(this.L2);
      this.framePara.Controls.Add(this.L1);
      this.framePara.Location = new System.Drawing.Point(9, 95);
      this.framePara.Name = "framePara";
      this.framePara.Size = new System.Drawing.Size(496, 137);
      this.framePara.TabIndex = 43;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      // 
      // lbl2
      // 
      this.lbl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lbl2.Location = new System.Drawing.Point(240, 106);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(184, 16);
      this.lbl2.TabIndex = 35;
      this.lbl2.Text = "Number of digits";
      // 
      // txtFDigits
      // 
      this.txtFDigits.Location = new System.Drawing.Point(168, 104);
      this.txtFDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtFDigits.Name = "txtFDigits";
      this.txtFDigits.Size = new System.Drawing.Size(64, 20);
      this.txtFDigits.TabIndex = 36;
      this.ToolTip.SetToolTip(this.txtFDigits, "File enumeration: Number of digits in enumeration");
      this.txtFDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtFDigits.Validated += new System.EventHandler(this.txtDigits_Validated);
      // 
      // lbl1
      // 
      this.lbl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lbl1.Location = new System.Drawing.Point(240, 82);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(184, 16);
      this.lbl1.TabIndex = 33;
      this.lbl1.Text = "Number to start with";
      // 
      // txtStartNr
      // 
      this.txtStartNr.Location = new System.Drawing.Point(168, 80);
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
      this.txtStartNr.TabIndex = 34;
      this.ToolTip.SetToolTip(this.txtStartNr, "File enumeration: Start enumeration with selected number");
      this.txtStartNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtStartNr.Validated += new System.EventHandler(this.txtStartNr_ValueChanged);
      // 
      // L18
      // 
      this.L18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L18.Location = new System.Drawing.Point(8, 80);
      this.L18.Name = "L18";
      this.L18.Size = new System.Drawing.Size(152, 16);
      this.L18.TabIndex = 18;
      this.L18.Text = "<#> = Enumerate files:";
      this.L18.Click += new System.EventHandler(this.Label_Click);
      // 
      // L17
      // 
      this.L17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L17.Location = new System.Drawing.Point(168, 56);
      this.L17.Name = "L17";
      this.L17.Size = new System.Drawing.Size(152, 16);
      this.L17.TabIndex = 17;
      this.L17.Text = "<F> = Current Filename";
      this.L17.Click += new System.EventHandler(this.Label_Click);
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
      this.L6.Text = "<G> = Genre";
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
      this.btnRemove.Location = new System.Drawing.Point(313, 31);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(192, 24);
      this.btnRemove.TabIndex = 40;
      this.btnRemove.Text = "&Remove format from list";
      this.ToolTip.SetToolTip(this.btnRemove, "Remove the selected format from the list");
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(105, 31);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(192, 24);
      this.btnAdd.TabIndex = 39;
      this.btnAdd.Text = "&Add format to list";
      this.ToolTip.SetToolTip(this.btnAdd, "Add the entered format to list");
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // cmbFormat
      // 
      this.cmbFormat.ItemHeight = 13;
      this.cmbFormat.Location = new System.Drawing.Point(105, 7);
      this.cmbFormat.Name = "cmbFormat";
      this.cmbFormat.Size = new System.Drawing.Size(400, 21);
      this.cmbFormat.TabIndex = 38;
      this.ToolTip.SetToolTip(this.cmbFormat, "Enter the format of how the filename should look like");
      this.cmbFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFormat_KeyPress);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(384, 304);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 46;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(256, 304);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 45;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblFormat
      // 
      this.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblFormat.Location = new System.Drawing.Point(9, 7);
      this.lblFormat.Name = "lblFormat";
      this.lblFormat.Size = new System.Drawing.Size(96, 16);
      this.lblFormat.TabIndex = 37;
      this.lblFormat.Text = "&Format:";
      // 
      // frmTAG1ToFilename
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(512, 334);
      this.ControlBox = false;
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
      this.Name = "frmTAG1ToFilename";
      this.ShowInTaskbar = false;
      this.Text = "TAG Ver. 1 -> Filename";
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).EndInit();
      this.framePara.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtFDigits)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartNr)).EndInit();
      this.ResumeLayout(false);
    }

    public frmTAG1ToFilename(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG1ToFilename_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmTAG2ToFilename";
      Control txtDigits = this.txtDigits;
      this.txtDigits = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.txtFDigits;
      this.txtFDigits = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtFDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.txtStartNr;
      this.txtStartNr = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtStartNr, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.btnRemove;
      this.btnRemove = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.btnAdd;
      this.btnAdd = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.cmbFormat;
      this.cmbFormat = (ComboBox)txtDigits;
      this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
    }

    private void TAG1ToFilenameCB(ref frmProgress frmProg)
    {
      bool flag = false;

      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        MP3 tag = (MP3)item.Tag;
        frmProg.Infos.Text = tag.CurrentFullName;
        flag = false;
        frmProgress progress = frmProg;
        progress.Integer01++;
        string sLeft = ID3Functions.FormatReplacedByTag(tag, frmProg.String01, 1).Replace("<#>", frmProg.Integer01.ToString().PadLeft(Convert.ToInt32(this.txtFDigits.Value), '0')).Replace("<F>", tag.CurrentName).Replace("<", "_").Replace(">", "_").Replace("|", "_").Replace("\"", "_").Replace(@"\", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace(":", "_").Trim(new char[] { ' ' });

        if (StringType.StrCmp(sLeft, "", false) != 0)
        {
          bool[] flagArray;
          object[] objArray;
          object[] objArray2;
          string str4;
          DataRow resStrings;
          string str = tag.CurrentFullName.Substring(0, tag.CurrentFullName.LastIndexOf(@"\") + 1) + sLeft + tag.FI.Extension;

          if (str.Length <= 0xff)
          {
            foreach (MP3 mp2 in Declarations.MP3s)
            {
              if ((StringType.StrCmp(str.ToLower(), mp2.CurrentFullName.ToLower(), false) == 0) && (mp2 != tag))
              {
                flag = true;
                break;
              }
            }

            if (!flag)
            {
              if (StringType.StrCmp(sLeft, tag.CurrentName, false) != 0)
              {
                Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
                frmProg.List.Add(@do);
                tag.CurrentName = sLeft;
                item.Text = sLeft;
                tag.Changed = true;
                item.BackColor = Color.FromArgb(Declarations.objSettings.ColorChangedBack);
                item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorChangedText);
              }
            }
            else
            {
              ListViewItem item3 = new ListViewItem { Text = tag.CurrentFullName };
              objArray2 = new object[1];
              resStrings = Declarations.objResources.ResStrings;
              str4 = "ErrorTFExists";
              objArray2[0] = RuntimeHelpers.GetObjectValue(resStrings[str4]);
              objArray = objArray2;
              flagArray = new bool[] { true };
              LateBinding.LateCall(item3.SubItems, null, "Add", objArray, null, flagArray);

              if (flagArray[0])
                resStrings[str4] = RuntimeHelpers.GetObjectValue(objArray[0]);

              this.MainForm.ErrorMsg.Items.Insert(0, item3);
              // FIXME - exp this.MainForm.SplitterBottom.Expanded = true;
            }
          }
          else
          {
            ListViewItem item4 = new ListViewItem { Text = tag.CurrentFullName };
            objArray = new object[1];
            resStrings = Declarations.objResources.ResStrings;
            str4 = "InvalidPathLength";
            objArray[0] = RuntimeHelpers.GetObjectValue(resStrings[str4]);
            objArray2 = objArray;
            flagArray = new bool[] { true };
            LateBinding.LateCall(item4.SubItems, null, "Add", objArray2, null, flagArray);

            if (flagArray[0])
              resStrings[str4] = RuntimeHelpers.GetObjectValue(objArray2[0]);

            this.MainForm.ErrorMsg.Items.Insert(0, item4);
            // FIXME - exp this.MainForm.SplitterBottom.Expanded = true;
          }
        }

        frmProg.ProgressBar.PerformStep();
      }
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
      ArrayList list = new ArrayList();
      string vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });

      if (vstrFormat.IndexOf(":") >= 0)
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });

      switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.TAGToFilename | Declarations.FormatReplace.TAGVer1))
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

      byte tracknumberDigitsFilename = Declarations.objSettings.TracknumberDigitsFilename;
      byte filenumberDigits = Declarations.objSettings.FilenumberDigits;
      byte filenumberStart = (byte)Declarations.objSettings.FilenumberStart;
      Declarations.objSettings.T1FFormats.Rows.Clear();
      Declarations.objSettings.T1FFormat = this.cmbFormat.Text;
      Declarations.objSettings.TracknumberDigitsFilename = Convert.ToByte(this.txtDigits.Value);
      Declarations.objSettings.FilenumberDigits = Convert.ToByte(this.txtFDigits.Value);
      Declarations.objSettings.FilenumberStart = Convert.ToInt32(this.txtStartNr.Value);

      int num6 = this.cmbFormat.Items.Count - 1;

      for (int i = 0; i <= num6; i++)
      {
        DataRow row = Declarations.objSettings.T1FFormats.NewRow();
        row["Format"] = this.cmbFormat.Items[i].ToString();
        Declarations.objSettings.T1FFormats.Rows.Add(row);
      }

      int num4 = Convert.ToInt32(decimal.Subtract(this.txtStartNr.Value, decimal.One));
      this.MainForm.MP3View.BeginUpdate();
      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.TAG1ToFilenameCB);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref ownerForm, ref cB);
      progress.SetStateTAGFilename();
      progress.List = list;
      progress.String01 = vstrFormat;
      progress.Integer01 = num4;
      progress.ShowDialog(this);
      this.MainForm.MP3View.EndUpdate();

      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
      }

      Declarations.objSettings.TracknumberDigitsFilename = tracknumberDigitsFilename;
      Declarations.objSettings.FilenumberDigits = filenumberDigits;
      Declarations.objSettings.FilenumberStart = filenumberStart;
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
        case '\\':
        case '|':
        case '"':
        case '/':
        case '*':
        case '?':
          e.Handled = true;
          break;
      }
    }

    private void frmTAG1ToFilename_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      int num2 = Declarations.objSettings.T1FFormats.Rows.Count - 1;

      for (int i = 0; i <= num2; i++)
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.T1FFormats.Rows[i]["Format"]));

      this.cmbFormat.Text = Declarations.objSettings.T1FFormat;
      this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);
      this.txtFDigits.Value = new decimal(Declarations.objSettings.FilenumberDigits);
      this.txtStartNr.Value = new decimal(Declarations.objSettings.FilenumberStart);
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

    private void txtStartNr_ValueChanged(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtStartNr.Value, this.txtStartNr.Minimum) < 0)
        this.txtStartNr.Value = this.txtStartNr.Minimum;
    }

    #endregion
  }
}