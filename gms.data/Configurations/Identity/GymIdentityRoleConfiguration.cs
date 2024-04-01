using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Identity;
internal class GymIdentityRoleConfiguration : IEntityTypeConfiguration<GymIdentityRoleEntity>
{
    public void Configure(EntityTypeBuilder<GymIdentityRoleEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymRole", gmsDbProperties.DbSchema);
        
        //builder.HasData(GetSystemRoles());
    }
    public List<GymIdentityRoleEntity> GetSystemRoles()
    {
        List<GymIdentityRoleEntity> roles = new();
        foreach (var role in Enum.GetValues(typeof(RolesEnum)))
        {
            GymIdentityRoleEntity newRole = new()
            {
                Id = (int)role,
                Name = role.ToString(),
                NormalizedName = role.ToString().ToUpper()
            };
            roles.Add(newRole);
        };
        return roles;
    }
}
