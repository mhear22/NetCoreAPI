using System.Collections.Generic;

namespace dotapi.Repositories
{
	public class ConnectionBuilder
	{
		private string username;
		private string password;
		private string address = "localhost";
		private string cataloge;
		
		public ConnectionBuilder Password(string Password)
		{
			password = Password;
			return this;
		}
		public ConnectionBuilder User(string Username)
		{
			username = Username;
			return this;
		}
		
		public ConnectionBuilder Address(string Address)
		{
			address = Address;
			return this;
		}
		
		public ConnectionBuilder Database(string Database)
		{
			cataloge = Database;
			return this;
		}
		
		public override string ToString()
		{
			var resultString = "";
			if(!string.IsNullOrWhiteSpace(username))
			{
				resultString += "user id=" + username + ";";
				resultString += "Pwd=" + password + ";";
			}
			resultString += "Server=" + address + ";";
			if(!string.IsNullOrWhiteSpace(cataloge))
				resultString += "Database=" + cataloge + ";";
				
			return resultString;
		}
	}
}