using gms.common.Models.GymCat.GymMemberGroup;
using gms.common.Models.Identity.Role;
using gms.common.Models.Identity.User;
using gms.common.ViewModels.GymUser;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using gms.service.Gym.GymGroupRepository;
using gms.service.Gym.GymMemberGroupRepository;
using gms.service.Identity.GymUserRepository;
using gms.service.Membership.GymMemberMembershipRepository;
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
    private readonly IGymMemberGroupService _gymMemberGroupService;
    private readonly IGymMemberMembershipService _gymMemberMembershipService;

    public GymUserController(IGymUserService gymUserService, UserManager<GymUserEntity> userManager, IGymMembershipPlanService gymMembershipPlanService, IGymGroupService gymGroupService, IGymMemberGroupService gymMemberGroupService, IGymMemberMembershipService gymMemberMembershipService)
    {
        _gymUserService = gymUserService;
        _userManager = userManager;
        _gymMembershipPlanService = gymMembershipPlanService;
        _gymGroupService = gymGroupService;
        _gymMemberGroupService = gymMemberGroupService;
        _gymMemberMembershipService = gymMemberMembershipService;
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

    [HttpGet]
    public async Task<JsonResult> GetCurrentUserData(string email)
    {
        GymUserEntity userEntity = await _gymUserService.GetGymUserByEmail(email);
        return Json(new { Success = true, Message = "", Data = userEntity.ToDTO() });
    }

    public IActionResult UserProfile()
    {
        return View();
    }

    #region Member
    public async Task<IActionResult> MembersList()
    {
        List<GymUserDTO> membersList = await _gymUserService.GetGymMemberUsersListAsync();
        return View(membersList);
    }

    public async Task<IActionResult> CreateNewMember()
	{
        AddNewMemberVM model = new ();
		model.MembershipsListDTO = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();
		model.GymGroupsListDTO = await _gymGroupService.GetGymGroupsListAsync();

        return View(model);
	}

	[HttpPost]
	public async Task<JsonResult> CreateNewMember(AddNewMemberVM model)
	{
        GymUserDTO createdMemberDto = await _gymUserService.CreateNewGymMemberUserAsync(model.CreateMemberDTO, GetBranchId());
        List<CreateGymMemberGroupDTO> GymMemberGroupsListDTO = new();
        foreach (var id in model.SelectedGroupIds)
        {
            GymMemberGroupsListDTO.Add(new CreateGymMemberGroupDTO()
            {
                GymMemberUserId = createdMemberDto.Id,
                GymGroupId = id
            });
        }
        await _gymMemberGroupService.CreateNewGymMemberGroupAsync(GymMemberGroupsListDTO);
        await _gymMemberMembershipService.CreateNewMemberMembershipAsync(model.MemberMembershipDTO, createdMemberDto.Id);

        return Json(new { Success = true, Message = "" });
	}

    public async Task<IActionResult> EditMember(int id)
    {
        UpdateMemberVM model = new();
        GymUserEntity gymUserEntity = await _gymUserService.GetGymUserByIdAsync(id);
        model.MemberDTO = gymUserEntity.ToDTO();
        model.MembershipsListDTO = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();
        model.GymGroupsListDTO = await _gymGroupService.GetGymGroupsListAsync();

        return View(model);
    }
    #endregion


    #region Staff
    public IActionResult AddNewStaff()
    {
        return View();
    }

    public IActionResult StaffsList()
    {
        return View();
    }
    #endregion
}