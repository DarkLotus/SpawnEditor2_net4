// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.UnloadSpawnerData
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  [Serializable]
  public class UnloadSpawnerData : TransferMessage
  {
    private byte[] m_Data;

    public byte[] Data
    {
      get
      {
        return this.m_Data;
      }
      set
      {
        this.m_Data = value;
      }
    }

    public UnloadSpawnerData(byte[] data)
    {
      this.Data = data;
    }

    public UnloadSpawnerData()
    {
    }
  }
}
