namespace ID3_TagIT
{
    using DevComponents.DotNetBar;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;

    public class frmLists : Form
    {
        [AccessedThroughProperty("barBottomDockSite")]
        private DockSite _barBottomDockSite;
        [AccessedThroughProperty("barLeftDockSite")]
        private DockSite _barLeftDockSite;
        [AccessedThroughProperty("barRightDockSite")]
        private DockSite _barRightDockSite;
        [AccessedThroughProperty("barTopDockSite")]
        private DockSite _barTopDockSite;
        [AccessedThroughProperty("btnClose")]
        private Button _btnClose;
        [AccessedThroughProperty("btnCreateFromTemp")]
        private Button _btnCreateFromTemp;
        [AccessedThroughProperty("btnCreatePlaylist")]
        private Button _btnCreatePlaylist;
        [AccessedThroughProperty("btnCreateQuickLists")]
        private Button _btnCreateQuickLists;
        [AccessedThroughProperty("btnDown")]
        private Button _btnDown;
        [AccessedThroughProperty("btnPath")]
        private Button _btnPath;
        [AccessedThroughProperty("btnUp")]
        private Button _btnUp;
        [AccessedThroughProperty("ButtomPanel")]
        private PanelEx _ButtomPanel;
        [AccessedThroughProperty("chkColor")]
        private CheckBox _chkColor;
        [AccessedThroughProperty("chkCreateCSV")]
        private CheckBox _chkCreateCSV;
        [AccessedThroughProperty("chkCreateHTML")]
        private CheckBox _chkCreateHTML;
        [AccessedThroughProperty("chkGridlines")]
        private CheckBox _chkGridlines;
        [AccessedThroughProperty("chkRelativ")]
        private CheckBox _chkRelativ;
        [AccessedThroughProperty("cmbWidth")]
        private ComboBox _cmbWidth;
        [AccessedThroughProperty("ColumnsList")]
        private ListView _ColumnsList;
        [AccessedThroughProperty("DotNetBarManager1")]
        private DotNetBarManager _DotNetBarManager1;
        [AccessedThroughProperty("frameColumns")]
        private GroupBox _frameColumns;
        [AccessedThroughProperty("frameOptions")]
        private GroupBox _frameOptions;
        [AccessedThroughProperty("framePara")]
        private GroupBox _framePara;
        [AccessedThroughProperty("frameTAGInfo")]
        private GroupBox _frameTAGInfo;
        [AccessedThroughProperty("L1")]
        private Label _L1;
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
        [AccessedThroughProperty("lblInfo1")]
        private Label _lblInfo1;
        [AccessedThroughProperty("lblInfo2")]
        private Label _lblInfo2;
        [AccessedThroughProperty("lblInfo3")]
        private Label _lblInfo3;
        [AccessedThroughProperty("lblListWidth")]
        private Label _lblListWidth;
        [AccessedThroughProperty("lblPath")]
        private Label _lblPath;
        [AccessedThroughProperty("lblPlaylist")]
        private Label _lblPlaylist;
        [AccessedThroughProperty("lblTitleHTML")]
        private Label _lblTitleHTML;
        [AccessedThroughProperty("optID3V1")]
        private RadioButton _optID3V1;
        [AccessedThroughProperty("optID3V2")]
        private RadioButton _optID3V2;
        [AccessedThroughProperty("ProgressBar")]
        private System.Windows.Forms.ProgressBar _ProgressBar;
        [AccessedThroughProperty("SaveFileDialog")]
        private System.Windows.Forms.SaveFileDialog _SaveFileDialog;
        [AccessedThroughProperty("TabControl1")]
        private DevComponents.DotNetBar.TabControl _TabControl1;
        [AccessedThroughProperty("TabControlPanel1")]
        private TabControlPanel _TabControlPanel1;
        [AccessedThroughProperty("TabControlPanel2")]
        private TabControlPanel _TabControlPanel2;
        [AccessedThroughProperty("TabControlPanel3")]
        private TabControlPanel _TabControlPanel3;
        [AccessedThroughProperty("tabFilelist")]
        private TabItem _tabFilelist;
        [AccessedThroughProperty("tabPlaylist")]
        private TabItem _tabPlaylist;
        [AccessedThroughProperty("tabTemp")]
        private TabItem _tabTemp;
        [AccessedThroughProperty("TemplatesList")]
        private ListBox _TemplatesList;
        [AccessedThroughProperty("ToolTip")]
        private System.Windows.Forms.ToolTip _ToolTip;
        [AccessedThroughProperty("TopPanel")]
        private PanelEx _TopPanel;
        [AccessedThroughProperty("txtExtInfo")]
        private TextBox _txtExtInfo;
        [AccessedThroughProperty("txtPath")]
        private TextBox _txtPath;
        [AccessedThroughProperty("txtTitleHTML")]
        private TextBox _txtTitleHTML;
        [AccessedThroughProperty("txtWidth")]
        private NumericUpDown _txtWidth;
        private IContainer components;
        public frmMain MainForm;
        private string vstrComparePath;
        private string vstrTemplatesPath;

