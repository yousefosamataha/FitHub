namespace gms.common.Models.Role;

public sealed record GymRoleDTO
{
	public int RoleId { get; init; }
	public required string RoleName { get; init; }
}
