using dotapi.Actions;
using dotapi.Actions.User;
using dotapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Actions.User
{
	public class GetCurrentUserAction: UserAction
	{
		public GetCurrentUserAction(IUserService userService, IAuthenticationService auth, ICurrentUserService current)
			: base(userService, auth, current)
		{
			AddAction(() => { return Ok(CurrentUser); });
		}
	}
}
