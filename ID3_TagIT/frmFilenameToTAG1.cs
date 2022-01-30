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
  public class frmFilenameToTAG1 : Form
  {
    #region Designer

    private Button btnAdd;
    private Button btnCancel;
    private Button btnOK;
    private Button btnRemove;
    private ComboBox cmbFormat;
    private GroupBox framePara;
    private Label L1;
    private Label L18;
    private Label L2;
    private Label L3;
    private Label L4;
    private Label L5;
    private Label L6;
    private Label L7;
    private Label L8;
    private Label lblFormat;
    private Label lblInfo;
    private System.Windows.Forms.ToolTip ToolTip;
    private ArrayList alstFormat;
    private IContainer components;
    private frmMain MainForm;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilenameToTAG1));
      this.lblInfo = new System.Windows.Forms.Label();
      this.framePara = new System.Windows.Forms.GroupBox();
      this.L8 = new System.Windows.Forms.Label();
      this.L18 = new System.Windows.Forms.Label();
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
      this.framePara.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblInfo
      // 
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 152);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(496, 56);
      this.lblInfo.TabIndex = 34;
      this.lblInfo.Text = resources.GetString("lblInfo.Text");
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // framePara
      // 
      this.framePara.Controls.Add(this.L8);
      this.framePara.Controls.Add(this.L18);
      this.framePara.Controls.Add(this.L7);
      this.framePara.Controls.Add(this.L6);
      this.framePara.Controls.Add(this.L5);
      this.framePara.Controls.Add(this.L4);
      this.framePara.Controls.Add(this.L3);
      this.framePara.Controls.Add(this.L2);
      this.framePara.Controls.Add(this.L1);
      this.framePara.Location = new System.Drawing.Point(8, 64);
      this.framePara.Name = "framePara";
      this.framePara.Size = new System.Drawing.Size(496, 80);
      this.framePara.TabIndex = 33;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      // 
      // L8
      // 
      this.L8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L8.Location = new System.Drawing.Point(168, 56);
      this.L8.Name = "L8";
      this.L8.Size = new System.Drawing.Size(160, 16);
      this.L8.TabIndex = 16;
      this.L8.Text = "<X> = Unused";
      this.L8.Click += new System.EventHandler(this.Label_Click);
      // 
      // L18
      // 
      this.L18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L18.Location = new System.Drawing.Point(328, 56);
      this.L18.Name = "L18";
      this.L18.Size = new System.Drawing.Size(152, 16);
      this.L18.TabIndex = 15;
      this.L18.Text = "\\ = Folder";
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
      this.btnRemove.Location = new System.Drawing.Point(312, 32);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(192, 24);
      this.btnRemove.TabIndex = 30;
      this.btnRemove.Text = "&Remove format from list";
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(104, 32);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(192, 24);
      this.btnAdd.TabIndex = 29;
      this.btnAdd.Text = "&Add format to list";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // cmbFormat
      // 
      this.cmbFormat.ItemHeight = 13;
      this.cmbFormat.Location = new System.Drawing.Point(104, 8);
      this.cmbFormat.Name = "cmbFormat";
      this.cmbFormat.Size = new System.Drawing.Size(400, 21);
      this.cmbFormat.TabIndex = 28;
      this.cmbFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFormat_KeyPress);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(384, 216);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 36;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(256, 216);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 35;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblFormat
      // 
      this.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblFormat.Location = new System.Drawing.Point(8, 10);
      this.lblFormat.Name = "lblFormat";
      this.lblFormat.Size = new System.Drawing.Size(96, 16);
      this.lblFormat.TabIndex = 27;
      this.lblFormat.Text = "&Format:";
      // 
      // frmFilenameToTAG1
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(514, 248);
      this.ControlBox = false;
      this.Controls.Add(this.lblInfo);
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
      this.Name = "frmFilenameToTAG1";
      this.ShowInTaskbar = false;
      this.Text = "Filename -> TAG Ver. 1";
      this.framePara.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    public frmFilenameToTAG1(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmFilenameToTAG1_Load);
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

      switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.FilenameToTAG | Declarations.FormatReplace.TAGVer1))
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

      Declarations.objSettings.FT1Formats.Rows.Clear();
      Declarations.objSettings.FT1Format = this.cmbFormat.Text;
      int num2 = this.cmbFormat.Items.Count - 1;

      for (int i = 0; i <= num2; i++)
      {
        DataRow row = Declarations.objSettings.FT1Formats.NewRow();
        row["Format"] = this.cmbFormat.Items[i].ToString();
        Declarations.objSettings.FT1Formats.Rows.Add(row);
      }

      format.Create(vstrFormat, 2);
      this.alstFormat = format.Parts;
      this.MainForm.MP3View.BeginUpdate();
      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.FilenameTAGV1CB);
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

    private void frmFilenameToTAG1_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
      int num2 = Declarations.objSettings.FT1Formats.Rows.Count - 1;

      for (int i = 0; i <= num2; i++)
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.FT1Formats.Rows[i]["Format"]));

      this.cmbFormat.Text = Declarations.objSettings.FT1Format;
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

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmFilenameToTAG1";
      Control btnRemove = this.btnRemove;
      this.btnRemove = (Button)btnRemove;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
      vstrName = "frmFilenameToTAG1";
      btnRemove = this.btnAdd;
      this.btnAdd = (Button)btnRemove;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
      vstrName = "frmFilenameToTAG1";
      btnRemove = this.cmbFormat;
      this.cmbFormat = (ComboBox)btnRemove;
      this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
    }

    private void FilenameTAGV1CB(ref frmProgress frmProg)
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
        ID3Functions.FilenameToTAG(ref tag, this.alstFormat, 1);
        item2.Tag = tag;
        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    #endregion
  }
}