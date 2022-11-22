using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小專題.Model
{
	public class OrderVM
	{
		public int ID { get; set; }
		public int CategoryID { get; set; }
		public string ProductName { get; set; }
		public int ListPrice { get; set; }
	}
}
