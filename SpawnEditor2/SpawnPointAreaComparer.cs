// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.SpawnPointAreaComparer
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Collections;

namespace SpawnEditor2
{
  public class SpawnPointAreaComparer : IComparer
  {
    public int Compare(object A, object B)
    {
      if (A is SpawnPointNode && B is SpawnPointNode)
        return ((SpawnPointNode) A).Spawn.Area - ((SpawnPointNode) B).Spawn.Area;
      return 0;
    }
  }
}
