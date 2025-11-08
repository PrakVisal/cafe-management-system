namespace RMS_Project
{
    partial class UC_Total
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblAllTime = new System.Windows.Forms.Label();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 30;
            this.guna2ContainerControl1.Controls.Add(this.lblAllTime);
            this.guna2ContainerControl1.Controls.Add(this.lblValue);
            this.guna2ContainerControl1.Controls.Add(this.lblTitle);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(14, 7);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.guna2ContainerControl1.Size = new System.Drawing.Size(384, 159);
            this.guna2ContainerControl1.TabIndex = 0;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("League Spartan", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Total Order";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Font = new System.Drawing.Font("League Spartan", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.DimGray;
            this.lblValue.Location = new System.Drawing.Point(31, 78);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(53, 33);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "24";
            // 
            // lblAllTime
            // 
            this.lblAllTime.AutoSize = true;
            this.lblAllTime.BackColor = System.Drawing.Color.Transparent;
            this.lblAllTime.Font = new System.Drawing.Font("League Spartan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblAllTime.Location = new System.Drawing.Point(101, 130);
            this.lblAllTime.Name = "lblAllTime";
            this.lblAllTime.Size = new System.Drawing.Size(76, 20);
            this.lblAllTime.TabIndex = 0;
            this.lblAllTime.Text = "All Time";
            // 
            // UC_Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "UC_Total";
            this.Size = new System.Drawing.Size(410, 169);
            //this.Load += new System.EventHandler(this.UC_Total_Load);
            

            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        public System.Windows.Forms.Label lblAllTime;
        public System.Windows.Forms.Label lblValue;
        public System.Windows.Forms.Label lblTitle;
    }
}
