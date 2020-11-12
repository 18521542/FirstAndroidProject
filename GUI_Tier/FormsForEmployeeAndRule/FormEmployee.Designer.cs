namespace GUI_Tier
{
    partial class FormEmployee
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
            this.btnShow = new System.Windows.Forms.Button();
            this.TableUser = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Realname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(790, 115);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 41);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // TableUser
            // 
            this.TableUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Password,
            this.Type,
            this.Realname,
            this.Phonenumber,
            this.Email,
            this.Address});
            this.TableUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableUser.HideSelection = false;
            this.TableUser.Location = new System.Drawing.Point(0, 161);
            this.TableUser.Name = "TableUser";
            this.TableUser.Size = new System.Drawing.Size(921, 557);
            this.TableUser.TabIndex = 2;
            this.TableUser.UseCompatibleStateImageBehavior = false;
            this.TableUser.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.Text = "Password";
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Realname
            // 
            this.Realname.Text = "Realname";
            // 
            // Phonenumber
            // 
            this.Phonenumber.Text = "Phonenumber";
            this.Phonenumber.Width = 91;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 95;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 95;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(921, 718);
            this.Controls.Add(this.TableUser);
            this.Controls.Add(this.btnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListView TableUser;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Realname;
        private System.Windows.Forms.ColumnHeader Phonenumber;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Address;
    }
}