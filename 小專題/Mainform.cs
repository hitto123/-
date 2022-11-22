using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using 小專題.Model;

namespace 小專題
{
	public partial class Mainform : Form
	{
		private ProductIndexVM[] products = null;
		public Mainform()
		{
			InitializeComponent();
			InitForm();

			DisplayProducts();
		}
		private void InitForm()
		{
			drinkcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM Addshop ORDER BY DISPLAYORDER";
			var dbHelper = new SqlDbHelper("default");

			List<ProductCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				.Prepend(new ProductCategoryVM { Id = 0, ShopName = String.Empty })
				.ToList();

			this.drinkcomboBox.DataSource = categories;
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



		private void DisplayProducts()
		{
			string sql = @"select p.ID, a.ShopName, p.ProductName, p.Listprice　from Product p  join Addshop a on p.CategoryId = a.ID
";
			SqlParameter[] parameters = new SqlParameter[] { };

			int categoryId = ((ProductCategoryVM)drinkcomboBox.SelectedItem).Id;

			if (categoryId > 0)
			{
				sql += " WHERE CategoryId=@CategoryId ";
				parameters = new SqlParameterBuilder()
					.AddInt("CategoryId", categoryId)
					.Build();
			}


			sql += " ORDER BY  a.DISPLAYORDER";
			var dbHelper = new SqlDbHelper("default");

			products = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();
			BindData(products);
		}
		

		private void BindData(ProductIndexVM[] products)
		{
			productdataGridView.DataSource = products;
		}

		private ProductIndexVM ParseToIndexVM(DataRow row)
		{
			return new ProductIndexVM
			{
				ID = row.Field<int>("Id"),
				ShopName = row.Field<string>("ShopName"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice"),
			};
		}
		
		

		private void searchbutton_Click_1(object sender, EventArgs e)
		{
			DisplayProducts();
		}

		//private void productdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		//{
		//	int rowIndx = e.RowIndex;

		//	if (rowIndx < 0) return;

		//	ProductIndexVM row = this.products[rowIndx];

		//	int id = row.ID;
		//	var frm = new EditProductForm(id);

		//	if (frm.ShowDialog() == DialogResult.OK)
		//	{
		//		DisplayProducts();
		//	}
		//}

		private void addbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateProduct();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

		private void productdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			ProductIndexVM row = this.products[rowIndx];

			int id = row.ID;
			var frm = new EditProductForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}
			
		}
	}
}
