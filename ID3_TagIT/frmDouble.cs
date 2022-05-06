using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmDouble : Form
  {
    #region Local variables

    private bool vbooCancel;

    #endregion

    #region Events

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
      ArrayList list = new ArrayList(this.MainForm.MP3View.Items.Count);
      ArrayList list2 = new ArrayList(this.MainForm.MP3View.Items.Count);
      ArrayList list4 = new ArrayList(this.MainForm.MP3View.Items.Count);
      ArrayList list3 = new ArrayList(this.MainForm.MP3View.Items.Count);

      if (this.optAT.Checked)
        Declarations.objSettings.CompareMethod = 1;

      if (this.optATA.Checked)
        Declarations.objSettings.CompareMethod = 2;

      if (this.optAD.Checked)
        Declarations.objSettings.CompareMethod = 3;

      if (this.optTAGV1.Checked)
        Declarations.objSettings.CompareTAGVersion = 1;
      else
        Declarations.objSettings.CompareTAGVersion = 2;

      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
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
              return;

            tag = (MP3)this.MainForm.MP3View.Items[num].Tag;
            list2.Add(tag.V1TAG.Artist);
            list4.Add(tag.V1TAG.Title);
            this.ProgressBar.PerformStep();

            if ((num % 50) == 0)
              Application.DoEvents();
          }
        }
        else if (this.optTAGV2.Checked)
        {
          int num13 = this.MainForm.MP3View.Items.Count - 1;

          for (num = 0; num <= num13; num++)
          {
            if (this.vbooCancel)
              return;

            tag = (MP3)this.MainForm.MP3View.Items[num].Tag;

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
              Application.DoEvents();
          }
        }

        this.lblStatus.Text = StringType.FromObject(Declarations.objResources.ResStrings["DoubleComparing"]);
        this.ProgressBar.Value = 0;
        this.MainForm.MP3View.BeginUpdate();

        int num12 = this.MainForm.MP3View.Items.Count - 2;

        for (num = 0; num <= num12; num++)
        {
          if (this.vbooCancel)
            return;

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
            Application.DoEvents();
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
              return;

            tag = (MP3)this.MainForm.MP3View.Items[num].Tag;
            list2.Add(tag.V1TAG.Artist);
            list4.Add(tag.V1TAG.Title);
            list.Add(tag.V1TAG.Album);

            this.ProgressBar.PerformStep();

            if ((num % 50) == 0)
              Application.DoEvents();
          }
        }
        else if (this.optTAGV2.Checked)
        {
          int num9 = this.MainForm.MP3View.Items.Count - 1;

          for (num = 0; num <= num9; num++)
          {
            if (this.vbooCancel)
              return;

            tag = (MP3)this.MainForm.MP3View.Items[num].Tag;

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
              Application.DoEvents();
          }
        }

        this.lblStatus.Text = StringType.FromObject(Declarations.objResources.ResStrings["DoubleComparing"]);
        this.ProgressBar.Value = 0;
        this.MainForm.MP3View.BeginUpdate();

        int num8 = this.MainForm.MP3View.Items.Count - 2;

        for (num = 0; num <= num8; num++)
        {
          if (this.vbooCancel)
            return;

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
            Application.DoEvents();
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
            return;

          tag = (MP3)this.MainForm.MP3View.Items[num].Tag;

          if (tag.AudioCheckSum == 0)
            tag.CalcAudioCheckSum();

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
            return;

          tag = (MP3)this.MainForm.MP3View.Items[num].Tag;

          if (this.MainForm.MP3View.Columns.Contains(this.MainForm.colHAudioCheckSum))
            this.MainForm.MP3View.Items[num].SubItems[this.MainForm.colHAudioCheckSum.Index].Text = StringType.FromObject(tag.AudioCheckSum != 0 ? tag.AudioCheckSum.ToString() : "");

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
            Application.DoEvents();
        }

        if (this.MainForm.MP3View.Columns.Contains(this.MainForm.colHAudioCheckSum))
          this.MainForm.MP3View.Items[this.MainForm.MP3View.Items.Count - 1].SubItems[this.MainForm.colHAudioCheckSum.Index].Text = StringType.FromObject(Interaction.IIf(ObjectType.ObjTst(LateBinding.LateGet(this.MainForm.MP3View.Items[this.MainForm.MP3View.Items.Count - 1].Tag, null, "AudioCheckSum", new object[0], null, null), 0, false) != 0, LateBinding.LateGet(this.MainForm.MP3View.Items[this.MainForm.MP3View.Items.Count - 1].Tag, null, "AudioCheckSum", new object[0], null, null).ToString(), ""));

        Application.DoEvents();
        this.MainForm.MP3View.EndUpdate();
      }

      this.GroupBox.Enabled = false;
      this.btnOK.Enabled = true;
      this.Close();
    }

    private void frmDouble_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
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
        this.optTAGV1.Checked = true;
      else
        this.optTAGV2.Checked = true;

      this.AddToolTips();
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmDouble";
      Control objControl = this.optTAGV1;

      this.optTAGV1 = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.optTAGV1, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmDouble";
      objControl = this.optTAGV2;

      this.optTAGV2 = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.optTAGV2, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmDouble";
      objControl = this.optAD;

      this.optAD = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.optAD, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmDouble";
      objControl = this.optATA;

      this.optATA = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.optATA, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmDouble";
      objControl = this.optAT;

      this.optAT = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.optAT, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
    }

    #endregion
  }
}