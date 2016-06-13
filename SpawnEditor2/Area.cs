// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.Area
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SpawnEditor2
{
  public class Area : Form
  {
    private Container components = (Container) null;
    private SpawnEditor _Editor;
    private SpawnPoint _Spawn;
    private bool _IsConstructed;
    private NumericUpDown spnX;
    private NumericUpDown spnY;
    private NumericUpDown spnWidth;
    private NumericUpDown spnHeight;
    private Label lblY;
    private Label lblX;
    private Label lblWidth;
    private Label lblHeight;
    private Button btnCancel;
    private Label label1;
    private NumericUpDown spnCentreZ;
    private NumericUpDown spnCentreY;
    private NumericUpDown spnCentreX;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;

    public Area(SpawnPoint Spawn, SpawnEditor Editor)
    {
      this.InitializeComponent();
      this._Spawn = Spawn;
      this._Editor = Editor;
      int num1 = this._Editor.grpSpawnEdit.Left + this._Editor.grpSpawnEdit.Parent.Left + this._Editor.Left;
      int num2 = this._Editor.grpSpawnEdit.Top + this._Editor.grpSpawnEdit.Parent.Top + this._Editor.btnUpdateSpawn.Top + this._Editor.Top;
      this.Left = num1;
      this.Top = num2;
      this.spnX.Value = (Decimal) this._Spawn.Bounds.X;
      this.spnY.Value = (Decimal) this._Spawn.Bounds.Y;
      this.spnWidth.Value = (Decimal) this._Spawn.Bounds.Width;
      this.spnHeight.Value = (Decimal) this._Spawn.Bounds.Height;
      this.spnCentreX.Value = (Decimal) this._Spawn.CentreX;
      this.spnCentreY.Value = (Decimal) this._Spawn.CentreY;
      this.spnCentreZ.Value = (Decimal) this._Spawn.CentreZ;
      this._IsConstructed = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.spnX = new NumericUpDown();
      this.spnY = new NumericUpDown();
      this.spnWidth = new NumericUpDown();
      this.spnHeight = new NumericUpDown();
      this.lblY = new Label();
      this.lblX = new Label();
      this.lblWidth = new Label();
      this.lblHeight = new Label();
      this.btnCancel = new Button();
      this.spnCentreZ = new NumericUpDown();
      this.label1 = new Label();
      this.spnCentreY = new NumericUpDown();
      this.spnCentreX = new NumericUpDown();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.spnX.BeginInit();
      this.spnY.BeginInit();
      this.spnWidth.BeginInit();
      this.spnHeight.BeginInit();
      this.spnCentreZ.BeginInit();
      this.spnCentreY.BeginInit();
      this.spnCentreX.BeginInit();
      this.SuspendLayout();
      this.spnX.Location = new Point(8, 88);
      NumericUpDown numericUpDown1 = this.spnX;
      int[] bits1 = new int[4];
      bits1[0] = 10000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.spnX.Name = "spnX";
      this.spnX.Size = new Size(64, 20);
      this.spnX.TabIndex = 1;
      this.spnX.Enter += new EventHandler(this.TextEntryControl_Enter);
      this.spnX.ValueChanged += new EventHandler(this.SpinBox_ValueChanged);
      this.spnY.Location = new Point(48, 48);
      NumericUpDown numericUpDown2 = this.spnY;
      int[] bits2 = new int[4];
      bits2[0] = 10000;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Maximum = num2;
      this.spnY.Name = "spnY";
      this.spnY.Size = new Size(64, 20);
      this.spnY.TabIndex = 3;
      this.spnY.Enter += new EventHandler(this.TextEntryControl_Enter);
      this.spnY.ValueChanged += new EventHandler(this.SpinBox_ValueChanged);
      this.spnWidth.Location = new Point(88, 88);
      NumericUpDown numericUpDown3 = this.spnWidth;
      int[] bits3 = new int[4];
      bits3[0] = 10000;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Maximum = num3;
      this.spnWidth.Name = "spnWidth";
      this.spnWidth.Size = new Size(64, 20);
      this.spnWidth.TabIndex = 5;
      this.spnWidth.Enter += new EventHandler(this.TextEntryControl_Enter);
      this.spnWidth.ValueChanged += new EventHandler(this.SpinBox_ValueChanged);
      this.spnHeight.Location = new Point(48, 128);
      NumericUpDown numericUpDown4 = this.spnHeight;
      int[] bits4 = new int[4];
      bits4[0] = 10000;
      Decimal num4 = new Decimal(bits4);
      numericUpDown4.Maximum = num4;
      this.spnHeight.Name = "spnHeight";
      this.spnHeight.Size = new Size(64, 20);
      this.spnHeight.TabIndex = 7;
      this.spnHeight.Enter += new EventHandler(this.TextEntryControl_Enter);
      this.spnHeight.ValueChanged += new EventHandler(this.SpinBox_ValueChanged);
      this.lblY.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblY.Location = new Point(48, 32);
      this.lblY.Name = "lblY";
      this.lblY.Size = new Size(64, 16);
      this.lblY.TabIndex = 2;
      this.lblY.Text = "Y";
      this.lblY.TextAlign = ContentAlignment.TopCenter;
      this.lblX.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblX.Location = new Point(8, 72);
      this.lblX.Name = "lblX";
      this.lblX.Size = new Size(64, 16);
      this.lblX.TabIndex = 0;
      this.lblX.Text = "X";
      this.lblX.TextAlign = ContentAlignment.TopCenter;
      this.lblWidth.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblWidth.Location = new Point(88, 72);
      this.lblWidth.Name = "lblWidth";
      this.lblWidth.Size = new Size(64, 16);
      this.lblWidth.TabIndex = 4;
      this.lblWidth.Text = "Width";
      this.lblWidth.TextAlign = ContentAlignment.TopCenter;
      this.lblHeight.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblHeight.Location = new Point(48, 112);
      this.lblHeight.Name = "lblHeight";
      this.lblHeight.Size = new Size(64, 16);
      this.lblHeight.TabIndex = 6;
      this.lblHeight.Text = "Height";
      this.lblHeight.TextAlign = ContentAlignment.TopCenter;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(176, 128);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(8, 8);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.TabStop = false;
      this.btnCancel.Text = "Cancel";
      this.spnCentreZ.Location = new Point(48, 248);
      NumericUpDown numericUpDown5 = this.spnCentreZ;
      int[] bits5 = new int[4];
      bits5[0] = 65000;
      Decimal num5 = new Decimal(bits5);
      numericUpDown5.Maximum = num5;
      this.spnCentreZ.Minimum = new Decimal(new int[4]
      {
        32768,
        0,
        0,
        int.MinValue
      });
      this.spnCentreZ.Name = "spnCentreZ";
      this.spnCentreZ.Size = new Size(80, 20);
      this.spnCentreZ.TabIndex = 9;
      this.spnCentreZ.ValueChanged += new EventHandler(this.spnCentreZ_ValueChanged);
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(8, 248);
      this.label1.Name = "label1";
      this.label1.Size = new Size(32, 16);
      this.label1.TabIndex = 10;
      this.label1.Text = "Z";
      this.label1.TextAlign = ContentAlignment.TopCenter;
      this.spnCentreY.Location = new Point(48, 224);
      NumericUpDown numericUpDown6 = this.spnCentreY;
      int[] bits6 = new int[4];
      bits6[0] = 10000;
      Decimal num6 = new Decimal(bits6);
      numericUpDown6.Maximum = num6;
      this.spnCentreY.Name = "spnCentreY";
      this.spnCentreY.Size = new Size(80, 20);
      this.spnCentreY.TabIndex = 11;
      this.spnCentreY.Enter += new EventHandler(this.TextEntryControl_Enter);
      this.spnCentreY.ValueChanged += new EventHandler(this.spnCentreY_ValueChanged);
      this.spnCentreX.Location = new Point(48, 200);
      NumericUpDown numericUpDown7 = this.spnCentreX;
      int[] bits7 = new int[4];
      bits7[0] = 10000;
      Decimal num7 = new Decimal(bits7);
      numericUpDown7.Maximum = num7;
      this.spnCentreX.Name = "spnCentreX";
      this.spnCentreX.Size = new Size(80, 20);
      this.spnCentreX.TabIndex = 12;
      this.spnCentreX.Enter += new EventHandler(this.TextEntryControl_Enter);
      this.spnCentreX.ValueChanged += new EventHandler(this.spnCentreX_ValueChanged);
      this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(8, 224);
      this.label2.Name = "label2";
      this.label2.Size = new Size(32, 16);
      this.label2.TabIndex = 13;
      this.label2.Text = "Y";
      this.label2.TextAlign = ContentAlignment.TopCenter;
      this.label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(8, 200);
      this.label3.Name = "label3";
      this.label3.Size = new Size(32, 16);
      this.label3.TabIndex = 14;
      this.label3.Text = "X";
      this.label3.TextAlign = ContentAlignment.TopCenter;
      this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(24, 176);
      this.label4.Name = "label4";
      this.label4.Size = new Size(112, 16);
      this.label4.TabIndex = 15;
      this.label4.Text = "Spawner Location";
      this.label4.TextAlign = ContentAlignment.TopCenter;
      this.label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(24, 8);
      this.label5.Name = "label5";
      this.label5.Size = new Size(112, 16);
      this.label5.TabIndex = 16;
      this.label5.Text = "Spawner Bounds";
      this.label5.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(160, 280);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.spnCentreX);
      this.Controls.Add((Control) this.spnCentreY);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.spnCentreZ);
      this.Controls.Add((Control) this.lblHeight);
      this.Controls.Add((Control) this.lblWidth);
      this.Controls.Add((Control) this.lblX);
      this.Controls.Add((Control) this.lblY);
      this.Controls.Add((Control) this.spnHeight);
      this.Controls.Add((Control) this.spnWidth);
      this.Controls.Add((Control) this.spnY);
      this.Controls.Add((Control) this.spnX);
      this.Controls.Add((Control) this.btnCancel);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.KeyPreview = true;
      this.Name = "Area";
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "Location and Bounds";
      this.TransparencyKey = Color.Red;
      this.KeyDown += new KeyEventHandler(this.Area_KeyDown);
      this.Load += new EventHandler(this.Area_Load);
      this.spnX.EndInit();
      this.spnY.EndInit();
      this.spnWidth.EndInit();
      this.spnHeight.EndInit();
      this.spnCentreZ.EndInit();
      this.spnCentreY.EndInit();
      this.spnCentreX.EndInit();
      this.ResumeLayout(false);
    }

    private void TextEntryControl_Enter(object sender, EventArgs e)
    {
      if (sender is TextBox)
      {
        TextBox textBox = (TextBox) sender;
        textBox.Select(0, textBox.MaxLength);
      }
      else
      {
        if (!(sender is NumericUpDown))
          return;
        ((UpDownBase) sender).Select(0, int.MaxValue);
      }
    }

    private void SpinBox_ValueChanged(object sender, EventArgs e)
    {
      if (!this._IsConstructed)
        return;
      NumericUpDown numericUpDown = sender as NumericUpDown;
      if (numericUpDown == null)
        return;
      Rectangle bounds;
      if (numericUpDown == this.spnX)
      {
        SpawnPoint spawnPoint = this._Spawn;
        int x = (int) this.spnX.Value;
        int y = this._Spawn.Bounds.Y;
        bounds = this._Spawn.Bounds;
        int width = bounds.Width;
        bounds = this._Spawn.Bounds;
        int height = bounds.Height;
        Rectangle rectangle = new Rectangle(x, y, width, height);
        spawnPoint.Bounds = rectangle;
      }
      else if (numericUpDown == this.spnY)
      {
        SpawnPoint spawnPoint = this._Spawn;
        int x = this._Spawn.Bounds.X;
        int y = (int) this.spnY.Value;
        bounds = this._Spawn.Bounds;
        int width = bounds.Width;
        bounds = this._Spawn.Bounds;
        int height = bounds.Height;
        Rectangle rectangle = new Rectangle(x, y, width, height);
        spawnPoint.Bounds = rectangle;
      }
      else if (numericUpDown == this.spnWidth)
      {
        SpawnPoint spawnPoint = this._Spawn;
        int x = this._Spawn.Bounds.X;
        bounds = this._Spawn.Bounds;
        int y = bounds.Y;
        int width = (int) this.spnWidth.Value;
        bounds = this._Spawn.Bounds;
        int height = bounds.Height;
        Rectangle rectangle = new Rectangle(x, y, width, height);
        spawnPoint.Bounds = rectangle;
      }
      else if (numericUpDown == this.spnHeight)
      {
        SpawnPoint spawnPoint = this._Spawn;
        int x = this._Spawn.Bounds.X;
        bounds = this._Spawn.Bounds;
        int y = bounds.Y;
        bounds = this._Spawn.Bounds;
        int width = bounds.Width;
        int height = (int) this.spnHeight.Value;
        Rectangle rectangle = new Rectangle(x, y, width, height);
        spawnPoint.Bounds = rectangle;
      }
      if (!this._Editor.SpawnLocationLocked)
      {
        SpawnPoint spawnPoint1 = this._Spawn;
        bounds = this._Spawn.Bounds;
        int x = bounds.X;
        bounds = this._Spawn.Bounds;
        int num1 = bounds.Width / 2;
        int num2 = (int) (short) (x + num1);
        spawnPoint1.CentreX = (short) num2;
        SpawnPoint spawnPoint2 = this._Spawn;
        bounds = this._Spawn.Bounds;
        int y = bounds.Y;
        bounds = this._Spawn.Bounds;
        int num3 = bounds.Height / 2;
        int num4 = (int) (short) (y + num3);
        spawnPoint2.CentreY = (short) num4;
      }
      this._Editor.spnSpawnRange.Value = new Decimal(-1);
      this._Editor.RefreshSpawnPoints();
    }

    private void Area_KeyDown(object sender, KeyEventArgs e)
    {
      int num = 1;
      if (e.Shift)
        num = 5;
      if (e.KeyCode == Keys.Down)
      {
        if (e.Control)
          this.spnHeight.Value += (Decimal) num;
        else
          this.spnY.Value += (Decimal) num;
        e.Handled = true;
      }
      else if (e.KeyCode == Keys.Up)
      {
        if (e.Control)
          this.spnHeight.Value -= (Decimal) num;
        else
          this.spnY.Value -= (Decimal) num;
        e.Handled = true;
      }
      else if (e.KeyCode == Keys.Left)
      {
        if (e.Control)
          this.spnWidth.Value -= (Decimal) num;
        else
          this.spnX.Value -= (Decimal) num;
        e.Handled = true;
      }
      else
      {
        if (e.KeyCode != Keys.Right)
          return;
        if (e.Control)
          this.spnWidth.Value += (Decimal) num;
        else
          this.spnX.Value += (Decimal) num;
        e.Handled = true;
      }
    }

    private void Area_Load(object sender, EventArgs e)
    {
      if (!this._Editor.TopMost)
        return;
      this.TopMost = true;
    }

    private void spnCentreX_ValueChanged(object sender, EventArgs e)
    {
      if (!this._IsConstructed)
        return;
      this._Spawn.CentreX = (short) this.spnCentreX.Value;
      this._Editor.RefreshSpawnPoints();
    }

    private void spnCentreY_ValueChanged(object sender, EventArgs e)
    {
      if (!this._IsConstructed)
        return;
      this._Spawn.CentreY = (short) this.spnCentreY.Value;
      this._Editor.RefreshSpawnPoints();
    }

    private void spnCentreZ_ValueChanged(object sender, EventArgs e)
    {
      if (!this._IsConstructed)
        return;
      this._Spawn.CentreZ = (short) this.spnCentreZ.Value;
      this._Editor.RefreshSpawnPoints();
    }
  }
}
