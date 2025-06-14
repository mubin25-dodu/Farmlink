namespace Farmlink
{
    partial class B_order_stat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Label();
            this.orderhistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmlinkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmlinkDataSet = new Farmlink.FarmlinkDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderhistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderhistoryTableAdapter = new Farmlink.FarmlinkDataSetTableAdapters.orderhistoryTableAdapter();
            this.orderTableAdapter = new Farmlink.FarmlinkDataSetTableAdapters.orderTableAdapter();
            this.orderhistoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Farmlink.FarmlinkDataSetTableAdapters.TableAdapterManager();
            this.his_notifi = new System.Windows.Forms.Label();
            this.ordr = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.DataGridView();
            this.orderhistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.data.Location = new System.Drawing.Point(80, 74);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(212, 28);
            this.data.TabIndex = 19;
            this.data.Text = "Ordered  Products ";
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.history.Location = new System.Drawing.Point(80, 373);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(156, 28);
            this.history.TabIndex = 20;
            this.history.Text = "Order History";
            // 
            // orderhistoryBindingSource
            // 
            this.orderhistoryBindingSource.DataMember = "orderhistory";
            this.orderhistoryBindingSource.DataSource = this.farmlinkDataSetBindingSource;
            // 
            // farmlinkDataSetBindingSource
            // 
            this.farmlinkDataSetBindingSource.DataSource = this.farmlinkDataSet;
            this.farmlinkDataSetBindingSource.Position = 0;
            // 
            // farmlinkDataSet
            // 
            this.farmlinkDataSet.DataSetName = "FarmlinkDataSet";
            this.farmlinkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.farmlinkDataSetBindingSource;
            // 
            // orderhistoryBindingSource1
            // 
            this.orderhistoryBindingSource1.DataMember = "orderhistory";
            this.orderhistoryBindingSource1.DataSource = this.farmlinkDataSetBindingSource;
            // 
            // orderhistoryTableAdapter
            // 
            this.orderhistoryTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderhistoryBindingSource2
            // 
            this.orderhistoryBindingSource2.DataMember = "orderhistory";
            this.orderhistoryBindingSource2.DataSource = this.farmlinkDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.orderhistoryTableAdapter = this.orderhistoryTableAdapter;
            this.tableAdapterManager.orderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Farmlink.FarmlinkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userinfoTableAdapter = null;
            // 
            // his_notifi
            // 
            this.his_notifi.AutoSize = true;
            this.his_notifi.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.his_notifi.ForeColor = System.Drawing.Color.PeachPuff;
            this.his_notifi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.his_notifi.Location = new System.Drawing.Point(242, 380);
            this.his_notifi.Name = "his_notifi";
            this.his_notifi.Size = new System.Drawing.Size(45, 19);
            this.his_notifi.TabIndex = 22;
            this.his_notifi.Text = "count";
            // 
            // ordr
            // 
            this.ordr.AutoSize = true;
            this.ordr.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordr.ForeColor = System.Drawing.Color.PeachPuff;
            this.ordr.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ordr.Location = new System.Drawing.Point(298, 81);
            this.ordr.Name = "ordr";
            this.ordr.Size = new System.Drawing.Size(45, 19);
            this.ordr.TabIndex = 26;
            this.ordr.Text = "count";
            // 
            // order
            // 
            this.order.AllowUserToAddRows = false;
            this.order.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.order.DefaultCellStyle = dataGridViewCellStyle3;
            this.order.Location = new System.Drawing.Point(85, 103);
            this.order.MultiSelect = false;
            this.order.Name = "order";
            this.order.RowHeadersVisible = false;
            this.order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.order.Size = new System.Drawing.Size(971, 274);
            this.order.TabIndex = 28;
            this.order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_CellContentClick_1);
            // 
            // orderhistory
            // 
            this.orderhistory.AllowUserToAddRows = false;
            this.orderhistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.orderhistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.orderhistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderhistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderhistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.orderhistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderhistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.orderhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderhistory.DefaultCellStyle = dataGridViewCellStyle6;
            this.orderhistory.Location = new System.Drawing.Point(85, 404);
            this.orderhistory.MultiSelect = false;
            this.orderhistory.Name = "orderhistory";
            this.orderhistory.RowHeadersVisible = false;
            this.orderhistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderhistory.Size = new System.Drawing.Size(971, 294);
            this.orderhistory.TabIndex = 29;
            // 
            // B_order_stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.orderhistory);
            this.Controls.Add(this.order);
            this.Controls.Add(this.ordr);
            this.Controls.Add(this.his_notifi);
            this.Controls.Add(this.history);
            this.Controls.Add(this.data);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "B_order_stat";
            this.Size = new System.Drawing.Size(1165, 770);
            this.Load += new System.EventHandler(this.B_order_stat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderhistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.BindingSource orderhistoryBindingSource;
        private System.Windows.Forms.BindingSource farmlinkDataSetBindingSource;
        private FarmlinkDataSet farmlinkDataSet;
        private FarmlinkDataSetTableAdapters.orderhistoryTableAdapter orderhistoryTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private FarmlinkDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderhistoryBindingSource1;
        private System.Windows.Forms.BindingSource orderhistoryBindingSource2;
        private FarmlinkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label his_notifi;
        private System.Windows.Forms.Label ordr;
        private System.Windows.Forms.DataGridView order;
        private System.Windows.Forms.DataGridView orderhistory;
    }
}
