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

namespace GUI_Tier
{
    public partial class MainUI : Form
    {
        //for childform which is appearing in the right panel
        private Form activeForm = null;

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

        public MainUI()
        {
            InitializeComponent();
        }

        //============================================================================= 
        //show submenu from DataManageMenu                          
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isForDataManageMenuReadyToCollapse)
            {
                panelManageData.Height += 10;
                if (panelManageData.Size == panelManageData.MaximumSize)
                {
                    timerForManageDataMenu.Stop();
                    isForDataManageMenuReadyToCollapse = false;
                }
            }
            else
            {
                panelManageData.Height -= 10;
                if (panelManageData.Size == panelManageData.MinimumSize)
                {
                    timerForManageDataMenu.Stop();
                    isForDataManageMenuReadyToCollapse = true;
                }
            }
        }
        private void btnDataMenu_Click(object sender, EventArgs e)
        {
            timerForManageDataMenu.Start();
        }
        //Open FormBookData
        private void btnBookData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBookData());
        }

        //Open FormCategoryAndAuthorData
        private void btnCategoryAndAuthorData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCategoryAndAuthorData());
        }

        //Open FormCustomerData
        private void btnCustomerData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCustomerData());
        }

        //=============================================================================  
        //show submenu for SellMenu
        private void timerForSellMenu_Tick(object sender, EventArgs e)
        {
            if (isForSellMenuReadyToCollapse)
            {
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timerForSellMenu.Stop();
                    isForSellMenuReadyToCollapse = false;
                }
            }
            else
            {
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timerForSellMenu.Stop();
                    isForSellMenuReadyToCollapse = true;
                }
            }
        }
        private void btnSellMenu_Click(object sender, EventArgs e)
        {
            timerForSellMenu.Start();
        }

        //Open FormSellBook
        private void btnSellBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSellBook());
        }

        //Open FormReceiveBook
        private void btnReceiveBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReceiveBook());
        }

        //Open FormReceiveMoney
        private void btnReceiveMoney_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReceiveMoney());
        }

        //=============================================================================
        //show submenu for ReportMenu
        private void timerForReportMenu_Tick(object sender, EventArgs e)
        {
            if (isForReportMenuReadyToCollapse)
            {
                panel3.Height += 10;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timerForReportMenu.Stop();
                    isForReportMenuReadyToCollapse = false;
                }
            }
            else
            {
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timerForReportMenu.Stop();
                    isForReportMenuReadyToCollapse = true;
                }
            }
        }
        private void btnReportMenu_Click(object sender, EventArgs e)
        {
            timerForReportMenu.Start();
        }

        //Open FormInventoryReport
        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInventoryReport());
        }

        //Open FormRevenueReport
        private void btnRevenueReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRevenueReport());
        }

        //=============================================================================
        //show submenu for EmployeeAndRuleMenu
        private void btnEmpAndRuleMenu_Click(object sender, EventArgs e)
        {
            timerForEmployeeAndRuleMenu.Start();
        }
        private void timerForEmployeeAndRuleMenu_Tick(object sender, EventArgs e)
        {
            if (isForEmployeeAndRuleReadyToCollapse)
            {
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timerForEmployeeAndRuleMenu.Stop();
                    isForEmployeeAndRuleReadyToCollapse = false;
                }
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timerForEmployeeAndRuleMenu.Stop();
                    isForEmployeeAndRuleReadyToCollapse = true;
                }
            }
        }

        //Open FormEmployee
        private void btnEmployeeClick(object sender, EventArgs e)
        {
            OpenChildForm(new FormEmployee());
        }

        //Open FormRule
        private void btnRuleClick(object sender, EventArgs e)
        {
                OpenChildForm(new FormRule());
        }

        //=============================================================================

        //logout
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm.getInstance().Show();
        }
    }
}
