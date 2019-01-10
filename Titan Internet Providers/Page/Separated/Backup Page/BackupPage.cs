using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Page.Separated.Backup_Page
{
    public partial class BackupPage : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        string Server = Properties.Settings.Default.dbs_Servername;
        string Database = Properties.Settings.Default.dbs_Databasename;
        string Authentication = Properties.Settings.Default.dbs_Authentication;
        string UserID = Properties.Settings.Default.dbs_Username;
        string Password = Properties.Settings.Default.dbs_Password;
        public BackupPage()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NewBackup_Click(object sender, EventArgs e)
        {
            if (this.Authentication == "windows")
            {
                this.Connection = new SqlConnection(@"Server=" + this.Server + "; Database=" + this.Database + "; Integrated Security=true");
            }
            else if (this.Authentication == "sql")
            {
                this.Connection = new SqlConnection(@"Server=" + this.Server + "; Database=" + this.Database + "; Integrated Security=false; User ID=" + this.UserID + "; Password=" + this.Password + ";");
            }

            //---------------------------
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Backup File (*.Bak) |*.bak";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Connection.Open();
                    Command = new SqlCommand("Backup Database "+this.Database+" To Disk ='" + sfd.FileName + "'", Connection);
                    Command.ExecuteNonQuery();
                    Connection.Close();
                }
               catch
                {
                    MessageBox.Show("لقد حدث خطأ  ");
                }
            }
            MessageBox.Show("تم نسخ البيانات بنجاح ستجد ملف النسخه الاحتياطيه في المكان الذي قمت بتحديده .. احتفظ به", "حاله عمليه النسخ الاحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Restor_Click(object sender, EventArgs e)
        {
            if (this.Authentication == "windows")
            {
                this.Connection = new SqlConnection(@"Server=" + this.Server + "; Database=" + "Master" + "; Integrated Security=true");
            }
            else if (this.Authentication == "sql")
            {
                this.Connection = new SqlConnection(@"Server=" + this.Server + "; Database=" + "Master" + "; Integrated Security=false; User ID=" + this.UserID + "; Password=" + this.Password + ";");
            }

            //--------------------------------------------
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup File (*.Bak) | *.bak";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    Connection.Open();
                    Command = new SqlCommand("Restore Database " + this.Database + " From Disk='" + ofd.FileName + "'", Connection);
                    Command.ExecuteNonQuery();
                    Connection.Close();
                    MessageBox.Show("تم استعاده بياناتك بنجاح", "حاله عمليه النسخ الاحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("لقد حدث خطأ  ");
                }              
            }
        }
    }
}
