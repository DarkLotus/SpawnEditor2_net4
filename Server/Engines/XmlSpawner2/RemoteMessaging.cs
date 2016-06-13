// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.RemoteMessaging
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  public class RemoteMessaging : MarshalByRefObject
  {
    private static int n_instances;

    public static event RemoteMessaging.Message OnReceiveMessage;

    public RemoteMessaging()
    {
      ++RemoteMessaging.n_instances;
    }

    ~RemoteMessaging()
    {
      --RemoteMessaging.n_instances;
    }

    public byte[] PerformRemoteRequest(string typeName, byte[] data, out string answerType)
    {
      answerType = (string) null;
      if (RemoteMessaging.OnReceiveMessage != null)
        return RemoteMessaging.OnReceiveMessage(typeName, data, out answerType);
      return (byte[]) null;
    }

    public delegate byte[] Message(string typeName, byte[] data, out string answerType);
  }
}
