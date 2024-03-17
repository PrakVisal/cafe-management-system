namespace RMS_Project
{
    partial class frmCRUD_Stock
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lblQty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.ptrImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.dtpExpiration = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSafetyAlert = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoStockOUT = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoStockIN = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2ContainerControl3 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnIncrement = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDecrement = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStockCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).BeginInit();
            this.guna2ContainerControl2.SuspendLayout();
            this.guna2ContainerControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(520, 81);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 30;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::RMS_Project.Properties.Resources.icons8_cross_501;
            this.btnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExit.Location = new System.Drawing.Point(459, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stock Management";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.btnSave);
            this.guna2Panel2.Controls.Add(this.btnClear);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 680);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(520, 86);
            this.guna2Panel2.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnSave.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(268, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 55);
            this.btnSave.TabIndex = 7;
            this.btnSave.Tag = "Save";
            this.btnSave.Text = "Save";
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnClear.BorderRadius = 10;
            this.btnClear.BorderThickness = 1;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(85)))), ((int)(((byte)(95)))));
            this.btnClear.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(85)))), ((int)(((byte)(95)))));
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(52, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 55);
            this.btnClear.TabIndex = 6;
            this.btnClear.Tag = "Cancel";
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 20;
            this.guna2ContainerControl1.Controls.Add(this.lblQty);
            this.guna2ContainerControl1.Controls.Add(this.label2);
            this.guna2ContainerControl1.Controls.Add(this.lblItemName);
            this.guna2ContainerControl1.Controls.Add(this.ptrImage);
            this.guna2ContainerControl1.CustomizableEdges.BottomLeft = false;
            this.guna2ContainerControl1.CustomizableEdges.BottomRight = false;
            this.guna2ContainerControl1.CustomizableEdges.TopLeft = false;
            this.guna2ContainerControl1.CustomizableEdges.TopRight = false;
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 81);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(520, 107);
            this.guna2ContainerControl1.TabIndex = 17;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(96)))), ((int)(((byte)(249)))));
            this.lblQty.Font = new System.Drawing.Font("!Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQty.Location = new System.Drawing.Point(235, 49);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(31, 29);
            this.lblQty.TabIndex = 16;
            this.lblQty.Text = "69";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("!Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(107, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Quantity";
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("!Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(107, 13);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(409, 36);
            this.lblItemName.TabIndex = 16;
            this.lblItemName.Text = "សាច់ចង្កាក់";
            // 
            // ptrImage
            // 
            this.ptrImage.BackColor = System.Drawing.Color.Transparent;
            this.ptrImage.BorderRadius = 10;
            this.ptrImage.Image = global::RMS_Project.Properties.Resources.no_image;
            this.ptrImage.ImageRotate = 0F;
            this.ptrImage.Location = new System.Drawing.Point(31, 13);
            this.ptrImage.Name = "ptrImage";
            this.ptrImage.Size = new System.Drawing.Size(70, 70);
            this.ptrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrImage.TabIndex = 15;
            this.ptrImage.TabStop = false;
            // 
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.Controls.Add(this.dtpExpiration);
            this.guna2ContainerControl2.Controls.Add(this.cboCategory);
            this.guna2ContainerControl2.Controls.Add(this.txtSafetyAlert);
            this.guna2ContainerControl2.Controls.Add(this.txtPrice);
            this.guna2ContainerControl2.Controls.Add(this.label7);
            this.guna2ContainerControl2.Controls.Add(this.label5);
            this.guna2ContainerControl2.Controls.Add(this.label6);
            this.guna2ContainerControl2.Controls.Add(this.txtUnitPrice);
            this.guna2ContainerControl2.Controls.Add(this.label4);
            this.guna2ContainerControl2.Controls.Add(this.guna2Separator1);
            this.guna2ContainerControl2.Controls.Add(this.label3);
            this.guna2ContainerControl2.Controls.Add(this.rdoStockOUT);
            this.guna2ContainerControl2.Controls.Add(this.rdoStockIN);
            this.guna2ContainerControl2.Location = new System.Drawing.Point(0, 201);
            this.guna2ContainerControl2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(520, 312);
            this.guna2ContainerControl2.TabIndex = 18;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.BackColor = System.Drawing.Color.White;
            this.dtpExpiration.Checked = true;
            this.dtpExpiration.FillColor = System.Drawing.Color.White;
            this.dtpExpiration.Font = new System.Drawing.Font("SF Pro Display", 10F);
            this.dtpExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExpiration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.dtpExpiration.Location = new System.Drawing.Point(201, 200);
            this.dtpExpiration.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpiration.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(200, 36);
            this.dtpExpiration.TabIndex = 23;
            this.dtpExpiration.Value = new System.DateTime(2024, 3, 16, 15, 40, 57, 491);
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboCategory.BorderRadius = 5;
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCategory.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.ForeColor = System.Drawing.Color.Black;
            this.cboCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.cboCategory.ItemHeight = 30;
            this.cboCategory.Location = new System.Drawing.Point(201, 158);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 36);
            this.cboCategory.TabIndex = 22;
            // 
            // txtSafetyAlert
            // 
            this.txtSafetyAlert.Animated = true;
            this.txtSafetyAlert.BackColor = System.Drawing.Color.Transparent;
            this.txtSafetyAlert.BorderRadius = 5;
            this.txtSafetyAlert.BorderThickness = 2;
            this.txtSafetyAlert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSafetyAlert.DefaultText = "";
            this.txtSafetyAlert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSafetyAlert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSafetyAlert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSafetyAlert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSafetyAlert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtSafetyAlert.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSafetyAlert.ForeColor = System.Drawing.Color.Black;
            this.txtSafetyAlert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtSafetyAlert.Location = new System.Drawing.Point(201, 242);
            this.txtSafetyAlert.Name = "txtSafetyAlert";
            this.txtSafetyAlert.PasswordChar = '\0';
            this.txtSafetyAlert.PlaceholderText = "Enter Amount";
            this.txtSafetyAlert.SelectedText = "";
            this.txtSafetyAlert.Size = new System.Drawing.Size(200, 36);
            this.txtSafetyAlert.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Animated = true;
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderRadius = 5;
            this.txtPrice.BorderThickness = 2;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtPrice.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtPrice.Location = new System.Drawing.Point(201, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Enter Price";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(200, 36);
            this.txtPrice.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(54, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Safety Alert";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(54, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(54, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Expiration Date";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Animated = true;
            this.txtUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtUnitPrice.BorderRadius = 5;
            this.txtUnitPrice.BorderThickness = 2;
            this.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitPrice.DefaultText = "";
            this.txtUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtUnitPrice.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.txtUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtUnitPrice.Location = new System.Drawing.Point(201, 74);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.PlaceholderText = "Enter Unit Price";
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 36);
            this.txtUnitPrice.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(54, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(31, 48);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(457, 10);
            this.guna2Separator1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(54, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Unit Price";
            // 
            // rdoStockOUT
            // 
            this.rdoStockOUT.Animated = true;
            this.rdoStockOUT.AutoSize = true;
            this.rdoStockOUT.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockOUT.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.rdoStockOUT.CheckedState.BorderThickness = 0;
            this.rdoStockOUT.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.rdoStockOUT.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoStockOUT.CheckedState.InnerOffset = -4;
            this.rdoStockOUT.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStockOUT.Location = new System.Drawing.Point(322, 19);
            this.rdoStockOUT.Name = "rdoStockOUT";
            this.rdoStockOUT.Size = new System.Drawing.Size(106, 23);
            this.rdoStockOUT.TabIndex = 18;
            this.rdoStockOUT.Text = "Stock OUT";
            this.rdoStockOUT.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoStockOUT.UncheckedState.BorderThickness = 2;
            this.rdoStockOUT.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoStockOUT.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoStockOUT.UseVisualStyleBackColor = false;
            // 
            // rdoStockIN
            // 
            this.rdoStockIN.Animated = true;
            this.rdoStockIN.AutoSize = true;
            this.rdoStockIN.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockIN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.rdoStockIN.CheckedState.BorderThickness = 0;
            this.rdoStockIN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.rdoStockIN.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoStockIN.CheckedState.InnerOffset = -4;
            this.rdoStockIN.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStockIN.Location = new System.Drawing.Point(86, 19);
            this.rdoStockIN.Name = "rdoStockIN";
            this.rdoStockIN.Size = new System.Drawing.Size(88, 23);
            this.rdoStockIN.TabIndex = 19;
            this.rdoStockIN.Text = "Stock IN";
            this.rdoStockIN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoStockIN.UncheckedState.BorderThickness = 2;
            this.rdoStockIN.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoStockIN.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoStockIN.UseVisualStyleBackColor = false;
            // 
            // guna2ContainerControl3
            // 
            this.guna2ContainerControl3.Controls.Add(this.btnIncrement);
            this.guna2ContainerControl3.Controls.Add(this.btnDecrement);
            this.guna2ContainerControl3.Controls.Add(this.txtQty);
            this.guna2ContainerControl3.Controls.Add(this.lblStockCount);
            this.guna2ContainerControl3.Controls.Add(this.label8);
            this.guna2ContainerControl3.Location = new System.Drawing.Point(0, 528);
            this.guna2ContainerControl3.Name = "guna2ContainerControl3";
            this.guna2ContainerControl3.Size = new System.Drawing.Size(520, 138);
            this.guna2ContainerControl3.TabIndex = 19;
            this.guna2ContainerControl3.Text = "guna2ContainerControl3";
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.Color.Transparent;
            this.btnIncrement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncrement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncrement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncrement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncrement.FillColor = System.Drawing.Color.Transparent;
            this.btnIncrement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIncrement.ForeColor = System.Drawing.Color.White;
            this.btnIncrement.Image = global::RMS_Project.Properties.Resources.icons8_add_50;
            this.btnIncrement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnIncrement.Location = new System.Drawing.Point(378, 44);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnIncrement.Size = new System.Drawing.Size(50, 50);
            this.btnIncrement.TabIndex = 17;
            this.btnIncrement.UseTransparentBackground = true;
            // 
            // btnDecrement
            // 
            this.btnDecrement.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrement.FillColor = System.Drawing.Color.Transparent;
            this.btnDecrement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecrement.ForeColor = System.Drawing.Color.White;
            this.btnDecrement.Image = global::RMS_Project.Properties.Resources.icons8_minus_50;
            this.btnDecrement.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDecrement.Location = new System.Drawing.Point(69, 44);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDecrement.Size = new System.Drawing.Size(50, 50);
            this.btnDecrement.TabIndex = 17;
            this.btnDecrement.UseTransparentBackground = true;
            // 
            // txtQty
            // 
            this.txtQty.Animated = true;
            this.txtQty.BackColor = System.Drawing.Color.Transparent;
            this.txtQty.BorderRadius = 5;
            this.txtQty.BorderThickness = 2;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultText = "";
            this.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtQty.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.txtQty.Location = new System.Drawing.Point(135, 44);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "Enter Quantity";
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(223, 50);
            this.txtQty.TabIndex = 21;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStockCount
            // 
            this.lblStockCount.BackColor = System.Drawing.Color.Transparent;
            this.lblStockCount.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblStockCount.Location = new System.Drawing.Point(131, 107);
            this.lblStockCount.Name = "lblStockCount";
            this.lblStockCount.Size = new System.Drawing.Size(227, 19);
            this.lblStockCount.TabIndex = 16;
            this.lblStockCount.Text = "69 > 65";
            this.lblStockCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(160, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Input Stock in Quantity";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmCRUD_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 766);
            this.Controls.Add(this.guna2ContainerControl3);
            this.Controls.Add(this.guna2ContainerControl2);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCRUD_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCRUD_Stock";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).EndInit();
            this.guna2ContainerControl2.ResumeLayout(false);
            this.guna2ContainerControl2.PerformLayout();
            this.guna2ContainerControl3.ResumeLayout(false);
            this.guna2ContainerControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemName;
        private Guna.UI2.WinForms.Guna2PictureBox ptrImage;
        private System.Windows.Forms.Label lblQty;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RadioButton rdoStockOUT;
        private Guna.UI2.WinForms.Guna2RadioButton rdoStockIN;
        private Guna.UI2.WinForms.Guna2ComboBox cboCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpiration;
        private Guna.UI2.WinForms.Guna2TextBox txtSafetyAlert;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private Guna.UI2.WinForms.Guna2CircleButton btnDecrement;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CircleButton btnIncrement;
        private Guna.UI2.WinForms.Guna2TextBox txtQty;
        private System.Windows.Forms.Label lblStockCount;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}