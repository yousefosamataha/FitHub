namespace gms.common.Models.IdentityCat.Role;

public record UpdateGymRoleDTO
{
    public int RoleId { get; init; }
    public required string RoleName { get; init; }
}
