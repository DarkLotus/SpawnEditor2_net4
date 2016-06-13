// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.RegionNode
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Windows.Forms;

namespace SpawnEditor2
{
  public class RegionNode : TreeNode
  {
    private Region _Region;

    public Region Region
    {
      get
      {
        return this._Region;
      }
    }

    public RegionNode(Region region)
    {
      this._Region = region;
      this.UpdateNode();
    }

    public void UpdateNode()
    {
      this.Text = this._Region.Name;
    }
  }
}
