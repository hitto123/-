namespace 小專題
{
	partial class Mainform
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
			this.productdataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIndexVMBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
			this.viewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addbutton = new System.Windows.Forms.Button();
			this.searchbutton = new System.Windows.Forms.Button();
			this.drinkcomboBox = new System.Windows.Forms.ComboBox();
			this.productIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.productdataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewModelsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource4)).BeginInit();
			this.SuspendLayout();
			// 
			// productdataGridView
			// 
			this.productdataGridView.AutoGenerateColumns = false;
			this.productdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.shopNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn});
			this.productdataGridView.DataSource = this.productIndexVMBindingSource5;
			this.productdataGridView.Location = new System.Drawing.Point(42, 113);
			this.productdataGridView.Name = "productdataGridView";
			this.productdataGridView.RowTemplate.Height = 24;
			this.productdataGridView.Size = new System.Drawing.Size(548, 356);
			this.productdataGridView.TabIndex = 7;
			this.productdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productdataGridView_CellClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// shopNameDataGridViewTextBoxColumn
			// 
			this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "ShopName";
			this.shopNameDataGridViewTextBoxColumn.HeaderText = "ShopName";
			this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			// 
			// listPriceDataGridViewTextBoxColumn
			// 
			this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
			this.listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
			this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
			// 
			// productIndexVMBindingSource5
			// 
			this.productIndexVMBindingSource5.DataSource = typeof(小專題.Model.ViewModels.ProductIndexVM);
			// 
			// viewModelsBindingSource
			// 
			this.viewModelsBindingSource.DataSource = typeof(小專題.Model.ViewModels);
			// 
			// productIndexVMBindingSource3
			// 
			this.productIndexVMBindingSource3.DataSource = typeof(小專題.Model.ViewModels.ProductIndexVM);
			// 
			// productIndexVMBindingSource2
			// 
			this.productIndexVMBindingSource2.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// productIndexVMBindingSource1
			// 
			this.productIndexVMBindingSource1.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(小專題.Model.ProductCategoryVM);
			// 
			// productVMBindingSource
			// 
			this.productVMBindingSource.DataSource = typeof(小專題.Model.ProductVM);
			// 
			// addbutton
			// 
			this.addbutton.Location = new System.Drawing.Point(369, 35);
			this.addbutton.Name = "addbutton";
			this.addbutton.Size = new System.Drawing.Size(95, 32);
			this.addbutton.TabIndex = 6;
			this.addbutton.Text = "新增";
			this.addbutton.UseVisualStyleBackColor = true;
			this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
			// 
			// searchbutton
			// 
			this.searchbutton.Location = new System.Drawing.Point(169, 35);
			this.searchbutton.Name = "searchbutton";
			this.searchbutton.Size = new System.Drawing.Size(82, 27);
			this.searchbutton.TabIndex = 5;
			this.searchbutton.Text = "查詢";
			this.searchbutton.UseVisualStyleBackColor = true;
			this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click_1);
			// 
			// drinkcomboBox
			// 
			this.drinkcomboBox.DataSource = this.productCategoryVMBindingSource;
			this.drinkcomboBox.DisplayMember = "ShopName";
			this.drinkcomboBox.FormattingEnabled = true;
			this.drinkcomboBox.Location = new System.Drawing.Point(42, 42);
			this.drinkcomboBox.Name = "drinkcomboBox";
			this.drinkcomboBox.Size = new System.Drawing.Size(121, 20);
			this.drinkcomboBox.TabIndex = 4;
			this.drinkcomboBox.ValueMember = "Id";
			// 
			// productIndexVMBindingSource
			// 
			this.productIndexVMBindingSource.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// productIndexVMBindingSource4
			// 
			this.productIndexVMBindingSource4.DataSource = typeof(小專題.Model.ViewModels.ProductIndexVM);
			// 
			// Mainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 481);
			this.Controls.Add(this.productdataGridView);
			this.Controls.Add(this.addbutton);
			this.Controls.Add(this.searchbutton);
			this.Controls.Add(this.drinkcomboBox);
			this.Name = "Mainform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mainform";
			((System.ComponentModel.ISupportInitialize)(this.productdataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewModelsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView productdataGridView;
		private System.Windows.Forms.Button addbutton;
		private System.Windows.Forms.Button searchbutton;
		private System.Windows.Forms.ComboBox drinkcomboBox;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
		private System.Windows.Forms.BindingSource productVMBindingSource;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource2;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource3;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource4;
		private System.Windows.Forms.BindingSource viewModelsBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource5;
	}
}