using gms.common.Models.SharedCat;

namespace gms.common.Models.Role;

public sealed class GymUserRolesDTO
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public List<SelectItemDTO> Roles { get; set; }
}
