internal class Book
{
	public string Title { get; set; }
	public string Author { get; set; }
	public int ISBN { get; set; }
	public double Price { get; set; }
	public int QuantityAvailable { get; set; }

	public Book() { }

	public Book(string title, string author, int isbn, double price, int quantityAvailable)
	{
		Title = title;
		Author = author;
		ISBN = isbn;
		Price = price;
		QuantityAvailable = quantityAvailable;
	}

	public string DisplayDetails()
	{
		return $"Book Name: {Title}, Author: {Author}, Price: {Price}, Quantity Available: {QuantityAvailable}";
	}

	public override string ToString()
	{
		return DisplayDetails();
	}
}
