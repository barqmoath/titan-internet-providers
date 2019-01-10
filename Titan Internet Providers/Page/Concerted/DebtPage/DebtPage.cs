using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan_Internet_Providers.Page.Concerted.DebtPage
{
    public partial class DebtPage : Form
    {
        Class.ClassDebt.Debt debt = new Class.ClassDebt.Debt();
        public DebtPage()
        {
            InitializeComponent();
            AddToolTips();
            GetData();
            GetDebtPanel.Hide(); label3.Hide(); dateTimePicker1.Hide();
        }

        private void GetData()
        {
            this.DGV_Debt.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_Debt.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_Debt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Debt.RowTemplate.Height = 28;
            this.DGV_Debt.DataSource = debt.GetDebtList();
            this.DGV_Debt.Columns[0].HeaderText = "المعرف";
            this.DGV_Debt.Columns[0].Visible = false;
            this.DGV_Debt.Columns[1].HeaderText = "ورقه النشوء";
            this.DGV_Debt.Columns[2].HeaderText = "معرف المشترك";
            this.DGV_Debt.Columns[2].Visible = false;
            this.DGV_Debt.Columns[3].HeaderText = "اسم المشترك";
            this.DGV_Debt.Columns[4].Visible = false;
            this.DGV_Debt.Columns[5].HeaderText = "كميه الدين";
            this.DGV_Debt.Columns[6].HeaderText = "اخر تاريخ";
            this.DGV_Debt.Columns[7].HeaderText = "العمله";
            this.lbl_DebtCount.Text = this.DGV_Debt.RowCount.ToString() + " هو عدد الديون حاليا";
        }
        private void AddToolTips()
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_Update, "تحديث");
            t.SetToolTip(btn_GoBack, "اغلاق ورجوع للرئيسيه");
            t.SetToolTip(btn_Showpaper, "عرض وصل نشوء الدين المحدد");
        }
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.MainPage.MainPage.GetMainPage.btn_Debt.Normalcolor = Color.WhiteSmoke;
            Main.MainPage.MainPage.GetMainPage.btn_Debt.Textcolor = Color.Black;
            Main.MainPage.MainPage.GetMainPage.ShowState = "non";
            Main.MainPage.MainPage.GetMainPage.PageBody.Hide();
        }

        private void RB_DISPLY_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if(this.RB_DISPLY_ALL.Checked==true)
            {
                try
                {
                    this.DGV_Debt.DataSource = debt.GetDebtList();
                }
                catch
                {
                    return;
                }
            }         
        }

        private void RB_ALERTDEBT_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(RB_ALERTDEBT.Checked==true)
                {
                    this.DGV_Debt.DataSource = debt.ShowImportList();
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.DGV_Debt.DataSource = debt.GetDebtList();
            }
            catch
            {
                return;
            }
        }

        private void btn_GetDebt_Click(object sender, EventArgs e)
        {
            if(this.DGV_Debt.RowCount !=0)
            {
                GetDebtPanel.Show();
                txt_DebtQty.Text = txt_Gic.Text= this.DGV_Debt.CurrentRow.Cells[5].Value.ToString();
                lbl_MonyType.Text = this.DGV_Debt.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                label1.Enabled = false;
                txt_Gic.Enabled = false;
                label3.Hide();
                dateTimePicker1.Hide();
            }
            else
            {
                label1.Enabled = true;
                txt_Gic.Enabled = true;
                label3.Show();
                dateTimePicker1.Show();
            }
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                //Delete Debt
               if(MessageBox.Show("باعتبار انك استلمت كافه المبلغ المطلوب من المشترك فسيتم حذفه من القائمه","تاكيد الاستلام",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
               {
                    debt.DeletDebt(Convert.ToInt32(this.DGV_Debt.CurrentRow.Cells[0].Value.ToString()));
                    this.DGV_Debt.DataSource = debt.GetDebtList();
                    GetDebtPanel.Hide();
                    RB_DISPLY_ALL.Checked = true;
               }
            }
            else 
            {
                //Update
                if (MessageBox.Show("ستقوم باستلام بعضا من المبلغ المطلوب تاكد من اخالك اخر تاريخ جديد من اجل تنبيهك للاستلام التالي", "تاكيد الاستلام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    double NewQTY = Convert.ToDouble(txt_DebtQty.Text) - Convert.ToDouble(txt_Gic.Text);
                    debt.UpdateDebt(Convert.ToInt32(this.DGV_Debt.CurrentRow.Cells[0].Value.ToString()), NewQTY.ToString(), dateTimePicker1.Value.Date);
                    this.DGV_Debt.DataSource = debt.GetDebtList();
                    GetDebtPanel.Hide();
                    RB_DISPLY_ALL.Checked = true;
                }
            }
        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                DGV_Debt.DataSource = this.debt.MultiSearch(txt_Search.Text);
            }
            catch { return; }
        }

        private void btn_Showpaper_Click(object sender, EventArgs e)
        {
            if(this.DGV_Debt.RowCount!=0)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    Report.ReportPage.ActivePaperReportPage P = new Report.ReportPage.ActivePaperReportPage();
                    P.PaperID = Convert.ToInt32(this.DGV_Debt.CurrentRow.Cells[1].Value.ToString());
                    P.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                catch
                {
                    return;
                }
            }           
        }

        private void btn_ShowPhone_Click(object sender, EventArgs e)
        {
            if(this.DGV_Debt.RowCount!=0)
            {
                try
                {
                    int Person = Convert.ToInt32(this.DGV_Debt.CurrentRow.Cells[2].Value.ToString());
                    MessageBox.Show("رقم هاتف المشترك المحدد هو   " + debt.GetMyPersonPhone(Person), "رقم هاتف المشترك", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    return;
                }
            }
        }
    }
}
