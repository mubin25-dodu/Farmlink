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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buyer_payment));
            this.details = new System.Windows.Forms.FlowLayoutPanel();
            this.cod = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.addressbox = new System.Windows.Forms.RichTextBox();
            this.donebtn = new System.Windows.Forms.LinkLabel();
            this.mobilepay = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.donep = new System.Windows.Forms.Button();
            this.pin_ = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.mobilepay.SuspendLayout();
            this.SuspendLayout();
            // 
            // details
            // 
            this.details.AutoScroll = true;
            this.details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(0)))));
            this.details.Location = new System.Drawing.Point(34, 59);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(1141, 308);
            this.details.TabIndex = 17;
            this.details.Paint += new System.Windows.Forms.PaintEventHandler(this.details_Paint);
            // 
            // cod
            // 
            this.cod.AllowDrop = true;
            this.cod.AutoSize = true;
            this.cod.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.cod.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.cod.Location = new System.Drawing.Point(29, 545);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(169, 25);
            this.cod.TabIndex = 18;
            this.cod.TabStop = true;
            this.cod.Text = "Cash On Delivery";
            this.cod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cod_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(29, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select a Payment Method";
            // 
            // address
            // 
            this.address.AllowDrop = true;
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.address.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.address.Location = new System.Drawing.Point(29, 370);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(261, 28);
            this.address.TabIndex = 20;
            this.address.TabStop = true;
            this.address.Text = "Click To Change Address";
            this.address.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.address_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AllowDrop = true;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Location = new System.Drawing.Point(29, 588);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 25);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mobile Banking";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(30, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addressbox
            // 
            this.addressbox.BackColor = System.Drawing.Color.SeaShell;
            this.addressbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressbox.ForeColor = System.Drawing.Color.Transparent;
            this.addressbox.Location = new System.Drawing.Point(34, 400);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(266, 96);
            this.addressbox.TabIndex = 23;
            this.addressbox.Text = "";
            // 
            // donebtn
            // 
            this.donebtn.AllowDrop = true;
            this.donebtn.AutoSize = true;
            this.donebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.donebtn.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.donebtn.Location = new System.Drawing.Point(306, 472);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(61, 25);
            this.donebtn.TabIndex = 24;
            this.donebtn.TabStop = true;
            this.donebtn.Text = "Done";
            this.donebtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.donebtn_LinkClicked_1);
            // 
            // mobilepay
            // 
            this.mobilepay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mobilepay.Controls.Add(this.backbtn);
            this.mobilepay.Controls.Add(this.donep);
            this.mobilepay.Controls.Add(this.pin_);
            this.mobilepay.Controls.Add(this.pin);
            this.mobilepay.Controls.Add(this.phone);
            this.mobilepay.Controls.Add(this.num);
            this.mobilepay.Location = new System.Drawing.Point(373, 35);
            this.mobilepay.Name = "mobilepay";
            this.mobilepay.Size = new System.Drawing.Size(386, 434);
            this.mobilepay.TabIndex = 27;
            this.mobilepay.Paint += new System.Windows.Forms.PaintEventHandler(this.listing_Paint_1);
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
            this.backbtn.Location = new System.Drawing.Point(47, 31);
            this.backbtn.Name = "backbtn";
            this.backbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backbtn.Size = new System.Drawing.Size(49, 49);
            this.backbtn.TabIndex = 29;
            this.backbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // donep
            // 
            this.donep.AutoSize = true;
            this.donep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.donep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.donep.Cursor = System.Windows.Forms.Cursors.Default;
            this.donep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donep.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.donep.Location = new System.Drawing.Point(257, 347);
            this.donep.Name = "donep";
            this.donep.Size = new System.Drawing.Size(74, 38);
            this.donep.TabIndex = 28;
            this.donep.Text = "Done";
            this.donep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donep.UseVisualStyleBackColor = false;
            this.donep.Click += new System.EventHandler(this.donep_Click);
            // 
            // pin_
            // 
            this.pin_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.pin_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pin_.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pin_.Location = new System.Drawing.Point(47, 255);
            this.pin_.Multiline = true;
            this.pin_.Name = "pin_";
            this.pin_.Size = new System.Drawing.Size(284, 36);
            this.pin_.TabIndex = 17;
            // 
            // pin
            // 
            this.pin.AutoSize = true;
            this.pin.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.ForeColor = System.Drawing.Color.White;
            this.pin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.pin.Location = new System.Drawing.Point(42, 217);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(108, 28);
            this.pin.TabIndex = 16;
            this.pin.Text = "Enter Pin";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.phone.Location = new System.Drawing.Point(42, 133);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(236, 28);
            this.phone.TabIndex = 15;
            this.phone.Text = "Enter Phone Number";
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(136)))));
            this.num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.num.Location = new System.Drawing.Point(47, 178);
            this.num.Multiline = true;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(284, 36);
            this.num.TabIndex = 14;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.data.Location = new System.Drawing.Point(29, 13);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(107, 28);
            this.data.TabIndex = 16;
            this.data.Text = "Products";
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.ForeColor = System.Drawing.Color.White;
            this.total_price.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.total_price.Location = new System.Drawing.Point(329, 585);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(107, 28);
            this.total_price.TabIndex = 28;
            this.total_price.Text = "Products";
            // 
            // Buyer_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::Farmlink.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.total_price);
            this.Controls.Add(this.mobilepay);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.details);
            this.Controls.Add(this.data);
            this.DoubleBuffered = true;
            this.Name = "Buyer_payment";
            this.Size = new System.Drawing.Size(1165, 729);
            this.Load += new System.EventHandler(this.Buyer_payment_Load);
            this.mobilepay.ResumeLayout(false);
            this.mobilepay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel details;
        private System.Windows.Forms.LinkLabel cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel address;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox addressbox;
        private System.Windows.Forms.LinkLabel donebtn;
        private System.Windows.Forms.Panel mobilepay;
        public System.Windows.Forms.Button backbtn;
        public System.Windows.Forms.Button donep;
        private System.Windows.Forms.TextBox pin_;
        private System.Windows.Forms.Label pin;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label total_price;
    }
}
