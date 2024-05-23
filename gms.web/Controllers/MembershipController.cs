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

    public MembershipController(
        IGymService gymService,
        IGymBranchService gymBranchService,
        ICountryService countryService,
        IGymMembershipPlanService gymMembershipPlanService,
        IGymMemberMembershipService gymMemberMembershipService,
        IGymMembershipPaymentHistoryService gymMembershipPaymentHistoryService)
    {
        _gymService = gymService;
        _gymBranchService = gymBranchService;
        _countryService = countryService;
        _gymMembershipPlanService = gymMembershipPlanService;
        _gymMemberMembershipService = gymMemberMembershipService;
        _gymMembershipPaymentHistoryService = gymMembershipPaymentHistoryService;
    }

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


    public async Task<IActionResult> MembershipPayment()
    {
        MembershipPaymentVM viewModel = new();
        BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
        viewModel.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
        viewModel.MemberMembershipList = await _gymMemberMembershipService.GetGymMemberMembershipListAsync();
        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AddMembershipPayment(AddMembershipPaymentVM model)
    {
        return PartialView("_AddMembershipPayment", model);
    }

    [HttpPost]
    public async Task<JsonResult> AddMembershipPaymentAmount(CreateMembershipPaymentHistoryDTO createDto)
    {
        await _gymMembershipPaymentHistoryService.CreateNewMembershipPaymentAsync(createDto);
        return Json(new { Success = true, Message = "" });
    }

    public async Task<IActionResult> SubscriptionHistory()
    {
        MembershipPaymentVM viewModel = new();
        BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
        viewModel.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
        viewModel.MemberMembershipList = await _gymMemberMembershipService.GetGymMemberMembershipListAsync();
        return View(viewModel);
    }
}
