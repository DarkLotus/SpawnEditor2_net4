// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.ChildNode
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Xml;

namespace SpawnEditor2
{
  public class ChildNode
  {
    private ParentNode m_Parent;
    private string m_Name;
    private MapLocation m_Location;

    public ParentNode Parent
    {
      get
      {
        return this.m_Parent;
      }
    }

    public string Name
    {
      get
      {
        return this.m_Name;
      }
    }

    public MapLocation Location
    {
      get
      {
        return this.m_Location;
      }
    }

    public ChildNode(XmlTextReader xml, ParentNode parent)
    {
      this.m_Parent = parent;
      this.Parse(xml);
    }

    private void Parse(XmlTextReader xml)
    {
      this.m_Name = !xml.MoveToAttribute("name") ? "empty" : xml.Value;
      int x = 0;
      int y = 0;
      int z = 0;
      if (xml.MoveToAttribute("x"))
      {
        try
        {
          x = int.Parse(xml.Value);
        }
        catch
        {
        }
      }
      if (xml.MoveToAttribute("y"))
      {
        try
        {
          y = int.Parse(xml.Value);
        }
        catch
        {
        }
      }
      if (xml.MoveToAttribute("z"))
      {
        try
        {
          z = int.Parse(xml.Value);
        }
        catch
        {
        }
      }
      this.m_Location = new MapLocation(x, y, z);
    }
  }
}
