using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using 小專題.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace 小專題
{
	public partial class OrderForm : Form
	{
		
		private string[] totalPrice = null;
		public OrderForm(string[] totalPrice)
		{
			InitializeComponent();
		
			this.totalPrice = totalPrice;
			ProductNametextBox.Text = totalPrice[0];
			PricetextBox.Text = totalPrice[1];
			ShopNametextBox.Text=totalPrice[2];

		}

		private void ProductNametextBox_TextChanged(object sender, EventArgs e)
		{
			

		}
	

		private void label6_Click(object sender, EventArgs e)
		{
		}
		


		private void Orderbutton_Click(object sender, EventArgs e)
		{
			

			Double Price = double.Parse(PricetextBox.Text);

			Double Number = (double)numericUpDown1.Value;
			Double Sum = Number * Price;
			//ALLtextBox.Text = Sum.ToString(); 

			RadioButton[] controls = new RadioButton[] { radioButton1, radioButton2, radioButton3,
			radioButton4,radioButton5,radioButton7};

			string value = string.Empty;
			foreach (RadioButton item in controls)
			{
				if (item.Checked == true)
				{
					value = item.Tag.ToString();
					break;
				}
				
			}


			RadioButton[] controls2 = new RadioButton[] { radioButton7, radioButton8, radioButton9,
			radioButton10,radioButton11};
			string value2 = string.Empty;
			foreach (RadioButton item in controls2)
			{
				if (item.Checked == true)
				{
					value2 = item.Tag.ToString();
					break;
				}
			}
			ChecktextBox.Text = ProductNametextBox.Text + value.ToString() + value2.ToString()+"*"+Number + "  "+Sum +"元";

		}

		private void Sendbutton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("你確認餐點都正確嗎?",
						"送出訂單",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
			}	
			
			
			string Ordername= ShopNametextBox.Text;
			string productname = ChecktextBox.Text;
			string shopname = ShopNametextBox.Text;

			string sql = @"INSERT INTO Ordercode(Ordername,ProductName,OrderTime)" +
				"VALUES(@Ordername,@ProductName,@OrderTime)";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("@Ordername",50, shopname)
				.AddNVarchar("@ProductName", 50, productname)
				.AddDateTime("@OrderTime", DateTime.Now)
				.Build();
			
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			this.DialogResult = DialogResult.OK;
			Close();


		}
	}
}
