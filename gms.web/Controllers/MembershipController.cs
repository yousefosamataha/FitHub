using gms.common.ViewModels.Membership;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymRepository;
using gms.service.Shared.CountryRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using gms.service.Membership.GymMembershipPlanRepository;
using gms.common.Models.MembershipCat;
using gms.common.Enums;
using gms.data.Models.Identity;

namespace gms.web.Controllers;

[Authorize]
public class MembershipController : BaseController<MembershipController>
{
	private readonly IGymService _gymService;
    private readonly IGymBranchService _gymBranchService;
    private readonly ICountryService _countryService;
	private readonly IGymMembershipPlanService _gymMembershipPlanService;

	public MembershipController(
		IGymService gymService,
		IGymBranchService gymBranchService,
		ICountryService countryService,
		IGymMembershipPlanService gymMembershipPlanService)
	{
		_gymService = gymService;
		_gymBranchService = gymBranchService;
		_countryService = countryService;
		_gymMembershipPlanService = gymMembershipPlanService;
	}

	public IActionResult Index()
	{
		return View();
	}

    public IActionResult AddNewMembership()
    {
		return View();
    }

	[HttpPost]
	public async Task<IActionResult> AddNewMembership(MembershipVM model)
	{
		var currentUser = await GetCurrentUserData();
		var modelDTO = new CreateMembershipDTO() {
			BranchId = currentUser.BranchId,
			MembershipName = model.MembershipName,
			MembershipDuration = (int)model.MembershipDuration,
			MembershipDurationTypeId = (MembershipLengthTypeEnum)model.MembershipDurationTypeId,
			MembershipAmount = (decimal)model.MembershipAmount,
			MembershipStatusId = (StatusEnum)model.MembershipStatusId,
			SignupFee = (decimal)model.SignupFee,
			MembershipDescription = model.MembershipDescription,
			ClassIsLimit = (bool)model.ClassIsLimit,
			ClassLimitDays = model.ClassLimitDays,
			ClassLimitationId = model.ClassLimitationId is null ? 0 : (MembershipClassLimitationEnum)model.ClassLimitationId,
			CreatedById = currentUser.Id
		};
		var createdMembership = await _gymMembershipPlanService.CreateGymMembershipPlanAsync(modelDTO);
		return RedirectToAction("MembershipsList");
	}

	public async Task<IActionResult> MembershipsList()
	{
		GymUserEntity currentUser = await GetCurrentUserData();
		List<MembershipDTO> membershipPlansList = await _gymMembershipPlanService.GetMembershipPlansListAsync(currentUser.BranchId);
		MembershipsListVM viewModel = new ();
        viewModel.BranchCurrencySymbol = currentUser.GymBranch.Country.CurrencySymbol;
        viewModel.MembershipsList = membershipPlansList.Select(mp => new MembershipVM()
		{
            Id = mp.Id,
            BranchId = mp.BranchId,
            MembershipName = mp.MembershipName,
            MembershipDuration = mp.MembershipDuration,
            MembershipDurationTypeId = mp.MembershipDurationTypeId,
            MembershipAmount = mp.MembershipAmount,
            MembershipStatusId = mp.MembershipStatusId,
            SignupFee = mp.SignupFee,
            MembershipDescription = mp.MembershipDescription,
            ClassIsLimit = mp.ClassIsLimit,
            ClassLimitDays = mp.ClassLimitDays,
            ClassLimitationId = mp.ClassLimitationId,
            CreatedAt = mp.CreatedAt,
        }).ToList();

        return View(viewModel);
	}

	public async Task<IActionResult> EditMembership(int id, int branchId)
    {
        var membership = await _gymMembershipPlanService.GetMembershipAsync(id, branchId);
        var viewModel = new MembershipVM()
		{
            Id = membership.Id,
            BranchId = membership.BranchId,
            MembershipName = membership.MembershipName,
            MembershipDuration = membership.MembershipDuration,
            MembershipDurationTypeId = membership.MembershipDurationTypeId,
            MembershipAmount = membership.MembershipAmount,
            MembershipStatusId = membership.MembershipStatusId,
            SignupFee = membership.SignupFee,
            MembershipDescription = membership.MembershipDescription,
            ClassIsLimit = membership.ClassIsLimit,
            ClassLimitDays = membership.ClassLimitDays,
            ClassLimitationId = membership.ClassLimitationId,
            CreatedAt = membership.CreatedAt,
        };

        return View(viewModel);
    }

	[HttpPost]
	public async Task<IActionResult> UpdateMembershipPlan(MembershipVM model)
	{
		// var currentUser = await GetCurrentUserData();
		var modelDTO = new MembershipDTO()
		{
			Id = (int)model.Id,
			BranchId = (int)model.BranchId,
			MembershipName = model.MembershipName,
			MembershipDuration = (int)model.MembershipDuration,
			MembershipDurationTypeId = (MembershipLengthTypeEnum)model.MembershipDurationTypeId,
			MembershipAmount = (decimal)model.MembershipAmount,
			MembershipStatusId = (StatusEnum)model.MembershipStatusId,
			SignupFee = (decimal)model.SignupFee,
			MembershipDescription = model.MembershipDescription,
			ClassIsLimit = (bool)model.ClassIsLimit,
			ClassLimitDays = model.ClassLimitDays,
			ClassLimitationId = model.ClassLimitationId is null ? 0 : (MembershipClassLimitationEnum)model.ClassLimitationId,
			// CreatedById = currentUser.Id
		};
		var updatedMembership = await _gymMembershipPlanService.UpdateGymMembershipPlanAsync(modelDTO);

		return RedirectToAction("MembershipsList");
	}

	[HttpPost]
	public async Task<IActionResult> DeleteMembership(int id, int branchId)
    {
        var result = await _gymMembershipPlanService.DeleteMembershipAsync(id, branchId);

        return Ok();
    }
}
