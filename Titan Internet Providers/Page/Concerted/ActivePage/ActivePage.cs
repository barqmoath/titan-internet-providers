using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace Titan_Internet_Providers.Page.Concerted.ActivePage
{
    public partial class ActivePage : Form
    {
        Class.ClassActive.Active active = new Class.ClassActive.Active();
        string PaperType = "نقدي";
        string Debt = null;
        public string UserLogin = null;
        public ActivePage()
        {
            InitializeComponent();
            SomeSetting();
            AddtoolTips();
            this.DGV_Paper.DataSource = active.GetPaperList();
            this.DataGridViewSetting();
        }

        private void AddtoolTips()
        {
            ToolTip T = new ToolTip();
            T.SetToolTip(btn_GoBack, "اغلاق ورجوع للرئيسيه");
            T.SetToolTip(btn_Update, "تحديث");
            T.SetToolTip(btn_DeleteOldpaper, "حذف الورقه المحدده");
            T.SetToolTip(btn_DeleteAllOldpaper, "حذف كافه الاوراق");
            T.SetToolTip(btn_Print, "طباعه الورقه المحدده");
            T.SetToolTip(btn_AddOldDebt, "ادراج الديون السابقه مع التفعيل هذا");
            T.SetToolTip(btn_OpenBrowser, "فتح صفحه الانترنت الافتراضيه");
        }
        private void DataGridViewSetting()
        {
            this.DGV_Paper.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_Paper.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_Paper.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Paper.RowTemplate.Height = 28;
            

            this.DGV_Paper.Columns[0].HeaderText = "معرف الورقه";
            this.DGV_Paper.Columns[0].Width = 170;

            this.DGV_Paper.Columns[1].HeaderText = "تاريخ الورقه";
            this.DGV_Paper.Columns[1].Width = 150;

            this.DGV_Paper.Columns[2].HeaderText = "وقت الورقه";
            this.DGV_Paper.Columns[2].Width = 150;

            this.DGV_Paper.Columns[3].HeaderText = "نوع الورقه";
            this.DGV_Paper.Columns[3].Width = 170;

            this.DGV_Paper.Columns[4].HeaderText = "معرف الشخص";
            this.DGV_Paper.Columns[4].Visible = false;

            this.DGV_Paper.Columns[5].HeaderText = "اسم المشترك";
            this.DGV_Paper.Columns[5].Width = 170;

            this.DGV_Paper.Columns[6].HeaderText = "يوزر المشترك";
            this.DGV_Paper.Columns[6].Width = 170;

            this.DGV_Paper.Columns[7].HeaderText = "معرف الاشتراك";
            this.DGV_Paper.Columns[7].Visible = false;

            this.DGV_Paper.Columns[8].HeaderText = "الاشتراك";
            this.DGV_Paper.Columns[8].Width = 170;

            this.DGV_Paper.Columns[9].HeaderText = "سعر الاشتراك";
            this.DGV_Paper.Columns[9].Width = 170;

            this.DGV_Paper.Columns[10].HeaderText = "كميه التفعيلات";
            this.DGV_Paper.Columns[10].Width = 170;

            this.DGV_Paper.Columns[11].HeaderText = "المبلغ الاجمالي";
            this.DGV_Paper.Columns[11].Width = 170;

            this.DGV_Paper.Columns[12].HeaderText = "المبلغ المستلم";
            this.DGV_Paper.Columns[12].Width = 170;

            this.DGV_Paper.Columns[13].HeaderText = "المبلغ المتبقي";
            this.DGV_Paper.Columns[13].Width = 170;

            this.DGV_Paper.Columns[14].HeaderText = "العمله";
            this.DGV_Paper.Columns[14].Width = 170;

            this.DGV_Paper.Columns[15].HeaderText = "القائم بالتفعيل";
            this.DGV_Paper.Columns[15].Width = 170;

            this.DGV_Paper.Columns[16].HeaderText = "ملاحضات";
            this.DGV_Paper.Columns[16].Width = 250;

            this.DGV_Paper.Columns[17].HeaderText = "تاريخ الانتهاء";
            this.DGV_Paper.Columns[17].Width = 150;
        }
        private void SomeSetting()
        {
            panel_Debt.Hide();
            btn_Cancel.Hide();
            label19.Hide();
            txt_AccountQTY.Hide();
            label20.Hide();
            txt_Cuting.Hide();
            DatePicker_EndDate.Hide();
            label21.Hide();
        }
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.MainPage.MainPage.GetMainPage.btn_Active.Normalcolor = Color.WhiteSmoke;
            Main.MainPage.MainPage.GetMainPage.btn_Active.Textcolor = Color.Black;
            Main.MainPage.MainPage.GetMainPage.ShowState = "non";
            Main.MainPage.MainPage.GetMainPage.PageBody.Hide();
        }

        private void Pnl_Search_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RB_NormalPaper_CheckedChanged(object sender, EventArgs e)
        {
            if(RB_NormalPaper.Checked==true)
            {
                this.PaperType = "نقدي";
                panel_Debt.Hide();
            }
        }

        private void RB_DebtPaper_CheckedChanged(object sender, EventArgs e)
        {
            if(RB_DebtPaper.Checked==true)
            {
                this.PaperType = "ديون";
                panel_Debt.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DatePicker_Paperdate.Value = DateTime.Now.Date;
            this.DatePicker_PaperTime.Value = DateTime.Now.ToLocalTime();
        }

        private void Datepicker_Search_onValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGV_Paper.DataSource = active.SearchWithDate(this.Datepicker_Search.Value.Date);
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
                this.DGV_Paper.DataSource = active.GetPaperList();
            }
            catch
            {
                return;
            }
        }

        private void btn_DeleteOldpaper_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.DGV_Paper.RowCount!=0)
                {
                    if(MessageBox.Show("سيتم حذف الورقه المحدده هل تريد الاستمرار","تاكيد الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {                       
                        active.DeleteOldPaper(Convert.ToInt32(this.DGV_Paper.CurrentRow.Cells[0].Value.ToString()));
                        this.DGV_Paper.DataSource = active.GetPaperList();
                        MessageBox.Show("تم الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        
                }
                
            }
            catch
            {
                MessageBox.Show("حدث خطأ تحقق من الاتصال");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_DeleteAllOldpaper_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DGV_Paper.RowCount != 0)
                {
                    if (MessageBox.Show("سيتم حذف كافه الاوراق هل تريد الاستمرار", "تاكيد التنظيف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        active.DeleteAll();
                        this.DGV_Paper.DataSource = active.GetPaperList();
                        MessageBox.Show("تم تنظيف لوحتك بنجاح", "تم التنظيف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch
            {
                MessageBox.Show("حدث خطأ تحقق من الاتصال");
            }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
        }

        private void txt_Give_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void btn_NewPaper_Click(object sender, EventArgs e)
        {
            ClearTools();
            txt_FindPerson.Focus();
            txt_PersonOldDebt.BackColor = Color.White;

            btn_Savepaper.Enabled = true;
            btn_NewPaper.Enabled = false;
            btn_PrintPaper.Enabled = false;
            this.DatePicker_EndDate.Value = DateTime.Now;
            btn_Cancel.Show();
        }

        private void ClearTools()
        {
            txt_FindPerson.Text = "";
            txt_FindSUBC.Text = "";
            txt_PersonID.Clear();
            txt_PersonName.Clear();
            txt_PersonUser.Clear();
            txt_PersonOldDebt.Text = "0";
            RB_NormalPaper.Checked = true;
            txt_SUBCID.Clear();
            txt_SUBC_Name.Clear();
            txt_SUBCFromAccount.Clear();
            txt_SUBCPRICE.Clear();
            txt_Price.Clear();
            txt_qty.Clear();
            txt_Amount.Text = "0";
            txt_Give.Text="0";
            txt_Rest.Text = "0";
            txt_Nots.Text = "لايوجد ملاحضات";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTools();
            txt_PersonOldDebt.BackColor = Color.White;

            btn_Cancel.Hide();
            btn_NewPaper.Enabled = true;
            btn_Savepaper.Enabled = false;
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Price.Text != string.Empty && txt_qty.Text != string.Empty)
                    txt_Amount.Text = (Convert.ToDouble(txt_Price.Text)*Convert.ToDouble(txt_qty.Text)).ToString();
                this.DatePicker_EndDate.Value = DatePicker_Paperdate.Value.AddDays(30 * Convert.ToInt32(txt_qty.Text));
            }
            catch { return; }
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Amount.Text != string.Empty && txt_Give.Text != string.Empty)
                    txt_Rest.Text = (Convert.ToDouble(txt_Amount.Text) - Convert.ToDouble(txt_Give.Text)).ToString();
            }
            catch { return; }
        }

        private void txt_Give_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Amount.Text != string.Empty && txt_Give.Text != string.Empty)
                    txt_Rest.Text = (Convert.ToDouble(txt_Amount.Text) - Convert.ToDouble(txt_Give.Text)).ToString();
            }
            catch { return; }
        }

        private void txt_FindSUBC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Enter)
                {
                    DataTable FindSubcTable = new DataTable();
                    FindSubcTable = active.GetSubcInfo(this.txt_FindSUBC.Text);
                    if (FindSubcTable.Rows.Count != 0)
                    {
                        txt_SUBCID.Text = FindSubcTable.Rows[0][0].ToString();
                        txt_SUBC_Name.Text = FindSubcTable.Rows[0][1].ToString();
                        lbl_MonyType.Text = FindSubcTable.Rows[0][2].ToString();
                        txt_SUBCFromAccount.Text = FindSubcTable.Rows[0][3].ToString();
                        txt_Price.Text = txt_SUBCPRICE.Text = FindSubcTable.Rows[0][4].ToString();
                        txt_Cuting.Text= FindSubcTable.Rows[0][5].ToString();
                        txt_AccountQTY.Text = active.GetAccountQty(txt_SUBCFromAccount.Text);
                        txt_qty.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }

        private void txt_FindPerson_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Enter)
                {
                    DataTable FinPersonTable = new DataTable();
                    FinPersonTable = active.GetPersonInfo(this.txt_FindPerson.Text);
                    if(FinPersonTable.Rows.Count !=0)
                    {
                        txt_PersonID.Text = FinPersonTable.Rows[0][0].ToString();
                        txt_PersonName.Text = FinPersonTable.Rows[0][1].ToString();
                        txt_PersonUser.Text = FinPersonTable.Rows[0][2].ToString();
                        txt_PersonOldDebt.Text = active.PersonDebtCheck(Convert.ToInt32(this.txt_PersonID.Text));
                        if(txt_PersonOldDebt.Text=="لايوجد")
                        {
                            txt_PersonOldDebt.BackColor = Color.SpringGreen;
                        }
                        else
                        {
                            txt_PersonOldDebt.BackColor = Color.Red;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
        }

        private void txt_PersonOldDebt_TextChanged(object sender, EventArgs e)
        {
            if(this.txt_AccountQTY.Text=="لايوجد")
            {
                this.btn_AddOldDebt.Enabled = false;
            }
            else
            {
                this.btn_AddOldDebt.Enabled = true;
            }
        }

        private void btn_AddOldDebt_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_PersonOldDebt.Text != "لايوجد")
                {
                    txt_Amount.Text = (Convert.ToDouble(this.txt_PersonOldDebt.Text) + Convert.ToDouble(this.txt_Amount.Text)).ToString();
                    txt_PersonOldDebt.Text = "تم الادراج";
                    
                    this.Debt = "ins";
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_Savepaper_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txt_AccountQTY.Text)>0)
            {
                double NewAccount = Convert.ToDouble(txt_AccountQTY.Text) - (Convert.ToDouble(txt_Cuting.Text)*(Convert.ToDouble(txt_qty.Text)));

                //Save Paper
                string PaperType = null;
                if (RB_NormalPaper.Checked == true)
                    PaperType = "نقد";
                else if (RB_DebtPaper.Checked == true)
                    PaperType = "دين";
                
                active.SavePaper(DatePicker_Paperdate.Value, DatePicker_PaperTime.Value.ToLongTimeString(),PaperType, Convert.ToInt32(txt_PersonID.Text), txt_PersonName.Text, txt_PersonUser.Text, Convert.ToInt32(txt_SUBCID.Text), txt_SUBC_Name.Text, txt_SUBCPRICE.Text, txt_qty.Text, txt_Amount.Text, txt_Give.Text, txt_Rest.Text, lbl_MonyType.Text, this.UserLogin, txt_Nots.Text,DatePicker_EndDate.Value);



                //Update Account
                active.UpdateAccount(txt_SUBCFromAccount.Text, Convert.ToString(NewAccount));

                //if The Debt Paper Save Debt
                if (RB_DebtPaper.Checked == true)
                {
                    active.SaveDebt(active.GetMaxPaperID(), Convert.ToInt32(txt_PersonID.Text), txt_PersonName.Text, txt_PersonUser.Text, txt_Rest.Text, DatePicker_LastDate.Value.Date, lbl_MonyType.Text);
                }

                //Update Status
                DateTime EndDate = DatePicker_Paperdate.Value.AddDays(30 * Convert.ToInt32(txt_qty.Text));
                active.UpdateStatus(Convert.ToInt32(txt_SUBCID.Text), txt_SUBC_Name.Text, "فعال", DatePicker_Paperdate.Value.Date, EndDate, Convert.ToInt32(txt_PersonID.Text));


                //Delete old Debt IF Inserted
                if(this.Debt=="ins")
                {
                    active.DeletOldDebt(Convert.ToInt32(txt_PersonID.Text));
                }
                //--------
                this.DGV_Paper.DataSource = active.GetPaperList();
                ClearTools();
                txt_PersonOldDebt.BackColor = Color.White;

                btn_Cancel.Hide();
                btn_NewPaper.Enabled = true;
                btn_Savepaper.Enabled = false;
                btn_PrintPaper.Enabled = true;
            }
        }

        private void txt_FindPerson_Validated(object sender, EventArgs e)
        {
            int A = active.CheckState(Convert.ToInt32(txt_PersonID.Text));
            if (A != 0)
            {
                MessageBox.Show("هذه المشترك لم ينته اشتراكه سيتم التفعيل فوق الاشتراك القديم اذا قمت بالاستمرار تبقى" + A.ToString(), "حاله المشترك", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.DGV_Paper.RowCount!=0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Report.ReportPage.ActivePaperReportPage P = new Report.ReportPage.ActivePaperReportPage();
                    P.PaperID = Convert.ToInt32(this.DGV_Paper.CurrentRow.Cells[0].Value.ToString());
                    P.ShowDialog();
                    this.Cursor = Cursors.Default;
                }              
            }
            catch
            {
                MessageBox.Show("حدث خطأ .. اذا كنت تستخدم اتصال الانترنت فتحقق من اتصالك");
            }
        }

        private void btn_PrintPaper_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Report.ReportPage.ActivePaperReportPage P = new Report.ReportPage.ActivePaperReportPage();
                P.PaperID = active.GetMaxPaperID();
                P.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("حدث خطأ .. اذا كنت تستخدم اتصال الانترنت فتحقق من اتصالك");
            }
        }

        private void btn_OpenBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                string browserPath = GetBrowserPath();
                if (browserPath == string.Empty)
                    browserPath = "iexplore";
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo(browserPath);
                process.StartInfo.Arguments = Properties.Settings.Default.Defualt_Web_Page;
                process.Start();
            }
            catch
            {
                return;
            }
        }


        private static string GetBrowserPath()
        {
            string browser = string.Empty;
            RegistryKey key = null;

            try
            {
                // try location of default browser path in XP
                key = Registry.ClassesRoot.OpenSubKey(@"HTTP\shell\open\command", false);

                // try location of default browser path in Vista
                if (key == null)
                {
                    key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http", false); ;
                }

                if (key != null)
                {
                    //trim off quotes
                    browser = key.GetValue(null).ToString().ToLower().Replace("\"", "");
                    if (!browser.EndsWith("exe"))
                    {
                        //get rid of everything after the ".exe"
                        browser = browser.Substring(0, browser.LastIndexOf(".exe") + 4);
                    }

                    key.Close();
                }
            }
            catch
            {
                return string.Empty;
            }

            return browser;
        }
    }
}
