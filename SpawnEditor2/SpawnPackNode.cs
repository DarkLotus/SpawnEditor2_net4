// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.SpawnPackNode
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Collections;
using System.Windows.Forms;

namespace SpawnEditor2
{
  public class SpawnPackNode : TreeNode
  {
    private string _packName;

    public string PackName
    {
      get
      {
        return this._packName;
      }
      set
      {
        this._packName = value;
        this.Text = this._packName;
      }
    }

    public SpawnPackNode(string packName, CheckedListBox.ObjectCollection items)
    {
      this._packName = packName;
      this.UpdateNode(items);
    }

    public SpawnPackNode(string packName, ArrayList items)
    {
      this._packName = packName;
      this.UpdateNode(items);
    }

    public void UpdateNode(CheckedListBox.ObjectCollection items)
    {
      this.Text = this._packName;
      this.Nodes.Clear();
      if (items == null || items.Count <= 0)
        return;
      for (int index = 0; index < items.Count; ++index)
        this.Nodes.Add((TreeNode) new SpawnPackSubNode((string) items[index]));
    }

    public void UpdateNode(ArrayList items)
    {
      this.Text = this._packName;
      this.Nodes.Clear();
      if (items == null || items.Count <= 0)
        return;
      for (int index = 0; index < items.Count; ++index)
        this.Nodes.Add((TreeNode) new SpawnPackSubNode((string) items[index]));
    }
  }
}
