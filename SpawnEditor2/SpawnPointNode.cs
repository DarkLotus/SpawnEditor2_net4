// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.SpawnPointNode
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Windows.Forms;

namespace SpawnEditor2
{
  public class SpawnPointNode : TreeNode
  {
    private SpawnPoint _Spawn;
    public bool Filtered;
    public bool Highlighted;

    public SpawnPoint Spawn
    {
      get
      {
        return this._Spawn;
      }
    }

    public SpawnPointNode(SpawnPoint Spawn)
    {
      this._Spawn = Spawn;
      this.UpdateNode();
    }

    public void UpdateNode()
    {
      this.Text = this._Spawn.SpawnName;
      this.Nodes.Clear();
      foreach (SpawnObject SpawnObject in this._Spawn.SpawnObjects)
        this.Nodes.Add((TreeNode) new SpawnObjectNode(SpawnObject));
    }
  }
}
