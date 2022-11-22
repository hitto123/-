namespace 小專題
{
	partial class OrderForm
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
			this.PricetextBox = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.radioButton11 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.Orderbutton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.ChecktextBox = new System.Windows.Forms.TextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.ProductNametextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.Sendbutton = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.ShopNametextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// PricetextBox
			// 
			this.PricetextBox.Location = new System.Drawing.Point(200, 33);
			this.PricetextBox.Margin = new System.Windows.Forms.Padding(2);
			this.PricetextBox.Name = "PricetextBox";
			this.PricetextBox.Size = new System.Drawing.Size(77, 22);
			this.PricetextBox.TabIndex = 0;
			this.PricetextBox.TextChanged += new System.EventHandler(this.ProductNametextBox_TextChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(2, 6);
			this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(59, 16);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Tag = "正常甜";
			this.radioButton1.Text = "正常甜";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(379, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "甜度";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(459, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "冰塊量";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(132, 7);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "飲料名:";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(2, 24);
			this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(47, 16);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Tag = "少糖";
			this.radioButton2.Text = "少糖";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(2, 43);
			this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(47, 16);
			this.radioButton3.TabIndex = 1;
			this.radioButton3.TabStop = true;
			this.radioButton3.Tag = "半糖";
			this.radioButton3.Text = "半糖";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(2, 62);
			this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(47, 16);
			this.radioButton4.TabIndex = 1;
			this.radioButton4.TabStop = true;
			this.radioButton4.Tag = "微糖";
			this.radioButton4.Text = "微糖";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(2, 80);
			this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(47, 16);
			this.radioButton5.TabIndex = 1;
			this.radioButton5.TabStop = true;
			this.radioButton5.Tag = "無糖";
			this.radioButton5.Text = "無糖";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Location = new System.Drawing.Point(2, 2);
			this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(59, 16);
			this.radioButton7.TabIndex = 3;
			this.radioButton7.TabStop = true;
			this.radioButton7.Tag = "正常冰";
			this.radioButton7.Text = "正常冰";
			this.radioButton7.UseVisualStyleBackColor = true;
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(2, 21);
			this.radioButton8.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(47, 16);
			this.radioButton8.TabIndex = 3;
			this.radioButton8.TabStop = true;
			this.radioButton8.Tag = "少冰";
			this.radioButton8.Text = "少冰";
			this.radioButton8.UseVisualStyleBackColor = true;
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.Location = new System.Drawing.Point(2, 40);
			this.radioButton9.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(47, 16);
			this.radioButton9.TabIndex = 3;
			this.radioButton9.TabStop = true;
			this.radioButton9.Tag = "去冰";
			this.radioButton9.Text = "去冰";
			this.radioButton9.UseVisualStyleBackColor = true;
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.Location = new System.Drawing.Point(2, 59);
			this.radioButton10.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(71, 16);
			this.radioButton10.TabIndex = 3;
			this.radioButton10.TabStop = true;
			this.radioButton10.Tag = "完全去冰";
			this.radioButton10.Text = "完全去冰";
			this.radioButton10.UseVisualStyleBackColor = true;
			// 
			// radioButton11
			// 
			this.radioButton11.AutoSize = true;
			this.radioButton11.Location = new System.Drawing.Point(2, 79);
			this.radioButton11.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton11.Name = "radioButton11";
			this.radioButton11.Size = new System.Drawing.Size(47, 16);
			this.radioButton11.TabIndex = 3;
			this.radioButton11.TabStop = true;
			this.radioButton11.Tag = "熱飲";
			this.radioButton11.Text = "熱飲";
			this.radioButton11.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(305, 7);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 4;
			this.label4.Text = "數量";
			// 
			// Orderbutton
			// 
			this.Orderbutton.Location = new System.Drawing.Point(455, 164);
			this.Orderbutton.Margin = new System.Windows.Forms.Padding(2);
			this.Orderbutton.Name = "Orderbutton";
			this.Orderbutton.Size = new System.Drawing.Size(77, 29);
			this.Orderbutton.TabIndex = 6;
			this.Orderbutton.Text = "確認";
			this.Orderbutton.UseVisualStyleBackColor = true;
			this.Orderbutton.Click += new System.EventHandler(this.Orderbutton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(223, 7);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 7;
			this.label5.Text = "單價";
			// 
			// ChecktextBox
			// 
			this.ChecktextBox.Location = new System.Drawing.Point(68, 232);
			this.ChecktextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ChecktextBox.Name = "ChecktextBox";
			this.ChecktextBox.Size = new System.Drawing.Size(192, 22);
			this.ChecktextBox.TabIndex = 9;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(290, 33);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(58, 22);
			this.numericUpDown1.TabIndex = 10;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.Orderbutton_Click);
			// 
			// ProductNametextBox
			// 
			this.ProductNametextBox.Location = new System.Drawing.Point(106, 33);
			this.ProductNametextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ProductNametextBox.Name = "ProductNametextBox";
			this.ProductNametextBox.Size = new System.Drawing.Size(79, 22);
			this.ProductNametextBox.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton3);
			this.panel1.Controls.Add(this.radioButton4);
			this.panel1.Controls.Add(this.radioButton5);
			this.panel1.Location = new System.Drawing.Point(373, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(74, 100);
			this.panel1.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.radioButton7);
			this.panel2.Controls.Add(this.radioButton8);
			this.panel2.Controls.Add(this.radioButton9);
			this.panel2.Controls.Add(this.radioButton10);
			this.panel2.Controls.Add(this.radioButton11);
			this.panel2.Location = new System.Drawing.Point(453, 33);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(81, 97);
			this.panel2.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 235);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 12);
			this.label7.TabIndex = 15;
			this.label7.Text = "訂單內容";
			// 
			// Sendbutton
			// 
			this.Sendbutton.Location = new System.Drawing.Point(185, 288);
			this.Sendbutton.Name = "Sendbutton";
			this.Sendbutton.Size = new System.Drawing.Size(75, 23);
			this.Sendbutton.TabIndex = 16;
			this.Sendbutton.Text = "訂單送出";
			this.Sendbutton.UseVisualStyleBackColor = true;
			this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 17;
			this.label8.Text = "店名";
			// 
			// ShopNametextBox
			// 
			this.ShopNametextBox.Location = new System.Drawing.Point(11, 32);
			this.ShopNametextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ShopNametextBox.Name = "ShopNametextBox";
			this.ShopNametextBox.Size = new System.Drawing.Size(79, 22);
			this.ShopNametextBox.TabIndex = 18;
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 421);
			this.Controls.Add(this.ShopNametextBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Sendbutton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ProductNametextBox);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.ChecktextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Orderbutton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PricetextBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "OrderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OederForm";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PricetextBox;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton10;
		private System.Windows.Forms.RadioButton radioButton11;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Orderbutton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ChecktextBox;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox ProductNametextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Sendbutton;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox ShopNametextBox;
	}
}