namespace Farmlink
{
    partial class order_details
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
            this.SuspendLayout();
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.ForeColor = System.Drawing.Color.White;
            this.pname.Location = new System.Drawing.Point(30, 22);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(66, 24);
            this.pname.TabIndex = 0;
            this.pname.Text = "label1";
            this.pname.Click += new System.EventHandler(this.label1_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(40, 56);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 16);
            this.price.TabIndex = 1;
            this.price.Text = "label1";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(40, 85);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(44, 16);
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
            this.remove.Location = new System.Drawing.Point(363, 22);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(86, 25);
            this.remove.TabIndex = 9;
            this.remove.TabStop = true;
            this.remove.Text = "Remove";
            this.remove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.remove_LinkClicked);
            // 
            // order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.remove);
            this.Controls.Add(this.total);
            this.Controls.Add(this.price);
            this.Controls.Add(this.pname);
            this.Name = "order_details";
            this.Size = new System.Drawing.Size(486, 123);
            this.Load += new System.EventHandler(this.order_details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.LinkLabel remove;
    }
}
