// Decompiled with JetBrains decompiler
// Type: SpawnEditor2.Amount
// Assembly: SpawnEditor2, Version=1.18.2133.41352, Culture=neutral, PublicKeyToken=null
// MVID: 02C34E83-756B-4927-A841-6F97602C50A7
// Assembly location: Y:\Spawn Editor2 v1.8\SpawnEditor2.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SpawnEditor2
{
  public class Amount : Form
  {
    private Container components = (Container) null;
    private Button btnOk;
    private Button btnCancel;
    private TextBox txtSpawnObject;
    private NumericUpDown spnSpawnAmount;

    public int SpawnAmount
    {
      get
      {
        return (int) this.spnSpawnAmount.Value;
      }
    }

    public string SpawnName
    {
      get
      {
        return this.txtSpawnObject.Text;
      }
    }

    public Amount(string Name, int Amount)
    {
      this.InitializeComponent();
      this.txtSpawnObject.Text = Name;
      this.spnSpawnAmount.Value = (Decimal) Amount;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.txtSpawnObject = new TextBox();
      this.spnSpawnAmount = new NumericUpDown();
      this.btnOk = new Button();
      this.btnCancel = new Button();
      this.spnSpawnAmount.BeginInit();
      this.SuspendLayout();
      this.txtSpawnObject.Location = new Point(3, 8);
      this.txtSpawnObject.Name = "txtSpawnObject";
      this.txtSpawnObject.ReadOnly = true;
      this.txtSpawnObject.Size = new Size(208, 20);
      this.txtSpawnObject.TabIndex = 0;
      this.txtSpawnObject.TabStop = false;
      this.txtSpawnObject.Text = "";
      this.spnSpawnAmount.Location = new Point(213, 8);
      this.spnSpawnAmount.Name = "spnSpawnAmount";
      this.spnSpawnAmount.Size = new Size(75, 20);
      this.spnSpawnAmount.TabIndex = 1;
      this.spnSpawnAmount.Enter += new EventHandler(this.spnSpawnAmount_Enter);
      this.btnOk.Location = new Point(136, 32);
      this.btnOk.Name = "btnOk";
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "&Ok";
      this.btnOk.Click += new EventHandler(this.btnOk_Click);
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(213, 32);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "&Cancel";
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(292, 61);
      this.Controls.AddRange(new Control[4]
      {
        (Control) this.btnCancel,
        (Control) this.btnOk,
        (Control) this.spnSpawnAmount,
        (Control) this.txtSpawnObject
      });
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "Amount";
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Set Amount";
      this.spnSpawnAmount.EndInit();
      this.ResumeLayout(false);
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void spnSpawnAmount_Enter(object sender, EventArgs e)
    {
      this.spnSpawnAmount.Select(0, int.MaxValue);
    }
  }
}
