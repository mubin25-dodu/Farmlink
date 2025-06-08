namespace Farmlink
{
    partial class Buyer_payment
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
            this.orderdetails1 = new Farmlink.orderdetails();
            this.SuspendLayout();
            // 
            // orderdetails1
            // 
            this.orderdetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.orderdetails1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderdetails1.Location = new System.Drawing.Point(3, 203);
            this.orderdetails1.Name = "orderdetails1";
            this.orderdetails1.Size = new System.Drawing.Size(437, 90);
            this.orderdetails1.TabIndex = 0;
            this.orderdetails1.Load += new System.EventHandler(this.orderdetails1_Load);
            // 
            // Buyer_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::Farmlink.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.orderdetails1);
            this.Name = "Buyer_payment";
            this.Size = new System.Drawing.Size(1165, 729);
            this.Load += new System.EventHandler(this.Buyer_payment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private orderdetails orderdetails1;
    }
}
