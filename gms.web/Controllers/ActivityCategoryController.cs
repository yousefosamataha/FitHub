using gms.common.Models.Activity;
using gms.data.Mapper;
using gms.data.Models.Activity;
using gms.service.Activity.ActivityCategoryRepository;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class ActivityCategoryController : Controller
{
    private readonly IActivityCategoryService _activityCategoryService;

    public ActivityCategoryController(IActivityCategoryService activityCategoryService = null)
    {
        _activityCategoryService = activityCategoryService;
    }

    [HttpGet]
    public IActionResult Create()
    {
        CreateActivityCategoryDTO model = new()
        {
            Name = string.Empty
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateActivityCategoryDTO newModel)
    {
        ActivityCategoryEntity entity = await _activityCategoryService.AddAsync(newModel.ToEntity());

        ActivityCategoryDTO entityDto = entity.ToDTO();

        return RedirectToAction(nameof(Index));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Edit(int id)
    {
        ActivityCategoryEntity entity = await _activityCategoryService.GetByIdAsync(id);
        return View(entity.ToDTO());
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        List<ActivityCategoryDTO> entitiesDtos = (await _activityCategoryService.GetAllAsync()).Select(ac => ac.ToDTO()).ToList();

        return View(entitiesDtos);
    }
}
