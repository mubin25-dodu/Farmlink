namespace Farmlink
{
    partial class sell_order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sell_order));
            this.table = new System.Windows.Forms.DataGridView();
            this.tablepanel = new System.Windows.Forms.Panel();
            this.tablenoti = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.pending = new System.Windows.Forms.Button();
            this.Processing = new System.Windows.Forms.Button();
            this.success = new System.Windows.Forms.Button();
            this.failed = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tablepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle9;
            this.table.Location = new System.Drawing.Point(3, 57);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(962, 476);
            this.table.TabIndex = 30;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pending_odr_CellClick);
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pending_odr_CellContentClick);
            // 
            // tablepanel
            // 
            this.tablepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablepanel.Controls.Add(this.tablenoti);
            this.tablepanel.Controls.Add(this.backbtn);
            this.tablepanel.Controls.Add(this.table);
            this.tablepanel.Location = new System.Drawing.Point(85, 87);
            this.tablepanel.Name = "tablepanel";
            this.tablepanel.Size = new System.Drawing.Size(968, 558);
            this.tablepanel.TabIndex = 39;
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
            // pending
            // 
            this.pending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.pending.Cursor = System.Windows.Forms.Cursors.Default;
            this.pending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pending.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pending.Location = new System.Drawing.Point(168, 104);
            this.pending.Name = "pending";
            this.pending.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.pending.Size = new System.Drawing.Size(237, 213);
            this.pending.TabIndex = 41;
            this.pending.Text = "Pending Orders";
            this.pending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pending.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pending.UseVisualStyleBackColor = false;
            this.pending.Click += new System.EventHandler(this.pending_Click);
            // 
            // Processing
            // 
            this.Processing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.Processing.Cursor = System.Windows.Forms.Cursors.Default;
            this.Processing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Processing.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Processing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Processing.Location = new System.Drawing.Point(449, 104);
            this.Processing.Name = "Processing";
            this.Processing.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.Processing.Size = new System.Drawing.Size(237, 213);
            this.Processing.TabIndex = 43;
            this.Processing.Text = "Processing Orders";
            this.Processing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Processing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Processing.UseVisualStyleBackColor = false;
            this.Processing.Click += new System.EventHandler(this.Processing_Click);
            // 
            // success
            // 
            this.success.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.success.Cursor = System.Windows.Forms.Cursors.Default;
            this.success.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.success.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.success.Location = new System.Drawing.Point(722, 104);
            this.success.Name = "success";
            this.success.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.success.Size = new System.Drawing.Size(237, 213);
            this.success.TabIndex = 45;
            this.success.Text = "Successfull Orders";
            this.success.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.success.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.success.UseVisualStyleBackColor = false;
            this.success.Click += new System.EventHandler(this.success_Click);
            // 
            // failed
            // 
            this.failed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.failed.Cursor = System.Windows.Forms.Cursors.Default;
            this.failed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.failed.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.failed.Location = new System.Drawing.Point(168, 346);
            this.failed.Name = "failed";
            this.failed.Padding = new System.Windows.Forms.Padding(0, 0, 50, 120);
            this.failed.Size = new System.Drawing.Size(237, 213);
            this.failed.TabIndex = 47;
            this.failed.Text = "Failed Orders";
            this.failed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.failed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.failed.UseVisualStyleBackColor = false;
            this.failed.Click += new System.EventHandler(this.failed_Click_1);
            // 
            // count
            // 
            this.count.AutoEllipsis = true;
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.count.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.ForeColor = System.Drawing.Color.Red;
            this.count.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.count.Location = new System.Drawing.Point(174, 280);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(74, 28);
            this.count.TabIndex = 49;
            this.count.Text = "count";
            // 
            // sell_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.tablepanel);
            this.Controls.Add(this.count);
            this.Controls.Add(this.failed);
            this.Controls.Add(this.success);
            this.Controls.Add(this.Processing);
            this.Controls.Add(this.pending);
            this.DoubleBuffered = true;
            this.Name = "sell_order";
            this.Size = new System.Drawing.Size(1165, 729);
            this.Load += new System.EventHandler(this.sell_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tablepanel.ResumeLayout(false);
            this.tablepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Panel tablepanel;
        public System.Windows.Forms.Button pending;
        public System.Windows.Forms.Button Processing;
        public System.Windows.Forms.Button success;
        public System.Windows.Forms.Button failed;
        public System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label tablenoti;
        private System.Windows.Forms.Label count;
    }
}
