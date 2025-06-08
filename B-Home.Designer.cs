namespace Farmlink
{
    partial class B_Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderbtn = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.cartbtn = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.display_product = new System.Windows.Forms.FlowLayoutPanel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.bpanel = new System.Windows.Forms.Panel();
            this.paymentbtn = new System.Windows.Forms.Button();
            this.totalamount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.orderbtn);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.cartbtn);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 729);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.orderbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.orderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.ForeColor = System.Drawing.Color.White;
            this.orderbtn.Image = global::Farmlink.Properties.Resources.booking;
            this.orderbtn.Location = new System.Drawing.Point(0, 437);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(190, 45);
            this.orderbtn.TabIndex = 20;
            this.orderbtn.Text = "Order";
            this.orderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.logout.Cursor = System.Windows.Forms.Cursors.Default;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Image = global::Farmlink.Properties.Resources.logout__1_;
            this.logout.Location = new System.Drawing.Point(0, 650);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(190, 44);
            this.logout.TabIndex = 19;
            this.logout.Text = " Logout";
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.button3_Click);
            // 
            // cartbtn
            // 
            this.cartbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.cartbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cartbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.cartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartbtn.ForeColor = System.Drawing.Color.White;
            this.cartbtn.Image = global::Farmlink.Properties.Resources.grocery_store;
            this.cartbtn.Location = new System.Drawing.Point(0, 376);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(190, 44);
            this.cartbtn.TabIndex = 18;
            this.cartbtn.Text = " Cart";
            this.cartbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cartbtn.UseVisualStyleBackColor = false;
            this.cartbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.home.Cursor = System.Windows.Forms.Cursors.Default;
            this.home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = global::Farmlink.Properties.Resources.home;
            this.home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.home.Location = new System.Drawing.Point(0, 304);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(190, 52);
            this.home.TabIndex = 17;
            this.home.Text = "Home";
            this.home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // id
            // 
            this.id.AllowDrop = true;
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.id.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.id.Location = new System.Drawing.Point(3, 232);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(64, 25);
            this.id.TabIndex = 8;
            this.id.TabStop = true;
            this.id.Text = "name";
            this.id.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 42);
            this.label6.TabIndex = 15;
            this.label6.Text = "FarmLink";
            // 
            // display_product
            // 
            this.display_product.AutoScroll = true;
            this.display_product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.display_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.display_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.display_product.Location = new System.Drawing.Point(228, 86);
            this.display_product.Name = "display_product";
            this.display_product.Size = new System.Drawing.Size(1167, 640);
            this.display_product.TabIndex = 22;
            this.display_product.Paint += new System.Windows.Forms.PaintEventHandler(this.display_product_Paint_2);
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
            this.searchbtn.Location = new System.Drawing.Point(303, 48);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(300, 3, 3, 3);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(32, 32);
            this.searchbtn.TabIndex = 28;
            this.searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // searchbox
            // 
            this.searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.searchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Location = new System.Drawing.Point(37, 46);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(258, 35);
            this.searchbox.TabIndex = 24;
            this.searchbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bpanel
            // 
            this.bpanel.BackgroundImage = global::Farmlink.Properties.Resources.background;
            this.bpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bpanel.Controls.Add(this.paymentbtn);
            this.bpanel.Controls.Add(this.totalamount);
            this.bpanel.Controls.Add(this.searchbtn);
            this.bpanel.Controls.Add(this.searchbox);
            this.bpanel.Location = new System.Drawing.Point(191, 0);
            this.bpanel.Name = "bpanel";
            this.bpanel.Size = new System.Drawing.Size(1164, 729);
            this.bpanel.TabIndex = 28;
            this.bpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bpanel_Paint_1);
            // 
            // paymentbtn
            // 
            this.paymentbtn.AutoSize = true;
            this.paymentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.paymentbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.paymentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.paymentbtn.Location = new System.Drawing.Point(951, 39);
            this.paymentbtn.Name = "paymentbtn";
            this.paymentbtn.Size = new System.Drawing.Size(167, 42);
            this.paymentbtn.TabIndex = 30;
            this.paymentbtn.Text = "Make Payment";
            this.paymentbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.paymentbtn.UseVisualStyleBackColor = false;
            this.paymentbtn.Click += new System.EventHandler(this.paymentbtn_Click);
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount.ForeColor = System.Drawing.Color.White;
            this.totalamount.Location = new System.Drawing.Point(590, 49);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(228, 28);
            this.totalamount.TabIndex = 29;
            this.totalamount.Text = "total payble amount";
            // 
            // B_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.display_product);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bpanel);
            this.Name = "B_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B_Home";
            this.Load += new System.EventHandler(this.B_Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bpanel.ResumeLayout(false);
            this.bpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel id;
        public System.Windows.Forms.Button home;
        public System.Windows.Forms.Button cartbtn;
        public System.Windows.Forms.Button logout;
        public System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel display_product;
        private System.Windows.Forms.TextBox searchbox;
        public System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Panel bpanel;
        private System.Windows.Forms.Label totalamount;
        public System.Windows.Forms.Button paymentbtn;
    }
}