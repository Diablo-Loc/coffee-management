using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace source.UI
{
    public partial class MainForm : Form
    {
        bool sideBarExpand; // Biến để theo dõi trạng thái mở rộng/thu gọn của sidebar
        [DllImport("user32.dll")]       // Code này dùng để thực hiện cầm vào thanh tiêu đề và kéo thả form
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonOrderList_Click(object sender, EventArgs e)
        {

        }

        private void labelCoffeeManagement_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreatOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
        private void buttonShowMenuForm_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // Giả sử label bạn đặt tên là lblToggle

        // Nút Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng ứng dụng
        }

        // Nút Minimize
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Nút Maximize / Restore
        private void btnMax_Click(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            if (this.Tag == null)
            {
                // Phóng to theo vùng làm việc (trừ taskbar)
                this.Location = workingArea.Location;
                this.Size = workingArea.Size;
                this.Tag = "Maximized";
            }
            else
            {
                // Quay về kích thước ban đầu
                this.Size = new Size(1280, 720);
                this.CenterToScreen();
                this.Tag = null;
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void side(object sender, EventArgs e)
        {
            //Set max/ min of sidebar
            if (sideBarExpand)
            {
                sideBar.Width -= 20;
                if (sideBar.Width <= sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sidebarTimer.Stop();
                }
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
