namespace RMS_Project
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnNewItem = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFilterCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchProduct);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 107);
            this.panel1.TabIndex = 4;
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
            this.txtSearchProduct.Location = new System.Drawing.Point(100, 24);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PlaceholderText = "Search Your Menu Here";
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.Size = new System.Drawing.Size(956, 58);
            this.txtSearchProduct.TabIndex = 4;
            this.txtSearchProduct.TextOffset = new System.Drawing.Point(10, 0);
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
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(181)))), ((int)(((byte)(160)))));
            this.btnAccount.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAccount.HoverState.Image = global::RMS_Project.Properties.Resources.icons8_male_user_501;
            this.btnAccount.Image = global::RMS_Project.Properties.Resources.icons8_male_user_502;
            this.btnAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccount.Location = new System.Drawing.Point(1285, 24);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(227, 67);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Angkor";
            this.btnAccount.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(95, 204);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1381, 11);
            this.guna2Separator1.TabIndex = 5;
            // 
            // btnNewItem
            // 
            this.btnNewItem.Animated = true;
            this.btnNewItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnNewItem.BorderRadius = 10;
            this.btnNewItem.BorderThickness = 2;
            this.btnNewItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewItem.FillColor = System.Drawing.Color.White;
            this.btnNewItem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnNewItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnNewItem.Location = new System.Drawing.Point(1347, 110);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(165, 54);
            this.btnNewItem.TabIndex = 7;
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 167);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 30, 30, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1584, 874);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter by";
            // 
            // cboFilterCategory
            // 
            this.cboFilterCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterCategory.BorderRadius = 5;
            this.cboFilterCategory.BorderThickness = 2;
            this.cboFilterCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.cboFilterCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.cboFilterCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.cboFilterCategory.Font = new System.Drawing.Font("Poppins", 12F);
            this.cboFilterCategory.ForeColor = System.Drawing.Color.Black;
            this.cboFilterCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.cboFilterCategory.ItemHeight = 40;
            this.cboFilterCategory.Items.AddRange(new object[] {
            "All",
            "Beverages",
            "Breakfast",
            "Frappe",
            "Lunch",
            "Juice",
            "Others",
            "Snack",
            "Promotion Set"});
            this.cboFilterCategory.ItemsAppearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterCategory.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cboFilterCategory.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.cboFilterCategory.ItemsAppearance.SelectedFont = new System.Drawing.Font("Poppins", 12F);
            this.cboFilterCategory.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.cboFilterCategory.Location = new System.Drawing.Point(192, 118);
            this.cboFilterCategory.Name = "cboFilterCategory";
            this.cboFilterCategory.Size = new System.Drawing.Size(213, 46);
            this.cboFilterCategory.StartIndex = 0;
            this.cboFilterCategory.TabIndex = 9;
            this.cboFilterCategory.Tag = "Role";
            this.cboFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cboFilterCategory_SelectedIndexChanged_1);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFilterCategory);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItems";
            this.Text = "frmItems";
            this.Load += new System.EventHandler(this.frmItems_Load_1);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnNewItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilterCategory;
    }
}