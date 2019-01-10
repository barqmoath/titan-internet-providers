using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan_Internet_Providers.Page.Separated.Connect_Setting_Page
{
    public partial class Connect_Setting_Page : Form
    {
        public Connect_Setting_Page()
        {
            InitializeComponent();
            txt_Server.Text = Properties.Settings.Default.dbs_Servername;
            txt_Database.Text = Properties.Settings.Default.dbs_Databasename;
            if(Properties.Settings.Default.dbs_Authentication=="windows")
            {
                RB_Windows.Checked = true;
                groupBox_SQL.Enabled = false;
                lbl_SQL.Enabled = false;
                lbl_SQL2.Enabled = false;
                txt_UserID.Enabled = false;
                txt_Password.Enabled = false;
            }
            else if(Properties.Settings.Default.dbs_Authentication=="sql")
            {
                RB_SQL.Checked = true;
                groupBox_SQL.Enabled = true;
                lbl_SQL.Enabled = true;
                lbl_SQL2.Enabled = true;
                txt_UserID.Enabled = true;
                txt_Password.Enabled = true;
                txt_UserID.Text = Properties.Settings.Default.dbs_Username;
                txt_Password.Text = Properties.Settings.Default.dbs_Password;
            }
            
        }

        private void RB_Windows_CheckedChanged(object sender, EventArgs e)
        {
            if(RB_Windows.Checked==true)
            {
                groupBox_SQL.Enabled = false;
                lbl_SQL.Enabled = false;
                lbl_SQL2.Enabled = false;
                txt_UserID.Enabled = false;
                txt_Password.Enabled = false;

            }
        }

        private void RB_SQL_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_SQL.Enabled = true;
            lbl_SQL.Enabled = true;
            lbl_SQL2.Enabled = true;
            txt_UserID.Enabled = true;
            txt_Password.Enabled = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dbs_Servername = txt_Server.Text;
            Properties.Settings.Default.dbs_Databasename = txt_Database.Text;
            if (RB_Windows.Checked == true)
            {
                Properties.Settings.Default.dbs_Authentication = "windows";
                Properties.Settings.Default.dbs_Username = null;
                Properties.Settings.Default.dbs_Password = null;
            }
            else if (RB_SQL.Checked == true)
            {
                Properties.Settings.Default.dbs_Authentication = "sql";
                Properties.Settings.Default.dbs_Username = txt_UserID.Text;
                Properties.Settings.Default.dbs_Password = txt_Password.Text;
            }
            Properties.Settings.Default.Save();
            btn_Save.Enabled = false;
            btn_Cancel.Text = "خروج";
            label2.Text = " تم الحفظ ";
        }

        private void btn_Defult_Click(object sender, EventArgs e)
        {
            txt_Server.Text = "EnterLocalServer";
            txt_Database.Text = "Titan_Internetproviders_db";
            RB_Windows.Checked = true;
            groupBox_SQL.Enabled = false;
            lbl_SQL.Enabled = false;
            lbl_SQL2.Enabled = false;
            txt_UserID.Enabled = false;
            txt_Password.Enabled = false;
            txt_UserID.Clear();
            txt_Password.Clear();
        }
    }
}
