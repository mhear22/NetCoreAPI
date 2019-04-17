using System;
using CoreApp.Models.Repositories;

namespace CoreApp.Models.Authentication
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
			if(model == null) { return null;}
			return new TokenModel()
			{
				UserId = model.UserId,
				SetTime = model.SetTime
			};
		}
	}
}