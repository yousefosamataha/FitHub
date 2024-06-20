using gms.common.Models.GymCat.Branch;
using gms.common.Models.GymCat.GymGeneralSetting;
using gms.common.Models.GymCat.GymGroup;
using gms.common.Models.GymCat.GymLocation;
using gms.common.Models.GymCat.GymSpecialization;
using gms.common.ViewModels.Gym;
using gms.data.Mapper.Gym;
using gms.data.Models.Identity;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymGeneralSettingsRepository;
using gms.service.Gym.GymGroupRepository;
using gms.service.Gym.GymLocationRepository;
using gms.service.Gym.GymSpecializationRepository;
using gms.service.Identity.GymRolesRepository;
using gms.service.Shared.CountryRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace gms.web.Controllers;
public class GymController : BaseController<GymController>
{
	private readonly IGymGroupService _gymGroupService;
	private readonly IGymLocationService _gymLocationService;
	private readonly IGymSpecializationService _gymSpecializationService;
	private readonly IGymGeneralSettingService _gymGeneralSettingService;
	private readonly IGymBranchService _gymBranchService;
    private readonly ICountryService _countryService;
    private readonly IGymRolesService _gymRoleService;
    private readonly SignInManager<GymUserEntity> _signInManager;
    private readonly UserManager<GymUserEntity> _userManager;

    public GymController(IGymGroupService gymGroupService, IGymLocationService gymLocationService, IGymSpecializationService gymSpecializationService, IGymGeneralSettingService gymGeneralSettingService, IGymBranchService gymBranchService, ICountryService countryService, IGymRolesService gymRoleService, UserManager<GymUserEntity> userManager, SignInManager<GymUserEntity> signInManager)
    {
        _gymGroupService = gymGroupService;
        _gymLocationService = gymLocationService;
        _gymSpecializationService = gymSpecializationService;
        _gymGeneralSettingService = gymGeneralSettingService;
        _gymBranchService = gymBranchService;
        _countryService = countryService;
        _gymRoleService = gymRoleService;
        _userManager = userManager;
        _signInManager = signInManager;
    }


    #region Gym Group Cat
    public async Task<IActionResult> GroupsList()
	{
        List<GymGroupDTO> listOfGymGroups = await _gymGroupService.GetGymGroupsListAsync();
		return View(listOfGymGroups);
	}

	public IActionResult AddNewGroup()
    {
        return PartialView("_AddNewGroup");
    }

    [HttpPost]
	public async Task<IActionResult> AddNewGroup(CreateGymGroupDTO model)
	{
		CreateGymGroupDTO modelDTO = new () {
			BranchId = GetBranchId(),
			Name = model.Name,	
			Image = model.Image?.Split(";base64,")[1],
			ImageType = model.Image?.Split(";base64,")[0].Split("data:image/")[1],
		};
		var result = await _gymGroupService.AddGymGroupAsync(modelDTO);
		return Json(result);
	}

    public async Task<IActionResult> EditGroup(int id)
    {
        var group = await _gymGroupService.GetGroupByIdAsync(id);
        return PartialView("_EditGroup", group.ToUpdateDTO());
    }

	[HttpPost]
	public async Task<JsonResult> UpdateGroup(UpdateGroupDTO modelDTO)
	{
		await _gymGroupService.UpdateGymGroupAsync(modelDTO);
		return Json(new { Success = true, Message = "" });
	}

	[HttpPost]
    public async Task<JsonResult> DeleteGroup(int id)
    {
        await _gymGroupService.DeleteGroupAsync(id);
        return Json(new { Success = true, Message = "" });
    }
    #endregion

    #region Gym Location
    [HttpGet]
    public async Task<IActionResult> CreateNewGymLocation()
    {
        GymLocationVM modal = new();
        modal.GymLocationList = await _gymLocationService.GetGymLocationsListAsync();

        return PartialView("_AddNewGymLocation", modal);
    }

    [HttpPost]
    public async Task<JsonResult> CreateNewGymLocation(CreateGymLocationDTO gymLocationModal)
    {
        await _gymLocationService.CreateNewGymLocationAsync(gymLocationModal);
        return Json(new { Success = true, Message = "" });
    }

