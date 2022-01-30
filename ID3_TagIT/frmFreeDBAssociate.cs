using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmFreeDBAssociate : Form
  {
    #region Designer

    private Button btnCancel;
    private Button btnDown;
    private Button btnOK;
    private Button btnUp;
    private ColumnHeader Filename;
    private ColumnHeader FreeDB;
    private Label Label1;
    private Label Label2;
    public Label lblGenre;
    private Label lblInfo;
    public Label lblYear;
    public ListView lvwFiles;
    public ListView lvwFreeDB;
    private IContainer components;
    private frmMain MainForm;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.lvwFreeDB = new System.Windows.Forms.ListView();
      this.FreeDB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lblInfo = new System.Windows.Forms.Label();
      this.lvwFiles = new System.Windows.Forms.ListView();
      this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnUp = new System.Windows.Forms.Button();
      this.btnDown = new System.Windows.Forms.Button();
      this.Label1 = new System.Windows.Forms.Label();
      this.lblGenre = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.lblYear = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(632, 429);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 16;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(504, 429);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 15;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lvwFreeDB
      // 
      this.lvwFreeDB.CheckBoxes = true;
      this.lvwFreeDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.FreeDB });
      this.lvwFreeDB.GridLines = true;
      this.lvwFreeDB.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lvwFreeDB.LabelWrap = false;
      this.lvwFreeDB.Location = new System.Drawing.Point(384, 40);
      this.lvwFreeDB.MultiSelect = false;
      this.lvwFreeDB.Name = "lvwFreeDB";
      this.lvwFreeDB.Size = new System.Drawing.Size(368, 360);
      this.lvwFreeDB.TabIndex = 17;
      this.lvwFreeDB.UseCompatibleStateImageBehavior = false;
      this.lvwFreeDB.View = System.Windows.Forms.View.Details;
      this.lvwFreeDB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvwFreeDB_ItemCheck);
      // 
      // FreeDB
      // 
      this.FreeDB.Text = "FreeDB entry";
      this.FreeDB.Width = 360;
      // 
      // lblInfo
      // 
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 16);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(744, 16);
      this.lblInfo.TabIndex = 18;
      this.lblInfo.Text = "Associate the selected files with entries found in the FreeDB. Only checked files" +
    " will be tagged.";
      // 
      // lvwFiles
      // 
      this.lvwFiles.CheckBoxes = true;
      this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.Filename });
      this.lvwFiles.FullRowSelect = true;
      this.lvwFiles.GridLines = true;
      this.lvwFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lvwFiles.Location = new System.Drawing.Point(8, 40);
      this.lvwFiles.Name = "lvwFiles";
      this.lvwFiles.Size = new System.Drawing.Size(368, 360);
      this.lvwFiles.TabIndex = 19;
      this.lvwFiles.UseCompatibleStateImageBehavior = false;
      this.lvwFiles.View = System.Windows.Forms.View.Details;
      // 
      // Filename
      // 
      this.Filename.Text = "Filename";
      this.Filename.Width = 358;
      // 
      // btnUp
      // 
      this.btnUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnUp.Location = new System.Drawing.Point(32, 429);
      this.btnUp.Name = "btnUp";
      this.btnUp.Size = new System.Drawing.Size(152, 24);
      this.btnUp.TabIndex = 21;
      this.btnUp.Text = "File &up";
      this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
      // 
      // btnDown
      // 
      this.btnDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnDown.Location = new System.Drawing.Point(192, 429);
      this.btnDown.Name = "btnDown";
      this.btnDown.Size = new System.Drawing.Size(152, 24);
      this.btnDown.TabIndex = 20;
      this.btnDown.Text = "File &down";
      this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
      // 
      // Label1
      // 
      this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label1.Location = new System.Drawing.Point(8, 408);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(48, 16);
      this.Label1.TabIndex = 22;
      this.Label1.Text = "Genre:";
      // 
      // lblGenre
      // 
      this.lblGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblGenre.Location = new System.Drawing.Point(56, 408);
      this.lblGenre.Name = "lblGenre";
      this.lblGenre.Size = new System.Drawing.Size(104, 16);
      this.lblGenre.TabIndex = 23;
      // 
      // Label2
      // 
      this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label2.Location = new System.Drawing.Point(200, 408);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(40, 16);
      this.Label2.TabIndex = 24;
      this.Label2.Text = "Year:";
      // 
      // lblYear
      // 
      this.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblYear.Location = new System.Drawing.Point(240, 408);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new System.Drawing.Size(136, 16);
      this.lblYear.TabIndex = 25;
      // 
      // frmFreeDBAssociate
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(762, 461);
      this.ControlBox = false;
      this.Controls.Add(this.lblYear);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.lblGenre);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.btnUp);
      this.Controls.Add(this.btnDown);
      this.Controls.Add(this.lvwFiles);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.lvwFreeDB);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "frmFreeDBAssociate";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "FreeDB";
      this.ResumeLayout(false);
    }

    public frmFreeDBAssociate(frmMain frmM)
    {
      base.Load += new EventHandler(this.frmFreeDBAssociate_Load);
      this.InitializeComponent();
      this.MainForm = frmM;
    }

    #endregion

    #region Events

    private void btnDown_Click(object sender, EventArgs e)
    {
      this.lvwFiles.BeginUpdate();

      if (this.lvwFiles.SelectedItems.Count == 1)
      {
        ListViewItem item = this.lvwFiles.SelectedItems[0];

        if (item.Index == (this.lvwFiles.Items.Count - 1))
          this.lvwFiles.EndUpdate();
        else
        {
          ListViewItem item2 = (ListViewItem)item.Clone();

          if (item.Checked)
            item2.Checked = true;
          else
            item2.Checked = false;

          this.lvwFiles.Items.Insert(item.Index + 2, item2);
          item2.Selected = true;
          item2.Focused = true;
          this.lvwFiles.Focus();
          this.lvwFiles.Items.Remove(item);
          this.lvwFiles.EndUpdate();
        }
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      frmFreeDB owner = (frmFreeDB)this.Owner;
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      int num2 = this.lvwFreeDB.Items.Count - 1;

      for (int i = 0; i <= num2; i++)
        owner.alstFilesToTAG.Add(RuntimeHelpers.GetObjectValue(this.lvwFiles.Items[i].Clone()));

      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Close();
    }

    private void btnUp_Click(object sender, EventArgs e)
    {
      this.lvwFiles.BeginUpdate();

      if (this.lvwFiles.SelectedItems.Count == 1)
      {
        ListViewItem item = this.lvwFiles.SelectedItems[0];

        if (item.Index == 0)
          this.lvwFiles.EndUpdate();
        else
        {
          ListViewItem item2 = (ListViewItem)item.Clone();

          if (item.Checked)
            item2.Checked = true;
          else
            item2.Checked = false;

          this.lvwFiles.Items.Insert(item.Index - 1, item2);
          item2.Selected = true;
          item2.Focused = true;
          this.lvwFiles.Focus();
          this.lvwFiles.Items.Remove(item);
          this.lvwFiles.EndUpdate();
        }
      }
    }

    private void frmFreeDBAssociate_Load(object sender, EventArgs e)
    {
      IEnumerator enumerator = null;
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);

      try
      {
        enumerator = this.lvwFiles.Items.GetEnumerator();

        while (enumerator.MoveNext())
        {
          ListViewItem current = (ListViewItem)enumerator.Current;
          current.Checked = true;
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          ((IDisposable)enumerator).Dispose();
      }
    }

    private void lvwFreeDB_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.NewValue == CheckState.Checked)
        e.NewValue = CheckState.Unchecked;
    }

    #endregion
  }
}