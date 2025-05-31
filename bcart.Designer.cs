namespace Farmlink
{
    partial class bcart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bcart));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.increment = new System.Windows.Forms.Button();
            this.abouttext = new System.Windows.Forms.Label();
            this.decrement = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.pay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // increment
            // 
            this.increment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.increment.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment.Location = new System.Drawing.Point(789, 338);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(49, 24);
            this.increment.TabIndex = 2;
            this.increment.Text = "+1";
            this.increment.UseVisualStyleBackColor = true;
            // 
            // abouttext
            // 
            this.abouttext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.abouttext.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abouttext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.abouttext.Location = new System.Drawing.Point(397, 17);
            this.abouttext.Name = "abouttext";
            this.abouttext.Size = new System.Drawing.Size(577, 254);
            this.abouttext.TabIndex = 10;
            this.abouttext.Text = resources.GetString("abouttext.Text");
            this.abouttext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // decrement
            // 
            this.decrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.decrement.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrement.Location = new System.Drawing.Point(844, 338);
            this.decrement.Name = "decrement";
            this.decrement.Size = new System.Drawing.Size(49, 24);
            this.decrement.TabIndex = 11;
            this.decrement.Text = "-1";
            this.decrement.UseVisualStyleBackColor = true;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(910, 332);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(91, 28);
            this.amount.TabIndex = 12;
            this.amount.Text = "amount";
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(83, 274);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(162, 28);
            this.pname.TabIndex = 13;
            this.pname.Text = "product name";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Snow;
            this.total.Location = new System.Drawing.Point(761, 126);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(78, 28);
            this.total.TabIndex = 14;
            this.total.Text = "Total :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.pname);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.decrement);
            this.panel1.Controls.Add(this.abouttext);
            this.panel1.Controls.Add(this.increment);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(69, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 403);
            this.panel1.TabIndex = 23;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(18, 363);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 15;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.pay.Cursor = System.Windows.Forms.Cursors.Default;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.pay.Location = new System.Drawing.Point(918, 113);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(177, 41);
            this.pay.TabIndex = 24;
            this.pay.Text = "Make payment";
            this.pay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pay.UseVisualStyleBackColor = false;
            // 
            // bcart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::Farmlink.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pay);
            this.Controls.Add(this.total);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "bcart";
            this.Size = new System.Drawing.Size(1165, 729);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Label abouttext;
        private System.Windows.Forms.Button decrement;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox;
        public System.Windows.Forms.Button pay;
    }
}
