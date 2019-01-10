using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan_Internet_Providers.Page.Separated.ReadNewWebPage_Page
{
    public partial class NewPage_Page : Form
    {
        public NewPage_Page()
        {
            InitializeComponent();
            this.txt_Url.Text = Properties.Settings.Default.Defualt_Web_Page;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(this.txt_Url.Text != string.Empty)
            {
                Properties.Settings.Default.Defualt_Web_Page = this.txt_Url.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
           
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
