using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan_Internet_Providers.Page.Concerted.PersonStatusPage
{
    public partial class PersonStatusPage : Form
    {
        Class.ClassPersonStatus.Status status = new Class.ClassPersonStatus.Status();
        int ActiveStateCount = 0;
        int NotActiveStateCount = 0;
        public PersonStatusPage()
        {
            InitializeComponent();
            this.DGV_PersonStatus.DataSource = status.GetStatusList();
            DataGridViewSetting();
            AddToolTips();
            groupBox_Counter.Hide();
        }
        private void DataGridViewSetting()
        {
            this.DGV_PersonStatus.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_PersonStatus.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_PersonStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_PersonStatus.RowTemplate.Height = 28;
            this.DGV_PersonStatus.Columns[0].HeaderText = "معرف المشترك";
            this.DGV_PersonStatus.Columns[0].Visible = false;
            this.DGV_PersonStatus.Columns[1].HeaderText = "اسم المشترك";
            this.DGV_PersonStatus.Columns[1].Width = 200;
            this.DGV_PersonStatus.Columns[2].HeaderText = "يوزر المشترك";
            this.DGV_PersonStatus.Columns[2].Width = 200;
            this.DGV_PersonStatus.Columns[3].HeaderText = "معرف الاشتراك";
            this.DGV_PersonStatus.Columns[3].Visible = false;
            this.DGV_PersonStatus.Columns[4].HeaderText = "نوع الاشتراك";
            this.DGV_PersonStatus.Columns[4].Width = 200;
            this.DGV_PersonStatus.Columns[5].HeaderText = "حاله الاشتراك";
            this.DGV_PersonStatus.Columns[5].Width = 200;
            this.DGV_PersonStatus.Columns[6].HeaderText = "تاريخ البدء";
            this.DGV_PersonStatus.Columns[6].Width = 200;
            this.DGV_PersonStatus.Columns[7].HeaderText = "تاريخ الانتهاء";
            this.DGV_PersonStatus.Columns[7].Width = 200;
            this.ColorAlert();
        }
        private void ColorAlert()
        {
            if(this.checkBox_ShowColorAlert.Checked==true)
            {
                for (int i = 0; i < this.DGV_PersonStatus.RowCount; i++)
                {
                    if(this.DGV_PersonStatus.Rows[i].Cells[5].Value.ToString()=="فعال")
                    {
                        this.DGV_PersonStatus.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
                    }
                    else
                    {
                        this.DGV_PersonStatus.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(232, 17, 35);
                    }
                }
            }
        }
        private void AddToolTips()
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_Update, "تحديث");
            t.SetToolTip(btn_GoBack, "اغلاق ورجوع للرئيسيه");
        }
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.MainPage.MainPage.GetMainPage.btn_Status.Normalcolor = Color.WhiteSmoke;
            Main.MainPage.MainPage.GetMainPage.btn_Status.Textcolor = Color.Black;
            Main.MainPage.MainPage.GetMainPage.ShowState = "non";
            Main.MainPage.MainPage.GetMainPage.PageBody.Hide();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGV_PersonStatus.DataSource = status.MultiSeacrch(txt_Search.Text);
                ColorAlert();
            }
            catch
            { return; }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (RB_ShowAll.Checked == true)
                {
                    this.DGV_PersonStatus.DataSource = status.GetStatusList();
                    ColorAlert();
                }
                else if (RB_ShowActiveOnly.Checked == true)
                {
                    this.DGV_PersonStatus.DataSource = status.ShowStartStatus();
                    ColorAlert();
                }
                else if (RB_Ended.Checked == true)
                {
                    this.DGV_PersonStatus.DataSource = status.ShowEndStatus();
                    ColorAlert();
                }
                else if (RB_EndedToday.Checked == true)
                {
                    this.DGV_PersonStatus.DataSource = status.ShowEndTodyStatus();
                    ColorAlert();
                }
                else if(RB_ShowStartedTody.Checked==true)
                {
                    this.DGV_PersonStatus.DataSource = status.ShowStartTodyStatus();
                    ColorAlert();
                }
            }
            catch
            {
                return;
            }
        }
        private void RB_ShowAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RB_ShowAll.Checked == true)
                {
                    this.DGV_PersonStatus.DataSource = status.GetStatusList();
                    ColorAlert();
                }
            }
            catch
            {
                return;
            }
        }
        private void RB_ShowActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RB_ShowActiveOnly.Checked == true)
                {
                    this.DGV_PersonStatus.DataSource = status.ShowStartStatus();
                    ColorAlert();
                }
            }
            catch
            {
                return;
            }
        }
        private void RB_Ended_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RB_Ended.Checked == true)
                {
                    this.DGV_PersonStatus.DataSource = status.ShowEndStatus();
                    ColorAlert();
                }
            }
            catch
            {
                return;
            }
        }
        private void RB_EndedToday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RB_EndedToday.Checked == true)
                {
                    this.DGV_PersonStatus.DataSource = status.ShowEndTodyStatus();
                    ColorAlert();
                }
            }
            catch
            {
                return;
            }
        }
        private void RB_ShowStartedTody_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGV_PersonStatus.DataSource = status.ShowStartTodyStatus();
                ColorAlert();
            }
            catch
            {
                return;
            }
        }
        private void checkBox_ShowColorAlert_OnChange(object sender, EventArgs e)
        {
            if (checkBox_ShowColorAlert.Checked == true)
            {
                ColorAlert();
            }
            else if(checkBox_ShowColorAlert.Checked==false)
            {
                for (int i = 0; i < this.DGV_PersonStatus.RowCount; i++)
                {
                    this.DGV_PersonStatus.Rows[i].DefaultCellStyle.BackColor = Color.White;   
                }
            }
        }
        private void PersonStatusPage_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < this.DGV_PersonStatus.RowCount; i++)
                {
                    status.UpdateStaus(Convert.ToInt32(this.DGV_PersonStatus.Rows[i].Cells[0].Value), "غير فعال");
                }
            }
            catch
            {
                return;
            }
            finally
            {
                this.DGV_PersonStatus.DataSource = status.GetStatusList();
                DataGridViewSetting();
            }
        }
        private void SwithCounter_OnValueChange(object sender, EventArgs e)
        {
            if(this.SwithCounter.Value==true)
            {
                this.groupBox_Counter.Show();
                for (int i = 0; i < this.DGV_PersonStatus.RowCount; i++)
                {
                    if (this.DGV_PersonStatus.Rows[i].Cells[5].Value.ToString() == "فعال")
                    {
                        this.ActiveStateCount++;
                    }
                    if (this.DGV_PersonStatus.Rows[i].Cells[5].Value.ToString() == "غير فعال")
                    {
                        this.NotActiveStateCount++;
                    }
                }
                this.lbl_ActiveStateCount.Text = this.ActiveStateCount.ToString();
                this.lbl_NotActiveStateCount.Text = this.NotActiveStateCount.ToString();
            }
            else
            {
                this.groupBox_Counter.Hide();
                this.ActiveStateCount = 0;
                this.NotActiveStateCount = 0;
            }
        }
    }
}
