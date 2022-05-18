namespace ResturantManagementSystem.Gui_Dashboards.StockmanDashbourdPanel
{
    partial class stockPanel
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
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new ResturantManagementSystem.ResturantTableAdapters.StockTableAdapter();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsNameTextBox = new System.Windows.Forms.TextBox();
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.costPerOneTextBox = new System.Windows.Forms.TextBox();
            this.costPerOneLabel = new System.Windows.Forms.Label();
            this.goodsIdTextBox = new System.Windows.Forms.TextBox();
            this.goodsIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceProviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIDDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.costPerOneDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
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
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.resturant;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            // 
            // costPerOneDataGridViewTextBoxColumn
            // 
            this.costPerOneDataGridViewTextBoxColumn.DataPropertyName = "CostPerOne";
            this.costPerOneDataGridViewTextBoxColumn.HeaderText = "CostPerOne";
            this.costPerOneDataGridViewTextBoxColumn.Name = "costPerOneDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(426, 311);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(112, 32);
            this.rjButton3.TabIndex = 23;
            this.rjButton3.Text = "Delet";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(426, 261);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(112, 32);
            this.rjButton2.TabIndex = 22;
            this.rjButton2.Text = "Update";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(426, 205);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(112, 32);
            this.rjButton1.TabIndex = 21;
            this.rjButton1.Text = "Add new goods";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(273, 323);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(144, 23);
            this.QuantityTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "QuantityLabel";
            // 
            // goodsNameTextBox
            // 
            this.goodsNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameTextBox.Location = new System.Drawing.Point(86, 323);
            this.goodsNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.goodsNameTextBox.Name = "goodsNameTextBox";
            this.goodsNameTextBox.Size = new System.Drawing.Size(149, 23);
            this.goodsNameTextBox.TabIndex = 18;
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameLabel.Location = new System.Drawing.Point(83, 290);
            this.goodsNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(94, 18);
            this.goodsNameLabel.TabIndex = 17;
            this.goodsNameLabel.Text = "GoodsName";
            // 
            // costPerOneTextBox
            // 
            this.costPerOneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPerOneTextBox.Location = new System.Drawing.Point(273, 251);
            this.costPerOneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costPerOneTextBox.Name = "costPerOneTextBox";
            this.costPerOneTextBox.Size = new System.Drawing.Size(144, 23);
            this.costPerOneTextBox.TabIndex = 16;
            // 
            // costPerOneLabel
            // 
            this.costPerOneLabel.AutoSize = true;
            this.costPerOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPerOneLabel.Location = new System.Drawing.Point(270, 218);
            this.costPerOneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costPerOneLabel.Name = "costPerOneLabel";
            this.costPerOneLabel.Size = new System.Drawing.Size(91, 18);
            this.costPerOneLabel.TabIndex = 15;
            this.costPerOneLabel.Text = "CostPerOne";
            // 
            // goodsIdTextBox
            // 
            this.goodsIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsIdTextBox.Location = new System.Drawing.Point(80, 251);
            this.goodsIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.goodsIdTextBox.Name = "goodsIdTextBox";
            this.goodsIdTextBox.Size = new System.Drawing.Size(155, 23);
            this.goodsIdTextBox.TabIndex = 14;
            // 
            // goodsIdLabel
            // 
            this.goodsIdLabel.AutoSize = true;
            this.goodsIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsIdLabel.Location = new System.Drawing.Point(77, 218);
            this.goodsIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goodsIdLabel.Name = "goodsIdLabel";
            this.goodsIdLabel.Size = new System.Drawing.Size(68, 18);
            this.goodsIdLabel.TabIndex = 13;
            this.goodsIdLabel.Text = "GoodsID";
            // 
            // stockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goodsNameTextBox);
            this.Controls.Add(this.goodsNameLabel);
            this.Controls.Add(this.costPerOneTextBox);
            this.Controls.Add(this.costPerOneLabel);
            this.Controls.Add(this.goodsIdTextBox);
            this.Controls.Add(this.goodsIdLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stockPanel";
            this.Text = "stockPanel";
            this.Load += new System.EventHandler(this.stockPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceProviderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Resturant resturant;
        private System.Windows.Forms.BindingSource serviceProviderBindingSource;
        private ResturantTableAdapters.ServiceProviderTableAdapter serviceProviderTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private ResturantTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPerOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goodsNameTextBox;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.TextBox costPerOneTextBox;
        private System.Windows.Forms.Label costPerOneLabel;
        private System.Windows.Forms.TextBox goodsIdTextBox;
        private System.Windows.Forms.Label goodsIdLabel;
    }
}