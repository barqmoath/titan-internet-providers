using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan_Internet_Providers.Activtion.AboutProgramPage
{
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();
            this.lbl_OwnerName.Text = Properties.Settings.Default.TheProgramOwnerName;
            this.lbl_Keys.Text = Properties.Settings.Default.ProductKey;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
