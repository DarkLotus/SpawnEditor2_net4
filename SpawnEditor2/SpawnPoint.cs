// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.SpawnPoint
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;

namespace SpawnEditor2
{
  public class SpawnPoint
  {
    public bool SpawnIsRunning = true;
    public ArrayList SpawnObjects = new ArrayList();
    public int SpawnProximityRange = -1;
    public int SpawnKillReset = 1;
    public int SpawnProximitySnd = 500;
    public int SpawnSequentialSpawn = -1;
    public double SpawnTriggerProbability = 1.0;
    public int SpawnStackAmount = 1;
    public short CentreX;
    public short CentreY;
    public short CentreZ;
    public short Range;
    public int Index;
    private Rectangle _Bounds;
    public bool IsSelected;
    public string XmlFileName;
    public string SpawnName;
    private int _SpawnHomeRange;
    public bool SpawnHomeRangeIsRelative;
    public int SpawnMaxCount;
    public double SpawnMinDelay;
    public double SpawnMaxDelay;
    public int SpawnTeam;
    public bool SpawnIsGroup;
    public WorldMap Map;
    public Guid UnqiueId;
    public double SpawnDuration;
    public double SpawnDespawn;
    public double SpawnMinRefract;
    public double SpawnMaxRefract;
    public double SpawnTODStart;
    public double SpawnTODEnd;
    public bool SpawnAllowGhost;
    public bool SpawnSpawnOnTrigger;
    public bool SpawnSmartSpawning;
    public int SpawnTODMode;
    public string SpawnSkillTrigger;
    public string SpawnSpeechTrigger;
    public string SpawnProximityMsg;
    public string SpawnMobTriggerName;
    public string SpawnMobTrigProp;
    public string SpawnPlayerTrigProp;
    public string SpawnTrigObjectProp;
    public string SpawnTriggerOnCarried;
    public string SpawnNoTriggerOnCarried;
    public bool SpawnInContainer;
    public string SpawnRegionName;
    public string SpawnConfigFile;
    public string SpawnObjectPropertyItemName;
    public string SpawnSetPropertyItemName;
    public bool SpawnExternalTriggering;
    public string SpawnWaypoint;
    public int SpawnContainerX;
    public int SpawnContainerY;
    public int SpawnContainerZ;
    public string SpawnNotes;

    public int SpawnSpawnRange
    {
      get
      {
        Rectangle bounds1 = this.Bounds;
        int width = bounds1.Width;
        bounds1 = this.Bounds;
        int height = bounds1.Height;
        if (width == height)
        {
          int num1 = (int) this.CentreX;
          int x = this.Bounds.X;
          Rectangle bounds2 = this.Bounds;
          int num2 = bounds2.Width / 2;
          int num3 = x + num2;
          if (num1 == num3)
          {
            int num4 = (int) this.CentreY;
            bounds2 = this.Bounds;
            int y = bounds2.Y;
            bounds2 = this.Bounds;
            int num5 = bounds2.Height / 2;
            int num6 = y + num5;
            if (num4 == num6)
            {
              bounds2 = this.Bounds;
              return bounds2.Width / 2;
            }
          }
        }
        return -1;
      }
      set
      {
        if (value < 0)
          return;
        this.Bounds = new Rectangle((int) this.CentreX - value, (int) this.CentreY - value, value * 2, value * 2);
      }
    }

    public double MinDelay
    {
      get
      {
        return this.SpawnMinDelay;
      }
      set
      {
        this.SpawnMinDelay = value;
      }
    }

    public double MaxDelay
    {
      get
      {
        return this.SpawnMaxDelay;
      }
      set
      {
        this.SpawnMaxDelay = value;
      }
    }

    public int HomeRange
    {
      get
      {
        return this.SpawnHomeRange;
      }
      set
      {
        this.SpawnHomeRange = value;
      }
    }

    public int MaxCount
    {
      get
      {
        return this.SpawnMaxCount;
      }
      set
      {
        this.SpawnMaxCount = value;
      }
    }

    public int Team
    {
      get
      {
        return this.SpawnTeam;
      }
      set
      {
        this.SpawnTeam = value;
      }
    }

    public int SpawnRange
    {
      get
      {
        return this.SpawnSpawnRange;
      }
      set
      {
        this.SpawnSpawnRange = value;
      }
    }

    public int ProximityRange
    {
      get
      {
        return this.SpawnProximityRange;
      }
      set
      {
        this.SpawnProximityRange = value;
      }
    }

    public double Duration
    {
      get
      {
        return this.SpawnDuration;
      }
      set
      {
        this.SpawnDuration = value;
      }
    }

    public double Despawn
    {
      get
      {
        return this.SpawnDespawn;
      }
      set
      {
        this.SpawnDespawn = value;
      }
    }

    public double MinRefract
    {
      get
      {
        return this.SpawnMinRefract;
      }
      set
      {
        this.SpawnMinRefract = value;
      }
    }

