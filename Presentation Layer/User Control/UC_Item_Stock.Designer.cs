namespace RMS_Project
{
    partial class UC_Item_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Item_Stock));
            this.btnUC_Item = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnUCItems = new Guna.UI2.WinForms.Guna2Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.ptrImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUC_Item
            // 
            this.btnUC_Item.Animated = true;
            this.btnUC_Item.BackColor = System.Drawing.Color.Transparent;
            this.btnUC_Item.BorderRadius = 10;
            this.btnUC_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUC_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUC_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUC_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUC_Item.FillColor = System.Drawing.Color.Transparent;
            this.btnUC_Item.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUC_Item.ForeColor = System.Drawing.Color.White;
            this.btnUC_Item.Location = new System.Drawing.Point(281, 0);
            this.btnUC_Item.Name = "btnUC_Item";
            this.btnUC_Item.PressedColor = System.Drawing.Color.Transparent;
            this.btnUC_Item.PressedDepth = 1;
            this.btnUC_Item.Size = new System.Drawing.Size(300, 152);
            this.btnUC_Item.TabIndex = 8;
            this.btnUC_Item.UseTransparentBackground = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderRadius = 10;
            this.pnlContainer.Controls.Add(this.btnUCItems);
            this.pnlContainer.Controls.Add(this.lblQty);
            this.pnlContainer.Controls.Add(this.lblItemName);
            this.pnlContainer.Controls.Add(this.ptrImage);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(291, 117);
            this.pnlContainer.TabIndex = 9;
            this.pnlContainer.Text = "guna2ContainerControl1";
            // 
            // btnUCItems
            // 
            this.btnUCItems.Animated = true;
            this.btnUCItems.BackColor = System.Drawing.Color.Transparent;
            this.btnUCItems.BorderRadius = 10;
            this.btnUCItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUCItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUCItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUCItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUCItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUCItems.FillColor = System.Drawing.Color.Transparent;
            this.btnUCItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUCItems.ForeColor = System.Drawing.Color.White;
            this.btnUCItems.Location = new System.Drawing.Point(0, 0);
            this.btnUCItems.Name = "btnUCItems";
            this.btnUCItems.PressedColor = System.Drawing.Color.Transparent;
            this.btnUCItems.PressedDepth = 1;
            this.btnUCItems.Size = new System.Drawing.Size(291, 117);
            this.btnUCItems.TabIndex = 13;
            this.btnUCItems.UseTransparentBackground = true;
            this.btnUCItems.Click += new System.EventHandler(this.btnUCItems_Click_1);
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Black;
            this.lblQty.Location = new System.Drawing.Point(181, 72);
            this.lblQty.Name = "lblQty";
            this.lblQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQty.Size = new System.Drawing.Size(94, 33);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "60";
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.White;
            this.lblItemName.Font = new System.Drawing.Font("!Khmer OS Siemreap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(99, 8);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(176, 64);
            this.lblItemName.TabIndex = 9;
            this.lblItemName.Text = "Item Name";
            // 
            // ptrImage
            // 
            this.ptrImage.BorderRadius = 10;
            this.ptrImage.Image = ((System.Drawing.Image)(resources.GetObject("ptrImage.Image")));
            this.ptrImage.ImageRotate = 0F;
            this.ptrImage.Location = new System.Drawing.Point(8, 14);
            this.ptrImage.Name = "ptrImage";
            this.ptrImage.Size = new System.Drawing.Size(85, 79);
            this.ptrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrImage.TabIndex = 8;
            this.ptrImage.TabStop = false;
            // 
            // UC_Item_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnUC_Item);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "UC_Item_Stock";
            this.Size = new System.Drawing.Size(291, 117);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnUC_Item;
        private Guna.UI2.WinForms.Guna2ContainerControl pnlContainer;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblItemName;
        private Guna.UI2.WinForms.Guna2PictureBox ptrImage;
        private Guna.UI2.WinForms.Guna2Button btnUCItems;
    }
}
