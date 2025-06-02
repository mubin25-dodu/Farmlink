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
            this.pending = new System.Windows.Forms.Label();
            this.processing = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.failed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pending
            // 
            this.pending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pending.AutoSize = true;
            this.pending.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pending.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.pending.Location = new System.Drawing.Point(37, 40);
            this.pending.Name = "pending";
            this.pending.Size = new System.Drawing.Size(177, 28);
            this.pending.TabIndex = 26;
            this.pending.Text = "Pending Orders";
            // 
            // processing
            // 
            this.processing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processing.AutoSize = true;
            this.processing.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.processing.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processing.Location = new System.Drawing.Point(580, 40);
            this.processing.Name = "processing";
            this.processing.Size = new System.Drawing.Size(203, 28);
            this.processing.TabIndex = 27;
            this.processing.Text = "Processing Orders";
            // 
            // success
            // 
            this.success.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.success.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.success.Location = new System.Drawing.Point(37, 415);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(205, 28);
            this.success.TabIndex = 28;
            this.success.Text = "Successfull Orders";
            // 
            // failed
            // 
            this.failed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.failed.AutoSize = true;
            this.failed.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.failed.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.failed.Location = new System.Drawing.Point(580, 415);
            this.failed.Name = "failed";
            this.failed.Size = new System.Drawing.Size(151, 28);
            this.failed.TabIndex = 29;
            this.failed.Text = "Failed Orders";
            // 
            // sell_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::Farmlink.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.failed);
            this.Controls.Add(this.success);
            this.Controls.Add(this.processing);
            this.Controls.Add(this.pending);
            this.DoubleBuffered = true;
            this.Name = "sell_order";
            this.Size = new System.Drawing.Size(1165, 729);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pending;
        private System.Windows.Forms.Label processing;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label failed;
    }
}
