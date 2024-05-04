internal class Inventory
{
	private List<Book> books;

	public Inventory()
	{
		books = new List<Book>();
	}

	public void AddBook(Book book, User user)
	{
		if (user.UserR == User.UserRole.Admin)
		{
			books.Add(book);
		}
		else
		{
			Console.WriteLine("Only admins can add books to the inventory.");
		}
	}

	public void RemoveBook(int id, User user)
	{
		if (user.UserR == User.UserRole.Admin)
		{
			books.RemoveAt(id);
		}
		else
		{
			Console.WriteLine("Only admins can remove books from the inventory.");
		}
	}

	public void UpdateStockStatus()
	{
		foreach (Book book in books)
		{
			if (book.QuantityAvailable == 0)
			{
				book.StockStatus = "Out of Stock";
			}
			else if (book.QuantityAvailable <= 5)
			{
				book.StockStatus = "Low in stock";
			}
			else
			{
				book.StockStatus = book.QuantityAvailable.ToString();
			}
		}
	}
}
