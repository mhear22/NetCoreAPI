using System;
using dotapi.Models.Repositories;
using dotapi.Repositories;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace dotapi.Services
{
	public interface IPasswordService
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
			var row = Context.passwords
				.Where(x=>x.UserId == UserId)
				.OrderByDescending(x=>x.DateSet)
				.FirstOrDefault();
				
			var hash = HashPassword(Password + row.Id);
			
			return hash == row.Hash;
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
			
			Context.passwords.Add(row);
			Context.SaveChanges();
		}
		
		private string HashPassword(string Password)
		{
			var bytes = Encoding.UTF8.GetBytes(Password);
			var hash = SHA256.Create().ComputeHash(bytes);
			var hashString = "";
			foreach(var x in hash)
			{
				hashString += String.Format("{0:x2}", x);
			}
			return hashString;
		}
	}
}