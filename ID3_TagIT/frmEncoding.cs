using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmEncoding : Form
  {
    private Button btnCancel;
    private Button btnOK;
    private ComboBox cmbV23Enc;
    private ComboBox cmbV24Enc;
    private Label lblTextEncInfo;
    private Label lblV23;
    private Label lblV24;
    private IContainer components;
    private frmMain MainForm;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.lblV24 = new System.Windows.Forms.Label();
      this.lblV23 = new System.Windows.Forms.Label();
      this.cmbV24Enc = new System.Windows.Forms.ComboBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblTextEncInfo = new System.Windows.Forms.Label();
      this.cmbV23Enc = new System.Windows.Forms.ComboBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblV24
      // 
      this.lblV24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblV24.Location = new System.Drawing.Point(8, 80);
      this.lblV24.Name = "lblV24";
      this.lblV24.Size = new System.Drawing.Size(168, 16);
      this.lblV24.TabIndex = 104;
      this.lblV24.Text = "Text encoding for TAG Ver. 2.4:";
      // 
      // lblV23
      // 
      this.lblV23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblV23.Location = new System.Drawing.Point(8, 56);
      this.lblV23.Name = "lblV23";
      this.lblV23.Size = new System.Drawing.Size(168, 16);
      this.lblV23.TabIndex = 102;
      this.lblV23.Text = "Text encoding for TAG Ver. 2.3:";
      // 
      // cmbV24Enc
      // 
      this.cmbV24Enc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbV24Enc.ItemHeight = 13;
      this.cmbV24Enc.Items.AddRange(new object[] {
            "ANSI-Encoding (Default)",
            "UTF-16 (LE) Encoding with BOM (Default for Unicode Encoding)",
            "UTF-16 (BE) Encoding without BOM",
            "UTF-8 Encoding"});
      this.cmbV24Enc.Location = new System.Drawing.Point(176, 80);
      this.cmbV24Enc.Name = "cmbV24Enc";
      this.cmbV24Enc.Size = new System.Drawing.Size(312, 21);
      this.cmbV24Enc.TabIndex = 105;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(368, 120);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 108;
      this.btnCancel.Text = "&Cancel";
      // 
      // lblTextEncInfo
      // 
      this.lblTextEncInfo.Location = new System.Drawing.Point(8, 8);
      this.lblTextEncInfo.Name = "lblTextEncInfo";
      this.lblTextEncInfo.Size = new System.Drawing.Size(480, 32);
      this.lblTextEncInfo.TabIndex = 106;
      this.lblTextEncInfo.Text = "This will change the text encoding of the TAG Ver. 2 frames of the selected files" +
    " from ANSI to Unicode or vise versa.";
      // 
      // cmbV23Enc
      // 
      this.cmbV23Enc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbV23Enc.ItemHeight = 13;
      this.cmbV23Enc.Items.AddRange(new object[] {
            "ANSI-Encoding (Default)",
            "UTF-16 (LE) Encoding with BOM (Default for Unicode Encoding)"});
      this.cmbV23Enc.Location = new System.Drawing.Point(176, 54);
      this.cmbV23Enc.Name = "cmbV23Enc";
      this.cmbV23Enc.Size = new System.Drawing.Size(312, 21);
      this.cmbV23Enc.TabIndex = 103;
      // 
      // btnOK
      // 
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(240, 120);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 107;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // frmEncoding
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(496, 153);
      this.ControlBox = false;
      this.Controls.Add(this.lblV24);
      this.Controls.Add(this.lblV23);
      this.Controls.Add(this.cmbV24Enc);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.lblTextEncInfo);
      this.Controls.Add(this.cmbV23Enc);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmEncoding";
      this.Text = "Change TAG Ver. 2 text encoding";
      this.ResumeLayout(false);
    }

    public frmEncoding(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmEncoding_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      ArrayList list = new ArrayList();
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      this.MainForm.MP3View.BeginUpdate();
      form = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.CBTextEnc);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref cB);
      progress.SetStateTransfer();
      progress.List = list;
      progress.ShowDialog(this);
      this.MainForm.MP3View.EndUpdate();
      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
      }
      this.Close();
    }

    private void CBTextEnc(ref frmProgress frmProg)
    {
      byte selectedIndex = (byte)this.cmbV23Enc.SelectedIndex;
      byte num2 = (byte)this.cmbV24Enc.SelectedIndex;
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        MP3 tag = (MP3)item.Tag;
        frmProg.Infos.Text = tag.CurrentFullName;
        if (tag.V2TAG.TAGHeaderPresent)
        {
          object objectValue;
          Declarations.UnDoReDo @do;
          if (tag.V2TAG.TAGVersion == 3)
          {
            @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
            frmProg.List.Add(@do);
            var enumerator2 = tag.V2TAG.GetAllSupportedFrames().GetEnumerator();
            while (enumerator2.MoveNext())
            {
              objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
              try
              {
                LateBinding.LateSet(objectValue, null, "EncodingByte", new object[] { selectedIndex }, null);
                continue;
              }
              catch (Exception exception1)
              {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
                continue;
              }
            }
            goto Label_0320;
          }
          if (tag.V2TAG.TAGVersion == 4)
          {
            @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
            frmProg.List.Add(@do);
            var enumerator = tag.V2TAG.GetAllSupportedFrames().GetEnumerator();
              while (enumerator.MoveNext())
              {
                objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
                try
                {
                  LateBinding.LateSet(objectValue, null, "EncodingByte", new object[] { num2 }, null);
                  continue;
                }
                catch (Exception exception3)
                {
                  ProjectData.SetProjectError(exception3);
                  Exception exception2 = exception3;
                  ProjectData.ClearProjectError();
                  continue;
                }
              }
          }
        }
        Label_0320:
        tag.Changed = true;
        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    private void frmEncoding_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
      this.cmbV23Enc.SelectedIndex = Declarations.objSettings.V23Encoding;
      this.cmbV24Enc.SelectedIndex = Declarations.objSettings.V24Encoding;
    }
  }
}