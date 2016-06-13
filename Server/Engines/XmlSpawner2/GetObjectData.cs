// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.GetObjectData
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  [Serializable]
  public class GetObjectData : TransferMessage
  {
    public int SelectedMap;
    public string ObjectType;
    public int ItemID;
    public short Statics;
    public short Visible;
    public short Movable;
    public short InContainers;
    public short Carried;
    public short Blessed;
    public short Innocent;
    public short Controlled;
    public short Access;
    public short Criminal;

    public GetObjectData()
    {
    }

    public GetObjectData(int map)
    {
      this.SelectedMap = map;
    }
  }
}
