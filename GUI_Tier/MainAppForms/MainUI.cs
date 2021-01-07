using DTO;
using BLL;
using GUI_Tier.FormForReportFunction;
using GUI_Tier.FormsForEmployeeAndRule;
using GUI_Tier.FormsForSelling_Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_Tier.Properties;

namespace GUI_Tier
{
    public partial class MainUI : Form
    {
        //for childform which is appearing in the right panel
        private Form activeForm = null;

        //for user who is using this software
        private AccountDTO user = null;

        //controller
        private AccountBLL controller = null;

        //flag for submenu appear
        private bool isForDataManageMenuReadyToCollapse = true;
        private bool isForSellMenuReadyToCollapse = true;
        private bool isForReportMenuReadyToCollapse = true;
        private bool isForEmployeeAndRuleReadyToCollapse = true;

        //open a child form
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LoadImageForAllButtonMenu()
        {
            btnDataMenu.Image = Resources.Expand_Arrow_20px;
            btnEmpAndRuleMenu.Image = Resources.Expand_Arrow_20px;
            btnReportMenu.Image = Resources.Expand_Arrow_20px;
            btnSellMenu.Image = Resources.Expand_Arrow_20px;
        }

        public MainUI(string username)
        {
            InitializeComponent();
            LoadImageForAllButtonMenu();
            controller = new AccountBLL();
            user = new AccountDTO();
            user = controller.GetAccountByUsername(username);
            ShowInfo();
        }

        //logic for show submenu when click menu
        private void timer_tick(ref bool isForSubmenuCollapse, Panel panelChosen, Timer timerForThisSubmenu, Button btnMenuChosen)
        {
            if (isForSubmenuCollapse)
            {
                btnMenuChosen.Image = Resources.Collapse_Arrow_20px;
                panelChosen.Height += 10;
                if (panelChosen.Size == panelChosen.MaximumSize)
                {
                    timerForThisSubmenu.Stop();
                    isForSubmenuCollapse = false;
                }
            }
            else
            {
                btnMenuChosen.Image = Resources.Expand_Arrow_20px;
                panelChosen.Height -= 10;
                if (panelChosen.Size == panelChosen.MinimumSize)
                {
                    timerForThisSubmenu.Stop();
                    isForSubmenuCollapse = true;
                }
            }
        }

        //Show info of active user when login-in
        private void ShowInfo()
        {
            //lbUsername.Text = user.getUsername();
            //lbPassword.Text = user.getPassword();
            //lbType.Text = user.getType().ToString();
            //lbRealname.Text = user.getRealName();
            //lbEmail.Text = user.getEmail();
            //lblPhone.Text = user.getPhoneNumber();
            //lbAddress.Text = user.getAddress();
        }

        //show submenu from DataManageMenu                          
        private void timer1_Tick(object sender, EventArgs e)
        { 
            timer_tick(ref isForDataManageMenuReadyToCollapse, panelManageData, timerForManageDataMenu,btnDataMenu);
        }

        private void btnDataMenu_Click(object sender, EventArgs e)
        {
            timerForManageDataMenu.Start();
        }

        private void btnBookData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBookData());
        }

        private void btnCategoryAndAuthorData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCategoryAndAuthorData());
        }

        private void btnCustomerData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCustomerData());
        }

        //show submenu for SellMenu
        private void timerForSellMenu_Tick(object sender, EventArgs e)
        {
            timer_tick(ref isForSellMenuReadyToCollapse, panel1, timerForSellMenu, btnSellMenu);
        }

        private void btnSellMenu_Click(object sender, EventArgs e)
        {
            timerForSellMenu.Start();
        }
        
        private void btnSellBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSellBook());
        }
        
        private void btnReceiveBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReceiveBook());
        }

        private void btnReceiveMoney_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReceiveMoney());
        }

        //show submenu for ReportMenu
        private void timerForReportMenu_Tick(object sender, EventArgs e)
        {
            timer_tick(ref isForReportMenuReadyToCollapse, panel3, timerForReportMenu, btnReportMenu);
        }

        private void btnReportMenu_Click(object sender, EventArgs e)
        {
            if (user.getType() == 0)
            {
                timerForReportMenu.Start();
            }
            else
            {
                MessageBox.Show("You don't have permision to do this funtion");
            }
            
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInventoryReport());
        }

        private void btnRevenueReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRevenueReport());
        }

        //show submenu for EmployeeAndRuleMenu
        private void btnEmpAndRuleMenu_Click(object sender, EventArgs e)
        {
            if (user.getType() == 0)
            {
                timerForEmployeeAndRuleMenu.Start();
            }
            else
            {
                MessageBox.Show("You don't have permision to do this funtion");
            } 
        }

        private void timerForEmployeeAndRuleMenu_Tick(object sender, EventArgs e)
        {
            timer_tick(ref isForEmployeeAndRuleReadyToCollapse, panel2, timerForEmployeeAndRuleMenu, btnEmpAndRuleMenu);
        }

        private void btnEmployeeClick(object sender, EventArgs e)
        {
            OpenChildForm(new FormEmployee());
        }

        private void btnRuleClick(object sender, EventArgs e)
        {
                OpenChildForm(new FormRule());
        }

        //logout
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm.getInstance().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
