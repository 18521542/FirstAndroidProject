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
using DTO;

namespace GUI_Tier
{
    public partial class FormEmployee : Form
    {
        private AccountBLL control;
        private List<AccountDTO> listAccount;
        private AccountDTO SelectedAccount;
        bool isClicked = false;
        public FormEmployee()
        {
            InitializeComponent();
            control = new AccountBLL();
            listAccount = new List<AccountDTO>();
            SelectedAccount = new AccountDTO();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                listAccount = control.GetAllAccounts();
                int stt = 0;
                foreach (AccountDTO acc in listAccount)
                {
                    TableUser.Items.Add(acc.getUsername());
                    TableUser.Items[stt].SubItems.Add(acc.getPassword());
                    TableUser.Items[stt].SubItems.Add(acc.getType().ToString());
                    TableUser.Items[stt].SubItems.Add(acc.getRealName());
                    TableUser.Items[stt].SubItems.Add(acc.getPhoneNumber());
                    TableUser.Items[stt].SubItems.Add(acc.getEmail());
                    TableUser.Items[stt].SubItems.Add(acc.getAddress());
                    stt++;
                }
                MessageBox.Show("Da lay het danh sach tai khoan");
                isClicked = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
