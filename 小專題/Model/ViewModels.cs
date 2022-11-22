using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小專題.Model
{
	public class ViewModels
	{
		public class ProductIndexVM
		{
			public int Id { get; set; }
			public string ShopName { get; set; }
			public string ProductName { get; set; }
			public int ListPrice { get; set; }
		}
		public class ProductVM
		{
			public int Id { get; set; }
			public int ShopName { get; set; }
			public string ProductName { get; set; }
			public int ListPrice { get; set; }
		}

	}
}
