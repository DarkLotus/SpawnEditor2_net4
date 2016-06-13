// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.ImportMap
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;
using System.IO;
using System.Windows.Forms;

namespace SpawnEditor2
{
  public class ImportMap
  {
    private SpawnEditor _Editor;

    public ImportMap(SpawnEditor editor)
    {
      this._Editor = editor;
    }

    public void DoImportMap(string filename, out int processedmaps, out int processedspawners)
    {
      processedmaps = 0;
      processedspawners = 0;
      int num1 = 0;
      int num2 = 0;
      if (filename == null || filename.Length <= 0)
        return;
      if (File.Exists(filename))
      {
        string fileName = Path.GetFileName(filename);
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = -1;
        try
        {
          using (StreamReader streamReader = new StreamReader(filename))
          {
            string str;
            while ((str = streamReader.ReadLine()) != null)
            {
              ++num5;
              string[] strArray1 = str.Trim().Split(' ');
              if (strArray1.Length == 2)
              {
                if (strArray1[0].ToLower() == "overridemap")
                {
                  try
                  {
                    num6 = int.Parse(strArray1[1]);
                  }
                  catch
                  {
                  }
                }
              }
              if (strArray1.Length > 0 && strArray1[0] == "*")
              {
                bool flag1 = false;
                int num7 = 0;
                int num8 = 0;
                int num9 = 0;
                int num10 = 0;
                int num11 = 0;
                int num12 = 0;
                int num13 = 0;
                int num14 = 0;
                int maxamount = 0;
                string[] strArray2 = (string[]) null;
                if (strArray1.Length != 11 && strArray1.Length != 12)
                {
                  flag1 = true;
                }
                else
                {
                  strArray2 = strArray1[1].Split(':');
                  if (strArray1.Length == 11)
                  {
                    try
                    {
                      num7 = int.Parse(strArray1[2]);
                      num8 = int.Parse(strArray1[3]);
                      num9 = int.Parse(strArray1[4]);
                      num10 = int.Parse(strArray1[5]);
                      num11 = int.Parse(strArray1[6]);
                      num12 = int.Parse(strArray1[7]);
                      num13 = int.Parse(strArray1[8]);
                      num14 = int.Parse(strArray1[9]);
                      maxamount = int.Parse(strArray1[10]);
                    }
                    catch
                    {
                      flag1 = true;
                    }
                  }
                  else if (strArray1.Length == 12)
                  {
                    try
                    {
                      num7 = int.Parse(strArray1[2]);
                      num8 = int.Parse(strArray1[3]);
                      num9 = int.Parse(strArray1[4]);
                      num10 = int.Parse(strArray1[5]);
                      num11 = int.Parse(strArray1[6]);
                      num12 = int.Parse(strArray1[7]);
                      num13 = int.Parse(strArray1[8]);
                      num14 = int.Parse(strArray1[9]);
                      int.Parse(strArray1[10]);
                      maxamount = int.Parse(strArray1[11]);
                    }
                    catch
                    {
                      flag1 = true;
                    }
                  }
                }
                if (!flag1 && strArray2 != null && strArray2.Length > 0)
                {
                  if (num6 >= 0)
                    num10 = num6;
                  WorldMap Map = WorldMap.Internal;
                  switch (num10)
                  {
                    case 0:
                      Map = WorldMap.Felucca;
                      break;
                    case 1:
                      Map = WorldMap.Felucca;
                      break;
                    case 2:
                      Map = WorldMap.Trammel;
                      break;
                    case 3:
                      Map = WorldMap.Ilshenar;
                      break;
                    case 4:
                      Map = WorldMap.Malas;
                      break;
                    case 5:
                      try
                      {
                        Map = WorldMap.Tokuno;
                        break;
                      }
                      catch
                      {
                        break;
                      }
                  }
                  if (Map == WorldMap.Internal)
                  {
                    ++num4;
                  }
                  else
                  {
                    SpawnPoint Spawn1 = new SpawnPoint(Guid.NewGuid(), Map, (short) num7, (short) num8, (short) (num14 * 2), (short) (num14 * 2));
                    Spawn1.SpawnName = string.Format("{0}#{1}", (object) fileName, (object) num3);
                    Spawn1.SpawnHomeRange = num13;
                    Spawn1.CentreZ = (short) num9;
                    Spawn1.SpawnMinDelay = (double) num11;
                    Spawn1.SpawnMaxDelay = (double) num12;
                    Spawn1.SpawnMaxCount = maxamount;
                    Type runUoType1 = SpawnEditor.FindRunUOType("BaseVendor");
                    bool flag2 = false;
                    for (int index = 0; index < strArray2.Length; ++index)
                    {
                      Type runUoType2 = SpawnEditor.FindRunUOType(strArray2[index]);
                      if (runUoType2 != null && runUoType1 != null && (runUoType2 == runUoType1 || runUoType2.IsSubclassOf(runUoType1)))
                        flag2 = true;
                      Spawn1.SpawnObjects.Add((object) new SpawnObject(strArray2[index], maxamount));
                    }
                    Spawn1.IsSelected = false;
                    if (flag2)
                      Spawn1.SpawnSpawnRange = 0;
                    this._Editor.tvwSpawnPoints.Nodes.Add((TreeNode) new SpawnPointNode(Spawn1));
                    ++num3;
                    if (num10 == 0)
                    {
                      SpawnPoint Spawn2 = new SpawnPoint(Guid.NewGuid(), WorldMap.Trammel, (short) num7, (short) num8, (short) (num14 * 2), (short) (num14 * 2));
                      Spawn2.SpawnName = string.Format("{0}#{1}", (object) fileName, (object) num3);
                      Spawn2.SpawnHomeRange = num13;
                      Spawn2.CentreZ = (short) num9;
                      Spawn2.SpawnMinDelay = (double) num11;
                      Spawn2.SpawnMaxDelay = (double) num12;
                      Spawn2.SpawnMaxCount = maxamount;
                      for (int index = 0; index < strArray2.Length; ++index)
                        Spawn2.SpawnObjects.Add((object) new SpawnObject(strArray2[index], maxamount));
                      Spawn2.IsSelected = false;
                      if (flag2)
                        Spawn2.SpawnSpawnRange = 0;
                      this._Editor.tvwSpawnPoints.Nodes.Add((TreeNode) new SpawnPointNode(Spawn2));
                      ++num3;
                    }
                  }
                }
                else
                  ++num4;
              }
            }
            streamReader.Close();
          }
        }
        catch
        {
        }
        processedmaps = 1;
        processedspawners = num3;
      }
      else
      {
        if (!Directory.Exists(filename))
          return;
        string[] strArray1 = (string[]) null;
        try
        {
          strArray1 = Directory.GetFiles(filename, "*.map");
        }
        catch
        {
        }
        if (strArray1 != null && strArray1.Length > 0)
        {
          foreach (string filename1 in strArray1)
          {
            this.DoImportMap(filename1, out processedmaps, out processedspawners);
            num1 += processedmaps;
            num2 += processedspawners;
          }
        }
        string[] strArray2 = (string[]) null;
        try
        {
          strArray2 = Directory.GetDirectories(filename);
        }
        catch
        {
        }
        if (strArray2 != null && strArray2.Length > 0)
        {
          foreach (string filename1 in strArray2)
          {
            this.DoImportMap(filename1, out processedmaps, out processedspawners);
            num1 += processedmaps;
            num2 += processedspawners;
          }
        }
        processedmaps = num1;
        processedspawners = num2;
      }
    }
  }
}
