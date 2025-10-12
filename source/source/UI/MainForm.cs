using source.Models.PersonModel;
using source.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static source.UI.Controls.FormDragger;
using static source.UI.Controls.Smooth;


namespace source.UI
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        private bool isDragging = false;
        private Point dragStartPoint = Point.Empty;
        private HomeForm homeForm;
        private MenuForm menuForm;
        private OrderForm orderForm;
        private Panel pnlManualPopup;
        private RichTextBox rtbManual;
        private System.Windows.Forms.Timer manualHideTimer;
        private string currentLanguage = "en";
        private Stopwatch manualHideStopwatch;
        private bool isMouseOutside = false;
        private bool isResizing = false;
        private Point resizeStartPoint;
        private Employee currentUser;
        private AdminManage employeeForm;

        public MainForm(Employee user)
        {
            InitializeComponent();
            this.Padding = new Padding(1);
            FormDragger dragger = new FormDragger(pnltopbar, this, pnltopbar);
            btnHome.BackColor = Color.AntiqueWhite;
            btnMenu.BackColor = Color.AntiqueWhite;
            btnCreatOrder.BackColor = Color.AntiqueWhite;
            this.StartPosition = FormStartPosition.CenterScreen;

            pictureBox1 = new DoubleBufferedPictureBox();
            this.Resize += (s, e) =>
            {
                if (this.WindowState == FormWindowState.Normal)
                    UIHelper.ApplyRoundedCorners(this, 30);
                else
                    this.Region = null;
            };
            this.Load += MainForm_Load;
            currentUser = user;
            ApplyRolePermissions();
            lblUserInfo.Text = $"👤 Đăng nhập: {user.Name} ({user._Role})";


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
            this.pnlHienThi.Controls.Add(childForm);
            this.pnlHienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            namebar.Text = childForm.Text;
            namebar.Anchor = AnchorStyles.Top;

        }
        //Mở form mới
        private void btnHome_Click(object sender, EventArgs e)
        {
            homeForm = new HomeForm();
            OpenChildForm(homeForm, sender);
            //homeForm.ApplyLanguage();
            btnHome.BackColor = Color.NavajoWhite;
            btnMenu.BackColor = Color.AntiqueWhite;
            btnCreatOrder.BackColor = Color.AntiqueWhite;
        }
        
        private void btnMenuForm_Click(object sender, EventArgs e)
        {
            menuForm = new MenuForm();
            OpenChildForm(menuForm, sender);
            //menuForm.ApplyLanguage();
            btnMenu.BackColor = Color.NavajoWhite;
            btnHome.BackColor = Color.AntiqueWhite;
            btnCreatOrder.BackColor = Color.AntiqueWhite;
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            orderForm = new OrderForm();
            OpenChildForm(orderForm, sender);
            //orderForm.ApplyLanguage();
            btnCreatOrder.BackColor = Color.NavajoWhite;
            btnMenu.BackColor = Color.AntiqueWhite;
            btnHome.BackColor = Color.AntiqueWhite;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            employeeForm = new AdminManage(currentUser);
            OpenChildForm(employeeForm, sender);

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                UIHelper.ApplyRoundedCorners(this, 30);
            //LanguageManager.SetLanguage("en");
            //ApplyLanguage();
            cmbLanguage.SelectedItem = "English";
        }
        /*private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lang = cmbLanguage.SelectedItem.ToString();
            if (lang == "English")
            {
                LanguageManager.SetLanguage("en");
                currentLanguage = "en";
            }
            else if (lang == "Tiếng Việt")
            {
                LanguageManager.SetLanguage("vi");
                currentLanguage = "vi";
            }
            ApplyLanguage();

            if (homeForm != null && !homeForm.IsDisposed)
                homeForm.ApplyLanguage();

            if (calculaterForm != null && !calculaterForm.IsDisposed)
                calculaterForm.ApplyLanguage();

            if (graphForm != null && !graphForm.IsDisposed)
                graphForm.ApplyLanguage();
        }*/
        /*private void ApplyLanguage()
        {
            btnCreatOrder.Text = LanguageManager.Get("NavMaxFlowSimulator");
            btnMenu.Text = LanguageManager.Get("NavTransportation");
            btnHome.Text = LanguageManager.Get("NavHome");
            lblmain.Text = LanguageManager.Get("TitleGroup11");
            lblLanguage.Text = LanguageManager.Get("LabelLanguage");
        }*/
        //Nút tương tác
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
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14;
            const int HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;
            const int RESIZE_HANDLE_SIZE = 10;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                Point cursor = PointToClient(new Point(m.LParam.ToInt32()));

                if (cursor.X <= RESIZE_HANDLE_SIZE && cursor.Y <= RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (cursor.X >= ClientSize.Width - RESIZE_HANDLE_SIZE && cursor.Y <= RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursor.X <= RESIZE_HANDLE_SIZE && cursor.Y >= ClientSize.Height - RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursor.X >= ClientSize.Width - RESIZE_HANDLE_SIZE && cursor.Y >= ClientSize.Height - RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursor.X <= RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTLEFT;
                else if (cursor.X >= ClientSize.Width - RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y <= RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTTOP;
                else if (cursor.Y >= ClientSize.Height - RESIZE_HANDLE_SIZE)
                    m.Result = (IntPtr)HTBOTTOM;
                return;
            }

            base.WndProc(ref m);
        }
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
                e.Location.X >= pnltopbar.Width - 10 &&
                e.Location.Y >= pnltopbar.Height - 10)
            {
                isResizing = true;
                resizeStartPoint = e.Location;
            }
        }

        private void pnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                int dx = e.Location.X - resizeStartPoint.X;
                int dy = e.Location.Y - resizeStartPoint.Y;
                this.Size = new Size(this.Width + dx, this.Height + dy);
                resizeStartPoint = e.Location;
            }
            else
            {
                // Đổi con trỏ chuột khi rê vào góc resize
                if (e.Location.X >= pnltopbar.Width - 10 &&
                    e.Location.Y >= pnltopbar.Height - 10)
                {
                    pnltopbar.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    pnltopbar.Cursor = Cursors.Default;
                }
            }
        }

        private void pnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
        }
        //Login
        private void ApplyRolePermissions()
        {
            switch (currentUser._Role)
            {
                case Employee.Role.Admin:
                    btnMenu.Visible = true;
                    btnEmployee.Visible = true;
                    btnCreatOrder.Visible=false;
                    btnMenu.Enabled = true;
                    //btnViewReports.Enabled = true;
                    btnEmployee.Enabled = true;
                    btnCreatOrder.Enabled = false;
                    break;

                case Employee.Role.Manager:
                    btnMenu.Enabled = false;
                    btnMenu.Visible=false;
                    btnEmployee.Visible=false;
                    btnCreatOrder.Visible = false;
                    //btnViewReports.Enabled = true;
                    btnEmployee.Enabled= false;
                    btnCreatOrder.Enabled = false;
                    //tạo thêm form mới
                    break;

                case Employee.Role.Cashier:
                    btnMenu.Enabled = false;
                    btnMenu.Visible=false;
                    btnEmployee.Visible=false;
                    btnCreatOrder.Enabled = true;
                    //btnViewReports.Enabled = false;
                    btnEmployee.Enabled = false;
                    btnCreatOrder.Enabled = true;
                    break;
            }
        }


    }
}