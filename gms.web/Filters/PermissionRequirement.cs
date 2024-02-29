using Microsoft.AspNetCore.Authorization;

namespace gms.web.Filters;

public class PermissionRequirement : IAuthorizationRequirement
{
    public string Permission { get; private set; }
    public PermissionRequirement(string permission)
    {
        Permission = permission;
    }
}
