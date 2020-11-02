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
        private AccountBLL controller = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            controller = new AccountBLL();
            if (controller.Login(txfUsername.Text, txfPassword.Text))
                MessageBox.Show("Thanh cong");
            else
                MessageBox.Show("That bai");
        }
    }
}
