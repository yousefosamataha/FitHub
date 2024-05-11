using gms.common.Models.Identity.Role;
using gms.data.Models.Identity;
using gms.service.Identity.GymRolesRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace gms.web.Controllers;

[Authorize]
public class RolesController : BaseController<RolesController>
{
    private readonly IGymRolesService _gymRolesService;

    private readonly RoleManager<GymIdentityRoleEntity> _roleManager;

    public RolesController(IGymRolesService gymRolesService, RoleManager<GymIdentityRoleEntity> roleManager)
    {
        _gymRolesService = gymRolesService;
        _roleManager = roleManager;
    }

    public async Task<IActionResult> Index()
    {
        List<GymRoleDTO> roles = await _gymRolesService.GetAllRolesAsync();
        return View(roles);
    }

    public async Task<IActionResult> GymRolePermissionsByRoleId(int roleId)
    {
        GymRolePermissionsDTO result = await _gymRolesService.GetRolePermissionsByRoleIdAsync(roleId);
        return View(result);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddGymRole(CreateGymRoleDTO newRole)
    {
        if (!ModelState.IsValid)
            return View("Index", await _gymRolesService.GetAllRolesAsync());
        if (await _roleManager.RoleExistsAsync(newRole.RoleName))
        {
            ModelState.AddModelError("RoleName", "Role Already Exists");
            return View("Index", await _gymRolesService.GetAllRolesAsync());
        }
        await _roleManager.CreateAsync(new GymIdentityRoleEntity()
        {
            Name = newRole.RoleName.Trim()
        });

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> UpdateRolePermissions(GymRolePermissionsDTO rolePermissions)
    {
        GymIdentityRoleEntity role = await _roleManager.FindByIdAsync(rolePermissions.RoleId.ToString());

        if (role is null)
            return NotFound();

        IList<Claim> roleClaims = await _roleManager.GetClaimsAsync(role);

        foreach (Claim claim in roleClaims)
            await _roleManager.RemoveClaimAsync(role, claim);

        List<Claim> roleNewClaims = rolePermissions.Permissions.Where(c => c.IsSelected).Select(c => new Claim(PermissionsConstants.Permission.ToString(), c.Text)).ToList();
        foreach (Claim newClaim in roleNewClaims)
            await _roleManager.AddClaimAsync(role, newClaim);

        return RedirectToAction(nameof(Index));
    }
}
