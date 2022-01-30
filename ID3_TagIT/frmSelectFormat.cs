using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmSelectFormat : Form
  {
    #region Designer

    private Button btnAdd;
    private Button btnCancel;
    private Button btnOK;
    private Button btnRemove;
    private ComboBox cmbFormat;
    private GroupBox framePara;
    private Label L1;
    private Label L2;
    private Label lblFormat;
    private Label lblInfo;
    private System.Windows.Forms.ToolTip ToolTip;
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
      this.lblInfo = new System.Windows.Forms.Label();
      this.framePara = new System.Windows.Forms.GroupBox();
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
      this.lblInfo.Location = new System.Drawing.Point(8, 120);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(496, 56);
      this.lblInfo.TabIndex = 42;
      this.lblInfo.Text = "This function offers you the possibilty to select all the files which match the f" +
    "ormat you entered above. <ABC> stands for a alphanumeric string while <123> stan" +
    "ds for a numeric only string.";
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // framePara
      // 
      this.framePara.Controls.Add(this.L2);
      this.framePara.Controls.Add(this.L1);
      this.framePara.Location = new System.Drawing.Point(8, 64);
      this.framePara.Name = "framePara";
      this.framePara.Size = new System.Drawing.Size(496, 48);
      this.framePara.TabIndex = 41;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      // 
      // L2
      // 
      this.L2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L2.Location = new System.Drawing.Point(264, 24);
      this.L2.Name = "L2";
      this.L2.Size = new System.Drawing.Size(224, 16);
      this.L2.TabIndex = 1;
      this.L2.Text = "<123> = Numeric string";
      this.L2.Click += new System.EventHandler(this.Label_Click);
      // 
      // L1
      // 
      this.L1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L1.Location = new System.Drawing.Point(8, 24);
      this.L1.Name = "L1";
      this.L1.Size = new System.Drawing.Size(232, 16);
      this.L1.TabIndex = 0;
      this.L1.Text = "<ABC> = Alphanumeric string";
      this.L1.Click += new System.EventHandler(this.Label_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemove.Location = new System.Drawing.Point(312, 32);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(192, 24);
      this.btnRemove.TabIndex = 40;
      this.btnRemove.Text = "&Remove format from list";
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(104, 32);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(192, 24);
      this.btnAdd.TabIndex = 39;
      this.btnAdd.Text = "&Add format to list";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // cmbFormat
      // 
      this.cmbFormat.ItemHeight = 13;
      this.cmbFormat.Location = new System.Drawing.Point(104, 8);
      this.cmbFormat.Name = "cmbFormat";
      this.cmbFormat.Size = new System.Drawing.Size(400, 21);
      this.cmbFormat.TabIndex = 38;
      this.cmbFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFormat_KeyPress);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(384, 184);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 44;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(256, 184);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 43;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblFormat
      // 
      this.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblFormat.Location = new System.Drawing.Point(8, 10);
      this.lblFormat.Name = "lblFormat";
      this.lblFormat.Size = new System.Drawing.Size(96, 16);
      this.lblFormat.TabIndex = 37;
      this.lblFormat.Text = "&Format:";
      // 
      // frmSelectFormat
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(512, 214);
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
      this.Name = "frmSelectFormat";
      this.ShowInTaskbar = false;
      this.Text = "Select files by format";
      this.framePara.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    public frmSelectFormat(frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmSelectFormat_Load);
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
      string vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });

      if (vstrFormat.IndexOf(":") >= 0)
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });

      vstrFormat = vstrFormat.Replace("<abc>", "<ABC>");

      if (((((((vstrFormat.IndexOf(@"\") >= 0) | (vstrFormat.IndexOf(":") >= 0)) | (vstrFormat.IndexOf('"') >= 0)) | (vstrFormat.IndexOf("/") >= 0)) | (vstrFormat.IndexOf("*") >= 0)) | (vstrFormat.IndexOf("|") >= 0)) | (vstrFormat.IndexOf("?") >= 0))
      {
        this.DialogResult = System.Windows.Forms.DialogResult.None;
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidCharFormat"]), MsgBoxStyle.Exclamation, null);
      }
      else
      {
        string str2 = vstrFormat.Replace("<abc>", "\x0001").Replace("<ABC>", "\x0001").Replace("<123>", "\x0001");

        if (((str2.IndexOf("<") >= 0) | (str2.IndexOf(">") >= 0)) | (str2.IndexOf("\x0001\x0001") >= 0))
        {
          this.DialogResult = System.Windows.Forms.DialogResult.None;
          Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidFormat"]), MsgBoxStyle.Exclamation, null);
        }
        else
        {
          Form form = this;
          Id3TagIT_Main.SaveFormSettings(ref form);
          Declarations.objSettings.SelectFormats.Rows.Clear();
          Declarations.objSettings.SelectFormat = this.cmbFormat.Text;
          int num2 = this.cmbFormat.Items.Count - 1;

          for (int i = 0; i <= num2; i++)
          {
            DataRow row = Declarations.objSettings.SelectFormats.NewRow();
            row["Format"] = this.cmbFormat.Items[i].ToString();
            Declarations.objSettings.SelectFormats.Rows.Add(row);
          }

          this.MainForm.MP3View.BeginUpdate();

          foreach (ListViewItem item in this.MainForm.MP3View.Items)
          {
            if (ID3Functions.MatchFilenameFormat(StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentName", new object[0], null, null)), vstrFormat, false))
              item.Selected = true;
            else if (Declarations.objSettings.SelectionMode == 1)
              item.Selected = false;
          }

          this.MainForm.MP3View.EndUpdate();
          form = this;
          Id3TagIT_Main.SaveFormSettings(ref form);
          this.Close();
        }
      }
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
          this.cmbFormat.SelectionStart = this.cmbFormat.Text.Length;
          break;
      }
    }

    private void frmSelectFormat_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      int num2 = Declarations.objSettings.SelectFormats.Rows.Count - 1;

      for (int i = 0; i <= num2; i++)
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.SelectFormats.Rows[i]["Format"]));

      this.cmbFormat.Text = Declarations.objSettings.SelectFormat;
      this.AddToolTips();
    }

    private void Label_Click(object sender, EventArgs e)
    {
      this.cmbFormat.Text = StringType.FromObject(ObjectType.StrCatObj(this.cmbFormat.Text, LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 5 }, null, null)));
      this.cmbFormat.Select(this.cmbFormat.Text.Length, 0);
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmSelectFormat";
      Control btnRemove = this.btnRemove;
      this.btnRemove = (Button)btnRemove;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));

      vstrName = "frmSelectFormat";
      btnRemove = this.btnAdd;
      this.btnAdd = (Button)btnRemove;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));

      vstrName = "frmSelectFormat";
      btnRemove = this.cmbFormat;
      this.cmbFormat = (ComboBox)btnRemove;
      this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
    }

    #endregion
  }
}