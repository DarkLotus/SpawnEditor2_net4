// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.Region
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Xml;

namespace SpawnEditor2
{
  public class Region : IComparable
  {
    private static int m_RegionUID = 1;
    private static bool m_SupressXmlWarnings = true;
    private static ArrayList m_Regions = new ArrayList();
    private MusicName m_Music = MusicName.Invalid;
    private int m_MinZ = (int) short.MinValue;
    private int m_MaxZ = (int) short.MaxValue;
    public const int LowestPriority = 0;
    public const int HighestPriority = 150;
    public const int TownPriority = 50;
    public const int HousePriority = 150;
    public const int InnPriority = 51;
    private int m_Priority;
    private ArrayList m_Coords;
    private ArrayList m_InnBounds;
    private WorldMap m_Map;
    private string m_Name;
    private string m_Prefix;
    private MapLocation m_GoLoc;
    private int m_UId;
    private bool m_Load;
    private ArrayList m_LoadCoords;
    public static SpawnEditor Editor;

    public bool LoadFromXml
    {
      get
      {
        return this.m_Load;
      }
      set
      {
        this.m_Load = value;
      }
    }

    public string Name
    {
      get
      {
        return this.m_Name;
      }
      set
      {
        this.m_Name = value;
      }
    }

    public string Prefix
    {
      get
      {
        return this.m_Prefix;
      }
      set
      {
        this.m_Prefix = value;
      }
    }

    public MusicName Music
    {
      get
      {
        return this.m_Music;
      }
      set
      {
        this.m_Music = value;
      }
    }

    public MapLocation GoLocation
    {
      get
      {
        return this.m_GoLoc;
      }
      set
      {
        this.m_GoLoc = value;
      }
    }

    public WorldMap Map
    {
      get
      {
        return this.m_Map;
      }
      set
      {
        Region.RemoveRegion(this);
        this.m_Map = value;
        Region.AddRegion(this);
      }
    }

    public ArrayList InnBounds
    {
      get
      {
        return this.m_InnBounds;
      }
      set
      {
        this.m_InnBounds = value;
      }
    }

    public ArrayList Coords
    {
      get
      {
        return this.m_Coords;
      }
      set
      {
        if (this.m_Coords == value)
          return;
        Region.RemoveRegion(this);
        this.m_Coords = value;
        Region.AddRegion(this);
      }
    }

    public int Priority
    {
      get
      {
        return this.m_Priority;
      }
      set
      {
        if (value == this.m_Priority)
          return;
        this.m_Priority = value;
      }
    }

    public int UId
    {
      get
      {
        return this.m_UId;
      }
    }

    public int MinZ
    {
      get
      {
        return this.m_MinZ;
      }
      set
      {
        Region.RemoveRegion(this);
        this.m_MinZ = value;
        Region.AddRegion(this);
      }
    }

    public int MaxZ
    {
      get
      {
        return this.m_MaxZ;
      }
      set
      {
        Region.RemoveRegion(this);
        this.m_MaxZ = value;
        Region.AddRegion(this);
      }
    }

    public static bool SupressXmlWarnings
    {
      get
      {
        return Region.m_SupressXmlWarnings;
      }
      set
      {
        Region.m_SupressXmlWarnings = value;
      }
    }

    public static ArrayList Regions
    {
      get
      {
        return Region.m_Regions;
      }
    }

    public Region(string prefix, string name, WorldMap map, int uid)
      : this(prefix, name, map)
    {
      this.m_UId = uid | 1073741824;
    }

    public Region(string prefix, string name, WorldMap map)
    {
      this.m_Prefix = prefix;
      this.m_Name = name;
      this.m_Map = map;
      this.m_Priority = 0;
      this.m_GoLoc = MapLocation.Zero;
      this.m_Load = true;
      this.m_UId = Region.m_RegionUID++;
    }

    public static bool operator <(Region l, Region r)
    {
      if (Region.IsNull(l) && Region.IsNull(r))
        return false;
      if (Region.IsNull(l))
        return true;
      if (Region.IsNull(r))
        return false;
      return l.Priority > r.Priority;
    }

    public static bool operator >(Region l, Region r)
    {
      if (Region.IsNull(l) && Region.IsNull(r) || Region.IsNull(l))
        return false;
      if (Region.IsNull(r))
        return true;
      return l.Priority < r.Priority;
    }

