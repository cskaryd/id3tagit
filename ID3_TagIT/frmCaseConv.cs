using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmCaseConv : Form
  {
    #region Local variables

    private string vstrExcep;

    #endregion

    #region Events

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.txtException.Text, "", false) != 0)
      {
        foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
          if (ObjectType.ObjTst(row["Name"], this.txtException.Text.Trim(new char[] { CharType.FromString(Strings.Space(1)) }), false) == 0)
            return;

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
      Id3TagIT_Main.SaveFormSettings(ref form);
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
        Declarations.objSettings.ConvertMethod = 1;
      if (this.optAllUp.Checked)
        Declarations.objSettings.ConvertMethod = 2;
      if (this.optFirstUp.Checked)
        Declarations.objSettings.ConvertMethod = 3;
      if (this.optAllFirstUp.Checked)
        Declarations.objSettings.ConvertMethod = 4;

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
        progress.ShowDialog(this);

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
        foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
          if (ObjectType.ObjTst(row["Name"], this.lstExceptions.SelectedValue, false) == 0)
          {
            Declarations.objSettings.Exceptions.Rows.Remove(row);
            break;
          }
    }

    private void chkReplaceSpace_CheckedChanged(object sender, EventArgs e)
    {
      if (!BooleanType.FromObject(ObjectType.NotObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null))))
        if (ObjectType.ObjTst(LateBinding.LateGet(sender, null, "Name", new object[0], null, null), "chkReplaceSpace20", false) == 0)
          this.chkReplaceSpaceUnder.Checked = !this.chkReplaceSpace20.Checked;
        else
          this.chkReplaceSpace20.Checked = !this.chkReplaceSpaceUnder.Checked;
    }

    private void chkVer_CheckedChanged(object sender, EventArgs e)
    {
      if (!Declarations.objSettings.SynchronizeTAGs)
        return;

      if (sender == this.chkVer1)
      {
        if (this.chkVer1.Checked)
          this.chkVer2.Checked = true;
        else
          this.chkVer2.Checked = false;

        if (this.chkVer2.Checked)
          this.chkVer1.Checked = true;
        else
          this.chkVer1.Checked = false;
      }
      else
      {
        if (this.chkVer2.Checked)
          this.chkVer1.Checked = true;
        else
          this.chkVer1.Checked = false;

        if (this.chkVer1.Checked)
          this.chkVer2.Checked = true;
        else
          this.chkVer2.Checked = false;
      }
    }

    private void frmCaseConv_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;

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

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmCaseConv";
      Control chkAlwaysFirst = this.chkAlwaysFirst;
      this.chkAlwaysFirst = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkAlwaysFirst, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkReplaceSpaceUnder;
      this.chkReplaceSpaceUnder = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkReplaceSpaceUnder, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkReplaceSpace20;
      this.chkReplaceSpace20 = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkReplaceSpace20, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkReplaceUnderSpace;
      this.chkReplaceUnderSpace = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkReplaceUnderSpace, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkReplace20Space;
      this.chkReplace20Space = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkReplace20Space, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.txtSeparator;
      this.txtSeparator = (TextBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.txtSeparator, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkSeparator;
      this.chkSeparator = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkSeparator, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.optAllFirstUp;
      this.optAllFirstUp = (RadioButton)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.optAllFirstUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.optFirstUp;
      this.optFirstUp = (RadioButton)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.optFirstUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.optAllUp;
      this.optAllUp = (RadioButton)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.optAllUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.optAllLow;
      this.optAllLow = (RadioButton)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.optAllLow, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkVer1;
      this.chkVer1 = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkVer1, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkVer2;
      this.chkVer2 = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkVer2, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkFilename;
      this.chkFilename = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkFilename, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkArtist;
      this.chkArtist = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkArtist, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkTitle;
      this.chkTitle = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkTitle, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkAlbum;
      this.chkAlbum = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkComment;
      this.chkComment = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkComment, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.btnRemove;
      this.btnRemove = (Button)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.btnAdd;
      this.btnAdd = (Button)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.lstExceptions;
      this.lstExceptions = (ListBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.lstExceptions, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.txtException;
      this.txtException = (TextBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.txtException, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
    }

    private void CaseConvertCB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        bool flag = false;
        MP3 tag = (MP3)item.Tag;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        frmProg.lblInfo.Text = tag.CurrentFullName.Replace("&", "&&");

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
              ListViewItem item2 = new ListViewItem
              {
                Text = tag.CurrentFullName,
                SubItems = { Convert.ToString(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["FileAlreadyExistsRename"])).Replace("%1", newValue).Replace("%2", tag.CurrentFullName).Replace("%C", "") }
              };

              this.MainForm.ErrorMsg.Items.Insert(0, item2);
              // FIXME - exp this.MainForm.SplitterBottom.Expanded = true;
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
            var enumerator = tag.V2TAG.GetFrames("COMM").GetEnumerator();
          
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

        this.MainForm.UpdateListItem(item, false);

        frmProg.ProgressBar.PerformStep();
      }
    }

    private string ConvertCase(string vstrText)
    {
      if (vstrText.Length < 1)
        return "";

      if (this.chkReplace20Space.Checked)
        vstrText = vstrText.Replace("%20", Strings.Space(1));

      if (this.chkReplaceUnderSpace.Checked)
        vstrText = vstrText.Replace("_", Strings.Space(1));

      if (this.optAllLow.Checked)
        vstrText = vstrText.ToLower();
      else if (this.optAllUp.Checked)
        vstrText = vstrText.ToUpper();
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
            var ss22 = str2;
          
            if (StringType.StrCmp(ss22, "", false) == 0)
              continue;

            ss22 = ss22.ToLower();
            int num3 = ss22.Length - 1;
            num = 0;

            while (num <= num3)
            {
              if (StringType.StrCmp(ss22.Substring(num, 1).ToUpper(), ss22.Substring(num, 1), false) != 0)
              {
                if (num == 0)
                  ss22 = ss22.Substring(0, 1).ToUpper() + ss22.Substring(1);
                else if (num == (ss22.Length - 1))
                  ss22 = ss22.Substring(0, num) + ss22.Substring(num).ToUpper();
                else
                  ss22 = ss22.Substring(0, num) + ss22.Substring(num, 1).ToUpper() + ss22.Substring(num + 1);
                break;
              }
            
              num++;
            }

            vstrText = vstrText + ss22 + "\x0001";
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
                vstrText = vstrText.Substring(0, 1).ToUpper() + vstrText.Substring(1);
              else if (num == (vstrText.Length - 1))
                vstrText = vstrText.Substring(0, num) + vstrText.Substring(num).ToUpper();
              else
                vstrText = vstrText.Substring(0, num) + vstrText.Substring(num, 1).ToUpper() + vstrText.Substring(num + 1);

              break;
            }
          }
        }
      }
      else if (this.optAllFirstUp.Checked)
        vstrText = Strings.StrConv(vstrText, VbStrConv.ProperCase, 0);

      foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
      {
        this.vstrExcep = StringType.FromObject(row["Name"]);
        this.vstrExcep = Regex.Escape(this.vstrExcep);
        vstrText = Regex.Replace(vstrText, @"(\W|^)" + this.vstrExcep + @"(\W|$)", new MatchEvaluator(this.ReplaceCallback), RegexOptions.Singleline | RegexOptions.IgnoreCase);
      }

      if (this.chkReplaceSpace20.Checked)
        vstrText = vstrText.Replace(Strings.Space(1), "%20");

      if (this.chkReplaceSpaceUnder.Checked)
        vstrText = vstrText.Replace(Strings.Space(1), "_");

      if (this.chkAlwaysFirst.Checked)
        vstrText = vstrText.Substring(0, 1).ToUpper() + vstrText.Substring(1);

      return vstrText;
    }

    private string ReplaceCallback(Match Match)
    {
      this.vstrExcep = this.vstrExcep.Replace(@"\\", "\x0001").Replace(@"\", "").Replace("\x0001", @"\");
      return Strings.Replace(Match.Value, this.vstrExcep, this.vstrExcep, 1, -1, CompareMethod.Text);
    }

    #endregion
  }
}