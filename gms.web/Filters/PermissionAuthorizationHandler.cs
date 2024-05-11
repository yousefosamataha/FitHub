using gms.common.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace gms.web.Filters;

public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
	public PermissionAuthorizationHandler()
	{

	}
	protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
	{
		if (context.User is null)
			return;

		bool canAccess = context.User.Claims.Any(c =>
														string.Equals(c.Type, PermissionsConstants.Permission, StringComparison.OrdinalIgnoreCase) &&
														string.Equals(c.Value, requirement.Permission, StringComparison.OrdinalIgnoreCase) &&
														c.Issuer == "LOCAL AUTHORITY"
												);

		if (canAccess)
		{
			context.Succeed(requirement);
			return;
		}
	}
}
