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
	public partial class Createproductcategory : Form
	{
		public Createproductcategory()
		{
			InitializeComponent();

		}

		private void addbutton_Click(object sender, EventArgs e)
		{
			string shopname = ShopNametextBox.Text;
			int displayOrder = displayOrderTextBox.Text.ToInt(-1);
			string sql = @"INSERT INTO Addshop(ShopName, DisplayOrder)
							VALUES(@ShopName, @DisplayOrder)";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("ShopName",50,shopname)
				.AddInt("DisplayOrder", displayOrder)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;


		}
	}
}
