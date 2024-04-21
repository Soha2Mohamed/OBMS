using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class Order
	{
		private int orderId;
		private Customer cus;
		private Book[] books;
		private double totalPrice;
		private string orderDate;

        public Order()
        {
            
        }

		public int OrderId { get { return orderId; } set { orderId = value; } }
		public double TotalPrice { get { return totalPrice; } set { totalPrice = value; } }
		public string OrderDate { get { return orderDate; } set { orderDate = value; } }
		public double CalculateTotalPrice()
		{
			double localPrice =0.0;
			for(int i = 0;i < books.Length; i++)
			{
				localPrice += books[i].Price;
			}
			return localPrice;
		}

	}
}
