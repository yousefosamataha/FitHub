using gms.common.Models.SharedCat;

namespace gms.common.Models.Identity.Role;

public sealed record GymUserRolesDTO
{
    public int UserId { get; init; }
    public string UserName { get; init; }
    public string Email { get; init; }
    public List<SelectItemDTO> Roles { get; init; }
}