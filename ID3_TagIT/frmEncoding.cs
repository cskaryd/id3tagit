namespace ID3_TagIT
{
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.Collections;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Drawing;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public class frmEncoding : Form
  {
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("cmbV23Enc")]
    private ComboBox _cmbV23Enc;
    [AccessedThroughProperty("cmbV24Enc")]
    private ComboBox _cmbV24Enc;
    [AccessedThroughProperty("lblTextEncInfo")]
    private Label _lblTextEncInfo;
    [AccessedThroughProperty("lblV23")]
    private Label _lblV23;
    [AccessedThroughProperty("lblV24")]
    private Label _lblV24;
    private IContainer components;
    private frmMain MainForm;

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
      Main.SaveFormSettings(ref form);
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
            using (IEnumerator enumerator2 = tag.V2TAG.GetAllSupportedFrames().GetEnumerator())
            {
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
          }
          if (tag.V2TAG.TAGVersion == 4)
          {
            @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
            frmProg.List.Add(@do);
            using (IEnumerator enumerator = tag.V2TAG.GetAllSupportedFrames().GetEnumerator())
            {
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
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void frmEncoding_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
      this.cmbV23Enc.SelectedIndex = Declarations.objSettings.V23Encoding;
      this.cmbV24Enc.SelectedIndex = Declarations.objSettings.V24Encoding;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.lblV24 = new Label();
      this.lblV23 = new Label();
      this.cmbV24Enc = new ComboBox();
      this.btnCancel = new Button();
      this.lblTextEncInfo = new Label();
      this.cmbV23Enc = new ComboBox();
      this.btnOK = new Button();
      this.SuspendLayout();
      this.lblV24.ImeMode = ImeMode.NoControl;
      Point point = new Point(8, 80);
      this.lblV24.Location = point;
      this.lblV24.Name = "lblV24";
      Size size = new Size(0xa8, 0x10);
      this.lblV24.Size = size;
      this.lblV24.TabIndex = 0x68;
      this.lblV24.Text = "Text encoding for TAG Ver. 2.4:";
      this.lblV23.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblV23.Location = point;
      this.lblV23.Name = "lblV23";
      size = new Size(0xa8, 0x10);
      this.lblV23.Size = size;
      this.lblV23.TabIndex = 0x66;
      this.lblV23.Text = "Text encoding for TAG Ver. 2.3:";
      this.cmbV24Enc.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbV24Enc.ItemHeight = 13;
      this.cmbV24Enc.Items.AddRange(new object[] { "ANSI-Encoding (Default)", "UTF-16 (LE) Encoding with BOM (Default for Unicode Encoding)", "UTF-16 (BE) Encoding without BOM", "UTF-8 Encoding" });
      point = new Point(0xb0, 80);
      this.cmbV24Enc.Location = point;
      this.cmbV24Enc.Name = "cmbV24Enc";
      size = new Size(0x138, 0x15);
      this.cmbV24Enc.Size = size;
      this.cmbV24Enc.TabIndex = 0x69;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 120);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(120, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x6c;
      this.btnCancel.Text = "&Cancel";
      point = new Point(8, 8);
      this.lblTextEncInfo.Location = point;
      this.lblTextEncInfo.Name = "lblTextEncInfo";
      size = new Size(480, 0x20);
      this.lblTextEncInfo.Size = size;
      this.lblTextEncInfo.TabIndex = 0x6a;
      this.lblTextEncInfo.Text = "This will change the text encoding of the TAG Ver. 2 frames of the selected files from ANSI to Unicode or vise versa.";
      this.cmbV23Enc.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbV23Enc.ItemHeight = 13;
      this.cmbV23Enc.Items.AddRange(new object[] { "ANSI-Encoding (Default)", "UTF-16 (LE) Encoding with BOM (Default for Unicode Encoding)" });
      point = new Point(0xb0, 0x36);
      this.cmbV23Enc.Location = point;
      this.cmbV23Enc.Name = "cmbV23Enc";
      size = new Size(0x138, 0x15);
      this.cmbV23Enc.Size = size;
      this.cmbV23Enc.TabIndex = 0x67;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(240, 120);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(120, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 0x6b;
      this.btnOK.Text = "&OK";
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(0x1f0, 0x99);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add(this.lblV24);
      this.Controls.Add(this.lblV23);
      this.Controls.Add(this.cmbV24Enc);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.lblTextEncInfo);
      this.Controls.Add(this.cmbV23Enc);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmEncoding";
      this.Text = "Change TAG Ver. 2 text encoding";
      this.ResumeLayout(false);
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

    internal virtual ComboBox cmbV23Enc
    {
      get
      {
        return this._cmbV23Enc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbV23Enc != null)
        {
        }
        this._cmbV23Enc = value;
        if (this._cmbV23Enc != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbV24Enc
    {
      get
      {
        return this._cmbV24Enc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbV24Enc != null)
        {
        }
        this._cmbV24Enc = value;
        if (this._cmbV24Enc != null)
        {
        }
      }
    }

    internal virtual Label lblTextEncInfo
    {
      get
      {
        return this._lblTextEncInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTextEncInfo != null)
        {
        }
        this._lblTextEncInfo = value;
        if (this._lblTextEncInfo != null)
        {
        }
      }
    }

    internal virtual Label lblV23
    {
      get
      {
        return this._lblV23;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblV23 != null)
        {
        }
        this._lblV23 = value;
        if (this._lblV23 != null)
        {
        }
      }
    }

    internal virtual Label lblV24
    {
      get
      {
        return this._lblV24;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblV24 != null)
        {
        }
        this._lblV24 = value;
        if (this._lblV24 != null)
        {
        }
      }
    }
  }
}