namespace RMS_Project
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNewUsers = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlUser = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.cboRole);
            this.guna2Panel1.Controls.Add(this.btnNewUsers);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 119);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1584, 78);
            this.guna2Panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter by";
            // 
            // cboRole
            // 
            this.cboRole.BackColor = System.Drawing.Color.Transparent;
            this.cboRole.BorderRadius = 5;
            this.cboRole.BorderThickness = 2;
            this.cboRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.cboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.cboRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.cboRole.Font = new System.Drawing.Font("Poppins", 12F);
            this.cboRole.ForeColor = System.Drawing.Color.Black;
            this.cboRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.cboRole.ItemHeight = 40;
            this.cboRole.Items.AddRange(new object[] {
            "All",
            "Staff",
            "Stock Manager",
            "Admin"});
            this.cboRole.ItemsAppearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cboRole.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.cboRole.ItemsAppearance.SelectedFont = new System.Drawing.Font("Poppins", 12F);
            this.cboRole.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.cboRole.Location = new System.Drawing.Point(151, 32);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(213, 46);
            this.cboRole.StartIndex = 0;
            this.cboRole.TabIndex = 10;
            this.cboRole.Tag = "Role";
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // btnNewUsers
            // 
            this.btnNewUsers.Animated = true;
            this.btnNewUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnNewUsers.BorderRadius = 10;
            this.btnNewUsers.BorderThickness = 1;
            this.btnNewUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewUsers.FillColor = System.Drawing.Color.White;
            this.btnNewUsers.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnNewUsers.Image = global::RMS_Project.Properties.Resources.icons8_create_50;
            this.btnNewUsers.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnNewUsers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewUsers.Location = new System.Drawing.Point(1349, 23);
            this.btnNewUsers.Name = "btnNewUsers";
            this.btnNewUsers.Size = new System.Drawing.Size(169, 55);
            this.btnNewUsers.TabIndex = 8;
            this.btnNewUsers.Text = "New Users";
            this.btnNewUsers.TextOffset = new System.Drawing.Point(3, 0);
            this.btnNewUsers.Click += new System.EventHandler(this.btnNewUsers_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.pnlUser);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 197);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1584, 844);
            this.guna2Panel2.TabIndex = 7;
            // 
            // pnlUser
            // 
            this.pnlUser.AutoScroll = true;
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUser.Location = new System.Drawing.Point(0, 5);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Padding = new System.Windows.Forms.Padding(40, 10, 0, 0);
            this.pnlUser.Size = new System.Drawing.Size(1584, 839);
            this.pnlUser.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.BorderRadius = 20;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(181)))), ((int)(((byte)(160)))));
            this.btnAccount.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAccount.HoverState.Image = global::RMS_Project.Properties.Resources.icons8_male_user_501;
            this.btnAccount.Image = global::RMS_Project.Properties.Resources.icons8_male_user_502;
            this.btnAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccount.Location = new System.Drawing.Point(1291, 33);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(227, 58);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Angkor";
            this.btnAccount.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Animated = true;
            this.txtSearchProduct.BorderRadius = 10;
            this.txtSearchProduct.BorderThickness = 2;
            this.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProduct.DefaultText = "";
            this.txtSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtSearchProduct.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(181)))), ((int)(((byte)(160)))));
            this.txtSearchProduct.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchProduct.IconLeft")));
            this.txtSearchProduct.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearchProduct.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearchProduct.Location = new System.Drawing.Point(60, 33);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PlaceholderText = "Search Users Here";
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.Size = new System.Drawing.Size(956, 58);
            this.txtSearchProduct.TabIndex = 4;
            this.txtSearchProduct.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSearchProduct);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 119);
            this.panel1.TabIndex = 5;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1041);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnNewUsers;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboRole;
        private System.Windows.Forms.FlowLayoutPanel pnlUser;
        
    }
}