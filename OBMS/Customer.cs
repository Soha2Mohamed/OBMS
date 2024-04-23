using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class Customer : User
	{
		private List<Book> shoppingCart;
		private List<Order> orders;

		public Customer(string username, string password) : base(username, password)
		{
			
		
			shoppingCart = new List<Book>();
			orders = new List<Order>();
		}
		public void AddToCart(Book book)
        {
            shoppingCart.Add(book);

        }
       // public void AddOrder(Order order) { }
		public void RemoveFromCart(string title)
		{
			Book bookToRemove = shoppingCart.FirstOrDefault(b => b.Title == title);
			if(bookToRemove != null)
			{
				shoppingCart.Remove(bookToRemove);
			}
			else
			{
				Console.WriteLine("the book is not found in the shopping cart");
			}
		}
		public Order CheckOut()
		{
			//create a new order
			Order order = new Order();

			//add books in shopping cart in the order
			foreach(Book book in shoppingCart)
			{
				order.AddBook(book);
			}

			//calculate price
			double totalPrice = shoppingCart.Sum(p => p.Price);
			order.TotalPrice = totalPrice;

			//clear shopping cart
			shoppingCart.Clear();

			//add order to customer list of orders
			orders.Add(order);

			return order;

		}
	}

}
