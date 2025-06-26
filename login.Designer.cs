namespace Farmlink
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.signinpanel = new System.Windows.Forms.Panel();
            this.getstarted = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.Button();
            this.hidepass = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forgotpanel = new System.Windows.Forms.Panel();
            this.phone = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.conpass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.passf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mailf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.signinpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.forgotpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signinpanel
            // 
            this.signinpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.signinpanel.Controls.Add(this.button2);
            this.signinpanel.Controls.Add(this.forgotpanel);
            this.signinpanel.Controls.Add(this.getstarted);
            this.signinpanel.Controls.Add(this.label1);
            this.signinpanel.Controls.Add(this.label2);
            this.signinpanel.Controls.Add(this.pictureBox1);
            this.signinpanel.Location = new System.Drawing.Point(-1, 0);
            this.signinpanel.Name = "signinpanel";
            this.signinpanel.Size = new System.Drawing.Size(682, 730);
            this.signinpanel.TabIndex = 0;
            this.signinpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // getstarted
            // 
            this.getstarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.getstarted.Cursor = System.Windows.Forms.Cursors.Default;
            this.getstarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getstarted.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getstarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.getstarted.Location = new System.Drawing.Point(223, 560);
            this.getstarted.Name = "getstarted";
            this.getstarted.Size = new System.Drawing.Size(177, 41);
            this.getstarted.TabIndex = 11;
            this.getstarted.Text = "Sign in";
            this.getstarted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.getstarted.UseVisualStyleBackColor = false;
            this.getstarted.Click += new System.EventHandler(this.getstarted_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(182, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don’t have an account !!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 70);
            this.label2.TabIndex = 5;
            this.label2.Text = "FarmLink";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.showpass);
            this.panel2.Controls.Add(this.forgot);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.hidepass);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Controls.Add(this.mail);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.email);
            this.panel2.Location = new System.Drawing.Point(679, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 730);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // forgot
            // 
            this.forgot.ActiveLinkColor = System.Drawing.Color.PowderBlue;
            this.forgot.AutoSize = true;
            this.forgot.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgot.LinkColor = System.Drawing.Color.Salmon;
            this.forgot.Location = new System.Drawing.Point(118, 450);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(158, 22);
            this.forgot.TabIndex = 14;
            this.forgot.TabStop = true;
            this.forgot.Text = "Forgot password?";
            this.forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(112, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.button1.Location = new System.Drawing.Point(222, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Login";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(117, 382);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(390, 34);
            this.pass.TabIndex = 8;
            this.pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.White;
            this.mail.Location = new System.Drawing.Point(117, 276);
            this.mail.Multiline = true;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(390, 38);
            this.mail.TabIndex = 7;
            this.mail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.password.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.password.Location = new System.Drawing.Point(117, 333);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(113, 28);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label4_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.email.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.email.Location = new System.Drawing.Point(112, 230);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(174, 28);
            this.email.TabIndex = 4;
            this.email.Text = "Enter your mail";
            // 
            // showpass
            // 
            this.showpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.showpass.Cursor = System.Windows.Forms.Cursors.Default;
            this.showpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpass.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.showpass.Image = global::Farmlink.Properties.Resources.cartoon_happy_eyes;
            this.showpass.Location = new System.Drawing.Point(461, 382);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(46, 34);
            this.showpass.TabIndex = 15;
            this.showpass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.Click += new System.EventHandler(this.showpass_Click);
            // 
            // hidepass
            // 
            this.hidepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.hidepass.Cursor = System.Windows.Forms.Cursors.Default;
            this.hidepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidepass.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.hidepass.Image = global::Farmlink.Properties.Resources.eyes;
            this.hidepass.Location = new System.Drawing.Point(461, 382);
            this.hidepass.Name = "hidepass";
            this.hidepass.Size = new System.Drawing.Size(46, 34);
            this.hidepass.TabIndex = 12;
            this.hidepass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hidepass.UseVisualStyleBackColor = false;
            this.hidepass.Click += new System.EventHandler(this.hidepass_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(49, 49);
            this.button2.TabIndex = 13;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Farmlink.Properties.Resources.Grow__Link__Thrive_;
            this.pictureBox1.Location = new System.Drawing.Point(175, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // forgotpanel
            // 
            this.forgotpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.forgotpanel.Controls.Add(this.phone);
            this.forgotpanel.Controls.Add(this.num);
            this.forgotpanel.Controls.Add(this.label10);
            this.forgotpanel.Controls.Add(this.role);
            this.forgotpanel.Controls.Add(this.conpass);
            this.forgotpanel.Controls.Add(this.label9);
            this.forgotpanel.Controls.Add(this.passf);
            this.forgotpanel.Controls.Add(this.label4);
            this.forgotpanel.Controls.Add(this.mailf);
            this.forgotpanel.Controls.Add(this.label6);
            this.forgotpanel.Controls.Add(this.fullname);
            this.forgotpanel.Controls.Add(this.button4);
            this.forgotpanel.Controls.Add(this.label7);
            this.forgotpanel.ForeColor = System.Drawing.Color.White;
            this.forgotpanel.Location = new System.Drawing.Point(-1, -1);
            this.forgotpanel.Name = "forgotpanel";
            this.forgotpanel.Size = new System.Drawing.Size(682, 730);
            this.forgotpanel.TabIndex = 15;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.phone.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.phone.Location = new System.Drawing.Point(121, 415);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(174, 28);
            this.phone.TabIndex = 27;
            this.phone.Text = "Phone Number";
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.num.Location = new System.Drawing.Point(126, 445);
            this.num.Multiline = true;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(390, 36);
            this.num.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(127, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Sign in as";
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.ForeColor = System.Drawing.Color.Turquoise;
            this.role.FormattingEnabled = true;
            this.role.IntegralHeight = false;
            this.role.Items.AddRange(new object[] {
            "Customer",
            "Seller",
            "Agent",
            "Admin"});
            this.role.Location = new System.Drawing.Point(126, 535);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(121, 27);
            this.role.TabIndex = 22;
            // 
            // conpass
            // 
            this.conpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.conpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conpass.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.conpass.Location = new System.Drawing.Point(126, 376);
            this.conpass.Multiline = true;
            this.conpass.Name = "conpass";
            this.conpass.Size = new System.Drawing.Size(390, 36);
            this.conpass.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(121, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Confirm Password";
            // 
            // passf
            // 
            this.passf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.passf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passf.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passf.Location = new System.Drawing.Point(126, 306);
            this.passf.Multiline = true;
            this.passf.Name = "passf";
            this.passf.Size = new System.Drawing.Size(390, 36);
            this.passf.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(121, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // mailf
            // 
            this.mailf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.mailf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailf.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mailf.Location = new System.Drawing.Point(126, 237);
            this.mailf.Multiline = true;
            this.mailf.Name = "mailf";
            this.mailf.Size = new System.Drawing.Size(390, 36);
            this.mailf.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(121, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mail";
            // 
            // fullname
            // 
            this.fullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fullname.Location = new System.Drawing.Point(126, 167);
            this.fullname.Multiline = true;
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(390, 36);
            this.fullname.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(121, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Full Name";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.button4.Location = new System.Drawing.Point(339, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = "Apply";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signinpanel);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.signinpanel.ResumeLayout(false);
            this.signinpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.forgotpanel.ResumeLayout(false);
            this.forgotpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signinpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button getstarted;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forgot;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label email;
        public System.Windows.Forms.Button hidepass;
        public System.Windows.Forms.Button showpass;
        private System.Windows.Forms.Panel forgotpanel;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.TextBox conpass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fullname;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
    }
}