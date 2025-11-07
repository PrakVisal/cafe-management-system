namespace RMS_Project
{
    partial class UC_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Item));
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnUC_Item = new Guna.UI2.WinForms.Guna2Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.ptrImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ContainerControl1.BorderRadius = 10;
            this.guna2ContainerControl1.Controls.Add(this.btnUC_Item);
            this.guna2ContainerControl1.Controls.Add(this.label2);
            this.guna2ContainerControl1.Controls.Add(this.lblDescription);
            this.guna2ContainerControl1.Controls.Add(this.lblPrice);
            this.guna2ContainerControl1.Controls.Add(this.lblItemName);
            this.guna2ContainerControl1.Controls.Add(this.ptrImage);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(300, 152);
            this.guna2ContainerControl1.TabIndex = 2;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // btnUC_Item
            // 
            this.btnUC_Item.Animated = true;
            this.btnUC_Item.BorderRadius = 10;
            this.btnUC_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUC_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUC_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUC_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUC_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUC_Item.FillColor = System.Drawing.Color.Transparent;
            this.btnUC_Item.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUC_Item.ForeColor = System.Drawing.Color.White;
            this.btnUC_Item.Location = new System.Drawing.Point(0, 0);
            this.btnUC_Item.Name = "btnUC_Item";
            this.btnUC_Item.PressedColor = System.Drawing.Color.Transparent;
            this.btnUC_Item.PressedDepth = 1;
            this.btnUC_Item.Size = new System.Drawing.Size(300, 152);
            this.btnUC_Item.TabIndex = 4;
            this.btnUC_Item.UseTransparentBackground = true;
            this.btnUC_Item.Click += new System.EventHandler(this.btnUC_Item_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(115, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(180, 68);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(33, 107);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 29);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "50.50";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.White;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(114, 7);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(110, 24);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "Item Name";
            // 
            // guna2PictureBox1
            // 
            this.ptrImage.BorderRadius = 10;
            this.ptrImage.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.ptrImage.ImageRotate = 0F;
            this.ptrImage.Location = new System.Drawing.Point(13, 15);
            this.ptrImage.Name = "guna2PictureBox1";
            this.ptrImage.Size = new System.Drawing.Size(85, 79);
            this.ptrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrImage.TabIndex = 0;
            this.ptrImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(300, 152);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemName;
        private Guna.UI2.WinForms.Guna2PictureBox ptrImage;
        private Guna.UI2.WinForms.Guna2Button btnUC_Item;
        private System.Windows.Forms.Label label2;
    }
}
