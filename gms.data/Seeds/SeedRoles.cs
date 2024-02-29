using gms.common.Enums;
using Microsoft.AspNetCore.Identity;

namespace gms.data.Seeds;

public static partial class Seeds
{
    public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManger)
    {
        if (!roleManger.Roles.Any())
        {
            foreach (var role in Enum.GetValues(typeof(RolesEnum)))
            {
                await roleManger.CreateAsync(new IdentityRole(role.ToString()));
            }
        }
    }
}
