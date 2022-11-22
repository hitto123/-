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
	public partial class MenuForm : Form
	{
		public MenuForm()
		{
			InitializeComponent();
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			var frm=new Mainform();
			frm.Show();
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			var frm = new ProductCategoriesForm();
			frm.Show();
		}

		private void iconButton3_Click(object sender, EventArgs e)
		{
			var frm = new checkoutForm();
			frm.Show();
		}
	}
}
