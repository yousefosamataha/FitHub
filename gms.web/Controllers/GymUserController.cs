using gms.common.Enums;
using gms.common.Models.GymCat.GymMemberGroup;
using gms.common.Models.GymCat.GymStaffGroup;
using gms.common.Models.GymCat.GymStaffSpecialization;
using gms.common.Models.Identity.Role;
using gms.common.Models.Identity.User;
using gms.common.ViewModels.GymUser;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using gms.service.Gym.GymGroupRepository;
using gms.service.Gym.GymMemberGroupRepository;
using gms.service.Gym.GymSpecializationRepository;
using gms.service.Gym.GymStaffSpecializationRepository;
using gms.service.Gym.StaffGroupRepository;
using gms.service.Identity.GymRolesRepository;
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
	private readonly IGymStaffGroupService _gymStaffGroupService;
	private readonly IGymMemberMembershipService _gymMemberMembershipService;
	private readonly IGymRolesService _gymRolesService;
	private readonly IGymSpecializationService _gymSpecializationService;
	private readonly IGymStaffSpecializationService _gymStaffSpecializationService;

    public GymUserController
    (
        IGymUserService gymUserService,
        UserManager<GymUserEntity> userManager,
        IGymMembershipPlanService gymMembershipPlanService,
        IGymGroupService gymGroupService,
        IGymMemberGroupService gymMemberGroupService,
        IGymMemberMembershipService gymMemberMembershipService,
        IGymRolesService gymRolesService,
        IGymStaffGroupService gymStaffGroupService,
        IGymSpecializationService gymSpecializationService,
        IGymStaffSpecializationService gymStaffSpecializationService)
    {
        _gymUserService = gymUserService;
        _userManager = userManager;
        _gymMembershipPlanService = gymMembershipPlanService;
        _gymGroupService = gymGroupService;
        _gymMemberGroupService = gymMemberGroupService;
        _gymMemberMembershipService = gymMemberMembershipService;
        _gymRolesService = gymRolesService;
        _gymStaffGroupService = gymStaffGroupService;
        _gymSpecializationService = gymSpecializationService;
        _gymStaffSpecializationService = gymStaffSpecializationService;
    }

    public async Task<IActionResult> Index()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(Index), "HttpGet", DateTime.Now.ToString() });

			List<GymUserDTO> users = await _gymUserService.GetAllGymBranchUsersByBranchIdAsync(GetGymId(), GetBranchId());
			return View(users);
		}

	}

	public async Task<IActionResult> GymUserRoles(int userId)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(GymUserRoles), "HttpGet", DateTime.Now.ToString() });

			GymUserRolesDTO user = await _gymUserService.GetUserRolesByUserIdAsync(userId);
			return View(user);
		}

	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> UpdateUserRoles(UpdateGymUserRolesDTO userRoles)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(UpdateUserRoles), "HttpPost", DateTime.Now.ToString() });

			GymUserRolesDTO user = await _gymUserService.UpdateGymUserRolesAsyn(userRoles);
			return RedirectToAction(nameof(Index));
		}

	}

	[HttpGet]
	public async Task<JsonResult> GetCurrentUserData(string email)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(GetCurrentUserData), "HttpGet", DateTime.Now.ToString() });

			GymUserEntity userEntity = await _gymUserService.GetGymUserByEmail(email);
			return Json(new { Success = true, Message = "", Data = userEntity.ToDTO() });
		}

	}

	public IActionResult UserProfile()
	{
		return View();
	}

	#region Member
	public async Task<IActionResult> MembersList()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(MembersList), "HttpGet", DateTime.Now.ToString() });

			List<GymUserDTO> membersList = await _gymUserService.GetGymMemberUsersListAsync();
			return View(membersList);
		}
	}

	public async Task<IActionResult> CreateNewMember()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(CreateNewMember), "HttpGet", DateTime.Now.ToString() });

			AddNewMemberVM model = new();
			model.MembershipsListDTO = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();
			model.GymGroupsListDTO = await _gymGroupService.GetGymGroupsListAsync();

			return View(model);
		}
	}

	[HttpPost]
	public async Task<JsonResult> CreateNewMember(AddNewMemberVM model)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(CreateNewMember), "HttpPost", DateTime.Now.ToString() });

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

	}

	public async Task<IActionResult> EditMember(int id)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(EditMember), "HttpGet", DateTime.Now.ToString() });

			UpdateMemberVM model = new();
			GymUserEntity gymUserEntity = await _gymUserService.GetGymUserByIdAsync(id);
			model.MemberDTO = gymUserEntity.ToDTO();
			model.MembershipsListDTO = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();
			model.GymGroupsListDTO = await _gymGroupService.GetGymGroupsListAsync();
			model.SelectedGroupIds = new List<int>();
			foreach (var item in model.MemberDTO.GymMemberGroups)
			{
				model.SelectedGroupIds.Add(item.GymGroupId);
			}

			return View(model);
		}

	}

	[HttpPost]
	public async Task<JsonResult> EditMember(UpdateMemberVM model)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(EditMember), "HttpGet", DateTime.Now.ToString() });

			GymUserDTO updatedMemberDto = await _gymUserService.UpdateGymMemberUserAsync(model.UpdateMemberDTO);
			List<CreateGymMemberGroupDTO> GymMemberGroupsListDTO = new();

			foreach (var id in model.SelectedGroupIds)
			{
				GymMemberGroupsListDTO.Add(new CreateGymMemberGroupDTO()
				{
					GymMemberUserId = updatedMemberDto.Id,
					GymGroupId = id
				});
			}
			await _gymMemberGroupService.UpdateGymMemberGroupAsync(GymMemberGroupsListDTO, updatedMemberDto.Id);

			decimal dueAmount = model.MemberMembershipDTO.Membership.MembershipAmount - model.MemberMembershipDTO.PaidAmount;

			if (dueAmount > 0 && model.MemberMembershipDTO.PaidAmount != 0)
			{
				model.UpdateMemberMembershipDTO.MemberShipStatusId = StatusEnum.Suspended;
				model.UpdateMemberMembershipDTO.PaymentStatusId = StatusEnum.PartiallyPaid;
				await _gymMemberMembershipService.UpdateMemberMembershipAsync(model.UpdateMemberMembershipDTO);
				GymUserEntity currentUserEntity = await _gymUserService.GetGymUserByIdAsync(updatedMemberDto.Id);
				currentUserEntity.StatusId = StatusEnum.InActive;
				await _gymUserService.UpdateGymUser(currentUserEntity);
			}
			else if (dueAmount < 0 && model.MemberMembershipDTO.PaidAmount != 0)
			{
				model.UpdateMemberMembershipDTO.MemberShipStatusId = StatusEnum.Active;
				model.UpdateMemberMembershipDTO.PaymentStatusId = StatusEnum.OverPaid;
				await _gymMemberMembershipService.UpdateMemberMembershipAsync(model.UpdateMemberMembershipDTO);
			}
			else if (dueAmount == 0 && model.MemberMembershipDTO.PaidAmount != 0)
			{
				model.UpdateMemberMembershipDTO.MemberShipStatusId = StatusEnum.Active;
				model.UpdateMemberMembershipDTO.PaymentStatusId = StatusEnum.FullyPaid;
				await _gymMemberMembershipService.UpdateMemberMembershipAsync(model.UpdateMemberMembershipDTO);
				GymUserEntity currentUserEntity = await _gymUserService.GetGymUserByIdAsync(updatedMemberDto.Id);
				currentUserEntity.StatusId = StatusEnum.Active;
				await _gymUserService.UpdateGymUser(currentUserEntity);
			}
			else
			{
				await _gymMemberMembershipService.UpdateMemberMembershipAsync(model.UpdateMemberMembershipDTO);
			}

			return Json(new { Success = true, Message = "" });
		}

	}
	#endregion

	#region Staff
	public async Task<IActionResult> StaffsList()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(StaffsList), "HttpGet", DateTime.Now.ToString() });

			List<GymUserDTO> staffsList = await _gymUserService.GetGymStaffUsersListAsync();
			return View(staffsList);
		}
		return View();
	}

	public async Task<IActionResult> CreateNewStaff()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(CreateNewStaff), "HttpGet", DateTime.Now.ToString() });

			AddNewStaffVM model = new();
			model.Roles = await _gymRolesService.GetAllRolesAsync();
			model.GymGroupsListDTO = await _gymGroupService.GetGymGroupsListAsync();
			model.GymSpecializationsListDTO = await _gymSpecializationService.GetGymSpecializationsListAsync();

			return View(model);
		}
	}

	[HttpPost]
	public async Task<JsonResult> CreateNewStaff(AddNewStaffVM model)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(CreateNewStaff), "HttpPost", DateTime.Now.ToString() });

			GymUserDTO createdStaffDto = await _gymUserService.CreateNewGymStaffUserAsync(model.CreateStaffDTO, GetBranchId(), model.RoleName);

			List<CreateGymStaffGroupDTO> GymStaffGroupsListDTO = new();
			foreach (var id in model.SelectedGroupIds)
			{
				GymStaffGroupsListDTO.Add(new CreateGymStaffGroupDTO()
				{
					GymStaffUserId = createdStaffDto.Id,
					GymGroupId = id
				});
			}
			await _gymStaffGroupService.CreateNewGymStaffGroupAsync(GymStaffGroupsListDTO);

            List<CreateGymStaffSpecializationDTO> GymStaffSpecializationsListDTO = new();
            foreach (var id in model.SelectedSpecializationIds)
            {
                GymStaffSpecializationsListDTO.Add(new CreateGymStaffSpecializationDTO()
                {
                    GymStaffId = createdStaffDto.Id,
                    GymSpecializationId = id
                });
            }
            await _gymStaffSpecializationService.CreateNewGymStaffSpecializationAsync(GymStaffSpecializationsListDTO);

            return Json(new { Success = true, Message = "" });
		}
	}

	public async Task<IActionResult> EditStaff(int id)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(EditStaff), "HttpGet", DateTime.Now.ToString() });

			UpdateStaffVM model = new();
			GymUserEntity gymUserEntity = await _gymUserService.GetGymUserByIdAsync(id);
			model.StaffDTO = gymUserEntity.ToDTO();
			model.Roles = await _gymRolesService.GetAllRolesAsync();
			model.GymGroupsListDTO = await _gymGroupService.GetGymGroupsListAsync();
            model.GymSpecializationsListDTO = await _gymSpecializationService.GetGymSpecializationsListAsync();

            var staffRoles = await _userManager.GetRolesAsync(gymUserEntity);
			model.RoleName = staffRoles.FirstOrDefault().Split("_")[1];

			model.SelectedGroupIds = new List<int>();
			foreach (var item in model.StaffDTO.GymStaffGroups)
			{
				model.SelectedGroupIds.Add(item.GymGroupId);
			}

            model.SelectedSpecializationIds = new List<int>();
            foreach (var item in model.StaffDTO.GymStaffSpecializations)
            {
                model.SelectedSpecializationIds.Add(item.GymSpecializationId);
            }

            return View(model);
		}
	}

	[HttpPost]
	public async Task<JsonResult> EditStaff(UpdateStaffVM model)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(GymUserController), nameof(EditStaff), "HttpPost", DateTime.Now.ToString() });

			GymUserDTO updatedStaffDto = await _gymUserService.UpdateGymStaffUserAsync(model.UpdateStaffDTO, model.RoleName);

			List<CreateGymStaffGroupDTO> GymStaffGroupsListDTO = new();
			foreach (var id in model.SelectedGroupIds)
			{
				GymStaffGroupsListDTO.Add(new CreateGymStaffGroupDTO()
				{
					GymStaffUserId = updatedStaffDto.Id,
					GymGroupId = id
				});
			}
			await _gymStaffGroupService.UpdateGymStaffGroupAsync(GymStaffGroupsListDTO, updatedStaffDto.Id);

			List<CreateGymStaffSpecializationDTO> GymStaffSpecializationsListDTO = new();
			foreach (var id in model.SelectedSpecializationIds)
			{
				GymStaffSpecializationsListDTO.Add(new CreateGymStaffSpecializationDTO()
				{
					GymStaffId = updatedStaffDto.Id,
					GymSpecializationId = id
				});
			}
			await _gymStaffSpecializationService.UpdateGymStaffSpecializationAsync(GymStaffSpecializationsListDTO, updatedStaffDto.Id);

			return Json(new { Success = true, Message = "" });
		}
	}

	[HttpPost]
	public async Task<JsonResult> DeleteStaff(int id)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(DeleteStaff), "HttpDelete", DateTime.Now.ToString() });

			await _gymUserService.DeleteGymStaffUserAsync(id, GetBranchId());
			return Json(new { Success = true, Message = "" });
		}

	}
	#endregion
}