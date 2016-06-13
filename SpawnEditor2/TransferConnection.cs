// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.TransferConnection
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using Server.Engines.XmlSpawner2;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace SpawnEditor2
{
  public class TransferConnection
  {
    private static RemoteMessaging m_Remote = (RemoteMessaging) null;

    public static bool HasErrors(TransferMessage msg, Type t, string rtype)
    {
      if (msg == null)
      {
        int num = (int) MessageBox.Show(string.Format("No Message Data Received from Remote Server for {0} ({1})", (object) t, (object) rtype));
        return true;
      }
      if (!(msg is ErrorMessage))
        return false;
      int num1 = (int) MessageBox.Show((msg as ErrorMessage).Message);
      return true;
    }

    public static TransferMessage ProcessMessage(string Address, int Port, TransferMessage msg)
    {
      byte[] data1 = msg.Compress();
      string answerType = (string) null;
      string url = string.Format("tcp://{0}:{1}/RemoteMessaging", (object) Address, (object) Port);
      try
      {
        TransferConnection.m_Remote = Activator.GetObject(typeof (RemoteMessaging), url) as RemoteMessaging;
      }
      catch
      {
        int num = (int) MessageBox.Show(string.Format("Failed to connect to remote server {0} : {1}", (object) Address, (object) Port));
        return (TransferMessage) null;
      }
      TransferMessage msg1;
      try
      {
        byte[] data2 = TransferConnection.m_Remote.PerformRemoteRequest(msg.GetType().FullName, data1, out answerType);
        if (data2 == null)
        {
          int num = (int) MessageBox.Show("No Data Received from Remote Server for " + msg.GetType().FullName);
          return (TransferMessage) null;
        }
        Type type = Type.GetType(answerType);
        if (type == null)
        {
          Assembly assembly = Assembly.GetAssembly(typeof (TransferMessage));
          if (assembly != null)
            type = assembly.GetType(answerType);
        }
        msg1 = TransferMessage.Decompress(data2, type);
        if (TransferConnection.HasErrors(msg1, type, answerType))
          msg1 = (TransferMessage) null;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
        msg1 = (TransferMessage) null;
      }
      return msg1;
    }
  }
}
