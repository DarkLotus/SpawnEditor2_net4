// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.ErrorMessage
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace Server.Engines.XmlSpawner2
{
  [Serializable]
  public class ErrorMessage : TransferMessage
  {
    private string m_Message;

    public string Message
    {
      get
      {
        return this.m_Message;
      }
      set
      {
        this.m_Message = value;
      }
    }

    public ErrorMessage(string message)
    {
      this.m_Message = message;
    }

    public ErrorMessage(string message, params string[] args)
    {
      this.m_Message = string.Format(message, (object[]) args);
    }

    public ErrorMessage()
    {
    }
  }
}
