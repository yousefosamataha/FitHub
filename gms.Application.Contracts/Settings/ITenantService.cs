using gms.shared.Settings;

namespace gms.Application.Contracts.Settings;
public interface ITenantService
{
    string? GetDatabaseProvider();
    string? GetConnectionString();
    Tenant? GetCurrentTenant();
}
