using System.ComponentModel;
using System.Windows.Forms;
using ColorMan.AppControls;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
	partial class DialogForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRgbG = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbHsvV = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbRgbB = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbHsvS = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbHslH = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbHslL = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbHsvH = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbHslS = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbLabB = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbRgbR = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbLabA = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.rbLabL = new ColorMan.ControlsLibrary.GroupRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.lbHex = new System.Windows.Forms.Label();
            this.lbOld = new System.Windows.Forms.Label();
            this.lbNew = new System.Windows.Forms.Label();
            this.btnCncl = new ColorMan.ControlsLibrary.Cbutton();
            this.btnOk = new ColorMan.ControlsLibrary.Cbutton();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enterHex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbHex = new ColorMan.ControlsLibrary.HexTextBox();
            this.wrapHex = new ColorMan.ControlsLibrary.WrapControl();
            this.squarePointer2 = new ColorMan.ControlsLibrary.VPointer();
            this.squarePointer1 = new ColorMan.ControlsLibrary.HPointer();
            this.linearPointer = new ColorMan.ControlsLibrary.VPointer();
            this.clNew = new ColorMan.ControlsLibrary.ColorLabel();
            this.clOld = new ColorMan.ControlsLibrary.ColorLabel();
            this.wrapL = new ColorMan.ControlsLibrary.WrapControl();
            this.linear = new ColorMan.ControlsLibrary.VColorBox();
            this.wrapS = new ColorMan.ControlsLibrary.WrapControl();
            this.square = new ColorMan.AppControls.SquareColorBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.wrapHex.SuspendLayout();
            this.wrapL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linear)).BeginInit();
            this.wrapS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRgbG);
            this.panel1.Controls.Add(this.rbHsvV);
            this.panel1.Controls.Add(this.rbRgbB);
            this.panel1.Controls.Add(this.rbHsvS);
            this.panel1.Controls.Add(this.rbHslH);
            this.panel1.Controls.Add(this.rbHslL);
            this.panel1.Controls.Add(this.rbHsvH);
            this.panel1.Controls.Add(this.rbHslS);
            this.panel1.Controls.Add(this.rbLabB);
            this.panel1.Controls.Add(this.rbRgbR);
            this.panel1.Controls.Add(this.rbLabA);
            this.panel1.Controls.Add(this.rbLabL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label0);
            this.panel1.Location = new System.Drawing.Point(396, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 288);
            this.panel1.TabIndex = 4;
            // 
            // rbRgbG
            // 
            this.rbRgbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRgbG.ForeColor = System.Drawing.Color.LightGray;
            this.rbRgbG.Location = new System.Drawing.Point(6, 178);
            this.rbRgbG.Name = "rbRgbG";
            this.rbRgbG.Outer = null;
            this.rbRgbG.Size = new System.Drawing.Size(30, 16);
            this.rbRgbG.TabIndex = 7;
            this.rbRgbG.Text = "G";
            this.rbRgbG.UseVisualStyleBackColor = true;
            this.rbRgbG.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHsvV
            // 
            this.rbHsvV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHsvV.ForeColor = System.Drawing.Color.LightGray;
            this.rbHsvV.Location = new System.Drawing.Point(6, 53);
            this.rbHsvV.Name = "rbHsvV";
            this.rbHsvV.Outer = null;
            this.rbHsvV.Size = new System.Drawing.Size(30, 16);
            this.rbHsvV.TabIndex = 2;
            this.rbHsvV.Text = "V";
            this.rbHsvV.UseVisualStyleBackColor = true;
            this.rbHsvV.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRgbB
            // 
            this.rbRgbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRgbB.ForeColor = System.Drawing.Color.LightGray;
            this.rbRgbB.Location = new System.Drawing.Point(6, 197);
            this.rbRgbB.Name = "rbRgbB";
            this.rbRgbB.Outer = null;
            this.rbRgbB.Size = new System.Drawing.Size(30, 16);
            this.rbRgbB.TabIndex = 8;
            this.rbRgbB.Text = "B";
            this.rbRgbB.UseVisualStyleBackColor = true;
            this.rbRgbB.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHsvS
            // 
            this.rbHsvS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHsvS.ForeColor = System.Drawing.Color.LightGray;
            this.rbHsvS.Location = new System.Drawing.Point(6, 34);
            this.rbHsvS.Name = "rbHsvS";
            this.rbHsvS.Outer = null;
            this.rbHsvS.Size = new System.Drawing.Size(30, 16);
            this.rbHsvS.TabIndex = 1;
            this.rbHsvS.Text = "S";
            this.rbHsvS.UseVisualStyleBackColor = true;
            this.rbHsvS.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHslH
            // 
            this.rbHslH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHslH.ForeColor = System.Drawing.Color.LightGray;
            this.rbHslH.Location = new System.Drawing.Point(6, 87);
            this.rbHslH.Name = "rbHslH";
            this.rbHslH.Outer = null;
            this.rbHslH.Size = new System.Drawing.Size(30, 16);
            this.rbHslH.TabIndex = 3;
            this.rbHslH.Text = "H";
            this.rbHslH.UseVisualStyleBackColor = true;
            this.rbHslH.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHslL
            // 
            this.rbHslL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHslL.ForeColor = System.Drawing.Color.LightGray;
            this.rbHslL.Location = new System.Drawing.Point(6, 125);
            this.rbHslL.Name = "rbHslL";
            this.rbHslL.Outer = null;
            this.rbHslL.Size = new System.Drawing.Size(30, 16);
            this.rbHslL.TabIndex = 5;
            this.rbHslL.Text = "L";
            this.rbHslL.UseVisualStyleBackColor = true;
            this.rbHslL.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHsvH
            // 
            this.rbHsvH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHsvH.ForeColor = System.Drawing.Color.LightGray;
            this.rbHsvH.Location = new System.Drawing.Point(6, 15);
            this.rbHsvH.Name = "rbHsvH";
            this.rbHsvH.Outer = null;
            this.rbHsvH.Size = new System.Drawing.Size(30, 16);
            this.rbHsvH.TabIndex = 0;
            this.rbHsvH.Text = "H";
            this.rbHsvH.UseVisualStyleBackColor = true;
            this.rbHsvH.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHslS
            // 
            this.rbHslS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHslS.ForeColor = System.Drawing.Color.LightGray;
            this.rbHslS.Location = new System.Drawing.Point(6, 106);
            this.rbHslS.Name = "rbHslS";
            this.rbHslS.Outer = null;
            this.rbHslS.Size = new System.Drawing.Size(30, 16);
            this.rbHslS.TabIndex = 4;
            this.rbHslS.Text = "S";
            this.rbHslS.UseVisualStyleBackColor = true;
            this.rbHslS.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbLabB
            // 
            this.rbLabB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLabB.ForeColor = System.Drawing.Color.LightGray;
            this.rbLabB.Location = new System.Drawing.Point(6, 269);
            this.rbLabB.Name = "rbLabB";
            this.rbLabB.Outer = null;
            this.rbLabB.Size = new System.Drawing.Size(30, 16);
            this.rbLabB.TabIndex = 11;
            this.rbLabB.Text = "b";
            this.rbLabB.UseVisualStyleBackColor = true;
            this.rbLabB.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRgbR
            // 
            this.rbRgbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRgbR.ForeColor = System.Drawing.Color.LightGray;
            this.rbRgbR.Location = new System.Drawing.Point(6, 159);
            this.rbRgbR.Name = "rbRgbR";
            this.rbRgbR.Outer = null;
            this.rbRgbR.Size = new System.Drawing.Size(30, 16);
            this.rbRgbR.TabIndex = 6;
            this.rbRgbR.Text = "R";
            this.rbRgbR.UseVisualStyleBackColor = true;
            this.rbRgbR.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbLabA
            // 
            this.rbLabA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLabA.ForeColor = System.Drawing.Color.LightGray;
            this.rbLabA.Location = new System.Drawing.Point(6, 250);
            this.rbLabA.Name = "rbLabA";
            this.rbLabA.Outer = null;
            this.rbLabA.Size = new System.Drawing.Size(30, 16);
            this.rbLabA.TabIndex = 10;
            this.rbLabA.Text = "a";
            this.rbLabA.UseVisualStyleBackColor = true;
            this.rbLabA.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbLabL
            // 
            this.rbLabL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLabL.ForeColor = System.Drawing.Color.LightGray;
            this.rbLabL.Location = new System.Drawing.Point(6, 231);
            this.rbLabL.Name = "rbLabL";
            this.rbLabL.Outer = null;
            this.rbLabL.Size = new System.Drawing.Size(30, 16);
            this.rbLabL.TabIndex = 9;
            this.rbLabL.Text = "L";
            this.rbLabL.UseVisualStyleBackColor = true;
            this.rbLabL.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(3, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 72);
            this.label3.TabIndex = 15;
            this.label3.Text = "LAB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 72);
            this.label2.TabIndex = 14;
            this.label2.Text = "RGB";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 72);
            this.label1.TabIndex = 13;
            this.label1.Text = "HSL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label0
            // 
            this.label0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label0.ForeColor = System.Drawing.Color.LightGray;
            this.label0.Location = new System.Drawing.Point(3, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(36, 72);
            this.label0.TabIndex = 12;
            this.label0.Text = "HSV";
            this.label0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHex
            // 
            this.lbHex.AutoSize = true;
            this.lbHex.ForeColor = System.Drawing.Color.LightGray;
            this.lbHex.Location = new System.Drawing.Point(134, 318);
            this.lbHex.Name = "lbHex";
            this.lbHex.Size = new System.Drawing.Size(14, 13);
            this.lbHex.TabIndex = 5;
            this.lbHex.Text = "#";
            // 
            // lbOld
            // 
            this.lbOld.AutoSize = true;
            this.lbOld.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOld.ForeColor = System.Drawing.Color.LightGray;
            this.lbOld.Location = new System.Drawing.Point(84, 340);
            this.lbOld.Name = "lbOld";
            this.lbOld.Size = new System.Drawing.Size(17, 11);
            this.lbOld.TabIndex = 7;
            this.lbOld.Text = "old";
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNew.ForeColor = System.Drawing.Color.LightGray;
            this.lbNew.Location = new System.Drawing.Point(46, 340);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(23, 11);
            this.lbNew.TabIndex = 8;
            this.lbNew.Text = "new";
            // 
            // btnCncl
            // 
            this.btnCncl.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCncl.ActiveBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCncl.ActiveForeColor = System.Drawing.Color.White;
            this.btnCncl.BackColor = System.Drawing.Color.LightGray;
            this.btnCncl.DeactiveBackColor = System.Drawing.Color.LightGray;
            this.btnCncl.DeactiveForeColor = System.Drawing.Color.Black;
            this.btnCncl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCncl.FlatAppearance.BorderSize = 2;
            this.btnCncl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCncl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnCncl.ForeColor = System.Drawing.Color.Black;
            this.btnCncl.LightingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(179)))));
            this.btnCncl.LightingBorderColor = System.Drawing.Color.Gold;
            this.btnCncl.Location = new System.Drawing.Point(360, 318);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.DeactiveBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCncl.Size = new System.Drawing.Size(75, 25);
            this.btnCncl.TabIndex = 3;
            this.btnCncl.TabStop = false;
            this.btnCncl.Text = "&Cancel";
            this.btnCncl.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.ActiveBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOk.ActiveForeColor = System.Drawing.Color.White;
            this.btnOk.BackColor = System.Drawing.Color.LightGray;
            this.btnOk.DeactiveBackColor = System.Drawing.Color.LightGray;
            this.btnOk.DeactiveForeColor = System.Drawing.Color.Black;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.LightingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(179)))));
            this.btnOk.LightingBorderColor = System.Drawing.Color.Gold;
            this.btnOk.Location = new System.Drawing.Point(301, 318);
            this.btnOk.Name = "btnOk";
            this.btnOk.DeactiveBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOk.Size = new System.Drawing.Size(48, 25);
            this.btnOk.TabIndex = 2;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.ForeColor = System.Drawing.Color.LightGray;
            this.lb1.Location = new System.Drawing.Point(372, 123);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(13, 39);
            this.lb1.TabIndex = 13;
            this.lb1.Text = "h\r\nu\r\ne";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.ForeColor = System.Drawing.Color.LightGray;
            this.lb2.Location = new System.Drawing.Point(141, 3);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 13);
            this.lb2.TabIndex = 14;
            this.lb2.Text = "saturation";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.ForeColor = System.Drawing.Color.LightGray;
            this.lb3.Location = new System.Drawing.Point(300, 110);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(13, 65);
            this.lb3.TabIndex = 15;
            this.lb3.Text = "v\r\na\r\nl\r\nu\r\ne";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterHex});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // enterHex
            // 
            this.enterHex.Name = "enterHex";
            this.enterHex.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.enterHex.Size = new System.Drawing.Size(144, 22);
            this.enterHex.Text = "&Enter";
            this.enterHex.Click += new System.EventHandler(this.enterHex_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            // 
            // tbHex
            // 
            this.tbHex.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHex.ActiveForeColor = System.Drawing.Color.White;
            this.tbHex.BackColor = System.Drawing.Color.DarkGray;
            this.tbHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbHex.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.tbHex.DeactiveForeColor = System.Drawing.Color.Black;
            this.tbHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHex.ForeColor = System.Drawing.Color.Black;
            this.tbHex.Location = new System.Drawing.Point(2, 2);
            this.tbHex.Margin = new System.Windows.Forms.Padding(0);
            this.tbHex.MaxLength = 6;
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(51, 20);
            this.tbHex.TabIndex = 4;
            this.tbHex.TabStop = false;
            this.tbHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tbHex, "Enter Ctrl+H");
            this.tbHex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbHex_MouseDown);
            // 
            // wrapHex
            // 
            this.wrapHex.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapHex.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapHex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapHex.BackgroundImage")));
            this.wrapHex.ButtonOk = this.btnOk;
            this.wrapHex.Content = this.tbHex;
            this.wrapHex.Controls.Add(this.tbHex);
            this.wrapHex.Form = this;
            this.wrapHex.LightingColor = System.Drawing.Color.Gold;
            this.wrapHex.Location = new System.Drawing.Point(149, 313);
            this.wrapHex.Name = "wrapHex";
            this.wrapHex.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapHex.Padding = new System.Windows.Forms.Padding(2);
            this.wrapHex.Size = new System.Drawing.Size(55, 24);
            this.wrapHex.TabIndex = 21;
            this.wrapHex.Leave += new System.EventHandler(this.wrapHex_Leave);
            // 
            // squarePointer2
            // 
            this.squarePointer2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.squarePointer2.Location = new System.Drawing.Point(0, 13);
            this.squarePointer2.Margin = new System.Windows.Forms.Padding(0);
            this.squarePointer2.Maximum = 100D;
            this.squarePointer2.Minimum = 0D;
            this.squarePointer2.Name = "squarePointer2";
            this.squarePointer2.Side = 255;
            this.squarePointer2.Size = new System.Drawing.Size(36, 269);
            this.squarePointer2.TabIndex = 2;
            this.squarePointer2.Val = 0D;
            // 
            // squarePointer1
            // 
            this.squarePointer1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.squarePointer1.Location = new System.Drawing.Point(27, 277);
            this.squarePointer1.Margin = new System.Windows.Forms.Padding(0);
            this.squarePointer1.Maximum = 100D;
            this.squarePointer1.Minimum = 0D;
            this.squarePointer1.Name = "squarePointer1";
            this.squarePointer1.Side = 255;
            this.squarePointer1.Size = new System.Drawing.Size(279, 26);
            this.squarePointer1.TabIndex = 1;
            this.squarePointer1.Val = 0D;
            // 
            // linearPointer
            // 
            this.linearPointer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.linearPointer.Location = new System.Drawing.Point(315, 13);
            this.linearPointer.Margin = new System.Windows.Forms.Padding(0);
            this.linearPointer.Maximum = 100D;
            this.linearPointer.Minimum = 0D;
            this.linearPointer.Name = "linearPointer";
            this.linearPointer.Side = 255;
            this.linearPointer.Size = new System.Drawing.Size(36, 269);
            this.linearPointer.TabIndex = 20;
            this.linearPointer.Val = 0D;
            // 
            // clNew
            // 
            this.clNew.AllowDrop = true;
            this.clNew.BackColor = System.Drawing.Color.Gray;
            this.clNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clNew.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clNew.LightingColor = System.Drawing.Color.Gold;
            this.clNew.Location = new System.Drawing.Point(37, 302);
            this.clNew.Name = "clNew";
            this.clNew.Size = new System.Drawing.Size(36, 36);
            this.clNew.Stroke = 2F;
            this.clNew.TabIndex = 5;
            this.clNew.TabStop = false;
            this.clNew.TypeAndHex = "RGB 808080";
            // 
            // clOld
            // 
            this.clOld.AllowDrop = true;
            this.clOld.BackColor = System.Drawing.Color.Gray;
            this.clOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clOld.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clOld.LightingColor = System.Drawing.Color.Gold;
            this.clOld.Location = new System.Drawing.Point(76, 302);
            this.clOld.Name = "clOld";
            this.clOld.Size = new System.Drawing.Size(36, 36);
            this.clOld.Stroke = 2F;
            this.clOld.TabIndex = 6;
            this.clOld.TabStop = false;
            this.clOld.TypeAndHex = "RGB 808080";
            // 
            // wrapL
            // 
            this.wrapL.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapL.BackgroundImage")));
            this.wrapL.ButtonOk = this.btnOk;
            this.wrapL.Content = this.linear;
            this.wrapL.ContextMenuStrip = this.contextMenuStrip1;
            this.wrapL.Controls.Add(this.linear);
            this.wrapL.Form = this;
            this.wrapL.LightingColor = System.Drawing.Color.Gold;
            this.wrapL.Location = new System.Drawing.Point(351, 17);
            this.wrapL.Name = "wrapL";
            this.wrapL.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapL.Padding = new System.Windows.Forms.Padding(2);
            this.wrapL.Size = new System.Drawing.Size(20, 260);
            this.wrapL.TabIndex = 0;
            this.wrapL.Leave += new System.EventHandler(this.wrap_Leave);
            // 
            // linear
            // 
            this.linear.BackColor = System.Drawing.Color.Gray;
            this.linear.BrightnessUnderTheCursorFunc = null;
            this.linear.BrushFunc = null;
            this.linear.CenterColor = System.Drawing.Color.Empty;
            this.linear.ColorCount = 2;
            this.linear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linear.Increment = 0.01F;
            this.linear.IsRightDowned = false;
            this.linear.Location = new System.Drawing.Point(2, 2);
            this.linear.Margin = new System.Windows.Forms.Padding(0);
            this.linear.Name = "linear";
            this.linear.SelectedColorFunc = null;
            this.linear.Size = new System.Drawing.Size(16, 256);
            this.linear.TabIndex = 3;
            this.linear.TabStop = false;
            this.linear.Val = 0F;
            // 
            // wrapS
            // 
            this.wrapS.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapS.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapS.BackgroundImage")));
            this.wrapS.ButtonOk = this.btnOk;
            this.wrapS.Content = this.square;
            this.wrapS.ContextMenuStrip = this.contextMenuStrip1;
            this.wrapS.Controls.Add(this.square);
            this.wrapS.Form = this;
            this.wrapS.LightingColor = System.Drawing.Color.Gold;
            this.wrapS.Location = new System.Drawing.Point(36, 17);
            this.wrapS.Name = "wrapS";
            this.wrapS.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapS.Padding = new System.Windows.Forms.Padding(2);
            this.wrapS.Size = new System.Drawing.Size(260, 260);
            this.wrapS.TabIndex = 1;
            this.wrapS.Leave += new System.EventHandler(this.wrap_Leave);
            // 
            // square
            // 
            this.square.AutoColorSize = false;
            this.square.BackColor = System.Drawing.Color.Gray;
            this.square.BrightnessUnderTheCursorFunc = null;
            this.square.BrushFunc = null;
            this.square.CenterColor = System.Drawing.Color.Empty;
            this.square.ColorCount = 2;
            this.square.ColorDiameter = 12;
            this.square.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square.Increment1 = 0.01D;
            this.square.Increment2 = 0.01D;
            this.square.IsRightDowned = false;
            this.square.Location = new System.Drawing.Point(2, 2);
            this.square.Margin = new System.Windows.Forms.Padding(0);
            this.square.Name = "square";
            this.square.SelectedColorFunc = null;
            this.square.SelfPaint = true;
            this.square.Size = new System.Drawing.Size(256, 256);
            this.square.Space = null;
            this.square.TabIndex = 0;
            this.square.TabStop = false;
            this.square.UseIndent = false;
            this.square.Val1 = 0D;
            this.square.Val2 = 0D;
            this.square.ValueChanged1 += new System.EventHandler(this.square_ValueChanged1);
            this.square.ValueChanged2 += new System.EventHandler(this.square_ValueChanged2);
            this.square.Paint += new System.Windows.Forms.PaintEventHandler(this.square_Paint);
            // 
            // DialogForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btnCncl;
            this.ClientSize = new System.Drawing.Size(440, 354);
            this.Controls.Add(this.wrapHex);
            this.Controls.Add(this.squarePointer2);
            this.Controls.Add(this.squarePointer1);
            this.Controls.Add(this.linearPointer);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.clNew);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.clOld);
            this.Controls.Add(this.lbNew);
            this.Controls.Add(this.lbOld);
            this.Controls.Add(this.lbHex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wrapL);
            this.Controls.Add(this.wrapS);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dialog";
            this.Shown += new System.EventHandler(this.DialogForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.DialogForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.wrapHex.ResumeLayout(false);
            this.wrapHex.PerformLayout();
            this.wrapL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linear)).EndInit();
            this.wrapS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private SquareColorBox square;
		private HPointer squarePointer1;
		private VPointer squarePointer2;
		private VColorBox linear;
		private Panel panel1;
		private GroupRadioButton rbLabL;
		private GroupRadioButton rbRgbG;
		private GroupRadioButton rbHsvV;
		private GroupRadioButton rbRgbB;
		private GroupRadioButton rbHsvS;
		private GroupRadioButton rbHslH;
		private GroupRadioButton rbHslL;
		private GroupRadioButton rbHsvH;
		private GroupRadioButton rbHslS;
		private GroupRadioButton rbLabB;
		private GroupRadioButton rbRgbR;
		private GroupRadioButton rbLabA;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label label0;
		private Label lbHex;
		private HexTextBox tbHex;
		private Label lbOld;
		private Label lbNew;
		private ColorLabel clOld;
		private Cbutton btnCncl;
		private ColorLabel clNew;
        private Cbutton btnOk;
		private Label lb1;
		private Label lb2;
		private Label lb3;
        private WrapControl wrapL;
		private ContextMenuStrip contextMenuStrip1;
		private WrapControl wrapS;
		private ToolStripMenuItem enterHex;
		private VPointer linearPointer;
        private WrapControl wrapHex;
        private ToolTip toolTip1;
	}
}