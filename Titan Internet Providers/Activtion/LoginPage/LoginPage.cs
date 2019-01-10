using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan_Internet_Providers.Activtion.LoginPage
{
    public partial class LoginPage : Form
    {
        public static LoginPage page;

        static void page_FormClosed(object sender, FormClosedEventArgs e) { page = null; }
        public static LoginPage GetLoginPage
        {
            get
            {
                if (page == null)
                {
                    page = new LoginPage();
                    page.FormClosed += new FormClosedEventHandler(page_FormClosed);
                }
                return page;
            }
        }

        public LoginPage()
        {
            if (page == null)
                page = this;
            InitializeComponent();
        }

        private void btn_Leave_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Class.ClassLogin.Login login = new Class.ClassLogin.Login(this.txt_Username.Text, this.txt_Password.Text);
                if (login.TheLoginOk() == true)
                {
                    this.Close();
                    Main.MainPage.MainPage.GetMainPage.UserType= login.GetUserType();
                    Main.MainPage.MainPage.GetMainPage.lbl_UserName.Text = login.GetUserName();
                }
                else
                {
                    MessageBox.Show("فشل الدخول تحقق من معلوماتك");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkLabel_ConnectionSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page.Separated.Connect_Setting_Page.Connect_Setting_Page p = new Page.Separated.Connect_Setting_Page.Connect_Setting_Page();
            p.ShowDialog();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btn_Login_Click(this, new EventArgs());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Activtion.HelpPage.HelpPage P = new HelpPage.HelpPage();
            P.ShowDialog();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
           // if (Properties.Settings.Default.StartDate == null)
           // {
           //     Properties.Settings.Default.StartDate = DateTime.Now.Date.AddDays(3);
           //     Properties.Settings.Default.Save();
           // }

           //if(Properties.Settings.Default.StartDate==DateTime.Now.Date)
           //{
           //     this.Close();
           //     Environment.Exit(1);
           //}




           this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           this.WindowState = FormWindowState.Maximized;

            panel2.Location = new Point(this.Width / 2 -panel2.Size.Width / 2, this.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}
