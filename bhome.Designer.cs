namespace Farmlink
{
    partial class bhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bhome));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.userinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmlinkDataSet = new Farmlink.FarmlinkDataSet();
            this.userinfoTableAdapter = new Farmlink.FarmlinkDataSetTableAdapters.userinfoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addcart = new System.Windows.Forms.Button();
            this.increment = new System.Windows.Forms.Button();
            this.abouttext = new System.Windows.Forms.Label();
            this.decrement = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.Label();
            this.avelibility = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(59, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.AutoSize = true;
            this.searchbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Image = global::Farmlink.Properties.Resources.transparency;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchbtn.Location = new System.Drawing.Point(309, 36);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(32, 32);
            this.searchbtn.TabIndex = 19;
            this.searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // userinfoBindingSource
            // 
            this.userinfoBindingSource.DataMember = "userinfo";
            this.userinfoBindingSource.DataSource = this.farmlinkDataSet;
            // 
            // farmlinkDataSet
            // 
            this.farmlinkDataSet.DataSetName = "FarmlinkDataSet";
            this.farmlinkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userinfoTableAdapter
            // 
            this.userinfoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.avelibility);
            this.panel1.Controls.Add(this.pname);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.decrement);
            this.panel1.Controls.Add(this.abouttext);
            this.panel1.Controls.Add(this.increment);
            this.panel1.Controls.Add(this.addcart);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(59, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 403);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addcart
            // 
            this.addcart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.addcart.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcart.Location = new System.Drawing.Point(899, 326);
            this.addcart.Name = "addcart";
            this.addcart.Size = new System.Drawing.Size(93, 36);
            this.addcart.TabIndex = 1;
            this.addcart.Text = "Add to cart";
            this.addcart.UseVisualStyleBackColor = true;
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
            this.amount.Location = new System.Drawing.Point(662, 338);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(91, 28);
            this.amount.TabIndex = 12;
            this.amount.Text = "amount";
            this.amount.Click += new System.EventHandler(this.label1_Click);
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
            this.pname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // avelibility
            // 
            this.avelibility.AutoSize = true;
            this.avelibility.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avelibility.Location = new System.Drawing.Point(123, 326);
            this.avelibility.Name = "avelibility";
            this.avelibility.Size = new System.Drawing.Size(22, 28);
            this.avelibility.TabIndex = 14;
            this.avelibility.Text = "\\";
            // 
            // bhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::Farmlink.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "bhome";
            this.Size = new System.Drawing.Size(1165, 729);
            this.Load += new System.EventHandler(this.bhome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.BindingSource userinfoBindingSource;
        private FarmlinkDataSet farmlinkDataSet;
        private FarmlinkDataSetTableAdapters.userinfoTableAdapter userinfoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addcart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Label abouttext;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Button decrement;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label avelibility;
    }
}
