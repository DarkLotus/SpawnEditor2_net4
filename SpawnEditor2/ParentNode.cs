// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.ParentNode
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System.Collections;
using System.Xml;

namespace SpawnEditor2
{
  public class ParentNode
  {
    private ParentNode m_Parent;
    private object[] m_Children;
    private string m_Name;

    public ParentNode Parent
    {
      get
      {
        return this.m_Parent;
      }
    }

    public object[] Children
    {
      get
      {
        return this.m_Children;
      }
    }

    public string Name
    {
      get
      {
        return this.m_Name;
      }
    }

    public ParentNode(XmlTextReader xml, ParentNode parent)
    {
      this.m_Parent = parent;
      this.Parse(xml);
    }

    private void Parse(XmlTextReader xml)
    {
      this.m_Name = !xml.MoveToAttribute("name") ? "empty" : xml.Value;
      if (xml.IsEmptyElement)
      {
        this.m_Children = new object[0];
      }
      else
      {
        ArrayList arrayList = new ArrayList();
        while (xml.Read() && xml.NodeType == XmlNodeType.Element)
        {
          if (xml.Name == "child")
          {
            ChildNode childNode = new ChildNode(xml, this);
            arrayList.Add((object) childNode);
          }
          else
            arrayList.Add((object) new ParentNode(xml, this));
        }
        this.m_Children = arrayList.ToArray();
      }
    }
  }
}
