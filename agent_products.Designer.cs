namespace Farmlink
{
    partial class agent_products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.noti = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmlinkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmlinkDataSet = new Farmlink.FarmlinkDataSet();
            this.orderTableAdapter = new Farmlink.FarmlinkDataSetTableAdapters.orderTableAdapter();
            this.productTableAdapter = new Farmlink.FarmlinkDataSetTableAdapters.productTableAdapter();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchbtn = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.DataGridView();
            this.agentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selleridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.searchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbox.Location = new System.Drawing.Point(67, 131);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(258, 32);
            this.searchbox.TabIndex = 34;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // noti
            // 
            this.noti.AutoSize = true;
            this.noti.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noti.ForeColor = System.Drawing.Color.Red;
            this.noti.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.noti.Location = new System.Drawing.Point(219, 84);
            this.noti.Name = "noti";
            this.noti.Size = new System.Drawing.Size(684, 28);
            this.noti.TabIndex = 32;
            this.noti.Text = " Double-click on the table cells to edit the product information.";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.farmlinkDataSetBindingSource;
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
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.farmlinkDataSetBindingSource;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.farmlinkDataSetBindingSource;
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
            this.searchbtn.Location = new System.Drawing.Point(323, 131);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(300, 3, 3, 3);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(32, 32);
            this.searchbtn.TabIndex = 35;
            this.searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // products
            // 
            this.products.AllowUserToAddRows = false;
            this.products.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.products.AutoGenerateColumns = false;
            this.products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.availableunitDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.selleridDataGridViewTextBoxColumn,
            this.agentidDataGridViewTextBoxColumn});
            this.products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products.DataSource = this.productBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.products.DefaultCellStyle = dataGridViewCellStyle6;
            this.products.Location = new System.Drawing.Point(67, 169);
            this.products.MultiSelect = false;
            this.products.Name = "products";
            this.products.RowHeadersVisible = false;
            this.products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products.Size = new System.Drawing.Size(1058, 592);
            this.products.TabIndex = 33;
            this.products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_CellContentClick);
            // 
            // agentidDataGridViewTextBoxColumn
            // 
            this.agentidDataGridViewTextBoxColumn.DataPropertyName = "agent_id";
            this.agentidDataGridViewTextBoxColumn.HeaderText = "agent_id";
            this.agentidDataGridViewTextBoxColumn.Name = "agentidDataGridViewTextBoxColumn";
            // 
            // selleridDataGridViewTextBoxColumn
            // 
            this.selleridDataGridViewTextBoxColumn.DataPropertyName = "seller_id";
            this.selleridDataGridViewTextBoxColumn.HeaderText = "seller_id";
            this.selleridDataGridViewTextBoxColumn.Name = "selleridDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // availableunitDataGridViewTextBoxColumn
            // 
            this.availableunitDataGridViewTextBoxColumn.DataPropertyName = "available_unit";
            this.availableunitDataGridViewTextBoxColumn.HeaderText = "available_unit";
            this.availableunitDataGridViewTextBoxColumn.Name = "availableunitDataGridViewTextBoxColumn";
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agent_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.noti);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.products);
            this.Name = "agent_products";
            this.Size = new System.Drawing.Size(1193, 844);
            this.Load += new System.EventHandler(this.agent_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmlinkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label noti;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource farmlinkDataSetBindingSource;
        private FarmlinkDataSet farmlinkDataSet;
        private FarmlinkDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private FarmlinkDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource1;
        public System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selleridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentidDataGridViewTextBoxColumn;
    }
}
