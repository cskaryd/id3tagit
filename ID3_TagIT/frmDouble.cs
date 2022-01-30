namespace ID3_TagIT
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class frmDouble : Form
    {
        [AccessedThroughProperty("btnCancel")]
        private Button _btnCancel;
        [AccessedThroughProperty("btnOK")]
        private Button _btnOK;
        [AccessedThroughProperty("GroupBox")]
        private System.Windows.Forms.GroupBox _GroupBox;
        [AccessedThroughProperty("lblStatus")]
        private Label _lblStatus;
        [AccessedThroughProperty("optAD")]
        private RadioButton _optAD;
        [AccessedThroughProperty("optAT")]
        private RadioButton _optAT;
        [AccessedThroughProperty("optATA")]
        private RadioButton _optATA;
        [AccessedThroughProperty("optTAGV1")]
        private RadioButton _optTAGV1;
        [AccessedThroughProperty("optTAGV2")]
        private RadioButton _optTAGV2;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;
        [AccessedThroughProperty("ProgressBar")]
        private System.Windows.Forms.ProgressBar _ProgressBar;
        [AccessedThroughProperty("ToolTip")]
        private System.Windows.Forms.ToolTip _ToolTip;
        private IContainer components;
        private frmMain MainForm;
        private bool vbooCancel;

        public frmDouble(frmMain Main)
        {
            base.Load += new EventHandler(this.frmDouble_Load);
            this.vbooCancel = false;
            this.InitializeComponent();
            this.MainForm = Main;
        }

        private void AddToolTips()
        {
            string vstrName = "frmDouble";
            Control objControl = this.optTAGV1;
            this.optTAGV1 = (RadioButton) objControl;
            this.ToolTip.SetToolTip(this.optTAGV1, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
            vstrName = "frmDouble";
            objControl = this.optTAGV2;
            this.optTAGV2 = (RadioButton) objControl;
            this.ToolTip.SetToolTip(this.optTAGV2, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
            vstrName = "frmDouble";
            objControl = this.optAD;
            this.optAD = (RadioButton) objControl;
            this.ToolTip.SetToolTip(this.optAD, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
            vstrName = "frmDouble";
            objControl = this.optATA;
            this.optATA = (RadioButton) objControl;
            this.ToolTip.SetToolTip(this.optATA, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
            vstrName = "frmDouble";
            objControl = this.optAT;
            this.optAT = (RadioButton) objControl;
            this.ToolTip.SetToolTip(this.optAT, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.vbooCancel = true;
            this.MainForm.MP3View.EndUpdate();
            this.GroupBox.Enabled = false;
            this.btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int num;
            int num2;
            MP3 tag;
            CRC32 crc = new CRC32();
            ArrayList list2 = new ArrayList(this.MainForm.MP3View.Items.Count);
            ArrayList list4 = new ArrayList(this.MainForm.MP3View.Items.Count);
            ArrayList list = new ArrayList(this.MainForm.MP3View.Items.Count);
            ArrayList list3 = new ArrayList(this.MainForm.MP3View.Items.Count);
            if (this.optAT.Checked)
            {
                Declarations.objSettings.CompareMethod = 1;
            }
            if (this.optATA.Checked)
            {
                Declarations.objSettings.CompareMethod = 2;
            }
            if (this.optAD.Checked)
            {
                Declarations.objSettings.CompareMethod = 3;
            }
            if (this.optTAGV1.Checked)
            {
                Declarations.objSettings.CompareTAGVersion = 1;
            }
            else
            {
                Declarations.objSettings.CompareTAGVersion = 2;
            }
            Form form = this;
            Main.SaveFormSettings(ref form);
            this.vbooCancel = false;
            if (this.optAT.Checked)
            {
                this.btnOK.Enabled = false;
                this.GroupBox.Enabled = true;
                this.lblStatus.Text = StringType.FromObject(Declarations.objResources.ResStrings["DoubleCreating"]);
                if (this.optTAGV1.Checked)
                {
                    int num14 = this.MainForm.MP3View.Items.Count - 1;
                    for (num = 0; num <= num14; num++)
                    {
                        if (this.vbooCancel)
                        {
                            return;
                        }
                        tag = (MP3) this.MainForm.MP3View.Items[num].Tag;
                        list2.Add(tag.V1TAG.Artist);
                        list4.Add(tag.V1TAG.Title);
                        this.ProgressBar.PerformStep();
                        if ((num % 50) == 0)
                        {
                            Application.DoEvents();
                        }
                    }
                }
                else if (this.optTAGV2.Checked)
                {
                    int num13 = this.MainForm.MP3View.Items.Count - 1;
                    for (num = 0; num <= num13; num++)
                    {
                        if (this.vbooCancel)
                        {
                            return;
                        }
                        tag = (MP3) this.MainForm.MP3View.Items[num].Tag;
                        if (tag.V2TAG.FrameExists("TPE1") && tag.V2TAG.FrameExists("TIT2"))
                        {
                            list2.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null)));
                            list4.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null)));
                        }
                        else
                        {
                            list2.Add("");
                            list4.Add("");
                        }
                        this.ProgressBar.PerformStep();
                        if ((num % 50) == 0)
                        {
                            Application.DoEvents();
                        }
                    }
                }
                this.lblStatus.Text = StringType.FromObject(Declarations.objResources.ResStrings["DoubleComparing"]);
                this.ProgressBar.Value = 0;
                this.MainForm.MP3View.BeginUpdate();
                int num12 = this.MainForm.MP3View.Items.Count - 2;
                for (num = 0; num <= num12; num++)
                {
                    if (this.vbooCancel)
                    {
                        return;
                    }
                    int num11 = this.MainForm.MP3View.Items.Count - 1;
                    num2 = num + 1;
                    while (num2 <= num11)
                    {
                        if (((ObjectType.ObjTst(list2[num], "", false) != 0) && (string.Compare(StringType.FromObject(list2[num]), StringType.FromObject(list2[num2]), true) == 0)) && ((ObjectType.ObjTst(list4[num], "", false) != 0) && (string.Compare(StringType.FromObject(list4[num]), StringType.FromObject(list4[num2]), true) == 0)))
                        {
                            LateBinding.LateSetComplex(this.MainForm.MP3View.Items[num].Tag, null, "Doubled", new object[] { true }, null, false, true);
                            LateBinding.LateSetComplex(this.MainForm.MP3View.Items[num2].Tag, null, "Doubled", new object[] { true }, null, false, true);
                            this.MainForm.UpdateListItem(this.MainForm.MP3View.Items[num], false);
                            this.MainForm.UpdateListItem(this.MainForm.MP3View.Items[num2], false);
                            break;
                        }
                        num2++;
                    }
                    this.ProgressBar.PerformStep();
                    if ((num % 50) == 0)
                    {
                        Application.DoEvents();
                    }
                }
                this.MainForm.MP3View.EndUpdate();
            }
            if (this.optATA.Checked)
            {
                this.btnOK.Enabled = false;
                this.GroupBox.Enabled = true;
                this.lblStatus.Text = StringType.FromObject(Declarations.objResources.ResStrings["DoubleCreating"]);
                if (this.optTAGV1.Checked)
                {
                    int num10 = this.MainForm.MP3View.Items.Count - 1;
                    for (num = 0; num <= num10; num++)
                    {
                        if (this.vbooCancel)
                        {
                            return;
                        }
                        tag = (MP3) this.MainForm.MP3View.Items[num].Tag;
                        list2.Add(tag.V1TAG.Artist);
                        list4.Add(tag.V1TAG.Title);
                        list.Add(tag.V1TAG.Album);
                        this.ProgressBar.PerformStep();
                        if ((num % 50) == 0)
                        {
                            Application.DoEvents();
                        }
                    }
                }
                else if (this.optTAGV2.Checked)
                {
                    int num9 = this.MainForm.MP3View.Items.Count - 1;
                    for (num = 0; num <= num9; num++)
                    {
                        if (this.vbooCancel)
                        {
                            return;
                        }
                        tag = (MP3) this.MainForm.MP3View.Items[num].Tag;
                        if ((tag.V2TAG.FrameExists("TPE1") && tag.V2TAG.FrameExists("TIT2")) && tag.V2TAG.FrameExists("TALB"))
                        {
                            list2.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null)));
                            list4.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null)));
                            list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null)));
                        }
                        else
                        {
                            list2.Add("");
                            list4.Add("");
                            list.Add("");
                        }
                        this.ProgressBar.PerformStep();
                        if ((num % 50) == 0)
                        {
                            Application.DoEvents();
                        }
                    }
                }
                this.lblStatus.Text = StringType.FromObject(Declarations.objResources.ResStrings["DoubleComparing"]);
                this.ProgressBar.Value = 0;
                this.MainForm.MP3View.BeginUpdate();
                int num8 = this.MainForm.MP3View.Items.Count - 2;
                for (num = 0; num <= num8; num++)
                {
                    if (this.vbooCancel)
                    {
                        return;
                    }
                    int num7 = this.MainForm.MP3View.Items.Count - 1;
                    num2 = num + 1;
                    while (num2 <= num7)
                    {
                        if ((((ObjectType.ObjTst(list2[num], "", false) != 0) && (string.Compare(StringType.FromObject(list2[num]), StringType.FromObject(list2[num2]), true) == 0)) && ((ObjectType.ObjTst(list4[num], "", false) != 0) && (string.Compare(StringType.FromObject(list4[num]), StringType.FromObject(list4[num2]), true) == 0))) && ((ObjectType.ObjTst(list[num], "", false) != 0) && (string.Compare(StringType.FromObject(list[num]), StringType.FromObject(list[num2]), true) == 0)))
                        {
                            LateBinding.LateSetComplex(this.MainForm.MP3View.Items[num].Tag, null, "Doubled", new object[] { true }, null, false, true);
                            LateBinding.LateSetComplex(this.MainForm.MP3View.Items[num2].Tag, null, "Doubled", new object[] { true }, null, false, true);
                            this.MainForm.UpdateListItem(this.MainForm.MP3View.Items[num], false);
                            this.MainForm.UpdateListItem(this.MainForm.MP3View.Items[num2], false);
                            break;
                        }
                        num2++;
                    }
                    this.ProgressBar.PerformStep();
                    if ((num % 50) == 0)
                    {
                        Application.DoEvents();
                    }
                }
                this.MainForm.MP3View.EndUpdate();
            }
            if (this.optAD.Checked)
            {
                this.btnOK.Enabled = false;
                this.GroupBox.Enabled = true;
                this.lblStatus.Text = StringType.FromObject(Declarations.objResources.ResStrings["DoubleCreating"]);
                int num6 = this.MainForm.MP3View.Items.Count - 1;
                for (num = 0; num <= num6; num++)
                {
                    if (this.vbooCancel)
                    {
                        return;
                    }
                    tag = (MP3) this.MainForm.MP3View.Items[num].Tag;
                    if (tag.AudioCheckSum == 0)
                    {
                        tag.CalcAudioCheckSum();
                    }
                    list3.Add(tag.AudioCheckSum);
                    this.ProgressBar.PerformStep();
                    this.lblStatus.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["DoubleCreating"], " ("), num.ToString()), ")"));
                    Application.DoEvents();
                }
                this.ProgressBar.Value = 0;
                this.lblStatus.Text = StringType.FromObject(Declarations.objResources.ResStrings["DoubleComparing"]);
                this.MainForm.MP3View.BeginUpdate();
                int num5 = this.MainForm.MP3View.Items.Count - 2;
                for (num = 0; num <= num5; num++)
                {
                    if (this.vbooCancel)
                    {
                        return;
                    }
                    tag = (MP3) this.MainForm.MP3View.Items[num].Tag;
                    if (this.MainForm.MP3View.Columns.Contains(this.MainForm.colHAudioCheckSum))
                    {
                        this.MainForm.MP3View.Items[num].SubItems[this.MainForm.colHAudioCheckSum.Index].Text = StringType.FromObject(Interaction.IIf(tag.AudioCheckSum != 0, tag.AudioCheckSum.ToString(), ""));
                    }
                    int num3 = this.MainForm.MP3View.Items.Count - 1;
                    for (num2 = num + 1; num2 <= num3; num2++)
                    {
                        if ((ObjectType.ObjTst(list3[num], 0, false) != 0) && (ObjectType.ObjTst(list3[num], list3[num2], false) == 0))
                        {
                            LateBinding.LateSetComplex(this.MainForm.MP3View.Items[num].Tag, null, "Doubled", new object[] { true }, null, false, true);
                            LateBinding.LateSetComplex(this.MainForm.MP3View.Items[num2].Tag, null, "Doubled", new object[] { true }, null, false, true);
                            this.MainForm.UpdateListItem(this.MainForm.MP3View.Items[num], false);
                            this.MainForm.UpdateListItem(this.MainForm.MP3View.Items[num2], false);
                            break;
                        }
                    }
                    this.ProgressBar.PerformStep();
                    if ((num % 50) == 0)
                    {
                        Application.DoEvents();
                    }
                }
                if (this.MainForm.MP3View.Columns.Contains(this.MainForm.colHAudioCheckSum))
                {
                    this.MainForm.MP3View.Items[this.MainForm.MP3View.Items.Count - 1].SubItems[this.MainForm.colHAudioCheckSum.Index].Text = StringType.FromObject(Interaction.IIf(ObjectType.ObjTst(LateBinding.LateGet(this.MainForm.MP3View.Items[this.MainForm.MP3View.Items.Count - 1].Tag, null, "AudioCheckSum", new object[0], null, null), 0, false) != 0, LateBinding.LateGet(this.MainForm.MP3View.Items[this.MainForm.MP3View.Items.Count - 1].Tag, null, "AudioCheckSum", new object[0], null, null).ToString(), ""));
                }
                Application.DoEvents();
                this.MainForm.MP3View.EndUpdate();
            }
            this.GroupBox.Enabled = false;
            this.btnOK.Enabled = true;
            this.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmDouble_Load(object sender, EventArgs e)
        {
            Form objForm = this;
            Declarations.objResources.ResourcesToForm(ref objForm);
            objForm = this;
            Main.RestoreFormSettings(ref objForm);
            objForm = this;
            Main.WindowsXPCheck(ref objForm);
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Maximum = this.MainForm.MP3View.Items.Count - 2;
            this.ProgressBar.Step = 1;
            switch (Declarations.objSettings.CompareMethod)
            {
                case 1:
                    this.optAT.Checked = true;
                    break;

                case 2:
                    this.optATA.Checked = true;
                    break;

                case 3:
                    this.optAD.Checked = true;
                    break;
            }
            if (Declarations.objSettings.CompareTAGVersion == 1)
            {
                this.optTAGV1.Checked = true;
            }
            else
            {
                this.optTAGV2.Checked = true;
            }
            this.AddToolTips();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
            this.btnCancel = new Button();
            this.btnOK = new Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.lblStatus = new Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Panel1 = new Panel();
            this.optTAGV1 = new RadioButton();
            this.optTAGV2 = new RadioButton();
            this.Panel2 = new Panel();
            this.optAD = new RadioButton();
            this.optATA = new RadioButton();
            this.optAT = new RadioButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = ImeMode.NoControl;
            Point point = new Point(0x160, 0x100);
            this.btnCancel.Location = point;
            this.btnCancel.Name = "btnCancel";
            Size size = new Size(0x70, 0x18);
            this.btnCancel.Size = size;
            this.btnCancel.TabIndex = 0x13;
            this.btnCancel.Text = "&Cancel";
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ImeMode = ImeMode.NoControl;
            point = new Point(0xe8, 0x100);
            this.btnOK.Location = point;
            this.btnOK.Name = "btnOK";
            size = new Size(0x70, 0x18);
            this.btnOK.Size = size;
            this.btnOK.TabIndex = 0x12;
            this.btnOK.Text = "&OK";
            this.GroupBox.Controls.Add(this.lblStatus);
            this.GroupBox.Controls.Add(this.ProgressBar);
            this.GroupBox.Enabled = false;
            point = new Point(8, 0xa8);
            this.GroupBox.Location = point;
            this.GroupBox.Name = "GroupBox";
            size = new Size(0x1d0, 80);
            this.GroupBox.Size = size;
            this.GroupBox.TabIndex = 20;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Progress ...";
            this.lblStatus.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x18);
            this.lblStatus.Location = point;
            this.lblStatus.Name = "lblStatus";
            size = new Size(0x1c0, 0x10);
            this.lblStatus.Size = size;
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            this.ProgressBar.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x30);
            this.ProgressBar.Location = point;
            this.ProgressBar.Name = "ProgressBar";
            size = new Size(0x1c0, 0x10);
            this.ProgressBar.Size = size;
            this.ProgressBar.TabIndex = 0;
            this.Panel1.Controls.Add(this.optTAGV1);
            this.Panel1.Controls.Add(this.optTAGV2);
            point = new Point(8, 0x68);
            this.Panel1.Location = point;
            this.Panel1.Name = "Panel1";
            size = new Size(0x1d0, 0x38);
            this.Panel1.Size = size;
            this.Panel1.TabIndex = 0x16;
            this.optTAGV1.ImeMode = ImeMode.NoControl;
            point = new Point(8, 8);
            this.optTAGV1.Location = point;
            this.optTAGV1.Name = "optTAGV1";
            size = new Size(0x100, 0x10);
            this.optTAGV1.Size = size;
            this.optTAGV1.TabIndex = 5;
            this.optTAGV1.Text = "Use TAG Ver. 1 for comparing";
            this.optTAGV2.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x20);
            this.optTAGV2.Location = point;
            this.optTAGV2.Name = "optTAGV2";
            size = new Size(0x100, 0x10);
            this.optTAGV2.Size = size;
            this.optTAGV2.TabIndex = 4;
            this.optTAGV2.Text = "Use TAG Ver. 2 for comparing";
            this.Panel2.Controls.Add(this.optAD);
            this.Panel2.Controls.Add(this.optATA);
            this.Panel2.Controls.Add(this.optAT);
            point = new Point(8, 8);
            this.Panel2.Location = point;
            this.Panel2.Name = "Panel2";
            size = new Size(0x1d0, 0x58);
            this.Panel2.Size = size;
            this.Panel2.TabIndex = 0x17;
            this.optAD.ImeMode = ImeMode.NoControl;
            point = new Point(8, 60);
            this.optAD.Location = point;
            this.optAD.Name = "optAD";
            size = new Size(0x1a8, 0x10);
            this.optAD.Size = size;
            this.optAD.TabIndex = 8;
            this.optAD.Text = "Find files with same audio data (LENGTHLY operation)";
            this.optATA.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x24);
            this.optATA.Location = point;
            this.optATA.Name = "optATA";
            size = new Size(0x1a8, 0x10);
            this.optATA.Size = size;
            this.optATA.TabIndex = 7;
            this.optATA.Text = "Find files with same artist, title, album";
            this.optAT.ImeMode = ImeMode.NoControl;
            point = new Point(8, 12);
            this.optAT.Location = point;
            this.optAT.Name = "optAT";
            size = new Size(0x1a8, 0x10);
            this.optAT.Size = size;
            this.optAT.TabIndex = 6;
            this.optAT.Text = "Find files with same artist and title";
            this.AcceptButton = this.btnOK;
            size = new Size(5, 13);
            this.AutoScaleBaseSize = size;
            this.CancelButton = this.btnCancel;
            size = new Size(480, 0x120);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "frmDouble";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Find duplicate files";
            this.GroupBox.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
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
                    this._btnCancel.Click -= new EventHandler(this.btnCancel_Click);
                }
                this._btnCancel = value;
                if (this._btnCancel != null)
                {
                    this._btnCancel.Click += new EventHandler(this.btnCancel_Click);
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

        internal virtual System.Windows.Forms.GroupBox GroupBox
        {
            get
            {
                return this._GroupBox;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._GroupBox != null)
                {
                }
                this._GroupBox = value;
                if (this._GroupBox != null)
                {
                }
            }
        }

        internal virtual Label lblStatus
        {
            get
            {
                return this._lblStatus;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblStatus != null)
                {
                }
                this._lblStatus = value;
                if (this._lblStatus != null)
                {
                }
            }
        }

        internal virtual RadioButton optAD
        {
            get
            {
                return this._optAD;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optAD != null)
                {
                }
                this._optAD = value;
                if (this._optAD != null)
                {
                }
            }
        }

        internal virtual RadioButton optAT
        {
            get
            {
                return this._optAT;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optAT != null)
                {
                }
                this._optAT = value;
                if (this._optAT != null)
                {
                }
            }
        }

        internal virtual RadioButton optATA
        {
            get
            {
                return this._optATA;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optATA != null)
                {
                }
                this._optATA = value;
                if (this._optATA != null)
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
                }
                this._optTAGV1 = value;
                if (this._optTAGV1 != null)
                {
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
                }
                this._optTAGV2 = value;
                if (this._optTAGV2 != null)
                {
                }
            }
        }

        internal virtual Panel Panel1
        {
            get
            {
                return this._Panel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Panel1 != null)
                {
                }
                this._Panel1 = value;
                if (this._Panel1 != null)
                {
                }
            }
        }

        internal virtual Panel Panel2
        {
            get
            {
                return this._Panel2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Panel2 != null)
                {
                }
                this._Panel2 = value;
                if (this._Panel2 != null)
                {
                }
            }
        }

        internal virtual System.Windows.Forms.ProgressBar ProgressBar
        {
            get
            {
                return this._ProgressBar;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._ProgressBar != null)
                {
                }
                this._ProgressBar = value;
                if (this._ProgressBar != null)
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

