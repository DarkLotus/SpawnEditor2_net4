// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.SpawnObject
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Collections;

namespace SpawnEditor2
{
  public class SpawnObject
  {
    public bool RestrictKillsToSubgroup = false;
    public bool ClearOnAdvance = true;
    public double MinDelay = -1.0;
    public double MaxDelay = -1.0;
    public int SpawnsPerTick = 1;
    public string TypeName;
    public int Count;
    public int SubGroup;
    public double SequentialResetTime;
    public int SequentialResetTo;
    public int KillsNeeded;

    public SpawnObject(string name, int maxamount)
    {
      this.TypeName = name;
      this.Count = maxamount;
      this.SubGroup = 0;
      this.SequentialResetTime = 0.0;
      this.SequentialResetTo = 0;
      this.KillsNeeded = 0;
      this.RestrictKillsToSubgroup = false;
      this.ClearOnAdvance = true;
    }

    public SpawnObject(string name, int maxamount, int subgroup, double sequentialresettime, int sequentialresetto, int killsneeded, bool restrictkills, bool clearadvance, double mindelay, double maxdelay, int spawnsper)
    {
      this.TypeName = name;
      this.Count = maxamount;
      this.SubGroup = subgroup;
      this.SequentialResetTime = sequentialresettime;
      this.SequentialResetTo = sequentialresetto;
      this.KillsNeeded = killsneeded;
      this.RestrictKillsToSubgroup = restrictkills;
      this.ClearOnAdvance = clearadvance;
      this.MinDelay = mindelay;
      this.MaxDelay = maxdelay;
      this.SpawnsPerTick = spawnsper;
    }

    internal static string GetParm(string str, string separator)
    {
      string[] strArray1 = SpawnObject.SplitString(str, separator);
      if (strArray1.Length > 1)
      {
        string[] strArray2 = strArray1[1].Split(':');
        if (strArray2.Length > 0)
          return strArray2[0];
      }
      return (string) null;
    }

    public override string ToString()
    {
      return this.TypeName + "=" + this.Count.ToString();
    }

    public static string[] SplitString(string str, string separator)
    {
      if (str == null || separator == null)
        return (string[]) null;
      int startIndex = 0;
      int length = 0;
      ArrayList arrayList = new ArrayList();
      while (length >= 0)
      {
        length = str.IndexOf(separator);
        if (length < 0)
        {
          arrayList.Add((object) str);
          break;
        }
        string str1 = str.Substring(startIndex, length);
        arrayList.Add((object) str1);
        str = str.Substring(length + separator.Length, str.Length - (length + separator.Length));
      }
      string[] strArray = new string[arrayList.Count];
      for (int index = 0; index < arrayList.Count; ++index)
        strArray[index] = (string) arrayList[index];
      return strArray;
    }
  }
}
