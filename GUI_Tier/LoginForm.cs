using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BLL;

namespace GUI_Tier
{
    public partial class LoginForm : Form
    {
        //private AccountBLL controller = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //controller = new AccountBLL();
            //if (controller.Login(txfUsername.Text, txfPassword.Text))
            //    MessageBox.Show("Thanh cong");
            //else
            //    MessageBox.Show("That bai");
        }

        private void Username_text(object sender, EventArgs e)
        {
            if ( textBox1.Text == "Nhập tài khoản")
            {
                textBox1.Clear();
            }
            else
            {
                if(textBox1.TextLength == 0)
                {
                    textBox1.Text = "Nhập tài khoản";
                }
            }
                if (textBox2.TextLength == 0)
                {
                    textBox2.Text = "Nhập mật khẩu";
                }

        }

        private void Password_text(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nhập mật khẩu")
            {
                textBox2.Clear();
            }
            else
            {
                if (textBox2.TextLength == 0)
                {
                    textBox2.Text = "Nhập mật khẩu";
                }
            }
                if (textBox1.TextLength == 0)
                {
                    textBox1.Text = "Nhập tài khoản";
                }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
