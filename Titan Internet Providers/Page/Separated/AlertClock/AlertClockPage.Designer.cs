namespace Titan_Internet_Providers.Page.Separated.AlertClock
{
    partial class AlertClockPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertClockPage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PageHead = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_NowTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.DatePickerTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_ChangeTone = new System.Windows.Forms.Button();
            this.lbl_State = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TimerNowTime = new System.Windows.Forms.Timer(this.components);
            this.TimerAlert = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_TimeAlert = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NOTS = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.PageHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TimeAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PageHead
            // 
            this.PageHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PageHead.Controls.Add(this.btn_TimeAlert);
            this.PageHead.Controls.Add(this.btn_Exit);
            this.PageHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageHead.Location = new System.Drawing.Point(0, 0);
            this.PageHead.Name = "PageHead";
            this.PageHead.Size = new System.Drawing.Size(500, 30);
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
            this.btn_Exit.Location = new System.Drawing.Point(461, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(39, 30);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_NowTime
            // 
            this.lbl_NowTime.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl_NowTime.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_NowTime.Location = new System.Drawing.Point(12, 33);
            this.lbl_NowTime.Name = "lbl_NowTime";
            this.lbl_NowTime.Size = new System.Drawing.Size(476, 81);
            this.lbl_NowTime.TabIndex = 2;
            this.lbl_NowTime.Text = "00 : 00 : 00";
            this.lbl_NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(0, 121);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(500, 17);
            this.bunifuSeparator4.TabIndex = 19;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // DatePickerTime
            // 
            this.DatePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DatePickerTime.Location = new System.Drawing.Point(258, 145);
            this.DatePickerTime.Name = "DatePickerTime";
            this.DatePickerTime.ShowUpDown = true;
            this.DatePickerTime.Size = new System.Drawing.Size(124, 25);
            this.DatePickerTime.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(380, 145);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "وقت التنبيه";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(372, 229);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Start.Size = new System.Drawing.Size(108, 32);
            this.btn_Start.TabIndex = 26;
            this.btn_Start.Text = "تشغيل المنبه";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(258, 229);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Stop.Size = new System.Drawing.Size(108, 32);
            this.btn_Stop.TabIndex = 27;
            this.btn_Stop.Text = "ايقاف المنبه";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_ChangeTone
            // 
            this.btn_ChangeTone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ChangeTone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeTone.FlatAppearance.BorderSize = 0;
            this.btn_ChangeTone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_ChangeTone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_ChangeTone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeTone.ForeColor = System.Drawing.Color.White;
            this.btn_ChangeTone.Location = new System.Drawing.Point(19, 229);
            this.btn_ChangeTone.Name = "btn_ChangeTone";
            this.btn_ChangeTone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_ChangeTone.Size = new System.Drawing.Size(108, 32);
            this.btn_ChangeTone.TabIndex = 28;
            this.btn_ChangeTone.Text = "تغيير النغـمه";
            this.btn_ChangeTone.UseVisualStyleBackColor = false;
            this.btn_ChangeTone.Click += new System.EventHandler(this.btn_ChangeTone_Click);
            // 
            // lbl_State
            // 
            this.lbl_State.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_State.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_State.Location = new System.Drawing.Point(20, 145);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(232, 25);
            this.lbl_State.TabIndex = 29;
            this.lbl_State.Text = "اختر وقــتا للتنبيه";
            this.lbl_State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerNowTime
            // 
            this.TimerNowTime.Enabled = true;
            this.TimerNowTime.Interval = 1000;
            this.TimerNowTime.Tick += new System.EventHandler(this.TimerNowTime_Tick);
            // 
            // TimerAlert
            // 
            this.TimerAlert.Interval = 1000;
            this.TimerAlert.Tick += new System.EventHandler(this.TimerAlert_Tick);
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.PageHead;
            this.bunifuDragControl.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(495, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 243);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 243);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 5);
            this.panel3.TabIndex = 32;
            // 
            // btn_TimeAlert
            // 
            this.btn_TimeAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_TimeAlert.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_TimeAlert.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimeAlert.Image")));
            this.btn_TimeAlert.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_TimeAlert.ImageActive")));
            this.btn_TimeAlert.Location = new System.Drawing.Point(5, 0);
            this.btn_TimeAlert.Name = "btn_TimeAlert";
            this.btn_TimeAlert.Size = new System.Drawing.Size(40, 30);
            this.btn_TimeAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_TimeAlert.TabIndex = 33;
            this.btn_TimeAlert.TabStop = false;
            this.btn_TimeAlert.Zoom = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 176);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(106, 47);
            this.label1.TabIndex = 33;
            this.label1.Text = "ملاحضاتك";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_NOTS
            // 
            this.txt_NOTS.BorderColor = System.Drawing.Color.Gray;
            this.txt_NOTS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NOTS.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_NOTS.Location = new System.Drawing.Point(19, 176);
            this.txt_NOTS.MaxLength = 100;
            this.txt_NOTS.Multiline = true;
            this.txt_NOTS.Name = "txt_NOTS";
            this.txt_NOTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_NOTS.Size = new System.Drawing.Size(363, 47);
            this.txt_NOTS.TabIndex = 34;
            this.txt_NOTS.Text = "اكتب ملاحضاتك هنا";
            this.txt_NOTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlertClockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 273);
            this.Controls.Add(this.txt_NOTS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.btn_ChangeTone);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DatePickerTime);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.lbl_NowTime);
            this.Controls.Add(this.PageHead);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertClockPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PageHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_TimeAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Panel PageHead;
        private System.Windows.Forms.Button btn_Exit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_NowTime;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer TimerNowTime;
        public System.Windows.Forms.Timer TimerAlert;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_State;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_TimeAlert;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker DatePickerTime;
        public System.Windows.Forms.Button btn_Stop;
        public System.Windows.Forms.Button btn_Start;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txt_NOTS;
        public System.Windows.Forms.Button btn_ChangeTone;
    }
}