//using gms.common.Enums;
//using gms.common.Permissions;
//using gms.data.Models.Identity;
//using Microsoft.AspNetCore.Identity;
//using System.Security.Claims;

//namespace gms.data.Seeds;

//public static partial class Seeds
//{
//    public static async Task SeedBasicUserAsync(UserManager<GymUserEntity> userManger)
//    {
//        try
//        {
//            GymUserEntity defaultUser = new()
//            {
//                UserName = "basicuser@domain.com",
//                Email = "basicuser@domain.com",
//                EmailConfirmed = true,
//                FirstName = "Basic",
//                LastName = "User",
//                PhoneNumber = "+201100241976",
//                GymUserTypeId = GymUserTypeEnum.Staff
//            };

//            GymUserEntity user = await userManger.FindByEmailAsync(defaultUser.Email);
//            if (user is null)
//            {
//                await userManger.CreateAsync(defaultUser, "P@ssWord123");
//                await userManger.AddToRoleAsync(defaultUser, RolesEnum.Basic.ToString());
//            }
//        }
//        catch (Exception ex)
//        {

//        }

//    }

//    public static async Task SeedSuperAdminUserAsync(UserManager<GymUserEntity> userManger, RoleManager<GymIdentityRoleEntity> roleManger)
//    {
//        try
//        {
//            GymUserEntity defaulSuperAdminUser = new()
//            {
//                UserName = "superadmin@domain.com",
//                Email = "superadmin@domain.com",
//                EmailConfirmed = true,
//                FirstName = "super",
//                LastName = "admin",
//                PhoneNumber = "+201100241976",
//                GymUserTypeId = GymUserTypeEnum.Staff
//            };

//            GymUserEntity user = await userManger.FindByEmailAsync(defaulSuperAdminUser.Email);
//            if (user is null)
//            {
//                await userManger.CreateAsync(defaulSuperAdminUser, "P@ssWord123");
//                await userManger.AddToRolesAsync(defaulSuperAdminUser, new List<string>() { RolesEnum.Basic.ToString(), RolesEnum.Admin.ToString(), RolesEnum.SuperAdmin.ToString() });
//            }
//            await roleManger.SeedClaimsForSuperAdminUser();
//        }
//        catch (Exception ex)
//        {

//        }
//    }

//    private static async Task SeedClaimsForSuperAdminUser(this RoleManager<GymIdentityRoleEntity> roleManger)
//    {
//        GymIdentityRoleEntity superadminRole = await roleManger.FindByNameAsync(RolesEnum.SuperAdmin.ToString());
//        await roleManger.AddAllPermissionClaims(superadminRole);
//    }

//    private static async Task AddAllPermissionClaims(this RoleManager<GymIdentityRoleEntity> roleManger, GymIdentityRoleEntity role)
//    {
//        IList<Claim> allRoleClaims = await roleManger.GetClaimsAsync(role);

//        List<string> permissionList = PermissionsConstants.GenerateAllPermissionsList();
//        foreach (var permission in permissionList)
//        {
//            if (!allRoleClaims.Any(c => c.Type == PermissionsConstants.Permission && c.Value == permission))
//                await roleManger.AddClaimAsync(role, new Claim(PermissionsConstants.Permission, permission));
//        }
//    }
//}
