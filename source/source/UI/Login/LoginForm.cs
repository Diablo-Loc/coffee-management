using source.Data;
using source.Models.PersonModel;
using source.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace source.UI
{
    public partial class LoginForm : Form
    {
        public Employee LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            lblError.Visible = false;
            EmployeeAccount.InitializeDatabase();
            //DatabaseSeeder.Seed(); // dùng 1 lần để lưu vào file thôi=))
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = XácThực.Authenticate(username, password);
            if (user != null)
            {
                LoggedInUser = user;
                this.DialogResult = DialogResult.OK; // ✅ Cho phép HomeForm biết là đăng nhập thành công
                this.Close();
            }
            else
            {
                lblError.Text = "Sai tài khoản hoặc mật khẩu!";
                lblError.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
