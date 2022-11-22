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

namespace 小專題
{
	public partial class ProductCategoriesForm : Form
	{
		DataTable categories;
		public ProductCategoriesForm()
		{
			InitializeComponent();
			Displayproductcategories();
		}

		private void Displayproductcategories()
		{
			string sql = "SELECT * FROM Addshop ORDER BY id";
			categories =new SqlDbHelper("default").Select(sql,null);
			BindData(categories);
			
		}

		private void BindData(DataTable model)
		{
			dataGridView1.DataSource =model;
		}

		private void addbutton_Click(object sender, EventArgs e)
		{
			var frm = new Createproductcategory();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				Displayproductcategories();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex=e.RowIndex;
			if (rowIndex < 0) return;
			DataRow row = this.categories.Rows[rowIndex]; 
			int id = row.Field<int>("Id");
			var frm = new EditProductcategoryForm(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				Displayproductcategories();
			}
		}
	}
}
