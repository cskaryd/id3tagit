namespace ID3_TagIT
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class frmSelectFormat : Form
    {
        [AccessedThroughProperty("btnAdd")]
        private Button _btnAdd;
        [AccessedThroughProperty("btnCancel")]
        private Button _btnCancel;
        [AccessedThroughProperty("btnOK")]
        private Button _btnOK;
        [AccessedThroughProperty("btnRemove")]
        private Button _btnRemove;
        [AccessedThroughProperty("cmbFormat")]
        private ComboBox _cmbFormat;
        [AccessedThroughProperty("framePara")]
        private GroupBox _framePara;
        [AccessedThroughProperty("L1")]
        private Label _L1;
        [AccessedThroughProperty("L2")]
        private Label _L2;
        [AccessedThroughProperty("lblFormat")]
        private Label _lblFormat;
        [AccessedThroughProperty("lblInfo")]
        private Label _lblInfo;
        [AccessedThroughProperty("ToolTip")]
        private System.Windows.Forms.ToolTip _ToolTip;
        private IContainer components;
        private frmMain MainForm;

        public frmSelectFormat(ref frmMain FormMain)
        {
            base.Load += new EventHandler(this.frmSelectFormat_Load);
            this.InitializeComponent();
            this.MainForm = FormMain;
        }

        private void AddToolTips()
        {
            string vstrName = "frmSelectFormat";
            Control btnRemove = this.btnRemove;
            this.btnRemove = (Button) btnRemove;
            this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
            vstrName = "frmSelectFormat";
            btnRemove = this.btnAdd;
            this.btnAdd = (Button) btnRemove;
            this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
            vstrName = "frmSelectFormat";
            btnRemove = this.cmbFormat;
            this.cmbFormat = (ComboBox) btnRemove;
            this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
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
            string vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });
            if (vstrFormat.IndexOf(":") >= 0)
            {
                vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });
            }
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
                    Main.SaveFormSettings(ref form);
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
                        {
                            item.Selected = true;
                        }
                        else if (Declarations.objSettings.SelectionMode == 1)
                        {
                            item.Selected = false;
                        }
                    }
                    this.MainForm.MP3View.EndUpdate();
                    form = this;
                    Main.SaveFormSettings(ref form);
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmSelectFormat_Load(object sender, EventArgs e)
        {
            Form objForm = this;
            Declarations.objResources.ResourcesToForm(ref objForm);
            objForm = this;
            Main.RestoreFormSettings(ref objForm);
            objForm = this;
            Main.WindowsXPCheck(ref objForm);
            int num2 = Declarations.objSettings.SelectFormats.Rows.Count - 1;
            for (int i = 0; i <= num2; i++)
            {
                this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.SelectFormats.Rows[i]["Format"]));
            }
            this.cmbFormat.Text = Declarations.objSettings.SelectFormat;
            this.AddToolTips();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
            this.lblInfo = new Label();
            this.framePara = new GroupBox();
            this.L2 = new Label();
            this.L1 = new Label();
            this.btnRemove = new Button();
            this.btnAdd = new Button();
            this.cmbFormat = new ComboBox();
            this.btnCancel = new Button();
            this.btnOK = new Button();
            this.lblFormat = new Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.framePara.SuspendLayout();
            this.SuspendLayout();
            this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
            this.lblInfo.ImeMode = ImeMode.NoControl;
            Point point = new Point(8, 120);
            this.lblInfo.Location = point;
            this.lblInfo.Name = "lblInfo";
            Size size = new Size(0x1f0, 0x38);
            this.lblInfo.Size = size;
            this.lblInfo.TabIndex = 0x2a;
            this.lblInfo.Text = "This function offers you the possibilty to select all the files which match the format you entered above. <ABC> stands for a alphanumeric string while <123> stands for a numeric only string.";
            this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            this.framePara.Controls.Add(this.L2);
            this.framePara.Controls.Add(this.L1);
            point = new Point(8, 0x40);
            this.framePara.Location = point;
            this.framePara.Name = "framePara";
            size = new Size(0x1f0, 0x30);
            this.framePara.Size = size;
            this.framePara.TabIndex = 0x29;
            this.framePara.TabStop = false;
            this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
            this.L2.ImeMode = ImeMode.NoControl;
            point = new Point(0x108, 0x18);
            this.L2.Location = point;
            this.L2.Name = "L2";
            size = new Size(0xe0, 0x10);
            this.L2.Size = size;
            this.L2.TabIndex = 1;
            this.L2.Text = "<123> = Numeric string";
            this.L1.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x18);
            this.L1.Location = point;
            this.L1.Name = "L1";
            size = new Size(0xe8, 0x10);
            this.L1.Size = size;
            this.L1.TabIndex = 0;
            this.L1.Text = "<ABC> = Alphanumeric string";
            this.btnRemove.ImeMode = ImeMode.NoControl;
            point = new Point(0x138, 0x20);
            this.btnRemove.Location = point;
            this.btnRemove.Name = "btnRemove";
            size = new Size(0xc0, 0x18);
            this.btnRemove.Size = size;
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "&Remove format from list";
            this.btnAdd.ImeMode = ImeMode.NoControl;
            point = new Point(0x68, 0x20);
            this.btnAdd.Location = point;
            this.btnAdd.Name = "btnAdd";
            size = new Size(0xc0, 0x18);
            this.btnAdd.Size = size;
            this.btnAdd.TabIndex = 0x27;
            this.btnAdd.Text = "&Add format to list";
            this.cmbFormat.ItemHeight = 13;
            point = new Point(0x68, 8);
            this.cmbFormat.Location = point;
            this.cmbFormat.Name = "cmbFormat";
            size = new Size(400, 0x15);
            this.cmbFormat.Size = size;
            this.cmbFormat.TabIndex = 0x26;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = ImeMode.NoControl;
            point = new Point(0x180, 0xb8);
            this.btnCancel.Location = point;
            this.btnCancel.Name = "btnCancel";
            size = new Size(120, 0x18);
            this.btnCancel.Size = size;
            this.btnCancel.TabIndex = 0x2c;
            this.btnCancel.Text = "&Cancel";
            this.btnOK.ImeMode = ImeMode.NoControl;
            point = new Point(0x100, 0xb8);
            this.btnOK.Location = point;
            this.btnOK.Name = "btnOK";
            size = new Size(120, 0x18);
            this.btnOK.Size = size;
            this.btnOK.TabIndex = 0x2b;
            this.btnOK.Text = "&OK";
            this.lblFormat.ImeMode = ImeMode.NoControl;
            point = new Point(8, 10);
            this.lblFormat.Location = point;
            this.lblFormat.Name = "lblFormat";
            size = new Size(0x60, 0x10);
            this.lblFormat.Size = size;
            this.lblFormat.TabIndex = 0x25;
            this.lblFormat.Text = "&Format:";
            this.AcceptButton = this.btnOK;
            size = new Size(5, 13);
            this.AutoScaleBaseSize = size;
            this.CancelButton = this.btnCancel;
            size = new Size(0x200, 0xd6);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.framePara);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFormat);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ImeMode = ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectFormat";
            this.ShowInTaskbar = false;
            this.Text = "Select files by format";
            this.framePara.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            this.cmbFormat.Text = StringType.FromObject(ObjectType.StrCatObj(this.cmbFormat.Text, LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 5 }, null, null)));
            this.cmbFormat.Select(this.cmbFormat.Text.Length, 0);
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
    }
}

