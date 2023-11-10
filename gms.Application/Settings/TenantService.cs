using gms.Application.Contracts.Settings;
using gms.shared.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace gms.Application.Settings;
public class TenantService : ITenantService
{

    private readonly TenantSettings _tenantSettings;

    private HttpContext? _httpContext;

    private Tenant? _currentTenant;

    public TenantService(IHttpContextAccessor ContextAccessor, IOptions<TenantSettings> tenantSettings)
    {
        _httpContext = ContextAccessor.HttpContext;
        _tenantSettings = tenantSettings.Value;

        if (_httpContext is not null)
        {
            if (_httpContext.Request.Headers.TryGetValue("__tenant", out var tenantName))
            {
                SetCurrentTenant(tenantName!);
            }
            else
                throw new Exception("No Tenant Provided!");
        }
    }

    public string? GetConnectionString()
    {
        string currentConnectionString = _currentTenant is null ?
                                         _tenantSettings.Defaults.ConnectionString :
                                         _currentTenant.ConnectionString;
        return currentConnectionString;
    }

    public Tenant? GetCurrentTenant()
    {
        return _currentTenant;
    }

    public string? GetDatabaseProvider()
    {
        return _tenantSettings.Defaults.DBProvider;
    }

    private void SetCurrentTenant(string tenantName)
    {
        _currentTenant = _tenantSettings.Tenants.FirstOrDefault(t => t.Name == tenantName);

        if (_currentTenant is null)
        {
            throw new Exception("Invalid TenantId");
        }
        _currentTenant.ConnectionString = string.IsNullOrWhiteSpace(_currentTenant.ConnectionString) ?
                                          _tenantSettings.Defaults.ConnectionString :
                                          _currentTenant.ConnectionString;
    }
}
