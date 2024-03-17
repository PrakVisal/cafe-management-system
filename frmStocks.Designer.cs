namespace RMS_Project
{
    partial class frmStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStocks));
            this.pnlBanner = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_Item_Stock1 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock2 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock3 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock4 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock5 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock6 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock7 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock8 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock9 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock10 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock11 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock12 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock13 = new RMS_Project.UC_Item_Stock();
            this.uC_Item_Stock14 = new RMS_Project.UC_Item_Stock();
            this.pnlBanner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.Controls.Add(this.label1);
            this.pnlBanner.Controls.Add(this.cboRole);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 119);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Padding = new System.Windows.Forms.Padding(90, 0, 45, 0);
            this.pnlBanner.Size = new System.Drawing.Size(1584, 71);
            this.pnlBanner.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 8;
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
            "Beverages",
            "Breakfast",
            "Frappe",
            "Lunch",
            "Juice",
            "Others",
            "Snack",
            "Promotion Set"});
            this.cboRole.ItemsAppearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cboRole.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.cboRole.ItemsAppearance.SelectedFont = new System.Drawing.Font("Poppins", 12F);
            this.cboRole.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.cboRole.Location = new System.Drawing.Point(138, 12);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(213, 46);
            this.cboRole.StartIndex = 0;
            this.cboRole.TabIndex = 6;
            this.cboRole.Tag = "Role";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.txtSearchProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 119);
            this.panel1.TabIndex = 8;
            // 
            // btnAccount
            // 
            this.btnAccount.Animated = true;
            this.btnAccount.BorderRadius = 20;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("League Spartan Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(181)))), ((int)(((byte)(160)))));
            this.btnAccount.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAccount.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccount.Location = new System.Drawing.Point(1306, 32);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(227, 58);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Angkor";
            this.btnAccount.TextOffset = new System.Drawing.Point(5, 0);
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
            this.txtSearchProduct.Location = new System.Drawing.Point(45, 32);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PlaceholderText = "Search Your Menu Here";
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.Size = new System.Drawing.Size(956, 58);
            this.txtSearchProduct.TabIndex = 2;
            this.txtSearchProduct.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock1);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock2);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock3);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock4);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock5);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock6);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock7);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock8);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock9);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock10);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock11);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock12);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock13);
            this.flowLayoutPanel1.Controls.Add(this.uC_Item_Stock14);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 190);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 30, 30, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1584, 851);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // uC_Item_Stock1
            // 
            this.uC_Item_Stock1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock1.Location = new System.Drawing.Point(48, 18);
            this.uC_Item_Stock1.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock1.Name = "uC_Item_Stock1";
            this.uC_Item_Stock1.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock1.TabIndex = 1;
            // 
            // uC_Item_Stock2
            // 
            this.uC_Item_Stock2.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock2.Location = new System.Drawing.Point(355, 18);
            this.uC_Item_Stock2.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock2.Name = "uC_Item_Stock2";
            this.uC_Item_Stock2.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock2.TabIndex = 2;
            // 
            // uC_Item_Stock3
            // 
            this.uC_Item_Stock3.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock3.Location = new System.Drawing.Point(662, 18);
            this.uC_Item_Stock3.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock3.Name = "uC_Item_Stock3";
            this.uC_Item_Stock3.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock3.TabIndex = 3;
            // 
            // uC_Item_Stock4
            // 
            this.uC_Item_Stock4.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock4.Location = new System.Drawing.Point(969, 18);
            this.uC_Item_Stock4.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock4.Name = "uC_Item_Stock4";
            this.uC_Item_Stock4.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock4.TabIndex = 4;
            // 
            // uC_Item_Stock5
            // 
            this.uC_Item_Stock5.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock5.Location = new System.Drawing.Point(1276, 18);
            this.uC_Item_Stock5.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock5.Name = "uC_Item_Stock5";
            this.uC_Item_Stock5.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock5.TabIndex = 5;
            // 
            // uC_Item_Stock6
            // 
            this.uC_Item_Stock6.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock6.Location = new System.Drawing.Point(48, 151);
            this.uC_Item_Stock6.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock6.Name = "uC_Item_Stock6";
            this.uC_Item_Stock6.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock6.TabIndex = 6;
            // 
            // uC_Item_Stock7
            // 
            this.uC_Item_Stock7.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock7.Location = new System.Drawing.Point(355, 151);
            this.uC_Item_Stock7.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock7.Name = "uC_Item_Stock7";
            this.uC_Item_Stock7.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock7.TabIndex = 7;
            // 
            // uC_Item_Stock8
            // 
            this.uC_Item_Stock8.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock8.Location = new System.Drawing.Point(662, 151);
            this.uC_Item_Stock8.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock8.Name = "uC_Item_Stock8";
            this.uC_Item_Stock8.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock8.TabIndex = 8;
            // 
            // uC_Item_Stock9
            // 
            this.uC_Item_Stock9.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock9.Location = new System.Drawing.Point(969, 151);
            this.uC_Item_Stock9.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock9.Name = "uC_Item_Stock9";
            this.uC_Item_Stock9.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock9.TabIndex = 9;
            // 
            // uC_Item_Stock10
            // 
            this.uC_Item_Stock10.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock10.Location = new System.Drawing.Point(1276, 151);
            this.uC_Item_Stock10.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock10.Name = "uC_Item_Stock10";
            this.uC_Item_Stock10.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock10.TabIndex = 10;
            // 
            // uC_Item_Stock11
            // 
            this.uC_Item_Stock11.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock11.Location = new System.Drawing.Point(48, 284);
            this.uC_Item_Stock11.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock11.Name = "uC_Item_Stock11";
            this.uC_Item_Stock11.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock11.TabIndex = 11;
            // 
            // uC_Item_Stock12
            // 
            this.uC_Item_Stock12.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock12.Location = new System.Drawing.Point(355, 284);
            this.uC_Item_Stock12.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock12.Name = "uC_Item_Stock12";
            this.uC_Item_Stock12.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock12.TabIndex = 12;
            // 
            // uC_Item_Stock13
            // 
            this.uC_Item_Stock13.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock13.Location = new System.Drawing.Point(662, 284);
            this.uC_Item_Stock13.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock13.Name = "uC_Item_Stock13";
            this.uC_Item_Stock13.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock13.TabIndex = 13;
            // 
            // uC_Item_Stock14
            // 
            this.uC_Item_Stock14.BackColor = System.Drawing.Color.Transparent;
            this.uC_Item_Stock14.Location = new System.Drawing.Point(969, 284);
            this.uC_Item_Stock14.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Item_Stock14.Name = "uC_Item_Stock14";
            this.uC_Item_Stock14.Size = new System.Drawing.Size(291, 117);
            this.uC_Item_Stock14.TabIndex = 14;
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1041);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStocks";
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBanner;
        private Guna.UI2.WinForms.Guna2ComboBox cboRole;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UC_Item_Stock uC_Item_Stock1;
        private UC_Item_Stock uC_Item_Stock2;
        private UC_Item_Stock uC_Item_Stock3;
        private UC_Item_Stock uC_Item_Stock4;
        private UC_Item_Stock uC_Item_Stock5;
        private UC_Item_Stock uC_Item_Stock6;
        private UC_Item_Stock uC_Item_Stock7;
        private UC_Item_Stock uC_Item_Stock8;
        private UC_Item_Stock uC_Item_Stock9;
        private UC_Item_Stock uC_Item_Stock10;
        private UC_Item_Stock uC_Item_Stock11;
        private UC_Item_Stock uC_Item_Stock12;
        private UC_Item_Stock uC_Item_Stock13;
        private UC_Item_Stock uC_Item_Stock14;
    }
}