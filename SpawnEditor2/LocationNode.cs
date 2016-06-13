// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.LocationNode
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Windows.Forms;

namespace SpawnEditor2
{
  public class LocationNode : TreeNode
  {
    private LocationTree _LTree;

    public LocationNode(LocationTree ltree)
    {
      this._LTree = ltree;
      this.UpdateNode();
    }

    public void UpdateNode()
    {
      this.Text = this._LTree.Map.ToString();
      this.Nodes.Clear();
      ParentNode root = this._LTree.Root;
      if (root == null || root.Children == null)
        return;
      foreach (object node in root.Children)
        this.Nodes.Add((TreeNode) new LocationSubNode(node, this._LTree.Map));
    }
  }
}
