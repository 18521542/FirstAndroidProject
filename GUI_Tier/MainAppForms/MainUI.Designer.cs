﻿namespace GUI_Tier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.timerForManageDataMenu = new System.Windows.Forms.Timer(this.components);
            this.timerForSellMenu = new System.Windows.Forms.Timer(this.components);
            this.timerForEmployeeAndRuleMenu = new System.Windows.Forms.Timer(this.components);
            this.timerForReportMenu = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnReportRevenueData = new System.Windows.Forms.Button();
            this.btnReportBookData = new System.Windows.Forms.Button();
            this.btnReportMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRuleData = new System.Windows.Forms.Button();
            this.btnEmployeeData = new System.Windows.Forms.Button();
            this.btnEmpAndRuleMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReceiveBookData = new System.Windows.Forms.Button();
            this.btnReceiveMoneyData = new System.Windows.Forms.Button();
            this.btnBillData = new System.Windows.Forms.Button();
            this.btnSellMenu = new System.Windows.Forms.Button();
            this.panelManageData = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCategoryAndAuthor = new System.Windows.Forms.Button();
            this.btnCustomerData = new System.Windows.Forms.Button();
            this.btnBookData = new System.Windows.Forms.Button();
            this.btnDataMenu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lbRealname = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelManageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Location = new System.Drawing.Point(2, 457);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(230, 36);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.btnReportRevenueData);
            this.panel3.Controls.Add(this.btnReportBookData);
            this.panel3.Controls.Add(this.btnReportMenu);
            this.panel3.Location = new System.Drawing.Point(2, 410);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.MaximumSize = new System.Drawing.Size(230, 122);
            this.panel3.MinimumSize = new System.Drawing.Size(230, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 43);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 27);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // btnReportRevenueData
            // 
            this.btnReportRevenueData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReportRevenueData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportRevenueData.FlatAppearance.BorderSize = 0;
            this.btnReportRevenueData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportRevenueData.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReportRevenueData.ForeColor = System.Drawing.Color.Tomato;
            this.btnReportRevenueData.Location = new System.Drawing.Point(0, 86);
            this.btnReportRevenueData.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportRevenueData.Name = "btnReportRevenueData";
            this.btnReportRevenueData.Size = new System.Drawing.Size(230, 46);
            this.btnReportRevenueData.TabIndex = 3;
            this.btnReportRevenueData.Text = "BÁO CÁO DOANH THU";
            this.btnReportRevenueData.UseVisualStyleBackColor = false;
            this.btnReportRevenueData.Click += new System.EventHandler(this.btnRevenueReport_Click);
            // 
            // btnReportBookData
            // 
            this.btnReportBookData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReportBookData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportBookData.FlatAppearance.BorderSize = 0;
            this.btnReportBookData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportBookData.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReportBookData.ForeColor = System.Drawing.Color.Tomato;
            this.btnReportBookData.Location = new System.Drawing.Point(0, 40);
            this.btnReportBookData.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportBookData.Name = "btnReportBookData";
            this.btnReportBookData.Size = new System.Drawing.Size(230, 46);
            this.btnReportBookData.TabIndex = 2;
            this.btnReportBookData.Text = "BÁO CÁO TỒN";
            this.btnReportBookData.UseVisualStyleBackColor = false;
            this.btnReportBookData.Click += new System.EventHandler(this.btnInventoryReport_Click);
            // 
            // btnReportMenu
            // 
            this.btnReportMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnReportMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportMenu.FlatAppearance.BorderSize = 0;
            this.btnReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMenu.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReportMenu.ForeColor = System.Drawing.Color.White;
            this.btnReportMenu.Location = new System.Drawing.Point(0, 0);
            this.btnReportMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportMenu.Name = "btnReportMenu";
            this.btnReportMenu.Size = new System.Drawing.Size(230, 40);
            this.btnReportMenu.TabIndex = 1;
            this.btnReportMenu.Text = "BÁO CÁO THÁNG";
            this.btnReportMenu.UseVisualStyleBackColor = false;
            this.btnReportMenu.Click += new System.EventHandler(this.btnReportMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnRuleData);
            this.panel2.Controls.Add(this.btnEmployeeData);
            this.panel2.Controls.Add(this.btnEmpAndRuleMenu);
            this.panel2.Location = new System.Drawing.Point(2, 363);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.MaximumSize = new System.Drawing.Size(230, 130);
            this.panel2.MinimumSize = new System.Drawing.Size(230, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 43);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnRuleData
            // 
            this.btnRuleData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRuleData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRuleData.FlatAppearance.BorderSize = 0;
            this.btnRuleData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuleData.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRuleData.ForeColor = System.Drawing.Color.Tomato;
            this.btnRuleData.Location = new System.Drawing.Point(0, 86);
            this.btnRuleData.Margin = new System.Windows.Forms.Padding(2);
            this.btnRuleData.Name = "btnRuleData";
            this.btnRuleData.Size = new System.Drawing.Size(230, 46);
            this.btnRuleData.TabIndex = 3;
            this.btnRuleData.Text = "THAY ĐỔI QUY ĐỊNH";
            this.btnRuleData.UseVisualStyleBackColor = false;
            this.btnRuleData.Click += new System.EventHandler(this.btnRuleClick);
            // 
            // btnEmployeeData
            // 
            this.btnEmployeeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmployeeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeData.FlatAppearance.BorderSize = 0;
            this.btnEmployeeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeData.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmployeeData.ForeColor = System.Drawing.Color.Tomato;
            this.btnEmployeeData.Location = new System.Drawing.Point(0, 40);
            this.btnEmployeeData.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeeData.Name = "btnEmployeeData";
            this.btnEmployeeData.Size = new System.Drawing.Size(230, 46);
            this.btnEmployeeData.TabIndex = 2;
            this.btnEmployeeData.Text = "DANH SÁCH NHÂN VIÊN";
            this.btnEmployeeData.UseVisualStyleBackColor = false;
            this.btnEmployeeData.Click += new System.EventHandler(this.btnEmployeeClick);
            // 
            // btnEmpAndRuleMenu
            // 
            this.btnEmpAndRuleMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnEmpAndRuleMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpAndRuleMenu.FlatAppearance.BorderSize = 0;
            this.btnEmpAndRuleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAndRuleMenu.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmpAndRuleMenu.ForeColor = System.Drawing.Color.White;
            this.btnEmpAndRuleMenu.Location = new System.Drawing.Point(0, 0);
            this.btnEmpAndRuleMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpAndRuleMenu.Name = "btnEmpAndRuleMenu";
            this.btnEmpAndRuleMenu.Size = new System.Drawing.Size(230, 40);
            this.btnEmpAndRuleMenu.TabIndex = 1;
            this.btnEmpAndRuleMenu.Text = "NHÂN SỰ - QUY ĐỊNH";
            this.btnEmpAndRuleMenu.UseVisualStyleBackColor = false;
            this.btnEmpAndRuleMenu.Click += new System.EventHandler(this.btnEmpAndRuleMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnReceiveBookData);
            this.panel1.Controls.Add(this.btnReceiveMoneyData);
            this.panel1.Controls.Add(this.btnBillData);
            this.panel1.Controls.Add(this.btnSellMenu);
            this.panel1.Location = new System.Drawing.Point(2, 316);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.MaximumSize = new System.Drawing.Size(230, 171);
            this.panel1.MinimumSize = new System.Drawing.Size(230, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 43);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnReceiveBookData
            // 
            this.btnReceiveBookData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReceiveBookData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceiveBookData.FlatAppearance.BorderSize = 0;
            this.btnReceiveBookData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveBookData.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReceiveBookData.ForeColor = System.Drawing.Color.Tomato;
            this.btnReceiveBookData.Location = new System.Drawing.Point(0, 132);
            this.btnReceiveBookData.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceiveBookData.Name = "btnReceiveBookData";
            this.btnReceiveBookData.Size = new System.Drawing.Size(230, 48);
            this.btnReceiveBookData.TabIndex = 4;
            this.btnReceiveBookData.Text = "LẬP PHIẾU NHẬP";
            this.btnReceiveBookData.UseVisualStyleBackColor = false;
            this.btnReceiveBookData.Click += new System.EventHandler(this.btnReceiveBook_Click);
            // 
            // btnReceiveMoneyData
            // 
            this.btnReceiveMoneyData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReceiveMoneyData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceiveMoneyData.FlatAppearance.BorderSize = 0;
            this.btnReceiveMoneyData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveMoneyData.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReceiveMoneyData.ForeColor = System.Drawing.Color.Tomato;
            this.btnReceiveMoneyData.Location = new System.Drawing.Point(0, 86);
            this.btnReceiveMoneyData.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceiveMoneyData.Name = "btnReceiveMoneyData";
            this.btnReceiveMoneyData.Size = new System.Drawing.Size(230, 46);
            this.btnReceiveMoneyData.TabIndex = 3;
            this.btnReceiveMoneyData.Text = "LẬP PHIẾU THU";
            this.btnReceiveMoneyData.UseVisualStyleBackColor = false;
            this.btnReceiveMoneyData.Click += new System.EventHandler(this.btnReceiveMoney_Click);
            // 
            // btnBillData
            // 
            this.btnBillData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBillData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillData.FlatAppearance.BorderSize = 0;
            this.btnBillData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillData.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBillData.ForeColor = System.Drawing.Color.Tomato;
            this.btnBillData.Location = new System.Drawing.Point(0, 40);
            this.btnBillData.Margin = new System.Windows.Forms.Padding(2);
            this.btnBillData.Name = "btnBillData";
            this.btnBillData.Size = new System.Drawing.Size(230, 46);
            this.btnBillData.TabIndex = 2;
            this.btnBillData.Text = "LẬP HÓA ĐƠN";
            this.btnBillData.UseVisualStyleBackColor = false;
            this.btnBillData.Click += new System.EventHandler(this.btnSellBook_Click);
            // 
            // btnSellMenu
            // 
            this.btnSellMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnSellMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellMenu.FlatAppearance.BorderSize = 0;
            this.btnSellMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellMenu.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSellMenu.ForeColor = System.Drawing.Color.White;
            this.btnSellMenu.Location = new System.Drawing.Point(0, 0);
            this.btnSellMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnSellMenu.Name = "btnSellMenu";
            this.btnSellMenu.Size = new System.Drawing.Size(230, 40);
            this.btnSellMenu.TabIndex = 1;
            this.btnSellMenu.Text = "QUẢN LÝ BÁN HÀNG";
            this.btnSellMenu.UseVisualStyleBackColor = false;
            this.btnSellMenu.Click += new System.EventHandler(this.btnSellMenu_Click);
            // 
            // panelManageData
            // 
            this.panelManageData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManageData.Controls.Add(this.pictureBox1);
            this.panelManageData.Controls.Add(this.btnCategoryAndAuthor);
            this.panelManageData.Controls.Add(this.btnCustomerData);
            this.panelManageData.Controls.Add(this.btnBookData);
            this.panelManageData.Controls.Add(this.btnDataMenu);
            this.panelManageData.Location = new System.Drawing.Point(2, 269);
            this.panelManageData.Margin = new System.Windows.Forms.Padding(2);
            this.panelManageData.MaximumSize = new System.Drawing.Size(230, 171);
            this.panelManageData.MinimumSize = new System.Drawing.Size(230, 43);
            this.panelManageData.Name = "panelManageData";
            this.panelManageData.Size = new System.Drawing.Size(230, 43);
            this.panelManageData.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCategoryAndAuthor
            // 
            this.btnCategoryAndAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCategoryAndAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoryAndAuthor.FlatAppearance.BorderSize = 0;
            this.btnCategoryAndAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryAndAuthor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryAndAuthor.ForeColor = System.Drawing.Color.Tomato;
            this.btnCategoryAndAuthor.Location = new System.Drawing.Point(0, 132);
            this.btnCategoryAndAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoryAndAuthor.Name = "btnCategoryAndAuthor";
            this.btnCategoryAndAuthor.Size = new System.Drawing.Size(230, 48);
            this.btnCategoryAndAuthor.TabIndex = 4;
            this.btnCategoryAndAuthor.Text = "Thể loại - Tác giả";
            this.btnCategoryAndAuthor.UseVisualStyleBackColor = false;
            this.btnCategoryAndAuthor.Click += new System.EventHandler(this.btnCategoryAndAuthorData_Click);
            // 
            // btnCustomerData
            // 
            this.btnCustomerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCustomerData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerData.FlatAppearance.BorderSize = 0;
            this.btnCustomerData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerData.ForeColor = System.Drawing.Color.Tomato;
            this.btnCustomerData.Location = new System.Drawing.Point(0, 86);
            this.btnCustomerData.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerData.Name = "btnCustomerData";
            this.btnCustomerData.Size = new System.Drawing.Size(230, 46);
            this.btnCustomerData.TabIndex = 3;
            this.btnCustomerData.Text = "Khách hàng";
            this.btnCustomerData.UseVisualStyleBackColor = false;
            this.btnCustomerData.Click += new System.EventHandler(this.btnCustomerData_Click);
            // 
            // btnBookData
            // 
            this.btnBookData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBookData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookData.FlatAppearance.BorderSize = 0;
            this.btnBookData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBookData.ForeColor = System.Drawing.Color.Tomato;
            this.btnBookData.Location = new System.Drawing.Point(0, 40);
            this.btnBookData.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookData.Name = "btnBookData";
            this.btnBookData.Size = new System.Drawing.Size(230, 46);
            this.btnBookData.TabIndex = 2;
            this.btnBookData.Text = "Dữ liệu sách";
            this.btnBookData.UseVisualStyleBackColor = false;
            this.btnBookData.Click += new System.EventHandler(this.btnBookData_Click);
            // 
            // btnDataMenu
            // 
            this.btnDataMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnDataMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataMenu.FlatAppearance.BorderSize = 0;
            this.btnDataMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataMenu.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDataMenu.ForeColor = System.Drawing.Color.White;
            this.btnDataMenu.Location = new System.Drawing.Point(0, 0);
            this.btnDataMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDataMenu.Name = "btnDataMenu";
            this.btnDataMenu.Size = new System.Drawing.Size(230, 40);
            this.btnDataMenu.TabIndex = 1;
            this.btnDataMenu.Text = "QUẢN LÝ DỮ LIỆU";
            this.btnDataMenu.UseVisualStyleBackColor = false;
            this.btnDataMenu.Click += new System.EventHandler(this.btnDataMenu_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.lbAddress);
            this.panel4.Controls.Add(this.lbEmail);
            this.panel4.Controls.Add(this.lblPhone);
            this.panel4.Controls.Add(this.lbRealname);
            this.panel4.Controls.Add(this.lbType);
            this.panel4.Controls.Add(this.lbPassword);
            this.panel4.Controls.Add(this.lbUsername);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 263);
            this.panel4.TabIndex = 1;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lbAddress.Location = new System.Drawing.Point(110, 217);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(66, 15);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Username";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lbEmail.Location = new System.Drawing.Point(110, 191);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(66, 15);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Username";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblPhone.Location = new System.Drawing.Point(110, 163);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 15);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Username";
            // 
            // lbRealname
            // 
            this.lbRealname.AutoSize = true;
            this.lbRealname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRealname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lbRealname.Location = new System.Drawing.Point(110, 140);
            this.lbRealname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRealname.Name = "lbRealname";
            this.lbRealname.Size = new System.Drawing.Size(66, 15);
            this.lbRealname.TabIndex = 12;
            this.lbRealname.Text = "Username";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lbType.Location = new System.Drawing.Point(110, 115);
            this.lbType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(66, 15);
            this.lbType.TabIndex = 11;
            this.lbType.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lbPassword.Location = new System.Drawing.Point(110, 93);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 15);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Username";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lbUsername.Location = new System.Drawing.Point(110, 71);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(66, 15);
            this.lbUsername.TabIndex = 9;
            this.lbUsername.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(41, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label8.Location = new System.Drawing.Point(55, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(62, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(27, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "PERSONAL INFO";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(2, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "---------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(51, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Realname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MenuPanel.Controls.Add(this.panel4);
            this.MenuPanel.Controls.Add(this.panelManageData);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Controls.Add(this.panel3);
            this.MenuPanel.Controls.Add(this.btnLogout);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(235, 812);
            this.MenuPanel.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelChildForm.Location = new System.Drawing.Point(236, 2);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(962, 810);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(3, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 32);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 812);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelManageData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lbRealname;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}