        public frmLists()
        {
            base.Load += new EventHandler(this.frmLists_Load);
            this.vstrComparePath = "*";
            this.vstrTemplatesPath = StringType.FromObject(Interaction.IIf(Application.StartupPath.EndsWith(@"\"), Application.StartupPath + @"Templetes\", Application.StartupPath + @"\Templetes\"));
            this.InitializeComponent();
            this.AddColumns();
            this.cmbWidth.SelectedIndex = 0;
            this.txtWidth.Minimum = decimal.Zero;
            this.txtWidth.Maximum = 4096M;
            this.txtWidth.Value = 600M;
        }

        public void AddColumns()
        {
            int num;
            bool flag = false;
            this.ColumnsList.Columns.Add("Name", this.ColumnsList.Width - 0x19, HorizontalAlignment.Left);
            string[] array = Declarations.objSettings.ListColumns.Split(new char[] { '-' });
            int num2 = Declarations.objSettings.Columns.Rows.Count - 1;
            for (num = 0; num <= num2; num++)
            {
                DataRow row = Declarations.objSettings.Columns.Rows[num];
                ListViewItem item2 = new ListViewItem {
                    Text = StringType.FromObject(Declarations.objResources.ResStrings["Col" + row["ID"].ToString().PadLeft(2, '0')])
                };
                if (Array.IndexOf(array, "Col" + row["ID"].ToString().PadLeft(2, '0')) > -1)
                {
                    item2.Checked = true;
                }
                item2.Tag = RuntimeHelpers.GetObjectValue(row["ID"]);
                this.ColumnsList.Items.Add(item2);
            }
            num = 2;
            do
            {
                foreach (ListViewItem item in this.ColumnsList.Items)
                {
                    if (ObjectType.ObjTst(item.Tag, num, false) == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    ListViewItem item3 = new ListViewItem(Convert.ToString(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["Col" + num.ToString().PadLeft(2, '0')])));
                    if (Array.IndexOf(array, num.ToString()) > -1)
                    {
                        item3.Checked = true;
                    }
                    item3.Tag = num;
                    this.ColumnsList.Items.Add(item3);
                }
                flag = false;
                num++;
            }
            while (num <= 0x17);
        }

        private void AddToolTips()
        {
            string vstrName = "frmLists";
            Control chkRelativ = this.chkRelativ;
            this.chkRelativ = (CheckBox) chkRelativ;
            this.ToolTip.SetToolTip(this.chkRelativ, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.btnPath;
            this.btnPath = (Button) chkRelativ;
            this.ToolTip.SetToolTip(this.btnPath, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.txtPath;
            this.txtPath = (TextBox) chkRelativ;
            this.ToolTip.SetToolTip(this.txtPath, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.chkColor;
            this.chkColor = (CheckBox) chkRelativ;
            this.ToolTip.SetToolTip(this.chkColor, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.chkGridlines;
            this.chkGridlines = (CheckBox) chkRelativ;
            this.ToolTip.SetToolTip(this.chkGridlines, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.txtWidth;
            this.txtWidth = (NumericUpDown) chkRelativ;
            this.ToolTip.SetToolTip(this.txtWidth, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.cmbWidth;
            this.cmbWidth = (ComboBox) chkRelativ;
            this.ToolTip.SetToolTip(this.cmbWidth, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.optID3V1;
            this.optID3V1 = (RadioButton) chkRelativ;
            this.ToolTip.SetToolTip(this.optID3V1, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.optID3V2;
            this.optID3V2 = (RadioButton) chkRelativ;
            this.ToolTip.SetToolTip(this.optID3V2, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.txtTitleHTML;
            this.txtTitleHTML = (TextBox) chkRelativ;
            this.ToolTip.SetToolTip(this.txtTitleHTML, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.ColumnsList;
            this.ColumnsList = (ListView) chkRelativ;
            this.ToolTip.SetToolTip(this.ColumnsList, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.btnUp;
            this.btnUp = (Button) chkRelativ;
            this.ToolTip.SetToolTip(this.btnUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
            vstrName = "frmLists";
            chkRelativ = this.btnDown;
            this.btnDown = (Button) chkRelativ;
            this.ToolTip.SetToolTip(this.btnDown, Declarations.objResources.GetToolTip(ref vstrName, ref chkRelativ));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form form = this;
            Main.SaveFormSettings(ref form);
            string str = this.txtPath.Text.Trim(new char[] { ' ' });
            if ((str.LastIndexOf(".") > 0) & (str.LastIndexOf(".") > str.LastIndexOf(@"\")))
            {
                str = str.Remove(str.LastIndexOf("."), str.Length - str.LastIndexOf("."));
            }
            if (StringType.StrCmp(this.vstrComparePath, "*", false) == 0)
            {
                Declarations.objSettings.ListPath = str;
            }
            Declarations.objSettings.PlaylistRelPath = this.chkRelativ.Checked;
            Declarations.objSettings.ListStyle = 0;
            if (this.chkCreateHTML.Checked)
            {
                Declarations.objSettings.ListStyle = (byte) (Declarations.objSettings.ListStyle | 1);
            }
            if (this.chkCreateCSV.Checked)
            {
                Declarations.objSettings.ListStyle = (byte) (Declarations.objSettings.ListStyle | 2);
            }
            Declarations.objSettings.ListColumns = "";
            foreach (ListViewItem item in this.ColumnsList.Items)
            {
                if (item.Checked)
                {
                    Settings objSettings = Declarations.objSettings;
                    objSettings.ListColumns = objSettings.ListColumns + item.Tag.ToString() + "-";
                }
            }
            Declarations.objSettings.ListColumns = Declarations.objSettings.ListColumns.TrimEnd(new char[] { '-' });
            Declarations.objSettings.HTMLListTitle = this.txtTitleHTML.Text;
            Declarations.objSettings.HTMLListWidth = this.txtWidth.Text;
            Declarations.objSettings.HTMLListWidthUnit = this.cmbWidth.Text;
            Declarations.objSettings.HTMLGridlines = this.chkGridlines.Checked;
            Declarations.objSettings.HTMLColored = this.chkColor.Checked;
            Declarations.objSettings.ListExtInfo = this.txtExtInfo.Text.Trim();
            if (this.optID3V2.Checked)
            {
                Declarations.objSettings.HTMLTAGVersion = 2;
            }
            else
            {
                Declarations.objSettings.HTMLTAGVersion = 1;
            }
            this.Close();
        }

        private void btnCreateFromTemp_Click(object sender, EventArgs e)
        {
            if (this.TemplatesList.Items.Count != 0)
            {
                string str;
                if (this.TemplatesList.SelectedItem == null)
                {
                    this.TemplatesList.SelectedIndex = 0;
                }
                string path = StringType.FromObject(ObjectType.StrCatObj(this.vstrTemplatesPath, this.TemplatesList.SelectedItem));
                string str2 = this.txtPath.Text.Trim(new char[] { ' ' });
                StreamReader reader = new StreamReader(path);
                ArrayList list2 = new ArrayList();
                ArrayList list3 = new ArrayList();
                ArrayList list = new ArrayList();
                byte num = 0;
                do
                {
                    str = reader.ReadLine();
                    if (!((str == null) | (StringType.StrCmp(str, "", false) == 0)))
                    {
                        str.TrimEnd(new char[] { '\r' });
                        if (str.StartsWith("[ITLHEADER]"))
                        {
                            num = 1;
                        }
                        if (str.StartsWith("[ITLRECORD]"))
                        {
                            num = 2;
                        }
                        if (str.StartsWith("[ITLFOOTER]"))
                        {
                            num = 3;
                        }
                        if (str.StartsWith("[ITLEXTENSION]"))
                        {
                            num = 4;
                        }
                        if (!str.StartsWith("[ITL"))
                        {
                            switch (num)
                            {
                                case 1:
                                    list2.Add(str);
                                    break;

                                case 2:
                                    list3.Add(str);
                                    break;

                                case 3:
                                    list.Add(str);
                                    break;

                                case 4:
                                    str2 = str2 + "." + str.Trim();
                                    num = 0;
                                    break;
                            }
                        }
                    }
                }
                while (str != null);
                reader.Close();
                try
                {
                    File.Create(str2).Close();
                    File.Delete(str2);
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidName"]), MsgBoxStyle.Exclamation, null);
                    ProjectData.ClearProjectError();
                    return;
                }
                this.Enabled = false;
                StreamWriter writer = new StreamWriter(str2);
                using (IEnumerator enumerator4 = list2.GetEnumerator())
                {
                    while (enumerator4.MoveNext())
                    {
                        str = StringType.FromObject(enumerator4.Current);
                        writer.WriteLine(str);
                    }
                }
                foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
                {
                    using (IEnumerator enumerator2 = list3.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            str = StringType.FromObject(enumerator2.Current);
                            if (str.IndexOf("%Filename%") > -1)
                            {
                                str = str.Replace("%Filename%", this.GetTempData(item, "%Filename%", ""));
                            }
                            if (str.IndexOf("%Subdirectory%") > -1)
                            {
                                str = str.Replace("%Subdirectory%", this.GetTempData(item, "%Subdirectory%", ""));
                            }
                            if (str.IndexOf("%Ver1%") > -1)
                            {
                                str = str.Replace("%Ver1%", this.GetTempData(item, "%Ver1%", ""));
                            }
                            if (str.IndexOf("%Ver2%") > -1)
                            {
                                str = str.Replace("%Ver2%", this.GetTempData(item, "%Ver2%", ""));
                            }
                            if (str.IndexOf("%Artist%") > -1)
                            {
                                str = str.Replace("%Artist%", this.GetTempData(item, "%Artist%", ""));
                            }
                            if (str.IndexOf("%Title%") > -1)
                            {
                                str = str.Replace("%Title%", this.GetTempData(item, "%Title%", ""));
                            }
                            if (str.IndexOf("%Album%") > -1)
                            {
                                str = str.Replace("%Album%", this.GetTempData(item, "%Album%", ""));
                            }
                            if (str.IndexOf("%Track%") > -1)
                            {
                                str = str.Replace("%Track%", this.GetTempData(item, "%Track%", ""));
                            }
                            if (str.IndexOf("%Position%") > -1)
                            {
                                str = str.Replace("%Position%", this.GetTempData(item, "%Position%", ""));
                            }
                            if (str.IndexOf("%Comment%") > -1)
                            {
                                str = str.Replace("%Comment%", this.GetTempData(item, "%Comment%", ""));
                            }
                            if (str.IndexOf("%Genre%") > -1)
                            {
                                str = str.Replace("%Genre%", this.GetTempData(item, "%Genre%", ""));
                            }
                            if (str.IndexOf("%Year%") > -1)
                            {
                                str = str.Replace("%Year%", this.GetTempData(item, "%Year%", ""));
                            }
                            if (str.IndexOf("%Rating%") > -1)
                            {
                                str = str.Replace("%Rating%", this.GetTempData(item, "%Rating%", ""));
                            }
                            if (str.IndexOf("%Duration%") > -1)
                            {
                                str = str.Replace("%Duration%", this.GetTempData(item, "%DurationSec%", ""));
                            }
                            if (str.IndexOf("%DurationSec%") > -1)
                            {
                                str = str.Replace("%DurationSec%", this.GetTempData(item, "%Duration%", ""));
                            }
                            if (str.IndexOf("%Bitrate%") > -1)
                            {
                                str = str.Replace("%Bitrate%", this.GetTempData(item, "%Bitrate%", ""));
                            }
                            if (str.IndexOf("%CBRVBR%") > -1)
                            {
                                str = str.Replace("%CBRVBR%", this.GetTempData(item, "%CBRVBR%", ""));
                            }
                            if (str.IndexOf("%Samplerate%") > -1)
                            {
                                str = str.Replace("%Samplerate%", this.GetTempData(item, "%Samplerate%", ""));
                            }
                            if (str.IndexOf("%Channel%") > -1)
                            {
                                str = str.Replace("%Channel%", this.GetTempData(item, "%Channel%", ""));
                            }
                            if (str.IndexOf("%Version%") > -1)
                            {
                                str = str.Replace("%Version%", this.GetTempData(item, "%Version%", ""));
                            }
                            if (str.IndexOf("%LastChanged%") > -1)
                            {
                                str = str.Replace("%LastChanged%", this.GetTempData(item, "%LastChanged%", ""));
                            }
                            if (str.IndexOf("%Composer%") > -1)
                            {
                                str = str.Replace("%Composer%", this.GetTempData(item, "%Composer%", ""));
                            }
                            if (str.IndexOf("%FileSize%") > -1)
                            {
                                str = str.Replace("%FileSize%", this.GetTempData(item, "%FileSize%", ""));
                            }
                            if (str.IndexOf("%BPM%") > -1)
                            {
                                str = str.Replace("%BPM%", this.GetTempData(item, "%BPM%", ""));
                            }
                            if (str.IndexOf("%FullFilename%") > -1)
                            {
                                str = str.Replace("%FullFilename%", this.GetTempData(item, "%FullFilename%", str2));
                            }
                            if (str.IndexOf("%RelFilename%") > -1)
                            {
                                str = str.Replace("%RelFilename%", this.GetTempData(item, "%RelFilename%", str2));
                            }
                            if (str.IndexOf("%CRC%") > -1)
                            {
                                str = str.Replace("%CRC%", this.GetTempData(item, "%CRC%", ""));
                            }
                            writer.WriteLine(str);
                        }
                    }
                    this.ProgressBar.PerformStep();
                }
                using (IEnumerator enumerator = list.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        str = StringType.FromObject(enumerator.Current);
                        writer.WriteLine(str);
                    }
                }
                writer.Close();
                this.Enabled = true;
                this.ProgressBar.Value = 0;
            }
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            string str = this.txtPath.Text.Trim(new char[] { ' ' });
            this.Enabled = false;
            string path = str + ".m3u";
            try
            {
                File.Create(path).Close();
                File.Delete(path);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidName"]), MsgBoxStyle.Exclamation, null);
                this.Enabled = true;
                ProjectData.ClearProjectError();
                return;
            }
            this.CreatePlaylist(path);
            this.Enabled = true;
        }

        private void btnCreateQuickLists_Click(object sender, EventArgs e)
        {
            string str2;
            string str = this.txtPath.Text.Trim(new char[] { ' ' });
            this.Enabled = false;
            if (this.chkCreateHTML.Checked)
            {
                str2 = str + ".html";
                try
                {
                    File.Create(str2).Close();
                    File.Delete(str2);
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidName"]), MsgBoxStyle.Exclamation, null);
                    this.Enabled = true;
                    ProjectData.ClearProjectError();
                    return;
                }
                switch (ID3Functions.FormatReplaceCheck(this.txtExtInfo.Text.Trim(), Declarations.FormatReplace.TAGToFilename | Declarations.FormatReplace.TAGVer2))
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
                this.CreateHTML(str2);
            }
            if (this.chkCreateCSV.Checked)
            {
                str2 = str + ".csv";
                try
                {
                    File.Create(str2).Close();
                    File.Delete(str2);
                }
                catch (Exception exception2)
                {
                    ProjectData.SetProjectError(exception2);
                    Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidName"]), MsgBoxStyle.Exclamation, null);
                    this.Enabled = true;
                    ProjectData.ClearProjectError();
                    return;
                }
                string str3 = "";
                StreamWriter writer = new StreamWriter(str2, false, Encoding.Default);
                int count = this.ColumnsList.CheckedItems.Count;
                int num = 1;
                while (num <= count)
                {
                    str3 = str3 + this.ColumnsList.CheckedItems[num - 1].Text + ";";
                    num++;
                }
                str3 = str3.TrimEnd(new char[] { ';' });
                writer.WriteLine(str3);
                foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
                {
                    str3 = "";
                    int num2 = this.ColumnsList.CheckedItems.Count;
                    for (num = 1; num <= num2; num++)
                    {
                        str3 = str3 + "\"" + this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)).Replace("\"", "_") + "\"" + ";";
                    }
                    str3 = str3.TrimEnd(new char[] { ';' });
                    writer.WriteLine(str3);
                    this.ProgressBar.PerformStep();
                }
                writer.Close();
            }
            this.Enabled = true;
            this.ProgressBar.Value = 0;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            this.ColumnsList.BeginUpdate();
            if (this.ColumnsList.SelectedItems.Count == 1)
            {
                ListViewItem item = this.ColumnsList.SelectedItems[0];
                if (item.Index == (this.ColumnsList.Items.Count - 1))
                {
                    this.ColumnsList.EndUpdate();
                }
                else
                {
                    ListViewItem item2 = (ListViewItem) item.Clone();
                    if (item.Checked)
                    {
                        item2.Checked = true;
                    }
                    else
                    {
                        item2.Checked = false;
                    }
                    this.ColumnsList.Items.Insert(item.Index + 2, item2);
                    item2.Selected = true;
                    item2.Focused = true;
                    this.ColumnsList.Focus();
                    this.ColumnsList.Items.Remove(item);
                    this.ColumnsList.EndUpdate();
                }
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            this.SaveFileDialog.InitialDirectory = this.txtPath.Text;
            this.SaveFileDialog.Filter = "All files|*.*";
            if (this.SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str = this.SaveFileDialog.FileName.Trim(new char[] { ' ' });
                this.txtPath.Text = str;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.ColumnsList.BeginUpdate();
            if (this.ColumnsList.SelectedItems.Count == 1)
            {
                ListViewItem item = this.ColumnsList.SelectedItems[0];
                if (item.Index == 0)
                {
                    this.ColumnsList.EndUpdate();
                }
                else
                {
                    ListViewItem item2 = (ListViewItem) item.Clone();
                    if (item.Checked)
                    {
                        item2.Checked = true;
                    }
                    else
                    {
                        item2.Checked = false;
                    }
                    this.ColumnsList.Items.Insert(item.Index - 1, item2);
                    item2.Selected = true;
                    item2.Focused = true;
                    this.ColumnsList.Focus();
                    this.ColumnsList.Items.Remove(item);
                    this.ColumnsList.EndUpdate();
                }
            }
        }

        private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StringType.StrCmp(this.cmbWidth.Text, "px", false) == 0)
            {
                this.txtWidth.Minimum = decimal.Zero;
                this.txtWidth.Maximum = 4096M;
                this.txtWidth.Value = 600M;
            }
            else
            {
                this.txtWidth.Value = 80M;
                this.txtWidth.Minimum = decimal.Zero;
                this.txtWidth.Maximum = 100M;
            }
        }

        private void CreateHTML(string vstrPath)
        {
            int vintNum = 0;
            HTMLList list = new HTMLList {
                TableWidth = this.txtWidth.Text + this.cmbWidth.Text
            };
            list.CreateHTMLFile(vstrPath, this.txtTitleHTML.Text + "   (created by <a href=" + "\"" + "http://www.id3-tagit.de" + "\"" + " target=_blank>ID3-TagIT </a> )");
            list.OpenGrid(this.chkGridlines.Checked);
            int count = this.ColumnsList.CheckedItems.Count;
            int num = 1;
            while (num <= count)
            {
                list.CellString((long) num, HTMLList.HTMLRowColor.HTMLRowGray, HTMLList.HTMLFontFormat.HTMLFontBold, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.ColumnsList.CheckedItems[num - 1].Text);
                num++;
            }
            foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
            {
                vintNum++;
                int num4 = this.ColumnsList.CheckedItems.Count;
                for (num = 1; num <= num4; num++)
                {
                    if (num == 1)
                    {
                        if (this.chkColor.Checked)
                        {
                            if (this.IsEven(vintNum))
                            {
                                list.CellString((long) num, HTMLList.HTMLRowColor.HTMLRowGray, HTMLList.HTMLFontFormat.HTMLFontNormal, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)));
                            }
                            else
                            {
                                list.CellString((long) num, HTMLList.HTMLRowColor.HTMLRowWhite, HTMLList.HTMLFontFormat.HTMLFontNormal, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)));
                            }
                        }
                        else
                        {
                            list.CellString((long) num, HTMLList.HTMLRowColor.HTMLRowWhite, HTMLList.HTMLFontFormat.HTMLFontNormal, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)));
                        }
                    }
                    else
                    {
                        list.CellString((long) num, HTMLList.HTMLRowColor.HTMLRowWhite, HTMLList.HTMLFontFormat.HTMLFontNormal, HTMLList.HTMLFontColor.HTMLFontBlack, HTMLList.HTMLAlignment.HTMLLeftJustify, BooleanType.FromObject(Interaction.IIf(num == this.ColumnsList.CheckedItems.Count, true, false)), this.GetQuickData(item, ByteType.FromObject(this.ColumnsList.CheckedItems[num - 1].Tag)));
                    }
                }
                this.ProgressBar.PerformStep();
            }
            list.CloseGrid();
            list.FinishHTMLFile();
            this.ProgressBar.Value = 0;
        }

        private void CreatePlaylist(string vstrPath)
        {
            StreamWriter writer = new StreamWriter(vstrPath, false, Encoding.Default);
            string vstrBaseDir = vstrPath.Substring(0, vstrPath.LastIndexOf(@"\"));
            writer.WriteLine("#EXTM3U");
            foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
            {
                string str;
                MP3 tag = (MP3) item.Tag;
                string sLeft = "";
                if (tag.V2TAG.TAGHeaderPresent)
                {
                    sLeft = ID3Functions.FormatReplacedByTag(tag, this.txtExtInfo.Text.Trim(), 2);
                }
                else if (tag.V1TAG.TAGPresent)
                {
                    sLeft = ID3Functions.FormatReplacedByTag(tag, this.txtExtInfo.Text.Trim(), 1);
                }
                sLeft = sLeft.Trim();
                if (StringType.StrCmp(sLeft, "", false) != 0)
                {
                    str = "#EXTINF:" + StringType.FromInteger(tag.Duration) + "," + sLeft;
                }
                else
                {
                    str = "#EXTINF:" + StringType.FromInteger(tag.Duration);
                }
                writer.WriteLine(str);
                if (!this.chkRelativ.Checked)
                {
                    writer.WriteLine(tag.FI.FullName);
                }
                else
                {
                    writer.WriteLine(Main.GetRelativePath(vstrBaseDir, tag.FI.FullName));
                }
                this.ProgressBar.PerformStep();
            }
            writer.Flush();
            writer.Close();
            this.ProgressBar.Value = 0;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmLists_Load(object sender, EventArgs e)
        {
            Form objForm = this;
            Declarations.objResources.ResourcesToForm(ref objForm);
            objForm = this;
            Main.RestoreFormSettings(ref objForm);
            objForm = this;
            Main.WindowsXPCheck(ref objForm);
            this.chkRelativ.Checked = Declarations.objSettings.PlaylistRelPath;
            this.txtExtInfo.Text = Declarations.objSettings.ListExtInfo;
            this.txtPath.Text = Declarations.objSettings.ListPath;
            this.txtTitleHTML.Text = Declarations.objSettings.HTMLListTitle;
            this.txtWidth.Text = Declarations.objSettings.HTMLListWidth;
            this.cmbWidth.Text = Declarations.objSettings.HTMLListWidthUnit;
            this.chkGridlines.Checked = Declarations.objSettings.HTMLGridlines;
            this.chkColor.Checked = Declarations.objSettings.HTMLColored;
            if (Declarations.objSettings.HTMLTAGVersion == 2)
            {
                this.optID3V2.Checked = true;
            }
            else
            {
                this.optID3V2.Checked = false;
            }
            if ((Declarations.objSettings.ListStyle & 1) == 1)
            {
                this.chkCreateHTML.Checked = true;
            }
            if ((Declarations.objSettings.ListStyle & 2) == 2)
            {
                this.chkCreateCSV.Checked = true;
            }
            string str = Declarations.objSettings.ListColumns + "-";
            foreach (ListViewItem item in this.ColumnsList.Items)
            {
                if (str.IndexOf(item.Tag.ToString() + "-") > -1)
                {
                    item.Checked = true;
                }
            }
            foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
            {
                if (StringType.StrCmp(this.vstrComparePath, "*", false) == 0)
                {
                    this.vstrComparePath = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "FI", new object[0], null, null), null, "DirectoryName", new object[0], null, null));
                }
                if (ObjectType.ObjTst(this.vstrComparePath, LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "FI", new object[0], null, null), null, "DirectoryName", new object[0], null, null), false) != 0)
                {
                    this.vstrComparePath = "*";
                    break;
                }
            }
            if (StringType.StrCmp(this.vstrComparePath, "*", false) != 0)
            {
                this.txtPath.Text = this.vstrComparePath + this.vstrComparePath.Substring(this.vstrComparePath.LastIndexOf(@"\"));
            }
            DirectoryInfo info = new DirectoryInfo(this.vstrTemplatesPath);
            foreach (FileInfo info2 in info.GetFiles("*.itl"))
            {
                this.TemplatesList.Items.Add(info2.Name);
            }
            this.ProgressBar.Maximum = this.MainForm.MP3View.SelectedItems.Count;
            this.AddToolTips();
        }

        private string GetQuickData(ListViewItem lstItem, byte colID)
        {
            MP3 tag = (MP3) lstItem.Tag;
            switch (colID)
            {
                case 1:
                    return tag.CurrentName;

                case 2:
                    return StringType.FromObject(Interaction.IIf(Declarations.objSettings.CurrentPath.EndsWith(":"), tag.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath + @"\", ""), tag.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath, "")));

                case 3:
                    return tag.V1TAG.TAGVersion.ToString().Replace("0", "-").Replace("1-", "1.0").Replace("11", "1.1");

                case 4:
                    return tag.V2TAG.TAGVersion.ToString().Replace("2", "2.2").Replace("3", "2.3").Replace("4", "2.4").Replace("0", "-");

                case 5:
                    if (!this.optID3V2.Checked)
                    {
                        return tag.V1TAG.Artist;
                    }
                    if (!tag.V2TAG.FrameExists("TPE1"))
                    {
                        break;
                    }
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPE1")), null, "Content", new object[0], null, null));

                case 6:
                    if (!this.optID3V2.Checked)
                    {
                        return tag.V1TAG.Title;
                    }
                    if (!tag.V2TAG.FrameExists("TIT2"))
                    {
                        break;
                    }
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TIT2")), null, "Content", new object[0], null, null));

                case 7:
                    if (!this.optID3V2.Checked)
                    {
                        return tag.V1TAG.Album;
                    }
                    if (!tag.V2TAG.FrameExists("TALB"))
                    {
                        break;
                    }
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TALB")), null, "Content", new object[0], null, null));

                case 8:
                    if (!this.optID3V2.Checked)
                    {
                        return tag.V1TAG.Tracknumber.ToString();
                    }
                    if (!tag.V2TAG.FrameExists("TRCK"))
                    {
                        break;
                    }
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TRCK")), null, "Content", new object[0], null, null));

                case 9:
                    if (!this.optID3V2.Checked || !tag.V2TAG.FrameExists("TPOS"))
                    {
                        break;
                    }
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPOS")), null, "Content", new object[0], null, null));

                case 10:
                    if (!this.optID3V2.Checked)
                    {
                        return tag.V1TAG.Comment;
                    }
                    if (tag.V2TAG.FrameExists("COMM"))
                    {
                        using (IEnumerator enumerator2 = tag.V2TAG.GetFrames("COMM").GetEnumerator())
                        {
                            while (enumerator2.MoveNext())
                            {
                                return LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator2.Current), null, "Content", new object[0], null, null).ToString();
                            }
                        }
                    }
                    break;

                case 11:
                    if (!this.optID3V2.Checked)
                    {
                        return tag.V1TAG.GenreText;
                    }
                    if (!tag.V2TAG.FrameExists("TCON"))
                    {
                        break;
                    }
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCON")), null, "Content", new object[0], null, null));

                case 12:
                    if (!this.optID3V2.Checked)
                    {
                        return tag.V1TAG.Year.ToString();
                    }
                    if (!tag.V2TAG.FrameExists("TYER"))
                    {
                        if (tag.V2TAG.FrameExists("TDRC"))
                        {
                            object objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TDRC"));
                            try
                            {
                                return StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "SubString", new object[] { 0, 4 }, null, null));
                            }
                            catch (Exception exception1)
                            {
                                ProjectData.SetProjectError(exception1);
                                ProjectData.ClearProjectError();
                            }
                        }
                        break;
                    }
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TYER")), null, "Content", new object[0], null, null));

                case 13:
                    if (this.optID3V2.Checked && tag.V2TAG.FrameExists("POPM"))
                    {
                        using (IEnumerator enumerator = tag.V2TAG.GetFrames("POPM").GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                return LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator.Current), null, "Rating", new object[0], null, null).ToString();
                            }
                        }
                    }
                    break;

                case 14:
                    return tag.DurationFormated;

                case 15:
                    return StringType.FromInteger(tag.Bitrate);

                case 0x10:
                    return StringType.FromObject(Interaction.IIf(tag.VBR, "VBR", "CBR"));

                case 0x11:
                    return StringType.FromInteger(tag.Samplerate);

                case 0x12:
                    return tag.ChannelText;

                case 0x13:
                    return (tag.VersionText + " " + tag.LayerText);

                case 20:
                    return tag.FI.LastWriteTime.ToString();

                case 0x15:
                    if (!this.optID3V2.Checked || !tag.V2TAG.FrameExists("TCOM"))
                    {
                        break;
                    }
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCOM")), null, "Content", new object[0], null, null));

                case 0x16:
                {
                    long num2 = tag.FI.Length / 0x400L;
                    return num2.ToString();
                }
                case 0x17:
                {
                    if (!this.optID3V2.Checked || !tag.V2TAG.FrameExists("TBPM"))
                    {
                        break;
                    }
                    string inputStr = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TBPM"), null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null));
                    if (inputStr.Length < 4)
                    {
                        return Conversion.Val(inputStr).ToString();
                    }
                    double num = Conversion.Val(inputStr) / 100.0;
                    return num.ToString();
                }
            }
            return "";
        }

        private string GetTempData(ListViewItem lstItem, string vstrVar, [Optional, DefaultParameterValue("")] string vstrPath)
        {
            MP3 tag = (MP3) lstItem.Tag;
            string sLeft = vstrVar;
            if (StringType.StrCmp(sLeft, "%Filename%", false) == 0)
            {
                return tag.CurrentName;
            }
            if (StringType.StrCmp(sLeft, "%FullFilename%", false) == 0)
            {
                return tag.CurrentFullName;
            }
            if (StringType.StrCmp(sLeft, "%Subdirectory%", false) == 0)
            {
                return StringType.FromObject(Interaction.IIf(Declarations.objSettings.CurrentPath.EndsWith(":"), tag.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath + @"\", ""), tag.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath, "")));
            }
            if (StringType.StrCmp(sLeft, "%Ver1%", false) == 0)
            {
                return tag.V1TAG.TAGVersion.ToString().Replace("0", "-").Replace("1-", "1.0").Replace("11", "1.1");
            }
            if (StringType.StrCmp(sLeft, "%Ver2%", false) == 0)
            {
                return tag.V2TAG.TAGVersion.ToString().Replace("2", "2.2").Replace("3", "2.3").Replace("4", "2.4").Replace("0", "-");
            }
            if (StringType.StrCmp(sLeft, "%Artist%", false) == 0)
            {
                if (!this.optID3V2.Checked)
                {
                    return tag.V1TAG.Artist;
                }
                if (tag.V2TAG.FrameExists("TPE1"))
                {
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPE1")), null, "Content", new object[0], null, null));
                }
            }
            else if (StringType.StrCmp(sLeft, "%Title%", false) == 0)
            {
                if (!this.optID3V2.Checked)
                {
                    return tag.V1TAG.Title;
                }
                if (tag.V2TAG.FrameExists("TIT2"))
                {
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TIT2")), null, "Content", new object[0], null, null));
                }
            }
            else if (StringType.StrCmp(sLeft, "%Album%", false) == 0)
            {
                if (!this.optID3V2.Checked)
                {
                    return tag.V1TAG.Album;
                }
                if (tag.V2TAG.FrameExists("TALB"))
                {
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TALB")), null, "Content", new object[0], null, null));
                }
            }
            else if (StringType.StrCmp(sLeft, "%Track%", false) == 0)
            {
                if (!this.optID3V2.Checked)
                {
                    return tag.V1TAG.Tracknumber.ToString();
                }
                if (tag.V2TAG.FrameExists("TRCK"))
                {
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TRCK")), null, "Content", new object[0], null, null));
                }
            }
            else if (StringType.StrCmp(sLeft, "%Position%", false) == 0)
            {
                if (this.optID3V2.Checked && tag.V2TAG.FrameExists("TPOS"))
                {
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TPOS")), null, "Content", new object[0], null, null));
                }
            }
            else if (StringType.StrCmp(sLeft, "%Comment%", false) == 0)
            {
                if (!this.optID3V2.Checked)
                {
                    return tag.V1TAG.Comment;
                }
                if (tag.V2TAG.FrameExists("COMM"))
                {
                    using (IEnumerator enumerator2 = tag.V2TAG.GetFrames("COMM").GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            return LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator2.Current), null, "Content", new object[0], null, null).ToString();
                        }
                    }
                }
            }
            else if (StringType.StrCmp(sLeft, "%Genre%", false) == 0)
            {
                if (!this.optID3V2.Checked)
                {
                    return tag.V1TAG.GenreText;
                }
                if (tag.V2TAG.FrameExists("TCON"))
                {
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCON")), null, "Content", new object[0], null, null));
                }
            }
            else if (StringType.StrCmp(sLeft, "%Year%", false) == 0)
            {
                if (!this.optID3V2.Checked)
                {
                    return tag.V1TAG.Year.ToString();
                }
                if (tag.V2TAG.FrameExists("TYER"))
                {
                    return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TYER")), null, "Content", new object[0], null, null));
                }
                if (tag.V2TAG.FrameExists("TDRC"))
                {
                    object objectValue = RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TDRC"));
                    try
                    {
                        return StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "SubString", new object[] { 0, 4 }, null, null));
                    }
                    catch (Exception exception1)
                    {
                        ProjectData.SetProjectError(exception1);
                        ProjectData.ClearProjectError();
                    }
                }
            }
            else if (StringType.StrCmp(sLeft, "%Rating%", false) == 0)
            {
                if (this.optID3V2.Checked && tag.V2TAG.FrameExists("POPM"))
                {
                    using (IEnumerator enumerator = tag.V2TAG.GetFrames("POPM").GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            return LateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator.Current), null, "Rating", new object[0], null, null).ToString();
                        }
                    }
                }
            }
            else
            {
                if (StringType.StrCmp(sLeft, "%Duration%", false) == 0)
                {
                    return tag.DurationFormated;
                }
                if (StringType.StrCmp(sLeft, "%DurationSec%", false) == 0)
                {
                    return tag.Duration.ToString();
                }
                if (StringType.StrCmp(sLeft, "%Bitrate%", false) == 0)
                {
                    return tag.Bitrate.ToString();
                }
                if (StringType.StrCmp(sLeft, "%CBRVBR%", false) == 0)
                {
                    return StringType.FromObject(Interaction.IIf(tag.VBR, "VBR", "CBR"));
                }
                if (StringType.StrCmp(sLeft, "%Samplerate%", false) == 0)
                {
                    return tag.Samplerate.ToString();
                }
                if (StringType.StrCmp(sLeft, "%Channel%", false) == 0)
                {
                    return tag.ChannelText;
                }
                if (StringType.StrCmp(sLeft, "%Version%", false) == 0)
                {
                    return (tag.VersionText + " " + tag.LayerText);
                }
                if (StringType.StrCmp(sLeft, "%LastChanged%", false) == 0)
                {
                    return tag.FI.LastWriteTime.ToString();
                }
                if (StringType.StrCmp(sLeft, "%Composer%", false) == 0)
                {
                    if (this.optID3V2.Checked && tag.V2TAG.FrameExists("TCOM"))
                    {
                        return StringType.FromObject(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TCOM")), null, "Content", new object[0], null, null));
                    }
                }
                else
                {
                    if (StringType.StrCmp(sLeft, "%FileSize%", false) == 0)
                    {
                        long num2 = tag.FI.Length / 0x400L;
                        return num2.ToString();
                    }
                    if (StringType.StrCmp(sLeft, "%BPM%", false) == 0)
                    {
                        if (this.optID3V2.Checked && tag.V2TAG.FrameExists("TBPM"))
                        {
                            string inputStr = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TBPM"), null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null));
                            if (inputStr.Length >= 4)
                            {
                                double num = Conversion.Val(inputStr) / 100.0;
                                return num.ToString();
                            }
                            return Conversion.Val(inputStr).ToString();
                        }
                    }
                    else
                    {
                        if (StringType.StrCmp(sLeft, "%RelFilename%", false) == 0)
                        {
                            return Main.GetRelativePath(vstrPath.Substring(0, vstrPath.LastIndexOf(@"\")), tag.FI.FullName);
                        }
                        if (StringType.StrCmp(sLeft, "%CRC%", false) == 0)
                        {
                            if (tag.AudioCheckSum == 0)
                            {
                                tag.CalcAudioCheckSum();
                            }
                            if (tag.AudioCheckSum != 0)
                            {
                                return tag.AudioCheckSum.ToString();
                            }
                            return "";
                        }
                    }
                }
            }
            return "";
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
            this.btnClose = new Button();
            this.btnPath = new Button();
            this.txtPath = new TextBox();
            this.lblPath = new Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ButtomPanel = new PanelEx();
            this.TopPanel = new PanelEx();
            this.DotNetBarManager1 = new DotNetBarManager(this.components);
            this.barBottomDockSite = new DockSite();
            this.barLeftDockSite = new DockSite();
            this.barRightDockSite = new DockSite();
            this.barTopDockSite = new DockSite();
            this.TabControl1 = new DevComponents.DotNetBar.TabControl();
            this.TabControlPanel1 = new TabControlPanel();
            this.btnCreatePlaylist = new Button();
            this.lblInfo1 = new Label();
            this.framePara = new GroupBox();
            this.L7 = new Label();
            this.L6 = new Label();
            this.L5 = new Label();
            this.L4 = new Label();
            this.L3 = new Label();
            this.L2 = new Label();
            this.L1 = new Label();
            this.chkRelativ = new CheckBox();
            this.txtExtInfo = new TextBox();
            this.lblPlaylist = new Label();
            this.tabPlaylist = new TabItem(this.components);
            this.TabControlPanel2 = new TabControlPanel();
            this.TemplatesList = new ListBox();
            this.lblInfo2 = new Label();
            this.btnCreateFromTemp = new Button();
            this.tabTemp = new TabItem(this.components);
            this.TabControlPanel3 = new TabControlPanel();
            this.lblInfo3 = new Label();
            this.chkCreateHTML = new CheckBox();
            this.chkCreateCSV = new CheckBox();
            this.frameOptions = new GroupBox();
            this.chkColor = new CheckBox();
            this.chkGridlines = new CheckBox();
            this.txtWidth = new NumericUpDown();
            this.cmbWidth = new ComboBox();
            this.lblListWidth = new Label();
            this.lblTitleHTML = new Label();
            this.frameTAGInfo = new GroupBox();
            this.optID3V1 = new RadioButton();
            this.optID3V2 = new RadioButton();
            this.txtTitleHTML = new TextBox();
            this.frameColumns = new GroupBox();
            this.ColumnsList = new ListView();
            this.btnUp = new Button();
            this.btnDown = new Button();
            this.btnCreateQuickLists = new Button();
            this.tabFilelist = new TabItem(this.components);
            this.ButtomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((ISupportInitialize) this.TabControl1).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabControlPanel1.SuspendLayout();
            this.framePara.SuspendLayout();
            this.TabControlPanel2.SuspendLayout();
            this.TabControlPanel3.SuspendLayout();
            this.frameOptions.SuspendLayout();
            this.txtWidth.BeginInit();
            this.frameTAGInfo.SuspendLayout();
            this.frameColumns.SuspendLayout();
            this.SuspendLayout();
            this.btnClose.BackColor = SystemColors.Control;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = ImeMode.NoControl;
            Point point = new Point(440, 8);
            this.btnClose.Location = point;
            this.btnClose.Name = "btnClose";
            Size size = new Size(160, 0x18);
            this.btnClose.Size = size;
            this.btnClose.TabIndex = 0x10;
            this.btnClose.Text = "&Close";
            this.btnPath.BackColor = SystemColors.Control;
            this.btnPath.ImeMode = ImeMode.NoControl;
            point = new Point(0x1c0, 30);
            this.btnPath.Location = point;
            this.btnPath.Name = "btnPath";
            size = new Size(0x98, 0x18);
            this.btnPath.Size = size;
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "&Select filename ...";
            point = new Point(8, 0x20);
            this.txtPath.Location = point;
            this.txtPath.MaxLength = 0xff;
            this.txtPath.Name = "txtPath";
            size = new Size(0x1b0, 20);
            this.txtPath.Size = size;
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "";
            this.lblPath.BackColor = Color.White;
            this.lblPath.ForeColor = Color.Black;
            this.lblPath.ImeMode = ImeMode.NoControl;
            point = new Point(8, 8);
            this.lblPath.Location = point;
            this.lblPath.Name = "lblPath";
            size = new Size(320, 0x10);
            this.lblPath.Size = size;
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "&Path and Filename of the list(s) (without extension): ";
            this.SaveFileDialog.Title = "Select the path and filename for the list";
            this.ProgressBar.BackColor = SystemColors.Control;
            this.ProgressBar.ImeMode = ImeMode.NoControl;
            point = new Point(8, 12);
            this.ProgressBar.Location = point;
            this.ProgressBar.Name = "ProgressBar";
            size = new Size(0x1a8, 0x10);
            this.ProgressBar.Size = size;
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 0x11;
            this.ButtomPanel.AntiAlias = true;
            this.ButtomPanel.Controls.Add(this.btnClose);
            this.ButtomPanel.Controls.Add(this.ProgressBar);
            this.ButtomPanel.Dock = DockStyle.Bottom;
            point = new Point(0, 0x1d0);
            this.ButtomPanel.Location = point;
            this.ButtomPanel.Name = "ButtomPanel";
            size = new Size(610, 40);
            this.ButtomPanel.Size = size;
            this.ButtomPanel.Style.BackColor1.Color = Color.White;
            this.ButtomPanel.Style.BackColor2.Color = Color.White;
            this.ButtomPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
            this.ButtomPanel.Style.BorderWidth = 0;
            this.ButtomPanel.Style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ButtomPanel.Style.ForeColor.Color = Color.Black;
            this.ButtomPanel.Style.GradientAngle = 90;
            this.ButtomPanel.Style.LineAlignment = StringAlignment.Near;
            this.ButtomPanel.Style.MarginBottom = 2;
            this.ButtomPanel.Style.MarginLeft = 7;
            this.ButtomPanel.Style.MarginRight = 2;
            this.ButtomPanel.Style.MarginTop = 2;
            this.ButtomPanel.TabIndex = 0x77;
            this.TopPanel.AntiAlias = true;
            this.TopPanel.Controls.Add(this.btnPath);
            this.TopPanel.Controls.Add(this.txtPath);
            this.TopPanel.Controls.Add(this.lblPath);
            this.TopPanel.Dock = DockStyle.Top;
            point = new Point(0, 0);
            this.TopPanel.Location = point;
            this.TopPanel.Name = "TopPanel";
            size = new Size(610, 0x40);
            this.TopPanel.Size = size;
            this.TopPanel.Style.BackColor1.Color = Color.White;
            this.TopPanel.Style.BackColor2.Color = Color.White;
            this.TopPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
            this.TopPanel.Style.BorderWidth = 0;
            this.TopPanel.Style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TopPanel.Style.ForeColor.Color = Color.Black;
            this.TopPanel.Style.GradientAngle = 90;
            this.TopPanel.Style.LineAlignment = StringAlignment.Near;
            this.TopPanel.Style.MarginBottom = 2;
            this.TopPanel.Style.MarginLeft = 7;
            this.TopPanel.Style.MarginRight = 2;
            this.TopPanel.Style.MarginTop = 2;
            this.TopPanel.TabIndex = 120;
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(eShortcut.F1);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(eShortcut.CtrlC);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(eShortcut.CtrlA);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(eShortcut.CtrlV);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(eShortcut.CtrlX);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(eShortcut.CtrlZ);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(eShortcut.Del);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(eShortcut.Ins);
            this.DotNetBarManager1.BottomDockSite = this.barBottomDockSite;
            this.DotNetBarManager1.DefinitionName = "";
            this.DotNetBarManager1.LeftDockSite = this.barLeftDockSite;
            this.DotNetBarManager1.ParentForm = this;
            this.DotNetBarManager1.RightDockSite = this.barRightDockSite;
            this.DotNetBarManager1.Style = eDotNetBarStyle.Office2003;
            this.DotNetBarManager1.TopDockSite = this.barTopDockSite;
            this.barBottomDockSite.AccessibleRole = AccessibleRole.Window;
            this.barBottomDockSite.BackgroundImageAlpha = 0xff;
            this.barBottomDockSite.Dock = DockStyle.Bottom;
            point = new Point(0, 0x1f8);
            this.barBottomDockSite.Location = point;
            this.barBottomDockSite.Name = "barBottomDockSite";
            size = new Size(610, 0);
            this.barBottomDockSite.Size = size;
            this.barBottomDockSite.TabIndex = 0x7c;
            this.barBottomDockSite.TabStop = false;
            this.barLeftDockSite.AccessibleRole = AccessibleRole.Window;
            this.barLeftDockSite.BackgroundImageAlpha = 0xff;
            this.barLeftDockSite.Dock = DockStyle.Left;
            point = new Point(0, 0);
            this.barLeftDockSite.Location = point;
            this.barLeftDockSite.Name = "barLeftDockSite";
            size = new Size(0, 0x1f8);
            this.barLeftDockSite.Size = size;
            this.barLeftDockSite.TabIndex = 0x79;
            this.barLeftDockSite.TabStop = false;
            this.barRightDockSite.AccessibleRole = AccessibleRole.Window;
            this.barRightDockSite.BackgroundImageAlpha = 0xff;
            this.barRightDockSite.Dock = DockStyle.Right;
            point = new Point(610, 0);
            this.barRightDockSite.Location = point;
            this.barRightDockSite.Name = "barRightDockSite";
            size = new Size(0, 0x1f8);
            this.barRightDockSite.Size = size;
            this.barRightDockSite.TabIndex = 0x7a;
            this.barRightDockSite.TabStop = false;
            this.barTopDockSite.AccessibleRole = AccessibleRole.Window;
            this.barTopDockSite.BackgroundImageAlpha = 0xff;
            this.barTopDockSite.Dock = DockStyle.Top;
            point = new Point(0, 0);
            this.barTopDockSite.Location = point;
            this.barTopDockSite.Name = "barTopDockSite";
            size = new Size(610, 0);
            this.barTopDockSite.Size = size;
            this.barTopDockSite.TabIndex = 0x7b;
            this.barTopDockSite.TabStop = false;
            this.TabControl1.CanReorderTabs = true;
            this.TabControl1.Controls.Add(this.TabControlPanel1);
            this.TabControl1.Controls.Add(this.TabControlPanel2);
            this.TabControl1.Controls.Add(this.TabControlPanel3);
            this.TabControl1.Dock = DockStyle.Fill;
            point = new Point(0, 0x40);
            this.TabControl1.Location = point;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            this.TabControl1.SelectedTabIndex = 0;
            size = new Size(610, 400);
            this.TabControl1.Size = size;
            this.TabControl1.Style = eTabStripStyle.VS2005Document;
            this.TabControl1.TabIndex = 0x7d;
            this.TabControl1.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
            this.TabControl1.Tabs.Add(this.tabPlaylist);
            this.TabControl1.Tabs.Add(this.tabTemp);
            this.TabControl1.Tabs.Add(this.tabFilelist);
            this.TabControlPanel1.AntiAlias = true;
            this.TabControlPanel1.Controls.Add(this.btnCreatePlaylist);
            this.TabControlPanel1.Controls.Add(this.lblInfo1);
            this.TabControlPanel1.Controls.Add(this.framePara);
            this.TabControlPanel1.Controls.Add(this.chkRelativ);
            this.TabControlPanel1.Controls.Add(this.txtExtInfo);
            this.TabControlPanel1.Controls.Add(this.lblPlaylist);
            this.TabControlPanel1.Dock = DockStyle.Fill;
            this.TabControlPanel1.DockPadding.All = 1;
            point = new Point(0, 0x1a);
            this.TabControlPanel1.Location = point;
            this.TabControlPanel1.Name = "TabControlPanel1";
            size = new Size(610, 0x176);
            this.TabControlPanel1.Size = size;
            this.TabControlPanel1.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
            this.TabControlPanel1.Style.Border = eBorderType.SingleLine;
            this.TabControlPanel1.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
            this.TabControlPanel1.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
            this.TabControlPanel1.Style.GradientAngle = 90;
            this.TabControlPanel1.TabIndex = 1;
            this.TabControlPanel1.TabItem = this.tabPlaylist;
            this.btnCreatePlaylist.BackColor = SystemColors.Control;
            this.btnCreatePlaylist.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x157);
            this.btnCreatePlaylist.Location = point;
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            size = new Size(0x250, 0x18);
            this.btnCreatePlaylist.Size = size;
            this.btnCreatePlaylist.TabIndex = 11;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.lblInfo1.BackColor = Color.Transparent;
            this.lblInfo1.BorderStyle = BorderStyle.Fixed3D;
            this.lblInfo1.ImeMode = ImeMode.NoControl;
            point = new Point(0x1d8, 0x18);
            this.lblInfo1.Location = point;
            this.lblInfo1.Name = "lblInfo1";
            size = new Size(0x80, 0x80);
            this.lblInfo1.Size = size;
            this.lblInfo1.TabIndex = 9;
            this.lblInfo1.Text = "M3U playlists can include some extended information with the format above you can choose which information should be put into the playlist.";
            this.lblInfo1.TextAlign = ContentAlignment.MiddleCenter;
            this.framePara.BackColor = Color.Transparent;
            this.framePara.Controls.Add(this.L7);
            this.framePara.Controls.Add(this.L6);
            this.framePara.Controls.Add(this.L5);
            this.framePara.Controls.Add(this.L4);
            this.framePara.Controls.Add(this.L3);
            this.framePara.Controls.Add(this.L2);
            this.framePara.Controls.Add(this.L1);
            point = new Point(0x10, 0x38);
            this.framePara.Location = point;
            this.framePara.Name = "framePara";
            size = new Size(440, 0x60);
            this.framePara.Size = size;
            this.framePara.TabIndex = 8;
            this.framePara.TabStop = false;
            this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
            this.L7.BackColor = Color.Transparent;
            this.L7.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x48);
            this.L7.Location = point;
            this.L7.Name = "L7";
            size = new Size(160, 0x10);
            this.L7.Size = size;
            this.L7.TabIndex = 6;
            this.L7.Text = "<K> = Track number";
            this.L6.BackColor = Color.Transparent;
            this.L6.ImeMode = ImeMode.NoControl;
            point = new Point(0xc0, 40);
            this.L6.Location = point;
            this.L6.Name = "L6";
            size = new Size(160, 0x10);
            this.L6.Size = size;
            this.L6.TabIndex = 5;
            this.L6.Text = "<G> = Genre";
            this.L5.BackColor = Color.Transparent;
            this.L5.ImeMode = ImeMode.NoControl;
            point = new Point(0xc0, 0x38);
            this.L5.Location = point;
            this.L5.Name = "L5";
            size = new Size(160, 0x10);
            this.L5.Size = size;
            this.L5.TabIndex = 4;
            this.L5.Text = "<Y> = Year";
            this.L4.BackColor = Color.Transparent;
            this.L4.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x38);
            this.L4.Location = point;
            this.L4.Name = "L4";
            size = new Size(160, 0x10);
            this.L4.Size = size;
            this.L4.TabIndex = 3;
            this.L4.Text = "<C> = Comment";
            this.L3.BackColor = Color.Transparent;
            this.L3.ImeMode = ImeMode.NoControl;
            point = new Point(8, 40);
            this.L3.Location = point;
            this.L3.Name = "L3";
            size = new Size(160, 0x10);
            this.L3.Size = size;
            this.L3.TabIndex = 2;
            this.L3.Text = "<B> = Album";
            this.L2.BackColor = Color.Transparent;
            this.L2.ImeMode = ImeMode.NoControl;
            point = new Point(0xc0, 0x18);
            this.L2.Location = point;
            this.L2.Name = "L2";
            size = new Size(160, 0x10);
            this.L2.Size = size;
            this.L2.TabIndex = 1;
            this.L2.Text = "<T> = Title";
            this.L1.BackColor = Color.Transparent;
            this.L1.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x18);
            this.L1.Location = point;
            this.L1.Name = "L1";
            size = new Size(160, 0x10);
            this.L1.Size = size;
            this.L1.TabIndex = 0;
            this.L1.Text = "<A> = Artist";
            this.chkRelativ.BackColor = Color.Transparent;
            this.chkRelativ.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0xa8);
            this.chkRelativ.Location = point;
            this.chkRelativ.Name = "chkRelativ";
            size = new Size(0x248, 0x10);
            this.chkRelativ.Size = size;
            this.chkRelativ.TabIndex = 10;
            this.chkRelativ.Text = "Use &relative paths in playlist";
            point = new Point(0x10, 0x18);
            this.txtExtInfo.Location = point;
            this.txtExtInfo.Name = "txtExtInfo";
            size = new Size(440, 20);
            this.txtExtInfo.Size = size;
            this.txtExtInfo.TabIndex = 7;
            this.txtExtInfo.Text = "";
            this.lblPlaylist.BackColor = Color.Transparent;
            this.lblPlaylist.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 8);
            this.lblPlaylist.Location = point;
            this.lblPlaylist.Name = "lblPlaylist";
            size = new Size(320, 0x10);
            this.lblPlaylist.Size = size;
            this.lblPlaylist.TabIndex = 6;
            this.lblPlaylist.Text = "Format of extended playlist info:";
            this.tabPlaylist.AttachedControl = this.TabControlPanel1;
            this.tabPlaylist.Name = "tabPlaylist";
            this.tabPlaylist.Text = "M3U Playlist";
            this.TabControlPanel2.AntiAlias = true;
            this.TabControlPanel2.Controls.Add(this.TemplatesList);
            this.TabControlPanel2.Controls.Add(this.lblInfo2);
            this.TabControlPanel2.Controls.Add(this.btnCreateFromTemp);
            this.TabControlPanel2.Dock = DockStyle.Fill;
            this.TabControlPanel2.DockPadding.All = 1;
            point = new Point(0, 0x1a);
            this.TabControlPanel2.Location = point;
            this.TabControlPanel2.Name = "TabControlPanel2";
            size = new Size(610, 0x176);
            this.TabControlPanel2.Size = size;
            this.TabControlPanel2.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
            this.TabControlPanel2.Style.Border = eBorderType.SingleLine;
            this.TabControlPanel2.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
            this.TabControlPanel2.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
            this.TabControlPanel2.Style.GradientAngle = 90;
            this.TabControlPanel2.TabIndex = 2;
            this.TabControlPanel2.TabItem = this.tabTemp;
            point = new Point(8, 0x48);
            this.TemplatesList.Location = point;
            this.TemplatesList.Name = "TemplatesList";
            size = new Size(240, 0x108);
            this.TemplatesList.Size = size;
            this.TemplatesList.Sorted = true;
            this.TemplatesList.TabIndex = 0x1b;
            this.lblInfo2.BackColor = Color.Transparent;
            this.lblInfo2.BorderStyle = BorderStyle.Fixed3D;
            this.lblInfo2.ImeMode = ImeMode.NoControl;
            point = new Point(8, 8);
            this.lblInfo2.Location = point;
            this.lblInfo2.Name = "lblInfo2";
            size = new Size(0x250, 0x38);
            this.lblInfo2.Size = size;
            this.lblInfo2.TabIndex = 0x1a;
            this.lblInfo2.Text = "This functions makes it possible to create a filelist in a user defined format which is defined by a template. The templates listed below can be found and edited in the ID3-TagIT installation folder under Templates. There you will also find a textfile with all necessary instructions to edit or create templates.";
            this.lblInfo2.TextAlign = ContentAlignment.MiddleCenter;
            this.btnCreateFromTemp.BackColor = SystemColors.Control;
            this.btnCreateFromTemp.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x157);
            this.btnCreateFromTemp.Location = point;
            this.btnCreateFromTemp.Name = "btnCreateFromTemp";
            size = new Size(0x250, 0x18);
            this.btnCreateFromTemp.Size = size;
            this.btnCreateFromTemp.TabIndex = 0x19;
            this.btnCreateFromTemp.Text = "Create from template";
            this.tabTemp.AttachedControl = this.TabControlPanel2;
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Text = "Filelist from template";
            this.TabControlPanel3.AntiAlias = true;
            this.TabControlPanel3.Controls.Add(this.lblInfo3);
            this.TabControlPanel3.Controls.Add(this.chkCreateHTML);
            this.TabControlPanel3.Controls.Add(this.chkCreateCSV);
            this.TabControlPanel3.Controls.Add(this.frameOptions);
            this.TabControlPanel3.Controls.Add(this.lblTitleHTML);
            this.TabControlPanel3.Controls.Add(this.frameTAGInfo);
            this.TabControlPanel3.Controls.Add(this.txtTitleHTML);
            this.TabControlPanel3.Controls.Add(this.frameColumns);
            this.TabControlPanel3.Controls.Add(this.btnCreateQuickLists);
            this.TabControlPanel3.Dock = DockStyle.Fill;
            this.TabControlPanel3.DockPadding.All = 1;
            point = new Point(0, 0x1a);
            this.TabControlPanel3.Location = point;
            this.TabControlPanel3.Name = "TabControlPanel3";
            size = new Size(610, 0x176);
            this.TabControlPanel3.Size = size;
            this.TabControlPanel3.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
            this.TabControlPanel3.Style.Border = eBorderType.SingleLine;
            this.TabControlPanel3.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
            this.TabControlPanel3.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
            this.TabControlPanel3.Style.GradientAngle = 90;
            this.TabControlPanel3.TabIndex = 3;
            this.TabControlPanel3.TabItem = this.tabFilelist;
            this.lblInfo3.BackColor = Color.Transparent;
            this.lblInfo3.BorderStyle = BorderStyle.Fixed3D;
            this.lblInfo3.ImeMode = ImeMode.NoControl;
            point = new Point(8, 7);
            this.lblInfo3.Location = point;
            this.lblInfo3.Name = "lblInfo3";
            size = new Size(0x250, 40);
            this.lblInfo3.Size = size;
            this.lblInfo3.TabIndex = 0x1f;
            this.lblInfo3.Text = "This option allows to cretae a HTML or CSV file without a template. Select the file format(s) and choose the columns. ";
            this.lblInfo3.TextAlign = ContentAlignment.MiddleCenter;
            this.chkCreateHTML.BackColor = Color.Transparent;
            this.chkCreateHTML.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x3f);
            this.chkCreateHTML.Location = point;
            this.chkCreateHTML.Name = "chkCreateHTML";
            size = new Size(0x98, 0x10);
            this.chkCreateHTML.Size = size;
            this.chkCreateHTML.TabIndex = 0x1d;
            this.chkCreateHTML.Text = "Create HTML list";
            this.chkCreateCSV.BackColor = Color.Transparent;
            this.chkCreateCSV.ImeMode = ImeMode.NoControl;
            point = new Point(0xb0, 0x3f);
            this.chkCreateCSV.Location = point;
            this.chkCreateCSV.Name = "chkCreateCSV";
            size = new Size(0xb0, 0x10);
            this.chkCreateCSV.Size = size;
            this.chkCreateCSV.TabIndex = 30;
            this.chkCreateCSV.Text = "Create CSV list";
            this.frameOptions.BackColor = Color.Transparent;
            this.frameOptions.Controls.Add(this.chkColor);
            this.frameOptions.Controls.Add(this.chkGridlines);
            this.frameOptions.Controls.Add(this.txtWidth);
            this.frameOptions.Controls.Add(this.cmbWidth);
            this.frameOptions.Controls.Add(this.lblListWidth);
            point = new Point(0x170, 0xaf);
            this.frameOptions.Location = point;
            this.frameOptions.Name = "frameOptions";
            size = new Size(0xe8, 0x70);
            this.frameOptions.Size = size;
            this.frameOptions.TabIndex = 0x19;
            this.frameOptions.TabStop = false;
            this.frameOptions.Text = "Options (HTML-List only)";
            this.chkColor.BackColor = Color.Transparent;
            this.chkColor.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 80);
            this.chkColor.Location = point;
            this.chkColor.Name = "chkColor";
            size = new Size(0xd0, 0x10);
            this.chkColor.Size = size;
            this.chkColor.TabIndex = 13;
            this.chkColor.Text = "&Color odd and even rows";
            this.chkGridlines.BackColor = Color.Transparent;
            this.chkGridlines.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x38);
            this.chkGridlines.Location = point;
            this.chkGridlines.Name = "chkGridlines";
            size = new Size(0xd0, 0x10);
            this.chkGridlines.Size = size;
            this.chkGridlines.TabIndex = 12;
            this.chkGridlines.Text = "Show &gridlines";
            point = new Point(0x58, 0x18);
            this.txtWidth.Location = point;
            decimal num = new decimal(new int[] { 0x1000, 0, 0, 0 });
            this.txtWidth.Maximum = num;
            this.txtWidth.Name = "txtWidth";
            size = new Size(0x48, 20);
            this.txtWidth.Size = size;
            this.txtWidth.TabIndex = 10;
            this.cmbWidth.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbWidth.ItemHeight = 13;
            this.cmbWidth.Items.AddRange(new object[] { "px", "%" });
            point = new Point(0xa8, 0x18);
            this.cmbWidth.Location = point;
            this.cmbWidth.Name = "cmbWidth";
            size = new Size(0x38, 0x15);
            this.cmbWidth.Size = size;
            this.cmbWidth.TabIndex = 11;
            this.lblListWidth.BackColor = Color.Transparent;
            this.lblListWidth.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x1a);
            this.lblListWidth.Location = point;
            this.lblListWidth.Name = "lblListWidth";
            size = new Size(80, 0x10);
            this.lblListWidth.Size = size;
            this.lblListWidth.TabIndex = 9;
            this.lblListWidth.Text = "List &width";
            this.lblTitleHTML.BackColor = Color.Transparent;
            this.lblTitleHTML.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x127);
            this.lblTitleHTML.Location = point;
            this.lblTitleHTML.Name = "lblTitleHTML";
            size = new Size(0x240, 0x10);
            this.lblTitleHTML.Size = size;
            this.lblTitleHTML.TabIndex = 0x1a;
            this.lblTitleHTML.Text = "&Title of the list (HTML-List only)";
            this.frameTAGInfo.BackColor = Color.Transparent;
            this.frameTAGInfo.Controls.Add(this.optID3V1);
            this.frameTAGInfo.Controls.Add(this.optID3V2);
            point = new Point(0x170, 0x57);
            this.frameTAGInfo.Location = point;
            this.frameTAGInfo.Name = "frameTAGInfo";
            size = new Size(0xe8, 80);
            this.frameTAGInfo.Size = size;
            this.frameTAGInfo.TabIndex = 0x18;
            this.frameTAGInfo.TabStop = false;
            this.frameTAGInfo.Text = "Choose TAG Ver. for creating list";
            this.optID3V1.BackColor = Color.Transparent;
            this.optID3V1.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x18);
            this.optID3V1.Location = point;
            this.optID3V1.Name = "optID3V1";
            size = new Size(0xd0, 0x10);
            this.optID3V1.Size = size;
            this.optID3V1.TabIndex = 7;
            this.optID3V1.Text = "Use TAG Ver. &1 for creating the list";
            this.optID3V2.BackColor = Color.Transparent;
            this.optID3V2.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x30);
            this.optID3V2.Location = point;
            this.optID3V2.Name = "optID3V2";
            size = new Size(0xd0, 0x10);
            this.optID3V2.Size = size;
            this.optID3V2.TabIndex = 8;
            this.optID3V2.Text = "Use TAG Ver. &2 for creating the list";
            point = new Point(8, 0x137);
            this.txtTitleHTML.Location = point;
            this.txtTitleHTML.Name = "txtTitleHTML";
            size = new Size(0x250, 20);
            this.txtTitleHTML.Size = size;
            this.txtTitleHTML.TabIndex = 0x1b;
            this.txtTitleHTML.Text = "";
            this.frameColumns.BackColor = Color.Transparent;
            this.frameColumns.Controls.Add(this.ColumnsList);
            this.frameColumns.Controls.Add(this.btnUp);
            this.frameColumns.Controls.Add(this.btnDown);
            point = new Point(8, 0x57);
            this.frameColumns.Location = point;
            this.frameColumns.Name = "frameColumns";
            size = new Size(0x160, 200);
            this.frameColumns.Size = size;
            this.frameColumns.TabIndex = 0x17;
            this.frameColumns.TabStop = false;
            this.frameColumns.Text = "Select columns of the list";
            this.ColumnsList.CheckBoxes = true;
            this.ColumnsList.FullRowSelect = true;
            this.ColumnsList.HeaderStyle = ColumnHeaderStyle.None;
            point = new Point(8, 0x18);
            this.ColumnsList.Location = point;
            this.ColumnsList.MultiSelect = false;
            this.ColumnsList.Name = "ColumnsList";
            size = new Size(0xd8, 0xa8);
            this.ColumnsList.Size = size;
            this.ColumnsList.TabIndex = 4;
            this.ColumnsList.View = View.Details;
            this.btnUp.ImeMode = ImeMode.NoControl;
            point = new Point(0xe8, 80);
            this.btnUp.Location = point;
            this.btnUp.Name = "btnUp";
            size = new Size(0x70, 0x18);
            this.btnUp.Size = size;
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Column &up";
            this.btnDown.ImeMode = ImeMode.NoControl;
            point = new Point(0xe8, 0x70);
            this.btnDown.Location = point;
            this.btnDown.Name = "btnDown";
            size = new Size(0x70, 0x18);
            this.btnDown.Size = size;
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Column &down";
            this.btnCreateQuickLists.BackColor = Color.Transparent;
            this.btnCreateQuickLists.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x157);
            this.btnCreateQuickLists.Location = point;
            this.btnCreateQuickLists.Name = "btnCreateQuickLists";
            size = new Size(0x250, 0x18);
            this.btnCreateQuickLists.Size = size;
            this.btnCreateQuickLists.TabIndex = 0x1c;
            this.btnCreateQuickLists.Text = "Create &lists";
            this.tabFilelist.AttachedControl = this.TabControlPanel3;
            this.tabFilelist.Name = "tabFilelist";
            this.tabFilelist.Text = "Quick HTML/CSV Filelist";
            size = new Size(5, 13);
            this.AutoScaleBaseSize = size;
            size = new Size(610, 0x1f8);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ButtomPanel);
            this.Controls.Add(this.barLeftDockSite);
            this.Controls.Add(this.barRightDockSite);
            this.Controls.Add(this.barTopDockSite);
            this.Controls.Add(this.barBottomDockSite);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLists";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Create lists of selected files";
            this.ButtomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((ISupportInitialize) this.TabControl1).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabControlPanel1.ResumeLayout(false);
            this.framePara.ResumeLayout(false);
            this.TabControlPanel2.ResumeLayout(false);
            this.TabControlPanel3.ResumeLayout(false);
            this.frameOptions.ResumeLayout(false);
            this.txtWidth.EndInit();
            this.frameTAGInfo.ResumeLayout(false);
            this.frameColumns.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private bool IsEven(int vintNum)
        {
            return ((vintNum % 2) == 0);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            string selectedText = this.txtExtInfo.SelectedText;
            int selectionStart = this.txtExtInfo.SelectionStart;
            if (this.txtExtInfo.SelectionLength == 0)
            {
                this.txtExtInfo.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(this.txtExtInfo.Text.Substring(0, this.txtExtInfo.SelectionStart), LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 3 }, null, null)), this.txtExtInfo.Text.Substring(this.txtExtInfo.SelectionStart)));
                this.txtExtInfo.SelectionStart = selectionStart + 3;
            }
            else
            {
                string str2 = this.txtExtInfo.Text.Substring(0, selectionStart);
                this.txtExtInfo.Text = Strings.Replace(this.txtExtInfo.Text, selectedText, StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 3 }, null, null)), selectionStart + 1, 1, CompareMethod.Text);
                this.txtExtInfo.Text = str2 + this.txtExtInfo.Text;
                this.txtExtInfo.SelectionStart = selectionStart + 3;
            }
        }

        private void txtExtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\\':
                case '|':
                case '"':
                case ';':
                case ',':
                case '*':
                case '?':
                    e.Handled = true;
                    this.txtExtInfo.SelectionStart = this.txtExtInfo.Text.Length;
                    break;
            }
        }

        internal virtual DockSite barBottomDockSite
        {
            get
            {
                return this._barBottomDockSite;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._barBottomDockSite != null)
                {
                }
                this._barBottomDockSite = value;
                if (this._barBottomDockSite != null)
                {
                }
            }
        }

        internal virtual DockSite barLeftDockSite
        {
            get
            {
                return this._barLeftDockSite;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._barLeftDockSite != null)
                {
                }
                this._barLeftDockSite = value;
                if (this._barLeftDockSite != null)
                {
                }
            }
        }

        internal virtual DockSite barRightDockSite
        {
            get
            {
                return this._barRightDockSite;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._barRightDockSite != null)
                {
                }
                this._barRightDockSite = value;
                if (this._barRightDockSite != null)
                {
                }
            }
        }

        internal virtual DockSite barTopDockSite
        {
            get
            {
                return this._barTopDockSite;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._barTopDockSite != null)
                {
                }
                this._barTopDockSite = value;
                if (this._barTopDockSite != null)
                {
                }
            }
        }

        internal virtual Button btnClose
        {
            get
            {
                return this._btnClose;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnClose != null)
                {
                    this._btnClose.Click -= new EventHandler(this.btnClose_Click);
                }
                this._btnClose = value;
                if (this._btnClose != null)
                {
                    this._btnClose.Click += new EventHandler(this.btnClose_Click);
                }
            }
        }

        internal virtual Button btnCreateFromTemp
        {
            get
            {
                return this._btnCreateFromTemp;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnCreateFromTemp != null)
                {
                    this._btnCreateFromTemp.Click -= new EventHandler(this.btnCreateFromTemp_Click);
                }
                this._btnCreateFromTemp = value;
                if (this._btnCreateFromTemp != null)
                {
                    this._btnCreateFromTemp.Click += new EventHandler(this.btnCreateFromTemp_Click);
                }
            }
        }

        internal virtual Button btnCreatePlaylist
        {
            get
            {
                return this._btnCreatePlaylist;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnCreatePlaylist != null)
                {
                    this._btnCreatePlaylist.Click -= new EventHandler(this.btnCreatePlaylist_Click);
                }
                this._btnCreatePlaylist = value;
                if (this._btnCreatePlaylist != null)
                {
                    this._btnCreatePlaylist.Click += new EventHandler(this.btnCreatePlaylist_Click);
                }
            }
        }

        internal virtual Button btnCreateQuickLists
        {
            get
            {
                return this._btnCreateQuickLists;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnCreateQuickLists != null)
                {
                    this._btnCreateQuickLists.Click -= new EventHandler(this.btnCreateQuickLists_Click);
                }
                this._btnCreateQuickLists = value;
                if (this._btnCreateQuickLists != null)
                {
                    this._btnCreateQuickLists.Click += new EventHandler(this.btnCreateQuickLists_Click);
                }
            }
        }

        internal virtual Button btnDown
        {
            get
            {
                return this._btnDown;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnDown != null)
                {
                    this._btnDown.Click -= new EventHandler(this.btnDown_Click);
                }
                this._btnDown = value;
                if (this._btnDown != null)
                {
                    this._btnDown.Click += new EventHandler(this.btnDown_Click);
                }
            }
        }

        internal virtual Button btnPath
        {
            get
            {
                return this._btnPath;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnPath != null)
                {
                    this._btnPath.Click -= new EventHandler(this.btnPath_Click);
                }
                this._btnPath = value;
                if (this._btnPath != null)
                {
                    this._btnPath.Click += new EventHandler(this.btnPath_Click);
                }
            }
        }

        internal virtual Button btnUp
        {
            get
            {
                return this._btnUp;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnUp != null)
                {
                    this._btnUp.Click -= new EventHandler(this.btnUp_Click);
                }
                this._btnUp = value;
                if (this._btnUp != null)
                {
                    this._btnUp.Click += new EventHandler(this.btnUp_Click);
                }
            }
        }

        internal virtual PanelEx ButtomPanel
        {
            get
            {
                return this._ButtomPanel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._ButtomPanel != null)
                {
                }
                this._ButtomPanel = value;
                if (this._ButtomPanel != null)
                {
                }
            }
        }

        internal virtual CheckBox chkColor
        {
            get
            {
                return this._chkColor;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkColor != null)
                {
                }
                this._chkColor = value;
                if (this._chkColor != null)
                {
                }
            }
        }

        internal virtual CheckBox chkCreateCSV
        {
            get
            {
                return this._chkCreateCSV;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkCreateCSV != null)
                {
                }
                this._chkCreateCSV = value;
                if (this._chkCreateCSV != null)
                {
                }
            }
        }

        internal virtual CheckBox chkCreateHTML
        {
            get
            {
                return this._chkCreateHTML;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkCreateHTML != null)
                {
                }
                this._chkCreateHTML = value;
                if (this._chkCreateHTML != null)
                {
                }
            }
        }

        internal virtual CheckBox chkGridlines
        {
            get
            {
                return this._chkGridlines;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkGridlines != null)
                {
                }
                this._chkGridlines = value;
                if (this._chkGridlines != null)
                {
                }
            }
        }

        internal virtual CheckBox chkRelativ
        {
            get
            {
                return this._chkRelativ;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkRelativ != null)
                {
                }
                this._chkRelativ = value;
                if (this._chkRelativ != null)
                {
                }
            }
        }

        internal virtual ComboBox cmbWidth
        {
            get
            {
                return this._cmbWidth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._cmbWidth != null)
                {
                    this._cmbWidth.SelectedIndexChanged -= new EventHandler(this.cmbWidth_SelectedIndexChanged);
                }
                this._cmbWidth = value;
                if (this._cmbWidth != null)
                {
                    this._cmbWidth.SelectedIndexChanged += new EventHandler(this.cmbWidth_SelectedIndexChanged);
                }
            }
        }

        internal virtual ListView ColumnsList
        {
            get
            {
                return this._ColumnsList;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._ColumnsList != null)
                {
                }
                this._ColumnsList = value;
                if (this._ColumnsList != null)
                {
                }
            }
        }

        internal virtual DotNetBarManager DotNetBarManager1
        {
            get
            {
                return this._DotNetBarManager1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._DotNetBarManager1 != null)
                {
                }
                this._DotNetBarManager1 = value;
                if (this._DotNetBarManager1 != null)
                {
                }
            }
        }

        internal virtual GroupBox frameColumns
        {
            get
            {
                return this._frameColumns;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._frameColumns != null)
                {
                }
                this._frameColumns = value;
                if (this._frameColumns != null)
                {
                }
            }
        }

        internal virtual GroupBox frameOptions
        {
            get
            {
                return this._frameOptions;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._frameOptions != null)
                {
                }
                this._frameOptions = value;
                if (this._frameOptions != null)
                {
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

        internal virtual GroupBox frameTAGInfo
        {
            get
            {
                return this._frameTAGInfo;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._frameTAGInfo != null)
                {
                }
                this._frameTAGInfo = value;
                if (this._frameTAGInfo != null)
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

        internal virtual Label lblInfo1
        {
            get
            {
                return this._lblInfo1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblInfo1 != null)
                {
                }
                this._lblInfo1 = value;
                if (this._lblInfo1 != null)
                {
                }
            }
        }

        internal virtual Label lblInfo2
        {
            get
            {
                return this._lblInfo2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblInfo2 != null)
                {
                }
                this._lblInfo2 = value;
                if (this._lblInfo2 != null)
                {
                }
            }
        }

        internal virtual Label lblInfo3
        {
            get
            {
                return this._lblInfo3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblInfo3 != null)
                {
                }
                this._lblInfo3 = value;
                if (this._lblInfo3 != null)
                {
                }
            }
        }

        internal virtual Label lblListWidth
        {
            get
            {
                return this._lblListWidth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblListWidth != null)
                {
                }
                this._lblListWidth = value;
                if (this._lblListWidth != null)
                {
                }
            }
        }

        internal virtual Label lblPath
        {
            get
            {
                return this._lblPath;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblPath != null)
                {
                }
                this._lblPath = value;
                if (this._lblPath != null)
                {
                }
            }
        }

        internal virtual Label lblPlaylist
        {
            get
            {
                return this._lblPlaylist;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblPlaylist != null)
                {
                }
                this._lblPlaylist = value;
                if (this._lblPlaylist != null)
                {
                }
            }
        }

        internal virtual Label lblTitleHTML
        {
            get
            {
                return this._lblTitleHTML;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblTitleHTML != null)
                {
                }
                this._lblTitleHTML = value;
                if (this._lblTitleHTML != null)
                {
                }
            }
        }

        internal virtual RadioButton optID3V1
        {
            get
            {
                return this._optID3V1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optID3V1 != null)
                {
                }
                this._optID3V1 = value;
                if (this._optID3V1 != null)
                {
                }
            }
        }

        internal virtual RadioButton optID3V2
        {
            get
            {
                return this._optID3V2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optID3V2 != null)
                {
                }
                this._optID3V2 = value;
                if (this._optID3V2 != null)
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

        internal virtual System.Windows.Forms.SaveFileDialog SaveFileDialog
        {
            get
            {
                return this._SaveFileDialog;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._SaveFileDialog != null)
                {
                }
                this._SaveFileDialog = value;
                if (this._SaveFileDialog != null)
                {
                }
            }
        }

        internal virtual DevComponents.DotNetBar.TabControl TabControl1
        {
            get
            {
                return this._TabControl1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TabControl1 != null)
                {
                }
                this._TabControl1 = value;
                if (this._TabControl1 != null)
                {
                }
            }
        }

        internal virtual TabControlPanel TabControlPanel1
        {
            get
            {
                return this._TabControlPanel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TabControlPanel1 != null)
                {
                }
                this._TabControlPanel1 = value;
                if (this._TabControlPanel1 != null)
                {
                }
            }
        }

        internal virtual TabControlPanel TabControlPanel2
        {
            get
            {
                return this._TabControlPanel2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TabControlPanel2 != null)
                {
                }
                this._TabControlPanel2 = value;
                if (this._TabControlPanel2 != null)
                {
                }
            }
        }

        internal virtual TabControlPanel TabControlPanel3
        {
            get
            {
                return this._TabControlPanel3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TabControlPanel3 != null)
                {
                }
                this._TabControlPanel3 = value;
                if (this._TabControlPanel3 != null)
                {
                }
            }
        }

        internal virtual TabItem tabFilelist
        {
            get
            {
                return this._tabFilelist;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._tabFilelist != null)
                {
                }
                this._tabFilelist = value;
                if (this._tabFilelist != null)
                {
                }
            }
        }

        internal virtual TabItem tabPlaylist
        {
            get
            {
                return this._tabPlaylist;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._tabPlaylist != null)
                {
                }
                this._tabPlaylist = value;
                if (this._tabPlaylist != null)
                {
                }
            }
        }

        internal virtual TabItem tabTemp
        {
            get
            {
                return this._tabTemp;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._tabTemp != null)
                {
                }
                this._tabTemp = value;
                if (this._tabTemp != null)
                {
                }
            }
        }

        internal virtual ListBox TemplatesList
        {
            get
            {
                return this._TemplatesList;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TemplatesList != null)
                {
                }
                this._TemplatesList = value;
                if (this._TemplatesList != null)
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

        internal virtual PanelEx TopPanel
        {
            get
            {
                return this._TopPanel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TopPanel != null)
                {
                }
                this._TopPanel = value;
                if (this._TopPanel != null)
                {
                }
            }
        }

        internal virtual TextBox txtExtInfo
        {
            get
            {
                return this._txtExtInfo;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtExtInfo != null)
                {
                    this._txtExtInfo.KeyPress -= new KeyPressEventHandler(this.txtExtInfo_KeyPress);
                }
                this._txtExtInfo = value;
                if (this._txtExtInfo != null)
                {
                    this._txtExtInfo.KeyPress += new KeyPressEventHandler(this.txtExtInfo_KeyPress);
                }
            }
        }

        internal virtual TextBox txtPath
        {
            get
            {
                return this._txtPath;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtPath != null)
                {
                }
                this._txtPath = value;
                if (this._txtPath != null)
                {
                }
            }
        }

        internal virtual TextBox txtTitleHTML
        {
            get
            {
                return this._txtTitleHTML;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtTitleHTML != null)
                {
                }
                this._txtTitleHTML = value;
                if (this._txtTitleHTML != null)
                {
                }
            }
        }

        internal virtual NumericUpDown txtWidth
        {
            get
            {
                return this._txtWidth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtWidth != null)
                {
                }
                this._txtWidth = value;
                if (this._txtWidth != null)
                {
                }
            }
        }
    }
}

