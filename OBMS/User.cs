internal class User
{
	//private string userName;
	//private string password;
	//private string email;
	//private bool isLogged = false;

	public string UserName { get; set; }
	public string Password { get; set; }
	public string Email { get; set; }
	public bool IsLogged { get; set; }

	public User(string username, string password)
	{
		this.UserName = username;
		this.Password = password;
		IsLogged = false;	
	}

	public bool LogIn(string username, string password)
	{
		if (UserName == username && Password == password)
		{
			IsLogged = true;
			return true;
		}
		return false;
	}

	public void LogOut()
	{
		IsLogged = false;
	}

	public bool UpdateProfile(string newUsername, string newPassword, string newEmail)
	{
		Console.WriteLine("Are you sure you want to update your profile? Press 'y' if you are sure and 'n' if not");

		//I used Console.ReadKey() because it doesn't require the user to press Enter so it's good gor interactivity
		//Also KeyChar property is used to extract the unicode character from the input (without shift, ctrl,...)
		char sure = Console.ReadKey().KeyChar;
		Console.WriteLine();
		if (sure == 'y')
		{
			UserName = newUsername;
			Password = newPassword;
			Email = newEmail;
			return true;
		}
		return false;
	}
}
