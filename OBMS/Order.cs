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
        public Order(Customer customer)
        {
            cus = customer;
        }

		public int OrderId { get; set; }
		public double TotalPrice { get; set; }
		public string OrderDate { get; set; }
		public double CalculateTotalPrice()
		{
			double localPrice =0.0;
			for(int i = 0;i < books.Count; i++)
			{
				localPrice += books[i].Price;
			}
			return localPrice;
		}

		internal void AddBook(Book book)
		{
			if(book.QuantityAvailable ==0)
			{
                Console.WriteLine("$this book '{0}' is out of stock, sorry",book.Title);
            }
			books.Add(book);
			book.QuantityAvailable--;

		}
		public void completeOrder()
		{
			Console.WriteLine("Order for " + cus.UserName + " is complete.");
			Console.WriteLine("Books purchased:");
			foreach (Book book in books)
			{
				Console.WriteLine("- " + book.Title + " by " + book.Author + " ($" +  book.Price + ")");
			}
			Console.WriteLine("Total: $" +  CalculateTotalPrice());
            Console.WriteLine();
		}

	}
}
