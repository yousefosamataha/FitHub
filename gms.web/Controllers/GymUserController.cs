using gms.common.Enums;
using gms.common.Models.IdentityCat;
using gms.common.Models.Role;
using gms.common.ViewModels;
using gms.common.ViewModels.GymUser;
using gms.data.Models.Identity;
using gms.service.GymUserRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class GymUserController : BaseController<GymUserController>
{
    private readonly IGymUserService _gymUserService;
    private readonly UserManager<GymUserEntity> _userManager;
    public GymUserController(IGymUserService gymUserService, UserManager<GymUserEntity> userManager)
    {
        _gymUserService = gymUserService;
        _userManager = userManager;
    }

    #region Roles
    public async Task<IActionResult> GymUsers()
	{
		List<GymUserViewModel> users = await _gymUserService.GetAllUserByGymIdAsync();
		return View(users);

	}
	public async Task<IActionResult> GymUserRoles(int userId)
	{
		GymUserRolesDTO user = await _gymUserService.GetUserRolesByUserIdAsync(userId);
		return View(user);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> UpdateUserRoles(GymUserRolesDTO userRoles)
	{
		GymUserRolesDTO user = await _gymUserService.UpdateGymUserRolesAsyn(userRoles);
		return RedirectToAction(nameof(GymUsers));
	}
    #endregion

    public IActionResult AddNewMember()
    {
        return View();
    }

	[HttpPost]
    public async Task<IActionResult> AddNewMember(GymUserVM model)
    {
        var currentUser = await GetCurrentUserData();
        var modelDTO = new CreateGymUserDTO()
        {
            BranchId = currentUser.BranchId,
            Image = model.Image?.Split(";base64,")[1],
            ImageType = model.Image?.Split(";base64,")[0].Split("data:image/")[1],
            FirstName = model.FirstName,
            LastName = model.LastName,
            GenderId = model.GenderId,
            BirthDate = model.BirthDate,
            Address = model.Address,
            City = model.City,
            State = model.State,
            PhoneNumber = model.PhoneNumber,
            Email = model.Email,
            Password = model.Password,
            StatusId = model.StatusId,
            GymUserTypeId = GymUserTypeEnum.Member
        };
        var result = await _gymUserService.AddGymUserMemberAsync(modelDTO);
        return View();
    }

    public IActionResult Memberslist()
    {
        return View();
    }

    private async Task<GymUserEntity> GetCurrentUserData()
    {
        System.Security.Claims.ClaimsPrincipal currentUser = this.User;
        var currentUserData = await _userManager.GetUserAsync(currentUser);
        var allUserData = await _gymUserService.GetGymUserByEmail(currentUserData.Email);
        return allUserData;
    }
}