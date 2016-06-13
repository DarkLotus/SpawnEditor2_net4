// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.TransferMessage
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  [Serializable]
  public abstract class TransferMessage
  {
    public Guid AuthenticationID;
    public bool UseMainThread;

    public virtual TransferMessage ProcessMessage()
    {
      return (TransferMessage) new ErrorMessage("Empty ProcessMessage");
    }

    public virtual byte[] Compress()
    {
      return ZLib.Compress((object) this);
    }

    public static TransferMessage Decompress(byte[] data, Type type)
    {
      return ZLib.Decompress(data, type) as TransferMessage;
    }
  }
}
