// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.RegionFacetNode
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Windows.Forms;

namespace SpawnEditor2
{
  public class RegionFacetNode : TreeNode
  {
    private WorldMap _Facet;

    public WorldMap Facet
    {
      get
      {
        return this._Facet;
      }
    }

    public RegionFacetNode(WorldMap facet)
    {
      this._Facet = facet;
      this.UpdateNode();
    }

    public void UpdateNode()
    {
      this.Text = this._Facet.ToString();
    }
  }
}
