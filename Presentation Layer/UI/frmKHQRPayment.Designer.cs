namespace RMS_Project.Presentation_Layer.UI
{
    partial class frmKHQRPayment
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
            this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtTotalRiel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalDollar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTax = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPayment = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnKHR = new Guna.UI2.WinForms.Guna2Button();
            this.btnUSD = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlTitle.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(445, 78);
            this.pnlTitle.TabIndex = 4;
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
            this.btnExit.Location = new System.Drawing.Point(385, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(22, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KHQR Payment";
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.guna2Separator1);
            this.guna2ContainerControl1.Controls.Add(this.txtTotalRiel);
            this.guna2ContainerControl1.Controls.Add(this.txtTotalDollar);
            this.guna2ContainerControl1.Controls.Add(this.txtTax);
            this.guna2ContainerControl1.Controls.Add(this.txtSubTotal);
            this.guna2ContainerControl1.Controls.Add(this.label3);
            this.guna2ContainerControl1.Controls.Add(this.label5);
            this.guna2ContainerControl1.Controls.Add(this.label4);
            this.guna2ContainerControl1.Controls.Add(this.label2);
            this.guna2ContainerControl1.Controls.Add(this.label1);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 78);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(445, 259);
            this.guna2ContainerControl1.TabIndex = 5;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(41, 137);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(357, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // txtTotalRiel
            // 
            this.txtTotalRiel.BorderColor = System.Drawing.Color.Gray;
            this.txtTotalRiel.BorderRadius = 5;
            this.txtTotalRiel.BorderThickness = 2;
            this.txtTotalRiel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalRiel.DefaultText = "";
            this.txtTotalRiel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalRiel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalRiel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRiel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRiel.Enabled = false;
            this.txtTotalRiel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRiel.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtTotalRiel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRiel.Location = new System.Drawing.Point(198, 207);
            this.txtTotalRiel.Name = "txtTotalRiel";
            this.txtTotalRiel.PasswordChar = '\0';
            this.txtTotalRiel.PlaceholderText = "";
            this.txtTotalRiel.SelectedText = "";
            this.txtTotalRiel.Size = new System.Drawing.Size(200, 36);
            this.txtTotalRiel.TabIndex = 1;
            // 
            // txtTotalDollar
            // 
            this.txtTotalDollar.BorderColor = System.Drawing.Color.Gray;
            this.txtTotalDollar.BorderRadius = 5;
            this.txtTotalDollar.BorderThickness = 2;
            this.txtTotalDollar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDollar.DefaultText = "";
            this.txtTotalDollar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalDollar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalDollar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDollar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDollar.Enabled = false;
            this.txtTotalDollar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDollar.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtTotalDollar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDollar.Location = new System.Drawing.Point(198, 165);
            this.txtTotalDollar.Name = "txtTotalDollar";
            this.txtTotalDollar.PasswordChar = '\0';
            this.txtTotalDollar.PlaceholderText = "";
            this.txtTotalDollar.SelectedText = "";
            this.txtTotalDollar.Size = new System.Drawing.Size(200, 36);
            this.txtTotalDollar.TabIndex = 1;
            // 
            // txtTax
            // 
            this.txtTax.BorderColor = System.Drawing.Color.Gray;
            this.txtTax.BorderRadius = 5;
            this.txtTax.BorderThickness = 2;
            this.txtTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTax.DefaultText = "";
            this.txtTax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTax.Enabled = false;
            this.txtTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTax.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTax.Location = new System.Drawing.Point(198, 90);
            this.txtTax.Name = "txtTax";
            this.txtTax.PasswordChar = '\0';
            this.txtTax.PlaceholderText = "";
            this.txtTax.SelectedText = "";
            this.txtTax.Size = new System.Drawing.Size(200, 36);
            this.txtTax.TabIndex = 1;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderColor = System.Drawing.Color.Gray;
            this.txtSubTotal.BorderRadius = 5;
            this.txtSubTotal.BorderThickness = 2;
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubTotal.DefaultText = "";
            this.txtSubTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubTotal.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubTotal.Location = new System.Drawing.Point(198, 48);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.PlaceholderText = "";
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.Size = new System.Drawing.Size(200, 36);
            this.txtSubTotal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grand Total (៛)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Grand Total ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub Total ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Summary";
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.White;
            this.pnlPayment.BorderRadius = 10;
            this.pnlPayment.Controls.Add(this.btnKHR);
            this.pnlPayment.Controls.Add(this.btnUSD);
            this.pnlPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnlPayment.Location = new System.Drawing.Point(75, 355);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(294, 90);
            this.pnlPayment.TabIndex = 6;
            this.pnlPayment.Text = "guna2ContainerControl3";
            // 
            // btnKHR
            // 
            this.btnKHR.Animated = true;
            this.btnKHR.BackColor = System.Drawing.Color.Transparent;
            this.btnKHR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnKHR.BorderRadius = 10;
            this.btnKHR.BorderThickness = 2;
            this.btnKHR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKHR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKHR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKHR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKHR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnKHR.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.btnKHR.ForeColor = System.Drawing.Color.Black;
            this.btnKHR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnKHR.HoverState.FillColor = System.Drawing.Color.White;
            this.btnKHR.Image = global::RMS_Project.Properties.Resources.icons8_riel_50;
            this.btnKHR.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKHR.ImageOffset = new System.Drawing.Point(50, -12);
            this.btnKHR.ImageSize = new System.Drawing.Size(40, 40);
            this.btnKHR.Location = new System.Drawing.Point(147, 0);
            this.btnKHR.Name = "btnKHR";
            this.btnKHR.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.btnKHR.ShadowDecoration.BorderRadius = 10;
            this.btnKHR.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnKHR.Size = new System.Drawing.Size(147, 91);
            this.btnKHR.TabIndex = 12;
            this.btnKHR.Text = "KHR";
            this.btnKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKHR.TextOffset = new System.Drawing.Point(4, 23);
            this.btnKHR.Click += new System.EventHandler(this.btnKHR_Click);
            // 
            // btnUSD
            // 
            this.btnUSD.Animated = true;
            this.btnUSD.BackColor = System.Drawing.Color.Transparent;
            this.btnUSD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnUSD.BorderRadius = 10;
            this.btnUSD.BorderThickness = 2;
            this.btnUSD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUSD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUSD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUSD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUSD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnUSD.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.btnUSD.ForeColor = System.Drawing.Color.Black;
            this.btnUSD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnUSD.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUSD.Image = global::RMS_Project.Properties.Resources.icons8_dollar_50;
            this.btnUSD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUSD.ImageOffset = new System.Drawing.Point(47, -15);
            this.btnUSD.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUSD.Location = new System.Drawing.Point(1, 0);
            this.btnUSD.Name = "btnUSD";
            this.btnUSD.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.btnUSD.ShadowDecoration.BorderRadius = 10;
            this.btnUSD.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnUSD.Size = new System.Drawing.Size(147, 91);
            this.btnUSD.TabIndex = 11;
            this.btnUSD.Text = "USD";
            this.btnUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUSD.TextOffset = new System.Drawing.Point(0, 20);
            this.btnUSD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.BorderThickness = 1;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnConfirm.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnConfirm.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(41, 452);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(357, 55);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Tag = "Save";
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmKHQRPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(445, 538);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKHQRPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKHQRPayment";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalRiel;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDollar;
        private Guna.UI2.WinForms.Guna2TextBox txtTax;
        private Guna.UI2.WinForms.Guna2TextBox txtSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContainerControl pnlPayment;
        private Guna.UI2.WinForms.Guna2Button btnKHR;
        private Guna.UI2.WinForms.Guna2Button btnUSD;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}