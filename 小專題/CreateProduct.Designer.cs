namespace 小專題
{
	partial class CreateProduct
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
			this.listpricetextBox = new System.Windows.Forms.TextBox();
			this.productNametextBox = new System.Windows.Forms.TextBox();
			this.categoryIdcomboBox = new System.Windows.Forms.ComboBox();
			this.productVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Addbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// listpricetextBox
			// 
			this.listpricetextBox.Location = new System.Drawing.Point(153, 160);
			this.listpricetextBox.Name = "listpricetextBox";
			this.listpricetextBox.Size = new System.Drawing.Size(121, 22);
			this.listpricetextBox.TabIndex = 11;
			// 
			// productNametextBox
			// 
			this.productNametextBox.Location = new System.Drawing.Point(153, 112);
			this.productNametextBox.Name = "productNametextBox";
			this.productNametextBox.Size = new System.Drawing.Size(121, 22);
			this.productNametextBox.TabIndex = 10;
			// 
			// categoryIdcomboBox
			// 
			this.categoryIdcomboBox.DataSource = this.productVMBindingSource;
			this.categoryIdcomboBox.DisplayMember = "ShopName";
			this.categoryIdcomboBox.FormattingEnabled = true;
			this.categoryIdcomboBox.Location = new System.Drawing.Point(153, 65);
			this.categoryIdcomboBox.Name = "categoryIdcomboBox";
			this.categoryIdcomboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryIdcomboBox.TabIndex = 9;
			this.categoryIdcomboBox.ValueMember = "Id";
			// 
			// productVMBindingSource
			// 
			this.productVMBindingSource.DataSource = typeof(小專題.Model.ProductVM);
			// 
			// productIndexVMBindingSource
			// 
			this.productIndexVMBindingSource.DataSource = typeof(小專題.Model.ProductIndexVM);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("新細明體", 15F);
			this.label3.Location = new System.Drawing.Point(70, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "價格:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 15F);
			this.label2.Location = new System.Drawing.Point(53, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "商品名稱:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 15F);
			this.label1.Location = new System.Drawing.Point(70, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "分類:";
			// 
			// Addbutton
			// 
			this.Addbutton.Location = new System.Drawing.Point(199, 236);
			this.Addbutton.Name = "Addbutton";
			this.Addbutton.Size = new System.Drawing.Size(75, 23);
			this.Addbutton.TabIndex = 5;
			this.Addbutton.Text = "新增";
			this.Addbutton.UseVisualStyleBackColor = true;
			this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
			// 
			// CreateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 392);
			this.Controls.Add(this.listpricetextBox);
			this.Controls.Add(this.productNametextBox);
			this.Controls.Add(this.categoryIdcomboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Addbutton);
			this.Name = "CreateProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新增商品";
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox listpricetextBox;
		private System.Windows.Forms.TextBox productNametextBox;
		private System.Windows.Forms.ComboBox categoryIdcomboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Addbutton;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource;
		private System.Windows.Forms.BindingSource productVMBindingSource;
	}
}