using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    partial class VerticalLinearView
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
            this.vcbox1 = new ColorMan.ControlsLibrary.VColorBox();
            this.ctbar1 = new ColorMan.ControlsLibrary.CtrackBar();
            this.vcbox2 = new ColorMan.ControlsLibrary.VColorBox();
            this.ctbar2 = new ColorMan.ControlsLibrary.CtrackBar();
            this.vcbox3 = new ColorMan.ControlsLibrary.VColorBox();
            this.ctbar3 = new ColorMan.ControlsLibrary.CtrackBar();
            this.ctbox1 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.cnud1 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.ctbox2 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.cnud2 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.ctbox3 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.cnud3 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.light1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.light3 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightN3 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightT1 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightT2 = new ColorMan.ControlsLibrary.LightingLabel();
            this.lightT3 = new ColorMan.ControlsLibrary.LightingLabel();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.SuspendLayout();
            // 
            // colorLabel1
            // 
            this.colorLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel1.Location = new System.Drawing.Point(10, 335);
            this.colorLabel1.MaximumSize = new System.Drawing.Size(0, 0);
            this.colorLabel1.MinimumSize = new System.Drawing.Size(0, 0);
            this.colorLabel1.Size = new System.Drawing.Size(24, 24);
            // 
            // colorLabel2
            // 
            this.colorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel2.Location = new System.Drawing.Point(22, 347);
            this.colorLabel2.MaximumSize = new System.Drawing.Size(0, 0);
            this.colorLabel2.MinimumSize = new System.Drawing.Size(0, 0);
            this.colorLabel2.Size = new System.Drawing.Size(24, 24);
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
            this.vcbox1.MaximumSize = new System.Drawing.Size(20, 540);
            this.vcbox1.MinimumSize = new System.Drawing.Size(20, 77);
            this.vcbox1.Name = "vcbox1";
            this.vcbox1.SelectedColorFunc = null;
            this.vcbox1.Size = new System.Drawing.Size(20, 250);
            this.vcbox1.TabIndex = 42;
            this.vcbox1.TabStop = false;
            this.vcbox1.Val = 0F;
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
            this.ctbar1.Maximum = 255;
            this.ctbar1.MaximumSize = new System.Drawing.Size(30, 566);
            this.ctbar1.MinimumSize = new System.Drawing.Size(30, 103);
            this.ctbar1.Name = "ctbar1";
            this.ctbar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ctbar1.Size = new System.Drawing.Size(30, 276);
            this.ctbar1.TabIndex = 0;
            this.ctbar1.TickFrequency = 255;
            this.ctbar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar1.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar1.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar1.Leave += new System.EventHandler(this.ctrl_Leave);
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
            this.vcbox2.MaximumSize = new System.Drawing.Size(20, 540);
            this.vcbox2.MinimumSize = new System.Drawing.Size(20, 77);
            this.vcbox2.Name = "vcbox2";
            this.vcbox2.SelectedColorFunc = null;
            this.vcbox2.Size = new System.Drawing.Size(20, 250);
            this.vcbox2.TabIndex = 44;
            this.vcbox2.TabStop = false;
            this.vcbox2.Val = 0F;
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
            this.ctbar2.Maximum = 255;
            this.ctbar2.MaximumSize = new System.Drawing.Size(30, 566);
            this.ctbar2.MinimumSize = new System.Drawing.Size(30, 103);
            this.ctbar2.Name = "ctbar2";
            this.ctbar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ctbar2.Size = new System.Drawing.Size(30, 276);
            this.ctbar2.TabIndex = 1;
            this.ctbar2.TickFrequency = 255;
            this.ctbar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar2.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar2.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar2.Leave += new System.EventHandler(this.ctrl_Leave);
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
            this.vcbox3.MaximumSize = new System.Drawing.Size(20, 540);
            this.vcbox3.MinimumSize = new System.Drawing.Size(20, 77);
            this.vcbox3.Name = "vcbox3";
            this.vcbox3.SelectedColorFunc = null;
            this.vcbox3.Size = new System.Drawing.Size(20, 250);
            this.vcbox3.TabIndex = 46;
            this.vcbox3.TabStop = false;
            this.vcbox3.Val = 0F;
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
            this.ctbar3.Maximum = 255;
            this.ctbar3.MaximumSize = new System.Drawing.Size(30, 566);
            this.ctbar3.MinimumSize = new System.Drawing.Size(30, 103);
            this.ctbar3.Name = "ctbar3";
            this.ctbar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ctbar3.Size = new System.Drawing.Size(30, 276);
            this.ctbar3.TabIndex = 2;
            this.ctbar3.TickFrequency = 255;
            this.ctbar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ctbar3.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbar3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbar3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbox1
            // 
            this.ctbox1.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctbox1.ActiveForeColor = System.Drawing.Color.White;
            this.ctbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbox1.BackColor = System.Drawing.Color.DarkGray;
            this.ctbox1.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctbox1.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctbox1.DecimalPlaces = 1;
            this.ctbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctbox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ctbox1.Location = new System.Drawing.Point(2, 310);
            this.ctbox1.Margin = new System.Windows.Forms.Padding(0);
            this.ctbox1.Maximum = 100F;
            this.ctbox1.Minimum = 0F;
            this.ctbox1.Name = "ctbox1";
            this.ctbox1.Size = new System.Drawing.Size(44, 20);
            this.ctbox1.TabIndex = 6;
            this.ctbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctbox1.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbox1.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbox1.Leave += new System.EventHandler(this.ctrl_Leave);
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
            50,
            0,
            0,
            0});
            this.cnud1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud1.Location = new System.Drawing.Point(4, 286);
            this.cnud1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnud1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.cnud1.Name = "cnud1";
            this.cnud1.Size = new System.Drawing.Size(48, 20);
            this.cnud1.TabIndex = 3;
            this.cnud1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud1.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud1.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud1.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbox2
            // 
            this.ctbox2.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctbox2.ActiveForeColor = System.Drawing.Color.White;
            this.ctbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbox2.BackColor = System.Drawing.Color.DarkGray;
            this.ctbox2.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctbox2.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctbox2.DecimalPlaces = 1;
            this.ctbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctbox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ctbox2.Location = new System.Drawing.Point(56, 310);
            this.ctbox2.Margin = new System.Windows.Forms.Padding(0);
            this.ctbox2.Maximum = 100F;
            this.ctbox2.Minimum = 0F;
            this.ctbox2.Name = "ctbox2";
            this.ctbox2.Size = new System.Drawing.Size(44, 20);
            this.ctbox2.TabIndex = 7;
            this.ctbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctbox2.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbox2.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbox2.Leave += new System.EventHandler(this.ctrl_Leave);
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
            50,
            0,
            0,
            0});
            this.cnud2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud2.Location = new System.Drawing.Point(57, 286);
            this.cnud2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnud2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.cnud2.Name = "cnud2";
            this.cnud2.Size = new System.Drawing.Size(48, 20);
            this.cnud2.TabIndex = 4;
            this.cnud2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud2.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud2.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud2.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // ctbox3
            // 
            this.ctbox3.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctbox3.ActiveForeColor = System.Drawing.Color.White;
            this.ctbox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbox3.BackColor = System.Drawing.Color.DarkGray;
            this.ctbox3.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctbox3.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctbox3.DecimalPlaces = 1;
            this.ctbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctbox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ctbox3.Location = new System.Drawing.Point(109, 310);
            this.ctbox3.Margin = new System.Windows.Forms.Padding(0);
            this.ctbox3.Maximum = 100F;
            this.ctbox3.Minimum = 0F;
            this.ctbox3.Name = "ctbox3";
            this.ctbox3.Size = new System.Drawing.Size(44, 20);
            this.ctbox3.TabIndex = 8;
            this.ctbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctbox3.LastValue += new System.EventHandler(this.item_LastValue);
            this.ctbox3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.ctbox3.Leave += new System.EventHandler(this.ctrl_Leave);
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
            50,
            0,
            0,
            0});
            this.cnud3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud3.Location = new System.Drawing.Point(110, 286);
            this.cnud3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnud3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.cnud3.Name = "cnud3";
            this.cnud3.Size = new System.Drawing.Size(48, 20);
            this.cnud3.TabIndex = 5;
            this.cnud3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud3.LastValue += new System.EventHandler(this.item_LastValue);
            this.cnud3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.cnud3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(66, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(120, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "B";
            // 
            // light1
            // 
            this.light1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.light1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.light1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.light1.Form = this;
            this.light1.LightingColor = System.Drawing.Color.Gold;
            this.light1.Location = new System.Drawing.Point(1, 0);
            this.light1.Name = "light1";
            this.light1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light1.Padding = new System.Windows.Forms.Padding(2);
            this.light1.Size = new System.Drawing.Size(53, 281);
            this.light1.TabIndex = 69;
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
            this.light2.Location = new System.Drawing.Point(54, 0);
            this.light2.Name = "light2";
            this.light2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light2.Padding = new System.Windows.Forms.Padding(2);
            this.light2.Size = new System.Drawing.Size(53, 281);
            this.light2.TabIndex = 70;
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
            this.light3.Location = new System.Drawing.Point(107, 0);
            this.light3.Name = "light3";
            this.light3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.light3.Padding = new System.Windows.Forms.Padding(2);
            this.light3.Size = new System.Drawing.Size(53, 281);
            this.light3.TabIndex = 71;
            // 
            // lightN1
            // 
            this.lightN1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN1.Form = this;
            this.lightN1.LightingColor = System.Drawing.Color.Gold;
            this.lightN1.Location = new System.Drawing.Point(1, 284);
            this.lightN1.Name = "lightN1";
            this.lightN1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN1.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN1.Size = new System.Drawing.Size(53, 24);
            this.lightN1.TabIndex = 72;
            // 
            // lightN2
            // 
            this.lightN2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN2.Form = this;
            this.lightN2.LightingColor = System.Drawing.Color.Gold;
            this.lightN2.Location = new System.Drawing.Point(54, 284);
            this.lightN2.Name = "lightN2";
            this.lightN2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN2.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN2.Size = new System.Drawing.Size(53, 24);
            this.lightN2.TabIndex = 73;
            // 
            // lightN3
            // 
            this.lightN3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightN3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightN3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN3.Form = this;
            this.lightN3.LightingColor = System.Drawing.Color.Gold;
            this.lightN3.Location = new System.Drawing.Point(107, 284);
            this.lightN3.Name = "lightN3";
            this.lightN3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightN3.Padding = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.lightN3.Size = new System.Drawing.Size(53, 24);
            this.lightN3.TabIndex = 74;
            // 
            // lightT1
            // 
            this.lightT1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightT1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightT1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT1.Form = this;
            this.lightT1.LightingColor = System.Drawing.Color.Gold;
            this.lightT1.Location = new System.Drawing.Point(0, 308);
            this.lightT1.Name = "lightT1";
            this.lightT1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT1.Padding = new System.Windows.Forms.Padding(2);
            this.lightT1.Size = new System.Drawing.Size(48, 24);
            this.lightT1.TabIndex = 75;
            // 
            // lightT2
            // 
            this.lightT2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightT2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightT2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT2.Form = this;
            this.lightT2.LightingColor = System.Drawing.Color.Gold;
            this.lightT2.Location = new System.Drawing.Point(54, 308);
            this.lightT2.Name = "lightT2";
            this.lightT2.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT2.Padding = new System.Windows.Forms.Padding(2);
            this.lightT2.Size = new System.Drawing.Size(48, 24);
            this.lightT2.TabIndex = 76;
            // 
            // lightT3
            // 
            this.lightT3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightT3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightT3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT3.Form = this;
            this.lightT3.LightingColor = System.Drawing.Color.Gold;
            this.lightT3.Location = new System.Drawing.Point(107, 308);
            this.lightT3.Name = "lightT3";
            this.lightT3.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.lightT3.Padding = new System.Windows.Forms.Padding(2);
            this.lightT3.Size = new System.Drawing.Size(48, 24);
            this.lightT3.TabIndex = 77;
            this.lightT3.Enter += new System.EventHandler(this.ctrl_Enter);
            this.lightT3.Leave += new System.EventHandler(this.ctrl_Leave);
            // 
            // VerticalLinearView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(161, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctbox3);
            this.Controls.Add(this.cnud3);
            this.Controls.Add(this.ctbox2);
            this.Controls.Add(this.cnud2);
            this.Controls.Add(this.ctbox1);
            this.Controls.Add(this.cnud1);
            this.Controls.Add(this.vcbox3);
            this.Controls.Add(this.ctbar3);
            this.Controls.Add(this.vcbox2);
            this.Controls.Add(this.ctbar2);
            this.Controls.Add(this.vcbox1);
            this.Controls.Add(this.ctbar1);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.light2);
            this.Controls.Add(this.light3);
            this.Controls.Add(this.lightN1);
            this.Controls.Add(this.lightN2);
            this.Controls.Add(this.lightN3);
            this.Controls.Add(this.lightT3);
            this.Controls.Add(this.lightT2);
            this.Controls.Add(this.lightT1);
            this.MaximumSize = new System.Drawing.Size(177, 700);
            this.MinimumSize = new System.Drawing.Size(177, 237);
            this.Name = "VerticalLinearView";
            this.Text = "VerticalLinearView";
            this.Controls.SetChildIndex(this.lightT1, 0);
            this.Controls.SetChildIndex(this.lightT2, 0);
            this.Controls.SetChildIndex(this.lightT3, 0);
            this.Controls.SetChildIndex(this.lightN3, 0);
            this.Controls.SetChildIndex(this.lightN2, 0);
            this.Controls.SetChildIndex(this.lightN1, 0);
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
            this.Controls.SetChildIndex(this.cnud1, 0);
            this.Controls.SetChildIndex(this.ctbox1, 0);
            this.Controls.SetChildIndex(this.cnud2, 0);
            this.Controls.SetChildIndex(this.ctbox2, 0);
            this.Controls.SetChildIndex(this.cnud3, 0);
            this.Controls.SetChildIndex(this.ctbox3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.vcbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected VColorBox vcbox1;
        protected CtrackBar ctbar1;
        protected VColorBox vcbox2;
        protected CtrackBar ctbar2;
        protected VColorBox vcbox3;
        protected CtrackBar ctbar3;
        protected NumberTextBox ctbox1;
        protected CnumericUpDown cnud1;
        protected NumberTextBox ctbox2;
        protected CnumericUpDown cnud2;
        protected NumberTextBox ctbox3;
        protected CnumericUpDown cnud3;
        protected Label label1;
        protected Label label2;
        protected Label label3;
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
