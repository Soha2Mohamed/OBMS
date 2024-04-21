using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBMS
{
	internal class User
	{
		private string userName;
		private string password;
		private string email;

		public string UserName { get { return userName; } set { userName = value; } }
		public string Password { get { return password; } set { password = value; } }
		public string Email { get { return email; } set { email = value; } }
		public User() { }

		public void LogIn()
		{

		}
		public void LogOut()
		{

		}
		public void UpdateProfile()
		{

		}
	}

}
