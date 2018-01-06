using System;
using CoreApp.Models.Repositories;
using CoreApp.Repositories;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace CoreApp.Services
{
	public interface IPasswordService
	{
		void SetPassword(string UserId, string Password);
		bool CheckPassword(string UserId, string Password);
	}
	
	public class PasswordService : ServiceBase, IPasswordService 
	{
		private IRepository<PasswordDto> _passwordRepo;
		public PasswordService(IContext context, IRepository<PasswordDto> passwordRepo)
			: base(context)
		{
			this._passwordRepo = passwordRepo;
		}
			
		public bool CheckPassword(string UserId, string Password)
		{
			var row = _passwordRepo
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
			
			_passwordRepo.Create(row);
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