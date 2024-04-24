using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class Admin : User
	{
		/* Admin Class (Inherits from User):
            Additional Methods: AddBook, RemoveBook, UpdateBookDetails
           Inventory Class:
            Properties: List of Books, StockStatus
            Methods: AddBookToInventory, RemoveBookFromInventory, UpdateStockStatus
           BookstoreManager Class:
            Properties: Inventory, Users, Orders
            Methods: InitializeInventory, RegisterUser, ProcessOrder
		*/
		Inventory inventory = new Inventory();
        public Admin(string username, string password) : base(username, password)
		{
            
        }
        public void AddBook(Book book)
        {
			inventory.addBook(book);
        }
		public void RemoveBook(int id)
		{
			inventory.removeBook(id);
		}
		public void UpdateBookDetails()
		{

		}
	}
}
