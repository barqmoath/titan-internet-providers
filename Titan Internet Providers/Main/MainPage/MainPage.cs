using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Titan_Internet_Providers.Main.MainPage
{
    public partial class MainPage : Form
    {
        //The Varible
        ToolTip tooltips = new ToolTip();
        public string ShowState = "non";
        private static MainPage page;
        public string UserType="admin";



        //----------------------------------


        //Control This Page From Another Pages ---------------------------
        static void page_FormClosed(object sender, FormClosedEventArgs e){ page = null; }
        public static MainPage GetMainPage
        {
            get
            {
                if (page == null)
                {
                   page = new MainPage();
                   page.FormClosed += new FormClosedEventHandler(page_FormClosed);
                }
                return page;
            }
        }
        //--------------------------------------
        public MainPage()
        {
            if (page == null)
                page = this;
            InitializeComponent();
            ShowLogin();
            AddToolTips();
            SomeSetting();
        }

        private void ShowLogin()
        {
            Activtion.LoginPage.LoginPage login = new Activtion.LoginPage.LoginPage();
            login.ShowDialog();
        }
        private void AddToolTips()
        {
            tooltips.SetToolTip(btn_Exit, "اغلاق");
            tooltips.SetToolTip(btn_Maximize, "تكبير");
            tooltips.SetToolTip(btn_Minimaze, "اخفاء");
            tooltips.SetToolTip(btn_About, "حول البرنامج");
            tooltips.SetToolTip(btn_Help, "احصل على المساعده");
            tooltips.SetToolTip(btn_Menu, "فتح القائمه");
            tooltips.SetToolTip(btn_OptionsMenu, "خيارات");
            tooltips.SetToolTip(btn_TimeAlert, "المنبه");
            tooltips.SetToolTip(btn_Calculator, "الاله الحاسبه");
            tooltips.SetToolTip(TitanAppLogo, "Titan Internet Providers");
            tooltips.SetToolTip(btn_LogOut, "تسجيل الخروج");
        }

        private void SomeSetting()
        {
            
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            PageBody.Hide();
            //Get The Wotk Area With out taskbar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            //---------------------------------
            AlertClockPanel.Hide();


            MainStartPanel.Location = new Point(this.StartPanel.Width / 2 - MainStartPanel.Size.Width / 2,this.StartPanel.Height / 2 - MainStartPanel.Size.Height / 2);
            MainStartPanel.Anchor = AnchorStyles.None;

            //Show Peroson Count
            lbl_PersonCount1.Text = "لديك " + Properties.Settings.Default.PersonCount.ToString() + " مشتركين حاليا";
            lbl_PersonCount2.Text = Properties.Settings.Default.PersonCount.ToString() + " هو اجمالي مشتركيك حاليا في جميع نقاط التوزيع وجميع اجهزه البث";

            //ShowDebt
            Class.ClassDebtAlert.Debt debt = new Class.ClassDebtAlert.Debt();
            if(debt.ShowNumberOfPersonDebt()==0)
            {
                pictureBox_FindDebt.Image = Properties.Resources.money_bag;
                lbl_FindDebt1.Text = "استرح لايوجد مشتركين يجب الاتصال بهم";
                lbl_FindeDebt2.Text = "جميع الحسابات تم استلامها فلا داعي للاتصال باي مشترك لابلاغه بتسديد ديونه";
            }
            else if(debt.ShowNumberOfPersonDebt() != 0)
            {
                try
                {
                    pictureBox_FindDebt.Image = Properties.Resources.red_money_bag;
                    lbl_FindDebt1.Text = debt.ShowNumberOfPersonDebt().ToString() + " مشتركين عليك الاتصال بهم";
                    lbl_FindeDebt2.Text = "يجب عليك الاتصال ببعض المشتركين لوجود ديون عليهم يجب استلامها .. راجع لوحه الديون";
                }
                catch { return; }              
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Activtion.LoginPage.LoginPage.GetLoginPage.Show();
            Activtion.LoginPage.LoginPage.GetLoginPage.txt_Password.Text = "";
            Activtion.LoginPage.LoginPage.GetLoginPage.txt_Username.Text = "";
        }
        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                tooltips.SetToolTip(btn_Maximize, "تكبير");
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                tooltips.SetToolTip(btn_Maximize, "تصغير");
            }
        }
        private void btn_Minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (this.MainMenu.Width == 40)
            {
                this.MainMenu.Width = 215;
                tooltips.SetToolTip(btn_Menu, "غلق  القائمه");
            }
            else if (this.MainMenu.Width == 215)
            {
                this.MainMenu.Width = 40;
                tooltips.SetToolTip(btn_Menu, "فتح القائمه");
            }
                
        }
        private void btn_OptionsMenu_Click(object sender, EventArgs e)
        {
            //Show The Options Menu
            OptionsContextMenuStrip.Show(btn_OptionsMenu, new Point(0, btn_OptionsMenu.Height));
        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
            
        }
        private void Notifications_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Process prcs = null;
                if(prcs == null)
                {
                    prcs = new Process();
                    prcs.StartInfo.FileName= "Calc.exe"; ;
                    prcs.Start();
                }
                else
                {
                    prcs.Close();
                    prcs.Dispose();
                }
                this.Cursor = Cursors.Default;
            }
            catch
            {
                return;
            }
        }

        private void OCMP_btn_ConnectionSetting_Click(object sender, EventArgs e)
        {
            Page.Separated.Connect_Setting_Page.Connect_Setting_Page P = new Page.Separated.Connect_Setting_Page.Connect_Setting_Page();
            P.ShowDialog();
        }

        private void OCMP_btn_Backup_Click(object sender, EventArgs e)
        {
            Page.Separated.Backup_Page.BackupPage P = new Page.Separated.Backup_Page.BackupPage();
            P.ShowDialog();
        }

        private void OCMP_btn_Format_Click(object sender, EventArgs e)
        {
            if(this.UserType=="admin")
            {
                if (MessageBox.Show(" تحذير تؤدي هذه العمليه الى فقدان كافه البيانات تأكد من انك قمت بنسخه احتياطيه من بياناتك تحسبا لاي طارئ قبل الاستمرار بهذه العمليه", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (MessageBox.Show("هل انت متاكد من التهيئه لايمكن التراجع بعد ذالك وستفقد بياناتك كن حذراُ", "تأكيد التهيئه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Main.MainClass.DataControl control = new MainClass.DataControl();
                        control.Execution("FORMATEE", null);
                        MessageBox.Show("تمت تهيئه البرنامج بنجاح", "اتمام التهيئه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Properties.Settings.Default.PersonCount = 0;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون  فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_Person_Click(object sender, EventArgs e)
        {
            if (this.UserType == "admin" || this.UserType == "user")
            {
                if (this.ShowState == "non")
                {
                    Page.Concerted.PersonPage.PersonPage P = new Page.Concerted.PersonPage.PersonPage();
                    P.TopLevel = false;
                    PageBody.Controls.Add(P);
                    P.Dock = DockStyle.Fill;
                    P.Show();
                    this.btn_Person.Normalcolor = Color.FromArgb(237, 28, 36);
                    this.btn_Person.Textcolor = Color.White;
                    this.ShowState = "personpageshow";
                    PageBody.Show();
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون والمستخدمين فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_StopAlertClock_Click(object sender, EventArgs e)
        {
            AlertClockPanel.Hide();
            Page.Separated.AlertClock.AlertClockPage.GetAlertClock.Player.Stop();
            Page.Separated.AlertClock.AlertClockPage.GetAlertClock.txt_NOTS.BackColor = Color.White;
            Page.Separated.AlertClock.AlertClockPage.GetAlertClock.txt_NOTS.Enabled = true;
            Page.Separated.AlertClock.AlertClockPage.GetAlertClock.DatePickerTime.Enabled = true;
            Page.Separated.AlertClock.AlertClockPage.GetAlertClock.btn_Start.Enabled = true;
            Page.Separated.AlertClock.AlertClockPage.GetAlertClock.btn_Stop.Enabled = false;
            Page.Separated.AlertClock.AlertClockPage.GetAlertClock.btn_ChangeTone.Enabled = true;
            Page.Separated.AlertClock.AlertClockPage.GetAlertClock.lbl_State.Text = "تم ايقاف المنبه";
            btn_TimeAlert.Image = Properties.Resources.AlertClock_Stop;
        }

        private void btn_TimeAlert_Click(object sender, EventArgs e)
        {
            Page.Separated.AlertClock.AlertClockPage P = new Page.Separated.AlertClock.AlertClockPage();
            P.ShowDialog();
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            if (this.UserType == "admin" || this.UserType == "user")
            {
                if (this.ShowState == "non")
                {
                    Page.Concerted.PersonStatusPage.PersonStatusPage P = new Page.Concerted.PersonStatusPage.PersonStatusPage();
                    P.TopLevel = false;
                    PageBody.Controls.Add(P);
                    P.Dock = DockStyle.Fill;
                    P.Show();
                    this.btn_Status.Normalcolor = Color.FromArgb(78, 186, 76);
                    this.btn_Status.Textcolor = Color.White;
                    this.ShowState = "personStauspageshow";
                    PageBody.Show();
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون والمستخدمين  فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            lbl_LocalTime.Text = DateTime.Now.ToLongTimeString();
            lbl_LocalDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_Points_Click(object sender, EventArgs e)
        {
            if (this.UserType == "admin")
            {
                if (this.ShowState == "non")
                {
                    Page.Concerted.PointPage.PointPage P = new Page.Concerted.PointPage.PointPage();
                    P.TopLevel = false;
                    PageBody.Controls.Add(P);
                    P.Dock = DockStyle.Fill;
                    P.Show();
                    this.btn_Points.Normalcolor = Color.FromArgb(0, 131, 255);
                    this.btn_Points.Textcolor = Color.White;
                    this.ShowState = "pointpageshow";
                    PageBody.Show();
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }

        private void btn_Mony_Click(object sender, EventArgs e)
        {
            if(this.UserType=="admin")
            {
                if (this.ShowState == "non")
                {
                    Page.Concerted.AcountPage.AcountPage P = new Page.Concerted.AcountPage.AcountPage();
                    P.TopLevel = false;
                    PageBody.Controls.Add(P);
                    P.Dock = DockStyle.Fill;
                    P.Show();
                    this.btn_Mony.Normalcolor = Color.FromArgb(79, 186, 111);
                    this.btn_Mony.Textcolor = Color.White;
                    this.ShowState = "monypageshow";
                    PageBody.Show();
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_AcountType_Click(object sender, EventArgs e)
        {
            if (this.UserType == "admin")
            {
                if (this.ShowState == "non")
                {
                    Page.Concerted.SubscribePage.SubscribePage P = new Page.Concerted.SubscribePage.SubscribePage();
                    P.TopLevel = false;
                    PageBody.Controls.Add(P);
                    P.Dock = DockStyle.Fill;
                    P.Show();
                    this.btn_AcountType.Normalcolor = Color.FromArgb(50, 190, 166);
                    this.btn_AcountType.Textcolor = Color.White;
                    this.ShowState = "subcpageshow";
                    PageBody.Show();
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            if (this.UserType == "admin" || this.UserType=="user" || this.UserType=="casher")
            {
                if (this.ShowState == "non")
                {
                    Page.Concerted.ActivePage.ActivePage P = new Page.Concerted.ActivePage.ActivePage();
                    P.UserLogin = this.lbl_UserName.Text;
                    P.TopLevel = false;
                    PageBody.Controls.Add(P);
                    P.Dock = DockStyle.Fill;
                    P.Show();
                    this.btn_Active.Normalcolor = Color.FromArgb(136, 197, 204);
                    this.btn_Active.Textcolor = Color.White;
                    this.ShowState = "activepageshow";
                    PageBody.Show();
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            if (this.UserType == "admin")
            {
                Page.Separated.UsersPage.UserPage P = new Page.Separated.UsersPage.UserPage();
                P.ShowDialog();
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            Activtion.AboutProgramPage.AboutPage P = new Activtion.AboutProgramPage.AboutPage();
            P.ShowDialog();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            Activtion.HelpPage.HelpPage P = new Activtion.HelpPage.HelpPage();
            P.ShowDialog();
        }

        private void btn_Debt_Click(object sender, EventArgs e)
        {
            if (this.UserType == "admin" || this.UserType=="user")
            {
                Page.Concerted.DebtPage.DebtPage P = new Page.Concerted.DebtPage.DebtPage();
                P.TopLevel = false;
                PageBody.Controls.Add(P);
                P.Dock = DockStyle.Fill;
                P.Show();
                this.btn_Debt.Normalcolor = Color.FromArgb(224, 79, 95);
                this.btn_Debt.Textcolor = Color.White;
                this.ShowState = "debtpageshow";
                PageBody.Show();
            }
            else
            {
                MessageBox.Show("غير مسموح لك بالوصول الى هذه القائمه وفقا لصلاحيات المستخدمين فالمديرون فقط يمكنهم الوصول الى هذه القائمه", "لايمكن الوصول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OCMP_btn_ُEdit_Defualt_Web_Page_Click(object sender, EventArgs e)
        {
            Page.Separated.ReadNewWebPage_Page.NewPage_Page P = new Page.Separated.ReadNewWebPage_Page.NewPage_Page();
            P.ShowDialog();
        }
    }
}
