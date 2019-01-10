using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Report.ReportPage
{
    
    public partial class ActivePaperReportPage : Form
    {
        public int PaperID;

        SqlConnection Connection;
        ToolTip toltips = new ToolTip();
        string Server = Properties.Settings.Default.dbs_Servername;
        string Database = Properties.Settings.Default.dbs_Databasename;
        string Authentication = Properties.Settings.Default.dbs_Authentication;
        string UserID = Properties.Settings.Default.dbs_Username;
        string Password = Properties.Settings.Default.dbs_Password;
        public ActivePaperReportPage()
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

        private void ActivePaperReportPage_Load(object sender, EventArgs e)
        {

            try
            {
                System.Data.DataSet ds = GetDataSet();
                ReportDataSource rds = new ReportDataSource("ActiveDataSet", ds.Tables[0]);
                this.ReportViewer.LocalReport.DataSources.Clear();
                this.ReportViewer.LocalReport.DataSources.Add(rds);
                this.bindingSource1.DataSource = rds;
                this.ReportViewer.RefreshReport();
            }
            catch
            {
                MessageBox.Show("خطأ .. تحقق من معلومات اتصالك");
            }
        }

        private DataSet GetDataSet()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
            string strQuery = string.Format(@"Select * From TBL_ACTIVE_PAPER Where ID="+this.PaperID.ToString());

            System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(strQuery, Connection);
            System.Data.DataSet ds = new System.Data.DataSet();
            ad.Fill(ds);
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
            return ds;
        }
    }
}
