using gms.common.Settings;

namespace gms.service.Settings;
public interface ITenantService
{
    string? GetDatabaseProvider();
    string? GetConnectionString();
    Tenant? GetCurrentTenant();
}
