using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
	partial class CmykHorizontalView
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
            this.hcbox4 = new ColorMan.ControlsLibrary.HColorBox();
            this.hcbox3 = new ColorMan.ControlsLibrary.HColorBox();
            this.hcbox2 = new ColorMan.ControlsLibrary.HColorBox();
            this.hcbox1 = new ColorMan.ControlsLibrary.HColorBox();
            this.ctbar1 = new ColorMan.ControlsLibrary.CtrackBar();
            this.ctbar2 = new ColorMan.ControlsLibrary.CtrackBar();
            this.ctbar3 = new ColorMan.ControlsLibrary.CtrackBar();
            this.ctbar4 = new ColorMan.ControlsLibrary.CtrackBar();
            this.cnud1 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.cnud2 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.cnud3 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.cnud4 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.light1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light3 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light4 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN3 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN4 = new ColorMan.ControlsLibrary.LightingLabel();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud4)).BeginInit();
            this.SuspendLayout();
            // 
            // colorLabel1
            // 
            this.colorLabel1.Location = new System.Drawing.Point(7, 66);
            // 
            // colorLabel2
            // 
            this.colorLabel2.Location = new System.Drawing.Point(28, 87);
            // 
            // hcbox4
            // 
            this.hcbox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hcbox4.BackColor = System.Drawing.Color.Gray;
            this.hcbox4.BrightnessUnderTheCursorFunc = null;
            this.hcbox4.BrushFunc = null;
            this.hcbox4.CenterColor = System.Drawing.Color.Empty;
            this.hcbox4.ColorCount = 2;
            this.hcbox4.Increment = 0.01F;
            this.hcbox4.IsRightDowned = false;
            this.hcbox4.Location = new System.Drawing.Point(88, 154);
            this.hcbox4.Margin = new System.Windows.Forms.Padding(0);
            this.hcbox4.MinimumSize = new System.Drawing.Size(77, 20);
            this.hcbox4.Name = "hcbox4";
            this.hcbox4.SelectedColorFunc = null;
            this.hcbox4.Size = new System.Drawing.Size(277, 20);
            this.hcbox4.TabIndex = 45;
            this.hcbox4.TabStop = false;
            this.hcbox4.Val = 0F;
            this.hcbox4.ValueChanged += new System.EventHandler(this.Hcbox4ValueChanged);
            this.hcbox4.LastValue += new System.EventHandler(this.item_LastValue);
            this.hcbox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hcbox_MouseDown);
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
            this.hcbox3.Location = new System.Drawing.Point(88, 106);
            this.hcbox3.Margin = new System.Windows.Forms.Padding(0);
            this.hcbox3.MinimumSize = new System.Drawing.Size(77, 20);
            this.hcbox3.Name = "hcbox3";
            this.hcbox3.SelectedColorFunc = null;
            this.hcbox3.Size = new System.Drawing.Size(277, 20);
            this.hcbox3.TabIndex = 44;
            this.hcbox3.TabStop = false;
            this.hcbox3.Val = 0F;
            this.hcbox3.ValueChanged += new System.EventHandler(this.Hcbox3ValueChanged);
            this.hcbox3.LastValue += new System.EventHandler(this.item_LastValue);
            this.hcbox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hcbox_MouseDown);
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
            this.hcbox2.Location = new System.Drawing.Point(88, 58);
            this.hcbox2.Margin = new System.Windows.Forms.Padding(0);
            this.hcbox2.MinimumSize = new System.Drawing.Size(77, 20);
            this.hcbox2.Name = "hcbox2";
            this.hcbox2.SelectedColorFunc = null;
            this.hcbox2.Size = new System.Drawing.Size(277, 20);
            this.hcbox2.TabIndex = 43;
            this.hcbox2.TabStop = false;
            this.hcbox2.Val = 0F;
            this.hcbox2.ValueChanged += new System.EventHandler(this.Hcbox2ValueChanged);
            this.hcbox2.LastValue += new System.EventHandler(this.item_LastValue);
            this.hcbox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hcbox_MouseDown);
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
            this.hcbox1.Location = new System.Drawing.Point(88, 10);
            this.hcbox1.Margin = new System.Windows.Forms.Padding(0);
            this.hcbox1.MinimumSize = new System.Drawing.Size(77, 20);
            this.hcbox1.Name = "hcbox1";
            this.hcbox1.SelectedColorFunc = null;
            this.hcbox1.Size = new System.Drawing.Size(277, 20);
            this.hcbox1.TabIndex = 42;
            this.hcbox1.TabStop = false;
            this.hcbox1.Val = 0F;
            this.hcbox1.ValueChanged += new System.EventHandler(this.Hcbox1ValueChanged);
            this.hcbox1.LastValue += new System.EventHandler(this.item_LastValue);
            this.hcbox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hcbox_MouseDown);
            // 
            // ctbar1
            // 
            this.ctbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar1.AutoSize = false;
            this.ctbar1.LargeChange = 10;
            this.ctbar1.Location = new System.Drawing.Point(75, 21);
            this.ctbar1.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar1.Maximum = 100;
            this.ctbar1.MinimumSize = new System.Drawing.Size(90, 30);
            this.ctbar1.Name = "ctbar1";
            this.ctbar1.Size = new System.Drawing.Size(303, 30);
            this.ctbar1.TabIndex = 46;
            this.ctbar1.TickFrequency = 100;
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
            this.ctbar2.LargeChange = 10;
            this.ctbar2.Location = new System.Drawing.Point(75, 69);
            this.ctbar2.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar2.Maximum = 100;
            this.ctbar2.MinimumSize = new System.Drawing.Size(90, 30);
            this.ctbar2.Name = "ctbar2";
            this.ctbar2.Size = new System.Drawing.Size(303, 30);
            this.ctbar2.TabIndex = 47;
            this.ctbar2.TickFrequency = 100;
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
            this.ctbar3.LargeChange = 10;
            this.ctbar3.Location = new System.Drawing.Point(75, 117);
            this.ctbar3.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar3.Maximum = 100;
            this.ctbar3.MinimumSize = new System.Drawing.Size(90, 30);
            this.ctbar3.Name = "ctbar3";
            this.ctbar3.Size = new System.Drawing.Size(303, 30);
            this.ctbar3.TabIndex = 48;
            this.ctbar3.TickFrequency = 100;
            this.ctbar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar3.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbar4
            // 
            this.ctbar4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar4.AutoSize = false;
            this.ctbar4.LargeChange = 10;
            this.ctbar4.Location = new System.Drawing.Point(75, 165);
            this.ctbar4.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar4.Maximum = 100;
            this.ctbar4.MinimumSize = new System.Drawing.Size(90, 30);
            this.ctbar4.Name = "ctbar4";
            this.ctbar4.Size = new System.Drawing.Size(303, 30);
            this.ctbar4.TabIndex = 49;
            this.ctbar4.TickFrequency = 100;
            this.ctbar4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar4.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar4.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar4.Leave += new System.EventHandler(this.ctrl_Leave);
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
            75,
            0,
            0,
            65536});
            this.cnud1.ForeColor = System.Drawing.Color.Black;
            this.cnud1.Location = new System.Drawing.Point(385, 19);
            this.cnud1.Margin = new System.Windows.Forms.Padding(0);
            this.cnud1.Name = "cnud1";
            this.cnud1.Size = new System.Drawing.Size(52, 20);
            this.cnud1.TabIndex = 50;
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
            75,
            0,
            0,
            65536});
            this.cnud2.ForeColor = System.Drawing.Color.Black;
            this.cnud2.Location = new System.Drawing.Point(385, 67);
            this.cnud2.Margin = new System.Windows.Forms.Padding(0);
            this.cnud2.Name = "cnud2";
            this.cnud2.Size = new System.Drawing.Size(52, 20);
            this.cnud2.TabIndex = 51;
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
            75,
            0,
            0,
            65536});
            this.cnud3.ForeColor = System.Drawing.Color.Black;
            this.cnud3.Location = new System.Drawing.Point(385, 115);
            this.cnud3.Margin = new System.Windows.Forms.Padding(0);
            this.cnud3.Name = "cnud3";
            this.cnud3.Size = new System.Drawing.Size(52, 20);
            this.cnud3.TabIndex = 52;
            this.cnud3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud3.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // cnud4
            // 
            this.cnud4.AccelerationIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud4.AccelerationSeconds = 1;
            this.cnud4.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnud4.ActiveForeColor = System.Drawing.Color.White;
            this.cnud4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnud4.BackColor = System.Drawing.Color.DarkGray;
            this.cnud4.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.cnud4.DeactiveForeColor = System.Drawing.Color.Black;
            this.cnud4.DecimalPlaces = 1;
            this.cnud4.Divider = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.cnud4.ForeColor = System.Drawing.Color.Black;
            this.cnud4.Location = new System.Drawing.Point(385, 163);
            this.cnud4.Margin = new System.Windows.Forms.Padding(0);
            this.cnud4.Name = "cnud4";
            this.cnud4.Size = new System.Drawing.Size(52, 20);
            this.cnud4.TabIndex = 53;
            this.cnud4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud4.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud4.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud4.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(66, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(66, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "K";
            // 
            // light1
            // 
            this.light1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light1.Form = this;
            this.light1.LightingColor = System.Drawing.Color.Gold;
            this.light1.Location = new System.Drawing.Point(73, 5);
            this.light1.Name = "light1";
            this.light1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light1.Padding = new System.Windows.Forms.Padding(2);
            this.light1.Size = new System.Drawing.Size(307, 48);
            this.light1.TabIndex = 58;
            // 
            // light2
            // 
            this.light2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light2.Form = this;
            this.light2.LightingColor = System.Drawing.Color.Gold;
            this.light2.Location = new System.Drawing.Point(73, 53);
            this.light2.Name = "light2";
            this.light2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light2.Padding = new System.Windows.Forms.Padding(2);
            this.light2.Size = new System.Drawing.Size(307, 48);
            this.light2.TabIndex = 59;
            // 
            // light3
            // 
            this.light3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light3.Form = this;
            this.light3.LightingColor = System.Drawing.Color.Gold;
            this.light3.Location = new System.Drawing.Point(73, 101);
            this.light3.Name = "light3";
            this.light3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light3.Padding = new System.Windows.Forms.Padding(2);
            this.light3.Size = new System.Drawing.Size(307, 48);
            this.light3.TabIndex = 60;
            // 
            // light4
            // 
            this.light4.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light4.Form = this;
            this.light4.LightingColor = System.Drawing.Color.Gold;
            this.light4.Location = new System.Drawing.Point(73, 149);
            this.light4.Name = "light4";
            this.light4.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light4.Padding = new System.Windows.Forms.Padding(2);
            this.light4.Size = new System.Drawing.Size(307, 48);
            this.light4.TabIndex = 61;
            // 
            // lightN1
            // 
            this.lightN1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN1.Form = this;
            this.lightN1.LightingColor = System.Drawing.Color.Gold;
            this.lightN1.Location = new System.Drawing.Point(382, 17);
            this.lightN1.Name = "lightN1";
            this.lightN1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN1.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN1.Size = new System.Drawing.Size(57, 24);
            this.lightN1.TabIndex = 62;
            // 
            // lightN2
            // 
            this.lightN2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN2.Form = this;
            this.lightN2.LightingColor = System.Drawing.Color.Gold;
            this.lightN2.Location = new System.Drawing.Point(382, 65);
            this.lightN2.Name = "lightN2";
            this.lightN2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN2.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN2.Size = new System.Drawing.Size(57, 24);
            this.lightN2.TabIndex = 63;
            // 
            // lightN3
            // 
            this.lightN3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN3.Form = this;
            this.lightN3.LightingColor = System.Drawing.Color.Gold;
            this.lightN3.Location = new System.Drawing.Point(382, 113);
            this.lightN3.Name = "lightN3";
            this.lightN3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN3.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN3.Size = new System.Drawing.Size(57, 24);
            this.lightN3.TabIndex = 64;
            // 
            // lightN4
            // 
            this.lightN4.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN4.Form = this;
            this.lightN4.LightingColor = System.Drawing.Color.Gold;
            this.lightN4.Location = new System.Drawing.Point(382, 161);
            this.lightN4.Name = "lightN4";
            this.lightN4.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN4.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN4.Size = new System.Drawing.Size(57, 24);
            this.lightN4.TabIndex = 65;
            // 
            // CmykHorizontalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(442, 201);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnud4);
            this.Controls.Add(this.cnud3);
            this.Controls.Add(this.cnud2);
            this.Controls.Add(this.cnud1);
            this.Controls.Add(this.hcbox4);
            this.Controls.Add(this.hcbox3);
            this.Controls.Add(this.hcbox2);
            this.Controls.Add(this.hcbox1);
            this.Controls.Add(this.ctbar4);
            this.Controls.Add(this.ctbar3);
            this.Controls.Add(this.ctbar2);
            this.Controls.Add(this.ctbar1);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.light2);
            this.Controls.Add(this.light3);
            this.Controls.Add(this.light4);
            this.Controls.Add(this.lightN1);
            this.Controls.Add(this.lightN2);
            this.Controls.Add(this.lightN3);
            this.Controls.Add(this.lightN4);
            this.MaximumSize = new System.Drawing.Size(2000, 240);
            this.MinimumSize = new System.Drawing.Size(268, 240);
            this.Name = "CmykHorizontalView";
            this.Text = "CMYK";
            this.Controls.SetChildIndex(this.lightN4, 0);
            this.Controls.SetChildIndex(this.lightN3, 0);
            this.Controls.SetChildIndex(this.lightN2, 0);
            this.Controls.SetChildIndex(this.lightN1, 0);
            this.Controls.SetChildIndex(this.light4, 0);
            this.Controls.SetChildIndex(this.light3, 0);
            this.Controls.SetChildIndex(this.light2, 0);
            this.Controls.SetChildIndex(this.light1, 0);
            this.Controls.SetChildIndex(this.colorLabel2, 0);
            this.Controls.SetChildIndex(this.colorLabel1, 0);
            this.Controls.SetChildIndex(this.ctbar1, 0);
            this.Controls.SetChildIndex(this.ctbar2, 0);
            this.Controls.SetChildIndex(this.ctbar3, 0);
            this.Controls.SetChildIndex(this.ctbar4, 0);
            this.Controls.SetChildIndex(this.hcbox1, 0);
            this.Controls.SetChildIndex(this.hcbox2, 0);
            this.Controls.SetChildIndex(this.hcbox3, 0);
            this.Controls.SetChildIndex(this.hcbox4, 0);
            this.Controls.SetChildIndex(this.cnud1, 0);
            this.Controls.SetChildIndex(this.cnud2, 0);
            this.Controls.SetChildIndex(this.cnud3, 0);
            this.Controls.SetChildIndex(this.cnud4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.hcbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private HColorBox hcbox1;
		private HColorBox hcbox2;
		private HColorBox hcbox3;
		private HColorBox hcbox4;
		private CtrackBar ctbar1;
		private CtrackBar ctbar2;
		private CtrackBar ctbar3;
		private CtrackBar ctbar4;
		private CnumericUpDown cnud1;
		private CnumericUpDown cnud2;
		private CnumericUpDown cnud3;
		private CnumericUpDown cnud4;
		private Label label1;
		private Label label2;
		private Label label3;
        private Label label4;
        private LightingLabel light1;
        private LightingLabel light2;
        private LightingLabel light3;
        private LightingLabel light4;
        private LightingLabel lightN1;
        private LightingLabel lightN2;
        private LightingLabel lightN3;
        private LightingLabel lightN4;
	}
}
