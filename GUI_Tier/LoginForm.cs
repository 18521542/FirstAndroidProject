using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI_Tier
{
    public partial class LoginForm : Form
    {
        private static LoginForm instance = null;
        public static LoginForm getInstance() 
        {
            if (instance == null)
                instance = new LoginForm();
            return instance;
        }
        private AccountBLL controller = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            controller = new AccountBLL();
            if (controller.Login(tbUsername.Text, tbPassword.Text))
            {
                MessageBox.Show("Login thanh cong");
                LoginForm.getInstance().Hide();
                MainUI main = new MainUI();
                main.Show();
                //MainUIWPF main = new MainUIWPF();
                //main.
            }
            else
                MessageBox.Show("That bai");
        }

        private void Username_text(object sender, EventArgs e)
        {
            if ( tbUsername.Text == "Nhập tài khoản")
            {
                tbUsername.Clear();
            }
            else
            {
                if(tbUsername.TextLength == 0)
                {
                    tbUsername.Text = "Nhập tài khoản";
                }
            }
                if (tbPassword.TextLength == 0)
                {
                    tbPassword.Text = "Nhập mật khẩu";
                }

        }

        private void Password_text(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Nhập mật khẩu")
            {
                tbPassword.Clear();
            }
            else
            {
                if (tbPassword.TextLength == 0)
                {
                    tbPassword.Text = "Nhập mật khẩu";
                }
            }
                if (tbUsername.TextLength == 0)
                {
                    tbUsername.Text = "Nhập tài khoản";
                }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
