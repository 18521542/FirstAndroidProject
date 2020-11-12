namespace GUI_Tier
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerForManageDataMenu = new System.Windows.Forms.Timer(this.components);
            this.timerForSellMenu = new System.Windows.Forms.Timer(this.components);
            this.timerForEmployeeAndRuleMenu = new System.Windows.Forms.Timer(this.components);
            this.timerForReportMenu = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportRevenueData = new System.Windows.Forms.Button();
            this.btnReportBookData = new System.Windows.Forms.Button();
            this.btnReportMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRuleData = new System.Windows.Forms.Button();
            this.btnEmployeeData = new System.Windows.Forms.Button();
            this.btnEmpAndRuleMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReceiveBookData = new System.Windows.Forms.Button();
            this.btnReceiveMoneyData = new System.Windows.Forms.Button();
            this.btnBillData = new System.Windows.Forms.Button();
            this.btnSellMenu = new System.Windows.Forms.Button();
            this.panelManageData = new System.Windows.Forms.Panel();
            this.btnCategoryAndAuthor = new System.Windows.Forms.Button();
            this.btnCustomerData = new System.Windows.Forms.Button();
            this.btnBookData = new System.Windows.Forms.Button();
            this.btnDataMenu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelManageData.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerForManageDataMenu
            // 
            this.timerForManageDataMenu.Interval = 15;
            this.timerForManageDataMenu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerForSellMenu
            // 
            this.timerForSellMenu.Interval = 15;
            this.timerForSellMenu.Tick += new System.EventHandler(this.timerForSellMenu_Tick);
            // 
            // timerForEmployeeAndRuleMenu
            // 
            this.timerForEmployeeAndRuleMenu.Interval = 15;
            this.timerForEmployeeAndRuleMenu.Tick += new System.EventHandler(this.timerForEmployeeAndRuleMenu_Tick);
            // 
            // timerForReportMenu
            // 
            this.timerForReportMenu.Interval = 15;
            this.timerForReportMenu.Tick += new System.EventHandler(this.timerForReportMenu_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(3, 569);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(306, 44);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnReportRevenueData);
            this.panel3.Controls.Add(this.btnReportBookData);
            this.panel3.Controls.Add(this.btnReportMenu);
            this.panel3.Location = new System.Drawing.Point(3, 510);
            this.panel3.MaximumSize = new System.Drawing.Size(306, 150);
            this.panel3.MinimumSize = new System.Drawing.Size(306, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 53);
            this.panel3.TabIndex = 5;
            // 
            // btnReportRevenueData
            // 
            this.btnReportRevenueData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReportRevenueData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportRevenueData.FlatAppearance.BorderSize = 0;
            this.btnReportRevenueData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportRevenueData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportRevenueData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportRevenueData.Location = new System.Drawing.Point(0, 106);
            this.btnReportRevenueData.Name = "btnReportRevenueData";
            this.btnReportRevenueData.Size = new System.Drawing.Size(306, 56);
            this.btnReportRevenueData.TabIndex = 3;
            this.btnReportRevenueData.Text = "BÁO CÁO DOANH THU";
            this.btnReportRevenueData.UseVisualStyleBackColor = false;
            this.btnReportRevenueData.Click += new System.EventHandler(this.btnRevenueReport_Click);
            // 
            // btnReportBookData
            // 
            this.btnReportBookData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReportBookData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportBookData.FlatAppearance.BorderSize = 0;
            this.btnReportBookData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportBookData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportBookData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportBookData.Location = new System.Drawing.Point(0, 49);
            this.btnReportBookData.Name = "btnReportBookData";
            this.btnReportBookData.Size = new System.Drawing.Size(306, 57);
            this.btnReportBookData.TabIndex = 2;
            this.btnReportBookData.Text = "BÁO CÁO TỒN";
            this.btnReportBookData.UseVisualStyleBackColor = false;
            this.btnReportBookData.Click += new System.EventHandler(this.btnInventoryReport_Click);
            // 
            // btnReportMenu
            // 
            this.btnReportMenu.BackColor = System.Drawing.Color.Purple;
            this.btnReportMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportMenu.FlatAppearance.BorderSize = 0;
            this.btnReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMenu.ForeColor = System.Drawing.Color.White;
            this.btnReportMenu.Location = new System.Drawing.Point(0, 0);
            this.btnReportMenu.Name = "btnReportMenu";
            this.btnReportMenu.Size = new System.Drawing.Size(306, 49);
            this.btnReportMenu.TabIndex = 1;
            this.btnReportMenu.Text = "BÁO CÁO THÁNG";
            this.btnReportMenu.UseVisualStyleBackColor = false;
            this.btnReportMenu.Click += new System.EventHandler(this.btnReportMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnRuleData);
            this.panel2.Controls.Add(this.btnEmployeeData);
            this.panel2.Controls.Add(this.btnEmpAndRuleMenu);
            this.panel2.Location = new System.Drawing.Point(3, 451);
            this.panel2.MaximumSize = new System.Drawing.Size(306, 160);
            this.panel2.MinimumSize = new System.Drawing.Size(306, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 53);
            this.panel2.TabIndex = 4;
            // 
            // btnRuleData
            // 
            this.btnRuleData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRuleData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRuleData.FlatAppearance.BorderSize = 0;
            this.btnRuleData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuleData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuleData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRuleData.Location = new System.Drawing.Point(0, 106);
            this.btnRuleData.Name = "btnRuleData";
            this.btnRuleData.Size = new System.Drawing.Size(306, 56);
            this.btnRuleData.TabIndex = 3;
            this.btnRuleData.Text = "THAY ĐỔI QUY ĐỊNH";
            this.btnRuleData.UseVisualStyleBackColor = false;
            this.btnRuleData.Click += new System.EventHandler(this.btnRuleClick);
            // 
            // btnEmployeeData
            // 
            this.btnEmployeeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmployeeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeData.FlatAppearance.BorderSize = 0;
            this.btnEmployeeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployeeData.Location = new System.Drawing.Point(0, 49);
            this.btnEmployeeData.Name = "btnEmployeeData";
            this.btnEmployeeData.Size = new System.Drawing.Size(306, 57);
            this.btnEmployeeData.TabIndex = 2;
            this.btnEmployeeData.Text = "DANH SÁCH NHÂN VIÊN";
            this.btnEmployeeData.UseVisualStyleBackColor = false;
            this.btnEmployeeData.Click += new System.EventHandler(this.btnEmployeeClick);
            // 
            // btnEmpAndRuleMenu
            // 
            this.btnEmpAndRuleMenu.BackColor = System.Drawing.Color.Purple;
            this.btnEmpAndRuleMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpAndRuleMenu.FlatAppearance.BorderSize = 0;
            this.btnEmpAndRuleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAndRuleMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAndRuleMenu.ForeColor = System.Drawing.Color.White;
            this.btnEmpAndRuleMenu.Location = new System.Drawing.Point(0, 0);
            this.btnEmpAndRuleMenu.Name = "btnEmpAndRuleMenu";
            this.btnEmpAndRuleMenu.Size = new System.Drawing.Size(306, 49);
            this.btnEmpAndRuleMenu.TabIndex = 1;
            this.btnEmpAndRuleMenu.Text = "NHÂN SỰ - QUY ĐỊNH";
            this.btnEmpAndRuleMenu.UseVisualStyleBackColor = false;
            this.btnEmpAndRuleMenu.Click += new System.EventHandler(this.btnEmpAndRuleMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnReceiveBookData);
            this.panel1.Controls.Add(this.btnReceiveMoneyData);
            this.panel1.Controls.Add(this.btnBillData);
            this.panel1.Controls.Add(this.btnSellMenu);
            this.panel1.Location = new System.Drawing.Point(3, 392);
            this.panel1.MaximumSize = new System.Drawing.Size(306, 210);
            this.panel1.MinimumSize = new System.Drawing.Size(306, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 53);
            this.panel1.TabIndex = 3;
            // 
            // btnReceiveBookData
            // 
            this.btnReceiveBookData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReceiveBookData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceiveBookData.FlatAppearance.BorderSize = 0;
            this.btnReceiveBookData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveBookData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveBookData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReceiveBookData.Location = new System.Drawing.Point(0, 162);
            this.btnReceiveBookData.Name = "btnReceiveBookData";
            this.btnReceiveBookData.Size = new System.Drawing.Size(306, 59);
            this.btnReceiveBookData.TabIndex = 4;
            this.btnReceiveBookData.Text = "LẬP PHIẾU NHẬP";
            this.btnReceiveBookData.UseVisualStyleBackColor = false;
            this.btnReceiveBookData.Click += new System.EventHandler(this.btnReceiveBook_Click);
            // 
            // btnReceiveMoneyData
            // 
            this.btnReceiveMoneyData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReceiveMoneyData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceiveMoneyData.FlatAppearance.BorderSize = 0;
            this.btnReceiveMoneyData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveMoneyData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveMoneyData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReceiveMoneyData.Location = new System.Drawing.Point(0, 106);
            this.btnReceiveMoneyData.Name = "btnReceiveMoneyData";
            this.btnReceiveMoneyData.Size = new System.Drawing.Size(306, 56);
            this.btnReceiveMoneyData.TabIndex = 3;
            this.btnReceiveMoneyData.Text = "LẬP PHIẾU THU";
            this.btnReceiveMoneyData.UseVisualStyleBackColor = false;
            this.btnReceiveMoneyData.Click += new System.EventHandler(this.btnReceiveMoney_Click);
            // 
            // btnBillData
            // 
            this.btnBillData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBillData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillData.FlatAppearance.BorderSize = 0;
            this.btnBillData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillData.Location = new System.Drawing.Point(0, 49);
            this.btnBillData.Name = "btnBillData";
            this.btnBillData.Size = new System.Drawing.Size(306, 57);
            this.btnBillData.TabIndex = 2;
            this.btnBillData.Text = "LẬP HÓA ĐƠN";
            this.btnBillData.UseVisualStyleBackColor = false;
            this.btnBillData.Click += new System.EventHandler(this.btnSellBook_Click);
            // 
            // btnSellMenu
            // 
            this.btnSellMenu.BackColor = System.Drawing.Color.Purple;
            this.btnSellMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellMenu.FlatAppearance.BorderSize = 0;
            this.btnSellMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMenu.ForeColor = System.Drawing.Color.White;
            this.btnSellMenu.Location = new System.Drawing.Point(0, 0);
            this.btnSellMenu.Name = "btnSellMenu";
            this.btnSellMenu.Size = new System.Drawing.Size(306, 49);
            this.btnSellMenu.TabIndex = 1;
            this.btnSellMenu.Text = "QUẢN LÝ BÁN HÀNG";
            this.btnSellMenu.UseVisualStyleBackColor = false;
            this.btnSellMenu.Click += new System.EventHandler(this.btnSellMenu_Click);
            // 
            // panelManageData
            // 
            this.panelManageData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManageData.Controls.Add(this.btnCategoryAndAuthor);
            this.panelManageData.Controls.Add(this.btnCustomerData);
            this.panelManageData.Controls.Add(this.btnBookData);
            this.panelManageData.Controls.Add(this.btnDataMenu);
            this.panelManageData.Location = new System.Drawing.Point(3, 333);
            this.panelManageData.MaximumSize = new System.Drawing.Size(306, 210);
            this.panelManageData.MinimumSize = new System.Drawing.Size(306, 53);
            this.panelManageData.Name = "panelManageData";
            this.panelManageData.Size = new System.Drawing.Size(306, 53);
            this.panelManageData.TabIndex = 2;
            // 
            // btnCategoryAndAuthor
            // 
            this.btnCategoryAndAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCategoryAndAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoryAndAuthor.FlatAppearance.BorderSize = 0;
            this.btnCategoryAndAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryAndAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryAndAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategoryAndAuthor.Location = new System.Drawing.Point(0, 162);
            this.btnCategoryAndAuthor.Name = "btnCategoryAndAuthor";
            this.btnCategoryAndAuthor.Size = new System.Drawing.Size(306, 59);
            this.btnCategoryAndAuthor.TabIndex = 4;
            this.btnCategoryAndAuthor.Text = "Thể loại - Tác giả";
            this.btnCategoryAndAuthor.UseVisualStyleBackColor = false;
            this.btnCategoryAndAuthor.Click += new System.EventHandler(this.btnCategoryAndAuthorData_Click);
            // 
            // btnCustomerData
            // 
            this.btnCustomerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCustomerData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerData.FlatAppearance.BorderSize = 0;
            this.btnCustomerData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerData.Location = new System.Drawing.Point(0, 106);
            this.btnCustomerData.Name = "btnCustomerData";
            this.btnCustomerData.Size = new System.Drawing.Size(306, 56);
            this.btnCustomerData.TabIndex = 3;
            this.btnCustomerData.Text = "Khách hàng";
            this.btnCustomerData.UseVisualStyleBackColor = false;
            this.btnCustomerData.Click += new System.EventHandler(this.btnCustomerData_Click);
            // 
            // btnBookData
            // 
            this.btnBookData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBookData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookData.FlatAppearance.BorderSize = 0;
            this.btnBookData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBookData.Location = new System.Drawing.Point(0, 49);
            this.btnBookData.Name = "btnBookData";
            this.btnBookData.Size = new System.Drawing.Size(306, 57);
            this.btnBookData.TabIndex = 2;
            this.btnBookData.Text = "Dữ liệu sách";
            this.btnBookData.UseVisualStyleBackColor = false;
            this.btnBookData.Click += new System.EventHandler(this.btnBookData_Click);
            // 
            // btnDataMenu
            // 
            this.btnDataMenu.BackColor = System.Drawing.Color.Purple;
            this.btnDataMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataMenu.FlatAppearance.BorderSize = 0;
            this.btnDataMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataMenu.ForeColor = System.Drawing.Color.White;
            this.btnDataMenu.Location = new System.Drawing.Point(0, 0);
            this.btnDataMenu.Name = "btnDataMenu";
            this.btnDataMenu.Size = new System.Drawing.Size(306, 49);
            this.btnDataMenu.TabIndex = 1;
            this.btnDataMenu.Text = "QUẢN LÝ DỮ LIỆU";
            this.btnDataMenu.UseVisualStyleBackColor = false;
            this.btnDataMenu.Click += new System.EventHandler(this.btnDataMenu_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.GhostWhite;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 324);
            this.panel4.TabIndex = 1;
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            this.MenuPanel.BackColor = System.Drawing.Color.Purple;
            this.MenuPanel.Controls.Add(this.panel4);
            this.MenuPanel.Controls.Add(this.panelManageData);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Controls.Add(this.panel3);
            this.MenuPanel.Controls.Add(this.btnLogout);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(313, 1000);
            this.MenuPanel.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.Green;
            this.panelChildForm.Location = new System.Drawing.Point(315, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1282, 997);
            this.panelChildForm.TabIndex = 1;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelManageData.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerForManageDataMenu;
        private System.Windows.Forms.Timer timerForSellMenu;
        private System.Windows.Forms.Timer timerForEmployeeAndRuleMenu;
        private System.Windows.Forms.Timer timerForReportMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReportRevenueData;
        private System.Windows.Forms.Button btnReportBookData;
        private System.Windows.Forms.Button btnReportMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRuleData;
        private System.Windows.Forms.Button btnEmployeeData;
        private System.Windows.Forms.Button btnEmpAndRuleMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReceiveBookData;
        private System.Windows.Forms.Button btnReceiveMoneyData;
        private System.Windows.Forms.Button btnBillData;
        private System.Windows.Forms.Button btnSellMenu;
        private System.Windows.Forms.Panel panelManageData;
        private System.Windows.Forms.Button btnCategoryAndAuthor;
        private System.Windows.Forms.Button btnCustomerData;
        private System.Windows.Forms.Button btnBookData;
        private System.Windows.Forms.Button btnDataMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.Panel panelChildForm;
    }
}