    public double MaxRefract
    {
      get
      {
        return this.SpawnMaxRefract;
      }
      set
      {
        this.SpawnMaxRefract = value;
      }
    }

    public double TODStart
    {
      get
      {
        return this.SpawnTODStart;
      }
      set
      {
        this.SpawnTODStart = value;
      }
    }

    public double TODEnd
    {
      get
      {
        return this.SpawnTODEnd;
      }
      set
      {
        this.SpawnTODEnd = value;
      }
    }

    public int KillReset
    {
      get
      {
        return this.SpawnKillReset;
      }
      set
      {
        this.SpawnKillReset = value;
      }
    }

    public int ProximitySnd
    {
      get
      {
        return this.SpawnProximitySnd;
      }
      set
      {
        this.SpawnProximitySnd = value;
      }
    }

    public bool Group
    {
      get
      {
        return this.SpawnIsGroup;
      }
      set
      {
        this.SpawnIsGroup = value;
      }
    }

    public bool Running
    {
      get
      {
        return this.SpawnIsRunning;
      }
      set
      {
        this.SpawnIsRunning = value;
      }
    }

    public bool RelativeHome
    {
      get
      {
        return this.SpawnHomeRangeIsRelative;
      }
      set
      {
        this.SpawnHomeRangeIsRelative = value;
      }
    }

    public bool InContainer
    {
      get
      {
        return this.SpawnInContainer;
      }
      set
      {
        this.SpawnInContainer = value;
      }
    }

    public bool AllowGhost
    {
      get
      {
        return this.SpawnAllowGhost;
      }
      set
      {
        this.SpawnAllowGhost = value;
      }
    }

    public int TODMode
    {
      get
      {
        return this.SpawnTODMode;
      }
      set
      {
        this.SpawnTODMode = value;
      }
    }

    public bool RealTOD
    {
      get
      {
        return this.SpawnTODMode == 0;
      }
      set
      {
        if (value)
          this.SpawnTODMode = 0;
        else
          this.SpawnTODMode = 1;
      }
    }

    public bool GameTOD
    {
      get
      {
        return this.SpawnTODMode == 1;
      }
      set
      {
        if (value)
          this.SpawnTODMode = 1;
        else
          this.SpawnTODMode = 0;
      }
    }

    public bool SpawnOnTrigger
    {
      get
      {
        return this.SpawnSpawnOnTrigger;
      }
      set
      {
        this.SpawnSpawnOnTrigger = value;
      }
    }

    public bool SequentialSpawn
    {
      get
      {
        return this.SpawnSequentialSpawn >= 0;
      }
      set
      {
        if (value)
          this.SpawnSequentialSpawn = 0;
        else
          this.SpawnSequentialSpawn = -1;
      }
    }

    public bool SmartSpawning
    {
      get
      {
        return this.SpawnSmartSpawning;
      }
      set
      {
        this.SpawnSmartSpawning = value;
      }
    }

    public string SkillTrigger
    {
      get
      {
        return this.SpawnSkillTrigger;
      }
      set
      {
        this.SpawnSkillTrigger = value;
      }
    }

    public string SpeechTrigger
    {
      get
      {
        return this.SpawnSpeechTrigger;
      }
      set
      {
        this.SpawnSpeechTrigger = value;
      }
    }

    public string ProximityMsg
    {
      get
      {
        return this.SpawnProximityMsg;
      }
      set
      {
        this.SpawnProximityMsg = value;
      }
    }

    public string PlayerTrigProp
    {
      get
      {
        return this.SpawnPlayerTrigProp;
      }
      set
      {
        this.SpawnPlayerTrigProp = value;
      }
    }

    public string TrigObjectProp
    {
      get
      {
        return this.SpawnTrigObjectProp;
      }
      set
      {
        this.SpawnTrigObjectProp = value;
      }
    }

    public string TriggerOnCarried
    {
      get
      {
        return this.SpawnTriggerOnCarried;
      }
      set
      {
        this.SpawnTriggerOnCarried = value;
      }
    }

    public string NoTriggerOnCarried
    {
      get
      {
        return this.SpawnNoTriggerOnCarried;
      }
      set
      {
        this.SpawnNoTriggerOnCarried = value;
      }
    }

    public int StackAmount
    {
      get
      {
        return this.SpawnStackAmount;
      }
      set
      {
        this.SpawnStackAmount = value;
      }
    }

    public double TriggerProbability
    {
      get
      {
        return this.SpawnTriggerProbability;
      }
      set
      {
        this.SpawnTriggerProbability = value;
      }
    }

    public bool ExternalTriggering
    {
      get
      {
        return this.SpawnExternalTriggering;
      }
      set
      {
        this.SpawnExternalTriggering = value;
      }
    }

