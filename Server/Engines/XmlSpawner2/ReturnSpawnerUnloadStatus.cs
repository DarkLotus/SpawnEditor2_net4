// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.ReturnSpawnerUnloadStatus
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  [Serializable]
  public class ReturnSpawnerUnloadStatus : TransferMessage
  {
    public int ProcessedMaps;
    public int ProcessedSpawners;

    public ReturnSpawnerUnloadStatus(int nspawners, int nmaps)
    {
      this.ProcessedMaps = nmaps;
      this.ProcessedSpawners = nspawners;
    }

    public ReturnSpawnerUnloadStatus()
    {
    }
  }
}
