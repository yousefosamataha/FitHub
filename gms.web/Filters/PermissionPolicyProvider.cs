using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace gms.web.Filters;

public class PermissionPolicyProvider : IAuthorizationPolicyProvider
{
    public DefaultAuthorizationPolicyProvider FallBackPolicyProvider { get; }

    public PermissionPolicyProvider(IOptions<AuthorizationOptions> options)
    {
        FallBackPolicyProvider = new DefaultAuthorizationPolicyProvider(options);
    }
    public async Task<AuthorizationPolicy> GetDefaultPolicyAsync()
    {
        return await FallBackPolicyProvider.GetDefaultPolicyAsync();
    }

    public async Task<AuthorizationPolicy?> GetFallbackPolicyAsync()
    {
        return await FallBackPolicyProvider.GetFallbackPolicyAsync();
    }

    public Task<AuthorizationPolicy?> GetPolicyAsync(string policyName)
    {
        if (policyName.StartsWith(PermissionsConstants.Permissions, StringComparison.OrdinalIgnoreCase))
        {
            AuthorizationPolicyBuilder policy = new();
            policy.AddRequirements(new PermissionRequirement(policyName));
            return Task.FromResult(policy.Build());
        }
        return FallBackPolicyProvider.GetPolicyAsync(policyName);
    }
}
