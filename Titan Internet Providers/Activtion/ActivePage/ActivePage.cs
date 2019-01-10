using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan_Internet_Providers.Activtion.ActivePage
{
    public partial class ActivePage : Form
    {
        private string ProductKey;
        private bool FisrUse;
        public ActivePage()
        {
            InitializeComponent();
            this.ProductKey = Properties.Settings.Default.ProductKey;
            this.FisrUse = Properties.Settings.Default.TheProgramFirstUse;

            btn_Restrt.Hide();
        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            if(txt_ProductKey.Text !=string.Empty && txt_ProductOwner.Text !=string.Empty)
            {
                if(txt_ProductKey.Text==ProductKey && FisrUse)
                {
                    Properties.Settings.Default.TheProgramIsActive = true;
                    Properties.Settings.Default.TheProgramOwnerName = txt_ProductOwner.Text;
                    Properties.Settings.Default.TheProgramFirstUse = false;
                    Properties.Settings.Default.Save();
                    txt_ProductKey.BackColor = Color.SpringGreen;
                    lbl_Active.Text = "تم تنشيط المنتج";
                    btn_Active.Enabled = false;
                    btn_Restrt.Show();
                }
                else
                {
                    lbl_Active.Text = "مفتاح منتج خاطئ";
                    txt_ProductKey.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("احد الحقول المهمه فارغ");
            }
        }

        private void btn_Restrt_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
