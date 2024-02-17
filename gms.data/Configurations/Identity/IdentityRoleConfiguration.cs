using gms.common.Constants;
using gms.common.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Identity;
internal class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".Role", gmsDbProperties.DbSchema);
        builder.HasData(GetSystemRoles());
    }
    public List<IdentityRole> GetSystemRoles()
    {
        List<IdentityRole> roles = new();
        roles.AddRange(new List<IdentityRole>()
        {
            new IdentityRole()
            {
                 Name = RolesEnum.Basic.ToString(),
                 NormalizedName = RolesEnum.Basic.ToString().ToUpper()
            },
            new IdentityRole()
            {
                 Name = RolesEnum.Admin.ToString(),
                 NormalizedName = RolesEnum.Admin.ToString().ToUpper()
            },
            new IdentityRole()
            {
                 Name = RolesEnum.SuperAdmin.ToString(),
                 NormalizedName = RolesEnum.SuperAdmin.ToString().ToUpper()
            }
        });
        return roles;
    }
}
