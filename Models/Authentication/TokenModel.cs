using System;
using dotapi.Models.Repositories;

namespace dotapi.Models.Authentication
{
	public class TokenModel
	{
		public string UserId;
		public DateTime SetTime;
	}
	
	public static class TokenModelExtentions
	{
		public static TokenModel ToModel(this SessionDto model)
		{
			return new TokenModel()
			{
				UserId = model.UserId,
				SetTime = model.SetTime
			};
		}
	}
}