using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmCompareFileTAG : Form
  {
    #region Events

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.cmbFormat.Text, "", false) != 0)
        this.cmbFormat.Items.Add(this.cmbFormat.Text);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      string vstrFormat = "";
      vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });

      if (vstrFormat.IndexOf(":") >= 0)
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });

      if (this.optTAGV2.Checked)
      {
        switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.CompareTAGFilename | Declarations.FormatReplace.TAGVer2))
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
      }
      else
      {
        switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.CompareTAGFilename | Declarations.FormatReplace.TAGVer1))
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
      }

      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);

      if (this.optTAGV2.Checked)
        Declarations.objSettings.CompareFileTAGVersion = 2;
      else
        Declarations.objSettings.CompareFileTAGVersion = 1;

      Declarations.objSettings.CompareFormats.Rows.Clear();
      Declarations.objSettings.CompareFormat = this.cmbFormat.Text;
      Declarations.objSettings.CompareFileTAGReplace = this.chkReplaceUnderScore.Checked;
      Declarations.objSettings.CompareFileTAGIgnoreCase = this.chkIgnoreCase.Checked;
      Declarations.objSettings.TracknumberDigitsFilename = Convert.ToByte(this.txtDigits.Value);

      int num2 = this.cmbFormat.Items.Count - 1;

      for (int i = 0; i <= num2; i++)
      {
        DataRow row = Declarations.objSettings.CompareFormats.NewRow();
        row["Format"] = this.cmbFormat.Items[i].ToString();
        Declarations.objSettings.CompareFormats.Rows.Add(row);
      }

      this.MainForm.MP3View.BeginUpdate();
      form = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.CompareFileTAGCB);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.Items.Count, 1, ref form, ref cB);
      progress.SetStateCompareFileTAG();
      progress.String01 = vstrFormat;
      progress.ShowDialog(this);
      this.MainForm.MP3View.EndUpdate();
      form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
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

    private void frmCompareFileTAG_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;

      int num2 = Declarations.objSettings.CompareFormats.Rows.Count - 1;
      for (int i = 0; i <= num2; i++)
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.CompareFormats.Rows[i]["Format"]));

      this.cmbFormat.Text = Declarations.objSettings.CompareFormat;
      this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);

      if (Declarations.objSettings.CompareFileTAGVersion == 1)
        this.optTAGV1.Checked = true;
      else
        this.optTAGV2.Checked = true;

      this.chkReplaceUnderScore.Checked = Declarations.objSettings.CompareFileTAGReplace;
      this.chkIgnoreCase.Checked = Declarations.objSettings.CompareFileTAGIgnoreCase;
      this.AddToolTips();
    }

    private void Label_Click(object sender, EventArgs e)
    {
      string selectedText = this.cmbFormat.SelectedText;
      int selectionStart = this.cmbFormat.SelectionStart;

      if (this.cmbFormat.SelectionLength == 0)
      {
        this.cmbFormat.Text = StringType.FromObject(
                                ObjectType.StrCatObj(
                                  ObjectType.StrCatObj(this.cmbFormat.Text.Substring(0, this.cmbFormat.SelectionStart),
                                                       LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null),
                                                                           null, "Substring", new object[] { 0, 3 }, null, null)),
                                  this.cmbFormat.Text.Substring(this.cmbFormat.SelectionStart)));
        this.cmbFormat.SelectionStart = selectionStart + 3;
      }
      else
      {
        string str2 = this.cmbFormat.Text.Substring(0, selectionStart);

        this.cmbFormat.Text = Strings.Replace(this.cmbFormat.Text,
                                              selectedText,
                                              StringType.FromObject(
                                                LateBinding.LateGet(
                                                  LateBinding.LateGet(sender, null, "Text", new object[0], null, null),
                                                                      null, "Substring", new object[] { 0, 3 }, null, null)),
                                              selectionStart + 1, 1, CompareMethod.Text);
        this.cmbFormat.Text = str2 + this.cmbFormat.Text;
        this.cmbFormat.SelectionStart = selectionStart + 3;
      }
    }

    private void optTAG_CheckedChanged(object sender, EventArgs e)
    {
      this.L8.Visible = this.optTAGV2.Checked;
      this.L9.Visible = this.optTAGV2.Checked;
      this.L10.Visible = this.optTAGV2.Checked;
      this.L11.Visible = this.optTAGV2.Checked;
      this.L12.Visible = this.optTAGV2.Checked;
      this.L13.Visible = this.optTAGV2.Checked;
      this.L14.Visible = this.optTAGV2.Checked;
      this.L15.Visible = this.optTAGV2.Checked;
      this.L16.Visible = this.optTAGV2.Checked;
      this.L17.Visible = this.optTAGV2.Checked;
    }

    private void txtDigits_Validated(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Minimum) < 0)
        this.txtDigits.Value = this.txtDigits.Minimum;

      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Maximum) > 0)
        this.txtDigits.Value = this.txtDigits.Maximum;
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmCompareFileTAG";
      Control txtDigits = this.txtDigits;
      this.txtDigits = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmCompareFileTAG";
      txtDigits = this.btnRemove;
      this.btnRemove = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmCompareFileTAG";
      txtDigits = this.btnAdd;
      this.btnAdd = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmCompareFileTAG";
      txtDigits = this.cmbFormat;
      this.cmbFormat = (ComboBox)txtDigits;
      this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmCompareFileTAG";
      txtDigits = this.optTAGV1;
      this.optTAGV1 = (RadioButton)txtDigits;
      this.ToolTip.SetToolTip(this.optTAGV1, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmCompareFileTAG";
      txtDigits = this.optTAGV2;
      this.optTAGV2 = (RadioButton)txtDigits;
      this.ToolTip.SetToolTip(this.optTAGV2, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmCompareFileTAG";
      txtDigits = this.chkReplaceUnderScore;
      this.chkReplaceUnderScore = (CheckBox)txtDigits;
      this.ToolTip.SetToolTip(this.chkReplaceUnderScore, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmCompareFileTAG";
      txtDigits = this.chkIgnoreCase;
      this.chkIgnoreCase = (CheckBox)txtDigits;
      this.ToolTip.SetToolTip(this.chkIgnoreCase, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
    }

    private void CompareFileTAGCB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.Items)
      {
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        var tag = (MP3)item.Tag;
        frmProg.lblInfo.Text = tag.CurrentFullName.Replace("&", "&&");
        string sLeft = ID3Functions.FormatReplacedByTag(tag, frmProg.String01, ByteType.FromObject(this.optTAGV1.Checked ? 1 : 2)) + tag.FI.Extension;

        if (this.chkReplaceUnderScore.Checked)
          sLeft = sLeft.Replace("<", "_")
                       .Replace(">", "_")
                       .Replace("|", "_")
                       .Replace("\"", "_")
                       .Replace("/", "_")
                       .Replace("*", "_")
                       .Replace("?", "_")
                       .Replace(":", "_").Trim(new char[] { ' ' });

        if (this.chkIgnoreCase.Checked)
          sLeft = sLeft.ToLower();

        if (StringType.StrCmp(sLeft, "", false) != 0)
        {
          tag.FileTAGCompare = false;
          item.BackColor = SystemColors.Window;
          item.ForeColor = SystemColors.WindowText;

          if (tag.Changed)
          {
            item.BackColor = Color.FromArgb(Declarations.objSettings.ColorChangedBack);
            item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorChangedText);
          }

          if (tag.Doubled)
          {
            item.BackColor = Color.FromArgb(Declarations.objSettings.ColorDoubleBack);
            item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorDoubleText);
          }

          if (this.chkIgnoreCase.Checked)
          {
            if (!tag.CurrentFullName.ToLower().EndsWith(sLeft))
            {
              tag.FileTAGCompare = true;
              item.BackColor = Color.FromArgb(Declarations.objSettings.ColorCompareBack);
              item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorCompareText);
            }
          }
          else if (!tag.CurrentFullName.EndsWith(sLeft))
          {
            tag.FileTAGCompare = true;
            item.BackColor = Color.FromArgb(Declarations.objSettings.ColorCompareBack);
            item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorCompareText);
          }
        }

        frmProg.ProgressBar.PerformStep();
      }
    }

    #endregion
  }
}