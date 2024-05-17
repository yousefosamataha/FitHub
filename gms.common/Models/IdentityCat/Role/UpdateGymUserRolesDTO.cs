using gms.common.Models.SharedCat;

namespace gms.common.Models.Identity.Role;

public sealed record UpdateGymUserRolesDTO
{
    public string UserEmail { get; init; }

    public List<SelectItemDTO> Roles { get; init; }
}