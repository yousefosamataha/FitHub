using System.ComponentModel.DataAnnotations;

namespace gms.common.Models.Role;

public sealed class CreateGymRoleDTO
{
    [Required, StringLength(256)]
    public string RoleName { get; set; }
}
