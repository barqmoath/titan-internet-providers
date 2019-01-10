namespace Titan_Internet_Providers.Page.Concerted.DebtPage
{
    partial class DebtPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PageHead = new System.Windows.Forms.Panel();
            this.Pnl_Search = new System.Windows.Forms.Panel();
            this.btn_DefultSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Showpaper = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Update = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DebtCount = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GetDebtPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Get = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_MonyType = new System.Windows.Forms.Label();
            this.txt_Gic = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_DebtQty = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GetDebt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.RB_ALERTDEBT = new System.Windows.Forms.RadioButton();
            this.RB_DISPLY_ALL = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGV_Debt = new System.Windows.Forms.DataGridView();
            this.btn_ShowPhone = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PageHead.SuspendLayout();
            this.Pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DefultSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Showpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Update)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.GetDebtPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Debt)).BeginInit();
            this.SuspendLayout();
            // 
            // PageHead
            // 
            this.PageHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PageHead.Controls.Add(this.Pnl_Search);
            this.PageHead.Controls.Add(this.panel2);
            this.PageHead.Controls.Add(this.panel1);
            this.PageHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageHead.Location = new System.Drawing.Point(0, 0);
            this.PageHead.Name = "PageHead";
            this.PageHead.Size = new System.Drawing.Size(1136, 35);
            this.PageHead.TabIndex = 1;
            // 
            // Pnl_Search
            // 
            this.Pnl_Search.Controls.Add(this.btn_DefultSearch);
            this.Pnl_Search.Controls.Add(this.txt_Search);
            this.Pnl_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Search.Location = new System.Drawing.Point(403, 0);
            this.Pnl_Search.Name = "Pnl_Search";
            this.Pnl_Search.Size = new System.Drawing.Size(450, 35);
            this.Pnl_Search.TabIndex = 3;
            // 
            // btn_DefultSearch
            // 
            this.btn_DefultSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_DefultSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DefultSearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_DefultSearch.Image")));
            this.btn_DefultSearch.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_DefultSearch.ImageActive")));
            this.btn_DefultSearch.Location = new System.Drawing.Point(416, 4);
            this.btn_DefultSearch.Name = "btn_DefultSearch";
            this.btn_DefultSearch.Size = new System.Drawing.Size(25, 24);
            this.btn_DefultSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_DefultSearch.TabIndex = 7;
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
            this.txt_Search.Location = new System.Drawing.Point(43, 4);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Search.Size = new System.Drawing.Size(400, 28);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Showpaper);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 35);
            this.panel2.TabIndex = 2;
            // 
            // btn_Showpaper
            // 
            this.btn_Showpaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_Showpaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Showpaper.Image = ((System.Drawing.Image)(resources.GetObject("btn_Showpaper.Image")));
            this.btn_Showpaper.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_Showpaper.ImageActive")));
            this.btn_Showpaper.Location = new System.Drawing.Point(50, 0);
            this.btn_Showpaper.Name = "btn_Showpaper";
            this.btn_Showpaper.Size = new System.Drawing.Size(40, 35);
            this.btn_Showpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Showpaper.TabIndex = 8;
            this.btn_Showpaper.TabStop = false;
            this.btn_Showpaper.Zoom = 0;
            this.btn_Showpaper.Click += new System.EventHandler(this.btn_Showpaper_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageActive")));
            this.btn_Update.Location = new System.Drawing.Point(4, 0);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(40, 35);
            this.btn_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Update.TabIndex = 7;
            this.btn_Update.TabStop = false;
            this.btn_Update.Zoom = 0;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_DebtCount);
            this.panel1.Controls.Add(this.btn_GoBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(853, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 35);
            this.panel1.TabIndex = 2;
            // 
            // lbl_DebtCount
            // 
            this.lbl_DebtCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DebtCount.ForeColor = System.Drawing.Color.Gray;
            this.lbl_DebtCount.Location = new System.Drawing.Point(3, 0);
            this.lbl_DebtCount.Name = "lbl_DebtCount";
            this.lbl_DebtCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_DebtCount.Size = new System.Drawing.Size(237, 35);
            this.lbl_DebtCount.TabIndex = 7;
            this.lbl_DebtCount.Text = "عدد الديون في القائمه";
            this.lbl_DebtCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_GoBack.Location = new System.Drawing.Point(240, 0);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(43, 35);
            this.btn_GoBack.TabIndex = 5;
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_ShowPhone);
            this.panel3.Controls.Add(this.GetDebtPanel);
            this.panel3.Controls.Add(this.btn_GetDebt);
            this.panel3.Controls.Add(this.bunifuSeparator1);
            this.panel3.Controls.Add(this.RB_ALERTDEBT);
            this.panel3.Controls.Add(this.RB_DISPLY_ALL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(853, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 516);
            this.panel3.TabIndex = 2;
            // 
            // GetDebtPanel
            // 
            this.GetDebtPanel.Controls.Add(this.label3);
            this.GetDebtPanel.Controls.Add(this.dateTimePicker1);
            this.GetDebtPanel.Controls.Add(this.btn_Get);
            this.GetDebtPanel.Controls.Add(this.lbl_MonyType);
            this.GetDebtPanel.Controls.Add(this.txt_Gic);
            this.GetDebtPanel.Controls.Add(this.label1);
            this.GetDebtPanel.Controls.Add(this.checkBox1);
            this.GetDebtPanel.Controls.Add(this.txt_DebtQty);
            this.GetDebtPanel.Controls.Add(this.label2);
            this.GetDebtPanel.Location = new System.Drawing.Point(2, 169);
            this.GetDebtPanel.Name = "GetDebtPanel";
            this.GetDebtPanel.Size = new System.Drawing.Size(276, 171);
            this.GetDebtPanel.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 135);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "اخر تاريخ جديد";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 25);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btn_Get
            // 
            this.btn_Get.ActiveBorderThickness = 1;
            this.btn_Get.ActiveCornerRadius = 20;
            this.btn_Get.ActiveFillColor = System.Drawing.Color.Gray;
            this.btn_Get.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Get.ActiveLineColor = System.Drawing.Color.Gray;
            this.btn_Get.BackColor = System.Drawing.Color.White;
            this.btn_Get.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Get.BackgroundImage")));
            this.btn_Get.ButtonText = "استلام";
            this.btn_Get.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Get.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btn_Get.ForeColor = System.Drawing.Color.Gray;
            this.btn_Get.IdleBorderThickness = 1;
            this.btn_Get.IdleCornerRadius = 20;
            this.btn_Get.IdleFillColor = System.Drawing.Color.White;
            this.btn_Get.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_Get.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_Get.Location = new System.Drawing.Point(67, 99);
            this.btn_Get.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(201, 31);
            this.btn_Get.TabIndex = 20;
            this.btn_Get.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // lbl_MonyType
            // 
            this.lbl_MonyType.BackColor = System.Drawing.Color.White;
            this.lbl_MonyType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_MonyType.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_MonyType.Location = new System.Drawing.Point(5, 97);
            this.lbl_MonyType.Name = "lbl_MonyType";
            this.lbl_MonyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MonyType.Size = new System.Drawing.Size(56, 31);
            this.lbl_MonyType.TabIndex = 11;
            this.lbl_MonyType.Text = "دولار";
            this.lbl_MonyType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Gic
            // 
            this.txt_Gic.BorderColor = System.Drawing.Color.Gray;
            this.txt_Gic.Enabled = false;
            this.txt_Gic.Location = new System.Drawing.Point(5, 69);
            this.txt_Gic.MaxLength = 50;
            this.txt_Gic.Name = "txt_Gic";
            this.txt_Gic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Gic.Size = new System.Drawing.Size(135, 25);
            this.txt_Gic.TabIndex = 10;
            this.txt_Gic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 69);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "المستلم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(99, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(171, 23);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "قمت باستلام كافه المبلغ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_DebtQty
            // 
            this.txt_DebtQty.BorderColor = System.Drawing.Color.Gray;
            this.txt_DebtQty.Location = new System.Drawing.Point(5, 38);
            this.txt_DebtQty.MaxLength = 50;
            this.txt_DebtQty.Name = "txt_DebtQty";
            this.txt_DebtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_DebtQty.Size = new System.Drawing.Size(135, 25);
            this.txt_DebtQty.TabIndex = 5;
            this.txt_DebtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 38);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "مجموع المبلغ المطلوب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GetDebt
            // 
            this.btn_GetDebt.ActiveBorderThickness = 1;
            this.btn_GetDebt.ActiveCornerRadius = 20;
            this.btn_GetDebt.ActiveFillColor = System.Drawing.Color.Gray;
            this.btn_GetDebt.ActiveForecolor = System.Drawing.Color.White;
            this.btn_GetDebt.ActiveLineColor = System.Drawing.Color.Gray;
            this.btn_GetDebt.BackColor = System.Drawing.Color.White;
            this.btn_GetDebt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GetDebt.BackgroundImage")));
            this.btn_GetDebt.ButtonText = "استلام الدين المحدد";
            this.btn_GetDebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GetDebt.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btn_GetDebt.ForeColor = System.Drawing.Color.Gray;
            this.btn_GetDebt.IdleBorderThickness = 1;
            this.btn_GetDebt.IdleCornerRadius = 20;
            this.btn_GetDebt.IdleFillColor = System.Drawing.Color.White;
            this.btn_GetDebt.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_GetDebt.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_GetDebt.Location = new System.Drawing.Point(7, 131);
            this.btn_GetDebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GetDebt.Name = "btn_GetDebt";
            this.btn_GetDebt.Size = new System.Drawing.Size(265, 31);
            this.btn_GetDebt.TabIndex = 19;
            this.btn_GetDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_GetDebt.Click += new System.EventHandler(this.btn_GetDebt_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 76);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(265, 13);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // RB_ALERTDEBT
            // 
            this.RB_ALERTDEBT.AutoSize = true;
            this.RB_ALERTDEBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_ALERTDEBT.Location = new System.Drawing.Point(97, 45);
            this.RB_ALERTDEBT.Name = "RB_ALERTDEBT";
            this.RB_ALERTDEBT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RB_ALERTDEBT.Size = new System.Drawing.Size(173, 23);
            this.RB_ALERTDEBT.TabIndex = 1;
            this.RB_ALERTDEBT.Text = "عرض الذي يجب استلامها";
            this.RB_ALERTDEBT.UseVisualStyleBackColor = true;
            this.RB_ALERTDEBT.CheckedChanged += new System.EventHandler(this.RB_ALERTDEBT_CheckedChanged);
            // 
            // RB_DISPLY_ALL
            // 
            this.RB_DISPLY_ALL.AutoSize = true;
            this.RB_DISPLY_ALL.Checked = true;
            this.RB_DISPLY_ALL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_DISPLY_ALL.Location = new System.Drawing.Point(174, 16);
            this.RB_DISPLY_ALL.Name = "RB_DISPLY_ALL";
            this.RB_DISPLY_ALL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RB_DISPLY_ALL.Size = new System.Drawing.Size(96, 23);
            this.RB_DISPLY_ALL.TabIndex = 0;
            this.RB_DISPLY_ALL.TabStop = true;
            this.RB_DISPLY_ALL.Text = "عرض الكــــل";
            this.RB_DISPLY_ALL.UseVisualStyleBackColor = true;
            this.RB_DISPLY_ALL.CheckedChanged += new System.EventHandler(this.RB_DISPLY_ALL_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.DGV_Debt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(853, 516);
            this.panel4.TabIndex = 3;
            // 
            // DGV_Debt
            // 
            this.DGV_Debt.AllowUserToAddRows = false;
            this.DGV_Debt.AllowUserToDeleteRows = false;
            this.DGV_Debt.AllowUserToResizeRows = false;
            this.DGV_Debt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Debt.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Debt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Debt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Debt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Debt.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Debt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Debt.Location = new System.Drawing.Point(0, 0);
            this.DGV_Debt.MultiSelect = false;
            this.DGV_Debt.Name = "DGV_Debt";
            this.DGV_Debt.ReadOnly = true;
            this.DGV_Debt.RowHeadersVisible = false;
            this.DGV_Debt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Debt.Size = new System.Drawing.Size(851, 514);
            this.DGV_Debt.TabIndex = 1;
            // 
            // btn_ShowPhone
            // 
            this.btn_ShowPhone.ActiveBorderThickness = 1;
            this.btn_ShowPhone.ActiveCornerRadius = 20;
            this.btn_ShowPhone.ActiveFillColor = System.Drawing.Color.Gray;
            this.btn_ShowPhone.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ShowPhone.ActiveLineColor = System.Drawing.Color.Gray;
            this.btn_ShowPhone.BackColor = System.Drawing.Color.White;
            this.btn_ShowPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ShowPhone.BackgroundImage")));
            this.btn_ShowPhone.ButtonText = "اعطني رقم هاتف المشترك المحدد";
            this.btn_ShowPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btn_ShowPhone.ForeColor = System.Drawing.Color.Gray;
            this.btn_ShowPhone.IdleBorderThickness = 1;
            this.btn_ShowPhone.IdleCornerRadius = 20;
            this.btn_ShowPhone.IdleFillColor = System.Drawing.Color.White;
            this.btn_ShowPhone.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_ShowPhone.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_ShowPhone.Location = new System.Drawing.Point(7, 96);
            this.btn_ShowPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ShowPhone.Name = "btn_ShowPhone";
            this.btn_ShowPhone.Size = new System.Drawing.Size(265, 31);
            this.btn_ShowPhone.TabIndex = 21;
            this.btn_ShowPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ShowPhone.Click += new System.EventHandler(this.btn_ShowPhone_Click);
            // 
            // DebtPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1136, 551);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PageHead);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DebtPage";
            this.PageHead.ResumeLayout(false);
            this.Pnl_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_DefultSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Showpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Update)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.GetDebtPanel.ResumeLayout(false);
            this.GetDebtPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Debt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PageHead;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_DebtCount;
        public System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DGV_Debt;
        private System.Windows.Forms.RadioButton RB_ALERTDEBT;
        private System.Windows.Forms.RadioButton RB_DISPLY_ALL;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel GetDebtPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_GetDebt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Gic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_DebtQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MonyType;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Get;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Panel Pnl_Search;
        private Bunifu.Framework.UI.BunifuImageButton btn_DefultSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuImageButton btn_Showpaper;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ShowPhone;
    }
}