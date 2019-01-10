using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan_Internet_Providers.Page.Concerted.AcountPage
{
    public partial class AcountPage : Form
    {
        Class.ClassAccount.Account account = new Class.ClassAccount.Account();
        public AcountPage()
        {
            InitializeComponent();
            AddToolTips();
            GetData();
            SomeSetting();
        }

        private void GetData()
        {
            this.DGV_Acount.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_Acount.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_Acount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Acount.RowTemplate.Height = 28;
            this.DGV_Acount.DataSource = account.GetAccountList();
            this.DGV_Acount.Columns[0].HeaderText = "معرف الحساب";
            this.DGV_Acount.Columns[0].Visible = false;
            this.DGV_Acount.Columns[1].HeaderText = "رمز الحساب";
            this.DGV_Acount.Columns[2].HeaderText = "وصف الحساب";
            this.DGV_Acount.Columns[3].HeaderText = "مالك الحساب";
            this.DGV_Acount.Columns[4].Visible = false; //تاريخ الفتح
            this.DGV_Acount.Columns[5].Visible = false; //اخر تحديث
            this.DGV_Acount.Columns[6].Visible = false; //العمله
            this.DGV_Acount.Columns[7].Visible = false; // كميه المال
            this.DGV_Acount.Columns[8].Visible = false; // حساب رئيسي ام لا
            this.lbl_AccountCount.Text = "لديك " + this.DGV_Acount.RowCount.ToString() + " حساب حاليا";
        }

        private void ShowBinding()
        {
            if(this.DGV_Acount.RowCount!=0)
            {
                txt_AccountCode.Text = this.DGV_Acount.CurrentRow.Cells[1].Value.ToString();
                txt_AccountName.Text = this.DGV_Acount.CurrentRow.Cells[2].Value.ToString();
                txt_AccountOwner.Text = this.DGV_Acount.CurrentRow.Cells[3].Value.ToString();
                DatePicker_StartAccountDate.Value = Convert.ToDateTime(this.DGV_Acount.CurrentRow.Cells[4].Value.ToString());
                DatePicker_LastUpdateOffAccount.Value = Convert.ToDateTime(this.DGV_Acount.CurrentRow.Cells[5].Value.ToString());
                cmb_MonyType.Text = this.DGV_Acount.CurrentRow.Cells[6].Value.ToString();
                txt_AccountQty.Text = this.DGV_Acount.CurrentRow.Cells[7].Value.ToString();
                if (this.DGV_Acount.CurrentRow.Cells[8].Value.ToString() == "main")
                {
                    Checkbox_MainAccount.Checked = true;
                    btn_MainAccount.Image = Properties.Resources.AcountFill;
                }
                else
                {
                    Checkbox_MainAccount.Checked = false;
                    btn_MainAccount.Image = Properties.Resources.Acount;
                }
            }
        }
        private void AddToolTips()
        {
            ToolTip T = new ToolTip();
            T.SetToolTip(btn_GoBack, "اغلاق ورجوع للرئيسيه");
            T.SetToolTip(btn_MainAccount, "تأشيره الحساب الرئيسي");
            T.SetToolTip(btn_Update, "تحديث");
        }
        private void SomeSetting()
        {
            btn_CancelNew.Hide();
        }
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.MainPage.MainPage.GetMainPage.btn_Mony.Normalcolor = Color.WhiteSmoke;
            Main.MainPage.MainPage.GetMainPage.btn_Mony.Textcolor = Color.Black;
            Main.MainPage.MainPage.GetMainPage.ShowState = "non";
            Main.MainPage.MainPage.GetMainPage.PageBody.Hide();
        }
        private void txt_AccountQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }
        private void cmb_MonyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmb_MonyType.Text=="دولار")
            {
                lbl_MonyType.Text = "دولار";
            }
            else if(this.cmb_MonyType.Text=="دينار")
            {
                lbl_MonyType.Text = "دينار";
            }
            else if(this.cmb_MonyType.Text=="اخرى")
            {
                lbl_MonyType.Text = "اخرى";
            }
        }
        private void Checkbox_MainAccount_OnChange(object sender, EventArgs e)
        {
            if(Checkbox_MainAccount.Checked==true)
            {
                btn_MainAccount.Image = Properties.Resources.AcountFill;
            }
            else
            {
                btn_MainAccount.Image = Properties.Resources.Acount;
            }
        }

        private void AcountPage_Load(object sender, EventArgs e)
        {
            ShowBinding();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
                ShowBinding();
            }
            catch
            {
                return;
            }
        }

        private void btn_NewAccount_Click(object sender, EventArgs e)
        {
            Checkbox_MainAccount.Checked = false;
            btn_NewAccount.Enabled = false;
            btn_SaveAccount.Enabled = true;
            btn_EditAccount.Enabled = false;
            btn_DeleteAccount.Enabled = false;
            txt_AccountCode.Clear();
            txt_AccountName.Clear();
            txt_AccountOwner.Clear();
            txt_AccountQty.Clear();
            DatePicker_LastUpdateOffAccount.Value = DateTime.Now.Date;
            DatePicker_StartAccountDate.Value = DateTime.Now.Date;
            Checkbox_MainAccount.Checked = false;
            btn_CancelNew.Show();
            txt_AccountCode.Focus();
        }

        private void btn_SaveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string mainaccount = null;
                if (Checkbox_MainAccount.Checked == true)
                {
                    mainaccount = "main";
                }
                else
                {
                    mainaccount = "notmain";
                }
                account.SaveAccount(txt_AccountCode.Text, txt_AccountName.Text, txt_AccountOwner.Text, DatePicker_StartAccountDate.Value.Date, DatePicker_LastUpdateOffAccount.Value.Date, cmb_MonyType.Text, txt_AccountQty.Text, mainaccount);
                btn_NewAccount.Enabled = true;
                btn_SaveAccount.Enabled = false;
                btn_EditAccount.Enabled = true;
                btn_DeleteAccount.Enabled = true;
                btn_CancelNew.Hide();
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

        private void btn_CancelNew_Click(object sender, EventArgs e)
        {
            btn_NewAccount.Enabled = true;
            btn_SaveAccount.Enabled = false;
            btn_EditAccount.Enabled = true;
            btn_DeleteAccount.Enabled = true;
            btn_CancelNew.Hide();
            ShowBinding();
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل انت متاكد من حذف حسابك قد يحصلل خلل ما اذا كنت متاكد فاستمر", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    account.DeleteAccount(Convert.ToInt32(this.DGV_Acount.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم حذف الحساب", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DGV_Acount_Click(object sender, EventArgs e)
        {
            ShowBinding();
        }

        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("سيتم حفظ التعديلات وفقا للمعلومات في الحقول هل تريد الاستمرار","تاكيد استمرار حفظ التعديلات",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    string mainaccount = null;
                    if (Checkbox_MainAccount.Checked == true)
                    {
                        mainaccount = "main";
                    }
                    else
                    {
                        mainaccount = "notmain";
                    }
                    account.EditAccount(txt_AccountCode.Text, txt_AccountName.Text, txt_AccountOwner.Text, DatePicker_StartAccountDate.Value.Date,DateTime.Now.Date, cmb_MonyType.Text, txt_AccountQty.Text, mainaccount, Convert.ToInt32(this.DGV_Acount.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم حفظ الحفظ", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGV_Acount.DataSource = account.MultiSerach(this.txt_Search.Text);
            }
            catch
            {
                return;
            }
        }

        private void txt_AccountCode_Validated(object sender, EventArgs e)
        {
            try
            {
                if(account.AccountCodeOk(txt_AccountCode.Text)==false)
                {
                    MessageBox.Show("هذا الرمز موجود سابقا","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_AccountCode.BackColor = Color.Red;
                    txt_AccountCode.Clear();
                }
                else
                {
                    txt_AccountCode.BackColor = Color.White;
                }
            }
            catch
            {
                return;
            }
        }
    }
}
