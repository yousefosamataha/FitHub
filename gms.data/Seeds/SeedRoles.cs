using gms.common.Enums;
using Microsoft.AspNetCore.Identity;

namespace gms.data.Seeds;

public static partial class Seeds
{
    public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManger)
    {
        if (!roleManger.Roles.Any())
        {
            await roleManger.CreateAsync(new IdentityRole(RolesEnum.Basic.ToString()));
            await roleManger.CreateAsync(new IdentityRole(RolesEnum.Admin.ToString()));
            await roleManger.CreateAsync(new IdentityRole(RolesEnum.SuperAdmin.ToString()));
        }
    }
}
