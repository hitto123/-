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
using 小專題.Model;

namespace 小專題
{
	public partial class CreateProduct : Form
	{
		public CreateProduct()
		{
			InitializeComponent();
			InitForm();
		}
		private void InitForm()
		{
			categoryIdcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM Addshop ORDER BY ID";
			var dbHelper = new SqlDbHelper("default");

			List<ProductCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				.ToList();

			this.categoryIdcomboBox.DataSource = categories;
		}
		private ProductCategoryVM ToCategoryVM(DataRow row)
		{
			return new ProductCategoryVM
			{
				Id = row.Field<int>("Id"),
				ShopName = row.Field<string>("ShopName"),
				DisplayOrder = row.Field<int>("DisplayOrder")

			};
		}

		private void Addbutton_Click(object sender, EventArgs e)
		{
			int categoryId = ((ProductCategoryVM)this.categoryIdcomboBox.SelectedItem).Id;
			string productName = productNametextBox.Text;
			int listPrice = listpricetextBox.Text.ToInt(-1);
			ProductVM model = new ProductVM
			{
				CategoryID = categoryId,
				ProductName = productName,
				ListPrice = listPrice
			};
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "飲料名字一定要填\r\n";
			if (model.ListPrice < 0) errorMsg += "價格一定要大於零\r\n";

			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				MessageBox.Show(errorMsg);
				return;
			}
			string sql = @"INSERT INTO Product (CategoryId,ProductName, ListPrice)
							VALUES(@CategoryId,@ProductName, @ListPrice)";
			var parameters = new SqlParameterBuilder()
				.AddInt("CategoryId", model.CategoryID)
				.AddNVarchar("ProductName", 50, model.ProductName)
				.AddInt("ListPrice", model.ListPrice)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;

		}
	}
}
