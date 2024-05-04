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
		// Set the role of the admin
		UserR = UserRole.Admin;
	}

	public void AddBook(Book book)
	{
		inventory.AddBook(book, this); // Pass the admin object to perform allow adding
	}

	public void RemoveBook(int id)
	{
		inventory.RemoveBook(id, this); 
	}

	public void UpdateBookDetails()
	{
		// Implement update book details functionality
	}
}
