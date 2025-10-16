using source.Common;
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
using static source.UI.Controls.Smooth;

namespace source.UI
{
    public partial class LoginForm : Form
    {
        private AuthService authService=new AuthService();
        public Employee LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            panel1 = new DoubleBufferedPanel();
            lblError.Visible = false;
            authService.InitialDataforLogin();
            DatabaseSeeder.Seed(); // dùng 1 lần để lưu vào file thôi=))
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                Employee user = authService.Login(username, password);
                this.LoggedInUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
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
