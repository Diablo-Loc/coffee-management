using System;
using System.Drawing;
using System.Windows.Forms;
using source.Models;

namespace source.UI
{
    public partial class Sample : Form
    {
        private Button currentButton;    // Nút đang chọn
        private Random random;           // Chọn màu ngẫu nhiên
        private int tempIndex;           // Tránh lặp màu
        private Form activeForm;         // Form con hiện tại

        public Sample()
        {
            InitializeComponent();
            random = new Random();
            btnclosechildform.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // ===== Chọn màu ngẫu nhiên =====
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        // ===== Reset màu nút menu =====
        private void DisableButton()
        {
            foreach (Control ctrl in Thanhbentrai.Controls)   // panel menu bên trái
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(51, 51, 76);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        // ===== Đổi màu nút được chọn =====
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
                    paneltitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);// chỉnh chỗ logo
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;*/
                    btnclosechildform.Visible = true;
                }
            }
        }

        // ===== Mở Form con trong panelDesktop =====
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) activeForm.Close();

            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.control.Controls.Add(childForm);
            this.control.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            namebar.Text = childForm.Text;   // hiển thị tiêu đề

        }

        // ===== Sự kiện click nút Menu =====
        private void Menubutton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            Bill bill = new Bill(order);
            OpenChildForm(new BillForm(bill), sender);
        }
        private void creatorder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderForm(), sender);
        }

        private void listorderbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListOrder(), sender);
        }

       

        private void btnclosechildform_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            namebar.Text = "Coffee shop Management";
            paneltitlebar.BackColor = Color.FromArgb(254, 104, 123);
            panelLogo.BackColor = Color.FromArgb(254, 104, 123);
            currentButton = null;
            btnclosechildform.Visible = false;
        }
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void zoombutton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
