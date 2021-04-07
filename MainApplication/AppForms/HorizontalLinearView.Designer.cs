using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
	partial class HorizontalLinearView
	{
		/// <summary>
		///Требуется переменная конструктора.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.hcbox1 = new ColorMan.ControlsLibrary.HColorBox();
            this.hcbox2 = new ColorMan.ControlsLibrary.HColorBox();
            this.hcbox3 = new ColorMan.ControlsLibrary.HColorBox();
            this.ctbar1 = new ColorMan.ControlsLibrary.CtrackBar();
            this.ctbar2 = new ColorMan.ControlsLibrary.CtrackBar();
            this.ctbar3 = new ColorMan.ControlsLibrary.CtrackBar();
            this.cnud1 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.cnud2 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.cnud3 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.ctbox1 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.ctbox2 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.ctbox3 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbRng1 = new System.Windows.Forms.Label();
            this.lbRng2 = new System.Windows.Forms.Label();
            this.lbRng3 = new System.Windows.Forms.Label();
            this.light1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light3 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN3 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightT1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightT2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightT3 = new ColorMan.ControlsLibrary.LightingLabel();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.SuspendLayout();
            // 
            // hcbox1
            // 
            this.hcbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hcbox1.BackColor = System.Drawing.Color.Gray;
            this.hcbox1.BrightnessUnderTheCursorFunc = null;
            this.hcbox1.BrushFunc = null;
            this.hcbox1.CenterColor = System.Drawing.Color.Empty;
            this.hcbox1.ColorCount = 2;
            this.hcbox1.Increment = 0.01F;
            this.hcbox1.IsRightDowned = false;
            this.hcbox1.Location = new System.Drawing.Point(88, 9);
            this.hcbox1.Margin = new System.Windows.Forms.Padding(0);
            this.hcbox1.MaximumSize = new System.Drawing.Size(2000, 20);
            this.hcbox1.MinimumSize = new System.Drawing.Size(77, 20);
            this.hcbox1.Name = "hcbox1";
            this.hcbox1.SelectedColorFunc = null;
            this.hcbox1.Size = new System.Drawing.Size(273, 20);
            this.hcbox1.TabIndex = 42;
            this.hcbox1.TabStop = false;
            this.hcbox1.Val = 0F;
            this.hcbox1.ValueChanged += new System.EventHandler(this.Hcbox1ValueChanged);
            this.hcbox1.LastValue += new System.EventHandler(this.item_LastValue);
            this.hcbox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hcbox_MouseDown);
            // 
            // hcbox2
            // 
            this.hcbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hcbox2.BackColor = System.Drawing.Color.Gray;
            this.hcbox2.BrightnessUnderTheCursorFunc = null;
            this.hcbox2.BrushFunc = null;
            this.hcbox2.CenterColor = System.Drawing.Color.Empty;
            this.hcbox2.ColorCount = 2;
            this.hcbox2.Increment = 0.01F;
            this.hcbox2.IsRightDowned = false;
            this.hcbox2.Location = new System.Drawing.Point(88, 57);
            this.hcbox2.Margin = new System.Windows.Forms.Padding(0);
            this.hcbox2.MaximumSize = new System.Drawing.Size(2000, 20);
            this.hcbox2.MinimumSize = new System.Drawing.Size(77, 20);
            this.hcbox2.Name = "hcbox2";
            this.hcbox2.SelectedColorFunc = null;
            this.hcbox2.Size = new System.Drawing.Size(273, 20);
            this.hcbox2.TabIndex = 43;
            this.hcbox2.TabStop = false;
            this.hcbox2.Val = 0F;
            this.hcbox2.ValueChanged += new System.EventHandler(this.Hcbox2ValueChanged);
            this.hcbox2.LastValue += new System.EventHandler(this.item_LastValue);
            this.hcbox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hcbox_MouseDown);
            // 
            // hcbox3
            // 
            this.hcbox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hcbox3.BackColor = System.Drawing.Color.Gray;
            this.hcbox3.BrightnessUnderTheCursorFunc = null;
            this.hcbox3.BrushFunc = null;
            this.hcbox3.CenterColor = System.Drawing.Color.Empty;
            this.hcbox3.ColorCount = 2;
            this.hcbox3.Increment = 0.01F;
            this.hcbox3.IsRightDowned = false;
            this.hcbox3.Location = new System.Drawing.Point(88, 105);
            this.hcbox3.Margin = new System.Windows.Forms.Padding(0);
            this.hcbox3.MaximumSize = new System.Drawing.Size(2000, 20);
            this.hcbox3.MinimumSize = new System.Drawing.Size(77, 20);
            this.hcbox3.Name = "hcbox3";
            this.hcbox3.SelectedColorFunc = null;
            this.hcbox3.Size = new System.Drawing.Size(273, 20);
            this.hcbox3.TabIndex = 44;
            this.hcbox3.TabStop = false;
            this.hcbox3.Val = 0F;
            this.hcbox3.ValueChanged += new System.EventHandler(this.Hcbox3ValueChanged);
            this.hcbox3.LastValue += new System.EventHandler(this.item_LastValue);
            this.hcbox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hcbox_MouseDown);
            // 
            // ctbar1
            // 
            this.ctbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar1.AutoSize = false;
            this.ctbar1.Location = new System.Drawing.Point(75, 20);
            this.ctbar1.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar1.Maximum = 255;
            this.ctbar1.MaximumSize = new System.Drawing.Size(2000, 30);
            this.ctbar1.MinimumSize = new System.Drawing.Size(105, 30);
            this.ctbar1.Name = "ctbar1";
            this.ctbar1.Size = new System.Drawing.Size(299, 30);
            this.ctbar1.TabIndex = 45;
            this.ctbar1.TickFrequency = 255;
            this.ctbar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar1.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar1.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar1.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbar2
            // 
            this.ctbar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar2.AutoSize = false;
            this.ctbar2.Location = new System.Drawing.Point(75, 68);
            this.ctbar2.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar2.Maximum = 255;
            this.ctbar2.MaximumSize = new System.Drawing.Size(2000, 30);
            this.ctbar2.MinimumSize = new System.Drawing.Size(105, 30);
            this.ctbar2.Name = "ctbar2";
            this.ctbar2.Size = new System.Drawing.Size(299, 30);
            this.ctbar2.TabIndex = 46;
            this.ctbar2.TickFrequency = 255;
            this.ctbar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar2.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar2.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar2.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbar3
            // 
            this.ctbar3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar3.AutoSize = false;
            this.ctbar3.Location = new System.Drawing.Point(75, 116);
            this.ctbar3.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar3.Maximum = 255;
            this.ctbar3.MaximumSize = new System.Drawing.Size(2000, 30);
            this.ctbar3.MinimumSize = new System.Drawing.Size(105, 30);
            this.ctbar3.Name = "ctbar3";
            this.ctbar3.Size = new System.Drawing.Size(299, 30);
            this.ctbar3.TabIndex = 47;
            this.ctbar3.TickFrequency = 255;
            this.ctbar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar3.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // cnud1
            // 
            this.cnud1.AccelerationIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud1.AccelerationSeconds = 1;
            this.cnud1.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnud1.ActiveForeColor = System.Drawing.Color.White;
            this.cnud1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnud1.BackColor = System.Drawing.Color.DarkGray;
            this.cnud1.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.cnud1.DeactiveForeColor = System.Drawing.Color.Black;
            this.cnud1.DecimalPlaces = 1;
            this.cnud1.Divider = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud1.ForeColor = System.Drawing.Color.Black;
            this.cnud1.Location = new System.Drawing.Point(379, 18);
            this.cnud1.Margin = new System.Windows.Forms.Padding(0);
            this.cnud1.Name = "cnud1";
            this.cnud1.Size = new System.Drawing.Size(52, 20);
            this.cnud1.TabIndex = 48;
            this.cnud1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud1.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud1.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud1.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // cnud2
            // 
            this.cnud2.AccelerationIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud2.AccelerationSeconds = 1;
            this.cnud2.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnud2.ActiveForeColor = System.Drawing.Color.White;
            this.cnud2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnud2.BackColor = System.Drawing.Color.DarkGray;
            this.cnud2.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.cnud2.DeactiveForeColor = System.Drawing.Color.Black;
            this.cnud2.DecimalPlaces = 1;
            this.cnud2.Divider = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud2.ForeColor = System.Drawing.Color.Black;
            this.cnud2.Location = new System.Drawing.Point(379, 66);
            this.cnud2.Margin = new System.Windows.Forms.Padding(0);
            this.cnud2.Name = "cnud2";
            this.cnud2.Size = new System.Drawing.Size(52, 20);
            this.cnud2.TabIndex = 49;
            this.cnud2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud2.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud2.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud2.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // cnud3
            // 
            this.cnud3.AccelerationIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud3.AccelerationSeconds = 1;
            this.cnud3.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnud3.ActiveForeColor = System.Drawing.Color.White;
            this.cnud3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnud3.BackColor = System.Drawing.Color.DarkGray;
            this.cnud3.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.cnud3.DeactiveForeColor = System.Drawing.Color.Black;
            this.cnud3.DecimalPlaces = 1;
            this.cnud3.Divider = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud3.ForeColor = System.Drawing.Color.Black;
            this.cnud3.Location = new System.Drawing.Point(379, 114);
            this.cnud3.Margin = new System.Windows.Forms.Padding(0);
            this.cnud3.Name = "cnud3";
            this.cnud3.Size = new System.Drawing.Size(52, 20);
            this.cnud3.TabIndex = 50;
            this.cnud3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud3.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbox1
            // 
            this.ctbox1.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctbox1.ActiveForeColor = System.Drawing.Color.White;
            this.ctbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbox1.BackColor = System.Drawing.Color.DarkGray;
            this.ctbox1.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctbox1.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctbox1.DecimalPlaces = 1;
            this.ctbox1.ForeColor = System.Drawing.Color.Black;
            this.ctbox1.Location = new System.Drawing.Point(436, 18);
            this.ctbox1.Margin = new System.Windows.Forms.Padding(0);
            this.ctbox1.Maximum = 100F;
            this.ctbox1.Minimum = 0F;
            this.ctbox1.Name = "ctbox1";
            this.ctbox1.Size = new System.Drawing.Size(44, 20);
            this.ctbox1.TabIndex = 51;
            this.ctbox1.Text = "0";
            this.ctbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctbox1.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbox1.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbox1.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbox2
            // 
            this.ctbox2.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctbox2.ActiveForeColor = System.Drawing.Color.White;
            this.ctbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbox2.BackColor = System.Drawing.Color.DarkGray;
            this.ctbox2.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctbox2.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctbox2.DecimalPlaces = 1;
            this.ctbox2.ForeColor = System.Drawing.Color.Black;
            this.ctbox2.Location = new System.Drawing.Point(436, 66);
            this.ctbox2.Margin = new System.Windows.Forms.Padding(0);
            this.ctbox2.Maximum = 100F;
            this.ctbox2.Minimum = 0F;
            this.ctbox2.Name = "ctbox2";
            this.ctbox2.Size = new System.Drawing.Size(44, 20);
            this.ctbox2.TabIndex = 52;
            this.ctbox2.Text = "0";
            this.ctbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctbox2.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbox2.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbox2.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbox3
            // 
            this.ctbox3.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctbox3.ActiveForeColor = System.Drawing.Color.White;
            this.ctbox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbox3.BackColor = System.Drawing.Color.DarkGray;
            this.ctbox3.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctbox3.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctbox3.DecimalPlaces = 1;
            this.ctbox3.ForeColor = System.Drawing.Color.Black;
            this.ctbox3.Location = new System.Drawing.Point(436, 114);
            this.ctbox3.Margin = new System.Windows.Forms.Padding(0);
            this.ctbox3.Maximum = 100F;
            this.ctbox3.Minimum = 0F;
            this.ctbox3.Name = "ctbox3";
            this.ctbox3.Size = new System.Drawing.Size(44, 20);
            this.ctbox3.TabIndex = 53;
            this.ctbox3.Text = "0";
            this.ctbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctbox3.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbox3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbox3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.ForeColor = System.Drawing.Color.Silver;
            this.lb1.Location = new System.Drawing.Point(66, 19);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(16, 13);
            this.lb1.TabIndex = 54;
            this.lb1.Text = "R";
            // 
            // lb2
            // 
            this.lb2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.ForeColor = System.Drawing.Color.Silver;
            this.lb2.Location = new System.Drawing.Point(66, 65);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(16, 13);
            this.lb2.TabIndex = 55;
            this.lb2.Text = "G";
            // 
            // lb3
            // 
            this.lb3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.ForeColor = System.Drawing.Color.Silver;
            this.lb3.Location = new System.Drawing.Point(67, 113);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(15, 13);
            this.lb3.TabIndex = 56;
            this.lb3.Text = "B";
            // 
            // lbRng1
            // 
            this.lbRng1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRng1.AutoSize = true;
            this.lbRng1.Font = new System.Drawing.Font("Comic Sans MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRng1.ForeColor = System.Drawing.Color.Silver;
            this.lbRng1.Location = new System.Drawing.Point(438, 3);
            this.lbRng1.Margin = new System.Windows.Forms.Padding(0);
            this.lbRng1.Name = "lbRng1";
            this.lbRng1.Size = new System.Drawing.Size(34, 13);
            this.lbRng1.TabIndex = 57;
            this.lbRng1.Text = "0-100";
            this.lbRng1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRng2
            // 
            this.lbRng2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRng2.AutoSize = true;
            this.lbRng2.Font = new System.Drawing.Font("Comic Sans MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRng2.ForeColor = System.Drawing.Color.Silver;
            this.lbRng2.Location = new System.Drawing.Point(438, 51);
            this.lbRng2.Margin = new System.Windows.Forms.Padding(0);
            this.lbRng2.Name = "lbRng2";
            this.lbRng2.Size = new System.Drawing.Size(34, 13);
            this.lbRng2.TabIndex = 58;
            this.lbRng2.Text = "0-100";
            this.lbRng2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRng3
            // 
            this.lbRng3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRng3.AutoSize = true;
            this.lbRng3.Font = new System.Drawing.Font("Comic Sans MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRng3.ForeColor = System.Drawing.Color.Silver;
            this.lbRng3.Location = new System.Drawing.Point(438, 99);
            this.lbRng3.Margin = new System.Windows.Forms.Padding(0);
            this.lbRng3.Name = "lbRng3";
            this.lbRng3.Size = new System.Drawing.Size(34, 13);
            this.lbRng3.TabIndex = 59;
            this.lbRng3.Text = "0-100";
            this.lbRng3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // light1
            // 
            this.light1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.light1.Form = this;
            this.light1.LightingColor = System.Drawing.Color.Gold;
            this.light1.Location = new System.Drawing.Point(73, 4);
            this.light1.Name = "light1";
            this.light1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light1.Padding = new System.Windows.Forms.Padding(2);
            this.light1.Size = new System.Drawing.Size(303, 48);
            this.light1.TabIndex = 60;
            // 
            // light2
            // 
            this.light2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.light2.Form = this;
            this.light2.LightingColor = System.Drawing.Color.Gold;
            this.light2.Location = new System.Drawing.Point(73, 52);
            this.light2.Name = "light2";
            this.light2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light2.Padding = new System.Windows.Forms.Padding(2);
            this.light2.Size = new System.Drawing.Size(303, 48);
            this.light2.TabIndex = 61;
            // 
            // light3
            // 
            this.light3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.light3.Form = this;
            this.light3.LightingColor = System.Drawing.Color.Gold;
            this.light3.Location = new System.Drawing.Point(73, 100);
            this.light3.Name = "light3";
            this.light3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light3.Padding = new System.Windows.Forms.Padding(2);
            this.light3.Size = new System.Drawing.Size(303, 49);
            this.light3.TabIndex = 62;
            // 
            // lightN1
            // 
            this.lightN1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN1.Form = this;
            this.lightN1.LightingColor = System.Drawing.Color.Gold;
            this.lightN1.Location = new System.Drawing.Point(377, 16);
            this.lightN1.Name = "lightN1";
            this.lightN1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN1.Padding = new System.Windows.Forms.Padding(2);
            this.lightN1.Size = new System.Drawing.Size(56, 24);
            this.lightN1.TabIndex = 63;
            // 
            // lightN2
            // 
            this.lightN2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN2.Form = this;
            this.lightN2.LightingColor = System.Drawing.Color.Gold;
            this.lightN2.Location = new System.Drawing.Point(377, 64);
            this.lightN2.Name = "lightN2";
            this.lightN2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN2.Padding = new System.Windows.Forms.Padding(2);
            this.lightN2.Size = new System.Drawing.Size(56, 24);
            this.lightN2.TabIndex = 64;
            // 
            // lightN3
            // 
            this.lightN3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN3.Form = this;
            this.lightN3.LightingColor = System.Drawing.Color.Gold;
            this.lightN3.Location = new System.Drawing.Point(377, 112);
            this.lightN3.Name = "lightN3";
            this.lightN3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN3.Padding = new System.Windows.Forms.Padding(2);
            this.lightN3.Size = new System.Drawing.Size(56, 24);
            this.lightN3.TabIndex = 65;
            // 
            // lightT1
            // 
            this.lightT1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightT1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightT1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT1.Form = this;
            this.lightT1.LightingColor = System.Drawing.Color.Gold;
            this.lightT1.Location = new System.Drawing.Point(434, 16);
            this.lightT1.Name = "lightT1";
            this.lightT1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT1.Padding = new System.Windows.Forms.Padding(2);
            this.lightT1.Size = new System.Drawing.Size(48, 24);
            this.lightT1.TabIndex = 66;
            // 
            // lightT2
            // 
            this.lightT2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightT2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightT2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT2.Form = this;
            this.lightT2.LightingColor = System.Drawing.Color.Gold;
            this.lightT2.Location = new System.Drawing.Point(434, 64);
            this.lightT2.Name = "lightT2";
            this.lightT2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT2.Padding = new System.Windows.Forms.Padding(2);
            this.lightT2.Size = new System.Drawing.Size(48, 24);
            this.lightT2.TabIndex = 67;
            // 
            // lightT3
            // 
            this.lightT3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightT3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightT3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT3.Form = this;
            this.lightT3.LightingColor = System.Drawing.Color.Gold;
            this.lightT3.Location = new System.Drawing.Point(434, 112);
            this.lightT3.Name = "lightT3";
            this.lightT3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT3.Padding = new System.Windows.Forms.Padding(2);
            this.lightT3.Size = new System.Drawing.Size(48, 24);
            this.lightT3.TabIndex = 68;
            // 
            // HorizontalLinearView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 153);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.ctbox3);
            this.Controls.Add(this.ctbox2);
            this.Controls.Add(this.ctbox1);
            this.Controls.Add(this.cnud3);
            this.Controls.Add(this.cnud2);
            this.Controls.Add(this.cnud1);
            this.Controls.Add(this.hcbox3);
            this.Controls.Add(this.hcbox2);
            this.Controls.Add(this.hcbox1);
            this.Controls.Add(this.ctbar3);
            this.Controls.Add(this.ctbar2);
            this.Controls.Add(this.ctbar1);
            this.Controls.Add(this.lbRng3);
            this.Controls.Add(this.lbRng2);
            this.Controls.Add(this.lbRng1);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.light2);
            this.Controls.Add(this.light3);
            this.Controls.Add(this.lightN1);
            this.Controls.Add(this.lightN3);
            this.Controls.Add(this.lightN2);
            this.Controls.Add(this.lightT1);
            this.Controls.Add(this.lightT3);
            this.Controls.Add(this.lightT2);
            this.MaximumSize = new System.Drawing.Size(2000, 192);
            this.MinimumSize = new System.Drawing.Size(330, 192);
            this.Name = "HorizontalLinearView";
            this.Text = "HorizontalLinearView";
            this.Controls.SetChildIndex(this.lightT2, 0);
            this.Controls.SetChildIndex(this.lightT3, 0);
            this.Controls.SetChildIndex(this.lightT1, 0);
            this.Controls.SetChildIndex(this.lightN2, 0);
            this.Controls.SetChildIndex(this.lightN3, 0);
            this.Controls.SetChildIndex(this.lightN1, 0);
            this.Controls.SetChildIndex(this.light3, 0);
            this.Controls.SetChildIndex(this.light2, 0);
            this.Controls.SetChildIndex(this.light1, 0);
            this.Controls.SetChildIndex(this.lbRng1, 0);
            this.Controls.SetChildIndex(this.lbRng2, 0);
            this.Controls.SetChildIndex(this.lbRng3, 0);
            this.Controls.SetChildIndex(this.colorLabel2, 0);
            this.Controls.SetChildIndex(this.colorLabel1, 0);
            this.Controls.SetChildIndex(this.ctbar1, 0);
            this.Controls.SetChildIndex(this.ctbar2, 0);
            this.Controls.SetChildIndex(this.ctbar3, 0);
            this.Controls.SetChildIndex(this.hcbox1, 0);
            this.Controls.SetChildIndex(this.hcbox2, 0);
            this.Controls.SetChildIndex(this.hcbox3, 0);
            this.Controls.SetChildIndex(this.cnud1, 0);
            this.Controls.SetChildIndex(this.cnud2, 0);
            this.Controls.SetChildIndex(this.cnud3, 0);
            this.Controls.SetChildIndex(this.ctbox1, 0);
            this.Controls.SetChildIndex(this.ctbox2, 0);
            this.Controls.SetChildIndex(this.ctbox3, 0);
            this.Controls.SetChildIndex(this.lb1, 0);
            this.Controls.SetChildIndex(this.lb2, 0);
            this.Controls.SetChildIndex(this.lb3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.hcbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		protected HColorBox hcbox1;
		protected HColorBox hcbox2;
		protected HColorBox hcbox3;
		protected CtrackBar ctbar1;
		protected CtrackBar ctbar2;
		protected CtrackBar ctbar3;
		protected CnumericUpDown cnud1;
		protected CnumericUpDown cnud2;
		protected CnumericUpDown cnud3;
		protected NumberTextBox ctbox1;
		protected NumberTextBox ctbox2;
		protected NumberTextBox ctbox3;
		protected Label lbRng1;
		protected Label lbRng2;
		protected Label lbRng3;
		protected Label lb1;
		protected Label lb2;
		protected Label lb3;
        private LightingLabel light1;
        private LightingLabel light2;
        private LightingLabel light3;
        private LightingLabel lightN1;
        private LightingLabel lightN2;
        private LightingLabel lightN3;
        private LightingLabel lightT1;
        private LightingLabel lightT2;
        private LightingLabel lightT3;
	}
}
