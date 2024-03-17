namespace RMS_Project
{
    partial class UC_Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Users));
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnUC_User = new Guna.UI2.WinForms.Guna2Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.ptrUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 10;
            this.guna2ContainerControl1.Controls.Add(this.btnUC_User);
            this.guna2ContainerControl1.Controls.Add(this.lblStatus);
            this.guna2ContainerControl1.Controls.Add(this.lblUsername);
            this.guna2ContainerControl1.Controls.Add(this.ptrUserImage);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2ContainerControl1.Size = new System.Drawing.Size(228, 274);
            this.guna2ContainerControl1.TabIndex = 0;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // btnUC_User
            // 
            this.btnUC_User.Animated = true;
            this.btnUC_User.BorderRadius = 10;
            this.btnUC_User.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUC_User.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUC_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUC_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUC_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUC_User.FillColor = System.Drawing.Color.Transparent;
            this.btnUC_User.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUC_User.ForeColor = System.Drawing.Color.White;
            this.btnUC_User.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnUC_User.Location = new System.Drawing.Point(0, 0);
            this.btnUC_User.Name = "btnUC_User";
            this.btnUC_User.PressedColor = System.Drawing.Color.Transparent;
            this.btnUC_User.PressedDepth = 0;
            this.btnUC_User.Size = new System.Drawing.Size(228, 274);
            this.btnUC_User.TabIndex = 6;
            this.btnUC_User.UseTransparentBackground = true;
            this.btnUC_User.Click += new System.EventHandler(this.btnUC_User_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatus.Location = new System.Drawing.Point(48, 227);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 34);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUsername.Location = new System.Drawing.Point(14, 154);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 73);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ptrUserImage
            // 
            this.ptrUserImage.Image = ((System.Drawing.Image)(resources.GetObject("ptrUserImage.Image")));
            this.ptrUserImage.ImageRotate = 0F;
            this.ptrUserImage.Location = new System.Drawing.Point(48, 14);
            this.ptrUserImage.Name = "ptrUserImage";
            this.ptrUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptrUserImage.Size = new System.Drawing.Size(130, 130);
            this.ptrUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrUserImage.TabIndex = 2;
            this.ptrUserImage.TabStop = false;
            this.ptrUserImage.UseTransparentBackground = true;
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(228, 274);
            this.guna2ContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptrUserImage;
        private Guna.UI2.WinForms.Guna2Button btnUC_User;
    }
}
