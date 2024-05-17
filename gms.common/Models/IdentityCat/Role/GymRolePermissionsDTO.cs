using gms.common.Models.SharedCat;

namespace gms.common.Models.Identity.Role;

public sealed record GymRolePermissionsDTO
{
	public int RoleId { get; init; }
	public string RoleName { get; init; }
	public List<SelectItemDTO> Permissions { get; init; }
}
