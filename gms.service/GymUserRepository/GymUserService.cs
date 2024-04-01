using gms.common.ViewModels;
using gms.data.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace gms.service.GymUserRepository;
public class GymUserService : IGymUserService
{
    private readonly UserManager<GymUserEntity> _userManager;
    private readonly RoleManager<GymIdentityRoleEntity> _roleManager;
    public GymUserService(UserManager<GymUserEntity> userManager, RoleManager<GymIdentityRoleEntity> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }
    public async Task<List<GymUserViewModel>> GetAllUserByGymIdAsync()
    {
        List<GymUserEntity> gymUsersEntities = await _userManager.Users.ToListAsync();

        List<GymUserViewModel> gymUsers = new();

        foreach (var user in gymUsersEntities)
        {
            IList<string> roles = await _userManager.GetRolesAsync(user);
            gymUsers.Add(new GymUserViewModel
            {
                Email = user.Email,
                UserId = user.Id,
                UserName = user.UserName,
                Roles = string.Join(" , ", roles)
            });
        }
        return gymUsers;
    }
    public async Task<GymUserRolesViewModel> GetUserRolesByUserIdAsync(int userId)
    {
        GymUserEntity user = await _userManager.FindByIdAsync(userId.ToString());
        if (user is null)
            return new GymUserRolesViewModel();

        List<GymIdentityRoleEntity> roles = await _roleManager.Roles.ToListAsync();

        GymUserRolesViewModel gymuserRolesViewModel = new()
        {
            UserId = userId,
            UserName = user.UserName,
            Email = user.Email,
            Roles = roles.Select(r => new SelectItemViewModel()
            {
                Text = r.Name,
                IsSelected = _userManager.IsInRoleAsync(user, r.Name).Result
            }).ToList()
        };
        return gymuserRolesViewModel;
    }
    public async Task<GymUserRolesViewModel> UpdateGymUserRolesAsyn(GymUserRolesViewModel gymUserRoles)
    {
        GymUserEntity user = await _userManager.FindByEmailAsync(gymUserRoles.Email);
        if (user is null)
            return new GymUserRolesViewModel();

        var userRoles = await _userManager.GetRolesAsync(user);

        await _userManager.RemoveFromRolesAsync(user, userRoles);
        await _userManager.AddToRolesAsync(user, gymUserRoles.Roles.Where(role => role.IsSelected).Select(role => role.Text));

        List<GymIdentityRoleEntity> roles = await _roleManager.Roles.ToListAsync();

        GymUserRolesViewModel updatedGymUserRolesViewModel = new()
        {
            UserId = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            Roles = roles.Select(r => new SelectItemViewModel()
            {
                Text = r.Name,
                IsSelected = _userManager.IsInRoleAsync(user, r.Name).Result
            }).ToList()
        };

        return updatedGymUserRolesViewModel;
    }
}
