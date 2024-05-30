using gms.common.Models.Identity.Role;
using gms.common.Models.IdentityCat.Role;
using gms.data.Models.Identity;


namespace gms.data.Mapper.Identity;
public static class GymRoleMapper
{
	public static GymIdentityRoleEntity ToEntity(this CreateGymRoleDTO source, int branchId)
	{
        string roleName = $"{branchId}_{source.RoleName}";
        return new GymIdentityRoleEntity()
		{
			Name = roleName,
			NormalizedName = roleName.ToUpper(),
			IsDeleteable = true,
			IsUpdateable = true
		};
	}
	public static GymRoleDTO ToDTO(this GymIdentityRoleEntity source)
	{
		return new GymRoleDTO()
		{
			RoleId = source.Id,
			RoleName = source.Name.Split("_")[1]
		};
	}

    public static GymIdentityRoleEntity ToUpdateEntity(this UpdateGymRoleDTO source, GymIdentityRoleEntity entity)
    {
        entity.Name = source.RoleName;
		entity.NormalizedName = source.RoleName.ToUpper();

		return entity;
    }
}
