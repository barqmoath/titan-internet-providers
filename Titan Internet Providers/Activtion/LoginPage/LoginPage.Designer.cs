namespace Titan_Internet_Providers.Activtion.LoginPage
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ConnectionSetting = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_Login
            // 
            this.btn_Login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Login.BorderRadius = 5;
            this.btn_Login.ButtonText = "دخــول";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Login.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Login.Iconimage")));
            this.btn_Login.Iconimage_right = null;
            this.btn_Login.Iconimage_right_Selected = null;
            this.btn_Login.Iconimage_Selected = null;
            this.btn_Login.IconMarginLeft = 0;
            this.btn_Login.IconMarginRight = 0;
            this.btn_Login.IconRightVisible = false;
            this.btn_Login.IconRightZoom = 0D;
            this.btn_Login.IconVisible = false;
            this.btn_Login.IconZoom = 90D;
            this.btn_Login.IsTab = false;
            this.btn_Login.Location = new System.Drawing.Point(343, 231);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.btn_Login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Login.selected = false;
            this.btn_Login.Size = new System.Drawing.Size(91, 41);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "دخــول";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Textcolor = System.Drawing.Color.White;
            this.btn_Login.TextFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Password.HintForeColor = System.Drawing.Color.DarkGray;
            this.txt_Password.HintText = "كلمه المرور";
            this.txt_Password.isPassword = false;
            this.txt_Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.txt_Password.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.txt_Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.txt_Password.LineThickness = 3;
            this.txt_Password.Location = new System.Drawing.Point(197, 151);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(295, 34);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.btn_Login);
            this.panel2.Controls.Add(this.linkLabel_ConnectionSetting);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Controls.Add(this.txt_Username);
            this.panel2.Location = new System.Drawing.Point(250, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 384);
            this.panel2.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.BorderRadius = 5;
            this.btn_Close.ButtonText = "غــادر";
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Close.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Close.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Close.Iconimage")));
            this.btn_Close.Iconimage_right = null;
            this.btn_Close.Iconimage_right_Selected = null;
            this.btn_Close.Iconimage_Selected = null;
            this.btn_Close.IconMarginLeft = 0;
            this.btn_Close.IconMarginRight = 0;
            this.btn_Close.IconRightVisible = false;
            this.btn_Close.IconRightZoom = 0D;
            this.btn_Close.IconVisible = false;
            this.btn_Close.IconZoom = 90D;
            this.btn_Close.IsTab = false;
            this.btn_Close.Location = new System.Drawing.Point(246, 231);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.btn_Close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Close.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Close.selected = false;
            this.btn_Close.Size = new System.Drawing.Size(91, 41);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "غــادر";
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Close.Textcolor = System.Drawing.Color.White;
            this.btn_Close.TextFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.linkLabel1.Location = new System.Drawing.Point(536, 354);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 19);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "مساعده";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel_ConnectionSetting
            // 
            this.linkLabel_ConnectionSetting.AutoSize = true;
            this.linkLabel_ConnectionSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_ConnectionSetting.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_ConnectionSetting.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.linkLabel_ConnectionSetting.Location = new System.Drawing.Point(597, 354);
            this.linkLabel_ConnectionSetting.Name = "linkLabel_ConnectionSetting";
            this.linkLabel_ConnectionSetting.Size = new System.Drawing.Size(88, 19);
            this.linkLabel_ConnectionSetting.TabIndex = 4;
            this.linkLabel_ConnectionSetting.TabStop = true;
            this.linkLabel_ConnectionSetting.Text = "اعداد الاتصال";
            this.linkLabel_ConnectionSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ConnectionSetting_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(692, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Username
            // 
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.HintForeColor = System.Drawing.Color.DarkGray;
            this.txt_Username.HintText = "اسم المستخدم";
            this.txt_Username.isPassword = false;
            this.txt_Username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.txt_Username.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.txt_Username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.txt_Username.LineThickness = 3;
            this.txt_Username.Location = new System.Drawing.Point(197, 109);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(295, 34);
            this.txt_Username.TabIndex = 0;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(244)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1242, 122);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome in Titan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(0, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Copyright (c) 2017 Barq Al-Tai Software";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1242, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_ConnectionSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_Username;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_Password;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Close;
    }
}