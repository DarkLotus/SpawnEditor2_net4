// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.ReturnData
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  [Serializable]
  public class ReturnData : TransferMessage
  {
    private object m_Data;
    private string m_Typename;

    public string Typename
    {
      get
      {
        return this.m_Typename;
      }
      set
      {
        this.m_Typename = value;
      }
    }

    public object Data
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

    public ReturnData(object data, string type)
    {
      this.m_Data = data;
      this.m_Typename = type;
    }

    public ReturnData(object data)
    {
      this.m_Data = data;
    }

    public ReturnData()
    {
    }
  }
}
