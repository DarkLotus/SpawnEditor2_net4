// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.LocationTree
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Collections;
using System.IO;
using System.Xml;

namespace SpawnEditor2
{
  public class LocationTree
  {
    private WorldMap m_Map;
    private ParentNode m_Root;
    private Hashtable m_LastBranch;

    public Hashtable LastBranch
    {
      get
      {
        return this.m_LastBranch;
      }
    }

    public WorldMap Map
    {
      get
      {
        return this.m_Map;
      }
    }

    public ParentNode Root
    {
      get
      {
        return this.m_Root;
      }
    }

    public LocationTree(string dirname, string fileName, WorldMap map)
    {
      this.m_LastBranch = new Hashtable();
      this.m_Map = map;
      string path = Path.Combine(Path.Combine(dirname, "Data\\Locations\\"), fileName);
      if (!File.Exists(path))
        return;
      XmlTextReader xml = new XmlTextReader((TextReader) new StreamReader(path));
      xml.WhitespaceHandling = WhitespaceHandling.None;
      this.m_Root = this.Parse(xml);
      xml.Close();
    }

    private ParentNode Parse(XmlTextReader xml)
    {
      xml.Read();
      xml.Read();
      xml.Read();
      return new ParentNode(xml, (ParentNode) null);
    }
  }
}
