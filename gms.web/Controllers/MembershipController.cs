using gms.common.ViewModels.Membership;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymRepository;
using gms.service.Shared.CountryRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using gms.service.Membership.GymMembershipPlanRepository;
using gms.data.Models.Identity;
using gms.data.Mapper.Membership;
using gms.common.Models.GymCat.Branch;
using gms.common.Models.MembershipCat.MembershipPlan;
using gms.service.Membership.GymMemberMembershipRepository;
using gms.common.Models.MembershipCat.MembershipPaymentHistory;
using gms.service.Membership.GymMembershipPaymentHistoryRepository;
using gms.common.Enums;
using gms.service.Identity.GymUserRepository;

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

    public MembershipController(
        IGymService gymService,
        IGymBranchService gymBranchService,
        ICountryService countryService,
        IGymMembershipPlanService gymMembershipPlanService,
        IGymMemberMembershipService gymMemberMembershipService,
        IGymMembershipPaymentHistoryService gymMembershipPaymentHistoryService,
        IGymUserService gymUserService)
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
        MembershipsListVM viewModel = new();
        BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
		viewModel.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
		viewModel.MembershipsList = await _gymMembershipPlanService.GetMembershipPlansListAsync();
		return View(viewModel);
	}

	public IActionResult AddNewMembership()
	{
		return View();
	}

	[HttpPost]
	public async Task<JsonResult> AddNewMembership(CreateMembershipDTO modelDTO)
	{
		GymUserEntity currentUser = await GetCurrentUserData();
		await _gymMembershipPlanService.CreateGymMembershipPlanAsync(modelDTO);
		return Json(new {Success = true, Message = ""});
	}

	public async Task<IActionResult> EditMembership(int id)
	{
		var membership = await _gymMembershipPlanService.GetMembershipAsync(id);
		return View(membership.ToUpdateDTO());
	}

	[HttpPost]
	public async Task<JsonResult> UpdateMembershipPlan(UpdateMembershipDTO modelDTO)
	{
		await _gymMembershipPlanService.UpdateGymMembershipPlanAsync(modelDTO);
		return Json(new { Success = true, Message = "" });
	}

	[HttpPost]
	public async Task<JsonResult> DeleteMembership(int id, int branchId)
	{
		await _gymMembershipPlanService.DeleteMembershipAsync(id, branchId);
		return Json(new { Success = true, Message = "" });
	}
    #endregion

    #region Membership Payment
    public async Task<IActionResult> MembershipPayment()
    {
        MembershipPaymentVM viewModel = new();
        BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
        viewModel.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
        viewModel.MemberMembershipList = await _gymMemberMembershipService.GetGymMemberMembershipListAsync();
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult AddMembershipPayment(AddMembershipPaymentVM model)
    {
        return PartialView("_AddMembershipPayment", model);
    }

    [HttpPost]
    public async Task<JsonResult> AddMembershipPaymentAmount(CreateMembershipPaymentHistoryDTO createDto)
    {
        await _gymMembershipPaymentHistoryService.CreateNewMembershipPaymentAsync(createDto);
        return Json(new { Success = true, Message = "" });
    }

    [HttpGet]
    public async Task<IActionResult> EditMemberMembership(int memberMembershipId)
    {
        EditMemberMembershipVM model = new ();
        model.MemberMembershipDTO = await _gymMemberMembershipService.GetGymMemberMembershipByIdAsync(memberMembershipId);
        model.MembershipsListDTO = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();

        return PartialView("_EditMemberMembership", model);
    }

    [HttpPost]
    public async Task<JsonResult> EditMemberMembership(EditMemberMembershipVM updateModel)
    {
        decimal dueAmount = updateModel.MembershipAmount - updateModel.PaidAmount;
        if(dueAmount > 0 && updateModel.PaidAmount != 0) {
            updateModel.UpdateMemberMembershipDTO.MemberShipStatusId = StatusEnum.Suspended;
            updateModel.UpdateMemberMembershipDTO.PaymentStatusId = StatusEnum.PartiallyPaid;
            await _gymMemberMembershipService.UpdateMemberMembershipAsync(updateModel.UpdateMemberMembershipDTO);
            GymUserEntity currentUserEntity = await _gymUserService.GetGymUserByIdAsync(updateModel.MemberMembershipDTO.MemberId);
            currentUserEntity.StatusId = StatusEnum.InActive;
            await _gymUserService.UpdateGymUser(currentUserEntity);
        }
        else if(dueAmount < 0 && updateModel.PaidAmount != 0) {
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
        else {
            await _gymMemberMembershipService.UpdateMemberMembershipAsync(updateModel.UpdateMemberMembershipDTO);
        }
        return Json(new { Success = true, Message = "" });
    }
    #endregion


    #region Subscription History
    public async Task<IActionResult> SubscriptionHistory()
    {
        MembershipPaymentVM viewModel = new();
        BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
        viewModel.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
        viewModel.MemberMembershipList = await _gymMemberMembershipService.GetGymMemberMembershipListAsync();
        return View(viewModel);
    }
    #endregion
}
