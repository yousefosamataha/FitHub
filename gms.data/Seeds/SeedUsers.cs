
using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace gms.data.Seeds;

public static partial class Seeds
{
    public static async Task SeedBasicUserAsync(UserManager<GymUserEntity> userManger)
    {
        GymUserEntity defaultUser = new()
        {
            UserName = "basicuser@domain.com",
            Email = "basicuser@domain.com",
            EmailConfirmed = true,
            FirstName = "Basic",
            LastName = "User",
            PhoneNumber = "+201100241976"
        };

        GymUserEntity user = await userManger.FindByEmailAsync(defaultUser.Email);
        if (user is null)
        {
            await userManger.CreateAsync(defaultUser, "P@ssWord123");
            await userManger.AddToRoleAsync(defaultUser, RolesEnum.Basic.ToString());
        }
    }
    public static async Task SeedSuperAdminUserAsync(UserManager<GymUserEntity> userManger, RoleManager<IdentityRole> roleManger)
    {
        GymUserEntity defaulSuperAdminUser = new()
        {
            UserName = "superadmin@domain.com",
            Email = "superadmin@domain.com",
            EmailConfirmed = true,
            FirstName = "super",
            LastName = "admin",
            PhoneNumber = "+201100241976"
        };

        GymUserEntity user = await userManger.FindByEmailAsync(defaulSuperAdminUser.Email);
        if (user is null)
        {
            await userManger.CreateAsync(defaulSuperAdminUser, "P@ssWord123");
            await userManger.AddToRolesAsync(defaulSuperAdminUser, new List<string>() { RolesEnum.Basic.ToString(), RolesEnum.Admin.ToString(), RolesEnum.SuperAdmin.ToString() });
        }
        await roleManger.SeedClaimsForSuperAdminUser();
    }
    private static async Task SeedClaimsForSuperAdminUser(this RoleManager<IdentityRole> roleManger)
    {
        IdentityRole superadminRole = await roleManger.FindByNameAsync(RolesEnum.SuperAdmin.ToString());
        await roleManger.AddPermissionClaims(superadminRole, "Product");
    }
    private static async Task AddPermissionClaims(this RoleManager<IdentityRole> roleManger, IdentityRole role, string module)
    {
        IList<Claim> allRoleClaims = await roleManger.GetClaimsAsync(role);
        List<string> modulePermissions = PermissionsConstants.GeneratePermissionList(module);
        foreach (var permission in modulePermissions)
        {
            if (!allRoleClaims.Any(c => c.Type == PermissionsConstants.Permission && c.Value == permission))
                await roleManger.AddClaimAsync(role, new Claim(PermissionsConstants.Permission, permission));
        }
    }
}
