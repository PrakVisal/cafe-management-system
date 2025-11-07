namespace RMS_Project
{
    partial class UC_BillingItem
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
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.guna2ContainerControl1.BorderRadius = 6;
            this.guna2ContainerControl1.Controls.Add(this.lblItemName);
            this.guna2ContainerControl1.Controls.Add(this.lblUnitPrice);
            this.guna2ContainerControl1.Controls.Add(this.lblTotalPrice);
            this.guna2ContainerControl1.Controls.Add(this.lblQty);
            this.guna2ContainerControl1.Controls.Add(this.lblNo);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(910, 68);
            this.guna2ContainerControl1.TabIndex = 0;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("!Khmer OS Siemreap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(128, 12);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(291, 35);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "សាច់ចង្កាក់";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Location = new System.Drawing.Point(579, 16);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(150, 25);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "$1.50";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(746, 16);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(150, 25);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "$4.50";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Black;
            this.lblQty.Location = new System.Drawing.Point(455, 16);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(80, 25);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "3";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.lblQty.TextChanged += new System.EventHandler(this.lblQty_TextChanged);
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.Black;
            this.lblNo.Location = new System.Drawing.Point(3, 15);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNo.Size = new System.Drawing.Size(71, 25);
            this.lblNo.TabIndex = 6;
            this.lblNo.Text = "1111";
            // 
            // UC_BillingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "UC_BillingItem";
            this.Size = new System.Drawing.Size(910, 68);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        public System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblTotalPrice;
        public System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblNo;
        public System.Windows.Forms.Label lblUnitPrice;
    }
}
