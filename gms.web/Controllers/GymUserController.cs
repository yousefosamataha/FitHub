using gms.common.Models.Identity.Role;
using gms.common.Models.Identity.User;
using gms.common.ViewModels.GymUser;
using gms.data.Models.Identity;
using gms.service.Gym.GymGroupRepository;
using gms.service.Identity.GymUserRepository;
using gms.service.Membership.GymMembershipPlanRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class GymUserController : BaseController<GymUserController>
{
	private readonly IGymUserService _gymUserService;
	private readonly UserManager<GymUserEntity> _userManager;
    private readonly IGymMembershipPlanService _gymMembershipPlanService;
    private readonly IGymGroupService _gymGroupService;
    public GymUserController(IGymUserService gymUserService, UserManager<GymUserEntity> userManager, IGymMembershipPlanService gymMembershipPlanService, IGymGroupService gymGroupService)
    {
        _gymUserService = gymUserService;
        _userManager = userManager;
        _gymMembershipPlanService = gymMembershipPlanService;
        _gymGroupService = gymGroupService;
    }

    public async Task<IActionResult> Index()
	{
		List<GymUserDTO> users = await _gymUserService.GetAllGymBranchUsersByBranchIdAsync(GetGymId(), GetBranchId());
		return View(users);
	}

	public async Task<IActionResult> GymUserRoles(int userId)
	{
		GymUserRolesDTO user = await _gymUserService.GetUserRolesByUserIdAsync(userId);
		return View(user);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> UpdateUserRoles(UpdateGymUserRolesDTO userRoles)
	{
		GymUserRolesDTO user = await _gymUserService.UpdateGymUserRolesAsyn(userRoles);
		return RedirectToAction(nameof(Index));
	}

	#region Member
	public async Task<IActionResult> CreateNewMember()
	{
        AddNewMemberVM model = new ();
		model.MembershipsListDTO = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();
		model.GymGroupsListDTO = await _gymGroupService.GetGymGroupsListAsync();

        return View(model);
	}

	[HttpPost]
	public async Task<IActionResult> CreateNewMember(AddNewMemberVM model)
	{
        GymUserDTO createdMemberDto = await _gymUserService.AddGymUserMemberAsync(model.CreateMemberDTO, GetBranchId());

		return RedirectToAction("Memberslist");
	}

	public IActionResult Memberslist()
	{
		return View();
	}
	#endregion
}