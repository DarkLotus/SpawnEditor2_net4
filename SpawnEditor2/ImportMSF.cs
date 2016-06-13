// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.ImportMSF
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SpawnEditor2
{
  public class ImportMSF
  {
    private SpawnEditor _Editor;

    public ImportMSF(SpawnEditor editor)
    {
      this._Editor = editor;
    }

    private static string GetText(XmlElement node, string defaultValue)
    {
      if (node == null)
        return defaultValue;
      return node.InnerText;
    }

    public void DoImportMSF(string filePath)
    {
      if (!File.Exists(filePath))
        return;
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(filePath);
      XmlElement xmlElement = xmlDocument["MegaSpawners"];
      if (xmlElement != null)
      {
        int num1 = 0;
        int num2 = 0;
        foreach (XmlElement node in xmlElement.GetElementsByTagName("MegaSpawner"))
        {
          try
          {
            this.ImportMegaSpawner(node);
            ++num1;
          }
          catch
          {
            ++num2;
          }
        }
      }
      else
      {
        int num = (int) MessageBox.Show((IWin32Window) this._Editor, "Invalid .msf file. No MegaSpawners node found", "Import MSF Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void ImportMegaSpawner(XmlElement node)
    {
      string text1 = ImportMSF.GetText(node["Name"], "MegaSpawner");
      bool.Parse(ImportMSF.GetText(node["Active"], "True"));
      MapLocation mapLocation = MapLocation.Parse(ImportMSF.GetText(node["Location"], "Error"));
      WorldMap Map = (WorldMap) Enum.Parse(typeof (WorldMap), ImportMSF.GetText(node["Map"], "Error"));
      string path = Path.Combine(this._Editor.StartingDirectory, "import.log");
      bool flag1 = false;
      int num1 = 0;
      int num2 = 4;
      int num3 = 4;
      TimeSpan timeSpan1 = TimeSpan.FromMinutes(10.0);
      TimeSpan timeSpan2 = TimeSpan.FromMinutes(5.0);
      XmlElement xmlElement1 = node["EntryLists"];
      int length = 0;
      SpawnObject[] spawnObjectArray = (SpawnObject[]) null;
      if (xmlElement1 != null)
      {
        if (xmlElement1.HasAttributes)
          length = int.Parse(xmlElement1.Attributes.GetNamedItem("count").Value);
        if (length > 0)
        {
          spawnObjectArray = new SpawnObject[length];
          int index = 0;
          bool flag2 = false;
          foreach (XmlElement xmlElement2 in xmlElement1.GetElementsByTagName("EntryList"))
          {
            if (xmlElement2 != null)
            {
              if (index == 0)
              {
                flag1 = bool.Parse(ImportMSF.GetText(xmlElement2["GroupSpawn"], "False"));
                timeSpan1 = TimeSpan.FromSeconds((double) int.Parse(ImportMSF.GetText(xmlElement2["MaxDelay"], "10:00")));
                timeSpan2 = TimeSpan.FromSeconds((double) int.Parse(ImportMSF.GetText(xmlElement2["MinDelay"], "05:00")));
                num2 = int.Parse(ImportMSF.GetText(xmlElement2["WalkRange"], "10"));
                num3 = int.Parse(ImportMSF.GetText(xmlElement2["SpawnRange"], "4"));
              }
              else
              {
                if (flag1 != bool.Parse(ImportMSF.GetText(xmlElement2["GroupSpawn"], "False")))
                {
                  flag2 = true;
                  try
                  {
                    using (StreamWriter streamWriter = new StreamWriter(path, true))
                      streamWriter.WriteLine("MSFimport : individual group entry difference: {0} vs {1}", (object) ImportMSF.GetText(xmlElement2["GroupSpawn"], "False"), (object)  (flag1 ? 1 : 0));
                  }
                  catch
                  {
                  }
                }
                if (timeSpan2 != TimeSpan.FromSeconds((double) int.Parse(ImportMSF.GetText(xmlElement2["MinDelay"], "05:00"))))
                {
                  flag2 = true;
                  try
                  {
                    using (StreamWriter streamWriter = new StreamWriter(path, true))
                      streamWriter.WriteLine("MSFimport : individual mindelay entry difference: {0} vs {1}", (object) ImportMSF.GetText(xmlElement2["MinDelay"], "05:00"), (object) timeSpan2);
                  }
                  catch
                  {
                  }
                }
                if (timeSpan1 != TimeSpan.FromSeconds((double) int.Parse(ImportMSF.GetText(xmlElement2["MaxDelay"], "10:00"))))
                {
                  flag2 = true;
                  try
                  {
                    using (StreamWriter streamWriter = new StreamWriter(path, true))
                      streamWriter.WriteLine("MSFimport : individual maxdelay entry difference: {0} vs {1}", (object) ImportMSF.GetText(xmlElement2["MaxDelay"], "10:00"), (object) timeSpan1);
                  }
                  catch
                  {
                  }
                }
                if (num2 != int.Parse(ImportMSF.GetText(xmlElement2["WalkRange"], "10")))
                {
                  flag2 = true;
                  try
                  {
                    using (StreamWriter streamWriter = new StreamWriter(path, true))
                      streamWriter.WriteLine("MSFimport : individual homerange entry difference: {0} vs {1}", (object) ImportMSF.GetText(xmlElement2["WalkRange"], "10"), (object) num2);
                  }
                  catch
                  {
                  }
                }
                if (num3 != int.Parse(ImportMSF.GetText(xmlElement2["SpawnRange"], "4")))
                {
                  flag2 = true;
                  try
                  {
                    using (StreamWriter streamWriter = new StreamWriter(path, true))
                      streamWriter.WriteLine("MSFimport : individual spawnrange entry difference: {0} vs {1}", (object) ImportMSF.GetText(xmlElement2["SpawnRange"], "4"), (object) num3);
                  }
                  catch
                  {
                  }
                }
              }
              int maxamount = int.Parse(ImportMSF.GetText(xmlElement2["Amount"], "1"));
              string text2 = ImportMSF.GetText(xmlElement2["EntryType"], "");
              num1 += maxamount;
              spawnObjectArray[index] = new SpawnObject(text2, maxamount);
              ++index;
              if (index > length)
              {
                try
                {
                  using (StreamWriter streamWriter = new StreamWriter(path, true))
                  {
                    streamWriter.WriteLine("{0} MSFImport Error; inconsistent entry count {1} {2}", (object) DateTime.Now, (object) mapLocation, (object) Map);
                    streamWriter.WriteLine();
                    break;
                  }
                }
                catch
                {
                  break;
                }
              }
            }
          }
          if (flag2)
          {
            try
            {
              using (StreamWriter streamWriter = new StreamWriter(path, true))
              {
                streamWriter.WriteLine("{0} MSFImport: Individual entry setting differences listed above from spawner at {1} {2}", (object) DateTime.Now, (object) mapLocation, (object) Map);
                streamWriter.WriteLine();
              }
            }
            catch
            {
            }
          }
        }
      }
      if (mapLocation.Z == -999)
        mapLocation.Z = (int) short.MinValue;
      SpawnPoint Spawn = new SpawnPoint(Guid.NewGuid(), Map, (short) mapLocation.X, (short) mapLocation.Y, (short) (num3 * 2), (short) (num3 * 2));
      Spawn.SpawnName = text1;
      Spawn.SpawnHomeRange = num2;
      Spawn.CentreZ = (short) mapLocation.Z;
      Spawn.SpawnMinDelay = timeSpan2.TotalMinutes;
      Spawn.SpawnMaxDelay = timeSpan1.TotalMinutes;
      Spawn.SpawnMaxCount = num1;
      Spawn.SpawnIsGroup = flag1;
      Spawn.IsSelected = false;
      for (int index = 0; index < spawnObjectArray.Length; ++index)
        Spawn.SpawnObjects.Add((object) spawnObjectArray[index]);
      this._Editor.tvwSpawnPoints.Nodes.Add((TreeNode) new SpawnPointNode(Spawn));
    }
  }
}
