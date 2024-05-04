using System;
using System.Collections.Generic;

namespace OBMS
{
	internal class BookstoreManager
	{
		public Inventory Inventory { get; private set; }
		public List<User> Users { get; private set; }
		public List<Order> Orders { get; private set; }
		Admin admin;

		public BookstoreManager()
		{
			Inventory = new Inventory();
			Users = new List<User>();
			Orders = new List<Order>();
		}

		public void InitializeInventory(List<Book> initialBooks)
		{
			foreach (var book in initialBooks)
			{
				Inventory.AddBook(book,admin);
			}
		}

		public void RegisterUser(User user)
		{
			Users.Add(user);
		}
		public void RegisterAdmin(User user)
		{
			admin = new Admin(user.UserName, user.Password);
		}

		public void ProcessOrder(Order order)
		{
			// Perform order processing logic, e.g., updating inventory, sending confirmation emails, etc.
			Orders.Add(order);
		}
	}
}
