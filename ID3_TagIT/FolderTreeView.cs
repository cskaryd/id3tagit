using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class FolderTreeView : UserControl
  {
    private bool mNodeFound = false;

    public FolderTreeView()
    {
      InitializeComponent();
    }

    [Browsable(true)]
    [Category("Action")]
    public event NodeLabelEditEventHandler AfterLabelEdit;

    [Browsable(true)]
    [Category("Action")]
    public event TreeViewEventHandler AfterSelect;

    [Browsable(true)]
    [Category("Action")]
    public event NodeLabelEditEventHandler BeforeLabelEdit;

    [Browsable(true)]
    [Category("Action")]
    public event TreeViewCancelEventHandler BeforeSelect;

    public void RefreshView()
    {
      trvFileTreeView.Nodes.Clear();

      var drives = System.IO.DriveInfo.GetDrives();
      var rootNode = trvFileTreeView.Nodes.Add("This PC");

      rootNode.ImageIndex = 0;
      rootNode.SelectedImageIndex = 0;

      foreach (var drv in drives)
      {
        string nodeName = drv.Name;

        if (drv.IsReady)
          nodeName = string.Format("{0} ({1})", nodeName, drv.VolumeLabel);

        var dn = rootNode.Nodes.Add(nodeName);

        dn.Tag = drv.Name;
        dn.ImageIndex = 1;
        dn.SelectedImageIndex = 1;

        if (drv.IsReady)
        {
          var dirs = System.IO.Directory.GetDirectories(drv.Name).OrderBy(o => o);

          foreach (var dir in dirs)
          {
            var fn = dn.Nodes.Add(dir.Substring(drv.Name.Length));

            fn.Tag = dir;
            fn.ImageIndex = 2;
            fn.SelectedImageIndex = 2;
          }
        }
      }

      rootNode.Expand();
    }

    public void SelectNode(string NodeToSelect)
    {
      if (string.IsNullOrEmpty(NodeToSelect))
        return;

      mNodeFound = false;

      _SelectNode(NodeToSelect, 0, trvFileTreeView.Nodes);
    }

    public TreeNode SelectedNode
    {
      get
      {
        return trvFileTreeView.SelectedNode;
      }
    }

    private void FileTreeView_Load(object sender, EventArgs e)
    {
      RefreshView();
    }

    private void trvFileTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      if (AfterLabelEdit != null)
        AfterLabelEdit(this, e);
    }

    private void trvFileTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (AfterSelect != null)
        AfterSelect(this, e);
    }

    private void trvFileTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
      if (e.Node.Level == 0)
        return;

      this.Cursor = Cursors.WaitCursor;

      prgFileTreeView.Value = 0;
      prgFileTreeView.Minimum = 0;
      prgFileTreeView.Visible = true;
      prgFileTreeView.Maximum = e.Node.Nodes.Count;

      foreach (TreeNode n in e.Node.Nodes)
        _ExpandBranch(n);

      prgFileTreeView.Visible = false;
      this.Cursor = Cursors.Default;
    }

    private void trvFileTreeView_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      if (BeforeLabelEdit != null)
        BeforeLabelEdit(this, e);
    }

    private void trvFileTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
    {
      if (BeforeSelect != null && e.Node != null)
        BeforeSelect(this, e);
    }

    private void _ExpandBranch(TreeNode Node)
    {
      var loc = (string)Node.Tag;

      try
      {
        var dirs = System.IO.Directory.GetDirectories(loc).OrderBy(o => o);

        Node.Nodes.Clear();

        foreach (var dir in dirs)
        {
          var fn = Node.Nodes.Add(dir.Substring(loc.Length + 1));

          fn.Tag = dir;
          fn.ImageIndex = 2;
          fn.SelectedImageIndex = 2;

          if (prgFileTreeView.Value % 100 == 0)
            Application.DoEvents();
        }

        prgFileTreeView.Value++;
      }
      catch
      {
        // If we've got here, it's a directory we don't have access to...
      }
    }

    // FIXME - This is MASSIVELY inefficient.  But it works for now.
    private void _SelectNode(string NodeToSelect, int Depth, TreeNodeCollection NodesToSearch)
    {
      string[] nodeParts = new string[] { };

      if (!string.IsNullOrEmpty(NodeToSelect))
        nodeParts = NodeToSelect.Split('\\');

      string nodePart = string.Empty;

      for (int i = 0; i < Depth; i++)
        nodePart = string.Format("{0}\\{1}", nodePart, nodeParts[i]);

      if (nodePart.Length > 0)
        nodePart = nodePart.Substring(1);

      foreach (TreeNode _node in NodesToSearch)
      {
        if ((string)_node.Tag == nodePart)
          _ExpandBranch(_node);

        if ((string)_node.Tag == NodeToSelect)
        {
          mNodeFound = true;
          trvFileTreeView.SelectedNode = _node;
          return;
        }

        if (_node.Nodes != null && _node.Nodes.Count > 0)
        {
          _SelectNode(NodeToSelect, Depth + 1, _node.Nodes);

          if (mNodeFound)
            return;
        }
      }
    }
  }
}