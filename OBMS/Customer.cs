using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class Customer : User
	{
		private Book[] shoppingCart;
		private Order[] orders;

        public Customer()
        {
            
        }
        public void AddToCart(Book book)
        {
            shoppingCart[shoppingCart.Length +1] = book;

        }
        public void AddOrder(Order order) { }
		public void RemoveFromCart(string title)
		{
			for (int i = 0;i < shoppingCart.Length;i++)
			{
				if (shoppingCart[i].Title == title) { }//shoppingCart[i]; }
			}
		}
		public double CheckOut()
		{
			double localPrice =0;
			for (int i = 0; i < shoppingCart.Length; i++)
			{
				localPrice += shoppingCart[i].Price;
			}
			return localPrice;
		}
	}

}
