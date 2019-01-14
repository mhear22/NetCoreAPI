using CoreApp.Models.Repositories;

namespace CoreApp.Models.Authentication
{
	public class UserModel
	{
		public string Id;
		public string Username;
		public string EmailAddress;
		public string ImageId { get; set; }
		public string PaymentPlanId { get; set; }
	}
	
	public static class UserModelExtentions
	{
		public static UserModel ToModel(this UserDto dto)
		{
			if(dto == null) { return null; }
			return new UserModel()
			{
				Id = dto.Id,
				Username = dto.Username,
				EmailAddress = dto.EmailAddress,
				ImageId = dto.ImageId,
				PaymentPlanId = dto.PaymentPlanId
			};
		}
		
		public static UserDto ToDTO(this UserModel model)
		{
			if(model == null) { return null; }
			return new UserDto()
			{
				Id = model.Id,
				Username = model.Username,
				EmailAddress = model.EmailAddress,
				ImageId = model.ImageId,
				PaymentPlanId = model.PaymentPlanId
			};
		}
	}
}