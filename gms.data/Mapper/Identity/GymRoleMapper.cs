using gms.common.Models.Role;
using gms.data.Models.Identity;


namespace gms.data.Mapper.Identity;
public static class GymRoleMapper
{
    public static GymIdentityRoleEntity ToEntity(this CreateGymRoleDTO source)
    {
        return new GymIdentityRoleEntity()
        {
             Name = source.RoleName,
             NormalizedName = source.RoleName.ToUpper()
        };
    }
    public static GymRoleDTO ToDTO(this GymIdentityRoleEntity source)
    {
        return new GymRoleDTO()
        {
             RoleId = source.Id,
             RoleName = source.Name,
        };
    }
}
