using System;
using dotapi.Models.Repositories;
using dotapi.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace dotapi.Services
{
	interface IPasswordService
	{
		void SetPassword(string UserId, string Password);
		bool CheckPassword(string UserId, string Password);
	}
	
	public class PasswordService : ServiceBase, IPasswordService 
	{
		public PasswordService(DatabaseContext context) 
			: base(context) { }
			
		public bool CheckPassword(string UserId, string Password)
		{
			return false;
		}
		
		public void SetPassword(string UserId, string Password)
		{
			var row = new PasswordDto()
			{
				Id = Guid.NewGuid().ToString(),
				UserId = UserId,
				DateSet = DateTime.UtcNow
			};
			
			row.Hash = HashPassword(Password + row.Id);
			
			using(var db = Context)
			{
				db.Passwords.Add(row);
				db.SaveChanges();
			}
		}
		
		private string HashPassword(string Password)
		{
			var bytes = Encoding.UTF8.GetBytes(Password);
			var hash = SHA256.Create().ComputeHash(bytes);
			var hashString = Encoding.UTF8.GetString(hash);
			return hashString;
		}
	}
}