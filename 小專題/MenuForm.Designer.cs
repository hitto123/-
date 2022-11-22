namespace 小專題
{
	partial class MenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.panelProduct = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panelMenu.Controls.Add(this.iconButton3);
			this.panelMenu.Controls.Add(this.iconButton2);
			this.panelMenu.Controls.Add(this.iconButton1);
			this.panelMenu.Controls.Add(this.panelProduct);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(147, 490);
			this.panelMenu.TabIndex = 2;
			// 
			// iconButton3
			// 
			this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton3.FlatAppearance.BorderSize = 0;
			this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Cube;
			this.iconButton3.IconColor = System.Drawing.Color.RosyBrown;
			this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton3.Location = new System.Drawing.Point(0, 340);
			this.iconButton3.Margin = new System.Windows.Forms.Padding(2);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
			this.iconButton3.Size = new System.Drawing.Size(147, 126);
			this.iconButton3.TabIndex = 3;
			this.iconButton3.Text = "訂單紀錄";
			this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton3.UseVisualStyleBackColor = true;
			this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
			// 
			// iconButton2
			// 
			this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Cube;
			this.iconButton2.IconColor = System.Drawing.Color.RosyBrown;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton2.Location = new System.Drawing.Point(0, 214);
			this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
			this.iconButton2.Size = new System.Drawing.Size(147, 126);
			this.iconButton2.TabIndex = 2;
			this.iconButton2.Text = "管理店家";
			this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton2.UseVisualStyleBackColor = true;
			this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
			// 
			// iconButton1
			// 
			this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cube;
			this.iconButton1.IconColor = System.Drawing.Color.RosyBrown;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.Location = new System.Drawing.Point(0, 87);
			this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
			this.iconButton1.Size = new System.Drawing.Size(147, 127);
			this.iconButton1.TabIndex = 1;
			this.iconButton1.Text = "菜單";
			this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton1.UseVisualStyleBackColor = true;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// panelProduct
			// 
			this.panelProduct.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelProduct.Location = new System.Drawing.Point(0, 0);
			this.panelProduct.Margin = new System.Windows.Forms.Padding(2);
			this.panelProduct.Name = "panelProduct";
			this.panelProduct.Size = new System.Drawing.Size(147, 87);
			this.panelProduct.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(147, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(705, 490);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 490);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panelMenu);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(868, 529);
			this.MinimumSize = new System.Drawing.Size(868, 529);
			this.Name = "MenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MenuForm";
			this.panelMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelMenu;
		private FontAwesome.Sharp.IconButton iconButton2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private System.Windows.Forms.Panel panelProduct;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private FontAwesome.Sharp.IconButton iconButton3;
	}
}