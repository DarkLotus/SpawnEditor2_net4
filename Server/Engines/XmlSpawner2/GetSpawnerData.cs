// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.GetSpawnerData
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  [Serializable]
  public class GetSpawnerData : TransferMessage
  {
    private int m_Map;
    public int X;
    public int Y;
    public int Width;
    public int Height;
    public string NameFilter;
    public string EntryFilter;
    public short ContainerFilter;
    public short SequentialFilter;
    public short SmartSpawnFilter;
    public bool NameCase;
    public bool EntryCase;
    public short Modified;
    public short Proximity;
    public short Running;
    public DateTime ModifiedDate;
    public short SpawnTime;
    public double AvgSpawnTime;
    public string ModifiedName;
    public short ModifiedBy;

    public int SelectedMap
    {
      get
      {
        return this.m_Map;
      }
      set
      {
        this.m_Map = value;
      }
    }

    public GetSpawnerData()
    {
    }

    public GetSpawnerData(int map)
    {
      this.m_Map = map;
    }

    public GetSpawnerData(int map, int x, int y, int w, int h)
    {
      this.m_Map = map;
      this.X = x;
      this.Y = y;
      this.Width = w;
      this.Height = h;
    }
  }
}
