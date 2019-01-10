namespace Titan_Internet_Providers.Report.ReportPage
{
    partial class ReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            this.PageHead = new System.Windows.Forms.Panel();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_UpdateReport = new Bunifu.Framework.UI.BunifuImageButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personReportDataSet1 = new Titan_Internet_Providers.PersonReportDataSet();
            this.tbL_PERSONTableAdapter1 = new Titan_Internet_Providers.PersonReportDataSetTableAdapters.TBL_PERSONTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PageHead.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_UpdateReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personReportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PageHead
            // 
            this.PageHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PageHead.Controls.Add(this.btn_UpdateReport);
            this.PageHead.Controls.Add(this.btn_Maximize);
            this.PageHead.Controls.Add(this.btn_Exit);
            this.PageHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageHead.Location = new System.Drawing.Point(0, 0);
            this.PageHead.Name = "PageHead";
            this.PageHead.Size = new System.Drawing.Size(1010, 30);
            this.PageHead.TabIndex = 1;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Maximize.BackgroundImage")));
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Location = new System.Drawing.Point(928, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(40, 30);
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
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
            this.btn_Exit.Location = new System.Drawing.Point(968, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(42, 30);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 5);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel2.Location = new System.Drawing.Point(1005, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 389);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 389);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.reportViewer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel4.Location = new System.Drawing.Point(5, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 389);
            this.panel4.TabIndex = 5;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PageHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn_UpdateReport
            // 
            this.btn_UpdateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_UpdateReport.Image = ((System.Drawing.Image)(resources.GetObject("btn_UpdateReport.Image")));
            this.btn_UpdateReport.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_UpdateReport.ImageActive")));
            this.btn_UpdateReport.Location = new System.Drawing.Point(3, 0);
            this.btn_UpdateReport.Name = "btn_UpdateReport";
            this.btn_UpdateReport.Size = new System.Drawing.Size(32, 30);
            this.btn_UpdateReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_UpdateReport.TabIndex = 1;
            this.btn_UpdateReport.TabStop = false;
            this.btn_UpdateReport.Zoom = 0;
            this.btn_UpdateReport.Click += new System.EventHandler(this.btn_UpdateReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Titan_Internet_Providers.Report.Reports.PersonReport.Person.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 389);
            this.reportViewer1.TabIndex = 0;
            // 
            // personReportDataSet1
            // 
            this.personReportDataSet1.DataSetName = "PersonReportDataSet";
            this.personReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbL_PERSONTableAdapter1
            // 
            this.tbL_PERSONTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 424);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PageHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReportPage_Load);
            this.PageHead.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_UpdateReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personReportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PageHead;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btn_Maximize;
        public Bunifu.Framework.UI.BunifuImageButton btn_UpdateReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PersonReportDataSet personReportDataSet1;
        private PersonReportDataSetTableAdapters.TBL_PERSONTableAdapter tbL_PERSONTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}