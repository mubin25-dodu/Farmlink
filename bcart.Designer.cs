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
            this.price_l = new System.Windows.Forms.Label();
            this.decrement = new System.Windows.Forms.Button();
            this.selected = new System.Windows.Forms.Label();
            this.increment = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.avelibility = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pname = new System.Windows.Forms.Label();
            this.abouttext = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // price_l
            // 
            this.price_l.AutoSize = true;
            this.price_l.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_l.Location = new System.Drawing.Point(19, 350);
            this.price_l.Name = "price_l";
            this.price_l.Size = new System.Drawing.Size(46, 20);
            this.price_l.TabIndex = 26;
            this.price_l.Text = "price";
            // 
            // decrement
            // 
            this.decrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.decrement.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrement.Location = new System.Drawing.Point(271, 425);
            this.decrement.Name = "decrement";
            this.decrement.Size = new System.Drawing.Size(49, 24);
            this.decrement.TabIndex = 21;
            this.decrement.Text = "-1";
            this.decrement.UseVisualStyleBackColor = true;
            this.decrement.Click += new System.EventHandler(this.decrement_Click_1);
            // 
            // selected
            // 
            this.selected.AutoSize = true;
            this.selected.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected.Location = new System.Drawing.Point(22, 421);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(65, 25);
            this.selected.TabIndex = 25;
            this.selected.Text = "select";
            // 
            // increment
            // 
            this.increment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.increment.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment.Location = new System.Drawing.Point(216, 425);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(49, 24);
            this.increment.TabIndex = 19;
            this.increment.Text = "+1";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(18, 387);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(84, 25);
            this.amount.TabIndex = 22;
            this.amount.Text = "amount";
            // 
            // avelibility
            // 
            this.avelibility.AutoSize = true;
            this.avelibility.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avelibility.Location = new System.Drawing.Point(212, 269);
            this.avelibility.Name = "avelibility";
            this.avelibility.Size = new System.Drawing.Size(78, 20);
            this.avelibility.TabIndex = 24;
            this.avelibility.Text = "avelibility";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(342, 260);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(9, 261);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(162, 28);
            this.pname.TabIndex = 23;
            this.pname.Text = "product name";
            // 
            // abouttext
            // 
            this.abouttext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.abouttext.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abouttext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.abouttext.Location = new System.Drawing.Point(23, 289);
            this.abouttext.Name = "abouttext";
            this.abouttext.Size = new System.Drawing.Size(270, 49);
            this.abouttext.TabIndex = 20;
            this.abouttext.Text = "description";
            this.abouttext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abouttext.Click += new System.EventHandler(this.abouttext_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(219, 402);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(101, 17);
            this.checkBox.TabIndex = 27;
            this.checkBox.Text = "Add to Payment";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // bcart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.price_l);
            this.Controls.Add(this.decrement);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.avelibility);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.abouttext);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "bcart";
            this.Size = new System.Drawing.Size(341, 452);
            this.Load += new System.EventHandler(this.bcart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label price_l;
        private System.Windows.Forms.Button decrement;
        private System.Windows.Forms.Label selected;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label avelibility;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label abouttext;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
