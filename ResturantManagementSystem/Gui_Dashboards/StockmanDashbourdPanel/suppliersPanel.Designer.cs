namespace ResturantManagementSystem.Gui_Dashboards.StockmanDashbourdPanel
{
    partial class suppliersPanel
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resturant = new ResturantManagementSystem.Resturant();
            this.serviceProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceProviderTableAdapter = new ResturantManagementSystem.ResturantTableAdapters.ServiceProviderTableAdapter();
            this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceProviderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIDDataGridViewTextBoxColumn,
            this.coNameDataGridViewTextBoxColumn,
            this.coEmailDataGridViewTextBoxColumn,
            this.coPhoneDataGridViewTextBoxColumn,
            this.coAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceProviderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // resturant
            // 
            this.resturant.DataSetName = "Resturant";
            this.resturant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceProviderBindingSource
            // 
            this.serviceProviderBindingSource.DataMember = "ServiceProvider";
            this.serviceProviderBindingSource.DataSource = this.resturant;
            // 
            // serviceProviderTableAdapter
            // 
            this.serviceProviderTableAdapter.ClearBeforeFill = true;
            // 
            // companyIDDataGridViewTextBoxColumn
            // 
            this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "CompanyID";
            this.companyIDDataGridViewTextBoxColumn.HeaderText = "CompanyID";
            this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
            // 
            // coNameDataGridViewTextBoxColumn
            // 
            this.coNameDataGridViewTextBoxColumn.DataPropertyName = "CoName";
            this.coNameDataGridViewTextBoxColumn.HeaderText = "CoName";
            this.coNameDataGridViewTextBoxColumn.Name = "coNameDataGridViewTextBoxColumn";
            // 
            // coEmailDataGridViewTextBoxColumn
            // 
            this.coEmailDataGridViewTextBoxColumn.DataPropertyName = "CoEmail";
            this.coEmailDataGridViewTextBoxColumn.HeaderText = "CoEmail";
            this.coEmailDataGridViewTextBoxColumn.Name = "coEmailDataGridViewTextBoxColumn";
            // 
            // coPhoneDataGridViewTextBoxColumn
            // 
            this.coPhoneDataGridViewTextBoxColumn.DataPropertyName = "CoPhone";
            this.coPhoneDataGridViewTextBoxColumn.HeaderText = "CoPhone";
            this.coPhoneDataGridViewTextBoxColumn.Name = "coPhoneDataGridViewTextBoxColumn";
            // 
            // coAddressDataGridViewTextBoxColumn
            // 
            this.coAddressDataGridViewTextBoxColumn.DataPropertyName = "CoAddress";
            this.coAddressDataGridViewTextBoxColumn.HeaderText = "CoAddress";
            this.coAddressDataGridViewTextBoxColumn.Name = "coAddressDataGridViewTextBoxColumn";
            // 
            // suppliersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "suppliersPanel";
            this.Text = "suppliersPanel";
            this.Load += new System.EventHandler(this.suppliersPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceProviderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Resturant resturant;
        private System.Windows.Forms.BindingSource serviceProviderBindingSource;
        private ResturantTableAdapters.ServiceProviderTableAdapter serviceProviderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coAddressDataGridViewTextBoxColumn;
    }
}