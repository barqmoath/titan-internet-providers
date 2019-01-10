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
using Microsoft.Win32;

namespace Titan_Internet_Providers.Page.Concerted.PointPage
{
    public partial class PointPage : Form
    {
        Class.ClassPoint.Point point = new Class.ClassPoint.Point();
        public PointPage()
        {
            InitializeComponent();
            AddToolTip();
            SomeSetting();
            GetData();
        }

        private void GetData()
        {
            //Points
            this.DGV_Point.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_Point.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_Point.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Point.RowTemplate.Height = 28;
            this.DGV_Point.DataSource = point.GetPointsList();
            this.DGV_Point.Columns[0].HeaderText = "رمز النقطه";

            this.DGV_Point.Columns[1].HeaderText = "اسم النقطه";

            this.DGV_Point.Columns[2].HeaderText = "الموقع على الخريطه";
            this.DGV_Point.Columns[2].Visible = false;

            this.DGV_Point.Columns[3].HeaderText = "عدد اجهزتها";
            this.DGV_Point.Columns[3].Visible = false;

            this.DGV_Point.Columns[4].HeaderText = "المالك";

            this.DGV_Point.Columns[5].HeaderText = "مزود الخدمه";

            this.DGV_Point.Columns[6].HeaderText = "ألمناطق";
            this.DGV_Point.Columns[6].Visible = false;

            this.DGV_Point.Columns[7].HeaderText = "حاله العمل";
            this.DGV_Point.Columns[7].Visible = false;

            this.DGV_Point.Columns[8].HeaderText = "نقطه رئيسيه";
            this.DGV_Point.Columns[8].Visible = false;


            //Device
            this.DGV_Device.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.DGV_Device.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DGV_Device.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Device.RowTemplate.Height = 28;
            this.DGV_Device.DataSource = point.GetDeviceList();

            this.DGV_Device.Columns[0].HeaderText = "معرف الجهاز";
            this.DGV_Device.Columns[0].Visible = false;
            this.DGV_Device.Columns[1].HeaderText = "رمز النقطه";
            this.DGV_Device.Columns[1].Visible = true;
            this.DGV_Device.Columns[2].HeaderText = "اسم الجهاز";
            this.DGV_Device.Columns[3].HeaderText = "عنوان IP";
            this.DGV_Device.Columns[4].HeaderText = "عنوان MAC";
            this.DGV_Device.Columns[5].HeaderText = "اتجاه الجهاز";
            this.DGV_Device.Columns[6].HeaderText = "حاله العمل";
            this.DGV_Device.Columns[6].Visible = false;

            lbl_Counter.Text="لديك "+this.DGV_Point.RowCount.ToString()+" نقطه بث و "+this.DGV_Device.RowCount.ToString()+" جهاز حاليا";

            
        }
        private void ShowBindingOfPoint()
        {
            txt_PointCode.Text = this.DGV_Point.CurrentRow.Cells[0].Value.ToString();
            txt_PointName.Text = this.DGV_Point.CurrentRow.Cells[1].Value.ToString();
            txt_PointOwner.Text= this.DGV_Point.CurrentRow.Cells[4].Value.ToString();
            txt_PointProvider.Text= this.DGV_Point.CurrentRow.Cells[5].Value.ToString();
            txt_Pointlocation.Text= this.DGV_Point.CurrentRow.Cells[2].Value.ToString();
            txt_PointCity.Text= this.DGV_Point.CurrentRow.Cells[6].Value.ToString();
            if(this.DGV_Point.CurrentRow.Cells[8].Value.ToString()=="yes")
            {
                Checkbox_IsMainPoint.Checked = true;
            }
            else
            {
                Checkbox_IsMainPoint.Checked = false;
            }

            if(this.DGV_Point.CurrentRow.Cells[7].Value.ToString()=="on")
            {
                Switch_on_Point.Value = true;
            }
            else
            {
                Switch_on_Point.Value = false;
            }
        }
        private void ShowBindingOfDevice()
        {
            txt_DeviceName.Text = this.DGV_Device.CurrentRow.Cells[2].Value.ToString();
            txt_DeviceIP.Text= this.DGV_Device.CurrentRow.Cells[3].Value.ToString();
            txt_DeviceMAC.Text= this.DGV_Device.CurrentRow.Cells[4].Value.ToString();
            cmb_DeviceMAP.Text= this.DGV_Device.CurrentRow.Cells[5].Value.ToString();
            txt_DeviceOFPoint.Text= this.DGV_Device.CurrentRow.Cells[1].Value.ToString();
        }
        private void SomeSetting()
        {
            btn_CancelOfDevice.Hide();
            btn_Cancel_Of_Point.Hide();

        }
        private void AddToolTip()
        {
            ToolTip T = new ToolTip();
            T.SetToolTip(btn_GoBack, "اغلاق ورجوع للرئيسيه");
            T.SetToolTip(btn_Update, "تحديث");
            T.SetToolTip(btn_PointLocation, "موقع النقطه المحدد على الخريطه");
            T.SetToolTip(txt_DeviceOFPoint, "انتبه لهذا الادخال فهو يحدد الي اي منضومه او نقطه توزيع ستقوم باضافه او تعديل مكان الجهاز خذ رمز النقطه من اعلى");
        }
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.MainPage.MainPage.GetMainPage.btn_Points.Normalcolor = Color.WhiteSmoke;
            Main.MainPage.MainPage.GetMainPage.btn_Points.Textcolor = Color.Black;
            Main.MainPage.MainPage.GetMainPage.ShowState = "non";
            Main.MainPage.MainPage.GetMainPage.PageBody.Hide();
        }
        private void groupBox_Point_Enter(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void Switch_on_Point_OnValueChange(object sender, EventArgs e)
        {
            if (Switch_on_Point.Value == true)
            {
                lbl_PointOn.Text = "النقطه قيد العمل";
            }
            else
            {
                lbl_PointOn.Text = "النقطه متوقفه عن العمل";
            }    
        }
        private void PointPage_Load(object sender, EventArgs e)
        {
            if(this.DGV_Point.RowCount !=0 && this.DGV_Device.RowCount !=0)
            {
                ShowBindingOfPoint();
                ShowBindingOfDevice();
            }
        }
        private void DGV_Point_Click(object sender, EventArgs e)
        {
            if(this.DGV_Point.RowCount!=0)
            ShowBindingOfPoint();
        }
        private void DGV_Device_Click(object sender, EventArgs e)
        {
            if(this.DGV_Device.RowCount !=0)
            ShowBindingOfDevice();
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
        private void btn_SelectLoCationPoint_Click(object sender, EventArgs e)
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

        private void btn_PointLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string browserPath = GetBrowserPath();
                if (browserPath == string.Empty)
                    browserPath = "iexplore";
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo(browserPath);
                process.StartInfo.Arguments = "https://www.google.com.eg/maps/place/" +txt_Pointlocation.Text;
                process.Start();
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
                GetData();
                ShowBindingOfPoint();
                ShowBindingOfDevice();
            }
            catch
            {
                return;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                this.DGV_Device.DataSource = point.ShowDeviceWithPoint(Convert.ToInt32(this.DGV_Point.CurrentRow.Cells[0].Value.ToString()));
            }
            catch
            {
                return;
            }
        }