    public int ContainerX
    {
      get
      {
        return this.SpawnContainerX;
      }
      set
      {
        this.SpawnContainerX = value;
      }
    }

    public int ContainerY
    {
      get
      {
        return this.SpawnContainerY;
      }
      set
      {
        this.SpawnContainerY = value;
      }
    }

    public int ContainerZ
    {
      get
      {
        return this.SpawnContainerZ;
      }
      set
      {
        this.SpawnContainerZ = value;
      }
    }

    public string RegionName
    {
      get
      {
        return this.SpawnRegionName;
      }
      set
      {
        this.SpawnRegionName = value;
      }
    }

    public string WaypointName
    {
      get
      {
        return this.SpawnWaypoint;
      }
      set
      {
        this.SpawnWaypoint = value;
      }
    }

    public string ConfigFile
    {
      get
      {
        return this.SpawnConfigFile;
      }
      set
      {
        this.SpawnConfigFile = value;
      }
    }

    public string MobTriggerName
    {
      get
      {
        return this.SpawnMobTriggerName;
      }
      set
      {
        this.SpawnMobTriggerName = value;
      }
    }

    public string MobTrigProp
    {
      get
      {
        return this.SpawnMobTrigProp;
      }
      set
      {
        this.SpawnMobTrigProp = value;
      }
    }

    public string TrigObjectName
    {
      get
      {
        return this.SpawnObjectPropertyItemName;
      }
      set
      {
        this.SpawnObjectPropertyItemName = value;
      }
    }

    public string SetObjectName
    {
      get
      {
        return this.SpawnSetPropertyItemName;
      }
      set
      {
        this.SpawnSetPropertyItemName = value;
      }
    }

    public Rectangle Bounds
    {
      get
      {
        return this._Bounds;
      }
      set
      {
        this._Bounds = value;
      }
    }

    public int SpawnHomeRange
    {
      get
      {
        return this._SpawnHomeRange;
      }
      set
      {
        this._SpawnHomeRange = value;
      }
    }

    public int Area
    {
      get
      {
        Rectangle bounds = this.Bounds;
        int width = bounds.Width;
        bounds = this.Bounds;
        int height = bounds.Height;
        return width * height;
      }
    }

    public SpawnPoint(Guid unqiueId, WorldMap Map, short MapX, short MapY, short MapWidth, short MapHeight)
    {
      this.UnqiueId = unqiueId;
      this.Map = Map;
      this.Index = -1;
      this.IsSelected = true;
      this.Bounds = new Rectangle((int) MapX - (int) MapWidth / 2, (int) MapY - (int) MapHeight / 2, (int) MapWidth, (int) MapHeight);
      this.CentreX = MapX;
      this.CentreY = MapY;
      this.SpawnName = "Spawn Point " + this.Bounds.ToString();
    }

    public SpawnPoint(Guid uniqueId, WorldMap Map, Rectangle SpawnBounds)
    {
      this.UnqiueId = uniqueId;
      this.Map = Map;
      this.Index = -1;
      this.IsSelected = true;
      this.Bounds = SpawnBounds;
      Rectangle bounds1 = this.Bounds;
      int x = bounds1.X;
      bounds1 = this.Bounds;
      int num1 = bounds1.Width / 2;
      this.CentreX = (short) (x + num1);
      Rectangle bounds2 = this.Bounds;
      int y = bounds2.Y;
      bounds2 = this.Bounds;
      int num2 = bounds2.Height / 2;
      this.CentreY = (short) (y + num2);
      this.SpawnName = "Spawn Point " + this.Bounds.ToString();
    }

