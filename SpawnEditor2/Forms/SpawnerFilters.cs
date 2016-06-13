// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.Forms.SpawnerFilters
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using SpawnEditor2;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SpawnEditor2.Forms
{
  public class SpawnerFilters : Form
  {
    private Container components = (Container) null;
    private GroupBox groupBox1;
    private Label label18;
    private NumericUpDown numAvgSpawnTime;
    private ComboBox cmbAvgSpawnTime;
    private CheckBox chkAvgSpawnTime;
    private Label label17;
    internal ComboBox cmbRunning;
    private Label label16;
    internal ComboBox cmbProximity;
    internal CheckBox chkNameCase;
    internal CheckBox chkEntryCase;
    private Label label4;
    private Label label3;
    private Label label1;
    internal ComboBox cmbSequential;
    internal ComboBox cmbInContainers;
    internal ComboBox cmbSmartSpawning;
    internal TextBox txtSpawnerEntry;
    private Label label38;
    internal TextBox txtSpawnerName;
    private Label label30;
    internal TextBox txtSpawnerEntryType;
    private Label label2;
    private SpawnEditor _Editor;
    private Button btnClose;
    private Button btnApply;
    internal ComboBox cmbNameHas;
    internal ComboBox cmbEntryHas;
    internal ComboBox cmbEntryTypeHas;
    internal ComboBox cmbEntryTypeHas2;
    internal TextBox txtSpawnerEntryType2;
    private Label label5;
    internal ComboBox cmbEntryHas2;
    internal TextBox txtSpawnerEntry2;
    private Label label6;
    internal CheckBox chkEntryCase2;
    private ComboBox cmbSpawnerMap;
    private Label label7;
    private TextBox txtPropertyTest;
    internal ComboBox cmbNotes;
    internal TextBox txtNotes;
    private Label label8;

    public SpawnerFilters(SpawnEditor editor)
    {
      this.InitializeComponent();
      this._Editor = editor;
      this.InitializeSettings();
    }

    private void InitializeSettings()
    {
      this.cmbInContainers.SelectedIndex = 0;
      this.cmbSequential.SelectedIndex = 0;
      this.cmbSmartSpawning.SelectedIndex = 0;
      this.cmbProximity.SelectedIndex = 0;
      this.cmbRunning.SelectedIndex = 0;
      this.cmbAvgSpawnTime.SelectedIndex = 0;
      this.cmbNameHas.SelectedIndex = 0;
      this.cmbEntryHas.SelectedIndex = 0;
      this.cmbEntryTypeHas.SelectedIndex = 0;
      this.cmbEntryHas2.SelectedIndex = 0;
      this.cmbEntryTypeHas2.SelectedIndex = 0;
      this.cmbSpawnerMap.SelectedIndex = 0;
      this.cmbNotes.SelectedIndex = 0;
    }

    public bool HasMatch(SpawnPoint spawn)
    {
      if (spawn == null || spawn.SpawnObjects == null)
        return false;
      bool flag1 = true;
      if (this.cmbSpawnerMap.SelectedIndex == 0 && (WorldMap) this._Editor.cbxMap.SelectedIndex != spawn.Map)
        flag1 = false;
      if (flag1 && this.txtSpawnerName.Text != null && this.txtSpawnerName.Text.Length > 0)
      {
        bool flag2 = false;
        if (this.chkNameCase.Checked)
        {
          if (spawn.SpawnName.IndexOf(this.txtSpawnerName.Text) >= 0)
            flag2 = true;
        }
        else if (spawn.SpawnName.ToLower().IndexOf(this.txtSpawnerName.Text.ToLower()) >= 0)
          flag2 = true;
        if (this.cmbNameHas.SelectedIndex == 0)
        {
          if (!flag2)
            flag1 = false;
        }
        else if (flag2)
          flag1 = false;
      }
      if (flag1 && this.txtSpawnerEntry.Text != null && this.txtSpawnerEntry.Text.Length > 0)
      {
        bool flag2 = false;
        if (spawn.SpawnObjects != null)
        {
          foreach (SpawnObject spawnObject in spawn.SpawnObjects)
          {
            if (this.chkEntryCase.Checked)
            {
              if (spawnObject.TypeName != null && spawnObject.TypeName.IndexOf(this.txtSpawnerEntry.Text) >= 0)
              {
                flag2 = true;
                break;
              }
            }
            else if (spawnObject.TypeName != null && spawnObject.TypeName.ToLower().IndexOf(this.txtSpawnerEntry.Text.ToLower()) >= 0)
            {
              flag2 = true;
              break;
            }
          }
        }
        if (this.cmbEntryHas.SelectedIndex == 0)
        {
          if (!flag2)
            flag1 = false;
        }
        else if (flag2)
          flag1 = false;
      }
      if (flag1 && this.txtSpawnerEntry2.Text != null && this.txtSpawnerEntry2.Text.Length > 0)
      {
        bool flag2 = false;
        if (spawn.SpawnObjects != null)
        {
          foreach (SpawnObject spawnObject in spawn.SpawnObjects)
          {
            if (this.chkEntryCase2.Checked)
            {
              if (spawnObject.TypeName != null && spawnObject.TypeName.IndexOf(this.txtSpawnerEntry2.Text) >= 0)
              {
                flag2 = true;
                break;
              }
            }
            else if (spawnObject.TypeName != null && spawnObject.TypeName.ToLower().IndexOf(this.txtSpawnerEntry2.Text.ToLower()) >= 0)
            {
              flag2 = true;
              break;
            }
          }
        }
        if (this.cmbEntryHas2.SelectedIndex == 0)
        {
          if (!flag2)
            flag1 = false;
        }
        else if (flag2)
          flag1 = false;
      }
      if (flag1 && this.txtSpawnerEntryType.Text != null && this.txtSpawnerEntryType.Text.Length > 0)
      {
        bool flag2 = false;
        Type runUoType = SpawnEditor.FindRunUOType(this.txtSpawnerEntryType.Text.ToLower());
        if (spawn.SpawnObjects != null && runUoType != null)
        {
          foreach (SpawnObject spawnObject in spawn.SpawnObjects)
          {
            Type type = (Type) null;
            if (spawnObject.TypeName != null)
            {
              string[] strArray = spawnObject.TypeName.Split('/');
              string name = (string) null;
              if (strArray != null && strArray.Length > 0)
                name = strArray[0];
              type = SpawnEditor.FindRunUOType(name);
            }
            if (type != null && (type == runUoType || type.IsSubclassOf(runUoType)))
            {
              flag2 = true;
              break;
            }
          }
        }
        if (this.cmbEntryTypeHas.SelectedIndex == 0)
        {
          if (!flag2)
            flag1 = false;
        }
        else if (flag2)
          flag1 = false;
      }
      if (flag1 && this.txtSpawnerEntryType2.Text != null && this.txtSpawnerEntryType2.Text.Length > 0)
      {
        bool flag2 = false;
        Type runUoType = SpawnEditor.FindRunUOType(this.txtSpawnerEntryType2.Text.ToLower());
        if (spawn.SpawnObjects != null && runUoType != null)
        {
          foreach (SpawnObject spawnObject in spawn.SpawnObjects)
          {
            Type type = (Type) null;
            if (spawnObject.TypeName != null)
            {
              string[] strArray = spawnObject.TypeName.Split('/');
              string name = (string) null;
              if (strArray != null && strArray.Length > 0)
                name = strArray[0];
              type = SpawnEditor.FindRunUOType(name);
            }
            if (type != null && (type == runUoType || type.IsSubclassOf(runUoType)))
            {
              flag2 = true;
              break;
            }
          }
        }
        if (this.cmbEntryTypeHas2.SelectedIndex == 0)
        {
          if (!flag2)
            flag1 = false;
        }
        else if (flag2)
          flag1 = false;
      }
      if (flag1 && this.cmbInContainers.SelectedIndex > 0)
      {
        if (this.cmbInContainers.SelectedIndex == 1 && !spawn.SpawnInContainer)
          flag1 = false;
        else if (this.cmbInContainers.SelectedIndex == 2 && spawn.SpawnInContainer)
          flag1 = false;
      }
      if (flag1 && this.cmbSequential.SelectedIndex > 0)
      {
        if (this.cmbSequential.SelectedIndex == 1 && spawn.SpawnSequentialSpawn < 0)
          flag1 = false;
        else if (this.cmbSequential.SelectedIndex == 2 && spawn.SpawnSequentialSpawn >= 0)
          flag1 = false;
      }
      if (flag1 && this.cmbSmartSpawning.SelectedIndex > 0)
      {
        if (this.cmbSmartSpawning.SelectedIndex == 1 && !spawn.SpawnSmartSpawning)
          flag1 = false;
        else if (this.cmbSmartSpawning.SelectedIndex == 2 && spawn.SpawnSmartSpawning)
          flag1 = false;
      }
      if (flag1 && this.cmbProximity.SelectedIndex > 0)
      {
        if (this.cmbProximity.SelectedIndex == 1 && spawn.SpawnProximityRange < 0)
          flag1 = false;
        else if (this.cmbProximity.SelectedIndex == 2 && spawn.SpawnProximityRange >= 0)
          flag1 = false;
      }
      if (flag1 && this.cmbRunning.SelectedIndex > 0)
      {
        if (this.cmbRunning.SelectedIndex == 1 && !spawn.SpawnIsRunning)
          flag1 = false;
        else if (this.cmbRunning.SelectedIndex == 2 && spawn.SpawnIsRunning)
          flag1 = false;
      }
      if (flag1 && this.chkAvgSpawnTime.Checked)
      {
        double num = (spawn.SpawnMinDelay + spawn.SpawnMaxDelay) / 2.0;
        if (this.cmbAvgSpawnTime.SelectedIndex == 0 && num >= (double) this.numAvgSpawnTime.Value)
          flag1 = false;
        else if (this.cmbAvgSpawnTime.SelectedIndex == 1 && num <= (double) this.numAvgSpawnTime.Value)
          flag1 = false;
      }
      string status_str;
      if (flag1 && this.txtPropertyTest.Text != null && (this.txtPropertyTest.Text.Trim().Length > 0 && !PropertyTest.CheckPropertyString((object) spawn, this.txtPropertyTest.Text, out status_str)))
        flag1 = false;
      if (flag1 && this.txtNotes.Text != null && this.txtNotes.Text.Trim().Length > 0)
      {
        bool flag2 = false;
        if (spawn.SpawnNotes != null && spawn.SpawnNotes.Length > 0 && spawn.SpawnNotes.ToLower().IndexOf(this.txtNotes.Text.ToLower()) >= 0)
          flag2 = true;
        if (this.cmbNotes.SelectedIndex == 0)
        {
          if (!flag2)
            flag1 = false;
        }
        else if (flag2)
          flag1 = false;
      }
      return flag1;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.cmbNotes = new ComboBox();
      this.txtNotes = new TextBox();
      this.label8 = new Label();
      this.txtPropertyTest = new TextBox();
      this.label7 = new Label();
      this.cmbSpawnerMap = new ComboBox();
      this.cmbEntryHas2 = new ComboBox();
      this.chkEntryCase2 = new CheckBox();
      this.txtSpawnerEntry2 = new TextBox();
      this.label6 = new Label();
      this.cmbEntryTypeHas2 = new ComboBox();
      this.txtSpawnerEntryType2 = new TextBox();
      this.label5 = new Label();
      this.cmbEntryTypeHas = new ComboBox();
      this.cmbEntryHas = new ComboBox();
      this.cmbNameHas = new ComboBox();
      this.txtSpawnerEntryType = new TextBox();
      this.label2 = new Label();
      this.label18 = new Label();
      this.numAvgSpawnTime = new NumericUpDown();
      this.cmbAvgSpawnTime = new ComboBox();
      this.chkAvgSpawnTime = new CheckBox();
      this.label17 = new Label();
      this.cmbRunning = new ComboBox();
      this.label16 = new Label();
      this.cmbProximity = new ComboBox();
      this.chkNameCase = new CheckBox();
      this.chkEntryCase = new CheckBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label1 = new Label();
      this.cmbSequential = new ComboBox();
      this.cmbInContainers = new ComboBox();
      this.cmbSmartSpawning = new ComboBox();
      this.txtSpawnerEntry = new TextBox();
      this.label38 = new Label();
      this.txtSpawnerName = new TextBox();
      this.label30 = new Label();
      this.btnClose = new Button();
      this.btnApply = new Button();
      this.groupBox1.SuspendLayout();
      this.numAvgSpawnTime.BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.cmbNotes);
      this.groupBox1.Controls.Add((Control) this.txtNotes);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.txtPropertyTest);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.cmbSpawnerMap);
      this.groupBox1.Controls.Add((Control) this.cmbEntryHas2);
      this.groupBox1.Controls.Add((Control) this.chkEntryCase2);
      this.groupBox1.Controls.Add((Control) this.txtSpawnerEntry2);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.cmbEntryTypeHas2);
      this.groupBox1.Controls.Add((Control) this.txtSpawnerEntryType2);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.cmbEntryTypeHas);
      this.groupBox1.Controls.Add((Control) this.cmbEntryHas);
      this.groupBox1.Controls.Add((Control) this.cmbNameHas);
      this.groupBox1.Controls.Add((Control) this.txtSpawnerEntryType);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label18);
      this.groupBox1.Controls.Add((Control) this.numAvgSpawnTime);
      this.groupBox1.Controls.Add((Control) this.cmbAvgSpawnTime);
      this.groupBox1.Controls.Add((Control) this.chkAvgSpawnTime);
      this.groupBox1.Controls.Add((Control) this.label17);
      this.groupBox1.Controls.Add((Control) this.cmbRunning);
      this.groupBox1.Controls.Add((Control) this.label16);
      this.groupBox1.Controls.Add((Control) this.cmbProximity);
      this.groupBox1.Controls.Add((Control) this.chkNameCase);
      this.groupBox1.Controls.Add((Control) this.chkEntryCase);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.cmbSequential);
      this.groupBox1.Controls.Add((Control) this.cmbInContainers);
      this.groupBox1.Controls.Add((Control) this.cmbSmartSpawning);
      this.groupBox1.Controls.Add((Control) this.txtSpawnerEntry);
      this.groupBox1.Controls.Add((Control) this.label38);
      this.groupBox1.Controls.Add((Control) this.txtSpawnerName);
      this.groupBox1.Controls.Add((Control) this.label30);
      this.groupBox1.Location = new Point(8, 16);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(344, 416);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filter Settings";
      this.cmbNotes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbNotes.Items.AddRange(new object[2]
      {
        (object) "has",
        (object) "has not"
      });
      this.cmbNotes.Location = new Point(48, 168);
      this.cmbNotes.Name = "cmbNotes";
      this.cmbNotes.Size = new Size(64, 21);
      this.cmbNotes.TabIndex = 270;
      this.txtNotes.Location = new Point(112, 168);
      this.txtNotes.Name = "txtNotes";
      this.txtNotes.Size = new Size(168, 20);
      this.txtNotes.TabIndex = 268;
      this.txtNotes.Text = "";
      this.label8.Location = new Point(8, 168);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 16);
      this.label8.TabIndex = 269;
      this.label8.Text = "Notes:";
      this.txtPropertyTest.Location = new Point(80, 352);
      this.txtPropertyTest.Name = "txtPropertyTest";
      this.txtPropertyTest.Size = new Size(256, 20);
      this.txtPropertyTest.TabIndex = 266;
      this.txtPropertyTest.Text = "";
      this.label7.Location = new Point(8, 352);
      this.label7.Name = "label7";
      this.label7.Size = new Size(80, 16);
      this.label7.TabIndex = 267;
      this.label7.Text = "Property Test:";
      this.cmbSpawnerMap.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSpawnerMap.Items.AddRange(new object[2]
      {
        (object) "Current map",
        (object) "All maps"
      });
      this.cmbSpawnerMap.Location = new Point(8, 384);
      this.cmbSpawnerMap.Name = "cmbSpawnerMap";
      this.cmbSpawnerMap.Size = new Size(96, 21);
      this.cmbSpawnerMap.TabIndex = 265;
      this.cmbEntryHas2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEntryHas2.Items.AddRange(new object[2]
      {
        (object) "has",
        (object) "has not"
      });
      this.cmbEntryHas2.Location = new Point(48, 72);
      this.cmbEntryHas2.Name = "cmbEntryHas2";
      this.cmbEntryHas2.Size = new Size(64, 21);
      this.cmbEntryHas2.TabIndex = 264;
      this.chkEntryCase2.Location = new Point(232, 72);
      this.chkEntryCase2.Name = "chkEntryCase2";
      this.chkEntryCase2.Size = new Size(104, 16);
      this.chkEntryCase2.TabIndex = 263;
      this.chkEntryCase2.Text = "Case sensitive";
      this.txtSpawnerEntry2.Location = new Point(112, 72);
      this.txtSpawnerEntry2.Name = "txtSpawnerEntry2";
      this.txtSpawnerEntry2.Size = new Size(112, 20);
      this.txtSpawnerEntry2.TabIndex = 261;
      this.txtSpawnerEntry2.Text = "";
      this.label6.Location = new Point(8, 72);
      this.label6.Name = "label6";
      this.label6.Size = new Size(40, 16);
      this.label6.TabIndex = 262;
      this.label6.Text = "Entry:";
      this.cmbEntryTypeHas2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEntryTypeHas2.Items.AddRange(new object[2]
      {
        (object) "has",
        (object) "has not"
      });
      this.cmbEntryTypeHas2.Location = new Point(64, 120);
      this.cmbEntryTypeHas2.Name = "cmbEntryTypeHas2";
      this.cmbEntryTypeHas2.Size = new Size(64, 21);
      this.cmbEntryTypeHas2.TabIndex = 260;
      this.txtSpawnerEntryType2.Location = new Point(128, 120);
      this.txtSpawnerEntryType2.Name = "txtSpawnerEntryType2";
      this.txtSpawnerEntryType2.Size = new Size(152, 20);
      this.txtSpawnerEntryType2.TabIndex = 258;
      this.txtSpawnerEntryType2.Text = "";
      this.label5.Location = new Point(8, 120);
      this.label5.Name = "label5";
      this.label5.Size = new Size(80, 16);
      this.label5.TabIndex = 259;
      this.label5.Text = "Entry Type:";
      this.cmbEntryTypeHas.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEntryTypeHas.Items.AddRange(new object[2]
      {
        (object) "has",
        (object) "has not"
      });
      this.cmbEntryTypeHas.Location = new Point(64, 96);
      this.cmbEntryTypeHas.Name = "cmbEntryTypeHas";
      this.cmbEntryTypeHas.Size = new Size(64, 21);
      this.cmbEntryTypeHas.TabIndex = 257;
      this.cmbEntryHas.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEntryHas.Items.AddRange(new object[2]
      {
        (object) "has",
        (object) "has not"
      });
      this.cmbEntryHas.Location = new Point(48, 48);
      this.cmbEntryHas.Name = "cmbEntryHas";
      this.cmbEntryHas.Size = new Size(64, 21);
      this.cmbEntryHas.TabIndex = 256;
      this.cmbNameHas.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbNameHas.Items.AddRange(new object[2]
      {
        (object) "has",
        (object) "has not"
      });
      this.cmbNameHas.Location = new Point(48, 24);
      this.cmbNameHas.Name = "cmbNameHas";
      this.cmbNameHas.Size = new Size(64, 21);
      this.cmbNameHas.TabIndex = (int) byte.MaxValue;
      this.txtSpawnerEntryType.Location = new Point(128, 96);
      this.txtSpawnerEntryType.Name = "txtSpawnerEntryType";
      this.txtSpawnerEntryType.Size = new Size(152, 20);
      this.txtSpawnerEntryType.TabIndex = 253;
      this.txtSpawnerEntryType.Text = "";
      this.label2.Location = new Point(8, 96);
      this.label2.Name = "label2";
      this.label2.Size = new Size(80, 16);
      this.label2.TabIndex = 254;
      this.label2.Text = "Entry Type:";
      this.label18.Location = new Point(280, 312);
      this.label18.Name = "label18";
      this.label18.Size = new Size(48, 16);
      this.label18.TabIndex = 252;
      this.label18.Text = "minutes";
      this.numAvgSpawnTime.DecimalPlaces = 1;
      this.numAvgSpawnTime.Location = new Point(208, 312);
      NumericUpDown numericUpDown1 = this.numAvgSpawnTime;
      int[] bits1 = new int[4];
      bits1[0] = (int) ushort.MaxValue;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.numAvgSpawnTime.Name = "numAvgSpawnTime";
      this.numAvgSpawnTime.Size = new Size(72, 20);
      this.numAvgSpawnTime.TabIndex = 251;
      NumericUpDown numericUpDown2 = this.numAvgSpawnTime;
      int[] bits2 = new int[4];
      bits2[0] = 10;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Value = num2;
      this.cmbAvgSpawnTime.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbAvgSpawnTime.Items.AddRange(new object[2]
      {
        (object) "less than",
        (object) "greater than"
      });
      this.cmbAvgSpawnTime.Location = new Point(120, 312);
      this.cmbAvgSpawnTime.Name = "cmbAvgSpawnTime";
      this.cmbAvgSpawnTime.Size = new Size(88, 21);
      this.cmbAvgSpawnTime.TabIndex = 249;
      this.chkAvgSpawnTime.Location = new Point(8, 312);
      this.chkAvgSpawnTime.Name = "chkAvgSpawnTime";
      this.chkAvgSpawnTime.Size = new Size(112, 16);
      this.chkAvgSpawnTime.TabIndex = 250;
      this.chkAvgSpawnTime.Text = "Avg. Spawn Time";
      this.label17.Location = new Point(16, 288);
      this.label17.Name = "label17";
      this.label17.Size = new Size(112, 16);
      this.label17.TabIndex = 248;
      this.label17.Text = "Running:";
      this.label17.TextAlign = ContentAlignment.MiddleRight;
      this.cmbRunning.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbRunning.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Running Only",
        (object) "Not Running"
      });
      this.cmbRunning.Location = new Point(128, 288);
      this.cmbRunning.Name = "cmbRunning";
      this.cmbRunning.Size = new Size(152, 21);
      this.cmbRunning.TabIndex = 247;
      this.label16.Location = new Point(16, 264);
      this.label16.Name = "label16";
      this.label16.Size = new Size(112, 16);
      this.label16.TabIndex = 246;
      this.label16.Text = "ProximityTriggered:";
      this.label16.TextAlign = ContentAlignment.MiddleRight;
      this.cmbProximity.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbProximity.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "ProximityTriggered Only",
        (object) "Not ProximityTriggered "
      });
      this.cmbProximity.Location = new Point(128, 264);
      this.cmbProximity.Name = "cmbProximity";
      this.cmbProximity.Size = new Size(152, 21);
      this.cmbProximity.TabIndex = 245;
      this.chkNameCase.Location = new Point(232, 24);
      this.chkNameCase.Name = "chkNameCase";
      this.chkNameCase.Size = new Size(104, 16);
      this.chkNameCase.TabIndex = 240;
      this.chkNameCase.Text = "Case sensitive";
      this.chkEntryCase.Location = new Point(232, 48);
      this.chkEntryCase.Name = "chkEntryCase";
      this.chkEntryCase.Size = new Size(104, 16);
      this.chkEntryCase.TabIndex = 241;
      this.chkEntryCase.Text = "Case sensitive";
      this.label4.Location = new Point(56, 240);
      this.label4.Name = "label4";
      this.label4.Size = new Size(72, 16);
      this.label4.TabIndex = 239;
      this.label4.Text = "InContainers:";
      this.label4.TextAlign = ContentAlignment.MiddleRight;
      this.label3.Location = new Point(16, 216);
      this.label3.Name = "label3";
      this.label3.Size = new Size(112, 16);
      this.label3.TabIndex = 238;
      this.label3.Text = "SequentialSpawning:";
      this.label3.TextAlign = ContentAlignment.MiddleRight;
      this.label1.Location = new Point(40, 192);
      this.label1.Name = "label1";
      this.label1.Size = new Size(88, 16);
      this.label1.TabIndex = 237;
      this.label1.Text = "SmartSpawning:";
      this.label1.TextAlign = ContentAlignment.MiddleRight;
      this.cmbSequential.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSequential.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Sequential Only",
        (object) "Not Sequential"
      });
      this.cmbSequential.Location = new Point(128, 216);
      this.cmbSequential.Name = "cmbSequential";
      this.cmbSequential.Size = new Size(152, 21);
      this.cmbSequential.TabIndex = 236;
      this.cmbInContainers.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbInContainers.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "InContainer Only",
        (object) "Not InContainer"
      });
      this.cmbInContainers.Location = new Point(128, 240);
      this.cmbInContainers.Name = "cmbInContainers";
      this.cmbInContainers.Size = new Size(152, 21);
      this.cmbInContainers.TabIndex = 235;
      this.cmbSmartSpawning.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSmartSpawning.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "SmartSpawned Only",
        (object) "Not SmartSpawned"
      });
      this.cmbSmartSpawning.Location = new Point(128, 192);
      this.cmbSmartSpawning.Name = "cmbSmartSpawning";
      this.cmbSmartSpawning.Size = new Size(152, 21);
      this.cmbSmartSpawning.TabIndex = 234;
      this.txtSpawnerEntry.Location = new Point(112, 48);
      this.txtSpawnerEntry.Name = "txtSpawnerEntry";
      this.txtSpawnerEntry.Size = new Size(112, 20);
      this.txtSpawnerEntry.TabIndex = 232;
      this.txtSpawnerEntry.Text = "";
      this.label38.Location = new Point(8, 48);
      this.label38.Name = "label38";
      this.label38.Size = new Size(40, 16);
      this.label38.TabIndex = 233;
      this.label38.Text = "Entry:";
      this.txtSpawnerName.Location = new Point(112, 24);
      this.txtSpawnerName.Name = "txtSpawnerName";
      this.txtSpawnerName.Size = new Size(112, 20);
      this.txtSpawnerName.TabIndex = 230;
      this.txtSpawnerName.Text = "";
      this.label30.Location = new Point(8, 24);
      this.label30.Name = "label30";
      this.label30.Size = new Size(40, 16);
      this.label30.TabIndex = 231;
      this.label30.Text = "Name:";
      this.btnClose.Location = new Point(208, 448);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(96, 24);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Close";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnApply.Location = new Point(64, 448);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new Size(96, 24);
      this.btnApply.TabIndex = 2;
      this.btnApply.Text = "Apply";
      this.btnApply.Click += new EventHandler(this.btnApply_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(360, 480);
      this.ControlBox = false;
      this.Controls.Add((Control) this.btnApply);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Name = "SpawnerFilters";
      this.Text = "Spawner Display Filter Settings";
      this.groupBox1.ResumeLayout(false);
      this.numAvgSpawnTime.EndInit();
      this.ResumeLayout(false);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      this._Editor._TransferDialog.DisplayStatusIndicator("Filtering Spawns...");
      if (!this._Editor.checkSpawnFilter.Checked)
      {
        this._Editor.checkSpawnFilter.Checked = true;
      }
      else
      {
        this._Editor.ApplySpawnFilter();
        this._Editor.RefreshSpawnPoints();
      }
      this._Editor._TransferDialog.HideStatusIndicator();
    }
  }
}
