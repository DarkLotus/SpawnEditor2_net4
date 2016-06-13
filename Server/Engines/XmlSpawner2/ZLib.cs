// Decompiled with JetBrains decompiler
// Type: Server.Engines.XmlSpawner2.ZLib
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Server.Engines.XmlSpawner2
{
  public class ZLib
  {
    [DllImport("zlib")]
    private static extern string zlibVersion();

    [DllImport("zlib")]
    private static extern ZLib.ZLibError compress(byte[] dest, ref int destLength, byte[] source, int sourceLength);

    [DllImport("zlib")]
    private static extern ZLib.ZLibError compress2(byte[] dest, ref int destLength, byte[] source, int sourceLength, ZLib.ZLibCompressionLevel level);

    [DllImport("zlib")]
    private static extern ZLib.ZLibError uncompress(byte[] dest, ref int destLen, byte[] source, int sourceLen);

    public static bool CheckVersion()
    {
      string[] strArray;
      try
      {
        strArray = ZLib.zlibVersion().Split('.');
      }
      catch (DllNotFoundException ex)
      {
        return false;
      }
      return strArray[0] == "1";
    }

    public static byte[] Compress(object source)
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());
        MemoryStream memoryStream = new MemoryStream();
        xmlSerializer.Serialize((Stream) memoryStream, source);
        byte[] source1 = memoryStream.ToArray();
        memoryStream.Close();
        int length = source1.Length;
        int destLength = source1.Length + 1;
        byte[] dest = new byte[destLength];
        if (ZLib.compress2(dest, ref destLength, source1, source1.Length, ZLib.ZLibCompressionLevel.Z_BEST_COMPRESSION) != ZLib.ZLibError.Z_OK)
          return new byte[0];
        byte[] numArray = new byte[destLength + 4];
        Array.Copy((Array) dest, 0, (Array) numArray, 4, destLength);
        numArray[0] = (byte) length;
        numArray[1] = (byte) (length >> 8);
        numArray[2] = (byte) (length >> 16);
        numArray[3] = (byte) (length >> 24);
        return numArray;
      }
      catch (Exception ex)
      {
        return new byte[0];
      }
    }

    public static object Decompress(byte[] data, Type type)
    {
      try
      {
        int destLen = (int) data[0] | (int) data[1] << 8 | (int) data[2] << 16 | (int) data[3] << 24;
        byte[] source = new byte[data.Length - 4];
        Array.Copy((Array) data, 4, (Array) source, 0, data.Length - 4);
        byte[] numArray = new byte[destLen];
        if (ZLib.uncompress(numArray, ref destLen, source, source.Length) != ZLib.ZLibError.Z_OK)
          return (object) null;
        MemoryStream memoryStream = new MemoryStream(numArray);
        object obj = new XmlSerializer(type).Deserialize((Stream) memoryStream);
        memoryStream.Close();
        return obj;
      }
      catch
      {
        return (object) null;
      }
    }

    public static byte[] Compress(byte[] data)
    {
      int length1 = data.Length;
      int length2 = data.Length;
      byte[] dest = new byte[data.Length];
      if (ZLib.compress(dest, ref length2, data, data.Length) != ZLib.ZLibError.Z_OK)
        return (byte[]) null;
      byte[] numArray = new byte[length2 + 4];
      Array.Copy((Array) dest, 0, (Array) numArray, 4, length2);
      numArray[0] = (byte) (length1 & (int) byte.MaxValue);
      numArray[1] = (byte) (length1 >> 8 & (int) byte.MaxValue);
      numArray[2] = (byte) (length1 >> 16 & (int) byte.MaxValue);
      numArray[3] = (byte) (length1 >> 24 & (int) byte.MaxValue);
      return numArray;
    }

    public static byte[] Decompress(byte[] data)
    {
      int destLen = (int) data[0] | (int) data[1] << 8 | (int) data[2] << 16 | (int) data[3] << 24;
      byte[] source = new byte[data.Length - 4];
      Array.Copy((Array) data, 4, (Array) source, 0, data.Length - 4);
      byte[] dest = new byte[destLen];
      if (ZLib.uncompress(dest, ref destLen, source, source.Length) != ZLib.ZLibError.Z_OK)
        return (byte[]) null;
      return dest;
    }

    private enum ZLibError
    {
      Z_VERSION_ERROR = -6,
      Z_BUF_ERROR = -5,
      Z_MEM_ERROR = -4,
      Z_DATA_ERROR = -3,
      Z_STREAM_ERROR = -2,
      Z_ERRNO = -1,
      Z_OK = 0,
      Z_STREAM_END = 1,
      Z_NEED_DICT = 2,
    }

    private enum ZLibCompressionLevel
    {
      Z_DEFAULT_COMPRESSION = -1,
      Z_NO_COMPRESSION = 0,
      Z_BEST_SPEED = 1,
      Z_BEST_COMPRESSION = 9,
    }
  }
}
