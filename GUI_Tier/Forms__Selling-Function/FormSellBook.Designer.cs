namespace GUI_Tier.FormsForSelling_Function
{
    partial class FormSellBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToListBuy = new System.Windows.Forms.Button();
            this.listviewBooksBuy = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxDay = new System.Windows.Forms.TextBox();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.textboxMoneychange = new System.Windows.Forms.TextBox();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listviewBooks = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.numberOfBookBuy = new System.Windows.Forms.NumericUpDown();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textboxMoney = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBookBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(59, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddToListBuy
            // 
            this.btnAddToListBuy.BackColor = System.Drawing.Color.Purple;
            this.btnAddToListBuy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToListBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToListBuy.Location = new System.Drawing.Point(951, 740);
            this.btnAddToListBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToListBuy.Name = "btnAddToListBuy";
            this.btnAddToListBuy.Size = new System.Drawing.Size(241, 48);
            this.btnAddToListBuy.TabIndex = 2;
            this.btnAddToListBuy.Text = "Thêm vào giỏ hàng";
            this.btnAddToListBuy.UseVisualStyleBackColor = false;
            this.btnAddToListBuy.Click += new System.EventHandler(this.btnAddToListBuy_Click);
            // 
            // listviewBooksBuy
            // 
            this.listviewBooksBuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listviewBooksBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listviewBooksBuy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listviewBooksBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewBooksBuy.FullRowSelect = true;
            this.listviewBooksBuy.GridLines = true;
            this.listviewBooksBuy.HideSelection = false;
            this.listviewBooksBuy.Location = new System.Drawing.Point(593, 79);
            this.listviewBooksBuy.Margin = new System.Windows.Forms.Padding(4);
            this.listviewBooksBuy.MultiSelect = false;
            this.listviewBooksBuy.Name = "listviewBooksBuy";
            this.listviewBooksBuy.Size = new System.Drawing.Size(599, 284);
            this.listviewBooksBuy.TabIndex = 8;
            this.listviewBooksBuy.UseCompatibleStateImageBehavior = false;
            this.listviewBooksBuy.View = System.Windows.Forms.View.Details;
            this.listviewBooksBuy.ItemActivate += new System.EventHandler(this.ListViewBookBuy_ItemClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Sách";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Sách";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá Bán";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng Tiền";
            this.columnHeader6.Width = 80;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Purple;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1228, 67);
            this.label8.TabIndex = 19;
            this.label8.Text = "HÓA ĐƠN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(47, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Còn Lại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(27, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số Tiền Nhận";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(59, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tổng Tiền";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(97, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ngày HĐ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textboxDay
            // 
            this.textboxDay.Enabled = false;
            this.textboxDay.Location = new System.Drawing.Point(190, 124);
            this.textboxDay.Margin = new System.Windows.Forms.Padding(4);
            this.textboxDay.Multiline = true;
            this.textboxDay.Name = "textboxDay";
            this.textboxDay.ReadOnly = true;
            this.textboxDay.Size = new System.Drawing.Size(357, 22);
            this.textboxDay.TabIndex = 30;
            this.textboxDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxTotal
            // 
            this.textboxTotal.Enabled = false;
            this.textboxTotal.Location = new System.Drawing.Point(190, 177);
            this.textboxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.ReadOnly = true;
            this.textboxTotal.Size = new System.Drawing.Size(357, 22);
            this.textboxTotal.TabIndex = 31;
            this.textboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxMoneychange
            // 
            this.textboxMoneychange.Enabled = false;
            this.textboxMoneychange.Location = new System.Drawing.Point(191, 272);
            this.textboxMoneychange.Margin = new System.Windows.Forms.Padding(4);
            this.textboxMoneychange.Multiline = true;
            this.textboxMoneychange.Name = "textboxMoneychange";
            this.textboxMoneychange.ReadOnly = true;
            this.textboxMoneychange.Size = new System.Drawing.Size(357, 31);
            this.textboxMoneychange.TabIndex = 33;
            this.textboxMoneychange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxSearch
            // 
            this.textboxSearch.Location = new System.Drawing.Point(27, 434);
            this.textboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSearch.Multiline = true;
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(1053, 27);
            this.textboxSearch.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(-1, 376);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1229, 44);
            this.label2.TabIndex = 36;
            this.label2.Text = "CHỌN SÁCH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listviewBooks
            // 
            this.listviewBooks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listviewBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listviewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listviewBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewBooks.FullRowSelect = true;
            this.listviewBooks.GridLines = true;
            this.listviewBooks.HideSelection = false;
            this.listviewBooks.Location = new System.Drawing.Point(27, 470);
            this.listviewBooks.Margin = new System.Windows.Forms.Padding(4);
            this.listviewBooks.MultiSelect = false;
            this.listviewBooks.Name = "listviewBooks";
            this.listviewBooks.Size = new System.Drawing.Size(1166, 247);
            this.listviewBooks.TabIndex = 37;
            this.listviewBooks.UseCompatibleStateImageBehavior = false;
            this.listviewBooks.View = System.Windows.Forms.View.Details;
            this.listviewBooks.ItemActivate += new System.EventHandler(this.myListView_ItemClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã Sách";
            this.columnHeader8.Width = 136;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên Sách";
            this.columnHeader9.Width = 480;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Số Lượng";
            this.columnHeader10.Width = 137;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Giá Bán";
            this.columnHeader11.Width = 138;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(21, 791);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nhập Số Lượng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(191, 326);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 37);
            this.button3.TabIndex = 42;
            this.button3.Text = "Tạo Mới";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Purple;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(395, 326);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 37);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Purple;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1088, 434);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 32);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(191, 79);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(357, 24);
            this.cbbCustomer.TabIndex = 49;
            // 
            // numberOfBookBuy
            // 
            this.numberOfBookBuy.Location = new System.Drawing.Point(261, 801);
            this.numberOfBookBuy.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numberOfBookBuy.Name = "numberOfBookBuy";
            this.numberOfBookBuy.Size = new System.Drawing.Size(120, 22);
            this.numberOfBookBuy.TabIndex = 50;
            // 
            // textboxName
            // 
            this.textboxName.Enabled = false;
            this.textboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textboxName.Location = new System.Drawing.Point(261, 745);
            this.textboxName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxName.Multiline = true;
            this.textboxName.Name = "textboxName";
            this.textboxName.ReadOnly = true;
            this.textboxName.Size = new System.Drawing.Size(682, 33);
            this.textboxName.TabIndex = 51;
            this.textboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.ForestGreen;
            this.label9.Location = new System.Drawing.Point(21, 745);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 32);
            this.label9.TabIndex = 52;
            this.label9.Text = "Sách đang chọn:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textboxMoney
            // 
            this.textboxMoney.Location = new System.Drawing.Point(190, 222);
            this.textboxMoney.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.textboxMoney.Name = "textboxMoney";
            this.textboxMoney.Size = new System.Drawing.Size(357, 22);
            this.textboxMoney.TabIndex = 53;
            this.textboxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxMoney.ValueChanged += new System.EventHandler(this.textboxMoney_ValueChanged);
            // 
            // FormSellBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1228, 857);
            this.Controls.Add(this.textboxMoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.numberOfBookBuy);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listviewBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.textboxMoneychange);
            this.Controls.Add(this.textboxTotal);
            this.Controls.Add(this.textboxDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listviewBooksBuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddToListBuy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSellBook";
            this.Text = "FormSellBook";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBookBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToListBuy;
        private System.Windows.Forms.ListView listviewBooksBuy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxDay;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.TextBox textboxMoneychange;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listviewBooks;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.NumericUpDown numberOfBookBuy;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown textboxMoney;
    }
}