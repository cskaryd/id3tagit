using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmFreeDBAssociate : Form
  {
    private Button btnCancel;
    private Button btnDown;
    private Button btnOK;
    private Button btnUp;
    private ColumnHeader Filename;
    private ColumnHeader FreeDB;
    private Label Label1;
    private Label Label2;
    private Label lblGenre;
    private Label lblInfo;
    private Label lblYear;
    private ListView lvwFiles;
    private ListView lvwFreeDB;
    private IContainer components;
    private frmMain MainForm;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.lvwFreeDB = new ListView();
      this.FreeDB = new ColumnHeader();
      this.lblInfo = new Label();
      this.lvwFiles = new ListView();
      this.Filename = new ColumnHeader();
      this.btnUp = new Button();
      this.btnDown = new Button();
      this.Label1 = new Label();
      this.lblGenre = new Label();
      this.Label2 = new Label();
      this.lblYear = new Label();
      this.SuspendLayout();
      this.btnCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      this.btnCancel.Location = new Point(0x278, 0x1ad);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(120, 0x18);
      this.btnCancel.TabIndex = 0x10;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
      this.btnOK.ImeMode = ImeMode.NoControl;
      this.btnOK.Location = new Point(0x1f8, 0x1ad);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(120, 0x18);
      this.btnOK.TabIndex = 15;
      this.btnOK.Text = "&OK";
      this.lvwFreeDB.CheckBoxes = true;
      this.lvwFreeDB.Columns.AddRange(new ColumnHeader[] { this.FreeDB });
      this.lvwFreeDB.GridLines = true;
      this.lvwFreeDB.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvwFreeDB.LabelWrap = false;
      this.lvwFreeDB.Location = new Point(0x180, 40);
      this.lvwFreeDB.MultiSelect = false;
      this.lvwFreeDB.Name = "lvwFreeDB";
      this.lvwFreeDB.Size = new Size(0x170, 360);
      this.lvwFreeDB.TabIndex = 0x11;
      this.lvwFreeDB.View = View.Details;
      this.FreeDB.Text = "FreeDB entry";
      this.FreeDB.Width = 360;
      this.lblInfo.ImeMode = ImeMode.NoControl;
      this.lblInfo.Location = new Point(8, 0x10);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new Size(0x2e8, 0x10);
      this.lblInfo.TabIndex = 0x12;
      this.lblInfo.Text = "Associate the selected files with entries found in the FreeDB. Only checked files will be tagged.";
      this.lvwFiles.CheckBoxes = true;
      this.lvwFiles.Columns.AddRange(new ColumnHeader[] { this.Filename });
      this.lvwFiles.FullRowSelect = true;
      this.lvwFiles.GridLines = true;
      this.lvwFiles.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvwFiles.Location = new Point(8, 40);
      this.lvwFiles.Name = "lvwFiles";
      this.lvwFiles.Size = new Size(0x170, 360);
      this.lvwFiles.TabIndex = 0x13;
      this.lvwFiles.View = View.Details;
      this.Filename.Text = "Filename";
      this.Filename.Width = 0x166;
      this.btnUp.ImeMode = ImeMode.NoControl;
      this.btnUp.Location = new Point(0x20, 0x1ad);
      this.btnUp.Name = "btnUp";
      this.btnUp.Size = new Size(0x98, 0x18);
      this.btnUp.TabIndex = 0x15;
      this.btnUp.Text = "File &up";
      this.btnDown.ImeMode = ImeMode.NoControl;
      this.btnDown.Location = new Point(0xc0, 0x1ad);
      this.btnDown.Name = "btnDown";
      this.btnDown.Size = new Size(0x98, 0x18);
      this.btnDown.TabIndex = 20;
      this.btnDown.Text = "File &down";
      this.Label1.ImeMode = ImeMode.NoControl;
      this.Label1.Location = new Point(8, 0x198);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(0x30, 0x10);
      this.Label1.TabIndex = 0x16;
      this.Label1.Text = "Genre:";
      this.lblGenre.ImeMode = ImeMode.NoControl;
      this.lblGenre.Location = new Point(0x38, 0x198);
      this.lblGenre.Name = "lblGenre";
      this.lblGenre.Size = new Size(0x68, 0x10);
      this.lblGenre.TabIndex = 0x17;
      this.Label2.ImeMode = ImeMode.NoControl;
      this.Label2.Location = new Point(200, 0x198);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(40, 0x10);
      this.Label2.TabIndex = 0x18;
      this.Label2.Text = "Year:";
      this.lblYear.ImeMode = ImeMode.NoControl;
      this.lblYear.Location = new Point(240, 0x198);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new Size(0x88, 0x10);
      this.lblYear.TabIndex = 0x19;
      this.btnUp.Click += new EventHandler(this.btnUp_Click);
      this.btnDown.Click += new EventHandler(this.btnDown_Click);
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.lvwFreeDB.ItemCheck += new ItemCheckEventHandler(this.lvwFreeDB_ItemCheck);
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new Size(0x2fa, 0x1cd);
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
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = "frmFreeDBAssociate";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "FreeDB";
      this.ResumeLayout(false);
    }

    public frmFreeDBAssociate(frmMain frmM)
    {
      base.Load += new EventHandler(this.frmFreeDBAssociate_Load);
      this.InitializeComponent();
      this.MainForm = frmM;
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
      this.lvwFiles.BeginUpdate();
      if (this.lvwFiles.SelectedItems.Count == 1)
      {
        ListViewItem item = this.lvwFiles.SelectedItems[0];
        if (item.Index == (this.lvwFiles.Items.Count - 1))
        {
          this.lvwFiles.EndUpdate();
        }
        else
        {
          ListViewItem item2 = (ListViewItem)item.Clone();
          if (item.Checked)
          {
            item2.Checked = true;
          }
          else
          {
            item2.Checked = false;
          }
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
      Main.SaveFormSettings(ref form);
      int num2 = this.lvwFreeDB.Items.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        owner.alstFilesToTAG.Add(RuntimeHelpers.GetObjectValue(this.lvwFiles.Items[i].Clone()));
      }
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
        {
          this.lvwFiles.EndUpdate();
        }
        else
        {
          ListViewItem item2 = (ListViewItem)item.Clone();
          if (item.Checked)
          {
            item2.Checked = true;
          }
          else
          {
            item2.Checked = false;
          }
          this.lvwFiles.Items.Insert(item.Index - 1, item2);
          item2.Selected = true;
          item2.Focused = true;
          this.lvwFiles.Focus();
          this.lvwFiles.Items.Remove(item);
          this.lvwFiles.EndUpdate();
        }
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    private void frmFreeDBAssociate_Load(object sender, EventArgs e)
    {
      IEnumerator enumerator = null;
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
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
  }
}