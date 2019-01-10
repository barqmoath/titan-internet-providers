namespace Titan_Internet_Providers.Page.Separated.Backup_Page
{
    partial class BackupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupPage));
            this.PageHead = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NewBackup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Restor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PageHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PageHead
            // 
            this.PageHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PageHead.Controls.Add(this.btn_Exit);
            this.PageHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageHead.Location = new System.Drawing.Point(0, 0);
            this.PageHead.Name = "PageHead";
            this.PageHead.Size = new System.Drawing.Size(456, 30);
            this.PageHead.TabIndex = 1;
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
            this.btn_Exit.Location = new System.Drawing.Point(418, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(38, 30);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(451, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 108);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 108);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 5);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(327, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "النسخ الاحتياطي من اجل عدم فقدان البيانات والندم لاحــقا";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NewBackup
            // 
            this.btn_NewBackup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_NewBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_NewBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NewBackup.BorderRadius = 5;
            this.btn_NewBackup.ButtonText = "نسخ البيانات";
            this.btn_NewBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewBackup.DisabledColor = System.Drawing.Color.Gray;
            this.btn_NewBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_NewBackup.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_NewBackup.Iconimage = null;
            this.btn_NewBackup.Iconimage_right = null;
            this.btn_NewBackup.Iconimage_right_Selected = null;
            this.btn_NewBackup.Iconimage_Selected = null;
            this.btn_NewBackup.IconMarginLeft = 0;
            this.btn_NewBackup.IconMarginRight = 0;
            this.btn_NewBackup.IconRightVisible = true;
            this.btn_NewBackup.IconRightZoom = 0D;
            this.btn_NewBackup.IconVisible = true;
            this.btn_NewBackup.IconZoom = 90D;
            this.btn_NewBackup.IsTab = false;
            this.btn_NewBackup.Location = new System.Drawing.Point(181, 82);
            this.btn_NewBackup.Name = "btn_NewBackup";
            this.btn_NewBackup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_NewBackup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_NewBackup.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_NewBackup.selected = false;
            this.btn_NewBackup.Size = new System.Drawing.Size(137, 44);
            this.btn_NewBackup.TabIndex = 7;
            this.btn_NewBackup.Text = "نسخ البيانات";
            this.btn_NewBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_NewBackup.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_NewBackup.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_NewBackup.Click += new System.EventHandler(this.btn_NewBackup_Click);
            // 
            // btn_Restor
            // 
            this.btn_Restor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Restor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Restor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Restor.BorderRadius = 5;
            this.btn_Restor.ButtonText = "استعاده البيانات";
            this.btn_Restor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Restor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Restor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Restor.Iconimage = null;
            this.btn_Restor.Iconimage_right = null;
            this.btn_Restor.Iconimage_right_Selected = null;
            this.btn_Restor.Iconimage_Selected = null;
            this.btn_Restor.IconMarginLeft = 0;
            this.btn_Restor.IconMarginRight = 0;
            this.btn_Restor.IconRightVisible = true;
            this.btn_Restor.IconRightZoom = 0D;
            this.btn_Restor.IconVisible = true;
            this.btn_Restor.IconZoom = 90D;
            this.btn_Restor.IsTab = false;
            this.btn_Restor.Location = new System.Drawing.Point(38, 82);
            this.btn_Restor.Name = "btn_Restor";
            this.btn_Restor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Restor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Restor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Restor.selected = false;
            this.btn_Restor.Size = new System.Drawing.Size(137, 44);
            this.btn_Restor.TabIndex = 8;
            this.btn_Restor.Text = "استعاده البيانات";
            this.btn_Restor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Restor.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_Restor.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Restor.Click += new System.EventHandler(this.btn_Restor_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PageHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BackupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 138);
            this.Controls.Add(this.btn_Restor);
            this.Controls.Add(this.btn_NewBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PageHead);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(456, 138);
            this.MinimumSize = new System.Drawing.Size(456, 138);
            this.Name = "BackupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PageHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PageHead;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_NewBackup;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Restor;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}