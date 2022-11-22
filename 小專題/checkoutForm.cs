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
using System.Windows.Forms;
using 小專題.Model;
using static 小專題.Model.ViewModels;
using ProductIndexVM = 小專題.Model.ProductIndexVM;

namespace 小專題
{
	public partial class checkoutForm : Form
	{
		private CheckVM[] products = null;

		public checkoutForm()
		{
			InitializeComponent();
			DisplayProducts();
		}

		private void PricetextBox_TextChanged(object sender, EventArgs e)
		{

		}
		private void BindData()
		{
			string sql = "SELECT * FROM Ordercode ORDER BY Id";
			
			var dbHelper = new SqlDbHelper("default");
			products = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToCheckVM(row))
				.ToArray();
		}
		private void DisplayProducts()
		{
			BindData();
			dataGridView1.DataSource = products;
		}

		private CheckVM ParseToCheckVM(DataRow row)
		{
			return new CheckVM
			{
				Id = row.Field<int>("Id"),
				OrderName = row.Field<string>("OrderName"),
				ProductName = row.Field<string>("ProductName"),
				OrderTime = row.Field<DateTime>("OrderTime"),
			};
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
