// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.ObjectData
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  [Serializable]
  public class ObjectData
  {
    public int X;
    public int Y;
    public int Map;
    public string Name;

    public ObjectData(int x, int y, int map, string name)
    {
      this.X = x;
      this.Y = y;
      this.Map = map;
      this.Name = name;
    }

    public ObjectData()
    {
    }

    public override string ToString()
    {
      return this.Name;
    }
  }
}
