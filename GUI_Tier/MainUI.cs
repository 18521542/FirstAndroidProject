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
        private bool isForDataManageMenuReadyToCollapse = true;

        private bool isForSellMenuReadyToCollapse = true;

        private bool isForReportMenuReadyToCollapse = true;

        private bool isForEmployeeAndRuleReadyToCollapse = true;

        public MainUI()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            LoginForm.getInstance().Show();

        }
    }
}
