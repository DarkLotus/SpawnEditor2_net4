// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.MapLocation
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;

namespace SpawnEditor2
{
  public class MapLocation
  {
    public static readonly MapLocation Zero = new MapLocation(0, 0, 0);
    public int Facet = -1;
    public int X;
    public int Y;
    public int Z;

    public MapLocation(int x, int y, int z)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
    }

    public MapLocation()
    {
    }

    public override string ToString()
    {
      return string.Format("({0}, {1}, {2})", (object) this.X, (object) this.Y, (object) this.Z);
    }

    public static MapLocation Parse(string value)
    {
      int num1 = value.IndexOf('(');
      int num2 = value.IndexOf(',', num1 + 1);
      string str1 = value.Substring(num1 + 1, num2 - (num1 + 1)).Trim();
      int num3 = num2;
      int num4 = value.IndexOf(',', num3 + 1);
      string str2 = value.Substring(num3 + 1, num4 - (num3 + 1)).Trim();
      int num5 = num4;
      int num6 = value.IndexOf(')', num5 + 1);
      string str3 = value.Substring(num5 + 1, num6 - (num5 + 1)).Trim();
      return new MapLocation(Convert.ToInt32(str1), Convert.ToInt32(str2), Convert.ToInt32(str3));
    }
  }
}
