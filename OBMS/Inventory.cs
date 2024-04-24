using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class Inventory
	{
		
		private List<Book> books;
        public Inventory()
        {
            books  = new List<Book>();
        }
		public void addBook(Book book)
		{
			books.Add(book);
		}
        public List<Book> getAllBooks()
		{
			return books;
		}

		internal void removeBook(int id)
		{
			books.RemoveAt(id);
		}
		public void UpdateStockStatus()
		{
				foreach (Book book in books)
				{
					if (book.QuantityAvailable == 0)
					{
						book.StockStatus = "Out of Stock";
					}
					else if(book.QuantityAvailable <= 5)
				    {
					    book.StockStatus = "Low in stock";
				    }
					else { book.StockStatus = book.QuantityAvailable.ToString();}
				
				}
		}
	}
}
