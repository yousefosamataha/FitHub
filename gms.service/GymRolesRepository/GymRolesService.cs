using gms.common.Constants;
using gms.common.Enums;
using gms.common.Models.Role;
using gms.common.Models.SharedCat;
using gms.data;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace gms.service.GymRolesRepository;
public class GymRolesService : IGymRolesService
{
    private readonly RoleManager<GymIdentityRoleEntity> _roleManager;
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public GymRolesService(RoleManager<GymIdentityRoleEntity> roleManager, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _roleManager = roleManager;
        _context = context;
        _httpContextAccessor = httpContextAccessor;
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

    public async Task<GymRoleDTO> CreateRoleAsync(CreateGymRoleDTO newRole)
    {
        GymIdentityRoleEntity newIdentityRoleEntity = newRole.ToEntity();
        await _context.Roles.AddAsync(newIdentityRoleEntity);
        return newIdentityRoleEntity.ToDTO();
    }

    public async Task<GymIdentityRoleEntity> AddAllPermissionClaims(GymIdentityRoleEntity role)
    {
        IList<Claim> allRoleClaims = await _roleManager.GetClaimsAsync(role);

        List<string> permissionList = PermissionsConstants.GenerateAllPermissionsList();

        foreach (string? permission in permissionList)
        {
            if (!allRoleClaims.Any(c => c.Type == PermissionsConstants.Permission && c.Value == permission))
                await _roleManager.AddClaimAsync(role, new Claim(PermissionsConstants.Permission, permission));
        }
        return role;
    }

    public async Task AddClaimsForSuperAdminUser()
    {
        GymIdentityRoleEntity superadminRole = await _roleManager.FindByNameAsync(RolesEnum.SuperAdmin.ToString());
        await AddAllPermissionClaims(superadminRole);
    }
}
