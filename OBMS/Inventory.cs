using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class Inventory
	{
		public Inventory() { }	
		private Book[] books = new Book[0];
		public Book[] Books { get {  return books; } }
		
	}
}
