namespace RMS_Project.Presentation_Layer.UI
{
    partial class frmCashPayment
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
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.txtRielAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUSDAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2ContainerControl3 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtChangeRiel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtChangeDollar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlTitle.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            this.guna2ContainerControl2.SuspendLayout();
            this.guna2ContainerControl3.SuspendLayout();
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
            this.pnlTitle.TabIndex = 3;
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
            this.lblTitle.Size = new System.Drawing.Size(228, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment Summary";
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
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 97);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(445, 259);
            this.guna2ContainerControl1.TabIndex = 4;
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
            this.txtTotalRiel.Location = new System.Drawing.Point(198, 204);
            this.txtTotalRiel.Name = "txtTotalRiel";
            this.txtTotalRiel.PasswordChar = '\0';
            this.txtTotalRiel.PlaceholderText = "";
            this.txtTotalRiel.ReadOnly = true;
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
            this.txtTotalDollar.Location = new System.Drawing.Point(198, 162);
            this.txtTotalDollar.Name = "txtTotalDollar";
            this.txtTotalDollar.PasswordChar = '\0';
            this.txtTotalDollar.PlaceholderText = "";
            this.txtTotalDollar.ReadOnly = true;
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
            this.txtTax.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTax.Location = new System.Drawing.Point(198, 90);
            this.txtTax.Name = "txtTax";
            this.txtTax.PasswordChar = '\0';
            this.txtTax.PlaceholderText = "";
            this.txtTax.ReadOnly = true;
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
            this.txtSubTotal.ReadOnly = true;
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
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.Controls.Add(this.txtRielAmount);
            this.guna2ContainerControl2.Controls.Add(this.txtUSDAmount);
            this.guna2ContainerControl2.Controls.Add(this.label6);
            this.guna2ContainerControl2.Controls.Add(this.label9);
            this.guna2ContainerControl2.Controls.Add(this.label10);
            this.guna2ContainerControl2.Location = new System.Drawing.Point(0, 372);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(445, 157);
            this.guna2ContainerControl2.TabIndex = 5;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // txtRielAmount
            // 
            this.txtRielAmount.BorderColor = System.Drawing.Color.Gray;
            this.txtRielAmount.BorderRadius = 5;
            this.txtRielAmount.BorderThickness = 2;
            this.txtRielAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRielAmount.DefaultText = "";
            this.txtRielAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRielAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRielAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRielAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRielAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRielAmount.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtRielAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRielAmount.Location = new System.Drawing.Point(198, 90);
            this.txtRielAmount.Name = "txtRielAmount";
            this.txtRielAmount.PasswordChar = '\0';
            this.txtRielAmount.PlaceholderText = "";
            this.txtRielAmount.SelectedText = "";
            this.txtRielAmount.Size = new System.Drawing.Size(200, 36);
            this.txtRielAmount.TabIndex = 1;
            // 
            // txtUSDAmount
            // 
            this.txtUSDAmount.BorderColor = System.Drawing.Color.Gray;
            this.txtUSDAmount.BorderRadius = 5;
            this.txtUSDAmount.BorderThickness = 2;
            this.txtUSDAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUSDAmount.DefaultText = "";
            this.txtUSDAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUSDAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUSDAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUSDAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUSDAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUSDAmount.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtUSDAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUSDAmount.Location = new System.Drawing.Point(198, 48);
            this.txtUSDAmount.Name = "txtUSDAmount";
            this.txtUSDAmount.PasswordChar = '\0';
            this.txtUSDAmount.PlaceholderText = "";
            this.txtUSDAmount.SelectedText = "";
            this.txtUSDAmount.Size = new System.Drawing.Size(200, 36);
            this.txtUSDAmount.TabIndex = 1;
            this.txtUSDAmount.TextChanged += new System.EventHandler(this.txtUSDAmount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Riel Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "USD Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Recieve Cash";
            // 
            // guna2ContainerControl3
            // 
            this.guna2ContainerControl3.Controls.Add(this.btnSave);
            this.guna2ContainerControl3.Controls.Add(this.txtChangeRiel);
            this.guna2ContainerControl3.Controls.Add(this.txtChangeDollar);
            this.guna2ContainerControl3.Controls.Add(this.label7);
            this.guna2ContainerControl3.Controls.Add(this.label12);
            this.guna2ContainerControl3.Controls.Add(this.label13);
            this.guna2ContainerControl3.Location = new System.Drawing.Point(0, 546);
            this.guna2ContainerControl3.Name = "guna2ContainerControl3";
            this.guna2ContainerControl3.Size = new System.Drawing.Size(445, 257);
            this.guna2ContainerControl3.TabIndex = 7;
            this.guna2ContainerControl3.Text = "guna2ContainerControl3";
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
            this.btnSave.Location = new System.Drawing.Point(41, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(357, 55);
            this.btnSave.TabIndex = 8;
            this.btnSave.Tag = "Save";
            this.btnSave.Text = "Confirm";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtChangeRiel
            // 
            this.txtChangeRiel.BorderColor = System.Drawing.Color.Gray;
            this.txtChangeRiel.BorderRadius = 5;
            this.txtChangeRiel.BorderThickness = 2;
            this.txtChangeRiel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChangeRiel.DefaultText = "";
            this.txtChangeRiel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChangeRiel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChangeRiel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChangeRiel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChangeRiel.Enabled = false;
            this.txtChangeRiel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChangeRiel.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtChangeRiel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChangeRiel.Location = new System.Drawing.Point(198, 90);
            this.txtChangeRiel.Name = "txtChangeRiel";
            this.txtChangeRiel.PasswordChar = '\0';
            this.txtChangeRiel.PlaceholderText = "";
            this.txtChangeRiel.ReadOnly = true;
            this.txtChangeRiel.SelectedText = "";
            this.txtChangeRiel.Size = new System.Drawing.Size(200, 36);
            this.txtChangeRiel.TabIndex = 1;
            // 
            // txtChangeDollar
            // 
            this.txtChangeDollar.BorderColor = System.Drawing.Color.Gray;
            this.txtChangeDollar.BorderRadius = 5;
            this.txtChangeDollar.BorderThickness = 2;
            this.txtChangeDollar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChangeDollar.DefaultText = "";
            this.txtChangeDollar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChangeDollar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChangeDollar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChangeDollar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChangeDollar.Enabled = false;
            this.txtChangeDollar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChangeDollar.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtChangeDollar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChangeDollar.Location = new System.Drawing.Point(198, 48);
            this.txtChangeDollar.Name = "txtChangeDollar";
            this.txtChangeDollar.PasswordChar = '\0';
            this.txtChangeDollar.PlaceholderText = "";
            this.txtChangeDollar.ReadOnly = true;
            this.txtChangeDollar.SelectedText = "";
            this.txtChangeDollar.Size = new System.Drawing.Size(200, 36);
            this.txtChangeDollar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Change (៛)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Change ($)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Change";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlTitle;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // frmCashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(445, 801);
            this.Controls.Add(this.guna2ContainerControl3);
            this.Controls.Add(this.guna2ContainerControl2);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCashPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCashPayment";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.guna2ContainerControl2.ResumeLayout(false);
            this.guna2ContainerControl2.PerformLayout();
            this.guna2ContainerControl3.ResumeLayout(false);
            this.guna2ContainerControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
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
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtRielAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtUSDAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private Guna.UI2.WinForms.Guna2TextBox txtChangeRiel;
        private Guna.UI2.WinForms.Guna2TextBox txtChangeDollar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}