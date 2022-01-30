namespace ID3_TagIT
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Resources;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class frmAbout : Form
    {
        [AccessedThroughProperty("btnOK")]
        private Button _btnOK;
        [AccessedThroughProperty("lblCopyRight")]
        private Label _lblCopyRight;
        [AccessedThroughProperty("lblHome")]
        private Label _lblHome;
        [AccessedThroughProperty("lblLink")]
        private LinkLabel _lblLink;
        [AccessedThroughProperty("lblVersion")]
        private Label _lblVersion;
        [AccessedThroughProperty("PictureBox")]
        private System.Windows.Forms.PictureBox _PictureBox;
        private IContainer components;

        public frmAbout()
        {
            base.Load += new EventHandler(this.frmAbout_Load);
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            Form formToCheck = this;
            Main.WindowsXPCheck(ref formToCheck);
            this.lblVersion.Text = "Version: " + Application.ProductVersion.ToString().Substring(0, Application.ProductVersion.ToString().LastIndexOf("."));
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ResourceManager manager = new ResourceManager(typeof(frmAbout));
            this.lblVersion = new Label();
            this.lblCopyRight = new Label();
            this.lblHome = new Label();
            this.btnOK = new Button();
            this.lblLink = new LinkLabel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            this.lblVersion.BackColor = Color.Transparent;
            this.lblVersion.ImeMode = ImeMode.NoControl;
            Point point = new Point(40, 0x68);
            this.lblVersion.Location = point;
            this.lblVersion.Name = "lblVersion";
            Size size = new Size(0x130, 0x10);
            this.lblVersion.Size = size;
            this.lblVersion.TabIndex = 1;
            this.lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            this.lblCopyRight.BackColor = Color.Transparent;
            this.lblCopyRight.ImeMode = ImeMode.NoControl;
            point = new Point(40, 160);
            this.lblCopyRight.Location = point;
            this.lblCopyRight.Name = "lblCopyRight";
            size = new Size(0x130, 0x10);
            this.lblCopyRight.Size = size;
            this.lblCopyRight.TabIndex = 2;
            this.lblCopyRight.Text = "Copyright 2000-2004 by Michael Pluemper";
            this.lblCopyRight.TextAlign = ContentAlignment.MiddleCenter;
            this.lblHome.BackColor = Color.Transparent;
            this.lblHome.ImeMode = ImeMode.NoControl;
            point = new Point(0x60, 0x88);
            this.lblHome.Location = point;
            this.lblHome.Name = "lblHome";
            size = new Size(0x44, 0x10);
            this.lblHome.Size = size;
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "Homepage:";
            this.lblHome.TextAlign = ContentAlignment.MiddleCenter;
            this.btnOK.BackColor = SystemColors.Control;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.ImeMode = ImeMode.NoControl;
            point = new Point(0x80, 0xc0);
            this.btnOK.Location = point;
            this.btnOK.Name = "btnOK";
            size = new Size(120, 0x18);
            this.btnOK.Size = size;
            this.btnOK.TabIndex = 0x10;
            this.btnOK.Text = "&OK";
            this.lblLink.BackColor = Color.Transparent;
            this.lblLink.ImeMode = ImeMode.NoControl;
            LinkArea area = new LinkArea(0, 0x17);
            this.lblLink.LinkArea = area;
            point = new Point(0xa8, 0x88);
            this.lblLink.Location = point;
            this.lblLink.Name = "lblLink";
            size = new Size(120, 0x10);
            this.lblLink.Size = size;
            this.lblLink.TabIndex = 0x11;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "http://www.id3-tagit.de";
            this.PictureBox.BackColor = Color.White;
            this.PictureBox.Image = (Image) manager.GetObject("PictureBox.Image");
            point = new Point(0, 0);
            this.PictureBox.Location = point;
            this.PictureBox.Name = "PictureBox";
            size = new Size(0x178, 0x70);
            this.PictureBox.Size = size;
            this.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0x12;
            this.PictureBox.TabStop = false;
            this.AcceptButton = this.btnOK;
            size = new Size(5, 13);
            this.AutoScaleBaseSize = size;
            this.BackColor = Color.White;
            this.CancelButton = this.btnOK;
            size = new Size(0x17a, 0xe0);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "About ...";
            this.ResumeLayout(false);
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.lblLink.Text);
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
                }
                this._btnOK = value;
                if (this._btnOK != null)
                {
                }
            }
        }

        internal virtual Label lblCopyRight
        {
            get
            {
                return this._lblCopyRight;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblCopyRight != null)
                {
                }
                this._lblCopyRight = value;
                if (this._lblCopyRight != null)
                {
                }
            }
        }

        internal virtual Label lblHome
        {
            get
            {
                return this._lblHome;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblHome != null)
                {
                }
                this._lblHome = value;
                if (this._lblHome != null)
                {
                }
            }
        }

        internal virtual LinkLabel lblLink
        {
            get
            {
                return this._lblLink;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblLink != null)
                {
                    this._lblLink.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
                }
                this._lblLink = value;
                if (this._lblLink != null)
                {
                    this._lblLink.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
                }
            }
        }

        internal virtual Label lblVersion
        {
            get
            {
                return this._lblVersion;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._lblVersion != null)
                {
                }
                this._lblVersion = value;
                if (this._lblVersion != null)
                {
                }
            }
        }

        internal virtual System.Windows.Forms.PictureBox PictureBox
        {
            get
            {
                return this._PictureBox;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._PictureBox != null)
                {
                }
                this._PictureBox = value;
                if (this._PictureBox != null)
                {
                }
            }
        }
    }
}

