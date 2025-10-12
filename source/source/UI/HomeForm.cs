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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            panel1 = new DoubleBufferedPanel();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lblRecommend_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lấy thông tin người dùng đã đăng nhập
                var user = loginForm.LoggedInUser;

                MessageBox.Show($"Xin chào {user.Name} - Vai trò: {user._Role}");

                // Nếu muốn mở MainForm sau khi đăng nhập:
                var mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }

        }
    }
}
