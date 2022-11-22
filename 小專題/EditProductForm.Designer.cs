namespace 小專題
{
	partial class EditProductForm
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
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.productIndexVMBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
			this.listPriceTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.productNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Orderbutton = new System.Windows.Forms.Button();
			this.productIndexVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.productCategoryVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.productVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productCategoryVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.productVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(83, 121);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 9;
			this.updateButton.Text = "編輯";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(163, 121);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 11;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.productIndexVMBindingSource4;
			this.categoryIdComboBox.DisplayMember = "ShopName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(105, 35);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(178, 20);
			this.categoryIdComboBox.TabIndex = 6;
			this.categoryIdComboBox.ValueMember = "ID";
			this.categoryIdComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryIdComboBox_SelectedIndexChanged);
			// 
			// productIndexVMBindingSource4
			// 
			this.productIndexVMBindingSource4.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// listPriceTextBox
			// 
			this.listPriceTextBox.Location = new System.Drawing.Point(105, 90);
			this.listPriceTextBox.Name = "listPriceTextBox";
			this.listPriceTextBox.Size = new System.Drawing.Size(178, 22);
			this.listPriceTextBox.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "價格:";
			// 
			// productNameTextBox
			// 
			this.productNameTextBox.Location = new System.Drawing.Point(105, 62);
			this.productNameTextBox.Name = "productNameTextBox";
			this.productNameTextBox.Size = new System.Drawing.Size(178, 22);
			this.productNameTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "店名:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 13;
			this.label1.Text = "商品名稱:";
			// 
			// Orderbutton
			// 
			this.Orderbutton.Location = new System.Drawing.Point(250, 121);
			this.Orderbutton.Margin = new System.Windows.Forms.Padding(2);
			this.Orderbutton.Name = "Orderbutton";
			this.Orderbutton.Size = new System.Drawing.Size(67, 23);
			this.Orderbutton.TabIndex = 14;
			this.Orderbutton.Text = "訂購";
			this.Orderbutton.UseVisualStyleBackColor = true;
			this.Orderbutton.Click += new System.EventHandler(this.Orderbutton_Click);
			// 
			// productIndexVMBindingSource3
			// 
			this.productIndexVMBindingSource3.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// productIndexVMBindingSource2
			// 
			this.productIndexVMBindingSource2.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// productCategoryVMBindingSource2
			// 
			this.productCategoryVMBindingSource2.DataSource = typeof(小專題.Model.ProductCategoryVM);
			// 
			// productVMBindingSource3
			// 
			this.productVMBindingSource3.DataSource = typeof(小專題.Model.ProductVM);
			// 
			// productIndexVMBindingSource1
			// 
			this.productIndexVMBindingSource1.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// productCategoryVMBindingSource1
			// 
			this.productCategoryVMBindingSource1.DataSource = typeof(小專題.Model.ProductCategoryVM);
			// 
			// productIndexVMBindingSource
			// 
			this.productIndexVMBindingSource.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(小專題.Model.ProductCategoryVM);
			// 
			// productVMBindingSource2
			// 
			this.productVMBindingSource2.DataSource = typeof(小專題.Model.ProductVM);
			// 
			// productVMBindingSource
			// 
			this.productVMBindingSource.DataSource = typeof(小專題.Model.ProductVM);
			// 
			// productVMBindingSource1
			// 
			this.productVMBindingSource1.DataSource = typeof(小專題.Model.ProductVM);
			// 
			// EditProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 228);
			this.Controls.Add(this.Orderbutton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.listPriceTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.productNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "EditProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "編輯飲料頁面";
			this.Load += new System.EventHandler(this.EditProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.TextBox listPriceTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox productNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource productVMBindingSource;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
		private System.Windows.Forms.BindingSource productVMBindingSource1;
		private System.Windows.Forms.BindingSource productVMBindingSource2;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource1;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource productVMBindingSource3;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource2;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource2;
		private System.Windows.Forms.Button Orderbutton;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource3;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource4;
	}
}