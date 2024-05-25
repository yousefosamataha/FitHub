using gms.common.Enums;
using gms.common.Models.GymCat.Branch;
using gms.common.Models.MembershipCat.MembershipPaymentHistory;
using gms.common.Models.MembershipCat.MembershipPlan;
using gms.common.ViewModels.Membership;
using gms.data.Mapper.Membership;
using gms.data.Models.Identity;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymRepository;
using gms.service.Identity.GymUserRepository;
using gms.service.Membership.GymMemberMembershipRepository;
using gms.service.Membership.GymMembershipPaymentHistoryRepository;
using gms.service.Membership.GymMembershipPlanRepository;
using gms.service.Shared.CountryRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class MembershipController : BaseController<MembershipController>
{
	private readonly IGymService _gymService;
	private readonly IGymBranchService _gymBranchService;
	private readonly ICountryService _countryService;
	private readonly IGymMembershipPlanService _gymMembershipPlanService;
	private readonly IGymMemberMembershipService _gymMemberMembershipService;
	private readonly IGymMembershipPaymentHistoryService _gymMembershipPaymentHistoryService;
	private readonly IGymUserService _gymUserService;

	public MembershipController
	(
		IGymService gymService,
		IGymBranchService gymBranchService,
		ICountryService countryService,
		IGymMembershipPlanService gymMembershipPlanService,
		IGymMemberMembershipService gymMemberMembershipService,
		IGymMembershipPaymentHistoryService gymMembershipPaymentHistoryService,
		IGymUserService gymUserService
	)
	{
		_gymService = gymService;
		_gymBranchService = gymBranchService;
		_countryService = countryService;
		_gymMembershipPlanService = gymMembershipPlanService;
		_gymMemberMembershipService = gymMemberMembershipService;
		_gymMembershipPaymentHistoryService = gymMembershipPaymentHistoryService;
		_gymUserService = gymUserService;
	}

	#region Membership
	public async Task<IActionResult> Index()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(Index), "HttpGet", DateTime.Now.ToString() });

			MembershipsListVM viewModel = new();
			BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
			viewModel.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
			viewModel.MembershipsList = await _gymMembershipPlanService.GetMembershipPlansListAsync();
			return View(viewModel);
		}

	}

	public IActionResult AddNewMembership()
	{
		return View();
	}

	[HttpPost]
	public async Task<JsonResult> AddNewMembership(CreateMembershipDTO modelDTO)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(AddNewMembership), "HttpPost", DateTime.Now.ToString() });

			GymUserEntity currentUser = await GetCurrentUserData();
			await _gymMembershipPlanService.CreateGymMembershipPlanAsync(modelDTO);
			return Json(new { Success = true, Message = "" });
		}

	}

	public async Task<IActionResult> EditMembership(int id)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(EditMembership), "HttpGet", DateTime.Now.ToString() });

			MembershipDTO? membership = await _gymMembershipPlanService.GetMembershipAsync(id);
			return View(membership.ToUpdateDTO());
		}

	}

	[HttpPost]
	public async Task<JsonResult> UpdateMembershipPlan(UpdateMembershipDTO modelDTO)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(UpdateMembershipPlan), "HttpPost", DateTime.Now.ToString() });

			await _gymMembershipPlanService.UpdateGymMembershipPlanAsync(modelDTO);
			return Json(new { Success = true, Message = "" });
		}

	}

	[HttpPost]
	public async Task<JsonResult> DeleteMembership(int id, int branchId)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(DeleteMembership), "HttpDelete", DateTime.Now.ToString() });

			await _gymMembershipPlanService.DeleteMembershipAsync(id, branchId);
			return Json(new { Success = true, Message = "" });
		}

	}
	#endregion

	#region Membership Payment
	public async Task<IActionResult> MembershipPayment()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(MembershipPayment), "HttpGet", DateTime.Now.ToString() });

			MembershipPaymentVM viewModel = new();
			BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
			viewModel.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
			viewModel.MemberMembershipList = await _gymMemberMembershipService.GetGymMemberMembershipListAsync();
			return View(viewModel);
		}

	}

	[HttpPost]
	public IActionResult AddMembershipPayment(AddMembershipPaymentVM model)
	{
		return PartialView("_AddMembershipPayment", model);
	}

	[HttpPost]
	public async Task<JsonResult> AddMembershipPaymentAmount(CreateMembershipPaymentHistoryDTO createDto)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(AddMembershipPaymentAmount), "HttpPost", DateTime.Now.ToString() });

			await _gymMembershipPaymentHistoryService.CreateNewMembershipPaymentAsync(createDto);
			return Json(new { Success = true, Message = "" });
		}

	}

	[HttpGet]
	public async Task<IActionResult> EditMemberMembership(int memberMembershipId)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(EditMemberMembership), "HttpGet", DateTime.Now.ToString() });

			EditMemberMembershipVM model = new();
			model.MemberMembershipDTO = await _gymMemberMembershipService.GetGymMemberMembershipByIdAsync(memberMembershipId);
			model.MembershipsListDTO = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();
			return PartialView("_EditMemberMembership", model);
		}
	}

	[HttpPost]
	public async Task<JsonResult> EditMemberMembership(EditMemberMembershipVM updateModel)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(EditMemberMembership), "HttpPost", DateTime.Now.ToString() });

			decimal dueAmount = updateModel.MembershipAmount - updateModel.PaidAmount;

			if (dueAmount > 0 && updateModel.PaidAmount != 0)
			{
				updateModel.UpdateMemberMembershipDTO.MemberShipStatusId = StatusEnum.Suspended;
				updateModel.UpdateMemberMembershipDTO.PaymentStatusId = StatusEnum.PartiallyPaid;
				await _gymMemberMembershipService.UpdateMemberMembershipAsync(updateModel.UpdateMemberMembershipDTO);
				GymUserEntity currentUserEntity = await _gymUserService.GetGymUserByIdAsync(updateModel.MemberMembershipDTO.MemberId);
				currentUserEntity.StatusId = StatusEnum.InActive;
				await _gymUserService.UpdateGymUser(currentUserEntity);
			}
			else if (dueAmount < 0 && updateModel.PaidAmount != 0)
			{
				updateModel.UpdateMemberMembershipDTO.MemberShipStatusId = StatusEnum.Active;
				updateModel.UpdateMemberMembershipDTO.PaymentStatusId = StatusEnum.OverPaid;
				await _gymMemberMembershipService.UpdateMemberMembershipAsync(updateModel.UpdateMemberMembershipDTO);
			}
			else if (dueAmount == 0 && updateModel.PaidAmount != 0)
			{
				updateModel.UpdateMemberMembershipDTO.MemberShipStatusId = StatusEnum.Active;
				updateModel.UpdateMemberMembershipDTO.PaymentStatusId = StatusEnum.FullyPaid;
				await _gymMemberMembershipService.UpdateMemberMembershipAsync(updateModel.UpdateMemberMembershipDTO);
			}
			else
			{
				await _gymMemberMembershipService.UpdateMemberMembershipAsync(updateModel.UpdateMemberMembershipDTO);
			}
			return Json(new { Success = true, Message = "" });
		}

	}
	#endregion

	#region Subscription History
	public async Task<IActionResult> SubscriptionHistory()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipController), nameof(SubscriptionHistory), "HttpGet", DateTime.Now.ToString() });

			MembershipPaymentVM viewModel = new();
			BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
			viewModel.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
			viewModel.MemberMembershipList = await _gymMemberMembershipService.GetGymMemberMembershipListAsync();
			return View(viewModel);
		}
	}
	#endregion
}