    public static bool operator ==(Region l, Region r)
    {
      if (Region.IsNull(l))
        return Region.IsNull(r);
      if (Region.IsNull(r))
        return false;
      return l.UId == r.UId;
    }

    public static bool operator !=(Region l, Region r)
    {
      if (Region.IsNull(l))
        return !Region.IsNull(r);
      if (Region.IsNull(r))
        return true;
      return l.UId != r.UId;
    }

    public int CompareTo(object o)
    {
      if (!(o is Region))
        return 0;
      int num1 = ((Region) o).m_Priority;
      int num2 = this.m_Priority;
      if (num1 < num2)
        return -1;
      return num1 > num2 ? 1 : 0;
    }

    public virtual bool Contains(MapLocation p)
    {
      if (this.m_Coords == null)
        return false;
      for (int index = 0; index < this.m_Coords.Count; ++index)
      {
        object obj = this.m_Coords[index];
        if (obj is Rectangle && ((Rectangle) obj).Contains(p.X, p.Y))
          return true;
      }
      return false;
    }

    public override string ToString()
    {
      if (this.Prefix != "")
        return string.Format("{0} {1}", (object) this.Prefix, (object) this.Name);
      return this.Name;
    }

    public static bool IsNull(Region r)
    {
      return object.ReferenceEquals((object) r, (object) null);
    }

    public override bool Equals(object o)
    {
      if (!(o is Region) || o == null)
        return false;
      return (Region) o == this;
    }

    public override int GetHashCode()
    {
      return this.m_UId;
    }

    public static Region GetByName(string name, WorldMap map)
    {
      for (int index = 0; index < Region.m_Regions.Count; ++index)
      {
        Region region = (Region) Region.m_Regions[index];
        if (region.Map == map && region.Name == name)
          return region;
      }
      return (Region) null;
    }

    public static object ParseRectangle(XmlElement rect, bool supports3d)
    {
      int x;
      int y;
      int num1;
      int num2;
      if (rect.HasAttribute("x") && rect.HasAttribute("y") && (rect.HasAttribute("width") && rect.HasAttribute("height")))
      {
        x = int.Parse(rect.GetAttribute("x"));
        y = int.Parse(rect.GetAttribute("y"));
        num1 = x + int.Parse(rect.GetAttribute("width"));
        num2 = y + int.Parse(rect.GetAttribute("height"));
      }
      else
      {
        if (!rect.HasAttribute("x1") || !rect.HasAttribute("y1") || (!rect.HasAttribute("x2") || !rect.HasAttribute("y2")))
          throw new ArgumentException("Wrong attributes specified.");
        x = int.Parse(rect.GetAttribute("x1"));
        y = int.Parse(rect.GetAttribute("y1"));
        num1 = int.Parse(rect.GetAttribute("x2"));
        num2 = int.Parse(rect.GetAttribute("y2"));
      }
      return (object) new Rectangle(x, y, num1 - x, num2 - y);
    }

