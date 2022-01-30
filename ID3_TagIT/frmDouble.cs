using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmDouble : Form
  {
    #region Designer

    private Button btnCancel;
    private Button btnOK;
    private System.Windows.Forms.GroupBox GroupBox;
    private Label lblStatus;
    private RadioButton optAD;
    private RadioButton optAT;
    private RadioButton optATA;
    private RadioButton optTAGV1;
    private RadioButton optTAGV2;
    private Panel Panel1;
    private Panel Panel2;
    private System.Windows.Forms.ProgressBar ProgressBar;
    private System.Windows.Forms.ToolTip ToolTip;
    private IContainer components;
    private frmMain MainForm;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.GroupBox = new System.Windows.Forms.GroupBox();
      this.lblStatus = new System.Windows.Forms.Label();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.Panel1 = new System.Windows.Forms.Panel();
      this.optTAGV1 = new System.Windows.Forms.RadioButton();
      this.optTAGV2 = new System.Windows.Forms.RadioButton();
      this.Panel2 = new System.Windows.Forms.Panel();
      this.optAD = new System.Windows.Forms.RadioButton();
      this.optATA = new System.Windows.Forms.RadioButton();
      this.optAT = new System.Windows.Forms.RadioButton();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.GroupBox.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(352, 256);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(112, 24);
      this.btnCancel.TabIndex = 19;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(232, 256);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(112, 24);
      this.btnOK.TabIndex = 18;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // GroupBox
      // 
      this.GroupBox.Controls.Add(this.lblStatus);
      this.GroupBox.Controls.Add(this.ProgressBar);
      this.GroupBox.Enabled = false;
      this.GroupBox.Location = new System.Drawing.Point(8, 168);
      this.GroupBox.Name = "GroupBox";
      this.GroupBox.Size = new System.Drawing.Size(464, 80);
      this.GroupBox.TabIndex = 20;
      this.GroupBox.TabStop = false;
      this.GroupBox.Text = "Progress ...";
      // 
      // lblStatus
      // 
      this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblStatus.Location = new System.Drawing.Point(8, 24);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(448, 16);
      this.lblStatus.TabIndex = 1;
      this.lblStatus.Text = "Status";
      // 
      // ProgressBar
      // 
      this.ProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ProgressBar.Location = new System.Drawing.Point(8, 48);
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Size = new System.Drawing.Size(448, 16);
      this.ProgressBar.TabIndex = 0;
      // 
      // Panel1
      // 
      this.Panel1.Controls.Add(this.optTAGV1);
      this.Panel1.Controls.Add(this.optTAGV2);
      this.Panel1.Location = new System.Drawing.Point(8, 104);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new System.Drawing.Size(464, 56);
      this.Panel1.TabIndex = 22;
      // 
      // optTAGV1
      // 
      this.optTAGV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optTAGV1.Location = new System.Drawing.Point(8, 8);
      this.optTAGV1.Name = "optTAGV1";
      this.optTAGV1.Size = new System.Drawing.Size(256, 18);
      this.optTAGV1.TabIndex = 5;
      this.optTAGV1.Text = "Use TAG Ver. 1 for comparing";
      // 
      // optTAGV2
      // 
      this.optTAGV2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optTAGV2.Location = new System.Drawing.Point(8, 32);
      this.optTAGV2.Name = "optTAGV2";
      this.optTAGV2.Size = new System.Drawing.Size(256, 18);
      this.optTAGV2.TabIndex = 4;
      this.optTAGV2.Text = "Use TAG Ver. 2 for comparing";
      // 
      // Panel2
      // 
      this.Panel2.Controls.Add(this.optAD);
      this.Panel2.Controls.Add(this.optATA);
      this.Panel2.Controls.Add(this.optAT);
      this.Panel2.Location = new System.Drawing.Point(8, 8);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new System.Drawing.Size(464, 88);
      this.Panel2.TabIndex = 23;
      // 
      // optAD
      // 
      this.optAD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAD.Location = new System.Drawing.Point(8, 60);
      this.optAD.Name = "optAD";
      this.optAD.Size = new System.Drawing.Size(424, 18);
      this.optAD.TabIndex = 8;
      this.optAD.Text = "Find files with same audio data (LENGTHLY operation)";
      // 
      // optATA
      // 
      this.optATA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optATA.Location = new System.Drawing.Point(8, 36);
      this.optATA.Name = "optATA";
      this.optATA.Size = new System.Drawing.Size(424, 18);
      this.optATA.TabIndex = 7;
      this.optATA.Text = "Find files with same artist, title, album";
      // 
      // optAT
      // 
      this.optAT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAT.Location = new System.Drawing.Point(8, 12);
      this.optAT.Name = "optAT";
      this.optAT.Size = new System.Drawing.Size(424, 18);
      this.optAT.TabIndex = 6;
      this.optAT.Text = "Find files with same artist and title";
      // 
      // frmDouble
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(480, 288);
      this.ControlBox = false;
      this.Controls.Add(this.Panel2);
      this.Controls.Add(this.Panel1);
      this.Controls.Add(this.GroupBox);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "frmDouble";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Find duplicate files";
      this.GroupBox.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    public frmDouble(frmMain Main)
    {
      base.Load += new EventHandler(this.frmDouble_Load);
      this.vbooCancel = false;
      this.InitializeComponent();
      this.MainForm = Main;
    }

    #endregion

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
            this.MainForm.MP3View.Items[num].SubItems[this.MainForm.colHAudioCheckSum.Index].Text = StringType.FromObject(Interaction.IIf(tag.AudioCheckSum != 0, tag.AudioCheckSum.ToString(), ""));

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
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
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