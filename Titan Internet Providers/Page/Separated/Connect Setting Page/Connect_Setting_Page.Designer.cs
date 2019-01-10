namespace Titan_Internet_Providers.Page.Separated.Connect_Setting_Page
{
    partial class Connect_Setting_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect_Setting_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Server = new System.Windows.Forms.TextBox();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_SQL = new System.Windows.Forms.RadioButton();
            this.RB_Windows = new System.Windows.Forms.RadioButton();
            this.PageHead = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_SQL = new System.Windows.Forms.GroupBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_SQL2 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.lbl_SQL = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Defult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.PageHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_SQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "اعداد الاتصال";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(336, 36);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "الخــادم :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Server
            // 
            this.txt_Server.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Server.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_Server.Location = new System.Drawing.Point(201, 36);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(133, 22);
            this.txt_Server.TabIndex = 3;
            this.txt_Server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Database
            // 
            this.txt_Database.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Database.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_Database.Location = new System.Drawing.Point(201, 66);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(133, 22);
            this.txt_Database.TabIndex = 5;
            this.txt_Database.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(336, 66);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "قاعده البيانات :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_SQL);
            this.groupBox1.Controls.Add(this.RB_Windows);
            this.groupBox1.Location = new System.Drawing.Point(201, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(217, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع الوصول";
            // 
            // RB_SQL
            // 
            this.RB_SQL.AutoSize = true;
            this.RB_SQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_SQL.Location = new System.Drawing.Point(78, 44);
            this.RB_SQL.Name = "RB_SQL";
            this.RB_SQL.Size = new System.Drawing.Size(133, 17);
            this.RB_SQL.TabIndex = 1;
            this.RB_SQL.Text = "ألوصول عبر حساب SQL";
            this.RB_SQL.UseVisualStyleBackColor = true;
            this.RB_SQL.CheckedChanged += new System.EventHandler(this.RB_SQL_CheckedChanged);
            // 
            // RB_Windows
            // 
            this.RB_Windows.AutoSize = true;
            this.RB_Windows.Checked = true;
            this.RB_Windows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_Windows.Location = new System.Drawing.Point(76, 21);
            this.RB_Windows.Name = "RB_Windows";
            this.RB_Windows.Size = new System.Drawing.Size(135, 17);
            this.RB_Windows.TabIndex = 0;
            this.RB_Windows.TabStop = true;
            this.RB_Windows.Text = "الوصول عبر  Windows";
            this.RB_Windows.UseVisualStyleBackColor = true;
            this.RB_Windows.CheckedChanged += new System.EventHandler(this.RB_Windows_CheckedChanged);
            // 
            // PageHead
            // 
            this.PageHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PageHead.Controls.Add(this.btn_Exit);
            this.PageHead.Controls.Add(this.label1);
            this.PageHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageHead.Location = new System.Drawing.Point(0, 0);
            this.PageHead.Name = "PageHead";
            this.PageHead.Size = new System.Drawing.Size(432, 30);
            this.PageHead.TabIndex = 7;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(393, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(39, 30);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_SQL
            // 
            this.groupBox_SQL.Controls.Add(this.txt_Password);
            this.groupBox_SQL.Controls.Add(this.lbl_SQL2);
            this.groupBox_SQL.Controls.Add(this.txt_UserID);
            this.groupBox_SQL.Controls.Add(this.lbl_SQL);
            this.groupBox_SQL.Enabled = false;
            this.groupBox_SQL.Location = new System.Drawing.Point(13, 176);
            this.groupBox_SQL.Name = "groupBox_SQL";
            this.groupBox_SQL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_SQL.Size = new System.Drawing.Size(405, 55);
            this.groupBox_SQL.TabIndex = 9;
            this.groupBox_SQL.TabStop = false;
            this.groupBox_SQL.Text = "معلومات الدخول عبر حساب SQL";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Password.Enabled = false;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_Password.Location = new System.Drawing.Point(10, 21);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(102, 22);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_SQL2
            // 
            this.lbl_SQL2.Enabled = false;
            this.lbl_SQL2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_SQL2.Location = new System.Drawing.Point(113, 21);
            this.lbl_SQL2.Name = "lbl_SQL2";
            this.lbl_SQL2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SQL2.Size = new System.Drawing.Size(73, 22);
            this.lbl_SQL2.TabIndex = 6;
            this.lbl_SQL2.Text = "كلمه المرور :";
            this.lbl_SQL2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_UserID.Enabled = false;
            this.txt_UserID.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_UserID.Location = new System.Drawing.Point(208, 21);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(102, 22);
            this.txt_UserID.TabIndex = 5;
            this.txt_UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_SQL
            // 
            this.lbl_SQL.Enabled = false;
            this.lbl_SQL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_SQL.Location = new System.Drawing.Point(311, 21);
            this.lbl_SQL.Name = "lbl_SQL";
            this.lbl_SQL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SQL.Size = new System.Drawing.Size(88, 22);
            this.lbl_SQL.TabIndex = 4;
            this.lbl_SQL.Text = "اسم المستخدم :";
            this.lbl_SQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.Location = new System.Drawing.Point(343, 237);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "حفـظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancel.Location = new System.Drawing.Point(262, 237);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Defult
            // 
            this.btn_Defult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Defult.Location = new System.Drawing.Point(13, 237);
            this.btn_Defult.Name = "btn_Defult";
            this.btn_Defult.Size = new System.Drawing.Size(90, 23);
            this.btn_Defult.TabIndex = 12;
            this.btn_Defult.Text = "افتراضي >>";
            this.btn_Defult.UseVisualStyleBackColor = true;
            this.btn_Defult.Click += new System.EventHandler(this.btn_Defult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 3);
            this.panel1.TabIndex = 13;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PageHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(186, 237);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 14;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(429, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 239);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 239);
            this.panel3.TabIndex = 16;
            // 
            // Connect_Setting_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(432, 272);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Defult);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox_SQL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PageHead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Database);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Server);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(432, 272);
            this.Name = "Connect_Setting_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PageHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_SQL.ResumeLayout(false);
            this.groupBox_SQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Server;
        private System.Windows.Forms.TextBox txt_Database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_SQL;
        private System.Windows.Forms.RadioButton RB_Windows;
        public System.Windows.Forms.Panel PageHead;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_SQL;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_SQL2;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label lbl_SQL;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Defult;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}