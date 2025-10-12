using source.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using static source.UI.Controls.FormDragger;


namespace source.UI
{
    public partial class MainFormvut : Form
    {
        private Button currentButton;    
        private Random random;           
        private int tempIndex;           
        private Form activeForm;        
        private bool isDragging = false;
        private Point dragStartPoint = Point.Empty;
        public MainFormvut()
        {
            InitializeComponent();
            Menubutton.BackColor = Color.AntiqueWhite;
            creatorderbutton.BackColor = Color.AntiqueWhite;
            listorderbutton.BackColor = Color.AntiqueWhite;
            random = new Random();
            btnclosechildform.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            int w = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.8);
            int h = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.8);
            this.Size = new Size(w, h);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Resize += (s, e) =>
            {
                if (this.WindowState == FormWindowState.Normal)
                    UIHelper.ApplyRoundedCorners(this, 30);
                else
                    this.Region = null;
            };

        }
        
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    Color color = BackColor;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
                    paneltitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);// chỉnh chỗ logo
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnclosechildform.Visible = true;
                }
            }
        }
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

        // Sự kiện click nút Menu
        private void Menubutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuForm(), sender);
            Menubutton.BackColor = Color.NavajoWhite;
            creatorderbutton.BackColor = Color.AntiqueWhite;
            listorderbutton.BackColor = Color.AntiqueWhite;
        }
        private void creatorder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderForm(), sender);
            creatorderbutton.BackColor = Color.NavajoWhite;
            Menubutton.BackColor = Color.AntiqueWhite;
            listorderbutton.BackColor = Color.AntiqueWhite;
        }

       
        //nút tương tác
        private void btnclosechildform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            namebar.Text = "Coffee shop Management";
            //paneltitlebar.BackColor = Color.FromArgb(54,69,79);
            //panelLogo.BackColor = Color.FromArgb(254, 104, 123);
            currentButton = null;
            btnclosechildform.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == btnExit)
                btn.BackColor = Color.Red;
            else if (btn == btnMaximize)
                btn.BackColor = Color.Orange;
            else if (btn == btnMinimize)
                btn.BackColor = Color.Gold;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent; // hoặc màu gốc của bạn
        }

    }

}
