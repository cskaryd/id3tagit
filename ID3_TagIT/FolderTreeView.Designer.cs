namespace ID3_TagIT
{
  partial class FolderTreeView
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ImageList imgFileTreeView;
    private System.Windows.Forms.ProgressBar prgFileTreeView;
    private System.Windows.Forms.TreeView trvFileTreeView;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
        components.Dispose();

      base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderTreeView));
      this.imgFileTreeView = new System.Windows.Forms.ImageList(this.components);
      this.prgFileTreeView = new System.Windows.Forms.ProgressBar();
      this.trvFileTreeView = new System.Windows.Forms.TreeView();
      this.SuspendLayout();
      // 
      // imgFileTreeView
      // 
      this.imgFileTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFileTreeView.ImageStream")));
      this.imgFileTreeView.TransparentColor = System.Drawing.Color.Transparent;
      this.imgFileTreeView.Images.SetKeyName(0, "computer-7.png");
      this.imgFileTreeView.Images.SetKeyName(1, "drive-7.png");
      this.imgFileTreeView.Images.SetKeyName(2, "folder-7.png");
      // 
      // prgFileTreeView
      // 
      this.prgFileTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.prgFileTreeView.Location = new System.Drawing.Point(0, 399);
      this.prgFileTreeView.Name = "prgFileTreeView";
      this.prgFileTreeView.Size = new System.Drawing.Size(264, 23);
      this.prgFileTreeView.TabIndex = 0;
      this.prgFileTreeView.Visible = false;
      // 
      // trvFileTreeView
      // 
      this.trvFileTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trvFileTreeView.ImageIndex = 0;
      this.trvFileTreeView.ImageList = this.imgFileTreeView;
      this.trvFileTreeView.ItemHeight = 18;
      this.trvFileTreeView.LabelEdit = true;
      this.trvFileTreeView.Location = new System.Drawing.Point(0, 0);
      this.trvFileTreeView.Name = "trvFileTreeView";
      this.trvFileTreeView.SelectedImageIndex = 0;
      this.trvFileTreeView.Size = new System.Drawing.Size(264, 422);
      this.trvFileTreeView.TabIndex = 1;
      this.trvFileTreeView.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.trvFileTreeView_BeforeLabelEdit);
      this.trvFileTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.trvFileTreeView_AfterLabelEdit);
      this.trvFileTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvFileTreeView_BeforeExpand);
      this.trvFileTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvFileTreeView_BeforeSelect);
      this.trvFileTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvFileTreeView_AfterSelect);
      // 
      // FolderTreeView
      // 
      this.Controls.Add(this.prgFileTreeView);
      this.Controls.Add(this.trvFileTreeView);
      this.Name = "FolderTreeView";
      this.Size = new System.Drawing.Size(264, 422);
      this.Load += new System.EventHandler(this.FileTreeView_Load);
      this.ResumeLayout(false);

    }

    #endregion
  }
}