        private void btn_NewPoint_Click(object sender, EventArgs e)
        {
            btn_Cancel_Of_Point.Show();
            btn_NewPoint.Enabled = false;
            btn_SavePoint.Enabled = true;
            btn_EditPoint.Enabled = false;
            btn_DeletePoint.Enabled = false;

            txt_PointCode.Clear();
            txt_PointName.Clear();
            txt_PointOwner.Clear();
            txt_PointProvider.Clear();
            txt_Pointlocation.Clear();
            txt_PointCity.Clear();
            txt_PointName.Focus();

            Switch_on_Point.Value = false;
            Checkbox_IsMainPoint.Checked = false;
            lbl_PointOn.Text = "نقطه جديده";
        }

        private void btn_SavePoint_Click(object sender, EventArgs e)
        {
            try
            {
                string ONOF = null;
                string Main = null;
                if (Switch_on_Point.Value == true)
                {
                    ONOF = "on";
                }
                else
                {
                    ONOF = "off";
                }

                if (Checkbox_IsMainPoint.Checked == true)
                {
                    Main = "yes";
                }
                else
                {
                    Main = "no";
                }
                point.SaveThePoint(txt_PointName.Text, txt_Pointlocation.Text, txt_PointOwner.Text, txt_PointProvider.Text, txt_PointCity.Text, ONOF, Main);
                MessageBox.Show("تم حفظ نقطه التوزيع الجديده بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من الاتصال");
            }
            finally
            {
                btn_Cancel_Of_Point.Hide();
                btn_SavePoint.Enabled = false;
                btn_NewPoint.Enabled = true;
                btn_EditPoint.Enabled = true;
                btn_DeletePoint.Enabled = true;
                GetData();
                ShowBindingOfPoint();
            }
            
        }

