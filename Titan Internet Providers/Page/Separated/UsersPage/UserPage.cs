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

namespace Titan_Internet_Providers.Page.Separated.UsersPage
{
    public partial class UserPage : Form
    {

        SqlConnection Connection;
        SqlDataAdapter Adapter;
        DataTable Table = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        string Server = Properties.Settings.Default.dbs_Servername;
        string Database = Properties.Settings.Default.dbs_Databasename;
        string Authentication = Properties.Settings.Default.dbs_Authentication;
        string UserID = Properties.Settings.Default.dbs_Username;
        string Password = Properties.Settings.Default.dbs_Password;
        public UserPage()
        {
            InitializeComponent();
            if (this.Authentication == "windows")
            {
                this.Connection = new SqlConnection(@"Server=" + this.Server + "; Database=" + this.Database + "; Integrated Security=true");
            }
            else if (this.Authentication == "sql")
            {
                this.Connection = new SqlConnection(@"Server=" + this.Server + "; Database=" + this.Database + "; Integrated Security=false; User ID=" + this.UserID + "; Password=" + this.Password + ";");
            }
        }

        private void DataGridSetting()
        {
            this.DGV_User.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_User.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_User.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_User.RowTemplate.Height = 28;
            this.DGV_User.DataSource =Table;
            this.DGV_User.Columns[0].HeaderText = "اسم المستخدم";
            this.DGV_User.Columns[1].Visible = false;
            this.DGV_User.Columns[2].HeaderText = "نوع المستخدم";
        }
        private void Checkbox_ShowPAss_OnChange(object sender, EventArgs e)
        {
            if (Checkbox_ShowPAss.Checked == true)
                txt_Password.UseSystemPasswordChar = false;
            else
                txt_Password.UseSystemPasswordChar = true;
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("Select USERNAME,PASSWORD,TYPE From TBL_USER", Connection);
            Adapter.Fill(Table);
            DataGridSetting();
            txt_UserName.DataBindings.Add("Text", Table, "USERNAME");
            txt_Password.DataBindings.Add("Text", Table, "PASSWORD");
            cmb_type.DataBindings.Add("Text", Table, "TYPE");
            bmb = this.BindingContext[Table];

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btn_NewUser.Enabled = false;
            btn_SaveUser.Enabled = true;
            btn_DeletUser.Enabled = false;
            btn_EditUser.Enabled = false;
            txt_UserName.Focus();
        }

        private void btn_SaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(Adapter);
                Adapter.Update(Table);
                btn_NewUser.Enabled = true;
                btn_SaveUser.Enabled = false;
                btn_DeletUser.Enabled = true;
                btn_EditUser.Enabled = true;
                MessageBox.Show("تمت الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من اتصالك");
            }          
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("سيتم تعديل معلومات المستخدم وفقا للمعلومات في الحقول", "تاكيد استمرار التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(Adapter);
                    Adapter.Update(Table);
                    MessageBox.Show("تم التعديل", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من اتصالك");
            }
        }

        private void btn_DeletUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد بالفعل حذف هذا المستخدم", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bmb.RemoveAt(bmb.Position);
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(Adapter);
                    Adapter.Update(Table);
                    MessageBox.Show("تم الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من اتصالك");
            }      
        }
    }
}
