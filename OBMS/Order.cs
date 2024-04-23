using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class Order
	{
		
		private Customer cus;
		private List<Book> books = new List<Book>();
        public Order()
        {
            
        }

		public int OrderId { get; set; }
		public double TotalPrice { get; set; }
		public string OrderDate { get; set; }
		/*public double CalculateTotalPrice()
		{
			double localPrice =0.0;
			for(int i = 0;i < books.Count; i++)
			{
				localPrice += books[i].Price;
			}
			return localPrice;
		}*/

		internal void AddBook(Book book)
		{
			books.Add(book);
		}
	}
}
