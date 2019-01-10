using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Titan_Internet_Providers.Page.Separated.AlertClock
{
    public partial class AlertClockPage : Form
    {
        public SoundPlayer Player = new SoundPlayer();
        private static AlertClockPage page;
        static void page_FormClosed(object sender, FormClosedEventArgs e) { page = null; }
        public static AlertClockPage GetAlertClock
        {
            get
            {
                if (page == null)
                {
                    page = new AlertClockPage();
                    page.FormClosed += new FormClosedEventHandler(page_FormClosed);
                }
                return page;
            }
        }


        public AlertClockPage()
        {
            if (page == null)
                page = this;
            InitializeComponent();
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimerNowTime_Tick(object sender, EventArgs e)
        {
            lbl_NowTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_ChangeTone_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Sound files (*.wav, *.mp3, *.m4a) | *.wav; *.mp3; *.m4a";
            if(OFD.ShowDialog()==DialogResult.OK)
            {
                Properties.Settings.Default.AlertToneFilename = OFD.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
            btn_ChangeTone.Enabled = false;
            txt_NOTS.Enabled = false;
            DatePickerTime.Enabled = false;
            TimerAlert.Start();
            lbl_State.Text = "المنبه يعمل سيرن في الوقت المحدد";
            Properties.Settings.Default.AlertMessage = txt_NOTS.Text;
            Properties.Settings.Default.Save();
            txt_NOTS.Text = Properties.Settings.Default.AlertMessage;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            btn_ChangeTone.Enabled = true;
            txt_NOTS.Enabled = true;
            DatePickerTime.Enabled = true;
            TimerAlert.Stop();
            Player.Stop();
            lbl_State.Text = "تم ايقاف المنبه";
            txt_NOTS.BackColor = Color.White;
            Main.MainPage.MainPage.GetMainPage.AlertClockPanel.Hide();
            Main.MainPage.MainPage.GetMainPage.btn_TimeAlert.Image = Properties.Resources.AlertClock_Stop;
        }

        private void TimerAlert_Tick(object sender, EventArgs e)
        {
            DateTime CTime = DateTime.Now;
            DateTime UTime = DatePickerTime.Value;

            if(UTime.Hour==CTime.Hour && UTime.Minute==CTime.Minute && UTime.Second==CTime.Second)
            {
                TimerAlert.Stop();
                try
                {
                    Player.SoundLocation = Properties.Settings.Default.AlertToneFilename;
                    Player.PlayLooping();
                    txt_NOTS.Text=Properties.Settings.Default.AlertMessage;
                    txt_NOTS.BackColor = Color.SpringGreen;
                    Main.MainPage.MainPage.GetMainPage.AlertClockPanel.Show();
                    Main.MainPage.MainPage.GetMainPage.btn_TimeAlert.Image = Properties.Resources.AlertClock_Run;
                    Main.MainPage.MainPage.GetMainPage.lbl_AlertMessage.Text = "لديك رساله تنبيه هي "+this.txt_NOTS.Text;
                    Main.MainPage.MainPage.GetMainPage.lbl_AlertMessage.BackColor = Color.SpringGreen;
                }
                catch
                {
                    return;
                }
                
            }
        }
    }
}
