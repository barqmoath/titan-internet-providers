namespace Titan_Internet_Providers.Page.Concerted.PersonStatusPage
{
    partial class PersonStatusPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonStatusPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PageHead = new System.Windows.Forms.Panel();
            this.btn_Update = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_DefultSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_ShowAll = new System.Windows.Forms.RadioButton();
            this.RB_Ended = new System.Windows.Forms.RadioButton();
            this.RB_ShowActiveOnly = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGV_PersonStatus = new System.Windows.Forms.DataGridView();
            this.RB_EndedToday = new System.Windows.Forms.RadioButton();
            this.RB_ShowStartedTody = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_ShowColorAlert = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Counter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ActiveStateCount = new System.Windows.Forms.Label();
            this.lbl_NotActiveStateCount = new System.Windows.Forms.Label();
            this.Lebel10 = new System.Windows.Forms.Label();
            this.SwithCounter = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.lbl = new System.Windows.Forms.Label();
            this.PageHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Update)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DefultSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PersonStatus)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox_Counter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageHead
            // 
            this.PageHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PageHead.Controls.Add(this.btn_Update);
            this.PageHead.Controls.Add(this.panel4);
            this.PageHead.Controls.Add(this.panel1);
            this.PageHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageHead.Location = new System.Drawing.Point(0, 0);
            this.PageHead.Name = "PageHead";
            this.PageHead.Size = new System.Drawing.Size(1206, 35);
            this.PageHead.TabIndex = 1;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageActive")));
            this.btn_Update.Location = new System.Drawing.Point(3, 0);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(40, 35);
            this.btn_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Update.TabIndex = 8;
            this.btn_Update.TabStop = false;
            this.btn_Update.Zoom = 0;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_DefultSearch);
            this.panel4.Controls.Add(this.txt_Search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(561, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 35);
            this.panel4.TabIndex = 2;
            // 
            // btn_DefultSearch
            // 
            this.btn_DefultSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_DefultSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DefultSearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_DefultSearch.Image")));
            this.btn_DefultSearch.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_DefultSearch.ImageActive")));
            this.btn_DefultSearch.Location = new System.Drawing.Point(379, 2);
            this.btn_DefultSearch.Name = "btn_DefultSearch";
            this.btn_DefultSearch.Size = new System.Drawing.Size(25, 24);
            this.btn_DefultSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_DefultSearch.TabIndex = 10;
            this.btn_DefultSearch.TabStop = false;
            this.btn_DefultSearch.Zoom = 0;
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Search.HintForeColor = System.Drawing.Color.Gray;
            this.txt_Search.HintText = "";
            this.txt_Search.isPassword = false;
            this.txt_Search.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txt_Search.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Search.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txt_Search.LineThickness = 1;
            this.txt_Search.Location = new System.Drawing.Point(4, 4);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Search.Size = new System.Drawing.Size(400, 28);
            this.txt_Search.TabIndex = 9;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_GoBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(970, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 35);
            this.panel1.TabIndex = 2;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GoBack.BackgroundImage")));
            this.btn_GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_GoBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_GoBack.FlatAppearance.BorderSize = 0;
            this.btn_GoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btn_GoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btn_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoBack.Location = new System.Drawing.Point(193, 0);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(43, 35);
            this.btn_GoBack.TabIndex = 5;
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox_Counter);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(970, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 466);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_ShowStartedTody);
            this.groupBox1.Controls.Add(this.RB_EndedToday);
            this.groupBox1.Controls.Add(this.RB_ShowAll);
            this.groupBox1.Controls.Add(this.RB_Ended);
            this.groupBox1.Controls.Add(this.RB_ShowActiveOnly);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(228, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العرض";
            // 
            // RB_ShowAll
            // 
            this.RB_ShowAll.AutoSize = true;
            this.RB_ShowAll.Checked = true;
            this.RB_ShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_ShowAll.Location = new System.Drawing.Point(84, 24);
            this.RB_ShowAll.Name = "RB_ShowAll";
            this.RB_ShowAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RB_ShowAll.Size = new System.Drawing.Size(139, 23);
            this.RB_ShowAll.TabIndex = 1;
            this.RB_ShowAll.TabStop = true;
            this.RB_ShowAll.Text = "عرض جميع الحالات";
            this.RB_ShowAll.UseVisualStyleBackColor = true;
            this.RB_ShowAll.CheckedChanged += new System.EventHandler(this.RB_ShowAll_CheckedChanged);
            // 
            // RB_Ended
            // 
            this.RB_Ended.AutoSize = true;
            this.RB_Ended.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_Ended.Location = new System.Drawing.Point(20, 87);
            this.RB_Ended.Name = "RB_Ended";
            this.RB_Ended.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RB_Ended.Size = new System.Drawing.Size(203, 23);
            this.RB_Ended.TabIndex = 2;
            this.RB_Ended.Text = "عرض الحالات الغير فعاله فقط";
            this.RB_Ended.UseVisualStyleBackColor = true;
            this.RB_Ended.CheckedChanged += new System.EventHandler(this.RB_Ended_CheckedChanged);
            // 
            // RB_ShowActiveOnly
            // 
            this.RB_ShowActiveOnly.AutoSize = true;
            this.RB_ShowActiveOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_ShowActiveOnly.Location = new System.Drawing.Point(43, 58);
            this.RB_ShowActiveOnly.Name = "RB_ShowActiveOnly";
            this.RB_ShowActiveOnly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RB_ShowActiveOnly.Size = new System.Drawing.Size(180, 23);
            this.RB_ShowActiveOnly.TabIndex = 0;
            this.RB_ShowActiveOnly.Text = "عرض الحالات الفعاله فقط";
            this.RB_ShowActiveOnly.UseVisualStyleBackColor = true;
            this.RB_ShowActiveOnly.CheckedChanged += new System.EventHandler(this.RB_ShowActiveOnly_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DGV_PersonStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 466);
            this.panel3.TabIndex = 3;
            // 
            // DGV_PersonStatus
            // 
            this.DGV_PersonStatus.AllowUserToAddRows = false;
            this.DGV_PersonStatus.AllowUserToDeleteRows = false;
            this.DGV_PersonStatus.AllowUserToResizeRows = false;
            this.DGV_PersonStatus.BackgroundColor = System.Drawing.Color.White;
            this.DGV_PersonStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PersonStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_PersonStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PersonStatus.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_PersonStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PersonStatus.Location = new System.Drawing.Point(0, 0);
            this.DGV_PersonStatus.MultiSelect = false;
            this.DGV_PersonStatus.Name = "DGV_PersonStatus";
            this.DGV_PersonStatus.ReadOnly = true;
            this.DGV_PersonStatus.RowHeadersVisible = false;
            this.DGV_PersonStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PersonStatus.Size = new System.Drawing.Size(968, 464);
            this.DGV_PersonStatus.TabIndex = 1;
            // 
            // RB_EndedToday
            // 
            this.RB_EndedToday.AutoSize = true;
            this.RB_EndedToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_EndedToday.Location = new System.Drawing.Point(25, 125);
            this.RB_EndedToday.Name = "RB_EndedToday";
            this.RB_EndedToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RB_EndedToday.Size = new System.Drawing.Size(198, 23);
            this.RB_EndedToday.TabIndex = 3;
            this.RB_EndedToday.Text = "عرض الذي سوف تنتهي اليوم";
            this.RB_EndedToday.UseVisualStyleBackColor = true;
            this.RB_EndedToday.CheckedChanged += new System.EventHandler(this.RB_EndedToday_CheckedChanged);
            // 
            // RB_ShowStartedTody
            // 
            this.RB_ShowStartedTody.AutoSize = true;
            this.RB_ShowStartedTody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_ShowStartedTody.Location = new System.Drawing.Point(38, 154);
            this.RB_ShowStartedTody.Name = "RB_ShowStartedTody";
            this.RB_ShowStartedTody.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RB_ShowStartedTody.Size = new System.Drawing.Size(185, 23);
            this.RB_ShowStartedTody.TabIndex = 5;
            this.RB_ShowStartedTody.Text = "عرض الذي تم تفعيلها اليوم";
            this.RB_ShowStartedTody.UseVisualStyleBackColor = true;
            this.RB_ShowStartedTody.CheckedChanged += new System.EventHandler(this.RB_ShowStartedTody_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.SwithCounter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox_ShowColorAlert);
            this.groupBox2.Location = new System.Drawing.Point(3, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(228, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بعض الاعدادات";
            // 
            // checkBox_ShowColorAlert
            // 
            this.checkBox_ShowColorAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(186)))), ((int)(((byte)(76)))));
            this.checkBox_ShowColorAlert.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(186)))), ((int)(((byte)(76)))));
            this.checkBox_ShowColorAlert.Checked = false;
            this.checkBox_ShowColorAlert.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(186)))), ((int)(((byte)(76)))));
            this.checkBox_ShowColorAlert.ForeColor = System.Drawing.Color.White;
            this.checkBox_ShowColorAlert.Location = new System.Drawing.Point(200, 25);
            this.checkBox_ShowColorAlert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_ShowColorAlert.Name = "checkBox_ShowColorAlert";
            this.checkBox_ShowColorAlert.Size = new System.Drawing.Size(20, 20);
            this.checkBox_ShowColorAlert.TabIndex = 1;
            this.checkBox_ShowColorAlert.OnChange += new System.EventHandler(this.checkBox_ShowColorAlert_OnChange);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(188, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "تشغيل اشعارات الالوان على لوحه العرض";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox_Counter
            // 
            this.groupBox_Counter.Controls.Add(this.lbl_NotActiveStateCount);
            this.groupBox_Counter.Controls.Add(this.Lebel10);
            this.groupBox_Counter.Controls.Add(this.lbl_ActiveStateCount);
            this.groupBox_Counter.Controls.Add(this.label2);
            this.groupBox_Counter.Location = new System.Drawing.Point(3, 331);
            this.groupBox_Counter.Name = "groupBox_Counter";
            this.groupBox_Counter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_Counter.Size = new System.Drawing.Size(228, 88);
            this.groupBox_Counter.TabIndex = 5;
            this.groupBox_Counter.TabStop = false;
            this.groupBox_Counter.Text = "احصائيات";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(78, 21);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "عدد الاشتراكات الفعاله        :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ActiveStateCount
            // 
            this.lbl_ActiveStateCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_ActiveStateCount.Location = new System.Drawing.Point(6, 21);
            this.lbl_ActiveStateCount.Name = "lbl_ActiveStateCount";
            this.lbl_ActiveStateCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ActiveStateCount.Size = new System.Drawing.Size(66, 28);
            this.lbl_ActiveStateCount.TabIndex = 4;
            this.lbl_ActiveStateCount.Text = "0";
            this.lbl_ActiveStateCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NotActiveStateCount
            // 
            this.lbl_NotActiveStateCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_NotActiveStateCount.Location = new System.Drawing.Point(6, 49);
            this.lbl_NotActiveStateCount.Name = "lbl_NotActiveStateCount";
            this.lbl_NotActiveStateCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_NotActiveStateCount.Size = new System.Drawing.Size(66, 28);
            this.lbl_NotActiveStateCount.TabIndex = 6;
            this.lbl_NotActiveStateCount.Text = "0";
            this.lbl_NotActiveStateCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lebel10
            // 
            this.Lebel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lebel10.Location = new System.Drawing.Point(78, 49);
            this.Lebel10.Name = "Lebel10";
            this.Lebel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lebel10.Size = new System.Drawing.Size(145, 28);
            this.Lebel10.TabIndex = 5;
            this.Lebel10.Text = "عدد الاشتراكات الغير فعاله :";
            this.Lebel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwithCounter
            // 
            this.SwithCounter.BackColor = System.Drawing.Color.Transparent;
            this.SwithCounter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SwithCounter.BackgroundImage")));
            this.SwithCounter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwithCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwithCounter.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.SwithCounter.Location = new System.Drawing.Point(177, 71);
            this.SwithCounter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SwithCounter.Name = "SwithCounter";
            this.SwithCounter.OffColor = System.Drawing.Color.Gray;
            this.SwithCounter.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(186)))), ((int)(((byte)(76)))));
            this.SwithCounter.Size = new System.Drawing.Size(43, 25);
            this.SwithCounter.TabIndex = 6;
            this.SwithCounter.Value = false;
            this.SwithCounter.OnValueChange += new System.EventHandler(this.SwithCounter_OnValueChange);
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl.Location = new System.Drawing.Point(26, 71);
            this.lbl.Name = "lbl";
            this.lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl.Size = new System.Drawing.Size(145, 25);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "تشغيل الاحصائيات";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PersonStatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PageHead);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonStatusPage";
            this.Load += new System.EventHandler(this.PersonStatusPage_Load);
            this.PageHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Update)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_DefultSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PersonStatus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Counter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PageHead;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGV_PersonStatus;
        private System.Windows.Forms.RadioButton RB_ShowActiveOnly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_ShowAll;
        private System.Windows.Forms.RadioButton RB_Ended;
        private Bunifu.Framework.UI.BunifuImageButton btn_Update;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuImageButton btn_DefultSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton RB_EndedToday;
        private System.Windows.Forms.RadioButton RB_ShowStartedTody;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCheckbox checkBox_ShowColorAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Counter;
        private System.Windows.Forms.Label lbl_NotActiveStateCount;
        private System.Windows.Forms.Label Lebel10;
        private System.Windows.Forms.Label lbl_ActiveStateCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private Bunifu.Framework.UI.BunifuiOSSwitch SwithCounter;
    }
}