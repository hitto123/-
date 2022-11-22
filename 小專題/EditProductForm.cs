using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using 小專題.Infra;
using 小專題.Model;

namespace 小專題
{
	public partial class EditProductForm : Form
	{
		private int id;
		public EditProductForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}
		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM Product WHERE ID=@ID";
			var parameters = new SqlParameterBuilder()
				.AddInt("ID", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			if (data.Rows.Count == 0)
			{
				MessageBox.Show("找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				return;
			}
			ProductVM model = ToProductVM(data.Rows[0]);
			categoryIdComboBox.SelectedItem = ((List<ProductCategoryVM>)categoryIdComboBox.DataSource)
												.FirstOrDefault(x => x.Id == model.CategoryID);
			productNameTextBox.Text = model.ProductName;
			listPriceTextBox.Text = model.ListPrice.ToString();


		}
		private ProductVM ToProductVM(DataRow row)
		{
			return new ProductVM
			{
				ID = row.Field<int>("Id"),
				CategoryID = row.Field<int>("CategoryID"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice")
			};
		}

		private void InitForm()
		{
			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM Addshop ORDER BY DisplayOrder";
			var dbHelper = new SqlDbHelper("default");

			List<ProductCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				.ToList();

			this.categoryIdComboBox.DataSource = categories;
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

		private void EditProductForm_Load_1(object sender, EventArgs e)
		{

		}

		private void categoryIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			int categoryId = ((ProductCategoryVM)this.categoryIdComboBox.SelectedItem).Id;
			string productName = productNameTextBox.Text;
			int listPrice = listPriceTextBox.Text.ToInt(-1);

			ProductVM model = new ProductVM
			{
				CategoryID = categoryId,
				ProductName = productName,
				ListPrice = listPrice
			};

			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "商品名必填\r\n";
			if (model.ListPrice < 0) errorMsg += "價格必須大於零\r\n";

			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				
				MessageBox.Show(errorMsg);
				return; 
			}
			string sql = @"UPDATE Product
			SET CategoryId=@CategoryId, ProductName=@ProductName, ListPrice = @ListPrice
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("CategoryId", model.CategoryID)
				.AddNVarchar("ProductName", 50, model.ProductName)
				.AddInt("ListPrice", model.ListPrice)
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

			string sql = @"DELETE FROM Product WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void Orderbutton_Click(object sender, EventArgs e)
		{
			string[] totalPrice = new string[3];
			totalPrice[0] = productNameTextBox.Text;
			totalPrice[1] = listPriceTextBox.Text;
			////////
			totalPrice[2] = categoryIdComboBox.Text;

			var frm = new OrderForm(totalPrice);
			frm.ShowDialog();
			Close();
		

		}
	}
	
}
