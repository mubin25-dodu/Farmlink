namespace Farmlink
{
    partial class orderdetails
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
            this.pname = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.LinkLabel();
            this.cart = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.ForeColor = System.Drawing.Color.White;
            this.pname.Location = new System.Drawing.Point(28, 13);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(57, 20);
            this.pname.TabIndex = 0;
            this.pname.Text = "label1";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(40, 33);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(45, 19);
            this.price.TabIndex = 1;
            this.price.Text = "label1";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(40, 52);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(45, 19);
            this.total.TabIndex = 2;
            this.total.Text = "label1";
            // 
            // remove
            // 
            this.remove.AllowDrop = true;
            this.remove.AutoSize = true;
            this.remove.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.remove.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.remove.Location = new System.Drawing.Point(315, 13);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(86, 25);
            this.remove.TabIndex = 10;
            this.remove.TabStop = true;
            this.remove.Text = "Remove";
            // 
            // cart
            // 
            this.cart.AllowDrop = true;
            this.cart.AutoSize = true;
            this.cart.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.cart.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.cart.Location = new System.Drawing.Point(271, 46);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(130, 25);
            this.cart.TabIndex = 11;
            this.cart.TabStop = true;
            this.cart.Text = "Add to Cart!!";
            // 
            // orderdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.cart);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.total);
            this.Controls.Add(this.price);
            this.Controls.Add(this.pname);
            this.Name = "orderdetails";
            this.Size = new System.Drawing.Size(437, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.LinkLabel remove;
        private System.Windows.Forms.LinkLabel cart;
    }
}
