using gms.common.Constants;
using gms.common.Models.Role;
using gms.common.Models.SharedCat;
using gms.data.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace gms.service.GymRolesRepository;
public class GymRolesService : IGymRolesService
{
    private readonly RoleManager<GymIdentityRoleEntity> _roleManager;
    public GymRolesService(RoleManager<GymIdentityRoleEntity> roleManager)
    {
        _roleManager = roleManager;
    }



    public async Task<List<GymRoleDTO>> GetAllRolesAsync()
    {
        List<GymRoleDTO> roles = await _roleManager.Roles.Select(r => new GymRoleDTO()
        {
            RoleId = r.Id,
            RoleName = r.Name
        }).ToListAsync();
        return roles;
    }

    public async Task<GymRolePermissionsDTO> GetRolePermissionsByRoleIdAsync(int roleId)
    {
        GymIdentityRoleEntity role = await _roleManager.FindByIdAsync(roleId.ToString());

        if (role is null)
            return new GymRolePermissionsDTO();

        List<string>? roleClaims = (await _roleManager.GetClaimsAsync(role)).Select(c => c.Value).ToList();

        List<SelectItemDTO> allClaims = PermissionsConstants.GenerateAllPermissionsList().Select(c => new SelectItemDTO()
        {
            Text = c
        }).ToList();

        foreach (SelectItemDTO claim in allClaims)
        {
            if (roleClaims.Any(c => string.Equals(c, claim.Text, StringComparison.OrdinalIgnoreCase)))
                claim.IsSelected = true;
        }
        GymRolePermissionsDTO result = new()
        {
            RoleId = role.Id,
            RoleName = role.Name,
            Permissions = allClaims.ToList()
        };
        return result;
    }

    public async Task<GymRoleDTO> CreateRoleAsync(string roleName)
    {
        throw new NotImplementedException();
    }
}
