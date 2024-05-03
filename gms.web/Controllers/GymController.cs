
using gms.common.Models.GymCat.GymGroup;
using gms.common.ViewModels.Gym;
using gms.data.Models.Identity;
using gms.service.Gym.GymGroupRepository;
using gms.service.GymUserRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;
public class GymController : BaseController<GymController>
{
	private readonly IGymUserService _gymUserService;
	private readonly UserManager<GymUserEntity> _userManager;
	private readonly IGymGroupService _gymGroupService;

	public GymController(IGymUserService gymUserService, UserManager<GymUserEntity> userManager, IGymGroupService gymGroupService)
	{
		_gymUserService = gymUserService;
		_userManager = userManager;
		_gymGroupService = gymGroupService;
	}

    public IActionResult AddNewGroup()
    {
        return View();
    }

    [HttpPost]
	public async Task<IActionResult> AddNewGroup(GymGroupVM model)
	{
		var currentUser = await GetCurrentUserData();
		var modelDTO = new CreateGymGroupDTO()
		{
			BranchId = currentUser.BranchId,
			Name = model.Name,	
			Image = model.Image?.Split(";base64,")[1],
			ImageType = model.Image?.Split(";base64,")[0].Split("data:image/")[1],
		};
		var result = await _gymGroupService.AddGymGroupAsync(modelDTO);
		return View();
	}

	public async Task<IActionResult> GroupsList()
	{
		var currentUser = await GetCurrentUserData();
		var listOfGymGroup = await _gymGroupService.GetGymGroupsListAsync(currentUser.BranchId);
		var listOfGymGroupVM = listOfGymGroup.Select(gg => new GymGroupVM()
		{
			Id = gg.Id,
			BranchId = gg.BranchId,
			Image = gg.Image,
			Name = gg.Name,
		}).ToList();

		return View(listOfGymGroupVM);
	}

	private async Task<GymUserEntity> GetCurrentUserData()
	{
		System.Security.Claims.ClaimsPrincipal currentUser = this.User;
		var currentUserData = await _userManager.GetUserAsync(currentUser);
		var allUserData = await _gymUserService.GetGymUserByEmail(currentUserData.Email);
		return allUserData;
	}
}
