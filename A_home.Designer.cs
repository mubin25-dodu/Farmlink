namespace Farmlink
{
    partial class A_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpanel = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.manage = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Button();
            this.orderbtn = new System.Windows.Forms.Button();
            this.propic = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.apanel = new System.Windows.Forms.Panel();
            this.tablepanel = new System.Windows.Forms.Panel();
            this.agentcount = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.agenttable = new System.Windows.Forms.DataGridView();
            this.agent_section = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.btnpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propic)).BeginInit();
            this.apanel.SuspendLayout();
            this.tablepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenttable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.btnpanel);
            this.panel1.Controls.Add(this.propic);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 729);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnpanel
            // 
            this.btnpanel.Controls.Add(this.home);
            this.btnpanel.Controls.Add(this.manage);
            this.btnpanel.Controls.Add(this.payment);
            this.btnpanel.Controls.Add(this.orderbtn);
            this.btnpanel.Location = new System.Drawing.Point(3, 231);
            this.btnpanel.Name = "btnpanel";
            this.btnpanel.Size = new System.Drawing.Size(195, 254);
            this.btnpanel.TabIndex = 23;
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.home.Cursor = System.Windows.Forms.Cursors.Default;
            this.home.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = global::Farmlink.Properties.Resources.home;
            this.home.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.home.Location = new System.Drawing.Point(0, 68);
            this.home.Margin = new System.Windows.Forms.Padding(10);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(195, 52);
            this.home.TabIndex = 17;
            this.home.Text = "Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // manage
            // 
            this.manage.AutoSize = true;
            this.manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.manage.Cursor = System.Windows.Forms.Cursors.Default;
            this.manage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage.ForeColor = System.Drawing.Color.White;
            this.manage.Image = global::Farmlink.Properties.Resources.user;
            this.manage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manage.Location = new System.Drawing.Point(0, 120);
            this.manage.Margin = new System.Windows.Forms.Padding(10);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(195, 44);
            this.manage.TabIndex = 18;
            this.manage.Text = "Manage Users";
            this.manage.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manage.UseVisualStyleBackColor = false;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.payment.Cursor = System.Windows.Forms.Cursors.Default;
            this.payment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.payment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payment.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.Color.White;
            this.payment.Image = global::Farmlink.Properties.Resources.booking;
            this.payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payment.Location = new System.Drawing.Point(0, 164);
            this.payment.Margin = new System.Windows.Forms.Padding(10);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(195, 45);
            this.payment.TabIndex = 21;
            this.payment.Text = "Payments";
            this.payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payment.UseVisualStyleBackColor = false;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // orderbtn
            // 
            this.orderbtn.AutoSize = true;
            this.orderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.orderbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.orderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.ForeColor = System.Drawing.Color.White;
            this.orderbtn.Image = global::Farmlink.Properties.Resources.booking;
            this.orderbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderbtn.Location = new System.Drawing.Point(0, 209);
            this.orderbtn.Margin = new System.Windows.Forms.Padding(10);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(195, 45);
            this.orderbtn.TabIndex = 20;
            this.orderbtn.Text = "Order";
            this.orderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // propic
            // 
            this.propic.Location = new System.Drawing.Point(19, 87);
            this.propic.Name = "propic";
            this.propic.Size = new System.Drawing.Size(142, 110);
            this.propic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.propic.TabIndex = 22;
            this.propic.TabStop = false;
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
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.name.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.name.Location = new System.Drawing.Point(23, 200);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(83, 28);
            this.name.TabIndex = 8;
            this.name.TabStop = true;
            this.name.Text = "user id";
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
            // apanel
            // 
            this.apanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.apanel.BackgroundImage = global::Farmlink.Properties.Resources.background;
            this.apanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apanel.Controls.Add(this.tablepanel);
            this.apanel.Controls.Add(this.agent_section);
            this.apanel.ForeColor = System.Drawing.SystemColors.Control;
            this.apanel.Location = new System.Drawing.Point(185, 0);
            this.apanel.Name = "apanel";
            this.apanel.Size = new System.Drawing.Size(1165, 729);
            this.apanel.TabIndex = 5;
            this.apanel.Paint += new System.Windows.Forms.PaintEventHandler(this.apanel_Paint);
            // 
            // tablepanel
            // 
            this.tablepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablepanel.Controls.Add(this.agentcount);
            this.tablepanel.Controls.Add(this.backbtn);
            this.tablepanel.Controls.Add(this.agenttable);
            this.tablepanel.Location = new System.Drawing.Point(90, 64);
            this.tablepanel.Name = "tablepanel";
            this.tablepanel.Size = new System.Drawing.Size(968, 558);
            this.tablepanel.TabIndex = 67;
            // 
            // agentcount
            // 
            this.agentcount.AutoSize = true;
            this.agentcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.agentcount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentcount.ForeColor = System.Drawing.Color.OrangeRed;
            this.agentcount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.agentcount.Location = new System.Drawing.Point(164, 17);
            this.agentcount.Name = "agentcount";
            this.agentcount.Size = new System.Drawing.Size(54, 21);
            this.agentcount.TabIndex = 49;
            this.agentcount.Text = "count";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backbtn.Location = new System.Drawing.Point(17, 3);
            this.backbtn.Name = "backbtn";
            this.backbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backbtn.Size = new System.Drawing.Size(50, 49);
            this.backbtn.TabIndex = 48;
            this.backbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // agenttable
            // 
            this.agenttable.AllowUserToAddRows = false;
            this.agenttable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.agenttable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.agenttable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agenttable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.agenttable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.agenttable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agenttable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.agenttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agenttable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.agenttable.DefaultCellStyle = dataGridViewCellStyle3;
            this.agenttable.Location = new System.Drawing.Point(3, 57);
            this.agenttable.MultiSelect = false;
            this.agenttable.Name = "agenttable";
            this.agenttable.ReadOnly = true;
            this.agenttable.RowHeadersVisible = false;
            this.agenttable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agenttable.Size = new System.Drawing.Size(962, 476);
            this.agenttable.TabIndex = 30;
            this.agenttable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.agenttable_CellContentClick);
            // 
            // agent_section
            // 
            this.agent_section.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.agent_section.Cursor = System.Windows.Forms.Cursors.Default;
            this.agent_section.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agent_section.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent_section.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.agent_section.Location = new System.Drawing.Point(137, 64);
            this.agent_section.Name = "agent_section";
            this.agent_section.Padding = new System.Windows.Forms.Padding(0, 0, 0, 120);
            this.agent_section.Size = new System.Drawing.Size(237, 213);
            this.agent_section.TabIndex = 65;
            this.agent_section.Text = "Approved Agents";
            this.agent_section.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agent_section.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.agent_section.UseVisualStyleBackColor = false;
            this.agent_section.Click += new System.EventHandler(this.agent_section_Click);
            // 
            // A_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.apanel);
            this.Name = "A_home";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.A_home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btnpanel.ResumeLayout(false);
            this.btnpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propic)).EndInit();
            this.apanel.ResumeLayout(false);
            this.tablepanel.ResumeLayout(false);
            this.tablepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenttable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox propic;
        public System.Windows.Forms.Button payment;
        public System.Windows.Forms.Button orderbtn;
        public System.Windows.Forms.Button logout;
        public System.Windows.Forms.Button manage;
        public System.Windows.Forms.Button home;
        private System.Windows.Forms.LinkLabel name;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button agent_section;
        public System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView agenttable;
        private System.Windows.Forms.Label agentcount;
        private System.Windows.Forms.Panel tablepanel;
        private System.Windows.Forms.Panel apanel;
        private System.Windows.Forms.Panel btnpanel;
    }
}