    public SpawnPoint(XmlElement node, WorldMap ForceMap, bool ForceGuid)
    {
      int num1 = 0;
      Guid guid = Guid.NewGuid();
      if (!ForceGuid)
      {
        string text = SpawnPoint.GetText(node["UniqueId"], "Error");
        if (text != "Error")
          guid = new Guid(text);
      }
      WorldMap worldMap = ForceMap;
      if (ForceMap == WorldMap.Internal)
      {
        worldMap = WorldMap.Trammel;
        try
        {
          worldMap = (WorldMap) Enum.Parse(typeof (WorldMap), SpawnPoint.GetText(node["Map"], "Trammel"));
        }
        catch
        {
        }
      }
      bool flag1 = false;
      try
      {
        flag1 = bool.Parse(SpawnPoint.GetText(node["IsHomeRangeRelative"], "false"));
      }
      catch
      {
        ++num1;
      }
      int x = int.Parse(SpawnPoint.GetText(node["X"], "0"));
      int y = int.Parse(SpawnPoint.GetText(node["Y"], "0"));
      int width = int.Parse(SpawnPoint.GetText(node["Width"], "0"));
      int height = int.Parse(SpawnPoint.GetText(node["Height"], "0"));
      this.UnqiueId = guid;
      this.Map = worldMap;
      this._Bounds = new Rectangle(x, y, width, height);
      this.SpawnName = SpawnPoint.GetText(node["Name"], "Spawner");
      this.CentreX = short.Parse(SpawnPoint.GetText(node["CentreX"], "0"));
      this.CentreY = short.Parse(SpawnPoint.GetText(node["CentreY"], "0"));
      this.CentreZ = short.Parse(SpawnPoint.GetText(node["CentreZ"], "0"));
      this._SpawnHomeRange = int.Parse(SpawnPoint.GetText(node["Range"], "0"));
      this.SpawnMaxCount = int.Parse(SpawnPoint.GetText(node["MaxCount"], "0"));
      bool flag2 = false;
      try
      {
        flag2 = bool.Parse(SpawnPoint.GetText(node["DelayInSec"], "false"));
      }
      catch
      {
        ++num1;
      }
      if (flag2)
      {
        this.SpawnMinDelay = double.Parse(SpawnPoint.GetText(node["MinDelay"], "0")) / 60.0;
        this.SpawnMaxDelay = double.Parse(SpawnPoint.GetText(node["MaxDelay"], "0")) / 60.0;
      }
      else
      {
        this.SpawnMinDelay = double.Parse(SpawnPoint.GetText(node["MinDelay"], "0"));
        this.SpawnMaxDelay = double.Parse(SpawnPoint.GetText(node["MaxDelay"], "0"));
      }
      this.SpawnTeam = int.Parse(SpawnPoint.GetText(node["Team"], "0"));
      this.SpawnIsGroup = bool.Parse(SpawnPoint.GetText(node["IsGroup"], "false"));
      this.SpawnIsRunning = bool.Parse(SpawnPoint.GetText(node["IsRunning"], "false"));
      this.SpawnHomeRangeIsRelative = flag1;
      this.SpawnProximityRange = -1;
      try
      {
        this.SpawnProximityRange = int.Parse(SpawnPoint.GetText(node["ProximityRange"], "-1"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnDuration = double.Parse(SpawnPoint.GetText(node["Duration"], "0"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnDespawn = double.Parse(SpawnPoint.GetText(node["DespawnTime"], "0"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnMinRefract = double.Parse(SpawnPoint.GetText(node["MinRefractory"], "0"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnMaxRefract = double.Parse(SpawnPoint.GetText(node["MaxRefractory"], "0"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnTODStart = double.Parse(SpawnPoint.GetText(node["TODStart"], "0")) / 60.0;
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnTODEnd = double.Parse(SpawnPoint.GetText(node["TODEnd"], "0")) / 60.0;
      }
      catch
      {
        ++num1;
      }
      this.SpawnKillReset = 1;
      try
      {
        this.SpawnKillReset = int.Parse(SpawnPoint.GetText(node["KillReset"], "1"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnProximitySnd = int.Parse(SpawnPoint.GetText(node["ProximityTriggerSound"], "500"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnAllowGhost = bool.Parse(SpawnPoint.GetText(node["AllowGhostTriggering"], "false"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnSpawnOnTrigger = bool.Parse(SpawnPoint.GetText(node["SpawnOnTrigger"], "false"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnSequentialSpawn = int.Parse(SpawnPoint.GetText(node["SequentialSpawning"], "-1"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnSmartSpawning = bool.Parse(SpawnPoint.GetText(node["SmartSpawning"], "false"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnTODMode = int.Parse(SpawnPoint.GetText(node["TODMode"], "0"));
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnSkillTrigger = SpawnPoint.GetText(node["SkillTrigger"], (string) null);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnSpeechTrigger = SpawnPoint.GetText(node["SpeechTrigger"], (string) null);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnProximityMsg = SpawnPoint.GetText(node["ProximityTriggerMessage"], (string) null);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnMobTriggerName = SpawnPoint.GetText(node["MobTriggerName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnMobTrigProp = SpawnPoint.GetText(node["MobPropertyName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnPlayerTrigProp = SpawnPoint.GetText(node["PlayerPropertyName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnTrigObjectProp = SpawnPoint.GetText(node["ObjectPropertyName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnTriggerOnCarried = SpawnPoint.GetText(node["ItemTriggerName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnNoTriggerOnCarried = SpawnPoint.GetText(node["NoItemTriggerName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      this.SpawnInContainer = false;
      this.SpawnContainerX = 0;
      this.SpawnContainerY = 0;
      this.SpawnContainerZ = 0;
      try
      {
        this.SpawnInContainer = bool.Parse(SpawnPoint.GetText(node["InContainer"], "false"));
      }
      catch
      {
        ++num1;
      }
      if (this.SpawnInContainer)
      {
        try
        {
          this.SpawnContainerX = int.Parse(SpawnPoint.GetText(node["ContainerX"], "0"));
        }
        catch
        {
          ++num1;
        }
        try
        {
          this.SpawnContainerY = int.Parse(SpawnPoint.GetText(node["ContainerY"], "0"));
        }
        catch
        {
          ++num1;
        }
        try
        {
          this.SpawnContainerZ = int.Parse(SpawnPoint.GetText(node["ContainerZ"], "0"));
        }
        catch
        {
          ++num1;
        }
      }
      this.SpawnTriggerProbability = 1.0;
      try
      {
        this.SpawnTriggerProbability = double.Parse(SpawnPoint.GetText(node["TriggerProbability"], "1"));
      }
      catch
      {
        ++num1;
      }
      this.SpawnRegionName = (string) null;
      try
      {
        this.SpawnRegionName = SpawnPoint.GetText(node["RegionName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      this.SpawnConfigFile = (string) null;
      try
      {
        this.SpawnConfigFile = SpawnPoint.GetText(node["ConfigFile"], (string) null);
      }
      catch
      {
        ++num1;
      }
      this.SpawnObjectPropertyItemName = (string) null;
      try
      {
        this.SpawnObjectPropertyItemName = SpawnPoint.GetText(node["ObjectPropertyItemName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      this.SpawnSetPropertyItemName = (string) null;
      try
      {
        this.SpawnSetPropertyItemName = SpawnPoint.GetText(node["SetPropertyItemName"], (string) null);
      }
      catch
      {
        ++num1;
      }
      this.SpawnStackAmount = 1;
      try
      {
        this.SpawnStackAmount = int.Parse(SpawnPoint.GetText(node["Amount"], "1"));
      }
      catch
      {
        ++num1;
      }
      this.SpawnExternalTriggering = false;
      try
      {
        this.SpawnExternalTriggering = bool.Parse(SpawnPoint.GetText(node["ExternalTriggering"], "false"));
      }
      catch
      {
        ++num1;
      }
      this.SpawnWaypoint = (string) null;
      try
      {
        this.SpawnWaypoint = SpawnPoint.GetText(node["Waypoint"], (string) null);
      }
      catch
      {
        ++num1;
      }
      bool flag3 = true;
      try
      {
        string text = SpawnPoint.GetText(node["Objects2"], (string) null);
        if (text != null)
          this.LoadSpawnObjectsFromString2(text);
        else
          flag3 = false;
      }
      catch
      {
        flag3 = false;
      }
      if (!flag3)
      {
        try
        {
          this.LoadSpawnObjectsFromString(SpawnPoint.GetText(node["Objects"], (string) null));
        }
        catch
        {
        }
      }
      try
      {
        this.SpawnNotes = SpawnPoint.GetText(node["Notes"], (string) null);
      }
      catch
      {
        int num2 = num1 + 1;
      }
      this.IsSelected = false;
    }

    public SpawnPoint(DataRow SpawnRow)
    {
      int num1 = 0;
      Guid guid = Guid.NewGuid();
      try
      {
        guid = new Guid((string) SpawnRow["UniqueId"]);
      }
      catch
      {
      }
      WorldMap worldMap = WorldMap.Trammel;
      try
      {
        worldMap = (WorldMap) Enum.Parse(typeof (WorldMap), (string) SpawnRow["Map"], true);
      }
      catch
      {
        ++num1;
      }
      bool flag1 = false;
      try
      {
        flag1 = bool.Parse((string) SpawnRow["IsHomeRangeRelative"]);
      }
      catch
      {
        ++num1;
      }
      int x = int.Parse((string) SpawnRow["X"]);
      int y = int.Parse((string) SpawnRow["Y"]);
      int width = int.Parse((string) SpawnRow["Width"]);
      int height = int.Parse((string) SpawnRow["Height"]);
      this.UnqiueId = guid;
      this.Map = worldMap;
      this._Bounds = new Rectangle(x, y, width, height);
      this.SpawnName = (string) SpawnRow["Name"];
      this.CentreX = short.Parse((string) SpawnRow["CentreX"]);
      this.CentreY = short.Parse((string) SpawnRow["CentreY"]);
      this.CentreZ = short.Parse((string) SpawnRow["CentreZ"]);
      this._SpawnHomeRange = int.Parse((string) SpawnRow["Range"]);
      this.SpawnMaxCount = int.Parse((string) SpawnRow["MaxCount"]);
      bool flag2 = false;
      try
      {
        flag2 = bool.Parse((string) SpawnRow["DelayInSec"]);
      }
      catch
      {
        ++num1;
      }
      if (flag2)
      {
        this.SpawnMinDelay = double.Parse((string) SpawnRow["MinDelay"]) / 60.0;
        this.SpawnMaxDelay = double.Parse((string) SpawnRow["MaxDelay"]) / 60.0;
      }
      else
      {
        this.SpawnMinDelay = double.Parse((string) SpawnRow["MinDelay"]);
        this.SpawnMaxDelay = double.Parse((string) SpawnRow["MaxDelay"]);
      }
      this.SpawnTeam = int.Parse((string) SpawnRow["Team"]);
      this.SpawnIsGroup = bool.Parse((string) SpawnRow["IsGroup"]);
      this.SpawnIsRunning = bool.Parse((string) SpawnRow["IsRunning"]);
      this.SpawnHomeRangeIsRelative = flag1;
      this.SpawnProximityRange = -1;
      try
      {
        this.SpawnProximityRange = int.Parse((string) SpawnRow["ProximityRange"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnDuration = double.Parse((string) SpawnRow["Duration"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnDespawn = double.Parse((string) SpawnRow["DespawnTime"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnMinRefract = double.Parse((string) SpawnRow["MinRefractory"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnMaxRefract = double.Parse((string) SpawnRow["MaxRefractory"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnTODStart = double.Parse((string) SpawnRow["TODStart"]) / 60.0;
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnTODEnd = double.Parse((string) SpawnRow["TODEnd"]) / 60.0;
      }
      catch
      {
        ++num1;
      }
      this.SpawnKillReset = 1;
      try
      {
        this.SpawnKillReset = int.Parse((string) SpawnRow["KillReset"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnProximitySnd = int.Parse((string) SpawnRow["ProximityTriggerSound"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnAllowGhost = bool.Parse((string) SpawnRow["AllowGhostTriggering"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnSpawnOnTrigger = bool.Parse((string) SpawnRow["SpawnOnTrigger"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnSequentialSpawn = int.Parse((string) SpawnRow["SequentialSpawning"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        this.SpawnSmartSpawning = bool.Parse((string) SpawnRow["SmartSpawning"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("TODMode"))
          this.SpawnTODMode = int.Parse((string) SpawnRow["TODMode"]);
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("SkillTrigger"))
          this.SpawnSkillTrigger = (string) SpawnRow["SkillTrigger"];
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("SpeechTrigger"))
          this.SpawnSpeechTrigger = (string) SpawnRow["SpeechTrigger"];
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("ProximityTriggerMessage"))
          this.SpawnProximityMsg = (string) SpawnRow["ProximityTriggerMessage"];
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("MobTriggerName"))
          this.SpawnMobTriggerName = (string) SpawnRow["MobTriggerName"];
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("MobPropertyName"))
          this.SpawnMobTrigProp = (string) SpawnRow["MobPropertyName"];
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("PlayerPropertyName"))
          this.SpawnPlayerTrigProp = (string) SpawnRow["PlayerPropertyName"];
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("ObjectPropertyName"))
          this.SpawnTrigObjectProp = (string) SpawnRow["ObjectPropertyName"];
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("ItemTriggerName"))
          this.SpawnTriggerOnCarried = (string) SpawnRow["ItemTriggerName"];
      }
      catch
      {
        ++num1;
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("NoItemTriggerName"))
          this.SpawnNoTriggerOnCarried = (string) SpawnRow["NoItemTriggerName"];
      }
      catch
      {
        ++num1;
      }
      this.SpawnInContainer = false;
      this.SpawnContainerX = 0;
      this.SpawnContainerY = 0;
      this.SpawnContainerZ = 0;
      try
      {
        if (SpawnRow.Table.Columns.Contains("InContainer"))
          this.SpawnInContainer = bool.Parse((string) SpawnRow["InContainer"]);
      }
      catch
      {
        ++num1;
      }
      if (this.SpawnInContainer)
      {
        try
        {
          this.SpawnContainerX = int.Parse((string) SpawnRow["ContainerX"]);
        }
        catch
        {
          ++num1;
        }
        try
        {
          this.SpawnContainerY = int.Parse((string) SpawnRow["ContainerY"]);
        }
        catch
        {
          ++num1;
        }
        try
        {
          this.SpawnContainerZ = int.Parse((string) SpawnRow["ContainerZ"]);
        }
        catch
        {
          ++num1;
        }
      }
      this.SpawnTriggerProbability = 1.0;
      try
      {
        if (SpawnRow.Table.Columns.Contains("TriggerProbability"))
          this.SpawnTriggerProbability = double.Parse((string) SpawnRow["TriggerProbability"]);
      }
      catch
      {
        ++num1;
      }
      this.SpawnRegionName = (string) null;
      try
      {
        if (SpawnRow.Table.Columns.Contains("RegionName"))
          this.SpawnRegionName = (string) SpawnRow["RegionName"];
      }
      catch
      {
        ++num1;
      }
      this.SpawnConfigFile = (string) null;
      try
      {
        if (SpawnRow.Table.Columns.Contains("ConfigFile"))
          this.SpawnConfigFile = (string) SpawnRow["ConfigFile"];
      }
      catch
      {
        ++num1;
      }
      this.SpawnObjectPropertyItemName = (string) null;
      try
      {
        if (SpawnRow.Table.Columns.Contains("ObjectPropertyItemName"))
          this.SpawnObjectPropertyItemName = (string) SpawnRow["ObjectPropertyItemName"];
      }
      catch
      {
        ++num1;
      }
      this.SpawnSetPropertyItemName = (string) null;
      try
      {
        if (SpawnRow.Table.Columns.Contains("SetPropertyItemName"))
          this.SpawnSetPropertyItemName = (string) SpawnRow["SetPropertyItemName"];
      }
      catch
      {
        ++num1;
      }
      this.SpawnStackAmount = 1;
      try
      {
        if (SpawnRow.Table.Columns.Contains("Amount"))
          this.SpawnStackAmount = int.Parse((string) SpawnRow["Amount"]);
      }
      catch
      {
        ++num1;
      }
      this.SpawnExternalTriggering = false;
      try
      {
        if (SpawnRow.Table.Columns.Contains("ExternalTriggering"))
          this.SpawnExternalTriggering = bool.Parse((string) SpawnRow["ExternalTriggering"]);
      }
      catch
      {
        ++num1;
      }
      this.SpawnWaypoint = (string) null;
      try
      {
        if (SpawnRow.Table.Columns.Contains("Waypoint"))
          this.SpawnWaypoint = (string) SpawnRow["Waypoint"];
      }
      catch
      {
        ++num1;
      }
      bool flag3 = true;
      try
      {
        if (SpawnRow.Table.Columns.Contains("Objects2"))
          this.LoadSpawnObjectsFromString2((string) SpawnRow["Objects2"]);
        else
          flag3 = false;
      }
      catch
      {
        flag3 = false;
      }
      if (!flag3)
      {
        try
        {
          this.LoadSpawnObjectsFromString((string) SpawnRow["Objects"]);
        }
        catch
        {
        }
      }
      try
      {
        if (SpawnRow.Table.Columns.Contains("Notes"))
          this.SpawnNotes = (string) SpawnRow["Notes"];
      }
      catch
      {
        int num2 = num1 + 1;
      }
      this.IsSelected = false;
    }

    private static string GetText(XmlElement node, string defaultValue)
    {
      if (node == null)
        return defaultValue;
      return node.InnerText;
    }

    public bool IsSameArea(short MapX, short MapY, short Range)
    {
      Rectangle rect = new Rectangle((int) MapX - (int) Range, (int) MapY - (int) Range, (int) Range * 2, (int) Range * 2);
      if (!this.Bounds.IntersectsWith(rect))
        return rect.Contains((int) this.CentreX, (int) this.CentreY);
      return true;
    }

    public bool IsSameArea(short MapX, short MapY)
    {
      int num = 2;
      Rectangle rectangle = new Rectangle((int) MapX - num, (int) MapY - num, num * 2, num * 2);
      if (!this.Bounds.Contains((int) MapX, (int) MapY))
        return rectangle.Contains((int) this.CentreX, (int) this.CentreY);
      return true;
    }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.SpawnName);
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append("==============================");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append(this.Bounds.ToString());
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.AppendFormat("Home Range: {0}", (object) this.SpawnHomeRange);
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.AppendFormat("Maximum: {0}", (object) this.SpawnMaxCount);
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.AppendFormat("Delay: {0}m - {1}m", (object) this.SpawnMinDelay, (object) this.SpawnMaxDelay);
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.AppendFormat("Team: {0}", (object) this.SpawnTeam);
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.AppendFormat("Grouped [{0}]", this.SpawnIsGroup ? (object) "True" : (object) "False");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.AppendFormat("Running [{0}]", this.SpawnIsRunning ? (object) "True" : (object) "False");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.AppendFormat("Relative Home Range [{0}]", this.SpawnHomeRangeIsRelative ? (object) "True" : (object) "False");
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.AppendFormat("Avg. Spawns per 32x32 area [{0:###.####}]", (object) (SpawnEditor.ComputeDensity(this) * 1024.0));
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append("==============================");
      if (this.SpawnNotes != null && this.SpawnNotes.Length > 0)
      {
        stringBuilder.Append(Environment.NewLine);
        stringBuilder.Append(this.SpawnNotes);
        stringBuilder.Append(Environment.NewLine);
        stringBuilder.Append("==============================");
      }
      for (int index = 0; index < this.SpawnObjects.Count; ++index)
      {
        SpawnObject spawnObject = this.SpawnObjects[index] as SpawnObject;
        if (spawnObject != null)
        {
          stringBuilder.Append(Environment.NewLine);
          stringBuilder.AppendFormat("{0} [Max:{1}]", (object) spawnObject.TypeName, (object) spawnObject.Count);
        }
      }
      return stringBuilder.ToString();
    }

    public string GetSerializedObjectList()
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (SpawnObject spawnObject in this.SpawnObjects)
      {
        if (stringBuilder.Length > 0)
          stringBuilder.Append(':');
        stringBuilder.AppendFormat("{0}={1}", (object) spawnObject.TypeName, (object) spawnObject.Count);
      }
      return stringBuilder.ToString();
    }

    public string GetSerializedObjectList2()
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (SpawnObject spawnObject in this.SpawnObjects)
      {
        if (stringBuilder.Length > 0)
          stringBuilder.Append(":OBJ=");
        stringBuilder.AppendFormat("{0}:MX={1}:SB={2}:RT={3}:TO={4}:KL={5}:RK={6}:CA={7}:DN={8}:DX={9}:SP={10}", (object) spawnObject.TypeName, (object) spawnObject.Count, (object) spawnObject.SubGroup, (object) spawnObject.SequentialResetTime, (object) spawnObject.SequentialResetTo, (object) spawnObject.KillsNeeded, (object) (spawnObject.RestrictKillsToSubgroup ? 1 : 0), (object) (spawnObject.ClearOnAdvance ? 1 : 0), (object) spawnObject.MinDelay, (object) spawnObject.MaxDelay, (object) spawnObject.SpawnsPerTick);
      }
      return stringBuilder.ToString();
    }

    public void LoadSpawnObjectsFromString(string SerializedObjectList)
    {
      this.SpawnObjects.Clear();
      if (SerializedObjectList.Length <= 0)
        return;
      string str1 = SerializedObjectList;
      char[] chArray1 = new char[1]
      {
        ':'
      };
      foreach (string str2 in str1.Split(chArray1))
      {
        char[] chArray2 = new char[1]
        {
          '='
        };
        string[] strArray = str2.Split(chArray2);
        if (strArray.Length == 2 && strArray[0].Length > 0 && strArray[1].Length > 0)
        {
          int maxamount = 1;
          try
          {
            maxamount = int.Parse(strArray[1]);
          }
          catch (Exception ex)
          {
          }
          this.SpawnObjects.Add((object) new SpawnObject(strArray[0], maxamount));
        }
      }
    }

    public void LoadSpawnObjectsFromString2(string SerializedObjectList)
    {
      this.SpawnObjects.Clear();
      if (SerializedObjectList == null || SerializedObjectList.Length <= 0)
        return;
      foreach (string str in SpawnObject.SplitString(SerializedObjectList, ":OBJ="))
      {
        string[] strArray = SpawnObject.SplitString(str, ":MX=");
        if (strArray.Length == 2 && strArray[0].Length > 0 && strArray[1].Length > 0)
        {
          string parm1 = SpawnObject.GetParm(str, ":MX=");
          int maxamount = 1;
          try
          {
            maxamount = int.Parse(parm1);
          }
          catch
          {
          }
          string parm2 = SpawnObject.GetParm(str, ":SB=");
          int subgroup = 0;
          try
          {
            subgroup = int.Parse(parm2);
          }
          catch
          {
          }
          string parm3 = SpawnObject.GetParm(str, ":RT=");
          double sequentialresettime = 0.0;
          try
          {
            sequentialresettime = double.Parse(parm3);
          }
          catch
          {
          }
          string parm4 = SpawnObject.GetParm(str, ":TO=");
          int sequentialresetto = 0;
          try
          {
            sequentialresetto = int.Parse(parm4);
          }
          catch
          {
          }
          string parm5 = SpawnObject.GetParm(str, ":KL=");
          int killsneeded = 0;
          try
          {
            killsneeded = int.Parse(parm5);
          }
          catch
          {
          }
          string parm6 = SpawnObject.GetParm(str, ":RK=");
          bool restrictkills = false;
          if (parm6 != null)
          {
            try
            {
              restrictkills = int.Parse(parm6) == 1;
            }
            catch
            {
            }
          }
          string parm7 = SpawnObject.GetParm(str, ":CA=");
          bool clearadvance = true;
          if (killsneeded == 0)
            clearadvance = false;
          if (parm7 != null)
          {
            try
            {
              clearadvance = int.Parse(parm7) == 1;
            }
            catch
            {
            }
          }
          string parm8 = SpawnObject.GetParm(str, ":DN=");
          double mindelay = -1.0;
          try
          {
            mindelay = double.Parse(parm8);
          }
          catch
          {
          }
          string parm9 = SpawnObject.GetParm(str, ":DX=");
          double maxdelay = -1.0;
          try
          {
            maxdelay = double.Parse(parm9);
          }
          catch
          {
          }
          string parm10 = SpawnObject.GetParm(str, ":SP=");
          int spawnsper = 1;
          try
          {
            spawnsper = int.Parse(parm10);
          }
          catch
          {
          }
          this.SpawnObjects.Add((object) new SpawnObject(strArray[0], maxamount, subgroup, sequentialresettime, sequentialresetto, killsneeded, restrictkills, clearadvance, mindelay, maxdelay, spawnsper));
        }
      }
    }
  }
}