    [HttpPost]
    public async Task<JsonResult> DeleteGymLocation(int id)
    {
        await _gymLocationService.DeleteGymLocationAsync(id);
        return Json(new { Success = true, Message = "" });
    }
	#endregion

	#region Gym Specialization
	[HttpGet]
	public async Task<IActionResult> CreateNewGymSpecialization()
	{
		GymSpecializationVM modal = new();
		modal.GymSpecializationsList = await _gymSpecializationService.GetGymSpecializationsListAsync();

		return PartialView("_AddNewGymSpecialization", modal);
	}

	[HttpPost]
	public async Task<JsonResult> CreateNewGymSpecialization(CreateGymSpecializationDTO gymSpecializationModal)
	{
		await _gymSpecializationService.CreateNewGymSpecializationAsync(gymSpecializationModal);
		return Json(new { Success = true, Message = "" });
	}

	[HttpPost]
	public async Task<JsonResult> DeleteGymSpecialization(int id)
	{
		await _gymSpecializationService.DeleteGymSpecializationAsync(id);
		return Json(new { Success = true, Message = "" });
	}
	#endregion

	#region Gym Branch General Setting
	public async Task<IActionResult> Settings()
	{
		GymGeneralSettingVM model = new ();
		model.GeneralSetting = await _gymGeneralSettingService.GetBranchGeneralSettingAsync();

		return View(model);
	}

	[HttpPost]
	public async Task<IActionResult> EditSettings(GymGeneralSettingVM updateGeneralSettingModel)
	{
		GeneralSettingDTO model = await _gymGeneralSettingService.UpdateGymGeneralSettingAsync(updateGeneralSettingModel.GeneralSetting);

		return RedirectToAction(nameof(Settings));
	}
	#endregion

	#region Gym Branches
	public async Task<IActionResult> BranchesList()
	{
		List<GymBranchDTO> branchesListDto = await _gymBranchService.GetGymBranchesListAsync();
		return View(branchesListDto);
	}

    public async Task<IActionResult> AddNewBranch()
    {
        AddNewBranchVM gymBranchModel = new ();
        gymBranchModel.CountriesList = await _countryService.GetCountriesListAsync();

        return PartialView("_AddNewBranch", gymBranchModel);
    }

    [HttpPost]
    public async Task<JsonResult> AddNewBranch(CreateBranchDTO model)
    {
        GymBranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
        model.GymId = GetGymId();
        model.IsMainBranch = false;

        if (branchData.GeneralSetting.IsShared) 
		{ 
			model.GeneralSettingId = branchData.GeneralSettingId;
			GymBranchDTO createdBranch = await _gymBranchService.CreateBranchAsync(model);

            await _gymRoleService.CreateRolesForBranchAsync(createdBranch.Id);
        }
		else
		{
            CreateGeneralSettingDTO GeneralSettingDTO = new();
            GeneralSettingDTO CreatedGeneralSetting = await _gymGeneralSettingService.CreateGymGeneralSettingAsync(GeneralSettingDTO);

            model.GeneralSettingId = CreatedGeneralSetting.Id;
            GymBranchDTO createdBranch = await _gymBranchService.CreateBranchAsync(model);

            await _gymRoleService.CreateRolesForBranchAsync(createdBranch.Id);
        }
        return Json(new { Success = true, Message = "" });
    }

    public async Task<IActionResult> SelectGymBranch()
    {
        List<GymBranchDTO> branchesListDto = await _gymBranchService.GetGymBranchesListAsync();
        return View(branchesListDto);
    }

    [HttpPost]
    public async Task<JsonResult> SelectGymBranch(int branchId)
    {
        var user = await _userManager.FindByIdAsync(GetUserId().ToString());
        var claimType = "BranchId";

        var oldClaims = (await _userManager.GetClaimsAsync(user)).Where(c => c.Type == claimType);

        if (oldClaims != null)
        {
            foreach (var cliam in oldClaims)
            {
                await _userManager.RemoveClaimAsync(user, cliam);
            }
            //if (result.Succeeded)
            //{
                var newClaim = new Claim(claimType, branchId.ToString());
                var sddNewClaimResult = await _userManager.AddClaimAsync(user, newClaim);
                if (sddNewClaimResult.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }
            //}
        }

        return Json(new { Success = true, Message = "" });
    }
	#endregion

	public IActionResult UpgradePlan()
	{
		return View();
	}
}
