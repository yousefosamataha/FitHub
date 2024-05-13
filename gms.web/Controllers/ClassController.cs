using gms.common.Enums;
using gms.common.Models.ClassCat.Class;
using gms.common.Models.ClassCat.ClassScheduleDay;
using gms.common.Models.GymCat.Branch;
using gms.common.Permissions;
using gms.common.ViewModels.Class;
using gms.data.Mapper.Class;
using gms.service.Class.ClassScheduleDayRepository;
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
    private readonly IClassScheduleDayService _classScheduleDayService;

    public ClassController(IGymLocationService gymLocationService, IClassScheduleService classScheduleService, IGymBranchService gymBranchService, IClassScheduleDayService classScheduleDayService)
    {
        _gymLocationService = gymLocationService;
        _classScheduleService = classScheduleService;
        _gymBranchService = gymBranchService;
        _classScheduleDayService = classScheduleDayService;
    }

	[Authorize(ClassPermissions.View)]
	public async Task<IActionResult> Index()
	{
        ClassesListVM model = new ();
        BranchDTO branchData = await _gymBranchService.GetBranchByIdAsync(GetBranchId());
        model.ClassesList = await _classScheduleService.GetClassesListAsync();
        model.BranchCurrencySymbol = branchData.Country.CurrencySymbol;
        return View(model);
	}

	[Authorize(ClassPermissions.Create)]
	public async Task<IActionResult> CreateNewClass()
	{
        AddClassVM addClassModel = new AddClassVM();
        addClassModel.GymLocations = await _gymLocationService.GetGymLocationsListAsync();

        return PartialView("_AddNewClass", addClassModel);
	}

    [HttpPost]
    public async Task<JsonResult> CreateNewClass(AddClassVM addClassModel)
    {
        ClassDTO createdClassDTO = await _classScheduleService.CreateNewClassAsync(addClassModel.Class);
        List<CreateClassScheduleDayDTO> classScheduleDaysListDTO = new();
        foreach (var dayId in addClassModel.WeekDayIds)
        {
            classScheduleDaysListDTO.Add(new CreateClassScheduleDayDTO()
            {
                ClassScheduleId = createdClassDTO.Id,
                WeekDayId = (WeekDayEnum)dayId
            });
        } 
        await _classScheduleDayService.CreateNewClassScheduleDaysAsync(classScheduleDaysListDTO);

        return Json(new { Success = true, Message = "" });
    }

	[HttpGet]
	[Authorize(ClassPermissions.Edit)]
	public async Task<IActionResult> EditClass(int id)
    {
        UpdateClassVM modal = new();
        ClassDTO Class = await _classScheduleService.GetClassAsync(id);
        modal.Class = Class.ToUpdateDTO();
        modal.GymLocations = await _gymLocationService.GetGymLocationsListAsync();

        return PartialView("_EditClass", modal);
    }

    [HttpPost]
    public async Task<JsonResult> EditClass(UpdateClassVM updateClassModel)
    {
        ClassDTO updatedClassDTO = await _classScheduleService.UpdateClassAsync(updateClassModel.Class);
        List<CreateClassScheduleDayDTO> classScheduleDaysListDTO = new();
        foreach (var dayId in updateClassModel.WeekDayIds)
        {
            classScheduleDaysListDTO.Add(new CreateClassScheduleDayDTO()
            {
                ClassScheduleId = updatedClassDTO.Id,
                WeekDayId = (WeekDayEnum)dayId
            });
        }
        await _classScheduleDayService.UpdateClassScheduleDaysAsync(classScheduleDaysListDTO, updatedClassDTO.Id);

        return Json(new { Success = true, Message = "" });
    }

    [HttpGet]
    public async Task<IActionResult> GetClassScheduleDaysById(int classId)
    {
        List<ClassScheduleDayDTO> classScheduleDaysList = await _classScheduleDayService.GetClassScheduleDaysListAsync(classId);

        return Json(new { Success = true, Message = "", Data = classScheduleDaysList });
    }

    [HttpPost]
	[Authorize(ClassPermissions.Delete)]
	public async Task<JsonResult> DeleteClass(int id)
    {
        await _classScheduleService.DeleteClassAsync(id);
        return Json(new { Success = true, Message = "" });
    }

    public IActionResult ClassesSchedule()
	{
		return View();
	}
}
