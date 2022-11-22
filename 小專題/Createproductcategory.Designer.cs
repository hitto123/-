namespace 小專題
{
	partial class Createproductcategory
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
			this.addbutton = new System.Windows.Forms.Button();
			this.ShopNametextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.displayOrderTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addbutton
			// 
			this.addbutton.Location = new System.Drawing.Point(194, 126);
			this.addbutton.Name = "addbutton";
			this.addbutton.Size = new System.Drawing.Size(75, 23);
			this.addbutton.TabIndex = 0;
			this.addbutton.Text = "新增";
			this.addbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.addbutton.UseVisualStyleBackColor = true;
			this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
			// 
			// ShopNametextBox
			// 
			this.ShopNametextBox.Location = new System.Drawing.Point(125, 36);
			this.ShopNametextBox.Name = "ShopNametextBox";
			this.ShopNametextBox.Size = new System.Drawing.Size(144, 22);
			this.ShopNametextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 15F);
			this.label1.Location = new System.Drawing.Point(25, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "店家名稱:";
			// 
			// displayOrderTextBox
			// 
			this.displayOrderTextBox.Location = new System.Drawing.Point(125, 69);
			this.displayOrderTextBox.Name = "displayOrderTextBox";
			this.displayOrderTextBox.Size = new System.Drawing.Size(144, 22);
			this.displayOrderTextBox.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 15F);
			this.label2.Location = new System.Drawing.Point(25, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "顯示順序:";
			// 
			// Createproductcategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 179);
			this.Controls.Add(this.displayOrderTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ShopNametextBox);
			this.Controls.Add(this.addbutton);
			this.Name = "Createproductcategory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新增店家";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addbutton;
		private System.Windows.Forms.TextBox ShopNametextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox displayOrderTextBox;
		private System.Windows.Forms.Label label2;
	}
}