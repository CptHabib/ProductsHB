namespace ProductsHB.PL
{
    partial class FRM_CUST_LIST
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
            this.dgvcust = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcust
            // 
            this.dgvcust.AllowUserToAddRows = false;
            this.dgvcust.AllowUserToDeleteRows = false;
            this.dgvcust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcust.Location = new System.Drawing.Point(0, 0);
            this.dgvcust.Name = "dgvcust";
            this.dgvcust.ReadOnly = true;
            this.dgvcust.Size = new System.Drawing.Size(455, 363);
            this.dgvcust.TabIndex = 0;
            this.dgvcust.DoubleClick += new System.EventHandler(this.dgvcust_DoubleClick);
            // 
            // FRM_CUST_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 363);
            this.Controls.Add(this.dgvcust);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUST_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لائحة العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvcust;

    }
}