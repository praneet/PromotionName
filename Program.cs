using System;
using System.Data;
using System.Net.Http.Headers;

namespace Promotion
{
	class Program
	{
		static void Main(string[] args)
		{
			var inventory = AddProduct();
			var orderCart = AddTocart();
		}
		public static DataTable AddTocart()
		{
			Console.WriteLine("Please add item to cart");
			bool AddMore = true;
			DataTable dt = new DataTable();
			dt.Columns.Add("CPName");
			dt.Columns.Add("CPQty");
			while (AddMore)
			{
				Console.WriteLine("Enter Product for adding to cart");
				string CPName = Console.ReadLine();
				Console.WriteLine("Enter Quantity of Product");
				int CPQty = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Add more item to cart (True/False)");
				AddMore = Convert.ToBoolean(Console.ReadLine());
				DataRow Cart = dt.NewRow();
				Cart["CPName"] = CPName;
				Cart["CPQty"] = CPQty;
				dt.Rows.Add(Cart);
			}
			return dt;
		}
		public static DataTable AddProduct()
		{
			Console.WriteLine("Enter number of product for inventory");
			int n = Convert.ToInt32(Console.ReadLine());
			DataTable dt = new DataTable();
			dt.Columns.Add("PName");
			dt.Columns.Add("PCost");
			dt.Columns.Add("PDQty");
			dt.Columns.Add("PDcost");
			dt.Columns.Add("PDProd");
			for (int i = 0; i < n; i++)
			{
				int PDCost = 0;
				int PDQty = 0;
				string PDProd = "";
				Console.WriteLine("Enter Product Name");
				string PName = Console.ReadLine();
				Console.WriteLine("Enter Price of Product");
				int PCost = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Is it a combo Product (True/False)");
				bool IsCombo = Convert.ToBoolean(Console.ReadLine());
				if (IsCombo)
				{
					Console.WriteLine("Enter Combo Product");
					PDProd = Console.ReadLine();
					Console.WriteLine("Enter Price of discounted Product");
					PDCost = Convert.ToInt32(Console.ReadLine());
				}
				else
				{
					Console.WriteLine("Enter Quantity for discount of Product");
					PDQty = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter Price of discounted Product");
					PDCost = Convert.ToInt32(Console.ReadLine());
				}
				DataRow product = dt.NewRow();
				product["PName"] = PName;
				product["PCost"] = PCost;
				product["PDQty"] = PDQty;
				product["PDcost"] = PDCost;
				product["PDProd"] = PDProd;
				dt.Rows.Add(product);
			}
			return dt;
		}
	}
}
