namespace gms.shared.Settings;

public sealed class Tenant
{
    public Guid TenantId { get; set; }
    public string Name { get; set; } = null!;
    public string ConnectionString { get; set; }
}
