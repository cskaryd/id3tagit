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
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public class frmCaseConv : Form
    {
        [AccessedThroughProperty("btnAdd")]
        private Button _btnAdd;
        [AccessedThroughProperty("btnCancel")]
        private Button _btnCancel;
        [AccessedThroughProperty("btnOK")]
        private Button _btnOK;
        [AccessedThroughProperty("btnRemove")]
        private Button _btnRemove;
        [AccessedThroughProperty("ButtomPanel")]
        private PanelEx _ButtomPanel;
        [AccessedThroughProperty("chkAlbum")]
        private CheckBox _chkAlbum;
        [AccessedThroughProperty("chkAlwaysFirst")]
        private CheckBox _chkAlwaysFirst;
        [AccessedThroughProperty("chkArtist")]
        private CheckBox _chkArtist;
        [AccessedThroughProperty("chkComment")]
        private CheckBox _chkComment;
        [AccessedThroughProperty("chkFilename")]
        private CheckBox _chkFilename;
        [AccessedThroughProperty("chkReplace20Space")]
        private CheckBox _chkReplace20Space;
        [AccessedThroughProperty("chkReplaceSpace20")]
        private CheckBox _chkReplaceSpace20;
        [AccessedThroughProperty("chkReplaceSpaceUnder")]
        private CheckBox _chkReplaceSpaceUnder;
        [AccessedThroughProperty("chkReplaceUnderSpace")]
        private CheckBox _chkReplaceUnderSpace;
        [AccessedThroughProperty("chkSeparator")]
        private CheckBox _chkSeparator;
        [AccessedThroughProperty("chkTitle")]
        private CheckBox _chkTitle;
        [AccessedThroughProperty("chkVer1")]
        private CheckBox _chkVer1;
        [AccessedThroughProperty("chkVer2")]
        private CheckBox _chkVer2;
        [AccessedThroughProperty("frameMethod")]
        private GroupBox _frameMethod;
        [AccessedThroughProperty("frameOptions")]
        private GroupBox _frameOptions;
        [AccessedThroughProperty("frameTAGOptions")]
        private GroupBox _frameTAGOptions;
        [AccessedThroughProperty("lblInfo")]
        private Label _lblInfo;
        [AccessedThroughProperty("lstExceptions")]
        private ListBox _lstExceptions;
        [AccessedThroughProperty("optAllFirstUp")]
        private RadioButton _optAllFirstUp;
        [AccessedThroughProperty("optAllLow")]
        private RadioButton _optAllLow;
        [AccessedThroughProperty("optAllUp")]
        private RadioButton _optAllUp;
        [AccessedThroughProperty("optFirstUp")]
        private RadioButton _optFirstUp;
        [AccessedThroughProperty("TabControl")]
        private DevComponents.DotNetBar.TabControl _TabControl;
        [AccessedThroughProperty("TabControlPanel1")]
        private TabControlPanel _TabControlPanel1;
        [AccessedThroughProperty("TabControlPanel2")]
        private TabControlPanel _TabControlPanel2;
        [AccessedThroughProperty("TabPage1")]
        private TabItem _TabPage1;
        [AccessedThroughProperty("TabPage2")]
        private TabItem _TabPage2;
        [AccessedThroughProperty("ToolTip")]
        private System.Windows.Forms.ToolTip _ToolTip;
        [AccessedThroughProperty("txtException")]
        private TextBox _txtException;
        [AccessedThroughProperty("txtSeparator")]
        private TextBox _txtSeparator;
        private IContainer components;
        private frmMain MainForm;
        private string vstrExcep;

        public frmCaseConv(ref frmMain FormMain)
        {
            base.Load += new EventHandler(this.frmCaseConv_Load);
            this.InitializeComponent();
            this.MainForm = FormMain;
        }

        private void AddToolTips()
        {
            string vstrName = "frmCaseConv";
            Control chkAlwaysFirst = this.chkAlwaysFirst;
            this.chkAlwaysFirst = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkAlwaysFirst, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkReplaceSpaceUnder;
            this.chkReplaceSpaceUnder = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkReplaceSpaceUnder, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkReplaceSpace20;
            this.chkReplaceSpace20 = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkReplaceSpace20, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkReplaceUnderSpace;
            this.chkReplaceUnderSpace = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkReplaceUnderSpace, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkReplace20Space;
            this.chkReplace20Space = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkReplace20Space, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.txtSeparator;
            this.txtSeparator = (TextBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.txtSeparator, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkSeparator;
            this.chkSeparator = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkSeparator, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.optAllFirstUp;
            this.optAllFirstUp = (RadioButton) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.optAllFirstUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.optFirstUp;
            this.optFirstUp = (RadioButton) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.optFirstUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.optAllUp;
            this.optAllUp = (RadioButton) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.optAllUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.optAllLow;
            this.optAllLow = (RadioButton) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.optAllLow, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkVer1;
            this.chkVer1 = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkVer1, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkVer2;
            this.chkVer2 = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkVer2, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkFilename;
            this.chkFilename = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkFilename, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkArtist;
            this.chkArtist = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkArtist, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkTitle;
            this.chkTitle = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkTitle, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkAlbum;
            this.chkAlbum = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.chkComment;
            this.chkComment = (CheckBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.chkComment, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.btnRemove;
            this.btnRemove = (Button) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.btnAdd;
            this.btnAdd = (Button) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.lstExceptions;
            this.lstExceptions = (ListBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.lstExceptions, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
            vstrName = "frmCaseConv";
            chkAlwaysFirst = this.txtException;
            this.txtException = (TextBox) chkAlwaysFirst;
            this.ToolTip.SetToolTip(this.txtException, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (StringType.StrCmp(this.txtException.Text, "", false) != 0)
            {
                foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
                {
                    if (ObjectType.ObjTst(row["Name"], this.txtException.Text.Trim(new char[] { CharType.FromString(Strings.Space(1)) }), false) == 0)
                    {
                        return;
                    }
                }
                DataRow row2 = Declarations.objSettings.Exceptions.NewRow();
                row2["Name"] = this.txtException.Text.Trim(new char[] { CharType.FromString(Strings.Space(1)) });
                Declarations.objSettings.Exceptions.Rows.Add(row2);
                this.txtException.Text = "";
                this.txtException.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            Form form = this;
            Main.SaveFormSettings(ref form);
            Declarations.objSettings.ConvertFilename = this.chkFilename.Checked;
            Declarations.objSettings.ConvertVer1 = this.chkVer1.Checked;
            Declarations.objSettings.ConvertVer2 = this.chkVer2.Checked;
            Declarations.objSettings.ConvertArtist = this.chkArtist.Checked;
            Declarations.objSettings.ConvertTitle = this.chkTitle.Checked;
            Declarations.objSettings.ConvertAlbum = this.chkAlbum.Checked;
            Declarations.objSettings.ConvertComment = this.chkComment.Checked;
            Declarations.objSettings.ConvertSeparat = this.chkSeparator.Checked;
            Declarations.objSettings.ConvertSeparator = this.txtSeparator.Text;
            if (this.optAllLow.Checked)
            {
                Declarations.objSettings.ConvertMethod = 1;
            }
            if (this.optAllUp.Checked)
            {
                Declarations.objSettings.ConvertMethod = 2;
            }
            if (this.optFirstUp.Checked)
            {
                Declarations.objSettings.ConvertMethod = 3;
            }
            if (this.optAllFirstUp.Checked)
            {
                Declarations.objSettings.ConvertMethod = 4;
            }
            Declarations.objSettings.ConvertReplaceSpace20 = this.chkReplaceSpace20.Checked;
            Declarations.objSettings.ConvertReplaceSpaceUnder = this.chkReplaceSpaceUnder.Checked;
            Declarations.objSettings.ConvertReplace20Space = this.chkReplace20Space.Checked;
            Declarations.objSettings.ConvertReplaceUnderSpace = this.chkReplaceUnderSpace.Checked;
            Declarations.objSettings.ConvertAlwaysFirst = this.chkAlwaysFirst.Checked;
            form = this;
            frmProgress.Callback cB = new frmProgress.Callback(this.CaseConvertCB);
            frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref cB);
            progress.SetStateCaseConv();
            progress.List = list;
            this.MainForm.MP3View.BeginUpdate();
            if ((this.chkFilename.Checked | this.chkVer1.Checked) | this.chkVer2.Checked)
            {
                progress.ShowDialog(this);
            }
            this.MainForm.MP3View.EndUpdate();
            if (list.Count > 0)
            {
                Declarations.UNDOList.Add(list);
                this.MainForm.UnDoEnable(true, true);
            }
            progress.Close();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.lstExceptions.SelectedItem != null)
            {
                foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
                {
                    if (ObjectType.ObjTst(row["Name"], this.lstExceptions.SelectedValue, false) == 0)
                    {
                        Declarations.objSettings.Exceptions.Rows.Remove(row);
                        break;
                    }
                }
            }
        }

        private void CaseConvertCB(ref frmProgress frmProg)
        {
            foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
            {
                Application.DoEvents();
                if (frmProg.Canceled)
                {
                    break;
                }
                bool flag = false;
                MP3 tag = (MP3) item.Tag;
                Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
                frmProg.List.Add(@do);
                frmProg.Infos.Text = tag.CurrentFullName;
                if (this.chkFilename.Checked)
                {
                    string sRight = this.ConvertCase(tag.CurrentName);
                    if (StringType.StrCmp(tag.CurrentName, sRight, false) != 0)
                    {
                        string newValue = tag.CurrentFullName.Substring(0, tag.CurrentFullName.LastIndexOf(@"\") + 1) + sRight + tag.FI.Extension;
                        foreach (MP3 mp in Declarations.MP3s)
                        {
                            if ((StringType.StrCmp(newValue.ToLower(), mp.CurrentFullName.ToLower(), false) == 0) && (mp != tag))
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            tag.CurrentName = sRight;
                            tag.Changed = true;
                        }
                        else
                        {
                            ListViewItem item2 = new ListViewItem {
                                Text = tag.CurrentFullName,
                                SubItems = { Convert.ToString(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["FileAlreadyExistsRename"])).Replace("%1", newValue).Replace("%2", tag.CurrentFullName).Replace("%C", "") }
                            };
                            this.MainForm.ErrorMsg.Items.Insert(0, item2);
                            this.MainForm.SplitterBottom.Expanded = true;
                        }
                    }
                }
                if (this.chkVer1.Checked)
                {
                    if (this.chkArtist.Checked)
                    {
                        string str3 = this.ConvertCase(tag.V1TAG.Artist);
                        if (StringType.StrCmp(tag.V1TAG.Artist, str3, false) != 0)
                        {
                            tag.V1TAG.Artist = str3;
                            tag.Changed = true;
                        }
                    }
                    if (this.chkAlbum.Checked)
                    {
                        string str4 = this.ConvertCase(tag.V1TAG.Album);
                        if (StringType.StrCmp(tag.V1TAG.Album, str4, false) != 0)
                        {
                            tag.V1TAG.Album = str4;
                            tag.Changed = true;
                        }
                    }
                    if (this.chkTitle.Checked)
                    {
                        string str5 = this.ConvertCase(tag.V1TAG.Title);
                        if (StringType.StrCmp(tag.V1TAG.Title, str5, false) != 0)
                        {
                            tag.V1TAG.Title = str5;
                            tag.Changed = true;
                        }
                    }
                    if (this.chkComment.Checked)
                    {
                        string str6 = this.ConvertCase(tag.V1TAG.Comment);
                        if (StringType.StrCmp(tag.V1TAG.Comment, str6, false) != 0)
                        {
                            tag.V1TAG.Comment = str6;
                            tag.Changed = true;
                        }
                    }
                }
                if (this.chkVer2.Checked)
                {
                    if (this.chkArtist.Checked & tag.V2TAG.FrameExists("TPE1"))
                    {
                        string str7 = this.ConvertCase(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null)));
                        if (ObjectType.ObjTst(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), str7, false) != 0)
                        {
                            LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[] { str7 }, null, false, true);
                            tag.Changed = true;
                        }
                    }
                    if (this.chkAlbum.Checked & tag.V2TAG.FrameExists("TALB"))
                    {
                        string str8 = this.ConvertCase(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null)));
                        if (ObjectType.ObjTst(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), str8, false) != 0)
                        {
                            LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[] { str8 }, null, false, true);
                            tag.Changed = true;
                        }
                    }
                    if (this.chkTitle.Checked & tag.V2TAG.FrameExists("TIT2"))
                    {
                        string str9 = this.ConvertCase(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null)));
                        if (ObjectType.ObjTst(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), str9, false) != 0)
                        {
                            LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[] { str9 }, null, false, true);
                            tag.Changed = true;
                        }
                    }
                    if (this.chkComment.Checked)
                    {
                        using (IEnumerator enumerator = tag.V2TAG.GetFrames("COMM").GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
                                string str10 = this.ConvertCase(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)));
                                if (ObjectType.ObjTst(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), str10, false) != 0)
                                {
                                    LateBinding.LateSet(objectValue, null, "Content", new object[] { str10 }, null);
                                    tag.Changed = true;
                                }
                            }
                        }
                    }
                }
                this.MainForm.UpdateListItem(item, false);
                frmProg.ProgressBar.PerformStep();
            }
        }

        private void chkReplaceSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (!BooleanType.FromObject(ObjectType.NotObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null))))
            {
                if (ObjectType.ObjTst(LateBinding.LateGet(sender, null, "Name", new object[0], null, null), "chkReplaceSpace20", false) == 0)
                {
                    this.chkReplaceSpaceUnder.Checked = !this.chkReplaceSpace20.Checked;
                }
                else
                {
                    this.chkReplaceSpace20.Checked = !this.chkReplaceSpaceUnder.Checked;
                }
            }
        }

        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (Declarations.objSettings.SynchronizeTAGs)
            {
                if (sender == this.chkVer1)
                {
                    if (this.chkVer1.Checked)
                    {
                        this.chkVer2.Checked = true;
                    }
                    else
                    {
                        this.chkVer2.Checked = false;
                    }
                    if (this.chkVer2.Checked)
                    {
                        this.chkVer1.Checked = true;
                    }
                    else
                    {
                        this.chkVer1.Checked = false;
                    }
                }
                else
                {
                    if (this.chkVer2.Checked)
                    {
                        this.chkVer1.Checked = true;
                    }
                    else
                    {
                        this.chkVer1.Checked = false;
                    }
                    if (this.chkVer1.Checked)
                    {
                        this.chkVer2.Checked = true;
                    }
                    else
                    {
                        this.chkVer2.Checked = false;
                    }
                }
            }
        }

        private string ConvertCase(string vstrText)
        {
            if (vstrText.Length < 1)
            {
                return "";
            }
            if (this.chkReplace20Space.Checked)
            {
                vstrText = vstrText.Replace("%20", Strings.Space(1));
            }
            if (this.chkReplaceUnderSpace.Checked)
            {
                vstrText = vstrText.Replace("_", Strings.Space(1));
            }
            if (this.optAllLow.Checked)
            {
                vstrText = vstrText.ToLower();
            }
            else if (this.optAllUp.Checked)
            {
                vstrText = vstrText.ToUpper();
            }
            else if (this.optFirstUp.Checked)
            {
                int num;
                if (this.chkSeparator.Checked)
                {
                    vstrText = vstrText.Replace(this.txtSeparator.Text, "\x0001");
                    string[] strArray = vstrText.Split(new char[] { '\x0001' });
                    vstrText = "";
                    foreach (string str2 in strArray)
                    {
                        if (StringType.StrCmp(str2, "", false) == 0)
                        {
                            continue;
                        }
                        str2 = str2.ToLower();
                        int num3 = str2.Length - 1;
                        num = 0;
                        while (num <= num3)
                        {
                            if (StringType.StrCmp(str2.Substring(num, 1).ToUpper(), str2.Substring(num, 1), false) != 0)
                            {
                                if (num == 0)
                                {
                                    str2 = str2.Substring(0, 1).ToUpper() + str2.Substring(1);
                                }
                                else if (num == (str2.Length - 1))
                                {
                                    str2 = str2.Substring(0, num) + str2.Substring(num).ToUpper();
                                }
                                else
                                {
                                    str2 = str2.Substring(0, num) + str2.Substring(num, 1).ToUpper() + str2.Substring(num + 1);
                                }
                                break;
                            }
                            num++;
                        }
                        vstrText = vstrText + str2 + "\x0001";
                    }
                    vstrText = vstrText.TrimEnd(new char[] { '\x0001' });
                    vstrText = vstrText.Replace("\x0001", this.txtSeparator.Text);
                }
                else if (StringType.StrCmp(vstrText, "", false) != 0)
                {
                    vstrText = vstrText.ToLower();
                    int num2 = vstrText.Length - 1;
                    for (num = 0; num <= num2; num++)
                    {
                        if (StringType.StrCmp(vstrText.Substring(num, 1).ToUpper(), vstrText.Substring(num, 1), false) != 0)
                        {
                            if (num == 0)
                            {
                                vstrText = vstrText.Substring(0, 1).ToUpper() + vstrText.Substring(1);
                            }
                            else if (num == (vstrText.Length - 1))
                            {
                                vstrText = vstrText.Substring(0, num) + vstrText.Substring(num).ToUpper();
                            }
                            else
                            {
                                vstrText = vstrText.Substring(0, num) + vstrText.Substring(num, 1).ToUpper() + vstrText.Substring(num + 1);
                            }
                            break;
                        }
                    }
                }
            }
            else if (this.optAllFirstUp.Checked)
            {
                vstrText = Strings.StrConv(vstrText, VbStrConv.ProperCase, 0);
            }
            foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
            {
                this.vstrExcep = StringType.FromObject(row["Name"]);
                this.vstrExcep = Regex.Escape(this.vstrExcep);
                vstrText = Regex.Replace(vstrText, @"(\W|^)" + this.vstrExcep + @"(\W|$)", new MatchEvaluator(this.ReplaceCallback), RegexOptions.Singleline | RegexOptions.IgnoreCase);
            }
            if (this.chkReplaceSpace20.Checked)
            {
                vstrText = vstrText.Replace(Strings.Space(1), "%20");
            }
            if (this.chkReplaceSpaceUnder.Checked)
            {
                vstrText = vstrText.Replace(Strings.Space(1), "_");
            }
            if (this.chkAlwaysFirst.Checked)
            {
                vstrText = vstrText.Substring(0, 1).ToUpper() + vstrText.Substring(1);
            }
            return vstrText;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmCaseConv_Load(object sender, EventArgs e)
        {
            Form objForm = this;
            Declarations.objResources.ResourcesToForm(ref objForm);
            objForm = this;
            Main.RestoreFormSettings(ref objForm);
            objForm = this;
            Main.WindowsXPCheck(ref objForm);
            this.lstExceptions.DataSource = Declarations.objSettings.Exceptions;
            this.lstExceptions.DisplayMember = "Name";
            this.lstExceptions.ValueMember = "Name";
            this.chkFilename.Checked = Declarations.objSettings.ConvertFilename;
            this.chkVer1.Checked = Declarations.objSettings.ConvertVer1;
            this.chkVer2.Checked = Declarations.objSettings.ConvertVer2;
            this.chkArtist.Checked = Declarations.objSettings.ConvertArtist;
            this.chkTitle.Checked = Declarations.objSettings.ConvertTitle;
            this.chkAlbum.Checked = Declarations.objSettings.ConvertAlbum;
            this.chkComment.Checked = Declarations.objSettings.ConvertComment;
            this.chkSeparator.Checked = Declarations.objSettings.ConvertSeparat;
            this.txtSeparator.Text = Declarations.objSettings.ConvertSeparator;
            switch (Declarations.objSettings.ConvertMethod)
            {
                case 1:
                    this.optAllLow.Checked = true;
                    break;

                case 2:
                    this.optAllUp.Checked = true;
                    break;

                case 3:
                    this.optFirstUp.Checked = true;
                    break;

                case 4:
                    this.optAllFirstUp.Checked = true;
                    break;
            }
            this.chkReplaceSpace20.Checked = Declarations.objSettings.ConvertReplaceSpace20;
            this.chkReplaceSpaceUnder.Checked = Declarations.objSettings.ConvertReplaceSpaceUnder;
            this.chkReplace20Space.Checked = Declarations.objSettings.ConvertReplace20Space;
            this.chkReplaceUnderSpace.Checked = Declarations.objSettings.ConvertReplaceUnderSpace;
            this.chkAlwaysFirst.Checked = Declarations.objSettings.ConvertAlwaysFirst;
            this.AddToolTips();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
            this.btnCancel = new Button();
            this.btnOK = new Button();
            this.frameOptions = new GroupBox();
            this.chkAlwaysFirst = new CheckBox();
            this.chkReplaceSpaceUnder = new CheckBox();
            this.chkReplaceSpace20 = new CheckBox();
            this.chkReplaceUnderSpace = new CheckBox();
            this.chkReplace20Space = new CheckBox();
            this.txtSeparator = new TextBox();
            this.chkSeparator = new CheckBox();
            this.frameMethod = new GroupBox();
            this.optAllFirstUp = new RadioButton();
            this.optFirstUp = new RadioButton();
            this.optAllUp = new RadioButton();
            this.optAllLow = new RadioButton();
            this.chkVer1 = new CheckBox();
            this.chkVer2 = new CheckBox();
            this.chkFilename = new CheckBox();
            this.frameTAGOptions = new GroupBox();
            this.chkArtist = new CheckBox();
            this.chkTitle = new CheckBox();
            this.chkAlbum = new CheckBox();
            this.chkComment = new CheckBox();
            this.lblInfo = new Label();
            this.btnRemove = new Button();
            this.btnAdd = new Button();
            this.lstExceptions = new ListBox();
            this.txtException = new TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl = new DevComponents.DotNetBar.TabControl();
            this.TabControlPanel1 = new TabControlPanel();
            this.TabPage1 = new TabItem(this.components);
            this.TabControlPanel2 = new TabControlPanel();
            this.TabPage2 = new TabItem(this.components);
            this.ButtomPanel = new PanelEx();
            this.frameOptions.SuspendLayout();
            this.frameMethod.SuspendLayout();
            this.frameTAGOptions.SuspendLayout();
            ((ISupportInitialize) this.TabControl).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabControlPanel1.SuspendLayout();
            this.TabControlPanel2.SuspendLayout();
            this.ButtomPanel.SuspendLayout();
            this.SuspendLayout();
            this.btnCancel.BackColor = SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = ImeMode.NoControl;
            Point point = new Point(0x148, 8);
            this.btnCancel.Location = point;
            this.btnCancel.Name = "btnCancel";
            Size size = new Size(0x70, 0x18);
            this.btnCancel.Size = size;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnOK.BackColor = SystemColors.Control;
            this.btnOK.ImeMode = ImeMode.NoControl;
            point = new Point(0xd0, 8);
            this.btnOK.Location = point;
            this.btnOK.Name = "btnOK";
            size = new Size(0x70, 0x18);
            this.btnOK.Size = size;
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.frameOptions.BackColor = Color.Transparent;
            this.frameOptions.Controls.Add(this.chkAlwaysFirst);
            this.frameOptions.Controls.Add(this.chkReplaceSpaceUnder);
            this.frameOptions.Controls.Add(this.chkReplaceSpace20);
            this.frameOptions.Controls.Add(this.chkReplaceUnderSpace);
            this.frameOptions.Controls.Add(this.chkReplace20Space);
            this.frameOptions.Controls.Add(this.txtSeparator);
            this.frameOptions.Controls.Add(this.chkSeparator);
            point = new Point(8, 0xb8);
            this.frameOptions.Location = point;
            this.frameOptions.Name = "frameOptions";
            size = new Size(0x1b0, 120);
            this.frameOptions.Size = size;
            this.frameOptions.TabIndex = 0x18;
            this.frameOptions.TabStop = false;
            this.frameOptions.Text = "Options";
            this.chkAlwaysFirst.BackColor = Color.Transparent;
            this.chkAlwaysFirst.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x60);
            this.chkAlwaysFirst.Location = point;
            this.chkAlwaysFirst.Name = "chkAlwaysFirst";
            size = new Size(0x198, 0x10);
            this.chkAlwaysFirst.Size = size;
            this.chkAlwaysFirst.TabIndex = 0x10;
            this.chkAlwaysFirst.Text = "Always uppercase first letter of entry";
            this.chkReplaceSpaceUnder.ImeMode = ImeMode.NoControl;
            point = new Point(0xe8, 0x48);
            this.chkReplaceSpaceUnder.Location = point;
            this.chkReplaceSpaceUnder.Name = "chkReplaceSpaceUnder";
            size = new Size(0xc0, 0x10);
            this.chkReplaceSpaceUnder.Size = size;
            this.chkReplaceSpaceUnder.TabIndex = 0x12;
            this.chkReplaceSpaceUnder.Text = "Replace space by '_'";
            this.chkReplaceSpace20.ImeMode = ImeMode.NoControl;
            point = new Point(0xe8, 0x30);
            this.chkReplaceSpace20.Location = point;
            this.chkReplaceSpace20.Name = "chkReplaceSpace20";
            size = new Size(0xc0, 0x10);
            this.chkReplaceSpace20.Size = size;
            this.chkReplaceSpace20.TabIndex = 0x11;
            this.chkReplaceSpace20.Text = "Replace space by '%20'";
            this.chkReplaceUnderSpace.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x48);
            this.chkReplaceUnderSpace.Location = point;
            this.chkReplaceUnderSpace.Name = "chkReplaceUnderSpace";
            size = new Size(0xd0, 0x10);
            this.chkReplaceUnderSpace.Size = size;
            this.chkReplaceUnderSpace.TabIndex = 15;
            this.chkReplaceUnderSpace.Text = "Replace '_' by space";
            this.chkReplace20Space.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x30);
            this.chkReplace20Space.Location = point;
            this.chkReplace20Space.Name = "chkReplace20Space";
            size = new Size(0xd0, 0x10);
            this.chkReplace20Space.Size = size;
            this.chkReplace20Space.TabIndex = 14;
            this.chkReplace20Space.Text = "Replace '%20' by space";
            point = new Point(0x60, 0x16);
            this.txtSeparator.Location = point;
            this.txtSeparator.Name = "txtSeparator";
            size = new Size(0x40, 20);
            this.txtSeparator.Size = size;
            this.txtSeparator.TabIndex = 13;
            this.txtSeparator.Text = "";
            this.chkSeparator.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x18);
            this.chkSeparator.Location = point;
            this.chkSeparator.Name = "chkSeparator";
            size = new Size(80, 0x10);
            this.chkSeparator.Size = size;
            this.chkSeparator.TabIndex = 12;
            this.chkSeparator.Text = "&Separator:";
            this.frameMethod.BackColor = Color.Transparent;
            this.frameMethod.Controls.Add(this.optAllFirstUp);
            this.frameMethod.Controls.Add(this.optFirstUp);
            this.frameMethod.Controls.Add(this.optAllUp);
            this.frameMethod.Controls.Add(this.optAllLow);
            point = new Point(200, 0x38);
            this.frameMethod.Location = point;
            this.frameMethod.Name = "frameMethod";
            size = new Size(240, 120);
            this.frameMethod.Size = size;
            this.frameMethod.TabIndex = 0x17;
            this.frameMethod.TabStop = false;
            this.frameMethod.Text = "Convert method";
            this.optAllFirstUp.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x60);
            this.optAllFirstUp.Location = point;
            this.optAllFirstUp.Name = "optAllFirstUp";
            size = new Size(0xd8, 0x10);
            this.optAllFirstUp.Size = size;
            this.optAllFirstUp.TabIndex = 11;
            this.optAllFirstUp.Text = "A&ll first letters uppercase";
            this.optFirstUp.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x48);
            this.optFirstUp.Location = point;
            this.optFirstUp.Name = "optFirstUp";
            size = new Size(0xd8, 0x10);
            this.optFirstUp.Size = size;
            this.optFirstUp.TabIndex = 10;
            this.optFirstUp.Text = "&First letter uppercase";
            this.optAllUp.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x30);
            this.optAllUp.Location = point;
            this.optAllUp.Name = "optAllUp";
            size = new Size(0xd8, 0x10);
            this.optAllUp.Size = size;
            this.optAllUp.TabIndex = 9;
            this.optAllUp.Text = "All &uppercase";
            this.optAllLow.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x18);
            this.optAllLow.Location = point;
            this.optAllLow.Name = "optAllLow";
            size = new Size(0xd8, 0x10);
            this.optAllLow.Size = size;
            this.optAllLow.TabIndex = 8;
            this.optAllLow.Text = "All &lowercase";
            this.chkVer1.BackColor = Color.Transparent;
            this.chkVer1.ImeMode = ImeMode.NoControl;
            point = new Point(0x18, 0x20);
            this.chkVer1.Location = point;
            this.chkVer1.Name = "chkVer1";
            size = new Size(0xc0, 0x10);
            this.chkVer1.Size = size;
            this.chkVer1.TabIndex = 2;
            this.chkVer1.Text = "Convert TAG Ver. &1";
            this.chkVer2.BackColor = Color.Transparent;
            this.chkVer2.ImeMode = ImeMode.NoControl;
            point = new Point(240, 0x20);
            this.chkVer2.Location = point;
            this.chkVer2.Name = "chkVer2";
            size = new Size(0xc0, 0x10);
            this.chkVer2.Size = size;
            this.chkVer2.TabIndex = 3;
            this.chkVer2.Text = "Convert TAG Ver. &2";
            this.chkFilename.BackColor = Color.Transparent;
            this.chkFilename.ImeMode = ImeMode.NoControl;
            point = new Point(0x18, 8);
            this.chkFilename.Location = point;
            this.chkFilename.Name = "chkFilename";
            size = new Size(0xc0, 0x10);
            this.chkFilename.Size = size;
            this.chkFilename.TabIndex = 1;
            this.chkFilename.Text = "Convert &Filename";
            this.frameTAGOptions.BackColor = Color.Transparent;
            this.frameTAGOptions.Controls.Add(this.chkArtist);
            this.frameTAGOptions.Controls.Add(this.chkTitle);
            this.frameTAGOptions.Controls.Add(this.chkAlbum);
            this.frameTAGOptions.Controls.Add(this.chkComment);
            point = new Point(8, 0x38);
            this.frameTAGOptions.Location = point;
            this.frameTAGOptions.Name = "frameTAGOptions";
            size = new Size(0xb8, 120);
            this.frameTAGOptions.Size = size;
            this.frameTAGOptions.TabIndex = 0x13;
            this.frameTAGOptions.TabStop = false;
            this.frameTAGOptions.Text = "TAG fields to convert";
            this.chkArtist.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x18);
            this.chkArtist.Location = point;
            this.chkArtist.Name = "chkArtist";
            size = new Size(160, 0x10);
            this.chkArtist.Size = size;
            this.chkArtist.TabIndex = 4;
            this.chkArtist.Text = "&Artist";
            this.chkTitle.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x48);
            this.chkTitle.Location = point;
            this.chkTitle.Name = "chkTitle";
            size = new Size(160, 0x10);
            this.chkTitle.Size = size;
            this.chkTitle.TabIndex = 6;
            this.chkTitle.Text = "&Title";
            this.chkAlbum.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x30);
            this.chkAlbum.Location = point;
            this.chkAlbum.Name = "chkAlbum";
            size = new Size(160, 0x10);
            this.chkAlbum.Size = size;
            this.chkAlbum.TabIndex = 5;
            this.chkAlbum.Text = "Al&bum";
            this.chkComment.ImeMode = ImeMode.NoControl;
            point = new Point(0x10, 0x60);
            this.chkComment.Location = point;
            this.chkComment.Name = "chkComment";
            size = new Size(160, 0x10);
            this.chkComment.Size = size;
            this.chkComment.TabIndex = 7;
            this.chkComment.Text = "&Comment";
            this.lblInfo.BackColor = Color.Transparent;
            this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
            this.lblInfo.ImeMode = ImeMode.NoControl;
            point = new Point(0xd8, 0xf8);
            this.lblInfo.Location = point;
            this.lblInfo.Name = "lblInfo";
            size = new Size(0xd8, 0x38);
            this.lblInfo.Size = size;
            this.lblInfo.TabIndex = 0x2d;
            this.lblInfo.Text = "All the words in the list will always be written in the casing you entered here.";
            this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            this.btnRemove.BackColor = SystemColors.Control;
            this.btnRemove.ImeMode = ImeMode.NoControl;
            point = new Point(0xd8, 0x48);
            this.btnRemove.Location = point;
            this.btnRemove.Name = "btnRemove";
            size = new Size(0xd8, 0x18);
            this.btnRemove.Size = size;
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "&Remove";
            this.btnAdd.BackColor = SystemColors.Control;
            this.btnAdd.ImeMode = ImeMode.NoControl;
            point = new Point(0xd8, 40);
            this.btnAdd.Location = point;
            this.btnAdd.Name = "btnAdd";
            size = new Size(0xd8, 0x18);
            this.btnAdd.Size = size;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            point = new Point(8, 40);
            this.lstExceptions.Location = point;
            this.lstExceptions.Name = "lstExceptions";
            size = new Size(200, 0x108);
            this.lstExceptions.Size = size;
            this.lstExceptions.TabIndex = 4;
            point = new Point(8, 8);
            this.txtException.Location = point;
            this.txtException.Name = "txtException";
            size = new Size(0x1a8, 20);
            this.txtException.Size = size;
            this.txtException.TabIndex = 1;
            this.txtException.Text = "";
            this.TabControl.CanReorderTabs = true;
            this.TabControl.Controls.Add(this.TabControlPanel1);
            this.TabControl.Controls.Add(this.TabControlPanel2);
            this.TabControl.Dock = DockStyle.Fill;
            point = new Point(0, 0);
            this.TabControl.Location = point;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            this.TabControl.SelectedTabIndex = 0;
            size = new Size(450, 0x150);
            this.TabControl.Size = size;
            this.TabControl.Style = eTabStripStyle.VS2005Document;
            this.TabControl.TabIndex = 3;
            this.TabControl.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
            this.TabControl.Tabs.Add(this.TabPage1);
            this.TabControl.Tabs.Add(this.TabPage2);
            this.TabControlPanel1.AntiAlias = true;
            this.TabControlPanel1.Controls.Add(this.frameTAGOptions);
            this.TabControlPanel1.Controls.Add(this.chkFilename);
            this.TabControlPanel1.Controls.Add(this.chkVer2);
            this.TabControlPanel1.Controls.Add(this.chkVer1);
            this.TabControlPanel1.Controls.Add(this.frameOptions);
            this.TabControlPanel1.Controls.Add(this.frameMethod);
            this.TabControlPanel1.Dock = DockStyle.Fill;
            this.TabControlPanel1.DockPadding.All = 1;
            point = new Point(0, 0x1a);
            this.TabControlPanel1.Location = point;
            this.TabControlPanel1.Name = "TabControlPanel1";
            size = new Size(450, 310);
            this.TabControlPanel1.Size = size;
            this.TabControlPanel1.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
            this.TabControlPanel1.Style.Border = eBorderType.SingleLine;
            this.TabControlPanel1.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
            this.TabControlPanel1.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
            this.TabControlPanel1.Style.GradientAngle = 90;
            this.TabControlPanel1.TabIndex = 1;
            this.TabControlPanel1.TabItem = this.TabPage1;
            this.TabPage1.AttachedControl = this.TabControlPanel1;
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Text = "Case Conversion";
            this.TabControlPanel2.AntiAlias = true;
            this.TabControlPanel2.Controls.Add(this.lstExceptions);
            this.TabControlPanel2.Controls.Add(this.btnAdd);
            this.TabControlPanel2.Controls.Add(this.btnRemove);
            this.TabControlPanel2.Controls.Add(this.lblInfo);
            this.TabControlPanel2.Controls.Add(this.txtException);
            this.TabControlPanel2.Dock = DockStyle.Fill;
            this.TabControlPanel2.DockPadding.All = 1;
            point = new Point(0, 0x1a);
            this.TabControlPanel2.Location = point;
            this.TabControlPanel2.Name = "TabControlPanel2";
            size = new Size(450, 310);
            this.TabControlPanel2.Size = size;
            this.TabControlPanel2.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
            this.TabControlPanel2.Style.Border = eBorderType.SingleLine;
            this.TabControlPanel2.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
            this.TabControlPanel2.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
            this.TabControlPanel2.Style.GradientAngle = 90;
            this.TabControlPanel2.TabIndex = 2;
            this.TabControlPanel2.TabItem = this.TabPage2;
            this.TabPage2.AttachedControl = this.TabControlPanel2;
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Text = "Exceptions";
            this.ButtomPanel.AntiAlias = true;
            this.ButtomPanel.Controls.Add(this.btnCancel);
            this.ButtomPanel.Controls.Add(this.btnOK);
            this.ButtomPanel.Dock = DockStyle.Bottom;
            point = new Point(0, 0x150);
            this.ButtomPanel.Location = point;
            this.ButtomPanel.Name = "ButtomPanel";
            size = new Size(450, 40);
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
            this.ButtomPanel.TabIndex = 0x75;
            this.AcceptButton = this.btnOK;
            size = new Size(5, 13);
            this.AutoScaleBaseSize = size;
            this.CancelButton = this.btnCancel;
            size = new Size(450, 0x178);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ButtomPanel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaseConv";
            this.ShowInTaskbar = false;
            this.Text = "Case Conversion";
            this.frameOptions.ResumeLayout(false);
            this.frameMethod.ResumeLayout(false);
            this.frameTAGOptions.ResumeLayout(false);
            ((ISupportInitialize) this.TabControl).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabControlPanel1.ResumeLayout(false);
            this.TabControlPanel2.ResumeLayout(false);
            this.ButtomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private string ReplaceCallback(Match Match)
        {
            this.vstrExcep = this.vstrExcep.Replace(@"\\", "\x0001").Replace(@"\", "").Replace("\x0001", @"\");
            return Strings.Replace(Match.Value, this.vstrExcep, this.vstrExcep, 1, -1, CompareMethod.Text);
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

        internal virtual CheckBox chkAlbum
        {
            get
            {
                return this._chkAlbum;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkAlbum != null)
                {
                }
                this._chkAlbum = value;
                if (this._chkAlbum != null)
                {
                }
            }
        }

        internal virtual CheckBox chkAlwaysFirst
        {
            get
            {
                return this._chkAlwaysFirst;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkAlwaysFirst != null)
                {
                }
                this._chkAlwaysFirst = value;
                if (this._chkAlwaysFirst != null)
                {
                }
            }
        }

        internal virtual CheckBox chkArtist
        {
            get
            {
                return this._chkArtist;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkArtist != null)
                {
                }
                this._chkArtist = value;
                if (this._chkArtist != null)
                {
                }
            }
        }

        internal virtual CheckBox chkComment
        {
            get
            {
                return this._chkComment;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkComment != null)
                {
                }
                this._chkComment = value;
                if (this._chkComment != null)
                {
                }
            }
        }

        internal virtual CheckBox chkFilename
        {
            get
            {
                return this._chkFilename;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkFilename != null)
                {
                }
                this._chkFilename = value;
                if (this._chkFilename != null)
                {
                }
            }
        }

        internal virtual CheckBox chkReplace20Space
        {
            get
            {
                return this._chkReplace20Space;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkReplace20Space != null)
                {
                }
                this._chkReplace20Space = value;
                if (this._chkReplace20Space != null)
                {
                }
            }
        }

        internal virtual CheckBox chkReplaceSpace20
        {
            get
            {
                return this._chkReplaceSpace20;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkReplaceSpace20 != null)
                {
                    this._chkReplaceSpace20.CheckedChanged -= new EventHandler(this.chkReplaceSpace_CheckedChanged);
                }
                this._chkReplaceSpace20 = value;
                if (this._chkReplaceSpace20 != null)
                {
                    this._chkReplaceSpace20.CheckedChanged += new EventHandler(this.chkReplaceSpace_CheckedChanged);
                }
            }
        }

        internal virtual CheckBox chkReplaceSpaceUnder
        {
            get
            {
                return this._chkReplaceSpaceUnder;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkReplaceSpaceUnder != null)
                {
                    this._chkReplaceSpaceUnder.CheckedChanged -= new EventHandler(this.chkReplaceSpace_CheckedChanged);
                }
                this._chkReplaceSpaceUnder = value;
                if (this._chkReplaceSpaceUnder != null)
                {
                    this._chkReplaceSpaceUnder.CheckedChanged += new EventHandler(this.chkReplaceSpace_CheckedChanged);
                }
            }
        }

        internal virtual CheckBox chkReplaceUnderSpace
        {
            get
            {
                return this._chkReplaceUnderSpace;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkReplaceUnderSpace != null)
                {
                }
                this._chkReplaceUnderSpace = value;
                if (this._chkReplaceUnderSpace != null)
                {
                }
            }
        }

        internal virtual CheckBox chkSeparator
        {
            get
            {
                return this._chkSeparator;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkSeparator != null)
                {
                }
                this._chkSeparator = value;
                if (this._chkSeparator != null)
                {
                }
            }
        }

        internal virtual CheckBox chkTitle
        {
            get
            {
                return this._chkTitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkTitle != null)
                {
                }
                this._chkTitle = value;
                if (this._chkTitle != null)
                {
                }
            }
        }

        internal virtual CheckBox chkVer1
        {
            get
            {
                return this._chkVer1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkVer1 != null)
                {
                    this._chkVer1.CheckedChanged -= new EventHandler(this.chkVer_CheckedChanged);
                }
                this._chkVer1 = value;
                if (this._chkVer1 != null)
                {
                    this._chkVer1.CheckedChanged += new EventHandler(this.chkVer_CheckedChanged);
                }
            }
        }

        internal virtual CheckBox chkVer2
        {
            get
            {
                return this._chkVer2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._chkVer2 != null)
                {
                    this._chkVer2.CheckedChanged -= new EventHandler(this.chkVer_CheckedChanged);
                }
                this._chkVer2 = value;
                if (this._chkVer2 != null)
                {
                    this._chkVer2.CheckedChanged += new EventHandler(this.chkVer_CheckedChanged);
                }
            }
        }

        internal virtual GroupBox frameMethod
        {
            get
            {
                return this._frameMethod;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._frameMethod != null)
                {
                }
                this._frameMethod = value;
                if (this._frameMethod != null)
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

        internal virtual GroupBox frameTAGOptions
        {
            get
            {
                return this._frameTAGOptions;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._frameTAGOptions != null)
                {
                }
                this._frameTAGOptions = value;
                if (this._frameTAGOptions != null)
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

        internal virtual ListBox lstExceptions
        {
            get
            {
                return this._lstExceptions;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lstExceptions != null)
                {
                }
                this._lstExceptions = value;
                if (this._lstExceptions != null)
                {
                }
            }
        }

        internal virtual RadioButton optAllFirstUp
        {
            get
            {
                return this._optAllFirstUp;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optAllFirstUp != null)
                {
                }
                this._optAllFirstUp = value;
                if (this._optAllFirstUp != null)
                {
                }
            }
        }

        internal virtual RadioButton optAllLow
        {
            get
            {
                return this._optAllLow;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optAllLow != null)
                {
                }
                this._optAllLow = value;
                if (this._optAllLow != null)
                {
                }
            }
        }

        internal virtual RadioButton optAllUp
        {
            get
            {
                return this._optAllUp;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optAllUp != null)
                {
                }
                this._optAllUp = value;
                if (this._optAllUp != null)
                {
                }
            }
        }

        internal virtual RadioButton optFirstUp
        {
            get
            {
                return this._optFirstUp;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._optFirstUp != null)
                {
                }
                this._optFirstUp = value;
                if (this._optFirstUp != null)
                {
                }
            }
        }

        internal virtual DevComponents.DotNetBar.TabControl TabControl
        {
            get
            {
                return this._TabControl;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TabControl != null)
                {
                }
                this._TabControl = value;
                if (this._TabControl != null)
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

        internal virtual TabItem TabPage1
        {
            get
            {
                return this._TabPage1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TabPage1 != null)
                {
                }
                this._TabPage1 = value;
                if (this._TabPage1 != null)
                {
                }
            }
        }

        internal virtual TabItem TabPage2
        {
            get
            {
                return this._TabPage2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TabPage2 != null)
                {
                }
                this._TabPage2 = value;
                if (this._TabPage2 != null)
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

        internal virtual TextBox txtException
        {
            get
            {
                return this._txtException;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtException != null)
                {
                }
                this._txtException = value;
                if (this._txtException != null)
                {
                }
            }
        }

        internal virtual TextBox txtSeparator
        {
            get
            {
                return this._txtSeparator;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._txtSeparator != null)
                {
                }
                this._txtSeparator = value;
                if (this._txtSeparator != null)
                {
                }
            }
        }
    }
}

