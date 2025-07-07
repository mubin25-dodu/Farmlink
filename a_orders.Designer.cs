namespace Farmlink
{
    partial class a_orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(a_orders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablepanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.tablenoti = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.failed = new System.Windows.Forms.Button();
            this.success = new System.Windows.Forms.Button();
            this.Processing = new System.Windows.Forms.Button();
            this.req = new System.Windows.Forms.Button();
            this.Delevred = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.tablepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // tablepanel
            // 
            this.tablepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablepanel.Controls.Add(this.label2);
            this.tablepanel.Controls.Add(this.searchbtn);
            this.tablepanel.Controls.Add(this.searchbox);
            this.tablepanel.Controls.Add(this.tablenoti);
            this.tablepanel.Controls.Add(this.backbtn);
            this.tablepanel.Controls.Add(this.table);
            this.tablepanel.Location = new System.Drawing.Point(77, 79);
            this.tablepanel.Name = "tablepanel";
            this.tablepanel.Size = new System.Drawing.Size(968, 558);
            this.tablepanel.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(668, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Search by ID ";
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
            this.searchbtn.Location = new System.Drawing.Point(927, 20);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(300, 3, 3, 3);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(32, 32);
            this.searchbtn.TabIndex = 73;
            this.searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // searchbox
            // 
            this.searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.searchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbox.Location = new System.Drawing.Point(670, 20);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(258, 32);
            this.searchbox.TabIndex = 72;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // tablenoti
            // 
            this.tablenoti.AutoSize = true;
            this.tablenoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.tablenoti.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablenoti.ForeColor = System.Drawing.Color.OrangeRed;
            this.tablenoti.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tablenoti.Location = new System.Drawing.Point(182, 17);
            this.tablenoti.Name = "tablenoti";
            this.tablenoti.Size = new System.Drawing.Size(54, 21);
            this.tablenoti.TabIndex = 49;
            this.tablenoti.Text = "count";
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
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle6;
            this.table.Location = new System.Drawing.Point(3, 57);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(962, 476);
            this.table.TabIndex = 30;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // failed
            // 
            this.failed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.failed.Cursor = System.Windows.Forms.Cursors.Default;
            this.failed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.failed.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.failed.Location = new System.Drawing.Point(450, 365);
            this.failed.Name = "failed";
            this.failed.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.failed.Size = new System.Drawing.Size(237, 213);
            this.failed.TabIndex = 56;
            this.failed.Text = "Failed Orders";
            this.failed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.failed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.failed.UseVisualStyleBackColor = false;
            this.failed.Click += new System.EventHandler(this.failed_Click);
            // 
            // success
            // 
            this.success.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.success.Cursor = System.Windows.Forms.Cursors.Default;
            this.success.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.success.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.success.Location = new System.Drawing.Point(169, 365);
            this.success.Name = "success";
            this.success.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.success.Size = new System.Drawing.Size(237, 213);
            this.success.TabIndex = 54;
            this.success.Text = "Successfull Orders";
            this.success.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.success.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.success.UseVisualStyleBackColor = false;
            this.success.Click += new System.EventHandler(this.success_Click);
            // 
            // Processing
            // 
            this.Processing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.Processing.Cursor = System.Windows.Forms.Cursors.Default;
            this.Processing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Processing.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Processing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Processing.Location = new System.Drawing.Point(450, 109);
            this.Processing.Name = "Processing";
            this.Processing.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.Processing.Size = new System.Drawing.Size(237, 213);
            this.Processing.TabIndex = 52;
            this.Processing.Text = "Processing Orders";
            this.Processing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Processing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Processing.UseVisualStyleBackColor = false;
            this.Processing.Click += new System.EventHandler(this.Processing_Click);
            // 
            // req
            // 
            this.req.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.req.Cursor = System.Windows.Forms.Cursors.Default;
            this.req.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.req.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.req.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.req.Location = new System.Drawing.Point(169, 109);
            this.req.Name = "req";
            this.req.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.req.Size = new System.Drawing.Size(237, 213);
            this.req.TabIndex = 50;
            this.req.Text = "Collection Request";
            this.req.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.req.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.req.UseVisualStyleBackColor = false;
            this.req.Click += new System.EventHandler(this.req_Click);
            // 
            // Delevred
            // 
            this.Delevred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.Delevred.Cursor = System.Windows.Forms.Cursors.Default;
            this.Delevred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delevred.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delevred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delevred.Location = new System.Drawing.Point(721, 109);
            this.Delevred.Name = "Delevred";
            this.Delevred.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.Delevred.Size = new System.Drawing.Size(237, 213);
            this.Delevred.TabIndex = 58;
            this.Delevred.Text = "Mark as Melivered ";
            this.Delevred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delevred.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Delevred.UseVisualStyleBackColor = false;
            this.Delevred.Click += new System.EventHandler(this.Delevred_Click);
            // 
            // count
            // 
            this.count.AutoEllipsis = true;
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.count.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.ForeColor = System.Drawing.Color.Red;
            this.count.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.count.Location = new System.Drawing.Point(181, 284);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(74, 28);
            this.count.TabIndex = 48;
            this.count.Text = "count";
            // 
            // a_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::Farmlink.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.tablepanel);
            this.Controls.Add(this.count);
            this.Controls.Add(this.failed);
            this.Controls.Add(this.success);
            this.Controls.Add(this.Processing);
            this.Controls.Add(this.req);
            this.Controls.Add(this.Delevred);
            this.DoubleBuffered = true;
            this.Name = "a_orders";
            this.Size = new System.Drawing.Size(1165, 770);
            this.Load += new System.EventHandler(this.a_orders_Load);
            this.tablepanel.ResumeLayout(false);
            this.tablepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tablepanel;
        private System.Windows.Forms.Label tablenoti;
        public System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView table;
        public System.Windows.Forms.Button failed;
        public System.Windows.Forms.Button success;
        public System.Windows.Forms.Button Processing;
        public System.Windows.Forms.Button req;
        public System.Windows.Forms.Button Delevred;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label count;
    }
}
