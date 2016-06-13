// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.TransferServerSettings
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using Server.Engines.XmlSpawner2;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SpawnEditor2
{
  public class TransferServerSettings : Form
  {
    internal GroupBox grpTransferServer;
    internal TextBox txtItemType;
    private Label label43;
    private Label label38;
    private Label label30;
    private GroupBox transferServer;
    internal TextBox txtTransferServerPort;
    internal TextBox txtTransferServerAddress;
    private Label label40;
    private Label label41;
    internal GroupBox groupBox1;
    private Label label2;
    internal GroupBox groupBox2;
    private Label label1;
    private Label label3;
    private Label label4;
    private Label label5;
    private Button btnDLItems;
    private Button btnDLCreatures;
    private Button btnDLPlayers;
    private Button btnDLSpawners;
    private Button btnCancel;
    private Button button1;
    private Label label6;
    private TextBox txtItemID;
    internal CheckBox chkNameCase;
    internal CheckBox chkEntryCase;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    internal GroupBox groupBox3;
    private Label label13;
    internal GroupBox grpSpawner;
    internal ComboBox cmbSequential;
    internal ComboBox cmbSmartSpawning;
    internal TextBox txtSpawnerEntry;
    internal TextBox txtSpawnerName;
    internal TextBox txtCreatureType;
    private ComboBox cmbStatics;
    private ComboBox cmbItemInContainers;
    private ComboBox cmbVisible;
    private ComboBox cmbMovable;
    private ComboBox cmbBlessed;
    private ComboBox cmbInnocent;
    private Label label12;
    private ComboBox cmbCriminal;
    private SpawnEditor _Editor;
    internal CheckBox chkShowPlayers;
    internal CheckBox chkShowCreatures;
    internal CheckBox chkShowTips;
    internal CheckBox chkShowItems;
    private Label label14;
    private ComboBox cmbAccessLevel;
    internal ComboBox cmbInContainers;
    private Label label7;
    private ComboBox cmbCarried;
    private Label label15;
    private ComboBox cmbControlled;
    private DateTimePicker dtModified;
    private Button btnRenew;
    private CheckBox chkModified;
    private ComboBox cmbModified;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private ComboBox cmbItemMap;
    private ComboBox cmbCreatureMap;
    private ComboBox cmbPlayerMap;
    private ComboBox cmbSpawnerMap;
    private Label label16;
    internal ComboBox cmbProximity;
    private ListBox listItems;
    private ListBox listCreatures;
    private ListBox listPlayers;
    private Label label17;
    internal ComboBox cmbRunning;
    internal CheckBox chkSpawnerWithinSelectionWindow;
    private Label label18;
    private ComboBox cmbAvgSpawnTime;
    private CheckBox chkAvgSpawnTime;
    private NumericUpDown numAvgSpawnTime;
    private ToolTip toolTip1;
    private ComboBox cmbModifiedBy;
    private CheckBox chkModifiedBy;
    private TextBox txtModifiedBy;
    private ComboBox cmbModifiedNotBy;
    private IContainer components;

    public TransferServerSettings(SpawnEditor editor)
    {
      this._Editor = editor;
      this.InitializeComponent();
      this.InitializeSettings();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.grpTransferServer = new GroupBox();
      this.listItems = new ListBox();
      this.cmbItemMap = new ComboBox();
      this.label7 = new Label();
      this.cmbCarried = new ComboBox();
      this.txtItemID = new TextBox();
      this.label14 = new Label();
      this.label9 = new Label();
      this.cmbMovable = new ComboBox();
      this.label8 = new Label();
      this.cmbVisible = new ComboBox();
      this.label6 = new Label();
      this.cmbItemInContainers = new ComboBox();
      this.label5 = new Label();
      this.cmbStatics = new ComboBox();
      this.txtItemType = new TextBox();
      this.label43 = new Label();
      this.label10 = new Label();
      this.cmbBlessed = new ComboBox();
      this.btnDLItems = new Button();
      this.grpSpawner = new GroupBox();
      this.label18 = new Label();
      this.numAvgSpawnTime = new NumericUpDown();
      this.cmbAvgSpawnTime = new ComboBox();
      this.chkAvgSpawnTime = new CheckBox();
      this.chkSpawnerWithinSelectionWindow = new CheckBox();
      this.label17 = new Label();
      this.cmbRunning = new ComboBox();
      this.label16 = new Label();
      this.cmbProximity = new ComboBox();
      this.cmbSpawnerMap = new ComboBox();
      this.cmbModified = new ComboBox();
      this.chkModified = new CheckBox();
      this.dtModified = new DateTimePicker();
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
      this.btnDLSpawners = new Button();
      this.button1 = new Button();
      this.transferServer = new GroupBox();
      this.txtTransferServerPort = new TextBox();
      this.txtTransferServerAddress = new TextBox();
      this.label40 = new Label();
      this.label41 = new Label();
      this.groupBox1 = new GroupBox();
      this.listCreatures = new ListBox();
      this.cmbCreatureMap = new ComboBox();
      this.label15 = new Label();
      this.cmbControlled = new ComboBox();
      this.label11 = new Label();
      this.cmbInnocent = new ComboBox();
      this.txtCreatureType = new TextBox();
      this.label2 = new Label();
      this.btnDLCreatures = new Button();
      this.groupBox2 = new GroupBox();
      this.chkShowPlayers = new CheckBox();
      this.chkShowCreatures = new CheckBox();
      this.chkShowTips = new CheckBox();
      this.chkShowItems = new CheckBox();
      this.btnDLPlayers = new Button();
      this.btnCancel = new Button();
      this.groupBox3 = new GroupBox();
      this.listPlayers = new ListBox();
      this.cmbPlayerMap = new ComboBox();
      this.label12 = new Label();
      this.cmbCriminal = new ComboBox();
      this.label13 = new Label();
      this.cmbAccessLevel = new ComboBox();
      this.btnRenew = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.tabPage3 = new TabPage();
      this.tabPage4 = new TabPage();
      this.toolTip1 = new ToolTip(this.components);
      this.cmbModifiedBy = new ComboBox();
      this.chkModifiedBy = new CheckBox();
      this.txtModifiedBy = new TextBox();
      this.cmbModifiedNotBy = new ComboBox();
      this.grpTransferServer.SuspendLayout();
      this.grpSpawner.SuspendLayout();
      this.numAvgSpawnTime.BeginInit();
      this.transferServer.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.SuspendLayout();
      this.grpTransferServer.Controls.Add((Control) this.listItems);
      this.grpTransferServer.Controls.Add((Control) this.cmbItemMap);
      this.grpTransferServer.Controls.Add((Control) this.label7);
      this.grpTransferServer.Controls.Add((Control) this.cmbCarried);
      this.grpTransferServer.Controls.Add((Control) this.txtItemID);
      this.grpTransferServer.Controls.Add((Control) this.label14);
      this.grpTransferServer.Controls.Add((Control) this.label9);
      this.grpTransferServer.Controls.Add((Control) this.cmbMovable);
      this.grpTransferServer.Controls.Add((Control) this.label8);
      this.grpTransferServer.Controls.Add((Control) this.cmbVisible);
      this.grpTransferServer.Controls.Add((Control) this.label6);
      this.grpTransferServer.Controls.Add((Control) this.cmbItemInContainers);
      this.grpTransferServer.Controls.Add((Control) this.label5);
      this.grpTransferServer.Controls.Add((Control) this.cmbStatics);
      this.grpTransferServer.Controls.Add((Control) this.txtItemType);
      this.grpTransferServer.Controls.Add((Control) this.label43);
      this.grpTransferServer.Controls.Add((Control) this.label10);
      this.grpTransferServer.Controls.Add((Control) this.cmbBlessed);
      this.grpTransferServer.Controls.Add((Control) this.btnDLItems);
      this.grpTransferServer.Location = new Point(0, 0);
      this.grpTransferServer.Name = "grpTransferServer";
      this.grpTransferServer.Size = new Size(336, 312);
      this.grpTransferServer.TabIndex = 209;
      this.grpTransferServer.TabStop = false;
      this.grpTransferServer.Text = "Item Filters";
      this.listItems.HorizontalScrollbar = true;
      this.listItems.Location = new Point(208, 64);
      this.listItems.Name = "listItems";
      this.listItems.Size = new Size(120, 212);
      this.listItems.TabIndex = 221;
      this.listItems.SelectedIndexChanged += new EventHandler(this.listItems_SelectedIndexChanged);
      this.cmbItemMap.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbItemMap.Items.AddRange(new object[2]
      {
        (object) "Current map",
        (object) "All maps"
      });
      this.cmbItemMap.Location = new Point(8, 280);
      this.cmbItemMap.Name = "cmbItemMap";
      this.cmbItemMap.Size = new Size(96, 21);
      this.cmbItemMap.TabIndex = 220;
      this.label7.Location = new Point(24, 88);
      this.label7.Name = "label7";
      this.label7.Size = new Size(56, 16);
      this.label7.TabIndex = 31;
      this.label7.Text = "Carried:";
      this.label7.TextAlign = ContentAlignment.MiddleRight;
      this.cmbCarried.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbCarried.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Carried Only",
        (object) "Not Carried"
      });
      this.cmbCarried.Location = new Point(80, 88);
      this.cmbCarried.Name = "cmbCarried";
      this.cmbCarried.Size = new Size(120, 21);
      this.cmbCarried.TabIndex = 30;
      this.txtItemID.Location = new Point(272, 16);
      this.txtItemID.Name = "txtItemID";
      this.txtItemID.Size = new Size(56, 20);
      this.txtItemID.TabIndex = 23;
      this.txtItemID.Text = "";
      this.label14.Location = new Point(232, 16);
      this.label14.Name = "label14";
      this.label14.Size = new Size(48, 16);
      this.label14.TabIndex = 29;
      this.label14.Text = "ItemID:";
      this.label9.Location = new Point(24, 112);
      this.label9.Name = "label9";
      this.label9.Size = new Size(56, 16);
      this.label9.TabIndex = 28;
      this.label9.Text = "Movable:";
      this.label9.TextAlign = ContentAlignment.MiddleRight;
      this.cmbMovable.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMovable.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Movable Only",
        (object) "Not Movable"
      });
      this.cmbMovable.Location = new Point(80, 112);
      this.cmbMovable.Name = "cmbMovable";
      this.cmbMovable.Size = new Size(120, 21);
      this.cmbMovable.TabIndex = 27;
      this.label8.Location = new Point(32, 136);
      this.label8.Name = "label8";
      this.label8.Size = new Size(48, 16);
      this.label8.TabIndex = 26;
      this.label8.Text = "Visible:";
      this.label8.TextAlign = ContentAlignment.MiddleRight;
      this.cmbVisible.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVisible.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Visible Only",
        (object) "Not Visible"
      });
      this.cmbVisible.Location = new Point(80, 136);
      this.cmbVisible.Name = "cmbVisible";
      this.cmbVisible.Size = new Size(120, 21);
      this.cmbVisible.TabIndex = 25;
      this.label6.Location = new Point(8, 64);
      this.label6.Name = "label6";
      this.label6.Size = new Size(72, 16);
      this.label6.TabIndex = 22;
      this.label6.Text = "InContainers:";
      this.label6.TextAlign = ContentAlignment.MiddleRight;
      this.cmbItemInContainers.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbItemInContainers.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "InContainers Only",
        (object) "Not InContainers"
      });
      this.cmbItemInContainers.Location = new Point(80, 64);
      this.cmbItemInContainers.Name = "cmbItemInContainers";
      this.cmbItemInContainers.Size = new Size(120, 21);
      this.cmbItemInContainers.TabIndex = 21;
      this.label5.Location = new Point(32, 40);
      this.label5.Name = "label5";
      this.label5.Size = new Size(48, 16);
      this.label5.TabIndex = 20;
      this.label5.Text = "Statics:";
      this.label5.TextAlign = ContentAlignment.MiddleRight;
      this.cmbStatics.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbStatics.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Statics Only",
        (object) "No Statics"
      });
      this.cmbStatics.Location = new Point(80, 40);
      this.cmbStatics.Name = "cmbStatics";
      this.cmbStatics.Size = new Size(120, 21);
      this.cmbStatics.TabIndex = 19;
      this.txtItemType.Location = new Point(40, 16);
      this.txtItemType.Name = "txtItemType";
      this.txtItemType.Size = new Size(160, 20);
      this.txtItemType.TabIndex = 9;
      this.txtItemType.Text = "";
      this.label43.Location = new Point(8, 16);
      this.label43.Name = "label43";
      this.label43.Size = new Size(32, 16);
      this.label43.TabIndex = 11;
      this.label43.Text = "Type:";
      this.label43.TextAlign = ContentAlignment.MiddleRight;
      this.label10.Location = new Point(32, 160);
      this.label10.Name = "label10";
      this.label10.Size = new Size(48, 16);
      this.label10.TabIndex = 30;
      this.label10.Text = "Blessed:";
      this.label10.TextAlign = ContentAlignment.MiddleRight;
      this.cmbBlessed.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbBlessed.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Blessed Only",
        (object) "Not Blessed"
      });
      this.cmbBlessed.Location = new Point(80, 160);
      this.cmbBlessed.Name = "cmbBlessed";
      this.cmbBlessed.Size = new Size(120, 21);
      this.cmbBlessed.TabIndex = 29;
      this.btnDLItems.Location = new Point(120, 280);
      this.btnDLItems.Name = "btnDLItems";
      this.btnDLItems.Size = new Size(96, 24);
      this.btnDLItems.TabIndex = 213;
      this.btnDLItems.Text = "Get Items";
      this.btnDLItems.Click += new EventHandler(this.btnDLItems_Click);
      this.grpSpawner.Controls.Add((Control) this.cmbModifiedNotBy);
      this.grpSpawner.Controls.Add((Control) this.txtModifiedBy);
      this.grpSpawner.Controls.Add((Control) this.cmbModifiedBy);
      this.grpSpawner.Controls.Add((Control) this.chkModifiedBy);
      this.grpSpawner.Controls.Add((Control) this.label18);
      this.grpSpawner.Controls.Add((Control) this.numAvgSpawnTime);
      this.grpSpawner.Controls.Add((Control) this.cmbAvgSpawnTime);
      this.grpSpawner.Controls.Add((Control) this.chkAvgSpawnTime);
      this.grpSpawner.Controls.Add((Control) this.chkSpawnerWithinSelectionWindow);
      this.grpSpawner.Controls.Add((Control) this.label17);
      this.grpSpawner.Controls.Add((Control) this.cmbRunning);
      this.grpSpawner.Controls.Add((Control) this.label16);
      this.grpSpawner.Controls.Add((Control) this.cmbProximity);
      this.grpSpawner.Controls.Add((Control) this.cmbSpawnerMap);
      this.grpSpawner.Controls.Add((Control) this.cmbModified);
      this.grpSpawner.Controls.Add((Control) this.chkModified);
      this.grpSpawner.Controls.Add((Control) this.dtModified);
      this.grpSpawner.Controls.Add((Control) this.chkNameCase);
      this.grpSpawner.Controls.Add((Control) this.chkEntryCase);
      this.grpSpawner.Controls.Add((Control) this.label4);
      this.grpSpawner.Controls.Add((Control) this.label3);
      this.grpSpawner.Controls.Add((Control) this.label1);
      this.grpSpawner.Controls.Add((Control) this.cmbSequential);
      this.grpSpawner.Controls.Add((Control) this.cmbInContainers);
      this.grpSpawner.Controls.Add((Control) this.cmbSmartSpawning);
      this.grpSpawner.Controls.Add((Control) this.txtSpawnerEntry);
      this.grpSpawner.Controls.Add((Control) this.label38);
      this.grpSpawner.Controls.Add((Control) this.txtSpawnerName);
      this.grpSpawner.Controls.Add((Control) this.label30);
      this.grpSpawner.Controls.Add((Control) this.btnDLSpawners);
      this.grpSpawner.Controls.Add((Control) this.button1);
      this.grpSpawner.Location = new Point(0, 0);
      this.grpSpawner.Name = "grpSpawner";
      this.grpSpawner.Size = new Size(336, 312);
      this.grpSpawner.TabIndex = 210;
      this.grpSpawner.TabStop = false;
      this.grpSpawner.Text = "Spawner Filters";
      this.label18.Location = new Point(280, 232);
      this.label18.Name = "label18";
      this.label18.Size = new Size(48, 16);
      this.label18.TabIndex = 229;
      this.label18.Text = "minutes";
      this.numAvgSpawnTime.DecimalPlaces = 1;
      this.numAvgSpawnTime.Location = new Point(208, 232);
      NumericUpDown numericUpDown1 = this.numAvgSpawnTime;
      int[] bits1 = new int[4];
      bits1[0] = (int) ushort.MaxValue;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.numAvgSpawnTime.Name = "numAvgSpawnTime";
      this.numAvgSpawnTime.Size = new Size(72, 20);
      this.numAvgSpawnTime.TabIndex = 228;
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
      this.cmbAvgSpawnTime.Location = new Point(120, 232);
      this.cmbAvgSpawnTime.Name = "cmbAvgSpawnTime";
      this.cmbAvgSpawnTime.Size = new Size(88, 21);
      this.cmbAvgSpawnTime.TabIndex = 226;
      this.chkAvgSpawnTime.Location = new Point(8, 232);
      this.chkAvgSpawnTime.Name = "chkAvgSpawnTime";
      this.chkAvgSpawnTime.Size = new Size(112, 16);
      this.chkAvgSpawnTime.TabIndex = 227;
      this.chkAvgSpawnTime.Text = "Avg. Spawn Time";
      this.chkSpawnerWithinSelectionWindow.Location = new Point(8, 256);
      this.chkSpawnerWithinSelectionWindow.Name = "chkSpawnerWithinSelectionWindow";
      this.chkSpawnerWithinSelectionWindow.Size = new Size(160, 16);
      this.chkSpawnerWithinSelectionWindow.TabIndex = 224;
      this.chkSpawnerWithinSelectionWindow.Text = "Within Selection Window";
      this.chkSpawnerWithinSelectionWindow.CheckedChanged += new EventHandler(this.chkSpawnerWithinSelectionWindow_CheckedChanged);
      this.label17.Location = new Point(16, 160);
      this.label17.Name = "label17";
      this.label17.Size = new Size(112, 16);
      this.label17.TabIndex = 223;
      this.label17.Text = "Running:";
      this.label17.TextAlign = ContentAlignment.MiddleRight;
      this.cmbRunning.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbRunning.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Running Only",
        (object) "Not Running"
      });
      this.cmbRunning.Location = new Point(128, 160);
      this.cmbRunning.Name = "cmbRunning";
      this.cmbRunning.Size = new Size(152, 21);
      this.cmbRunning.TabIndex = 222;
      this.label16.Location = new Point(16, 136);
      this.label16.Name = "label16";
      this.label16.Size = new Size(112, 16);
      this.label16.TabIndex = 221;
      this.label16.Text = "ProximityTriggered:";
      this.label16.TextAlign = ContentAlignment.MiddleRight;
      this.cmbProximity.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbProximity.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "ProximityTriggered Only",
        (object) "Not ProximityTriggered "
      });
      this.cmbProximity.Location = new Point(128, 136);
      this.cmbProximity.Name = "cmbProximity";
      this.cmbProximity.Size = new Size(152, 21);
      this.cmbProximity.TabIndex = 220;
      this.cmbSpawnerMap.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSpawnerMap.Items.AddRange(new object[2]
      {
        (object) "Current map",
        (object) "All maps"
      });
      this.cmbSpawnerMap.Location = new Point(8, 280);
      this.cmbSpawnerMap.Name = "cmbSpawnerMap";
      this.cmbSpawnerMap.Size = new Size(96, 21);
      this.cmbSpawnerMap.TabIndex = 219;
      this.cmbModified.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbModified.Items.AddRange(new object[2]
      {
        (object) "before",
        (object) "after"
      });
      this.cmbModified.Location = new Point(72, 184);
      this.cmbModified.Name = "cmbModified";
      this.cmbModified.Size = new Size(56, 21);
      this.cmbModified.TabIndex = 25;
      this.chkModified.Location = new Point(8, 186);
      this.chkModified.Name = "chkModified";
      this.chkModified.Size = new Size(72, 16);
      this.chkModified.TabIndex = 26;
      this.chkModified.Text = "Modified";
      this.dtModified.CustomFormat = "MMM dd yyyy h:mm tt";
      this.dtModified.Format = DateTimePickerFormat.Custom;
      this.dtModified.Location = new Point(128, 184);
      this.dtModified.Name = "dtModified";
      this.dtModified.Size = new Size(152, 20);
      this.dtModified.TabIndex = 23;
      this.chkNameCase.Location = new Point(224, 16);
      this.chkNameCase.Name = "chkNameCase";
      this.chkNameCase.Size = new Size(104, 16);
      this.chkNameCase.TabIndex = 21;
      this.chkNameCase.Text = "Case sensitive";
      this.chkEntryCase.Location = new Point(224, 40);
      this.chkEntryCase.Name = "chkEntryCase";
      this.chkEntryCase.Size = new Size(104, 16);
      this.chkEntryCase.TabIndex = 22;
      this.chkEntryCase.Text = "Case sensitive";
      this.label4.Location = new Point(56, 112);
      this.label4.Name = "label4";
      this.label4.Size = new Size(72, 16);
      this.label4.TabIndex = 20;
      this.label4.Text = "InContainers:";
      this.label4.TextAlign = ContentAlignment.MiddleRight;
      this.label3.Location = new Point(16, 88);
      this.label3.Name = "label3";
      this.label3.Size = new Size(112, 16);
      this.label3.TabIndex = 19;
      this.label3.Text = "SequentialSpawning:";
      this.label3.TextAlign = ContentAlignment.MiddleRight;
      this.label1.Location = new Point(40, 64);
      this.label1.Name = "label1";
      this.label1.Size = new Size(88, 16);
      this.label1.TabIndex = 18;
      this.label1.Text = "SmartSpawning:";
      this.label1.TextAlign = ContentAlignment.MiddleRight;
      this.cmbSequential.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSequential.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Sequential Only",
        (object) "Not Sequential"
      });
      this.cmbSequential.Location = new Point(128, 88);
      this.cmbSequential.Name = "cmbSequential";
      this.cmbSequential.Size = new Size(152, 21);
      this.cmbSequential.TabIndex = 17;
      this.cmbInContainers.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbInContainers.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "InContainer Only",
        (object) "Not InContainer"
      });
      this.cmbInContainers.Location = new Point(128, 112);
      this.cmbInContainers.Name = "cmbInContainers";
      this.cmbInContainers.Size = new Size(152, 21);
      this.cmbInContainers.TabIndex = 16;
      this.cmbSmartSpawning.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSmartSpawning.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "SmartSpawned Only",
        (object) "Not SmartSpawned"
      });
      this.cmbSmartSpawning.Location = new Point(128, 64);
      this.cmbSmartSpawning.Name = "cmbSmartSpawning";
      this.cmbSmartSpawning.Size = new Size(152, 21);
      this.cmbSmartSpawning.TabIndex = 15;
      this.txtSpawnerEntry.Location = new Point(40, 40);
      this.txtSpawnerEntry.Name = "txtSpawnerEntry";
      this.txtSpawnerEntry.Size = new Size(176, 20);
      this.txtSpawnerEntry.TabIndex = 13;
      this.txtSpawnerEntry.Text = "";
      this.label38.Location = new Point(5, 40);
      this.label38.Name = "label38";
      this.label38.Size = new Size(40, 16);
      this.label38.TabIndex = 14;
      this.label38.Text = "Entry:";
      this.txtSpawnerName.Location = new Point(40, 16);
      this.txtSpawnerName.Name = "txtSpawnerName";
      this.txtSpawnerName.Size = new Size(176, 20);
      this.txtSpawnerName.TabIndex = 11;
      this.txtSpawnerName.Text = "";
      this.label30.Location = new Point(5, 16);
      this.label30.Name = "label30";
      this.label30.Size = new Size(40, 16);
      this.label30.TabIndex = 12;
      this.label30.Text = "Name:";
      this.btnDLSpawners.Location = new Point(120, 280);
      this.btnDLSpawners.Name = "btnDLSpawners";
      this.btnDLSpawners.Size = new Size(96, 24);
      this.btnDLSpawners.TabIndex = 216;
      this.btnDLSpawners.Text = "Get Spawners";
      this.toolTip1.SetToolTip((Control) this.btnDLSpawners, "Retrieve spawners that meet the filtering criteria from the server. Currently loaded spawners will first be cleared.");
      this.btnDLSpawners.Click += new EventHandler(this.btnDLSpawners_Click);
      this.button1.Location = new Point(224, 280);
      this.button1.Name = "button1";
      this.button1.Size = new Size(104, 24);
      this.button1.TabIndex = 218;
      this.button1.Text = "Merge Spawners";
      this.toolTip1.SetToolTip((Control) this.button1, "Retrieve spawners that meet the filtering criteria from the server. Currently loaded spawners will NOT be cleared.");
      this.button1.Click += new EventHandler(this.btnDLSpawners_Click);
      this.transferServer.Controls.Add((Control) this.txtTransferServerPort);
      this.transferServer.Controls.Add((Control) this.txtTransferServerAddress);
      this.transferServer.Controls.Add((Control) this.label40);
      this.transferServer.Controls.Add((Control) this.label41);
      this.transferServer.Location = new Point(8, 0);
      this.transferServer.Name = "transferServer";
      this.transferServer.Size = new Size(344, 48);
      this.transferServer.TabIndex = 211;
      this.transferServer.TabStop = false;
      this.transferServer.Text = "Transfer Server";
      this.txtTransferServerPort.Location = new Point(288, 16);
      this.txtTransferServerPort.Name = "txtTransferServerPort";
      this.txtTransferServerPort.Size = new Size(48, 20);
      this.txtTransferServerPort.TabIndex = 22;
      this.txtTransferServerPort.Text = "8030";
      this.txtTransferServerAddress.Location = new Point(56, 16);
      this.txtTransferServerAddress.Name = "txtTransferServerAddress";
      this.txtTransferServerAddress.Size = new Size(192, 20);
      this.txtTransferServerAddress.TabIndex = 20;
      this.txtTransferServerAddress.Text = "127.0.0.1";
      this.label40.Location = new Point(8, 16);
      this.label40.Name = "label40";
      this.label40.Size = new Size(56, 16);
      this.label40.TabIndex = 21;
      this.label40.Text = "Address:";
      this.label41.Location = new Point(256, 16);
      this.label41.Name = "label41";
      this.label41.Size = new Size(48, 16);
      this.label41.TabIndex = 23;
      this.label41.Text = "Port:";
      this.groupBox1.Controls.Add((Control) this.listCreatures);
      this.groupBox1.Controls.Add((Control) this.cmbCreatureMap);
      this.groupBox1.Controls.Add((Control) this.label15);
      this.groupBox1.Controls.Add((Control) this.cmbControlled);
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Controls.Add((Control) this.cmbInnocent);
      this.groupBox1.Controls.Add((Control) this.txtCreatureType);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.btnDLCreatures);
      this.groupBox1.Location = new Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(336, 312);
      this.groupBox1.TabIndex = 212;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Creature Filters";
      this.listCreatures.HorizontalScrollbar = true;
      this.listCreatures.Location = new Point(208, 64);
      this.listCreatures.Name = "listCreatures";
      this.listCreatures.Size = new Size(120, 212);
      this.listCreatures.TabIndex = 222;
      this.listCreatures.SelectedIndexChanged += new EventHandler(this.listCreatures_SelectedIndexChanged);
      this.cmbCreatureMap.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbCreatureMap.Items.AddRange(new object[2]
      {
        (object) "Current map",
        (object) "All maps"
      });
      this.cmbCreatureMap.Location = new Point(8, 280);
      this.cmbCreatureMap.Name = "cmbCreatureMap";
      this.cmbCreatureMap.Size = new Size(96, 21);
      this.cmbCreatureMap.TabIndex = 220;
      this.label15.Location = new Point(8, 40);
      this.label15.Name = "label15";
      this.label15.Size = new Size(64, 16);
      this.label15.TabIndex = 34;
      this.label15.Text = "Controlled:";
      this.label15.TextAlign = ContentAlignment.MiddleRight;
      this.cmbControlled.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbControlled.Items.AddRange(new object[3]
      {
        (object) "No Restriction",
        (object) "Controlled Only",
        (object) "Not Controlled"
      });
      this.cmbControlled.Location = new Point(80, 40);
      this.cmbControlled.Name = "cmbControlled";
      this.cmbControlled.Size = new Size(120, 21);
      this.cmbControlled.TabIndex = 33;
      this.label11.Location = new Point(16, 64);
      this.label11.Name = "label11";
      this.label11.Size = new Size(56, 16);
      this.label11.TabIndex = 32;
      this.label11.Text = "Notoriety:";
      this.label11.TextAlign = ContentAlignment.MiddleRight;
      this.cmbInnocent.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbInnocent.Items.AddRange(new object[4]
      {
        (object) "No Restriction",
        (object) "Innocents Only",
        (object) "Invulnerable Only",
        (object) "Attackable Only"
      });
      this.cmbInnocent.Location = new Point(80, 64);
      this.cmbInnocent.Name = "cmbInnocent";
      this.cmbInnocent.Size = new Size(120, 21);
      this.cmbInnocent.TabIndex = 31;
      this.txtCreatureType.Location = new Point(40, 16);
      this.txtCreatureType.Name = "txtCreatureType";
      this.txtCreatureType.Size = new Size(160, 20);
      this.txtCreatureType.TabIndex = 6;
      this.txtCreatureType.Text = "";
      this.label2.Location = new Point(8, 16);
      this.label2.Name = "label2";
      this.label2.Size = new Size(32, 16);
      this.label2.TabIndex = 10;
      this.label2.Text = "Type:";
      this.label2.TextAlign = ContentAlignment.MiddleRight;
      this.btnDLCreatures.Location = new Point(120, 280);
      this.btnDLCreatures.Name = "btnDLCreatures";
      this.btnDLCreatures.Size = new Size(96, 24);
      this.btnDLCreatures.TabIndex = 214;
      this.btnDLCreatures.Text = "Get Creatures";
      this.btnDLCreatures.Click += new EventHandler(this.btnDLCreatures_Click);
      this.groupBox2.Controls.Add((Control) this.chkShowPlayers);
      this.groupBox2.Controls.Add((Control) this.chkShowCreatures);
      this.groupBox2.Controls.Add((Control) this.chkShowTips);
      this.groupBox2.Controls.Add((Control) this.chkShowItems);
      this.groupBox2.Location = new Point(8, 48);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(344, 56);
      this.groupBox2.TabIndex = 210;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Display Filters";
      this.chkShowPlayers.Location = new Point(176, 32);
      this.chkShowPlayers.Name = "chkShowPlayers";
      this.chkShowPlayers.Size = new Size(160, 16);
      this.chkShowPlayers.TabIndex = 5;
      this.chkShowPlayers.Text = "Show Players";
      this.chkShowCreatures.Location = new Point(8, 32);
      this.chkShowCreatures.Name = "chkShowCreatures";
      this.chkShowCreatures.Size = new Size(160, 16);
      this.chkShowCreatures.TabIndex = 4;
      this.chkShowCreatures.Text = "Show Creatures";
      this.chkShowTips.Location = new Point(8, 16);
      this.chkShowTips.Name = "chkShowTips";
      this.chkShowTips.Size = new Size(80, 16);
      this.chkShowTips.TabIndex = 12;
      this.chkShowTips.Text = "Show Tips";
      this.chkShowItems.Location = new Point(176, 16);
      this.chkShowItems.Name = "chkShowItems";
      this.chkShowItems.Size = new Size(160, 16);
      this.chkShowItems.TabIndex = 8;
      this.chkShowItems.Text = "Show Items";
      this.btnDLPlayers.Location = new Point(120, 280);
      this.btnDLPlayers.Name = "btnDLPlayers";
      this.btnDLPlayers.Size = new Size(96, 24);
      this.btnDLPlayers.TabIndex = 215;
      this.btnDLPlayers.Text = "Get Players";
      this.btnDLPlayers.Click += new EventHandler(this.btnDLPlayers_Click);
      this.btnCancel.Location = new Point(248, 448);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(88, 24);
      this.btnCancel.TabIndex = 217;
      this.btnCancel.Text = "Close";
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.groupBox3.Controls.Add((Control) this.listPlayers);
      this.groupBox3.Controls.Add((Control) this.cmbPlayerMap);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Controls.Add((Control) this.cmbCriminal);
      this.groupBox3.Controls.Add((Control) this.label13);
      this.groupBox3.Controls.Add((Control) this.cmbAccessLevel);
      this.groupBox3.Controls.Add((Control) this.btnDLPlayers);
      this.groupBox3.Location = new Point(0, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(336, 312);
      this.groupBox3.TabIndex = 219;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Player Filters";
      this.listPlayers.HorizontalScrollbar = true;
      this.listPlayers.Location = new Point(208, 64);
      this.listPlayers.Name = "listPlayers";
      this.listPlayers.Size = new Size(120, 212);
      this.listPlayers.TabIndex = 222;
      this.listPlayers.SelectedIndexChanged += new EventHandler(this.listPlayers_SelectedIndexChanged);
      this.cmbPlayerMap.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbPlayerMap.Items.AddRange(new object[2]
      {
        (object) "Current map",
        (object) "All maps"
      });
      this.cmbPlayerMap.Location = new Point(8, 280);
      this.cmbPlayerMap.Name = "cmbPlayerMap";
      this.cmbPlayerMap.Size = new Size(96, 21);
      this.cmbPlayerMap.TabIndex = 220;
      this.label12.Location = new Point(8, 38);
      this.label12.Name = "label12";
      this.label12.Size = new Size(72, 16);
      this.label12.TabIndex = 32;
      this.label12.Text = "Notoriety:";
      this.label12.TextAlign = ContentAlignment.MiddleRight;
      this.cmbCriminal.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbCriminal.Items.AddRange(new object[4]
      {
        (object) "No Restriction",
        (object) "Innocents Only",
        (object) "Criminals Only",
        (object) "Murderers Only"
      });
      this.cmbCriminal.Location = new Point(80, 38);
      this.cmbCriminal.Name = "cmbCriminal";
      this.cmbCriminal.Size = new Size(120, 21);
      this.cmbCriminal.TabIndex = 31;
      this.label13.Location = new Point(8, 16);
      this.label13.Name = "label13";
      this.label13.Size = new Size(72, 16);
      this.label13.TabIndex = 30;
      this.label13.Text = "AccessLevel:";
      this.label13.TextAlign = ContentAlignment.MiddleRight;
      this.cmbAccessLevel.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbAccessLevel.Items.AddRange(new object[7]
      {
        (object) "No Restriction",
        (object) "Player Only",
        (object) "Staff Only",
        (object) "Counselor Only",
        (object) "GM Only",
        (object) "Seer Only",
        (object) "Administrator Only"
      });
      this.cmbAccessLevel.Location = new Point(80, 16);
      this.cmbAccessLevel.Name = "cmbAccessLevel";
      this.cmbAccessLevel.Size = new Size(120, 21);
      this.cmbAccessLevel.TabIndex = 29;
      this.btnRenew.Location = new Point(8, 448);
      this.btnRenew.Name = "btnRenew";
      this.btnRenew.Size = new Size(208, 24);
      this.btnRenew.TabIndex = 220;
      this.btnRenew.Text = "Renew Session Authentication";
      this.toolTip1.SetToolTip((Control) this.btnRenew, "Registers the current Spawn Editor session with the server.  Must be logged in to the server via the UO client with a staff level account.");
      this.btnRenew.Click += new EventHandler(this.btnRenew_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Location = new Point(8, 104);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.ShowToolTips = true;
      this.tabControl1.Size = new Size(344, 336);
      this.tabControl1.TabIndex = 221;
      this.tabPage1.Controls.Add((Control) this.grpSpawner);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Size = new Size(336, 310);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Spawners";
      this.tabPage2.Controls.Add((Control) this.grpTransferServer);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Size = new Size(336, 310);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Items";
      this.tabPage3.Controls.Add((Control) this.groupBox1);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new Size(336, 310);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Creatures";
      this.tabPage4.Controls.Add((Control) this.groupBox3);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new Size(336, 310);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Players";
      this.cmbModifiedBy.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbModifiedBy.Items.AddRange(new object[2]
      {
        (object) "first",
        (object) "last"
      });
      this.cmbModifiedBy.Location = new Point(72, 208);
      this.cmbModifiedBy.Name = "cmbModifiedBy";
      this.cmbModifiedBy.Size = new Size(56, 21);
      this.cmbModifiedBy.TabIndex = 231;
      this.chkModifiedBy.Location = new Point(8, 208);
      this.chkModifiedBy.Name = "chkModifiedBy";
      this.chkModifiedBy.Size = new Size(72, 16);
      this.chkModifiedBy.TabIndex = 232;
      this.chkModifiedBy.Text = "Modified";
      this.txtModifiedBy.Location = new Point(192, 208);
      this.txtModifiedBy.Name = "txtModifiedBy";
      this.txtModifiedBy.Size = new Size(128, 20);
      this.txtModifiedBy.TabIndex = 233;
      this.txtModifiedBy.Text = "";
      this.cmbModifiedNotBy.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbModifiedNotBy.Items.AddRange(new object[2]
      {
        (object) "by",
        (object) "not by"
      });
      this.cmbModifiedNotBy.Location = new Point(128, 208);
      this.cmbModifiedNotBy.Name = "cmbModifiedNotBy";
      this.cmbModifiedNotBy.Size = new Size(64, 21);
      this.cmbModifiedNotBy.TabIndex = 234;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(358, 478);
      this.ControlBox = false;
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.btnRenew);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.transferServer);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = "TransferServerSettings";
      this.Text = "Transfer Server Settings";
      this.Load += new EventHandler(this.TransferServerSettings_Load);
      this.grpTransferServer.ResumeLayout(false);
      this.grpSpawner.ResumeLayout(false);
      this.numAvgSpawnTime.EndInit();
      this.transferServer.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void TransferServerSettings_Load(object sender, EventArgs e)
    {
    }

    private void InitializeSettings()
    {
      this.cmbStatics.SelectedIndex = 0;
      this.cmbVisible.SelectedIndex = 0;
      this.cmbMovable.SelectedIndex = 0;
      this.cmbItemInContainers.SelectedIndex = 2;
      this.cmbCarried.SelectedIndex = 2;
      this.cmbBlessed.SelectedIndex = 0;
      this.cmbControlled.SelectedIndex = 0;
      this.cmbInnocent.SelectedIndex = 0;
      this.cmbAccessLevel.SelectedIndex = 0;
      this.cmbCriminal.SelectedIndex = 0;
      this.cmbSmartSpawning.SelectedIndex = 0;
      this.cmbSequential.SelectedIndex = 0;
      this.cmbInContainers.SelectedIndex = 0;
      this.cmbModified.SelectedIndex = 0;
      this.cmbProximity.SelectedIndex = 0;
      this.cmbRunning.SelectedIndex = 0;
      this.dtModified.Value = DateTime.Now;
      this.cmbAvgSpawnTime.SelectedIndex = 0;
      this.cmbModifiedBy.SelectedIndex = 0;
      this.cmbModifiedNotBy.SelectedIndex = 0;
      this.cmbSpawnerMap.SelectedIndex = 0;
      this.cmbCreatureMap.SelectedIndex = 0;
      this.cmbItemMap.SelectedIndex = 0;
      this.cmbPlayerMap.SelectedIndex = 0;
    }

    internal void DisplayStatusIndicator(string text)
    {
      this._Editor.progressBar1.Visible = true;
      this._Editor.lblTransferStatus.Visible = true;
      this._Editor.trkZoom.Visible = false;
      this._Editor.lblTrkMin.Visible = false;
      this._Editor.lblTrkMax.Visible = false;
      this._Editor.lblTransferStatus.BringToFront();
      this._Editor.progressBar1.BringToFront();
      this._Editor.lblTransferStatus.Text = text;
      this._Editor.lblTransferStatus.Refresh();
    }

    internal void HideStatusIndicator()
    {
      this._Editor.progressBar1.Visible = false;
      this._Editor.lblTransferStatus.Visible = false;
      this._Editor.trkZoom.Visible = true;
      this._Editor.lblTrkMin.Visible = true;
      this._Editor.lblTrkMax.Visible = true;
      this._Editor.trkZoom.Refresh();
      this._Editor.lblTrkMin.Refresh();
      this._Editor.lblTrkMax.Refresh();
    }

    private void btnDLCreatures_Click(object sender, EventArgs e)
    {
      GetObjectData getObjectData = new GetObjectData();
      getObjectData.SelectedMap = this.cmbCreatureMap.SelectedIndex != 1 ? this._Editor.cbxMap.SelectedIndex : -1;
      getObjectData.ObjectType = this.txtCreatureType.Text == null || this.txtCreatureType.Text.Trim().Length <= 0 ? "BaseCreature" : this.txtCreatureType.Text.Trim();
      getObjectData.Controlled = (short) this.cmbControlled.SelectedIndex;
      getObjectData.Innocent = (short) this.cmbInnocent.SelectedIndex;
      getObjectData.AuthenticationID = this._Editor.SessionID;
      string text = this.txtTransferServerAddress.Text;
      int Port = -1;
      try
      {
        Port = int.Parse(this.txtTransferServerPort.Text);
      }
      catch
      {
      }
      this.DisplayStatusIndicator("Getting Creature Info...");
      TransferMessage transferMessage = TransferConnection.ProcessMessage(text, Port, (TransferMessage) getObjectData);
      if (transferMessage is ReturnObjectData)
      {
        this._Editor.MobLocArray = ((ReturnObjectData) transferMessage).Data;
        if (this._Editor.MobLocArray.Length == 0)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "No Creatures found.", "Empty Download", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        this.listCreatures.Items.Clear();
        this.listCreatures.Sorted = false;
        for (int index = 0; index < this._Editor.MobLocArray.Length; ++index)
          this.listCreatures.Items.Add((object) this._Editor.MobLocArray[index]);
        this.listCreatures.Sorted = true;
        this.chkShowCreatures.Text = string.Format("Show Creatures ({0})", (object) this._Editor.MobLocArray.Length);
        this.chkShowCreatures.Checked = true;
        this.DisplayStatusIndicator("Updating Display...");
        this._Editor.RefreshSpawnPoints();
      }
      this.HideStatusIndicator();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void btnDLItems_Click(object sender, EventArgs e)
    {
      GetObjectData getObjectData = new GetObjectData();
      getObjectData.SelectedMap = this.cmbItemMap.SelectedIndex != 1 ? this._Editor.cbxMap.SelectedIndex : -1;
      getObjectData.Movable = (short) this.cmbMovable.SelectedIndex;
      getObjectData.Visible = (short) this.cmbVisible.SelectedIndex;
      getObjectData.Statics = (short) this.cmbStatics.SelectedIndex;
      getObjectData.InContainers = (short) this.cmbItemInContainers.SelectedIndex;
      getObjectData.Blessed = (short) this.cmbBlessed.SelectedIndex;
      getObjectData.Carried = (short) this.cmbCarried.SelectedIndex;
      getObjectData.ItemID = -1;
      if (this.txtItemID.Text != null)
      {
        if (this.txtItemID.Text.Length > 0)
        {
          try
          {
            getObjectData.ItemID = !this.txtItemID.Text.StartsWith("0x") ? int.Parse(this.txtItemID.Text) : Convert.ToInt32(this.txtItemID.Text, 16);
          }
          catch
          {
          }
        }
      }
      getObjectData.ObjectType = this.txtItemType.Text == null || this.txtItemType.Text.Trim().Length <= 0 ? "Item" : this.txtItemType.Text.Trim();
      getObjectData.AuthenticationID = this._Editor.SessionID;
      string text = this.txtTransferServerAddress.Text;
      int Port = -1;
      try
      {
        Port = int.Parse(this.txtTransferServerPort.Text);
      }
      catch
      {
      }
      this.DisplayStatusIndicator("Getting Item Info...");
      TransferMessage transferMessage = TransferConnection.ProcessMessage(text, Port, (TransferMessage) getObjectData);
      if (transferMessage is ReturnObjectData)
      {
        this._Editor.ItemLocArray = ((ReturnObjectData) transferMessage).Data;
        if (this._Editor.ItemLocArray.Length == 0)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "No Items found.", "Empty Download", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        this.listItems.Items.Clear();
        this.listItems.Sorted = false;
        for (int index = 0; index < this._Editor.ItemLocArray.Length; ++index)
          this.listItems.Items.Add((object) this._Editor.ItemLocArray[index]);
        this.listItems.Sorted = true;
        this.chkShowItems.Text = string.Format("Show Items ({0})", (object) this._Editor.ItemLocArray.Length);
        this.chkShowItems.Checked = true;
        this.DisplayStatusIndicator("Updating Display...");
        this._Editor.RefreshSpawnPoints();
      }
      this.HideStatusIndicator();
    }

    private void btnDLPlayers_Click(object sender, EventArgs e)
    {
      GetObjectData getObjectData = new GetObjectData();
      getObjectData.SelectedMap = this.cmbPlayerMap.SelectedIndex != 1 ? this._Editor.cbxMap.SelectedIndex : -1;
      getObjectData.ObjectType = "PlayerMobile";
      getObjectData.Access = (short) this.cmbAccessLevel.SelectedIndex;
      getObjectData.Criminal = (short) this.cmbCriminal.SelectedIndex;
      getObjectData.AuthenticationID = this._Editor.SessionID;
      string text = this.txtTransferServerAddress.Text;
      int Port = -1;
      try
      {
        Port = int.Parse(this.txtTransferServerPort.Text);
      }
      catch
      {
      }
      this.DisplayStatusIndicator("Getting Player Info...");
      TransferMessage transferMessage = TransferConnection.ProcessMessage(text, Port, (TransferMessage) getObjectData);
      if (transferMessage is ReturnObjectData)
      {
        this._Editor.PlayerLocArray = ((ReturnObjectData) transferMessage).Data;
        if (this._Editor.PlayerLocArray.Length == 0)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "No Players found.", "Empty Download", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        this.listPlayers.Items.Clear();
        this.listPlayers.Sorted = false;
        for (int index = 0; index < this._Editor.PlayerLocArray.Length; ++index)
          this.listPlayers.Items.Add((object) this._Editor.PlayerLocArray[index]);
        this.listPlayers.Sorted = true;
        this.chkShowPlayers.Text = string.Format("Show Players ({0})", (object) this._Editor.PlayerLocArray.Length);
        this.chkShowPlayers.Checked = true;
        this.DisplayStatusIndicator("Updating Display...");
        this._Editor.RefreshSpawnPoints();
      }
      this.HideStatusIndicator();
    }

    private void btnDLSpawners_Click(object sender, EventArgs e)
    {
      GetSpawnerData getSpawnerData = new GetSpawnerData();
      if (sender == this.btnDLSpawners)
        this._Editor.tvwSpawnPoints.Nodes.Clear();
      getSpawnerData.SelectedMap = this.cmbSpawnerMap.SelectedIndex != 1 ? this._Editor.cbxMap.SelectedIndex : -1;
      if (this.chkSpawnerWithinSelectionWindow.Checked && this._Editor._SelectionWindow != null)
      {
        getSpawnerData.X = (int) this._Editor._SelectionWindow.X;
        getSpawnerData.Y = (int) this._Editor._SelectionWindow.Y;
        getSpawnerData.Width = (int) this._Editor._SelectionWindow.Width;
        getSpawnerData.Height = (int) this._Editor._SelectionWindow.Height;
      }
      else
      {
        getSpawnerData.Width = -1;
        getSpawnerData.Height = -1;
      }
      getSpawnerData.NameFilter = this.txtSpawnerName.Text;
      getSpawnerData.NameCase = this.chkNameCase.Checked;
      getSpawnerData.EntryFilter = this.txtSpawnerEntry.Text;
      getSpawnerData.EntryCase = this.chkEntryCase.Checked;
      getSpawnerData.ContainerFilter = (short) this.cmbInContainers.SelectedIndex;
      getSpawnerData.SmartSpawnFilter = (short) this.cmbSmartSpawning.SelectedIndex;
      getSpawnerData.SequentialFilter = (short) this.cmbSequential.SelectedIndex;
      getSpawnerData.Proximity = (short) this.cmbProximity.SelectedIndex;
      getSpawnerData.Running = (short) this.cmbRunning.SelectedIndex;
      if (this.chkAvgSpawnTime.Checked)
      {
        getSpawnerData.AvgSpawnTime = (double) this.numAvgSpawnTime.Value;
        getSpawnerData.SpawnTime = (short) (this.cmbAvgSpawnTime.SelectedIndex + 1);
      }
      else
        getSpawnerData.SpawnTime = (short) 0;
      getSpawnerData.Modified = !this.chkModified.Checked ? (short) 0 : (short) (this.cmbModified.SelectedIndex + 1);
      getSpawnerData.ModifiedDate = this.dtModified.Value;
      getSpawnerData.ModifiedBy = !this.chkModifiedBy.Checked ? (short) 0 : (short) (this.cmbModifiedBy.SelectedIndex + 1 + this.cmbModifiedNotBy.SelectedIndex * 2);
      getSpawnerData.ModifiedName = this.txtModifiedBy.Text;
      getSpawnerData.AuthenticationID = this._Editor.SessionID;
      string text = this.txtTransferServerAddress.Text;
      int Port = -1;
      try
      {
        Port = int.Parse(this.txtTransferServerPort.Text);
      }
      catch
      {
      }
      this.DisplayStatusIndicator("Downloading Spawners...");
      TransferMessage transferMessage = TransferConnection.ProcessMessage(text, Port, (TransferMessage) getSpawnerData);
      if (transferMessage is ReturnSpawnerData)
      {
        byte[] data = ((ReturnSpawnerData) transferMessage).Data;
        if (data == null || data.Length == 0)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "No Spawners found.", "Empty Download", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          this._Editor.LoadSpawnFile((Stream) new MemoryStream(data), (string) null, WorldMap.Internal);
      }
      this.DisplayStatusIndicator("Updating Display...");
      this._Editor.RefreshSpawnPoints();
      this.HideStatusIndicator();
    }

    private void btnRenew_Click(object sender, EventArgs e)
    {
      this._Editor.SessionID = Guid.NewGuid();
      this._Editor.SendAuthCommand(this._Editor.SessionID);
    }

    private void listPlayers_SelectedIndexChanged(object sender, EventArgs e)
    {
      ObjectData objectData = this.listPlayers.SelectedItem as ObjectData;
      if (objectData == null)
        return;
      this._Editor.cbxMap.SelectedIndex = objectData.Map;
      this._Editor.axUOMap.SetCenter((short) objectData.X, (short) objectData.Y);
    }

    private void listItems_SelectedIndexChanged(object sender, EventArgs e)
    {
      ObjectData objectData = this.listItems.SelectedItem as ObjectData;
      if (objectData == null)
        return;
      this._Editor.cbxMap.SelectedIndex = objectData.Map;
      this._Editor.axUOMap.SetCenter((short) objectData.X, (short) objectData.Y);
    }

    private void listCreatures_SelectedIndexChanged(object sender, EventArgs e)
    {
      ObjectData objectData = this.listCreatures.SelectedItem as ObjectData;
      if (objectData == null)
        return;
      this._Editor.cbxMap.SelectedIndex = objectData.Map;
      this._Editor.axUOMap.SetCenter((short) objectData.X, (short) objectData.Y);
    }

    private void chkSpawnerWithinSelectionWindow_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSpawnerWithinSelectionWindow.Checked)
      {
        this.cmbSpawnerMap.SelectedIndex = 0;
        this.cmbSpawnerMap.Enabled = false;
      }
      else
        this.cmbSpawnerMap.Enabled = true;
    }
  }
}
