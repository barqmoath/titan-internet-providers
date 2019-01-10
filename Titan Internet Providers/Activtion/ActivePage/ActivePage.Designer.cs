namespace Titan_Internet_Providers.Activtion.ActivePage
{
    partial class ActivePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivePage));
            this.lbl_Active = new System.Windows.Forms.Label();
            this.txt_ProductOwner = new System.Windows.Forms.TextBox();
            this.txt_ProductKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Active = new System.Windows.Forms.Button();
            this.btn_Restrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Active
            // 
            this.lbl_Active.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Active.Location = new System.Drawing.Point(240, 3);
            this.lbl_Active.Name = "lbl_Active";
            this.lbl_Active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Active.Size = new System.Drawing.Size(148, 30);
            this.lbl_Active.TabIndex = 0;
            this.lbl_Active.Text = "الرجاء تنشيط المنتج اولا";
            this.lbl_Active.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ProductOwner
            // 
            this.txt_ProductOwner.Location = new System.Drawing.Point(12, 41);
            this.txt_ProductOwner.Name = "txt_ProductOwner";
            this.txt_ProductOwner.Size = new System.Drawing.Size(257, 22);
            this.txt_ProductOwner.TabIndex = 1;
            this.txt_ProductOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ProductKey
            // 
            this.txt_ProductKey.Location = new System.Drawing.Point(12, 69);
            this.txt_ProductKey.MaxLength = 19;
            this.txt_ProductKey.Name = "txt_ProductKey";
            this.txt_ProductKey.Size = new System.Drawing.Size(257, 22);
            this.txt_ProductKey.TabIndex = 2;
            this.txt_ProductKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(275, 41);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "مالك البرنامج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(275, 69);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "مفتاح المنتج";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Active
            // 
            this.btn_Active.Location = new System.Drawing.Point(194, 97);
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(75, 23);
            this.btn_Active.TabIndex = 5;
            this.btn_Active.Text = "تنشيط";
            this.btn_Active.UseVisualStyleBackColor = true;
            this.btn_Active.Click += new System.EventHandler(this.btn_Active_Click);
            // 
            // btn_Restrt
            // 
            this.btn_Restrt.Location = new System.Drawing.Point(12, 97);
            this.btn_Restrt.Name = "btn_Restrt";
            this.btn_Restrt.Size = new System.Drawing.Size(176, 23);
            this.btn_Restrt.TabIndex = 6;
            this.btn_Restrt.Text = "اعاده التشغيل";
            this.btn_Restrt.UseVisualStyleBackColor = true;
            this.btn_Restrt.Click += new System.EventHandler(this.btn_Restrt_Click);
            // 
            // ActivePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 129);
            this.Controls.Add(this.btn_Restrt);
            this.Controls.Add(this.btn_Active);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ProductKey);
            this.Controls.Add(this.txt_ProductOwner);
            this.Controls.Add(this.lbl_Active);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 168);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(402, 168);
            this.Name = "ActivePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الترخيص";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Active;
        private System.Windows.Forms.TextBox txt_ProductOwner;
        private System.Windows.Forms.TextBox txt_ProductKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Active;
        private System.Windows.Forms.Button btn_Restrt;
    }
}