using dotapi.Services;

namespace dotapi.Actions.Session
{
	public interface ILogoutAction
	{
		LogoutAction Logout(string Id);
	}
	
	public class LogoutAction: ActionBase, ILogoutAction
	{
		private IAuthenticationService authService;
		public LogoutAction(IAuthenticationService authService)
		{
			this.authService = authService;
		}
		public LogoutAction Logout(string Id)
		{
			AddAction(() => {
				var token = authService.Logout(Id);
				return Ok();
			});
			return this;
		}
	}
}