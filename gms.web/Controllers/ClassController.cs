using gms.common.Models.GymCat.Branch;
using gms.common.ViewModels.Class;
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

	public IActionResult AddNewClass()
	{
		return View();
	}

	public IActionResult ClassesSchedule()
	{
		return View();
	}
}
