namespace ID3_TagIT
{
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

    public class frmFilenameToTAG1 : Form
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
        [AccessedThroughProperty("L18")]
        private Label _L18;
        [AccessedThroughProperty("L2")]
        private Label _L2;
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
        [AccessedThroughProperty("lblFormat")]
        private Label _lblFormat;
        [AccessedThroughProperty("lblInfo")]
        private Label _lblInfo;
        [AccessedThroughProperty("ToolTip")]
        private System.Windows.Forms.ToolTip _ToolTip;
        private ArrayList alstFormat;
        private IContainer components;
        private frmMain MainForm;

        public frmFilenameToTAG1(ref frmMain FormMain)
        {
            base.Load += new EventHandler(this.frmFilenameToTAG1_Load);
            this.InitializeComponent();
            this.MainForm = FormMain;
        }

        private void AddToolTips()
        {
            string vstrName = "frmFilenameToTAG1";
            Control btnRemove = this.btnRemove;
            this.btnRemove = (Button) btnRemove;
            this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
            vstrName = "frmFilenameToTAG1";
            btnRemove = this.btnAdd;
            this.btnAdd = (Button) btnRemove;
            this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref btnRemove));
            vstrName = "frmFilenameToTAG1";
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
            FilenameToTAGFormat format = new FilenameToTAGFormat();
            ArrayList list = new ArrayList();
            string vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });
            if (vstrFormat.IndexOf(":") >= 0)
            {
                vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });
            }
            if (vstrFormat.StartsWith(@"\"))
            {
                vstrFormat = vstrFormat.Substring(1);
            }
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
            Main.SaveFormSettings(ref ownerForm);
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FilenameTAGV1CB(ref frmProgress frmProg)
        {
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
            {
                Application.DoEvents();
                if (frmProg.Canceled)
                {
                    break;
                }
                Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3) item.Tag, (V1TAG) LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG) LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
                frmProg.List.Add(@do);
                frmProg.Infos.Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null));
                ListViewItem item2 = item;
                MP3 tag = (MP3) item2.Tag;
                ID3Functions.FilenameToTAG(ref tag, this.alstFormat, 1);
                item2.Tag = tag;
                this.MainForm.UpdateListItem(item, false);
                frmProg.ProgressBar.PerformStep();
            }
        }

        private void frmFilenameToTAG1_Load(object sender, EventArgs e)
        {
            Form objForm = this;
            Declarations.objResources.ResourcesToForm(ref objForm);
            objForm = this;
            Main.RestoreFormSettings(ref objForm);
            objForm = this;
            Main.WindowsXPCheck(ref objForm);
            int num2 = Declarations.objSettings.FT1Formats.Rows.Count - 1;
            for (int i = 0; i <= num2; i++)
            {
                this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.FT1Formats.Rows[i]["Format"]));
            }
            this.cmbFormat.Text = Declarations.objSettings.FT1Format;
            this.AddToolTips();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
            this.lblInfo = new Label();
            this.framePara = new GroupBox();
            this.L8 = new Label();
            this.L18 = new Label();
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
            this.framePara.SuspendLayout();
            this.SuspendLayout();
            this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
            this.lblInfo.ImeMode = ImeMode.NoControl;
            Point point = new Point(8, 0x98);
            this.lblInfo.Location = point;
            this.lblInfo.Name = "lblInfo";
            Size size = new Size(0x1f0, 0x38);
            this.lblInfo.Size = size;
            this.lblInfo.TabIndex = 0x22;
            this.lblInfo.Text = "This function offers you the possibilty to extract information from the filename and write it into the TAG.  Enter the format using the parameters above. To save the format give it a description (using the following syntax: \"Description: Format\") and add it to the list.";
            this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            this.framePara.Controls.Add(this.L8);
            this.framePara.Controls.Add(this.L18);
            this.framePara.Controls.Add(this.L7);
            this.framePara.Controls.Add(this.L6);
            this.framePara.Controls.Add(this.L5);
            this.framePara.Controls.Add(this.L4);
            this.framePara.Controls.Add(this.L3);
            this.framePara.Controls.Add(this.L2);
            this.framePara.Controls.Add(this.L1);
            point = new Point(8, 0x40);
            this.framePara.Location = point;
            this.framePara.Name = "framePara";
            size = new Size(0x1f0, 80);
            this.framePara.Size = size;
            this.framePara.TabIndex = 0x21;
            this.framePara.TabStop = false;
            this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
            this.L8.ImeMode = ImeMode.NoControl;
            point = new Point(0xa8, 0x38);
            this.L8.Location = point;
            this.L8.Name = "L8";
            size = new Size(160, 0x10);
            this.L8.Size = size;
            this.L8.TabIndex = 0x10;
            this.L8.Text = "<X> = Unused";
            this.L18.ImeMode = ImeMode.NoControl;
            point = new Point(0x148, 0x38);
            this.L18.Location = point;
            this.L18.Name = "L18";
            size = new Size(0x98, 0x10);
            this.L18.Size = size;
            this.L18.TabIndex = 15;
            this.L18.Text = @"\ = Folder";
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
            this.L6.Text = "<G> = Genre";
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
            point = new Point(0x138, 0x20);
            this.btnRemove.Location = point;
            this.btnRemove.Name = "btnRemove";
            size = new Size(0xc0, 0x18);
            this.btnRemove.Size = size;
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "&Remove format from list";
            this.btnAdd.ImeMode = ImeMode.NoControl;
            point = new Point(0x68, 0x20);
            this.btnAdd.Location = point;
            this.btnAdd.Name = "btnAdd";
            size = new Size(0xc0, 0x18);
            this.btnAdd.Size = size;
            this.btnAdd.TabIndex = 0x1d;
            this.btnAdd.Text = "&Add format to list";
            this.cmbFormat.ItemHeight = 13;
            point = new Point(0x68, 8);
            this.cmbFormat.Location = point;
            this.cmbFormat.Name = "cmbFormat";
            size = new Size(400, 0x15);
            this.cmbFormat.Size = size;
            this.cmbFormat.TabIndex = 0x1c;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = ImeMode.NoControl;
            point = new Point(0x180, 0xd8);
            this.btnCancel.Location = point;
            this.btnCancel.Name = "btnCancel";
            size = new Size(120, 0x18);
            this.btnCancel.Size = size;
            this.btnCancel.TabIndex = 0x24;
            this.btnCancel.Text = "&Cancel";
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ImeMode = ImeMode.NoControl;
            point = new Point(0x100, 0xd8);
            this.btnOK.Location = point;
            this.btnOK.Name = "btnOK";
            size = new Size(120, 0x18);
            this.btnOK.Size = size;
            this.btnOK.TabIndex = 0x23;
            this.btnOK.Text = "&OK";
            this.lblFormat.ImeMode = ImeMode.NoControl;
            point = new Point(8, 10);
            this.lblFormat.Location = point;
            this.lblFormat.Name = "lblFormat";
            size = new Size(0x60, 0x10);
            this.lblFormat.Size = size;
            this.lblFormat.TabIndex = 0x1b;
            this.lblFormat.Text = "&Format:";
            this.AcceptButton = this.btnOK;
            size = new Size(5, 13);
            this.AutoScaleBaseSize = size;
            this.CancelButton = this.btnCancel;
            size = new Size(0x202, 0xf8);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilenameToTAG1";
            this.ShowInTaskbar = false;
            this.Text = "Filename -> TAG Ver. 1";
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

