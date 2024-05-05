using System;

namespace OBMS // assuming OBMS is your namespace
{
	class Program
	{
		static void Main(string[] args)
		{
			Inventory inventory = new Inventory();
			Admin admin = new Admin("admin", "admin123");
			Customer[] customers =
			{
				new Customer("user1","1234"),
				new Customer("user2", "4567"),
				new Customer("user3", "7890")
			};
			Book[] books =
			{
				new Book("Multicore and GPU programming", "Gerassimos Barlas",1, 29.99, 5),
				new Book("Python for Beginners", "Jane Smith", 2,19.99,10),
				new Book("C++ Programming", "Alice Johnson",3, 34.99,0),
				new Book("Data Structures in Java", "Bob Wilson",4, 27.99,1),
				new Book("JavaScript Fundamentals", "Mary Brown",5, 24.99,9),
				new Book("SQL Essentials", "David Davis",6, 22.99,11),
				new Book("Algorithms and Complexity", "Eva Evans",7, 39.99, 5),
				new Book("Web Development with React", "Frank Lee",8, 29.99,15),
				new Book("Artificial Intelligence", "Grace Adams",9, 44.99,6),
				new Book("Machine Learning Basics", "Henry Harris",10, 36.99,3)
			};

			for (int i = 0; i < books.Length; i++)
			{
				inventory.AddBook(books[i], admin);
			}

			// Simulate purchases and orders
			Console.WriteLine("\nSimulating purchases and orders...");
			Order[] orders = new Order[customers.Length];
			for (int i = 0; i < customers.Length; i++)
			{
				orders[i] = new Order(customers[i]);
				orders[i].AddBook(books[i * 2]);
				orders[i].AddBook(books[i * 2 + 1]);
				orders[i].completeOrder();
			}

			inventory.UpdateStockStatus();
			Console.WriteLine("the updated books in inventory are: ");
			for (int i = 0; i < books.Length; i++)
			{
				Console.WriteLine("${0}-> {1}", books[i].Title, books[i].StockStatus);
                Console.WriteLine("------");
            }
		}
	}
}
