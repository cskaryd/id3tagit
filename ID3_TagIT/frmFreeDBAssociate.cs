namespace ID3_TagIT
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class frmFreeDBAssociate : Form
    {
        [AccessedThroughProperty("btnCancel")]
        private Button _btnCancel;
        [AccessedThroughProperty("btnDown")]
        private Button _btnDown;
        [AccessedThroughProperty("btnOK")]
        private Button _btnOK;
        [AccessedThroughProperty("btnUp")]
        private Button _btnUp;
        [AccessedThroughProperty("Filename")]
        private ColumnHeader _Filename;
        [AccessedThroughProperty("FreeDB")]
        private ColumnHeader _FreeDB;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("lblGenre")]
        private Label _lblGenre;
        [AccessedThroughProperty("lblInfo")]
        private Label _lblInfo;
        [AccessedThroughProperty("lblYear")]
        private Label _lblYear;
        [AccessedThroughProperty("lvwFiles")]
        private ListView _lvwFiles;
        [AccessedThroughProperty("lvwFreeDB")]
        private ListView _lvwFreeDB;
        private IContainer components;
        private frmMain MainForm;

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
                    ListViewItem item2 = (ListViewItem) item.Clone();
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
            frmFreeDB owner = (frmFreeDB) this.Owner;
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
                    ListViewItem item2 = (ListViewItem) item.Clone();
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
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmFreeDBAssociate_Load(object sender, EventArgs e)
        {
            IEnumerator enumerator;
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
                    ListViewItem current = (ListViewItem) enumerator.Current;
                    current.Checked = true;
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    ((IDisposable) enumerator).Dispose();
                }
            }
        }

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
            Point point = new Point(0x278, 0x1ad);
            this.btnCancel.Location = point;
            this.btnCancel.Name = "btnCancel";
            Size size = new Size(120, 0x18);
            this.btnCancel.Size = size;
            this.btnCancel.TabIndex = 0x10;
            this.btnCancel.Text = "&Cancel";
            this.btnOK.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.btnOK.ImeMode = ImeMode.NoControl;
            point = new Point(0x1f8, 0x1ad);
            this.btnOK.Location = point;
            this.btnOK.Name = "btnOK";
            size = new Size(120, 0x18);
            this.btnOK.Size = size;
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "&OK";
            this.lvwFreeDB.CheckBoxes = true;
            this.lvwFreeDB.Columns.AddRange(new ColumnHeader[] { this.FreeDB });
            this.lvwFreeDB.GridLines = true;
            this.lvwFreeDB.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.lvwFreeDB.LabelWrap = false;
            point = new Point(0x180, 40);
            this.lvwFreeDB.Location = point;
            this.lvwFreeDB.MultiSelect = false;
            this.lvwFreeDB.Name = "lvwFreeDB";
            size = new Size(0x170, 360);
            this.lvwFreeDB.Size = size;
            this.lvwFreeDB.TabIndex = 0x11;
            this.lvwFreeDB.View = View.Details;
            this.FreeDB.Text = "FreeDB entry";
            this.FreeDB.Width = 360;
            this.lblInfo.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x10);
            this.lblInfo.Location = point;
            this.lblInfo.Name = "lblInfo";
            size = new Size(0x2e8, 0x10);
            this.lblInfo.Size = size;
            this.lblInfo.TabIndex = 0x12;
            this.lblInfo.Text = "Associate the selected files with entries found in the FreeDB. Only checked files will be tagged.";
            this.lvwFiles.CheckBoxes = true;
            this.lvwFiles.Columns.AddRange(new ColumnHeader[] { this.Filename });
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.GridLines = true;
            this.lvwFiles.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            point = new Point(8, 40);
            this.lvwFiles.Location = point;
            this.lvwFiles.Name = "lvwFiles";
            size = new Size(0x170, 360);
            this.lvwFiles.Size = size;
            this.lvwFiles.TabIndex = 0x13;
            this.lvwFiles.View = View.Details;
            this.Filename.Text = "Filename";
            this.Filename.Width = 0x166;
            this.btnUp.ImeMode = ImeMode.NoControl;
            point = new Point(0x20, 0x1ad);
            this.btnUp.Location = point;
            this.btnUp.Name = "btnUp";
            size = new Size(0x98, 0x18);
            this.btnUp.Size = size;
            this.btnUp.TabIndex = 0x15;
            this.btnUp.Text = "File &up";
            this.btnDown.ImeMode = ImeMode.NoControl;
            point = new Point(0xc0, 0x1ad);
            this.btnDown.Location = point;
            this.btnDown.Name = "btnDown";
            size = new Size(0x98, 0x18);
            this.btnDown.Size = size;
            this.btnDown.TabIndex = 20;
            this.btnDown.Text = "File &down";
            this.Label1.ImeMode = ImeMode.NoControl;
            point = new Point(8, 0x198);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            size = new Size(0x30, 0x10);
            this.Label1.Size = size;
            this.Label1.TabIndex = 0x16;
            this.Label1.Text = "Genre:";
            this.lblGenre.ImeMode = ImeMode.NoControl;
            point = new Point(0x38, 0x198);
            this.lblGenre.Location = point;
            this.lblGenre.Name = "lblGenre";
            size = new Size(0x68, 0x10);
            this.lblGenre.Size = size;
            this.lblGenre.TabIndex = 0x17;
            this.Label2.ImeMode = ImeMode.NoControl;
            point = new Point(200, 0x198);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            size = new Size(40, 0x10);
            this.Label2.Size = size;
            this.Label2.TabIndex = 0x18;
            this.Label2.Text = "Year:";
            this.lblYear.ImeMode = ImeMode.NoControl;
            point = new Point(240, 0x198);
            this.lblYear.Location = point;
            this.lblYear.Name = "lblYear";
            size = new Size(0x88, 0x10);
            this.lblYear.Size = size;
            this.lblYear.TabIndex = 0x19;
            this.AcceptButton = this.btnOK;
            size = new Size(5, 13);
            this.AutoScaleBaseSize = size;
            this.CancelButton = this.btnCancel;
            size = new Size(0x2fa, 0x1cd);
            this.ClientSize = size;
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

        private void lvwFreeDB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
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

        internal virtual ColumnHeader Filename
        {
            get
            {
                return this._Filename;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Filename != null)
                {
                }
                this._Filename = value;
                if (this._Filename != null)
                {
                }
            }
        }

        internal virtual ColumnHeader FreeDB
        {
            get
            {
                return this._FreeDB;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._FreeDB != null)
                {
                }
                this._FreeDB = value;
                if (this._FreeDB != null)
                {
                }
            }
        }

        internal virtual Label Label1
        {
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Label1 != null)
                {
                }
                this._Label1 = value;
                if (this._Label1 != null)
                {
                }
            }
        }

        internal virtual Label Label2
        {
            get
            {
                return this._Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Label2 != null)
                {
                }
                this._Label2 = value;
                if (this._Label2 != null)
                {
                }
            }
        }

        internal virtual Label lblGenre
        {
            get
            {
                return this._lblGenre;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblGenre != null)
                {
                }
                this._lblGenre = value;
                if (this._lblGenre != null)
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

        internal virtual Label lblYear
        {
            get
            {
                return this._lblYear;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblYear != null)
                {
                }
                this._lblYear = value;
                if (this._lblYear != null)
                {
                }
            }
        }

        internal virtual ListView lvwFiles
        {
            get
            {
                return this._lvwFiles;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lvwFiles != null)
                {
                }
                this._lvwFiles = value;
                if (this._lvwFiles != null)
                {
                }
            }
        }

        internal virtual ListView lvwFreeDB
        {
            get
            {
                return this._lvwFreeDB;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lvwFreeDB != null)
                {
                    this._lvwFreeDB.ItemCheck -= new ItemCheckEventHandler(this.lvwFreeDB_ItemCheck);
                }
                this._lvwFreeDB = value;
                if (this._lvwFreeDB != null)
                {
                    this._lvwFreeDB.ItemCheck += new ItemCheckEventHandler(this.lvwFreeDB_ItemCheck);
                }
            }
        }
    }
}

