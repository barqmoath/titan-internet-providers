namespace Titan_Internet_Providers.Page.Separated.UsersPage
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PageHead = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGV_User = new System.Windows.Forms.DataGridView();
            this.txt_UserName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Password = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NewUser = new System.Windows.Forms.Button();
            this.btn_SaveUser = new System.Windows.Forms.Button();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.btn_DeletUser = new System.Windows.Forms.Button();
            this.Checkbox_ShowPAss = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PageHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_User)).BeginInit();
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
            this.PageHead.Size = new System.Drawing.Size(679, 30);
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
            this.btn_Exit.Location = new System.Drawing.Point(638, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(41, 30);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(674, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 313);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 313);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 5);
            this.panel3.TabIndex = 4;
            // 
            // DGV_User
            // 
            this.DGV_User.AllowUserToAddRows = false;
            this.DGV_User.AllowUserToDeleteRows = false;
            this.DGV_User.AllowUserToResizeRows = false;
            this.DGV_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_User.BackgroundColor = System.Drawing.Color.White;
            this.DGV_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGV_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_User.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_User.Location = new System.Drawing.Point(5, 30);
            this.DGV_User.MultiSelect = false;
            this.DGV_User.Name = "DGV_User";
            this.DGV_User.ReadOnly = true;
            this.DGV_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_User.RowHeadersVisible = false;
            this.DGV_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_User.Size = new System.Drawing.Size(438, 305);
            this.DGV_User.TabIndex = 5;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BorderColor = System.Drawing.Color.Gray;
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_UserName.Location = new System.Drawing.Point(449, 36);
            this.txt_UserName.MaxLength = 50;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_UserName.Size = new System.Drawing.Size(120, 23);
            this.txt_UserName.TabIndex = 15;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(569, 36);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "اسم المستخدم";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderColor = System.Drawing.Color.Gray;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Password.Location = new System.Drawing.Point(449, 65);
            this.txt_Password.MaxLength = 50;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Password.Size = new System.Drawing.Size(120, 23);
            this.txt_Password.TabIndex = 17;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(569, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "كلمه السر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "admin",
            "user",
            "casher"});
            this.cmb_type.Location = new System.Drawing.Point(449, 94);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_type.Size = new System.Drawing.Size(120, 23);
            this.cmb_type.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(569, 94);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "نوع المستخدم";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_NewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewUser.FlatAppearance.BorderSize = 0;
            this.btn_NewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_NewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_NewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewUser.ForeColor = System.Drawing.Color.White;
            this.btn_NewUser.Location = new System.Drawing.Point(563, 264);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_NewUser.Size = new System.Drawing.Size(98, 29);
            this.btn_NewUser.TabIndex = 24;
            this.btn_NewUser.Text = "مستخدم جديد";
            this.btn_NewUser.UseVisualStyleBackColor = false;
            this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
            // 
            // btn_SaveUser
            // 
            this.btn_SaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_SaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveUser.Enabled = false;
            this.btn_SaveUser.FlatAppearance.BorderSize = 0;
            this.btn_SaveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_SaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_SaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveUser.ForeColor = System.Drawing.Color.White;
            this.btn_SaveUser.Location = new System.Drawing.Point(459, 264);
            this.btn_SaveUser.Name = "btn_SaveUser";
            this.btn_SaveUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_SaveUser.Size = new System.Drawing.Size(98, 29);
            this.btn_SaveUser.TabIndex = 25;
            this.btn_SaveUser.Text = "حفظ المستخدم";
            this.btn_SaveUser.UseVisualStyleBackColor = false;
            this.btn_SaveUser.Click += new System.EventHandler(this.btn_SaveUser_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_EditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditUser.FlatAppearance.BorderSize = 0;
            this.btn_EditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_EditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditUser.ForeColor = System.Drawing.Color.White;
            this.btn_EditUser.Location = new System.Drawing.Point(563, 299);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_EditUser.Size = new System.Drawing.Size(98, 29);
            this.btn_EditUser.TabIndex = 26;
            this.btn_EditUser.Text = "حفظ التعديلات";
            this.btn_EditUser.UseVisualStyleBackColor = false;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_DeletUser
            // 
            this.btn_DeletUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btn_DeletUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeletUser.FlatAppearance.BorderSize = 0;
            this.btn_DeletUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_DeletUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_DeletUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeletUser.ForeColor = System.Drawing.Color.White;
            this.btn_DeletUser.Location = new System.Drawing.Point(459, 299);
            this.btn_DeletUser.Name = "btn_DeletUser";
            this.btn_DeletUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_DeletUser.Size = new System.Drawing.Size(98, 29);
            this.btn_DeletUser.TabIndex = 27;
            this.btn_DeletUser.Text = "حذف المستخدم";
            this.btn_DeletUser.UseVisualStyleBackColor = false;
            this.btn_DeletUser.Click += new System.EventHandler(this.btn_DeletUser_Click);
            // 
            // Checkbox_ShowPAss
            // 
            this.Checkbox_ShowPAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_ShowPAss.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_ShowPAss.Checked = false;
            this.Checkbox_ShowPAss.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_ShowPAss.ForeColor = System.Drawing.Color.White;
            this.Checkbox_ShowPAss.Location = new System.Drawing.Point(638, 130);
            this.Checkbox_ShowPAss.Name = "Checkbox_ShowPAss";
            this.Checkbox_ShowPAss.Size = new System.Drawing.Size(20, 20);
            this.Checkbox_ShowPAss.TabIndex = 28;
            this.Checkbox_ShowPAss.OnChange += new System.EventHandler(this.Checkbox_ShowPAss_OnChange);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(464, 130);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "اظهار كلمه المرور";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Checkbox_ShowPAss);
            this.Controls.Add(this.btn_DeletUser);
            this.Controls.Add(this.btn_EditUser);
            this.Controls.Add(this.btn_SaveUser);
            this.Controls.Add(this.btn_NewUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DGV_User);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PageHead);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(679, 343);
            this.MinimumSize = new System.Drawing.Size(679, 343);
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.PageHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PageHead;
        private System.Windows.Forms.Button btn_Exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_type;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Password;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_UserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_DeletUser;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_SaveUser;
        private System.Windows.Forms.Button btn_NewUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox_ShowPAss;
    }
}