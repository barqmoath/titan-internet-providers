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

namespace Titan_Internet_Providers.Page.Concerted.PersonPage
{
    public partial class PersonPage : Form
    {
        //Some Varibe-----
        Class.ClassPerson.Person person = new Class.ClassPerson.Person();

        //----------------
        public PersonPage()
        {
            InitializeComponent();
            AddToolTips();
            DisplyPersonList();
            DataGridViewSetting();
            FillComboBox();
        }
        private void AddToolTips()
        {
            ToolTip T = new ToolTip();
            T.SetToolTip(btn_GoBack, "اغلاق ورجوع للرئيسه");
            T.SetToolTip(btn_Update, "تحديث");
            T.SetToolTip(Datepicker_Search, "بحث باستخدام تاريخ الانضمام");
            T.SetToolTip(btn_StarPerson, "المشترك المميز");
            T.SetToolTip(btn_Print, "طباعه ");
            T.SetToolTip(btn_ShowLocation, "موقع المشترك على الخريطه");
            T.SetToolTip(txt_Location, "اضغط على زر تحديد موقع ثم حدد موقع المشترك ثم انسخ احداثيات موقعه هنا");
        }
        private void DisplyPersonList()
        {
            this.DGV_Person.DataSource = person.GetPersonList();
        }
        private void DataGridViewSetting()
        {
            this.DGV_Person.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_Person.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_Person.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Person.RowTemplate.Height = 28;
            this.DGV_Person.Columns[0].HeaderText = "معرف المشترك";
            this.DGV_Person.Columns[0].Visible = false;
            this.DGV_Person.Columns[1].HeaderText = "اسم المشترك";
            this.DGV_Person.Columns[1].Width = 150;
            this.DGV_Person.Columns[2].HeaderText = "يوزر المشترك";
            this.DGV_Person.Columns[2].Width = 150;
            this.DGV_Person.Columns[3].HeaderText = "الباسوورد";
            this.DGV_Person.Columns[3].Visible = false;
            this.DGV_Person.Columns[4].HeaderText = "نقطه التوزيع";
            this.DGV_Person.Columns[4].Width = 150;
            this.DGV_Person.Columns[5].HeaderText = "الجهاز";
            this.DGV_Person.Columns[5].Width = 150;
            this.DGV_Person.Columns[6].HeaderText = "رقم الهاتف";
            this.DGV_Person.Columns[6].Width = 150;
            this.DGV_Person.Columns[7].HeaderText = "عنوان السكن";
            this.DGV_Person.Columns[7].Width = 150;
            this.DGV_Person.Columns[8].HeaderText = "عنوان IP";
            this.DGV_Person.Columns[8].Width = 150;
            this.DGV_Person.Columns[9].HeaderText = "عنوان MAC";
            this.DGV_Person.Columns[9].Width = 150;
            this.DGV_Person.Columns[10].HeaderText = "مشترك مميز ام لا";
            this.DGV_Person.Columns[10].Visible = false;
            this.DGV_Person.Columns[11].HeaderText = "تاريخ الانضمام";
            this.DGV_Person.Columns[11].Width = 150;
            this.DGV_Person.Columns[12].HeaderText = "ملاحضات";
            this.DGV_Person.Columns[12].Visible = false;
            this.DGV_Person.Columns[13].HeaderText = "الموقع على الخريطه";
            this.DGV_Person.Columns[13].Visible = false;
            lbl_PersonCount.Text = "لديك  " + this.DGV_Person.RowCount.ToString() + "  مشتركين حالياُ";
        }
        private void FillComboBox()
        {
            this.cmb_Point.DataSource = person.GetThePointList();
            this.cmb_Point.DisplayMember = "LABEL";
            this.cmb_Point.ValueMember = "ID";

            this.cmb_Device.DataSource = person.GetTheDeviceList(Convert.ToInt32(this.cmb_Point.SelectedValue));
            this.cmb_Device.DisplayMember = "LABEL";
            this.cmb_Device.ValueMember = "ID";
        }
        private void ShowOnBinding()
        {
            if (this.DGV_Person.RowCount != 0)
            {
                txt_PersonName.Text = this.DGV_Person.CurrentRow.Cells[1].Value.ToString();
                txt_PersonUser.Text = this.DGV_Person.CurrentRow.Cells[2].Value.ToString();
                txt_PersonPassword.Text = this.DGV_Person.CurrentRow.Cells[3].Value.ToString();
                cmb_Point.Text = this.DGV_Person.CurrentRow.Cells[4].Value.ToString();
                cmb_Device.Text = this.DGV_Person.CurrentRow.Cells[5].Value.ToString();
                txt_Phone.Text = this.DGV_Person.CurrentRow.Cells[6].Value.ToString();
                txt_Home.Text = this.DGV_Person.CurrentRow.Cells[7].Value.ToString();
                txt_IP.Text = this.DGV_Person.CurrentRow.Cells[8].Value.ToString();
                txt_Mac.Text = this.DGV_Person.CurrentRow.Cells[9].Value.ToString();
                txt_NOTS.Text= this.DGV_Person.CurrentRow.Cells[12].Value.ToString();
                txt_Location.Text = this.DGV_Person.CurrentRow.Cells[13].Value.ToString();
           
                if (this.DGV_Person.CurrentRow.Cells[10].Value.ToString() == "star")
                {
                    this.btn_StarPerson.Image = Properties.Resources.StarPerson;
                    Checkbox_StarPerson.Checked = true;
                }
                else
                {
                    this.btn_StarPerson.Image = Properties.Resources.NorStartPerson;
                    Checkbox_StarPerson.Checked = false;
                }
            }
        }
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.MainPage.MainPage.GetMainPage.btn_Person.Normalcolor = Color.WhiteSmoke;
            Main.MainPage.MainPage.GetMainPage.btn_Person.Textcolor = Color.Black;
            Main.MainPage.MainPage.GetMainPage.ShowState = "non";
            Main.MainPage.MainPage.GetMainPage.PageBody.Hide();
        }
        private void Pnl_Search_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ToolsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Checkbox_Showpassword_OnChange(object sender, EventArgs e)
        {
            if (Checkbox_Showpassword.Checked == true)
            {
                txt_PersonPassword.UseSystemPasswordChar = false;
            }
            else
                txt_PersonPassword.UseSystemPasswordChar = true;
        }
        private void Checkbox_StarPerson_OnChange(object sender, EventArgs e)
        {
            if(Checkbox_StarPerson.Checked==true)
            {
                this.btn_StarPerson.Image = Properties.Resources.StarPerson;
            }
            else
            {
                this.btn_StarPerson.Image = Properties.Resources.NorStartPerson;
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DisplyPersonList();
            DataGridViewSetting();
            FillComboBox();
        }
        private void DGV_Person_Click(object sender, EventArgs e)
        {
            ShowOnBinding();
        }
        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGV_Person.DataSource = person.MultiSeatch(txt_Search.Text);
            }
            catch
            { return; }
           
        }
        private void btn_DefultSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.DGV_Person.DataSource = person.MultiSeatch(txt_Search.Text);
            }
            catch
            { return; }
        }
        private void Datepicker_Search_onValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGV_Person.DataSource = person.SearchWithDate(Datepicker_Search.Value.Date);
            }
            catch
            { return; }
        }
        private void btn_NewPerson_Click(object sender, EventArgs e)
        {
            btn_NewPerson.Enabled = false;
            btn_SavePerson.Enabled = true;
            btn_DeletePerson.Enabled = false;
            btn_EditPerson.Enabled = false;
            btn_PersonState.Enabled = false;
            btn_CancelNew.Show();
            txt_PersonName.Clear();
            txt_PersonUser.Clear();
            txt_PersonPassword.Clear();
            txt_IP.Clear();
            txt_Mac.Clear();
            txt_Phone.Clear();
            txt_Home.Clear();
            txt_NOTS.Text = "اكتب ملاحضاتك هنا";
            txt_Location.Clear();
            txt_PersonName.Focus();
            Checkbox_StarPerson.Checked = false;
            Checkbox_Showpassword.Checked = false;
        }
        private void btn_SavePerson_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //Save The Person Information -------
                string Starperson = "notstar";
                if (Checkbox_StarPerson.Checked == true)
                    Starperson = "star";
                person.SavePersonInformation(txt_PersonName.Text, txt_PersonUser.Text, txt_PersonPassword.Text, cmb_Point.Text, cmb_Device.Text, txt_Phone.Text, txt_Home.Text, txt_IP.Text, txt_Mac.Text, Starperson, DateTime.Now.Date,txt_NOTS.Text,txt_Location.Text);

                // Save Person State -----------------
                int PersonID = person.GetMaxPersonID();
                person.SavePersonState(PersonID,txt_PersonName.Text,txt_PersonUser.Text);

                //Update The Page
                DisplyPersonList();
                DataGridViewSetting();
                FillComboBox();
                btn_NewPerson.Enabled = true;
                btn_SavePerson.Enabled = false;
                btn_DeletePerson.Enabled = true;
                btn_EditPerson.Enabled = true;
                btn_PersonState.Enabled = true;
                btn_CancelNew.Hide();
            }
            catch
            {
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                Properties.Settings.Default.PersonCount = this.DGV_Person.RowCount;
                Properties.Settings.Default.Save();
                Main.MainPage.MainPage.GetMainPage.lbl_PersonCount1.Text = "لديك " + Properties.Settings.Default.PersonCount.ToString() + " مشتركين حاليا";
                Main.MainPage.MainPage.GetMainPage.lbl_PersonCount2.Text = Properties.Settings.Default.PersonCount.ToString() + " هو اجمالي مشتركيك حاليا في جميع نقاط التوزيع وجميع اجهزه البث";
            }
            
        }
        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            btn_NewPerson.Enabled = true;
            btn_SavePerson.Enabled = false;
            btn_DeletePerson.Enabled = true;
            btn_EditPerson.Enabled = true;
            btn_PersonState.Enabled = true;
            btn_CancelNew.Hide();
            ShowOnBinding();
        }
        private void btn_DeletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.DGV_Person.RowCount !=0)
                {
                    if (MessageBox.Show("هل انت متاكد من حذف المشترك", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        person.DeletePerson(Convert.ToInt32(this.DGV_Person.CurrentRow.Cells[0].Value.ToString()));
                        if (MessageBox.Show("تم الحذف .. هل تريد حذف هذا للمشترك من قائمه حالات الاشتراك؟", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            person.DeletePersonState(Convert.ToInt32(this.DGV_Person.CurrentRow.Cells[0].Value.ToString()));
                        }
                    }
                }
            }
            catch
            { MessageBox.Show("حدث خطأ اعد المحاوله لاحقا .. او اذا كنت تستخدم اتصال الانترنت فتحقق من اتصالك"); }
            finally
            {
                DisplyPersonList();
                DataGridViewSetting();
                FillComboBox();
                ShowOnBinding();
                Properties.Settings.Default.PersonCount = this.DGV_Person.RowCount;
                Properties.Settings.Default.Save();
                Main.MainPage.MainPage.GetMainPage.lbl_PersonCount1.Text = "لديك " + Properties.Settings.Default.PersonCount.ToString() + " مشتركين حاليا";
                Main.MainPage.MainPage.GetMainPage.lbl_PersonCount2.Text = Properties.Settings.Default.PersonCount.ToString() + " هو اجمالي مشتركيك حاليا في جميع نقاط التوزيع وجميع اجهزه البث";
            }
        }
        private void DGV_Person_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void PersonPage_Load(object sender, EventArgs e)
        {
            ShowOnBinding();
            btn_CancelNew.Hide();
        }
        private void btn_EditPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("سيتم تحديث معلومات المشترك المحدد وفقا للمعلومات المعدله في الحقول ", "تاكيد استمرار التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Starperson = null;
                    if (Checkbox_StarPerson.Checked == true)
                        Starperson = "star";
                    else
                        Starperson = "notstar";
                    person.UpdatePersonInformation(Convert.ToInt32(this.DGV_Person.CurrentRow.Cells[0].Value.ToString()), txt_PersonName.Text, txt_PersonUser.Text, txt_PersonPassword.Text, cmb_Point.Text, cmb_Device.Text, txt_Phone.Text, txt_Home.Text, txt_IP.Text, txt_Mac.Text, Starperson, Convert.ToDateTime(this.DGV_Person.CurrentRow.Cells[11].Value), txt_NOTS.Text,txt_Location.Text);
                    DisplyPersonList();
                    ShowOnBinding();
                    MessageBox.Show("تم التعديل بنجاح");
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ .. اذا كنت تستخدم اتصال الانترنت فتحقق من اتصالك");
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Report.ReportPage.ReportPage P = new Report.ReportPage.ReportPage();
                P.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("حدث خطأ .. اذا كنت تستخدم اتصال الانترنت فتحقق من اتصالك");
            }
        }

        private void btn_PersonState_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(person.ShowPersonState(Convert.ToInt32(this.DGV_Person.CurrentRow.Cells[0].Value.ToString())) + "", "حاله المشترك", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("حدث خطأ .. اذا كنت تستخدم اتصال الانترنت فتحقق من اتصالك");
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
        private void btn_ShowLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string browserPath = GetBrowserPath();
                if (browserPath == string.Empty)
                    browserPath = "iexplore";
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo(browserPath);
                process.StartInfo.Arguments = "https://www.google.com.eg/maps/place/" + txt_Location.Text;
                process.Start();
            }
            catch
            {
                return;
            }
        }

        private void btn_SelectLoCation_Click(object sender, EventArgs e)
        {
            try
            {
                string browserPath = GetBrowserPath();
                if (browserPath == string.Empty)
                    browserPath = "iexplore";
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo(browserPath);
                process.StartInfo.Arguments = "https://maps.google.com/";
                process.Start();
            }
            catch
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PersonPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Properties.Settings.Default.PersonCount = this.DGV_Person.RowCount;
            //Properties.Settings.Default.Save();
            //Main.MainPage.MainPage.GetMainPage.lbl_PersonCount1.Text = "لديك " + Properties.Settings.Default.PersonCount.ToString() + " مشتركين حاليا";
            //Main.MainPage.MainPage.GetMainPage.lbl_PersonCount2.Text = Properties.Settings.Default.PersonCount.ToString() + " هو اجمالي مشتركيك حاليا في جميع نقاط التوزيع وجميع اجهزه البث";
        }

        private void cmb_Point_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                    this.cmb_Device.DataSource = person.GetTheDeviceList(Convert.ToInt32(this.cmb_Point.SelectedValue));
                    this.cmb_Device.DisplayMember = "LABEL";
                    this.cmb_Device.ValueMember = "ID";
            }
            catch
            {
                return;
            }
        }
    }
}