    public static void Load(string basedir)
    {
      string str = Path.Combine(basedir, "Data\\Regions.xml");
      if (!File.Exists(str))
        return;
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(str);
      foreach (XmlElement xmlElement1 in xmlDocument["ServerRegions"].GetElementsByTagName("Facet"))
      {
        string attribute1 = xmlElement1.GetAttribute("name");
        WorldMap map = WorldMap.Internal;
        try
        {
          map = (WorldMap) Enum.Parse(typeof (WorldMap), attribute1, true);
        }
        catch
        {
        }
        if (map == WorldMap.Internal)
        {
          if (!Region.m_SupressXmlWarnings)
            Console.WriteLine("Regions.xml: Invalid facet name '{0}'", (object) attribute1);
        }
        else
        {
          foreach (XmlElement xmlElement2 in xmlElement1.GetElementsByTagName("region"))
          {
            string attribute2 = xmlElement2.GetAttribute("name");
            if (attribute2 != null && attribute2.Length > 0)
            {
              Region region = new Region("", attribute2, map);
              Region.AddRegion(region);
              try
              {
                region.Priority = int.Parse(xmlElement2.GetAttribute("priority"));
              }
              catch
              {
                if (!Region.m_SupressXmlWarnings)
                  Console.WriteLine("Regions.xml: Could not parse priority for region '{0}' (assuming TownPriority)", (object) region.Name);
                region.Priority = 50;
              }
              XmlElement xmlElement3 = xmlElement2["go"];
              if (xmlElement3 != null)
              {
                try
                {
                  region.GoLocation = MapLocation.Parse(xmlElement3.GetAttribute("location"));
                  region.GoLocation.Facet = (int) map;
                }
                catch
                {
                  if (!Region.m_SupressXmlWarnings)
                    Console.WriteLine("Regions.xml: Could not parse go location for region '{0}'", (object) region.Name);
                }
              }
              XmlElement xmlElement4 = xmlElement2["music"];
              if (xmlElement4 != null)
              {
                try
                {
                  region.Music = (MusicName) Enum.Parse(typeof (MusicName), xmlElement4.GetAttribute("name"), true);
                }
                catch
                {
                  if (!Region.m_SupressXmlWarnings)
                    Console.WriteLine("Regions.xml: Could not parse music for region '{0}'", (object) region.Name);
                }
              }
              XmlElement xmlElement5 = xmlElement2["zrange"];
              if (xmlElement5 != null)
              {
                string attribute3 = xmlElement5.GetAttribute("min");
                if (attribute3 != null)
                {
                  if (attribute3 != "")
                  {
                    try
                    {
                      region.MinZ = int.Parse(attribute3);
                    }
                    catch
                    {
                      if (!Region.m_SupressXmlWarnings)
                        Console.WriteLine("Regions.xml: Could not parse zrange:min for region '{0}'", (object) region.Name);
                    }
                  }
                }
                string attribute4 = xmlElement5.GetAttribute("max");
                if (attribute4 != null)
                {
                  if (attribute4 != "")
                  {
                    try
                    {
                      region.MaxZ = int.Parse(attribute4);
                    }
                    catch
                    {
                      if (!Region.m_SupressXmlWarnings)
                        Console.WriteLine("Regions.xml: Could not parse zrange:max for region '{0}'", (object) region.Name);
                    }
                  }
                }
              }
              foreach (XmlElement rect in xmlElement2.GetElementsByTagName("rect"))
              {
                try
                {
                  if (region.m_LoadCoords == null)
                    region.m_LoadCoords = new ArrayList(1);
                  region.m_LoadCoords.Add(Region.ParseRectangle(rect, true));
                }
                catch
                {
                  if (!Region.m_SupressXmlWarnings)
                    Console.WriteLine("Regions.xml: Error parsing rect for region '{0}'", (object) region.Name);
                }
              }
              foreach (XmlElement rect in xmlElement2.GetElementsByTagName("inn"))
              {
                try
                {
                  if (region.InnBounds == null)
                    region.InnBounds = new ArrayList(1);
                  region.InnBounds.Add(Region.ParseRectangle(rect, false));
                }
                catch
                {
                  if (!Region.m_SupressXmlWarnings)
                    Console.WriteLine("Regions.xml: Error parsing inn for region '{0}'", (object) region.Name);
                }
              }
            }
          }
        }
      }
      ArrayList arrayList = new ArrayList((ICollection) Region.m_Regions);
      for (int index = 0; index < arrayList.Count; ++index)
      {
        Region region = (Region) arrayList[index];
        if (!region.LoadFromXml && region.m_Coords == null)
          region.Coords = new ArrayList();
        else if (region.LoadFromXml)
        {
          if (region.m_LoadCoords == null)
            region.m_LoadCoords = new ArrayList();
          region.Coords = region.m_LoadCoords;
        }
      }
    }

    public static void AddRegion(Region region)
    {
      Region.m_Regions.Add((object) region);
    }

    public static void RemoveRegion(Region region)
    {
      Region.m_Regions.Remove((object) region);
    }

    public static Region FindByUId(int uid)
    {
      for (int index = 0; index < Region.m_Regions.Count; ++index)
      {
        Region region = (Region) Region.m_Regions[index];
        if (region.UId == uid)
          return region;
      }
      return (Region) null;
    }

    public static Region Find(MapLocation p, WorldMap map)
    {
      if (map == WorldMap.Internal)
        return (Region) null;
      for (int index = 0; index < Region.m_Regions.Count; ++index)
      {
        Region region = (Region) Region.m_Regions[index];
        if (region.Map == map && region.Contains(p))
          return region;
      }
      return (Region) null;
    }
  }
}
