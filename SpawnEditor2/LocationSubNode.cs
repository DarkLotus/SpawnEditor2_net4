// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.LocationSubNode
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Windows.Forms;

namespace SpawnEditor2
{
  public class LocationSubNode : TreeNode
  {
    private object _Node;
    private WorldMap _Map;

    public object Node
    {
      get
      {
        return this._Node;
      }
    }

    public WorldMap Map
    {
      get
      {
        return this._Map;
      }
    }

    public LocationSubNode(object node, WorldMap map)
    {
      this._Node = node;
      this._Map = map;
      this.UpdateNode();
    }

    public void UpdateNode()
    {
      this.Nodes.Clear();
      if (this._Node is ChildNode)
      {
        this.Text = (this._Node as ChildNode).Name;
      }
      else
      {
        if (!(this._Node is ParentNode))
          return;
        ParentNode parentNode = this._Node as ParentNode;
        this.Text = parentNode.Name;
        if (parentNode.Children == null)
          return;
        foreach (object node in parentNode.Children)
          this.Nodes.Add((TreeNode) new LocationSubNode(node, this.Map));
      }
    }
  }
}
