using CoreApp.Services;

namespace CoreApp.Actions.Session
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
			if(!string.IsNullOrWhiteSpace(Id))
				AddAction(() => { 
					var token = authService.Logout(Id);
					return Ok();
				});
			else
				AddAction(() => { return Ok(); });
			
			return this;
		}
	}
}