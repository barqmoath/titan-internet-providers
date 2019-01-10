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
    public partial class ReportPage : Form
    {
        SqlConnection Connection;
        ToolTip toltips = new ToolTip();
        string Server = Properties.Settings.Default.dbs_Servername;
        string Database = Properties.Settings.Default.dbs_Databasename;
        string Authentication = Properties.Settings.Default.dbs_Authentication;
        string UserID = Properties.Settings.Default.dbs_Username;
        string Password = Properties.Settings.Default.dbs_Password;
        public ReportPage()
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
            toltips.SetToolTip(btn_Exit, "اغلاق");
            toltips.SetToolTip(btn_Maximize, "تكبير");
            toltips.SetToolTip(btn_UpdateReport, "تحميل او اعاده تحديث ");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataSet ds = GetDataSet();
                ReportDataSource rds = new ReportDataSource("PersonReportDataSet", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.bindingSource1.DataSource = rds;
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("خطأ .. تحقق من معلومات اتصالك");
            }
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                toltips.SetToolTip(btn_Maximize, "تصغير");
            }
            else if(this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                toltips.SetToolTip(btn_Maximize, "تكبير");
            }
        }

        private void btn_UpdateReport_Click(object sender, EventArgs e)
        {
            System.Data.DataSet ds = GetDataSet();
            ReportDataSource rds = new ReportDataSource("PersonReportDataSet", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.bindingSource1.DataSource = rds;
            this.reportViewer1.RefreshReport();
        }

        private DataSet GetDataSet()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
            string strQuery = string.Format(@"Select * From TBL_PERSON");

            System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(strQuery,Connection);
            System.Data.DataSet ds = new System.Data.DataSet();
            ad.Fill(ds);
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
            return ds;
        }
    }
}
