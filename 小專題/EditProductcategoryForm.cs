using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 小專題.Infra;

namespace 小專題
{
	public partial class EditProductcategoryForm : Form
	{
		private int id;
		public EditProductcategoryForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM Addshop WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				this.Close();
				return;
			}
			DataRow row = data.Rows[0];
			categoryNameTextBox.Text=row.Field<string>("ShopName");
			displayOrderTextBox.Text = row.Field<int>("DisplayOrder").ToString();
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string shopName = categoryNameTextBox.Text;
			int displayOrder = displayOrderTextBox.Text.ToInt(-1);

			string sql = "UPDATE Addshop SET ShopName=@ShopName,DisplayOrder=@DisplayOrder WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("ShopName", 50, shopName)
				.AddInt("DisplayOrder", displayOrder)
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("確定要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql = @"DELETE FROM Addshop WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
