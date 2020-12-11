namespace GUI_Tier.FormsForSelling_Function
{
    partial class FormReceiveMoney
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
            this.ksdk = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.RichTextBox();
            this.moneyRest = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.RichTextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moneyReceive = new System.Windows.Forms.NumericUpDown();
            this.moneyOwe = new System.Windows.Forms.NumericUpDown();
            this.ksdk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyOwe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1228, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu thu tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ksdk
            // 
            this.ksdk.BackColor = System.Drawing.Color.Purple;
            this.ksdk.Controls.Add(this.moneyOwe);
            this.ksdk.Controls.Add(this.moneyReceive);
            this.ksdk.Controls.Add(this.label7);
            this.ksdk.Controls.Add(this.date);
            this.ksdk.Controls.Add(this.moneyRest);
            this.ksdk.Controls.Add(this.name);
            this.ksdk.Controls.Add(this.btnPay);
            this.ksdk.Controls.Add(this.btnRefresh);
            this.ksdk.Controls.Add(this.label6);
            this.ksdk.Controls.Add(this.label5);
            this.ksdk.Controls.Add(this.label4);
            this.ksdk.Controls.Add(this.label3);
            this.ksdk.Controls.Add(this.label2);
            this.ksdk.Location = new System.Drawing.Point(814, 79);
            this.ksdk.Margin = new System.Windows.Forms.Padding(4);
            this.ksdk.Name = "ksdk";
            this.ksdk.Size = new System.Drawing.Size(409, 754);
            this.ksdk.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-7, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 10);
            this.label7.TabIndex = 17;
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.No;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.date.Location = new System.Drawing.Point(20, 478);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(373, 35);
            this.date.TabIndex = 16;
            this.date.Text = "";
            // 
            // moneyRest
            // 
            this.moneyRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.moneyRest.Location = new System.Drawing.Point(20, 374);
            this.moneyRest.Name = "moneyRest";
            this.moneyRest.ReadOnly = true;
            this.moneyRest.Size = new System.Drawing.Size(373, 35);
            this.moneyRest.TabIndex = 15;
            this.moneyRest.Text = "";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(20, 73);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(373, 35);
            this.name.TabIndex = 12;
            this.name.Text = "";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(20, 677);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(373, 56);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(20, 594);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(373, 59);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(15, 446);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(15, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Còn lại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(15, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập số tiền thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(15, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền nợ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 79);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(805, 754);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.ListViewBookReceive_ItemClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã khách hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên khách hàng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 300;
            // 
            // moneyReceive
            // 
            this.moneyReceive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyReceive.Location = new System.Drawing.Point(20, 277);
            this.moneyReceive.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.moneyReceive.Name = "moneyReceive";
            this.moneyReceive.Size = new System.Drawing.Size(373, 34);
            this.moneyReceive.TabIndex = 18;
            this.moneyReceive.ValueChanged += new System.EventHandler(this.moneyReceive_ValueChanged);
            // 
            // moneyOwe
            // 
            this.moneyOwe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyOwe.Enabled = false;
            this.moneyOwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyOwe.Location = new System.Drawing.Point(20, 170);
            this.moneyOwe.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.moneyOwe.Name = "moneyOwe";
            this.moneyOwe.Size = new System.Drawing.Size(373, 34);
            this.moneyOwe.TabIndex = 19;
            // 
            // FormReceiveMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1228, 846);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ksdk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReceiveMoney";
            this.Text = "FormReceiveMoney";
            this.ksdk.ResumeLayout(false);
            this.ksdk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyOwe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ksdk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox date;
        private System.Windows.Forms.RichTextBox moneyRest;
        private System.Windows.Forms.RichTextBox name;
        private System.Windows.Forms.NumericUpDown moneyReceive;
        private System.Windows.Forms.NumericUpDown moneyOwe;
    }
}