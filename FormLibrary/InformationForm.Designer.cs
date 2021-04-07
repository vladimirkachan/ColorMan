namespace ColorMan.FormLibrary
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.labelIcon = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelDecription = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.linkLabelWebsite = new System.Windows.Forms.LinkLabel();
            this.cbuttonClose = new ColorMan.ControlsLibrary.Cbutton();
            this.cbuttonDonate = new ColorMan.ControlsLibrary.Cbutton();
            this.SuspendLayout();
            // 
            // labelIcon
            // 
            this.labelIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelIcon.Location = new System.Drawing.Point(10, 10);
            this.labelIcon.Margin = new System.Windows.Forms.Padding(10);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(128, 128);
            this.labelIcon.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(26)))));
            this.labelName.Location = new System.Drawing.Point(152, 6);
            this.labelName.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(280, 37);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCopyright
            // 
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopyright.Location = new System.Drawing.Point(152, 47);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(280, 13);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright ©  2021 Vladimir Kachan";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDecription
            // 
            this.labelDecription.BackColor = System.Drawing.Color.Transparent;
            this.labelDecription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDecription.Location = new System.Drawing.Point(152, 66);
            this.labelDecription.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.labelDecription.Name = "labelDecription";
            this.labelDecription.Size = new System.Drawing.Size(280, 16);
            this.labelDecription.TabIndex = 7;
            this.labelDecription.Text = "Free software";
            this.labelDecription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(152, 88);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(67, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "email: ";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelWebsite
            // 
            this.labelWebsite.BackColor = System.Drawing.Color.Transparent;
            this.labelWebsite.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWebsite.Location = new System.Drawing.Point(152, 107);
            this.labelWebsite.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(67, 13);
            this.labelWebsite.TabIndex = 9;
            this.labelWebsite.Text = "website: ";
            this.labelWebsite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelEmail.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabelEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelEmail.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabelEmail.Location = new System.Drawing.Point(233, 88);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(199, 13);
            this.linkLabelEmail.TabIndex = 0;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "victorhulcko@gmail.com";
            this.linkLabelEmail.VisitedLinkColor = System.Drawing.Color.DarkOrange;
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked);
            // 
            // linkLabelWebsite
            // 
            this.linkLabelWebsite.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelWebsite.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelWebsite.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabelWebsite.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelWebsite.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabelWebsite.Location = new System.Drawing.Point(233, 108);
            this.linkLabelWebsite.Name = "linkLabelWebsite";
            this.linkLabelWebsite.Size = new System.Drawing.Size(199, 13);
            this.linkLabelWebsite.TabIndex = 1;
            this.linkLabelWebsite.TabStop = true;
            this.linkLabelWebsite.Text = "https://github.com/vladimirkachan/ColorMan";
            this.linkLabelWebsite.VisitedLinkColor = System.Drawing.Color.DarkOrange;
            this.linkLabelWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebsite_LinkClicked);
            // 
            // cbuttonClose
            // 
            this.cbuttonClose.ActiveBackColor = System.Drawing.Color.White;
            this.cbuttonClose.ActiveBorderColor = System.Drawing.Color.Black;
            this.cbuttonClose.ActiveForeColor = System.Drawing.Color.Green;
            this.cbuttonClose.BackColor = System.Drawing.Color.Transparent;
            this.cbuttonClose.DeactiveBackColor = System.Drawing.Color.Transparent;
            this.cbuttonClose.DeactiveBorderColor = System.Drawing.Color.Gray;
            this.cbuttonClose.DeactiveForeColor = System.Drawing.Color.DarkGreen;
            this.cbuttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cbuttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cbuttonClose.FlatAppearance.BorderSize = 2;
            this.cbuttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbuttonClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbuttonClose.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbuttonClose.LightingBackColor = System.Drawing.Color.NavajoWhite;
            this.cbuttonClose.LightingBorderColor = System.Drawing.Color.DarkGreen;
            this.cbuttonClose.Location = new System.Drawing.Point(357, 126);
            this.cbuttonClose.Name = "cbuttonClose";
            this.cbuttonClose.Size = new System.Drawing.Size(75, 23);
            this.cbuttonClose.TabIndex = 3;
            this.cbuttonClose.Text = "Close";
            this.cbuttonClose.UseVisualStyleBackColor = false;
            this.cbuttonClose.Click += new System.EventHandler(this.cbuttonClose_Click);
            // 
            // cbuttonDonate
            // 
            this.cbuttonDonate.ActiveBackColor = System.Drawing.Color.White;
            this.cbuttonDonate.ActiveBorderColor = System.Drawing.Color.Black;
            this.cbuttonDonate.ActiveForeColor = System.Drawing.Color.Green;
            this.cbuttonDonate.BackColor = System.Drawing.Color.Transparent;
            this.cbuttonDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbuttonDonate.DeactiveBackColor = System.Drawing.Color.Transparent;
            this.cbuttonDonate.DeactiveBorderColor = System.Drawing.Color.Gray;
            this.cbuttonDonate.DeactiveForeColor = System.Drawing.Color.DarkGreen;
            this.cbuttonDonate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cbuttonDonate.FlatAppearance.BorderSize = 2;
            this.cbuttonDonate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbuttonDonate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbuttonDonate.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbuttonDonate.Image = global::ColorMan.FormLibrary.Properties.Resources.vova_logo;
            this.cbuttonDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbuttonDonate.LightingBackColor = System.Drawing.Color.NavajoWhite;
            this.cbuttonDonate.LightingBorderColor = System.Drawing.Color.DarkGreen;
            this.cbuttonDonate.Location = new System.Drawing.Point(152, 126);
            this.cbuttonDonate.Name = "cbuttonDonate";
            this.cbuttonDonate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cbuttonDonate.Size = new System.Drawing.Size(126, 23);
            this.cbuttonDonate.TabIndex = 2;
            this.cbuttonDonate.Text = "Donate";
            this.cbuttonDonate.UseVisualStyleBackColor = false;
            this.cbuttonDonate.Click += new System.EventHandler(this.cbuttonDonate_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ColorMan.FormLibrary.Properties.Resources.bg1;
            this.CancelButton = this.cbuttonClose;
            this.ClientSize = new System.Drawing.Size(444, 157);
            this.Controls.Add(this.cbuttonClose);
            this.Controls.Add(this.cbuttonDonate);
            this.Controls.Add(this.linkLabelWebsite);
            this.Controls.Add(this.linkLabelEmail);
            this.Controls.Add(this.labelWebsite);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDecription);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "caption";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelDecription;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.LinkLabel linkLabelWebsite;
        private ColorMan.ControlsLibrary.Cbutton cbuttonDonate;
        private ColorMan.ControlsLibrary.Cbutton cbuttonClose;
    }
}