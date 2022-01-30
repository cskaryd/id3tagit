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

    public class frmTAG1ToFilename : Form
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
        [AccessedThroughProperty("L17")]
        private Label _L17;
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
        [AccessedThroughProperty("lbl1")]
        private Label _lbl1;
        [AccessedThroughProperty("lbl2")]
        private Label _lbl2;
        [AccessedThroughProperty("lblDigits")]
        private Label _lblDigits;
        [AccessedThroughProperty("lblFormat")]
        private Label _lblFormat;
        [AccessedThroughProperty("lblInfo")]
        private Label _lblInfo;
        [AccessedThroughProperty("ToolTip")]
        private System.Windows.Forms.ToolTip _ToolTip;
        [AccessedThroughProperty("txtDigits")]
        private NumericUpDown _txtDigits;
        [AccessedThroughProperty("txtFDigits")]
        private NumericUpDown _txtFDigits;
        [AccessedThroughProperty("txtStartNr")]
        private NumericUpDown _txtStartNr;
        private IContainer components;
        private frmMain MainForm;

        public frmTAG1ToFilename(ref frmMain FormMain)
        {
            base.Load += new EventHandler(this.frmTAG1ToFilename_Load);
            this.InitializeComponent();
            this.MainForm = FormMain;
        }

        private void AddToolTips()
        {
            string vstrName = "frmTAG2ToFilename";
            Control txtDigits = this.txtDigits;
            this.txtDigits = (NumericUpDown) txtDigits;
            this.ToolTip.SetToolTip(this.txtDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
            vstrName = "frmTAG2ToFilename";
            txtDigits = this.txtFDigits;
            this.txtFDigits = (NumericUpDown) txtDigits;
            this.ToolTip.SetToolTip(this.txtFDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
            vstrName = "frmTAG2ToFilename";
            txtDigits = this.txtStartNr;
            this.txtStartNr = (NumericUpDown) txtDigits;
            this.ToolTip.SetToolTip(this.txtStartNr, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
            vstrName = "frmTAG2ToFilename";
            txtDigits = this.btnRemove;
            this.btnRemove = (Button) txtDigits;
            this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
            vstrName = "frmTAG2ToFilename";
            txtDigits = this.btnAdd;
            this.btnAdd = (Button) txtDigits;
            this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
            vstrName = "frmTAG2ToFilename";
            txtDigits = this.cmbFormat;
            this.cmbFormat = (ComboBox) txtDigits;
            this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
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
            ArrayList list = new ArrayList();
            string vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });
            if (vstrFormat.IndexOf(":") >= 0)
            {
                vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });
            }
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
            byte filenumberStart = (byte) Declarations.objSettings.FilenumberStart;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmTAG1ToFilename_Load(object sender, EventArgs e)
        {
            Form objForm = this;
            Declarations.objResources.ResourcesToForm(ref objForm);
            objForm = this;
            Main.RestoreFormSettings(ref objForm);
            objForm = this;
            Main.WindowsXPCheck(ref objForm);
            int num2 = Declarations.objSettings.T1FFormats.Rows.Count - 1;
            for (int i = 0; i <= num2; i++)
            {
                this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.T1FFormats.Rows[i]["Format"]));
            }
            this.cmbFormat.Text = Declarations.objSettings.T1FFormat;
            this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);
            this.txtFDigits.Value = new decimal(Declarations.objSettings.FilenumberDigits);
            this.txtStartNr.Value = new decimal(Declarations.objSettings.FilenumberStart);
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
            this.lbl2 = new Label();
            this.txtFDigits = new NumericUpDown();
            this.lbl1 = new Label();
            this.txtStartNr = new NumericUpDown();
            this.L18 = new Label();
            this.L17 = new Label();
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
            this.txtDigits.BeginInit();
            this.framePara.SuspendLayout();
            this.txtFDigits.BeginInit();
            this.txtStartNr.BeginInit();
            this.SuspendLayout();
            this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
            this.lblInfo.ImeMode = ImeMode.NoControl;
            Point point = new Point(8, 240);
            this.lblInfo.Location = point;
            this.lblInfo.Name = "lblInfo";
            Size size = new Size(0x1f0, 0x38);
            this.lblInfo.Size = size;
            this.lblInfo.TabIndex = 0x2c;
            this.lblInfo.Text = "This function offers you the possibilty to extract information from the filename and write it into the TAG.  Enter the format using the parameters above. To save the format give it a description (using the following syntax: \"Description: Format\") and add it to the list.";
            this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            this.lblDigits.ImeMode = ImeMode.NoControl;
            point = new Point(0x69, 0x41);
            this.lblDigits.Location = point;
            this.lblDigits.Name = "lblDigits";
            size = new Size(0xb8, 0x10);
            this.lblDigits.Size = size;
            this.lblDigits.TabIndex = 0x29;
            this.lblDigits.Text = "&Number of digits of track numbers:";
            point = new Point(0x139, 0x3f);
            this.txtDigits.Location = point;
            decimal num = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtDigits.Minimum = num;
            this.txtDigits.Name = "txtDigits";
            size = new Size(0x40, 20);
            this.txtDigits.Size = size;
            this.txtDigits.TabIndex = 0x2a;
            this.ToolTip.SetToolTip(this.txtDigits, "Select number of digits of track numbers");
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtDigits.Value = num;
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
            point = new Point(9, 0x5f);
            this.framePara.Location = point;
            this.framePara.Name = "framePara";
            size = new Size(0x1f0, 0x89);
            this.framePara.Size = size;
            this.framePara.TabIndex = 0x2b;
            this.framePara.TabStop = false;
            this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
            this.lbl2.ImeMode = ImeMode.NoControl;
            point = new Point(240, 0x6a);
            this.lbl2.Location = point;
            this.lbl2.Name = "lbl2";
            size = new Size(0xb8, 0x10);
            this.lbl2.Size = size;
            this.lbl2.TabIndex = 0x23;
            this.lbl2.Text = "Number of digits";
            point = new Point(0xa8, 0x68);
            this.txtFDigits.Location = point;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtFDigits.Minimum = num;
            this.txtFDigits.Name = "txtFDigits";
            size = new Size(0x40, 20);
            this.txtFDigits.Size = size;
            this.txtFDigits.TabIndex = 0x24;
            this.ToolTip.SetToolTip(this.txtFDigits, "File enumeration: Number of digits in enumeration");
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtFDigits.Value = num;
            this.lbl1.ImeMode = ImeMode.NoControl;
            point = new Point(240, 0x52);
            this.lbl1.Location = point;
            this.lbl1.Name = "lbl1";
            size = new Size(0xb8, 0x10);
            this.lbl1.Size = size;
            this.lbl1.TabIndex = 0x21;
            this.lbl1.Text = "Number to start with";
            point = new Point(0xa8, 80);
            this.txtStartNr.Location = point;
            num = new decimal(new int[] { 0x989680, 0, 0, 0 });
            this.txtStartNr.Maximum = num;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtStartNr.Minimum = num;
            this.txtStartNr.Name = "txtStartNr";
            size = new Size(0x40, 20);
            this.txtStartNr.Size = size;
            this.txtStartNr.TabIndex = 0x22;
            this.ToolTip.SetToolTip(this.txtStartNr, "File enumeration: Start enumeration with selected number");
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.txtStartNr.Value = num;
            this.L18.ImeMode = ImeMode.NoControl;
            point = new Point(8, 80);
            this.L18.Location = point;
            this.L18.Name = "L18";
            size = new Size(0x98, 0x10);
            this.L18.Size = size;
            this.L18.TabIndex = 0x12;
            this.L18.Text = "<#> = Enumerate files:";
            this.L17.ImeMode = ImeMode.NoControl;
            point = new Point(0xa8, 0x38);
            this.L17.Location = point;
            this.L17.Name = "L17";
            size = new Size(0x98, 0x10);
            this.L17.Size = size;
            this.L17.TabIndex = 0x11;
            this.L17.Text = "<F> = Current Filename";
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
            point = new Point(0x139, 0x1f);
            this.btnRemove.Location = point;
            this.btnRemove.Name = "btnRemove";
            size = new Size(0xc0, 0x18);
            this.btnRemove.Size = size;
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "&Remove format from list";
            this.ToolTip.SetToolTip(this.btnRemove, "Remove the selected format from the list");
            this.btnAdd.ImeMode = ImeMode.NoControl;
            point = new Point(0x69, 0x1f);
            this.btnAdd.Location = point;
            this.btnAdd.Name = "btnAdd";
            size = new Size(0xc0, 0x18);
            this.btnAdd.Size = size;
            this.btnAdd.TabIndex = 0x27;
            this.btnAdd.Text = "&Add format to list";
            this.ToolTip.SetToolTip(this.btnAdd, "Add the entered format to list");
            this.cmbFormat.ItemHeight = 13;
            point = new Point(0x69, 7);
            this.cmbFormat.Location = point;
            this.cmbFormat.Name = "cmbFormat";
            size = new Size(400, 0x15);
            this.cmbFormat.Size = size;
            this.cmbFormat.TabIndex = 0x26;
            this.ToolTip.SetToolTip(this.cmbFormat, "Enter the format of how the filename should look like");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = ImeMode.NoControl;
            point = new Point(0x180, 0x130);
            this.btnCancel.Location = point;
            this.btnCancel.Name = "btnCancel";
            size = new Size(120, 0x18);
            this.btnCancel.Size = size;
            this.btnCancel.TabIndex = 0x2e;
            this.btnCancel.Text = "&Cancel";
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ImeMode = ImeMode.NoControl;
            point = new Point(0x100, 0x130);
            this.btnOK.Location = point;
            this.btnOK.Name = "btnOK";
            size = new Size(120, 0x18);
            this.btnOK.Size = size;
            this.btnOK.TabIndex = 0x2d;
            this.btnOK.Text = "&OK";
            this.lblFormat.ImeMode = ImeMode.NoControl;
            point = new Point(9, 7);
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
            size = new Size(0x200, 0x14e);
            this.ClientSize = size;
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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTAG1ToFilename";
            this.ShowInTaskbar = false;
            this.Text = "TAG Ver. 1 -> Filename";
            this.txtDigits.EndInit();
            this.framePara.ResumeLayout(false);
            this.txtFDigits.EndInit();
            this.txtStartNr.EndInit();
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

        private void TAG1ToFilenameCB(ref frmProgress frmProg)
        {
            bool flag = false;
            foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
            {
                Application.DoEvents();
                if (frmProg.Canceled)
                {
                    break;
                }
                MP3 tag = (MP3) item.Tag;
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
                            ListViewItem item3 = new ListViewItem {
                                Text = tag.CurrentFullName
                            };
                            objArray2 = new object[1];
                            resStrings = Declarations.objResources.ResStrings;
                            str4 = "ErrorTFExists";
                            objArray2[0] = RuntimeHelpers.GetObjectValue(resStrings[str4]);
                            objArray = objArray2;
                            flagArray = new bool[] { true };
                            LateBinding.LateCall(item3.SubItems, null, "Add", objArray, null, flagArray);
                            if (flagArray[0])
                            {
                                resStrings[str4] = RuntimeHelpers.GetObjectValue(objArray[0]);
                            }
                            this.MainForm.ErrorMsg.Items.Insert(0, item3);
                            this.MainForm.SplitterBottom.Expanded = true;
                        }
                    }
                    else
                    {
                        ListViewItem item4 = new ListViewItem {
                            Text = tag.CurrentFullName
                        };
                        objArray = new object[1];
                        resStrings = Declarations.objResources.ResStrings;
                        str4 = "InvalidPathLength";
                        objArray[0] = RuntimeHelpers.GetObjectValue(resStrings[str4]);
                        objArray2 = objArray;
                        flagArray = new bool[] { true };
                        LateBinding.LateCall(item4.SubItems, null, "Add", objArray2, null, flagArray);
                        if (flagArray[0])
                        {
                            resStrings[str4] = RuntimeHelpers.GetObjectValue(objArray2[0]);
                        }
                        this.MainForm.ErrorMsg.Items.Insert(0, item4);
                        this.MainForm.SplitterBottom.Expanded = true;
                    }
                }
                frmProg.ProgressBar.PerformStep();
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

        private void txtStartNr_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.Compare(this.txtStartNr.Value, this.txtStartNr.Minimum) < 0)
            {
                this.txtStartNr.Value = this.txtStartNr.Minimum;
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
                    this._L18.Click -= new EventHandler(this.Label_Click);
                }
                this._L18 = value;
                if (this._L18 != null)
                {
                    this._L18.Click += new EventHandler(this.Label_Click);
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

        internal virtual Label lbl1
        {
            get
            {
                return this._lbl1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lbl1 != null)
                {
                }
                this._lbl1 = value;
                if (this._lbl1 != null)
                {
                }
            }
        }

        internal virtual Label lbl2
        {
            get
            {
                return this._lbl2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lbl2 != null)
                {
                }
                this._lbl2 = value;
                if (this._lbl2 != null)
                {
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

        internal virtual NumericUpDown txtFDigits
        {
            get
            {
                return this._txtFDigits;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtFDigits != null)
                {
                    this._txtFDigits.Validated -= new EventHandler(this.txtDigits_Validated);
                }
                this._txtFDigits = value;
                if (this._txtFDigits != null)
                {
                    this._txtFDigits.Validated += new EventHandler(this.txtDigits_Validated);
                }
            }
        }

        internal virtual NumericUpDown txtStartNr
        {
            get
            {
                return this._txtStartNr;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtStartNr != null)
                {
                    this._txtStartNr.Validated -= new EventHandler(this.txtStartNr_ValueChanged);
                }
                this._txtStartNr = value;
                if (this._txtStartNr != null)
                {
                    this._txtStartNr.Validated += new EventHandler(this.txtStartNr_ValueChanged);
                }
            }
        }
    }
}

