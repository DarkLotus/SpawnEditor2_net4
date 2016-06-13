// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.Configure
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SpawnEditor2
{
  public class Configure : Form
  {
    private readonly string UOTDRegistryKey = "Software\\Origin Worlds Online\\Ultima Online Third Dawn\\1.0";
    private readonly string T2ARegistryKey = "Software\\Origin Worlds Online\\Ultima Online\\1.0";
    private readonly string UOExePathValue = "ExePath";
    private readonly string AppRegistryKey = "Software\\Spawn Editor";
    private readonly string AppRunUoPathValue = "RunUO Exe Path";
    private readonly string AppUoClientPathValue = "Ultima Client Exe Path";
    private readonly string AppZoomLevelValue = "Zoom Level";
    private readonly string AppRunUoCmdPrefixValue = "RunUO Cmd Prefix";
    private readonly string AppUoClientWindowValue = "Ultima Client Window";
    private readonly string AppSpawnNameValue = "Spawn Name";
    private readonly string AppSpawnHomeRangeValue = "Spawn Home Range";
    private readonly string AppSpawnMaxCountValue = "Spawn Max Count";
    private readonly string AppSpawnMinDelayValue = "Spawn Min Delay";
    private readonly string AppSpawnMaxDelayValue = "Spawn Max Delay";
    private readonly string AppSpawnTeamValue = "Spawn Team";
    private readonly string AppSpawnGroupValue = "Spawn Group";
    private readonly string AppSpawnRunningValue = "Spawn Running";
    private readonly string AppSpawnRelativeHomeValue = "Spawn Relative Home";
    private readonly string AppStartingStaticsValue = "Starting Statics";
    private readonly string AppStartingDetailsValue = "Starting Details";
    private readonly string AppStartingMapValue = "Starting Map";
    private readonly string AppStartingOnTopValue = "Starting On Top";
    private readonly string AppStartingXValue = "Starting X";
    private readonly string AppStartingYValue = "Starting Y";
    private readonly string AppStartingWidthValue = "Starting Width";
    private readonly string AppStartingHeightValue = "Starting Height";
    private readonly string AppTransferServerAddressValue = "Transfer Server Address";
    private readonly string AppTransferServerPortValue = "Transfer Server Port";
    public string CfgUoClientWindowValue = "Ultima Online Third Dawn";
    public short CfgZoomLevelValue = (short) -4;
    public string CfgRunUoCmdPrefix = "[";
    public string CfgSpawnNameValue = "Spawn";
    public int CfgSpawnHomeRangeValue = 10;
    public int CfgSpawnMaxCountValue = 1;
    public int CfgSpawnMinDelayValue = 5;
    public int CfgSpawnMaxDelayValue = 10;
    public int CfgSpawnTeamValue = 0;
    public bool CfgSpawnGroupValue = false;
    public bool CfgSpawnRunningValue = true;
    public bool CfgSpawnRelativeHomeValue = true;
    public bool CfgStartingStaticsValue = false;
    public bool CfgStartingDetailsValue = false;
    public WorldMap CfgStartingMapValue = WorldMap.Trammel;
    public bool CfgStartingOnTopValue = false;
    public int CfgStartingXValue = -1;
    public int CfgStartingYValue = -1;
    public int CfgStartingWidthValue = -1;
    public int CfgStartingHeightValue = -1;
    public string CfgTransferServerAddressValue = "127.0.0.1";
    public int CfgTransferServerPortValue = 8030;
    private bool _IsValidConfiguration = false;
    private RegistryKey _HKLMKey = (RegistryKey) null;
    private RegistryKey _HKCUKey = (RegistryKey) null;
    public string CfgRunUoPathValue;
    public string CfgUoClientPathValue;
    private OpenFileDialog ofdOpenFile;
    private TextBox txtRunUOExe;
    private Button btnRunUOExe;
    private Label lblRunUOExe;
    private TextBox txtUltimaClient;
    private Label lblUltimaClient;
    private Button btnUltimaClient;
    private Label label1;
    private TrackBar trkZoom;
    private GroupBox grpSpawnEdit;
    private Label lblMaxDelay;
    private Label lblHomeRange;
    private Label lblTeam;
    private Label lblMaxCount;
    private Label lblMinDelay;
    private CheckBox chkSpawnRunning;
    private NumericUpDown spnSpawnMaxCount;
    private TextBox txtSpawnName;
    private NumericUpDown spnSpawnRange;
    private NumericUpDown spnSpawnMinDelay;
    private NumericUpDown spnSpawnTeam;
    private CheckBox chkSpawnGroup;
    private NumericUpDown spnSpawnMaxDelay;
    private Button btnOk;
    private Button btnCancel;
    private CheckBox chkHomeRangeIsRelative;
    private TextBox txtCmdPrefix;
    private Label lblCmdPrefix;
    private Label lblClientWindow;
    private TextBox txtClientWindow;
    private CheckBox startingStatics;
    private CheckBox startingDetails;
    private ComboBox startingMap;
    private Label label2;
    private CheckBox startingOnTop;
    private IContainer components;
    private SpawnEditor _Editor;

    public bool IsValidConfiguration
    {
      get
      {
        return this._IsValidConfiguration;
      }
    }

    public Configure(SpawnEditor editor)
    {
      this._Editor = editor;
      this.InitializeComponent();
      this._HKCUKey = Registry.CurrentUser.OpenSubKey(this.AppRegistryKey, true);
      if (this._HKCUKey == null || this._HKCUKey.ValueCount < 14)
        return;
      this.CfgRunUoPathValue = (string) this._HKCUKey.GetValue(this.AppRunUoPathValue, (object) string.Empty);
      this.CfgUoClientPathValue = (string) this._HKCUKey.GetValue(this.AppUoClientPathValue, (object) string.Empty);
      this.CfgUoClientWindowValue = (string) this._HKCUKey.GetValue(this.AppUoClientWindowValue, (object) "Ultima Online Third Dawn");
      this.CfgZoomLevelValue = short.Parse(this._HKCUKey.GetValue(this.AppZoomLevelValue, (object) "-4") as string);
      this.CfgRunUoCmdPrefix = (string) this._HKCUKey.GetValue(this.AppRunUoCmdPrefixValue, (object) "[");
      this.CfgSpawnNameValue = (string) this._HKCUKey.GetValue(this.AppSpawnNameValue, (object) "Spawner");
      this.CfgSpawnHomeRangeValue = (int) this._HKCUKey.GetValue(this.AppSpawnHomeRangeValue, (object) 5);
      this.CfgSpawnMaxCountValue = (int) this._HKCUKey.GetValue(this.AppSpawnMaxCountValue, (object) 1);
      this.CfgSpawnMinDelayValue = (int) this._HKCUKey.GetValue(this.AppSpawnMinDelayValue, (object) 5);
      this.CfgSpawnMaxDelayValue = (int) this._HKCUKey.GetValue(this.AppSpawnMaxDelayValue, (object) 10);
      this.CfgSpawnTeamValue = (int) this._HKCUKey.GetValue(this.AppSpawnTeamValue, (object) 0);
      this.CfgSpawnGroupValue = bool.Parse(this._HKCUKey.GetValue(this.AppSpawnGroupValue, (object) bool.FalseString) as string);
      this.CfgSpawnRunningValue = bool.Parse(this._HKCUKey.GetValue(this.AppSpawnRunningValue, (object) bool.TrueString) as string);
      this.CfgSpawnRelativeHomeValue = bool.Parse(this._HKCUKey.GetValue(this.AppSpawnRelativeHomeValue, (object) bool.TrueString) as string);
      this.CfgStartingStaticsValue = bool.Parse(this._HKCUKey.GetValue(this.AppStartingStaticsValue, (object) bool.FalseString) as string);
      this.CfgStartingDetailsValue = bool.Parse(this._HKCUKey.GetValue(this.AppStartingDetailsValue, (object) bool.FalseString) as string);
      this.CfgStartingMapValue = (WorldMap) Enum.Parse(typeof (WorldMap), this._HKCUKey.GetValue(this.AppStartingMapValue, (object) "Trammel") as string);
      this.CfgStartingOnTopValue = bool.Parse(this._HKCUKey.GetValue(this.AppStartingOnTopValue, (object) bool.FalseString) as string);
      this.CfgStartingXValue = (int) this._HKCUKey.GetValue(this.AppStartingXValue, (object) -1);
      this.CfgStartingYValue = (int) this._HKCUKey.GetValue(this.AppStartingYValue, (object) -1);
      this.CfgStartingWidthValue = (int) this._HKCUKey.GetValue(this.AppStartingWidthValue, (object) -1);
      this.CfgStartingHeightValue = (int) this._HKCUKey.GetValue(this.AppStartingHeightValue, (object) -1);
      this.CfgTransferServerAddressValue = (string) this._HKCUKey.GetValue(this.AppTransferServerAddressValue, (object) "127.0.0.1");
      this.CfgTransferServerPortValue = (int) this._HKCUKey.GetValue(this.AppTransferServerPortValue, (object) 8030);
      if (!File.Exists(this.CfgRunUoPathValue) || this.CfgUoClientPathValue.Length <= 0)
        return;
      this._IsValidConfiguration = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.ofdOpenFile = new OpenFileDialog();
      this.txtRunUOExe = new TextBox();
      this.btnRunUOExe = new Button();
      this.lblRunUOExe = new Label();
      this.txtUltimaClient = new TextBox();
      this.lblUltimaClient = new Label();
      this.btnUltimaClient = new Button();
      this.label1 = new Label();
      this.trkZoom = new TrackBar();
      this.grpSpawnEdit = new GroupBox();
      this.chkHomeRangeIsRelative = new CheckBox();
      this.lblMaxDelay = new Label();
      this.chkSpawnRunning = new CheckBox();
      this.lblHomeRange = new Label();
      this.spnSpawnMaxCount = new NumericUpDown();
      this.txtSpawnName = new TextBox();
      this.spnSpawnRange = new NumericUpDown();
      this.lblTeam = new Label();
      this.lblMaxCount = new Label();
      this.spnSpawnMinDelay = new NumericUpDown();
      this.spnSpawnTeam = new NumericUpDown();
      this.chkSpawnGroup = new CheckBox();
      this.spnSpawnMaxDelay = new NumericUpDown();
      this.lblMinDelay = new Label();
      this.btnOk = new Button();
      this.btnCancel = new Button();
      this.txtCmdPrefix = new TextBox();
      this.lblCmdPrefix = new Label();
      this.lblClientWindow = new Label();
      this.txtClientWindow = new TextBox();
      this.startingStatics = new CheckBox();
      this.startingDetails = new CheckBox();
      this.startingMap = new ComboBox();
      this.label2 = new Label();
      this.startingOnTop = new CheckBox();
      this.trkZoom.BeginInit();
      this.grpSpawnEdit.SuspendLayout();
      this.spnSpawnMaxCount.BeginInit();
      this.spnSpawnRange.BeginInit();
      this.spnSpawnMinDelay.BeginInit();
      this.spnSpawnTeam.BeginInit();
      this.spnSpawnMaxDelay.BeginInit();
      this.SuspendLayout();
      this.ofdOpenFile.DefaultExt = "exe";
      this.ofdOpenFile.Filter = "Executable (*.exe)|*.exe|All Files (*.*)|*.*";
      this.ofdOpenFile.ReadOnlyChecked = true;
      this.txtRunUOExe.Location = new Point(80, 8);
      this.txtRunUOExe.Name = "txtRunUOExe";
      this.txtRunUOExe.ReadOnly = true;
      this.txtRunUOExe.Size = new Size(208, 20);
      this.txtRunUOExe.TabIndex = 1;
      this.txtRunUOExe.Text = "";
      this.btnRunUOExe.Location = new Point(288, 8);
      this.btnRunUOExe.Name = "btnRunUOExe";
      this.btnRunUOExe.Size = new Size(24, 20);
      this.btnRunUOExe.TabIndex = 2;
      this.btnRunUOExe.Text = "...";
      this.btnRunUOExe.Click += new EventHandler(this.btnRunUOExe_Click);
      this.lblRunUOExe.Location = new Point(8, 8);
      this.lblRunUOExe.Name = "lblRunUOExe";
      this.lblRunUOExe.Size = new Size(80, 20);
      this.lblRunUOExe.TabIndex = 0;
      this.lblRunUOExe.Text = "RunUO.EXE:";
      this.lblRunUOExe.TextAlign = ContentAlignment.MiddleLeft;
      this.txtUltimaClient.Location = new Point(80, 32);
      this.txtUltimaClient.Name = "txtUltimaClient";
      this.txtUltimaClient.ReadOnly = true;
      this.txtUltimaClient.Size = new Size(208, 20);
      this.txtUltimaClient.TabIndex = 4;
      this.txtUltimaClient.Text = "";
      this.lblUltimaClient.Location = new Point(8, 32);
      this.lblUltimaClient.Name = "lblUltimaClient";
      this.lblUltimaClient.Size = new Size(80, 20);
      this.lblUltimaClient.TabIndex = 3;
      this.lblUltimaClient.Text = "Ultima Client:";
      this.lblUltimaClient.TextAlign = ContentAlignment.MiddleLeft;
      this.btnUltimaClient.Location = new Point(288, 32);
      this.btnUltimaClient.Name = "btnUltimaClient";
      this.btnUltimaClient.Size = new Size(24, 20);
      this.btnUltimaClient.TabIndex = 5;
      this.btnUltimaClient.Text = "...";
      this.btnUltimaClient.Click += new EventHandler(this.btnUltimaClient_Click);
      this.label1.Location = new Point(8, 64);
      this.label1.Name = "label1";
      this.label1.Size = new Size(112, 20);
      this.label1.TabIndex = 6;
      this.label1.Text = "Default Zoom Level:";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.trkZoom.LargeChange = 2;
      this.trkZoom.Location = new Point(112, 56);
      this.trkZoom.Maximum = 4;
      this.trkZoom.Minimum = -4;
      this.trkZoom.Name = "trkZoom";
      this.trkZoom.Size = new Size(146, 45);
      this.trkZoom.TabIndex = 7;
      this.trkZoom.TickStyle = TickStyle.TopLeft;
      this.grpSpawnEdit.Controls.Add((Control) this.chkHomeRangeIsRelative);
      this.grpSpawnEdit.Controls.Add((Control) this.lblMaxDelay);
      this.grpSpawnEdit.Controls.Add((Control) this.chkSpawnRunning);
      this.grpSpawnEdit.Controls.Add((Control) this.lblHomeRange);
      this.grpSpawnEdit.Controls.Add((Control) this.spnSpawnMaxCount);
      this.grpSpawnEdit.Controls.Add((Control) this.txtSpawnName);
      this.grpSpawnEdit.Controls.Add((Control) this.spnSpawnRange);
      this.grpSpawnEdit.Controls.Add((Control) this.lblTeam);
      this.grpSpawnEdit.Controls.Add((Control) this.lblMaxCount);
      this.grpSpawnEdit.Controls.Add((Control) this.spnSpawnMinDelay);
      this.grpSpawnEdit.Controls.Add((Control) this.spnSpawnTeam);
      this.grpSpawnEdit.Controls.Add((Control) this.chkSpawnGroup);
      this.grpSpawnEdit.Controls.Add((Control) this.spnSpawnMaxDelay);
      this.grpSpawnEdit.Controls.Add((Control) this.lblMinDelay);
      this.grpSpawnEdit.Location = new Point(112, 104);
      this.grpSpawnEdit.Name = "grpSpawnEdit";
      this.grpSpawnEdit.Size = new Size(152, 200);
      this.grpSpawnEdit.TabIndex = 10;
      this.grpSpawnEdit.TabStop = false;
      this.grpSpawnEdit.Text = "Default Spawn Details";
      this.chkHomeRangeIsRelative.CheckAlign = ContentAlignment.MiddleRight;
      this.chkHomeRangeIsRelative.Checked = true;
      this.chkHomeRangeIsRelative.CheckState = CheckState.Checked;
      this.chkHomeRangeIsRelative.Location = new Point(8, 176);
      this.chkHomeRangeIsRelative.Name = "chkHomeRangeIsRelative";
      this.chkHomeRangeIsRelative.Size = new Size(102, 16);
      this.chkHomeRangeIsRelative.TabIndex = 13;
      this.chkHomeRangeIsRelative.Text = "Relative Home:";
      this.lblMaxDelay.Location = new Point(8, 104);
      this.lblMaxDelay.Name = "lblMaxDelay";
      this.lblMaxDelay.Size = new Size(80, 16);
      this.lblMaxDelay.TabIndex = 7;
      this.lblMaxDelay.Text = "Max Delay (m)";
      this.chkSpawnRunning.CheckAlign = ContentAlignment.MiddleRight;
      this.chkSpawnRunning.Checked = true;
      this.chkSpawnRunning.CheckState = CheckState.Checked;
      this.chkSpawnRunning.Location = new Point(8, 160);
      this.chkSpawnRunning.Name = "chkSpawnRunning";
      this.chkSpawnRunning.Size = new Size(102, 16);
      this.chkSpawnRunning.TabIndex = 12;
      this.chkSpawnRunning.Text = "Running:";
      this.lblHomeRange.Location = new Point(8, 44);
      this.lblHomeRange.Name = "lblHomeRange";
      this.lblHomeRange.Size = new Size(80, 16);
      this.lblHomeRange.TabIndex = 1;
      this.lblHomeRange.Text = "Home Range:";
      this.spnSpawnMaxCount.Location = new Point(96, 60);
      NumericUpDown numericUpDown1 = this.spnSpawnMaxCount;
      int[] bits1 = new int[4];
      bits1[0] = 10000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.spnSpawnMaxCount.Name = "spnSpawnMaxCount";
      this.spnSpawnMaxCount.Size = new Size(48, 20);
      this.spnSpawnMaxCount.TabIndex = 4;
      NumericUpDown numericUpDown2 = this.spnSpawnMaxCount;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Value = num2;
      this.txtSpawnName.Location = new Point(8, 16);
      this.txtSpawnName.Name = "txtSpawnName";
      this.txtSpawnName.Size = new Size(136, 20);
      this.txtSpawnName.TabIndex = 0;
      this.txtSpawnName.Text = "Spawn";
      this.spnSpawnRange.Location = new Point(96, 40);
      NumericUpDown numericUpDown3 = this.spnSpawnRange;
      int[] bits3 = new int[4];
      bits3[0] = 10000;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Maximum = num3;
      NumericUpDown numericUpDown4 = this.spnSpawnRange;
      int[] bits4 = new int[4];
      bits4[0] = 1;
      Decimal num4 = new Decimal(bits4);
      numericUpDown4.Minimum = num4;
      this.spnSpawnRange.Name = "spnSpawnRange";
      this.spnSpawnRange.Size = new Size(48, 20);
      this.spnSpawnRange.TabIndex = 2;
      NumericUpDown numericUpDown5 = this.spnSpawnRange;
      int[] bits5 = new int[4];
      bits5[0] = 10;
      Decimal num5 = new Decimal(bits5);
      numericUpDown5.Value = num5;
      this.lblTeam.Location = new Point(8, 124);
      this.lblTeam.Name = "lblTeam";
      this.lblTeam.Size = new Size(80, 16);
      this.lblTeam.TabIndex = 9;
      this.lblTeam.Text = "Team:";
      this.lblMaxCount.Location = new Point(8, 64);
      this.lblMaxCount.Name = "lblMaxCount";
      this.lblMaxCount.Size = new Size(80, 16);
      this.lblMaxCount.TabIndex = 3;
      this.lblMaxCount.Text = "Max Count:";
      this.spnSpawnMinDelay.Location = new Point(96, 80);
      NumericUpDown numericUpDown6 = this.spnSpawnMinDelay;
      int[] bits6 = new int[4];
      bits6[0] = (int) ushort.MaxValue;
      Decimal num6 = new Decimal(bits6);
      numericUpDown6.Maximum = num6;
      this.spnSpawnMinDelay.Name = "spnSpawnMinDelay";
      this.spnSpawnMinDelay.Size = new Size(48, 20);
      this.spnSpawnMinDelay.TabIndex = 6;
      NumericUpDown numericUpDown7 = this.spnSpawnMinDelay;
      int[] bits7 = new int[4];
      bits7[0] = 5;
      Decimal num7 = new Decimal(bits7);
      numericUpDown7.Value = num7;
      this.spnSpawnTeam.Location = new Point(96, 120);
      NumericUpDown numericUpDown8 = this.spnSpawnTeam;
      int[] bits8 = new int[4];
      bits8[0] = (int) ushort.MaxValue;
      Decimal num8 = new Decimal(bits8);
      numericUpDown8.Maximum = num8;
      this.spnSpawnTeam.Name = "spnSpawnTeam";
      this.spnSpawnTeam.Size = new Size(48, 20);
      this.spnSpawnTeam.TabIndex = 10;
      this.chkSpawnGroup.CheckAlign = ContentAlignment.MiddleRight;
      this.chkSpawnGroup.Location = new Point(8, 144);
      this.chkSpawnGroup.Name = "chkSpawnGroup";
      this.chkSpawnGroup.Size = new Size(102, 16);
      this.chkSpawnGroup.TabIndex = 11;
      this.chkSpawnGroup.Text = "Group:";
      this.spnSpawnMaxDelay.Location = new Point(96, 100);
      NumericUpDown numericUpDown9 = this.spnSpawnMaxDelay;
      int[] bits9 = new int[4];
      bits9[0] = (int) ushort.MaxValue;
      Decimal num9 = new Decimal(bits9);
      numericUpDown9.Maximum = num9;
      this.spnSpawnMaxDelay.Name = "spnSpawnMaxDelay";
      this.spnSpawnMaxDelay.Size = new Size(48, 20);
      this.spnSpawnMaxDelay.TabIndex = 8;
      NumericUpDown numericUpDown10 = this.spnSpawnMaxDelay;
      int[] bits10 = new int[4];
      bits10[0] = 10;
      Decimal num10 = new Decimal(bits10);
      numericUpDown10.Value = num10;
      this.lblMinDelay.Location = new Point(8, 84);
      this.lblMinDelay.Name = "lblMinDelay";
      this.lblMinDelay.Size = new Size(80, 16);
      this.lblMinDelay.TabIndex = 5;
      this.lblMinDelay.Text = "Min Delay (m)";
      this.btnOk.Location = new Point(112, 368);
      this.btnOk.Name = "btnOk";
      this.btnOk.TabIndex = 11;
      this.btnOk.Text = "&Ok";
      this.btnOk.Click += new EventHandler(this.btnOk_Click);
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(192, 368);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 12;
      this.btnCancel.Text = "&Cancel";
      this.txtCmdPrefix.Location = new Point(8, 120);
      this.txtCmdPrefix.Name = "txtCmdPrefix";
      this.txtCmdPrefix.Size = new Size(96, 20);
      this.txtCmdPrefix.TabIndex = 9;
      this.txtCmdPrefix.Text = "[";
      this.lblCmdPrefix.Location = new Point(8, 104);
      this.lblCmdPrefix.Name = "lblCmdPrefix";
      this.lblCmdPrefix.Size = new Size(96, 16);
      this.lblCmdPrefix.TabIndex = 8;
      this.lblCmdPrefix.Text = "Command Prefix:";
      this.lblClientWindow.Location = new Point(8, 152);
      this.lblClientWindow.Name = "lblClientWindow";
      this.lblClientWindow.Size = new Size(88, 16);
      this.lblClientWindow.TabIndex = 13;
      this.lblClientWindow.Text = "Client Window:";
      this.txtClientWindow.Location = new Point(8, 168);
      this.txtClientWindow.Name = "txtClientWindow";
      this.txtClientWindow.Size = new Size(96, 20);
      this.txtClientWindow.TabIndex = 14;
      this.txtClientWindow.Text = "Ultima Online";
      this.startingStatics.Location = new Point(8, 216);
      this.startingStatics.Name = "startingStatics";
      this.startingStatics.Size = new Size(96, 16);
      this.startingStatics.TabIndex = 15;
      this.startingStatics.Text = "Statics";
      this.startingDetails.Location = new Point(8, 232);
      this.startingDetails.Name = "startingDetails";
      this.startingDetails.Size = new Size(96, 16);
      this.startingDetails.TabIndex = 16;
      this.startingDetails.Text = "Details";
      this.startingMap.DropDownStyle = ComboBoxStyle.DropDownList;
      this.startingMap.Location = new Point(8, 272);
      this.startingMap.Name = "startingMap";
      this.startingMap.Size = new Size(77, 21);
      this.startingMap.TabIndex = 17;
      this.label2.Location = new Point(8, 200);
      this.label2.Name = "label2";
      this.label2.Size = new Size(88, 16);
      this.label2.TabIndex = 18;
      this.label2.Text = "On Startup:";
      this.startingOnTop.Location = new Point(8, 248);
      this.startingOnTop.Name = "startingOnTop";
      this.startingOnTop.Size = new Size(96, 16);
      this.startingOnTop.TabIndex = 19;
      this.startingOnTop.Text = "On Top";
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(314, 392);
      this.Controls.Add((Control) this.startingOnTop);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.startingMap);
      this.Controls.Add((Control) this.startingDetails);
      this.Controls.Add((Control) this.startingStatics);
      this.Controls.Add((Control) this.txtClientWindow);
      this.Controls.Add((Control) this.lblClientWindow);
      this.Controls.Add((Control) this.lblCmdPrefix);
      this.Controls.Add((Control) this.txtCmdPrefix);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.grpSpawnEdit);
      this.Controls.Add((Control) this.trkZoom);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.txtUltimaClient);
      this.Controls.Add((Control) this.lblUltimaClient);
      this.Controls.Add((Control) this.btnUltimaClient);
      this.Controls.Add((Control) this.txtRunUOExe);
      this.Controls.Add((Control) this.lblRunUOExe);
      this.Controls.Add((Control) this.btnRunUOExe);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "Configure";
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Spawn Editor Configuration";
      this.Load += new EventHandler(this.Configure_Load);
      this.trkZoom.EndInit();
      this.grpSpawnEdit.ResumeLayout(false);
      this.spnSpawnMaxCount.EndInit();
      this.spnSpawnRange.EndInit();
      this.spnSpawnMinDelay.EndInit();
      this.spnSpawnTeam.EndInit();
      this.spnSpawnMaxDelay.EndInit();
      this.ResumeLayout(false);
    }

    private void btnRunUOExe_Click(object sender, EventArgs e)
    {
      if (this.ofdOpenFile.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      this.txtRunUOExe.Text = this.ofdOpenFile.FileName;
    }

    private void btnUltimaClient_Click(object sender, EventArgs e)
    {
      if (this.ofdOpenFile.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      this.txtUltimaClient.Text = this.ofdOpenFile.FileName;
      this.SetClientWindowName();
    }

    private void Configure_Load(object sender, EventArgs e)
    {
      if (this._Editor.TopMost)
        this.TopMost = true;
      foreach (WorldMap worldMap in Enum.GetValues(typeof (WorldMap)))
      {
        if (worldMap != WorldMap.Internal)
          this.startingMap.Items.Add((object) worldMap);
      }
      if (!this._IsValidConfiguration)
      {
        this._HKLMKey = Registry.LocalMachine.OpenSubKey(this.UOTDRegistryKey);
        this.CfgUoClientWindowValue = "Ultima Online Third Dawn";
        if (this._HKLMKey == null)
          this._HKLMKey = Registry.LocalMachine.OpenSubKey(this.T2ARegistryKey);
        if (this._HKLMKey != null)
        {
          this.CfgUoClientPathValue = (string) this._HKLMKey.GetValue(this.UOExePathValue);
          this.txtUltimaClient.Text = this.CfgUoClientPathValue;
          this.SetClientWindowName();
        }
      }
      this.txtRunUOExe.Text = this.CfgRunUoPathValue;
      this.txtUltimaClient.Text = this.CfgUoClientPathValue;
      this.txtClientWindow.Text = this.CfgUoClientWindowValue;
      this.trkZoom.Value = (int) this.CfgZoomLevelValue;
      this.txtCmdPrefix.Text = this.CfgRunUoCmdPrefix;
      this.txtSpawnName.Text = this.CfgSpawnNameValue;
      this.spnSpawnRange.Value = (Decimal) this.CfgSpawnHomeRangeValue;
      this.spnSpawnMaxCount.Value = (Decimal) this.CfgSpawnMaxCountValue;
      this.spnSpawnMinDelay.Value = (Decimal) this.CfgSpawnMinDelayValue;
      this.spnSpawnMaxDelay.Value = (Decimal) this.CfgSpawnMaxDelayValue;
      this.spnSpawnTeam.Value = (Decimal) this.CfgSpawnTeamValue;
      this.chkSpawnGroup.Checked = this.CfgSpawnGroupValue;
      this.chkSpawnRunning.Checked = this.CfgSpawnRunningValue;
      this.chkHomeRangeIsRelative.Checked = this.CfgSpawnRelativeHomeValue;
      this.startingStatics.Checked = this.CfgStartingStaticsValue;
      this.startingDetails.Checked = this.CfgStartingDetailsValue;
      this.startingMap.SelectedIndex = (int) this.CfgStartingMapValue;
      this.startingOnTop.Checked = this.CfgStartingOnTopValue;
    }

    private void SetClientWindowName()
    {
      switch (Path.GetFileName(this.txtUltimaClient.Text).ToLower())
      {
        case "uotd.exe":
          this.CfgUoClientWindowValue = "Ultima Online Third Dawn";
          break;
        case "client.exe":
          this.CfgUoClientWindowValue = "Ultima Online";
          break;
        default:
          this.CfgUoClientWindowValue = "???";
          break;
      }
      this.txtClientWindow.Text = this.CfgUoClientWindowValue;
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      this.CfgRunUoPathValue = this.txtRunUOExe.Text;
      this.CfgUoClientPathValue = this.txtUltimaClient.Text;
      this.CfgUoClientWindowValue = this.txtClientWindow.Text;
      this.CfgZoomLevelValue = (short) this.trkZoom.Value;
      this.CfgRunUoCmdPrefix = this.txtCmdPrefix.Text;
      this.CfgSpawnNameValue = this.txtSpawnName.Text;
      this.CfgSpawnHomeRangeValue = (int) this.spnSpawnRange.Value;
      this.CfgSpawnMaxCountValue = (int) this.spnSpawnMaxCount.Value;
      this.CfgSpawnMinDelayValue = (int) this.spnSpawnMinDelay.Value;
      this.CfgSpawnMaxDelayValue = (int) this.spnSpawnMaxDelay.Value;
      this.CfgSpawnTeamValue = (int) this.spnSpawnTeam.Value;
      this.CfgSpawnGroupValue = this.chkSpawnGroup.Checked;
      this.CfgSpawnRunningValue = this.chkSpawnRunning.Checked;
      this.CfgSpawnRelativeHomeValue = this.chkHomeRangeIsRelative.Checked;
      this.CfgStartingStaticsValue = this.startingStatics.Checked;
      this.CfgStartingDetailsValue = this.startingDetails.Checked;
      this.CfgStartingMapValue = (WorldMap) this.startingMap.SelectedIndex;
      this.CfgStartingOnTopValue = this.startingOnTop.Checked;
      if (this.CfgRunUoPathValue.Length == 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, "You must set the path to the RunUO EXE before proceeding!", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if (this.CfgUoClientPathValue.Length == 0)
      {
        int num2 = (int) MessageBox.Show((IWin32Window) this, "You must set the path to the Ultima Online client EXE before proceeding!", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        if (this._HKCUKey == null)
          this._HKCUKey = Registry.CurrentUser.CreateSubKey(this.AppRegistryKey);
        this._HKCUKey.SetValue(this.AppRunUoPathValue, (object) this.CfgRunUoPathValue);
        this._HKCUKey.SetValue(this.AppUoClientPathValue, (object) this.CfgUoClientPathValue);
        this._HKCUKey.SetValue(this.AppUoClientWindowValue, (object) this.CfgUoClientWindowValue);
        this._HKCUKey.SetValue(this.AppZoomLevelValue, (object) this.CfgZoomLevelValue.ToString());
        this._HKCUKey.SetValue(this.AppRunUoCmdPrefixValue, (object) this.CfgRunUoCmdPrefix);
        this._HKCUKey.SetValue(this.AppSpawnNameValue, (object) this.CfgSpawnNameValue);
        this._HKCUKey.SetValue(this.AppSpawnHomeRangeValue, (object) this.CfgSpawnHomeRangeValue);
        this._HKCUKey.SetValue(this.AppSpawnMaxCountValue, (object) this.CfgSpawnMaxCountValue);
        this._HKCUKey.SetValue(this.AppSpawnMinDelayValue, (object) this.CfgSpawnMinDelayValue);
        this._HKCUKey.SetValue(this.AppSpawnMaxDelayValue, (object) this.CfgSpawnMaxDelayValue);
        this._HKCUKey.SetValue(this.AppSpawnTeamValue, (object) this.CfgSpawnTeamValue);
        this._HKCUKey.SetValue(this.AppSpawnGroupValue, (object) (this.CfgSpawnGroupValue ? 1 : 0));
        this._HKCUKey.SetValue(this.AppSpawnRunningValue, (object)  (this.CfgSpawnRunningValue ? 1 : 0));
        this._HKCUKey.SetValue(this.AppSpawnRelativeHomeValue, (object)  (this.CfgSpawnRelativeHomeValue ? 1 : 0));
        this._HKCUKey.SetValue(this.AppStartingStaticsValue, (object)  (this.CfgStartingStaticsValue ? 1 : 0));
        this._HKCUKey.SetValue(this.AppStartingDetailsValue, (object)  (this.CfgStartingDetailsValue ? 1 : 0));
        this._HKCUKey.SetValue(this.AppStartingMapValue, (object) this.CfgStartingMapValue.ToString());
        this._HKCUKey.SetValue(this.AppStartingOnTopValue, (object)  (this.CfgStartingOnTopValue ? 1 : 0));
        this._IsValidConfiguration = true;
        this.Close();
      }
    }

    public void SaveWindowConfiguration()
    {
      if (this._HKCUKey == null || this._Editor == null)
        return;
      this._HKCUKey.SetValue(this.AppStartingXValue, (object) this._Editor.Location.X);
      this._HKCUKey.SetValue(this.AppStartingYValue, (object) this._Editor.Location.Y);
      this._HKCUKey.SetValue(this.AppStartingWidthValue, (object) this._Editor.Width);
      this._HKCUKey.SetValue(this.AppStartingHeightValue, (object) this._Editor.Height);
    }

    public void ConfigureTransferServer()
    {
      this._Editor._TransferDialog.txtTransferServerAddress.Text = this.CfgTransferServerAddressValue;
      this._Editor._TransferDialog.txtTransferServerPort.Text = this.CfgTransferServerPortValue.ToString();
    }

    public void SaveTransferServerConfiguration()
    {
      if (this._HKCUKey == null || this._Editor == null)
        return;
      this._HKCUKey.SetValue(this.AppTransferServerAddressValue, (object) this._Editor._TransferDialog.txtTransferServerAddress.Text);
      try
      {
        this._HKCUKey.SetValue(this.AppTransferServerPortValue, (object) int.Parse(this._Editor._TransferDialog.txtTransferServerPort.Text));
      }
      catch
      {
      }
    }
  }
}
