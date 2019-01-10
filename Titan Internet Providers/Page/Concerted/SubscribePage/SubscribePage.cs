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
namespace Titan_Internet_Providers.Page.Concerted.SubscribePage
{
    public partial class SubscribePage : Form
    {
        Class.ClassSubscribe.Subc subc = new Class.ClassSubscribe.Subc();
        bool ShowMonyType = false;
        public SubscribePage()
        {
            InitializeComponent();
            GetData();
            btn_CancelNew.Hide();
        }

        private void GetData()
        {
            this.DGV_Subc.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_Subc.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_Subc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Subc.RowTemplate.Height = 28;
            this.DGV_Subc.DataSource = subc.GetSubcList();
            this.DGV_Subc.Columns[0].HeaderText = "معرف الاشتراك";
            this.DGV_Subc.Columns[0].Width = 200;
            this.DGV_Subc.Columns[1].HeaderText = "عنوان الاشتراك";
            this.DGV_Subc.Columns[1].Width = 200;
            this.DGV_Subc.Columns[2].HeaderText = "نوع الاشتراك";
            this.DGV_Subc.Columns[2].Width = 200;
            this.DGV_Subc.Columns[3].HeaderText = "الكميه"; //ملغيه عفتها حتى لتلاقي المشاكل بقاعده البيانات
            this.DGV_Subc.Columns[3].Visible = false;
            this.DGV_Subc.Columns[4].HeaderText = "سعر التفعيل";
            this.DGV_Subc.Columns[4].Width = 200;
            this.DGV_Subc.Columns[5].HeaderText = "عمله سعر التفعيل";
            this.DGV_Subc.Columns[5].Width = 200;
            this.DGV_Subc.Columns[6].HeaderText = "تابع للحساب";
            this.DGV_Subc.Columns[6].Width = 200;
            this.DGV_Subc.Columns[7].HeaderText = "السعر الاصلي";
            this.DGV_Subc.Columns[7].Width = 200;
            this.DGV_Subc.Columns[8].HeaderText = "عمله السعر الاصلي";
            this.DGV_Subc.Columns[8].Width = 200;

            lbl_SubcCount.Text = "يتوفر لديك " + this.DGV_Subc.RowCount.ToString() + " انواع من الاشتراكات حاليا";
        }

        private void ShowBinding()
        {
            if(this.DGV_Subc.RowCount !=0 )
            {
                txt_ID.Text = this.DGV_Subc.CurrentRow.Cells[0].Value.ToString();
                txt_Label.Text = this.DGV_Subc.CurrentRow.Cells[1].Value.ToString();
                cmb_Type.Text = this.DGV_Subc.CurrentRow.Cells[2].Value.ToString();
                txt_ActivePrice.Text = this.DGV_Subc.CurrentRow.Cells[4].Value.ToString();
                lbl_MonyType2.Text = this.DGV_Subc.CurrentRow.Cells[8].Value.ToString();
                cmb_Account.Text = this.DGV_Subc.CurrentRow.Cells[6].Value.ToString();
                txt_MainPrice.Text = this.DGV_Subc.CurrentRow.Cells[7].Value.ToString();
                comboBox_MonyType.Text = this.DGV_Subc.CurrentRow.Cells[5].Value.ToString();
            }
        }
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.MainPage.MainPage.GetMainPage.btn_AcountType.Normalcolor = Color.WhiteSmoke;
            Main.MainPage.MainPage.GetMainPage.btn_AcountType.Textcolor = Color.Black;
            Main.MainPage.MainPage.GetMainPage.ShowState = "non";
            Main.MainPage.MainPage.GetMainPage.PageBody.Hide();
        }

        private void FillAccountCombo()
        {
            this.cmb_Account.DataSource = subc.GetAccont();
            this.cmb_Account.DisplayMember = "CODE";
            this.cmb_Account.ValueMember = "MONYTYPE";
            this.lbl_MonyType2.Text  = subc.GetAccountMonyType(this.cmb_Account.Text);
        }
        private void SubscribePage_Load(object sender, EventArgs e)
        {
            FillAccountCombo();
            ShowBinding();
            ShowMonyType = true;
        }
        private void btn_NewSubc_Click(object sender, EventArgs e)
        {
            btn_NewSubc.Enabled = false;
            btn_SaveSUBC.Enabled = true;
            btn_EditSubc.Enabled = false;
            btn_DeleteSubc.Enabled = false;
            btn_CancelNew.Show();
            txt_ID.Clear();
            txt_Label.Clear();
            txt_Label.Focus();
            txt_MainPrice.Clear();
            txt_MainPrice.Clear();
            txt_ActivePrice.Clear();
        }

        private void DGV_Subc_Click(object sender, EventArgs e)
        {
            ShowBinding();
        }

        private void cmb_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.ShowMonyType==true)
            this.lbl_MonyType2.Text=  subc.GetAccountMonyType(this.cmb_Account.Text);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
                FillAccountCombo();
                ShowBinding();
            }
            catch
            {
                return;
            }
        }

        private void btn_CancelNew_Click(object sender, EventArgs e)
        {
            btn_NewSubc.Enabled = true;
            btn_SaveSUBC.Enabled = false;
            btn_EditSubc.Enabled = true;
            btn_DeleteSubc.Enabled = true;
            btn_CancelNew.Hide();
            ShowBinding();
        }

        private void btn_DeleteSubc_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("سيتم حذف هذا النوع من الاشتراكات هل تريد الاستمرار", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    subc.DeleteSubc(Convert.ToInt32(this.txt_ID.Text));
                    MessageBox.Show("تم حذف هذا الاشتراك", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ تحقق من الاتصال");
            }
            finally
            {
                GetData();
                ShowBinding();
            }
        }

        private void btn_SaveSUBC_Click(object sender, EventArgs e)
        {
            try
            {
                subc.SaveSubc(txt_Label.Text, cmb_Type.Text, txt_ActivePrice.Text, lbl_MonyType2.Text, cmb_Account.Text, txt_MainPrice.Text,comboBox_MonyType.Text);
            }
            catch
            {
                MessageBox.Show("حدث خطأ تحقق من الاتصال");
            }
            finally
            {
                btn_NewSubc.Enabled = true;
                btn_SaveSUBC.Enabled = false;
                btn_EditSubc.Enabled = true;
                btn_DeleteSubc.Enabled = true;
                btn_CancelNew.Hide();
                GetData();
                ShowBinding();
            } 
        }

        private void btn_EditSubc_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("سيتم تعديل الاشتراك وفقا للمعلومات في الحقول هل تريد الاستمرار","تاكيد استمرار التعديل",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    subc.EditSubc(txt_Label.Text, cmb_Type.Text, txt_ActivePrice.Text, lbl_MonyType2.Text, cmb_Account.Text, txt_MainPrice.Text, Convert.ToInt32(this.txt_ID.Text),comboBox_MonyType.Text);
                    MessageBox.Show("تم التعديل بنجاح", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ تحقق من الاتصال");
            }
            finally
            {
                GetData();
                ShowBinding();
            }
        }

        private void txt_ActivePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_MainPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_MainPrice_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    lbl_WIN.Text = (Convert.ToDouble(this.txt_ActivePrice.Text) - Convert.ToDouble(this.txt_MainPrice.Text)).ToString();
            //}
            //catch { return; }
        }

        private void txt_ActivePrice_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    lbl_WIN.Text = (Convert.ToDouble(this.txt_ActivePrice.Text) - Convert.ToDouble(this.txt_MainPrice.Text)).ToString();
            //}
            //catch { return; }
        }
    }
}
