using gms.common.Models.ClassCat.Class;
using gms.common.Models.GymCat.Branch;
using gms.common.ViewModels.Class;
using gms.data.Mapper.Class;
using gms.service.Class.ClassScheduleRepository;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymLocationRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class ClassController : BaseController<ClassController>
{
    private readonly IClassScheduleService _classScheduleService;
    private readonly IGymLocationService _gymLocationService;
    private readonly IGymBranchService _gymBranchService;

    public ClassController(IGymLocationService gymLocationService, IClassScheduleService classScheduleService, IGymBranchService gymBranchService)
    {
        _gymLocationService = gymLocationService;
        _classScheduleService = classScheduleService;
        _gymBranchService = gymBranchService;
    }


    public async Task<IActionResult> Index()
	{
        ClassesListVM model = new ();
        BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
        model.ClassesList = await _classScheduleService.GetClassesListAsync();
        model.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
        return View(model);
	}

	public async Task<IActionResult> AddNewClass()
	{
        AddClassVM addClassModel = new AddClassVM();
        addClassModel.GymLocations = await _gymLocationService.GetGymLocationsListAsync();

        return PartialView("_AddNewClass", addClassModel);
	}

    [HttpPost]
    public async Task<JsonResult> AddNewClass(CreateClassDTO createClassModel)
    {
        ClassDTO createdClassDTO = await _classScheduleService.CreateNewClassAsync(createClassModel);

        return Json(new { Success = true, Message = "" });
    }

    public async Task<IActionResult> EditClass(int id)
    {
        UpdateClassVM modal = new();
        ClassDTO Class = await _classScheduleService.GetClassAsync(id);
        modal.Class = Class.ToUpdateDTO();
        modal.GymLocations = await _gymLocationService.GetGymLocationsListAsync();

        return PartialView("_EditClass", modal);
    }

    //[HttpPost]
    //public async Task<JsonResult> UpdateActivity(UpdateActivityVM updateActivityDTO)
    //{
    //    ActivityDTO updatedActivityDTO = await _activityService.UpdateActivityAsync(updateActivityDTO.Activity);
    //    List<CreateMembershipActivityDTO> updateMembershipActivitiesListDTO = new();
    //    return Json(new { Success = true, Message = "" });
    //}

    public IActionResult ClassesSchedule()
	{
		return View();
	}
}
