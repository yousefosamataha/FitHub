using gms.common.ViewModels.Membership;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymRepository;
using gms.service.Shared.CountryRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using gms.service.Membership.GymMembershipPlanRepository;
using gms.common.Models.MembershipCat;
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


	public IActionResult AddNewMembership()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> AddNewMembership(CreateMembershipDTO modelDTO)
	{
		GymUserEntity currentUser = await GetCurrentUserData();
		modelDTO.BranchId = currentUser.BranchId;
		await _gymMembershipPlanService.CreateGymMembershipPlanAsync(modelDTO);
		return Ok();
	}

	public async Task<IActionResult> MembershipsList()
	{
		GymUserEntity currentUser = await GetCurrentUserData();
		List<MembershipDTO> membershipPlansList = await _gymMembershipPlanService.GetMembershipPlansListAsync(currentUser.BranchId);
		MembershipsListVM viewModel = new();
		viewModel.BranchCurrencySymbol = currentUser.GymBranch.Country.CurrencySymbol;
		viewModel.MembershipsList = membershipPlansList;
		return View(viewModel);
	}

	public async Task<IActionResult> EditMembership(int id, int branchId)
	{
		var membership = await _gymMembershipPlanService.GetMembershipAsync(id, branchId);
		return View(membership);
	}

	[HttpPost]
	public async Task<IActionResult> UpdateMembershipPlan(MembershipDTO modelDTO)
	{
		await _gymMembershipPlanService.UpdateGymMembershipPlanAsync(modelDTO);
		return Ok();
	}

	[HttpPost]
	public async Task<IActionResult> DeleteMembership(int id, int branchId)
	{
		var result = await _gymMembershipPlanService.DeleteMembershipAsync(id, branchId);
		if (result)
		{
			return Ok();
		}
		return BadRequest();
	}
}