        private void btn_Cancel_Of_Point_Click(object sender, EventArgs e)
        {
            btn_Cancel_Of_Point.Hide();
            btn_NewPoint.Enabled = true;
            btn_SavePoint.Enabled = false;
            btn_EditPoint.Enabled = true;
            btn_DeletePoint.Enabled = true;
            ShowBindingOfPoint();
        }

        private void btn_DeletePoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل انت متاكد من حذق موقع التوزيع هذا", "تاكيد الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    point.DeletePoint(Convert.ToInt32(this.DGV_Point.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم حذف نقطه التوزيع", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من الاتصال");
            }
            finally
            {
                GetData();
                ShowBindingOfPoint();
                ShowBindingOfPoint();
            }
        }

        private void btn_EditPoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("سيتم تعديل موقع البث الذي طلبت حفظ تعديلاته وفقا للمعومات في الحقول هل تريد الاستمرار", "تاكيد استمرار حفظ التعديلات", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string ONOF = null;
                    string Main = null;
                    if (Switch_on_Point.Value == true)
                    {
                        ONOF = "on";
                    }
                    else
                    {
                        ONOF = "off";
                    }

                    if (Checkbox_IsMainPoint.Checked == true)
                    {
                        Main = "yes";
                    }
                    else
                    {
                        Main = "no";
                    }
                    point.EditePoint(txt_PointName.Text, txt_Pointlocation.Text, txt_PointOwner.Text, txt_PointProvider.Text, txt_PointCity.Text, ONOF, Main, Convert.ToInt32(txt_PointCode.Text));
                    MessageBox.Show("تم حفظ كافه التعديلات", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من الاتصال");
            }
            finally
            {
                GetData();
                ShowBindingOfPoint();
                ShowBindingOfPoint();
            }
        }

        private void txt_DeviceOFPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
        }

        private void btn_NewDevice_Click(object sender, EventArgs e)
        {
            btn_SaveDevice.Enabled = true;
            btn_NewDevice.Enabled = false;
            btn_DeleteDevice.Enabled = false;
            btn_EditDevice.Enabled = false;
            txt_DeviceName.Clear();
            txt_DeviceIP.Clear();
            txt_DeviceOFPoint.Clear();
            txt_DeviceMAC.Clear();
            cmb_DeviceMAP.Text = "";
            btn_CancelOfDevice.Show();
        }

        private void btn_CancelOfDevice_Click(object sender, EventArgs e)
        {
            btn_SaveDevice.Enabled = false;
            btn_NewDevice.Enabled = true;
            btn_DeleteDevice.Enabled = true;
            btn_EditDevice.Enabled = true;
            btn_CancelOfDevice.Hide();
            ShowBindingOfDevice();
        }

        private void btn_SaveDevice_Click(object sender, EventArgs e)
        {
            try
            {
                point.SaveDevice(Convert.ToInt32(txt_DeviceOFPoint.Text), txt_DeviceName.Text, txt_DeviceIP.Text, txt_DeviceMAC.Text, cmb_DeviceMAP.Text);
                btn_SaveDevice.Enabled = false;
                btn_NewDevice.Enabled = true;
                btn_DeleteDevice.Enabled = true;
                btn_EditDevice.Enabled = true;
                btn_CancelOfDevice.Hide();
                MessageBox.Show("تم حفظ الجهاز بالنسبه لمنضومه التوزيع الذي ادخلت رمزها", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من الاتصال");
            }
            finally
            {
                GetData();
                ShowBindingOfDevice();
            }

        }

        private void btn_EditDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("سيتم تعديل الجهاز وفقا للمعلومات الجديده في الحقول .. حاول ان تتاكد من رمز النقطه اذا قمت بتعديله فهو يوكد الى اي نقطه الجهاز يتبع", "تاكيد استمرار التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    point.EditeDevice(Convert.ToInt32(txt_DeviceOFPoint.Text), txt_DeviceName.Text, txt_DeviceIP.Text, txt_DeviceMAC.Text, cmb_DeviceMAP.Text, Convert.ToInt32(this.DGV_Device.CurrentRow.Cells[0].Value.ToString()));
                    GetData();
                    ShowBindingOfDevice();
                    MessageBox.Show("تم حفظ كافه التعديلات", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من الاتصال");
            }
            finally
            {
                GetData();
                ShowBindingOfDevice();
            }
        }

        private void btn_DeleteDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("سيتم حذف الجهاز هل تريد الاستمرار", "تاكيد الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    point.DeleteDevice(Convert.ToInt32(this.DGV_Device.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم حذف الجهاز", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("خطأ تحقق من الاتصال");
            }
            finally
            {
                GetData();
                ShowBindingOfDevice();
            }
        }
    }
}
