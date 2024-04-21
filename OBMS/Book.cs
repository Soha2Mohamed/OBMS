using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class Book
	{
		private string title;
		private string author;
		private int iSBN;
		private double price;
		private int quantityAvailable;

		public Book()
		{

		}

		public string Title
		{
			get { return  title; }
		
			set
			{
				title = value;
			}
		}

		public string Author
		{
			get { return author; }
			
			set { author = value;}
		}
		public int ISBN
		{
			get { return iSBN; }
			set { iSBN = value;}
		}
		public double Price
		{
			get { return price; }
			set { price = value;}
		}
		public int QuantityAvailable
		{
			get { return quantityAvailable; }
			set { quantityAvailable = value; }
		}

		public string DisplayDetails()
		{
			return $"Book Name is: {Title}, Author: {Author } , Price: {Price }, And Quantity Available is:{QuantityAvailable} ";
		}
    }
}
