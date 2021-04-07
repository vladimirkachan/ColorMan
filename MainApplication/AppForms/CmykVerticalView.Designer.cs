using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    partial class CmykVerticalView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vcbox3 = new ColorMan.ControlsLibrary.VColorBox();
            this.ctbar3 = new ColorMan.ControlsLibrary.CtrackBar();
            this.vcbox2 = new ColorMan.ControlsLibrary.VColorBox();
            this.ctbar2 = new ColorMan.ControlsLibrary.CtrackBar();
            this.vcbox1 = new ColorMan.ControlsLibrary.VColorBox();
            this.ctbar1 = new ColorMan.ControlsLibrary.CtrackBar();
            this.vcbox4 = new ColorMan.ControlsLibrary.VColorBox();
            this.ctbar4 = new ColorMan.ControlsLibrary.CtrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.cnud3 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.cnud2 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.cnud1 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.cnud4 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.light1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light3 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light4 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN3 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN4 = new ColorMan.ControlsLibrary.LightingLabel();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud4)).BeginInit();
            this.SuspendLayout();
            // 
            // colorLabel1
            // 
            this.colorLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel1.Location = new System.Drawing.Point(10, 321);
            this.colorLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.colorLabel1.MaximumSize = new System.Drawing.Size(24, 24);
            this.colorLabel1.MinimumSize = new System.Drawing.Size(24, 24);
            this.colorLabel1.Size = new System.Drawing.Size(24, 24);
            // 
            // colorLabel2
            // 
            this.colorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel2.Location = new System.Drawing.Point(22, 333);
            this.colorLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.colorLabel2.MaximumSize = new System.Drawing.Size(24, 24);
            this.colorLabel2.MinimumSize = new System.Drawing.Size(24, 24);
            this.colorLabel2.Size = new System.Drawing.Size(24, 24);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(126, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(70, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "M";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(20, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "C";
            // 
            // vcbox3
            // 
            this.vcbox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vcbox3.BackColor = System.Drawing.Color.Gray;
            this.vcbox3.BrightnessUnderTheCursorFunc = null;
            this.vcbox3.BrushFunc = null;
            this.vcbox3.CenterColor = System.Drawing.Color.Empty;
            this.vcbox3.ColorCount = 2;
            this.vcbox3.Increment = 0.01F;
            this.vcbox3.IsRightDowned = false;
            this.vcbox3.Location = new System.Drawing.Point(117, 16);
            this.vcbox3.Margin = new System.Windows.Forms.Padding(0);
            this.vcbox3.MaximumSize = new System.Drawing.Size(20, 540);
            this.vcbox3.MinimumSize = new System.Drawing.Size(20, 77);
            this.vcbox3.Name = "vcbox3";
            this.vcbox3.SelectedColorFunc = null;
            this.vcbox3.Size = new System.Drawing.Size(20, 255);
            this.vcbox3.TabIndex = 73;
            this.vcbox3.TabStop = false;
            this.vcbox3.Val = 0F;
            this.vcbox3.ValueChanged += new System.EventHandler(this.Vcbox3ValueChanged);
            this.vcbox3.LastValue += new System.EventHandler(this.item_LastValue);
            this.vcbox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vcbox_MouseDown);
            // 
            // ctbar3
            // 
            this.ctbar3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar3.AutoSize = false;
            this.ctbar3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ctbar3.Location = new System.Drawing.Point(128, 3);
            this.ctbar3.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar3.Maximum = 100;
            this.ctbar3.MaximumSize = new System.Drawing.Size(30, 566);
            this.ctbar3.MinimumSize = new System.Drawing.Size(30, 103);
            this.ctbar3.Name = "ctbar3";
            this.ctbar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ctbar3.Size = new System.Drawing.Size(30, 281);
            this.ctbar3.TabIndex = 74;
            this.ctbar3.TickFrequency = 255;
            this.ctbar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar3.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // vcbox2
            // 
            this.vcbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vcbox2.BackColor = System.Drawing.Color.Gray;
            this.vcbox2.BrightnessUnderTheCursorFunc = null;
            this.vcbox2.BrushFunc = null;
            this.vcbox2.CenterColor = System.Drawing.Color.Empty;
            this.vcbox2.ColorCount = 2;
            this.vcbox2.Increment = 0.01F;
            this.vcbox2.IsRightDowned = false;
            this.vcbox2.Location = new System.Drawing.Point(64, 16);
            this.vcbox2.Margin = new System.Windows.Forms.Padding(0);
            this.vcbox2.MaximumSize = new System.Drawing.Size(20, 540);
            this.vcbox2.MinimumSize = new System.Drawing.Size(20, 77);
            this.vcbox2.Name = "vcbox2";
            this.vcbox2.SelectedColorFunc = null;
            this.vcbox2.Size = new System.Drawing.Size(20, 255);
            this.vcbox2.TabIndex = 71;
            this.vcbox2.TabStop = false;
            this.vcbox2.Val = 0F;
            this.vcbox2.ValueChanged += new System.EventHandler(this.Vcbox2ValueChanged);
            this.vcbox2.LastValue += new System.EventHandler(this.item_LastValue);
            this.vcbox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vcbox_MouseDown);
            // 
            // ctbar2
            // 
            this.ctbar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar2.AutoSize = false;
            this.ctbar2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ctbar2.Location = new System.Drawing.Point(75, 3);
            this.ctbar2.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar2.Maximum = 100;
            this.ctbar2.MaximumSize = new System.Drawing.Size(30, 566);
            this.ctbar2.MinimumSize = new System.Drawing.Size(30, 103);
            this.ctbar2.Name = "ctbar2";
            this.ctbar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ctbar2.Size = new System.Drawing.Size(30, 281);
            this.ctbar2.TabIndex = 72;
            this.ctbar2.TickFrequency = 255;
            this.ctbar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar2.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar2.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar2.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // vcbox1
            // 
            this.vcbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vcbox1.BackColor = System.Drawing.Color.Gray;
            this.vcbox1.BrightnessUnderTheCursorFunc = null;
            this.vcbox1.BrushFunc = null;
            this.vcbox1.CenterColor = System.Drawing.Color.Empty;
            this.vcbox1.ColorCount = 2;
            this.vcbox1.Increment = 0.01F;
            this.vcbox1.IsRightDowned = false;
            this.vcbox1.Location = new System.Drawing.Point(11, 16);
            this.vcbox1.Margin = new System.Windows.Forms.Padding(0);
            this.vcbox1.MaximumSize = new System.Drawing.Size(20, 540);
            this.vcbox1.MinimumSize = new System.Drawing.Size(20, 77);
            this.vcbox1.Name = "vcbox1";
            this.vcbox1.SelectedColorFunc = null;
            this.vcbox1.Size = new System.Drawing.Size(20, 255);
            this.vcbox1.TabIndex = 69;
            this.vcbox1.TabStop = false;
            this.vcbox1.Val = 0F;
            this.vcbox1.ValueChanged += new System.EventHandler(this.Vcbox1ValueChanged);
            this.vcbox1.LastValue += new System.EventHandler(this.item_LastValue);
            this.vcbox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vcbox_MouseDown);
            // 
            // ctbar1
            // 
            this.ctbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar1.AutoSize = false;
            this.ctbar1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ctbar1.Location = new System.Drawing.Point(22, 3);
            this.ctbar1.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar1.Maximum = 100;
            this.ctbar1.MaximumSize = new System.Drawing.Size(30, 566);
            this.ctbar1.MinimumSize = new System.Drawing.Size(30, 103);
            this.ctbar1.Name = "ctbar1";
            this.ctbar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ctbar1.Size = new System.Drawing.Size(30, 281);
            this.ctbar1.TabIndex = 70;
            this.ctbar1.TickFrequency = 255;
            this.ctbar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar1.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar1.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar1.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // vcbox4
            // 
            this.vcbox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vcbox4.BackColor = System.Drawing.Color.Gray;
            this.vcbox4.BrightnessUnderTheCursorFunc = null;
            this.vcbox4.BrushFunc = null;
            this.vcbox4.CenterColor = System.Drawing.Color.Empty;
            this.vcbox4.ColorCount = 2;
            this.vcbox4.Increment = 0.01F;
            this.vcbox4.IsRightDowned = false;
            this.vcbox4.Location = new System.Drawing.Point(170, 16);
            this.vcbox4.Margin = new System.Windows.Forms.Padding(0);
            this.vcbox4.MaximumSize = new System.Drawing.Size(20, 540);
            this.vcbox4.MinimumSize = new System.Drawing.Size(20, 77);
            this.vcbox4.Name = "vcbox4";
            this.vcbox4.SelectedColorFunc = null;
            this.vcbox4.Size = new System.Drawing.Size(20, 255);
            this.vcbox4.TabIndex = 78;
            this.vcbox4.TabStop = false;
            this.vcbox4.Val = 0F;
            this.vcbox4.ValueChanged += new System.EventHandler(this.Vcbox4ValueChanged);
            this.vcbox4.LastValue += new System.EventHandler(this.item_LastValue);
            this.vcbox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vcbox_MouseDown);
            // 
            // ctbar4
            // 
            this.ctbar4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbar4.AutoSize = false;
            this.ctbar4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ctbar4.Location = new System.Drawing.Point(181, 3);
            this.ctbar4.Margin = new System.Windows.Forms.Padding(0);
            this.ctbar4.Maximum = 100;
            this.ctbar4.MaximumSize = new System.Drawing.Size(30, 566);
            this.ctbar4.MinimumSize = new System.Drawing.Size(30, 103);
            this.ctbar4.Name = "ctbar4";
            this.ctbar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ctbar4.Size = new System.Drawing.Size(30, 281);
            this.ctbar4.TabIndex = 79;
            this.ctbar4.TickFrequency = 255;
            this.ctbar4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar4.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar4.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar4.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(178, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "K";
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
            this.cnud3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.cnud3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud3.Location = new System.Drawing.Point(110, 295);
            this.cnud3.Margin = new System.Windows.Forms.Padding(0);
            this.cnud3.Name = "cnud3";
            this.cnud3.Size = new System.Drawing.Size(48, 20);
            this.cnud3.TabIndex = 83;
            this.cnud3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud3.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud3.Leave += new System.EventHandler(this.ctrl_Leave);
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
            this.cnud2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.cnud2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud2.Location = new System.Drawing.Point(57, 295);
            this.cnud2.Margin = new System.Windows.Forms.Padding(0);
            this.cnud2.Name = "cnud2";
            this.cnud2.Size = new System.Drawing.Size(48, 20);
            this.cnud2.TabIndex = 82;
            this.cnud2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud2.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud2.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud2.Leave += new System.EventHandler(this.ctrl_Leave);
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
            this.cnud1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.cnud1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud1.Location = new System.Drawing.Point(4, 295);
            this.cnud1.Margin = new System.Windows.Forms.Padding(0);
            this.cnud1.Name = "cnud1";
            this.cnud1.Size = new System.Drawing.Size(48, 20);
            this.cnud1.TabIndex = 81;
            this.cnud1.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud1.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud1.Leave += new System.EventHandler(this.ctrl_Leave);
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
            this.cnud4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.cnud4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud4.Location = new System.Drawing.Point(163, 295);
            this.cnud4.Margin = new System.Windows.Forms.Padding(0);
            this.cnud4.Name = "cnud4";
            this.cnud4.Size = new System.Drawing.Size(48, 20);
            this.cnud4.TabIndex = 84;
            this.cnud4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud4.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud4.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud4.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // light1
            // 
            this.light1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light1.Form = this;
            this.light1.LightingColor = System.Drawing.Color.Gold;
            this.light1.Location = new System.Drawing.Point(1, 0);
            this.light1.Name = "light1";
            this.light1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light1.Padding = new System.Windows.Forms.Padding(2);
            this.light1.Size = new System.Drawing.Size(53, 286);
            this.light1.TabIndex = 85;
            // 
            // light2
            // 
            this.light2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light2.Form = this;
            this.light2.LightingColor = System.Drawing.Color.Gold;
            this.light2.Location = new System.Drawing.Point(54, 0);
            this.light2.Name = "light2";
            this.light2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light2.Padding = new System.Windows.Forms.Padding(2);
            this.light2.Size = new System.Drawing.Size(53, 286);
            this.light2.TabIndex = 86;
            // 
            // light3
            // 
            this.light3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light3.Form = this;
            this.light3.LightingColor = System.Drawing.Color.Gold;
            this.light3.Location = new System.Drawing.Point(107, 0);
            this.light3.Name = "light3";
            this.light3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light3.Padding = new System.Windows.Forms.Padding(2);
            this.light3.Size = new System.Drawing.Size(53, 286);
            this.light3.TabIndex = 87;
            // 
            // light4
            // 
            this.light4.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light4.Form = this;
            this.light4.LightingColor = System.Drawing.Color.Gold;
            this.light4.Location = new System.Drawing.Point(160, 0);
            this.light4.Name = "light4";
            this.light4.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light4.Padding = new System.Windows.Forms.Padding(2);
            this.light4.Size = new System.Drawing.Size(53, 286);
            this.light4.TabIndex = 88;
            // 
            // lightN1
            // 
            this.lightN1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN1.Form = this;
            this.lightN1.LightingColor = System.Drawing.Color.Gold;
            this.lightN1.Location = new System.Drawing.Point(1, 293);
            this.lightN1.Name = "lightN1";
            this.lightN1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN1.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN1.Size = new System.Drawing.Size(53, 24);
            this.lightN1.TabIndex = 89;
            // 
            // lightN2
            // 
            this.lightN2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN2.Form = this;
            this.lightN2.LightingColor = System.Drawing.Color.Gold;
            this.lightN2.Location = new System.Drawing.Point(54, 293);
            this.lightN2.Name = "lightN2";
            this.lightN2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN2.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN2.Size = new System.Drawing.Size(53, 24);
            this.lightN2.TabIndex = 90;
            // 
            // lightN3
            // 
            this.lightN3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN3.Form = this;
            this.lightN3.LightingColor = System.Drawing.Color.Gold;
            this.lightN3.Location = new System.Drawing.Point(107, 293);
            this.lightN3.Name = "lightN3";
            this.lightN3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN3.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN3.Size = new System.Drawing.Size(53, 24);
            this.lightN3.TabIndex = 91;
            // 
            // lightN4
            // 
            this.lightN4.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN4.Form = this;
            this.lightN4.LightingColor = System.Drawing.Color.Gold;
            this.lightN4.Location = new System.Drawing.Point(160, 293);
            this.lightN4.Name = "lightN4";
            this.lightN4.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN4.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN4.Size = new System.Drawing.Size(53, 24);
            this.lightN4.TabIndex = 92;
            // 
            // CmykVerticalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(214, 361);
            this.Controls.Add(this.cnud4);
            this.Controls.Add(this.cnud3);
            this.Controls.Add(this.cnud2);
            this.Controls.Add(this.cnud1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vcbox4);
            this.Controls.Add(this.ctbar4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vcbox3);
            this.Controls.Add(this.ctbar3);
            this.Controls.Add(this.vcbox2);
            this.Controls.Add(this.ctbar2);
            this.Controls.Add(this.vcbox1);
            this.Controls.Add(this.ctbar1);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.light2);
            this.Controls.Add(this.light3);
            this.Controls.Add(this.light4);
            this.Controls.Add(this.lightN1);
            this.Controls.Add(this.lightN2);
            this.Controls.Add(this.lightN3);
            this.Controls.Add(this.lightN4);
            this.MaximumSize = new System.Drawing.Size(230, 700);
            this.MinimumSize = new System.Drawing.Size(230, 215);
            this.Name = "CmykVerticalView";
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
            this.Controls.SetChildIndex(this.vcbox1, 0);
            this.Controls.SetChildIndex(this.ctbar2, 0);
            this.Controls.SetChildIndex(this.vcbox2, 0);
            this.Controls.SetChildIndex(this.ctbar3, 0);
            this.Controls.SetChildIndex(this.vcbox3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ctbar4, 0);
            this.Controls.SetChildIndex(this.vcbox4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cnud1, 0);
            this.Controls.SetChildIndex(this.cnud2, 0);
            this.Controls.SetChildIndex(this.cnud3, 0);
            this.Controls.SetChildIndex(this.cnud4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.vcbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VColorBox vcbox1;
        private VColorBox vcbox2;
        private VColorBox vcbox3;
        private VColorBox vcbox4;
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
