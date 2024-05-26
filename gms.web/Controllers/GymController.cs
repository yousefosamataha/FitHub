using gms.common.Models.GymCat.GymGroup;
using gms.common.Models.GymCat.GymLocation;
using gms.common.ViewModels.Gym;
using gms.data.Mapper.Gym;
using gms.service.Gym.GymGroupRepository;
using gms.service.Gym.GymLocationRepository;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;
public class GymController : BaseController<GymController>
{
	private readonly IGymGroupService _gymGroupService;
	private readonly IGymLocationService _gymLocationService;

    public GymController(IGymGroupService gymGroupService, IGymLocationService gymLocationService)
    {
        _gymGroupService = gymGroupService;
        _gymLocationService = gymLocationService;
    }


    #region Gym Group Cat
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

	public async Task<IActionResult> GroupsList()
	{
        List<GymGroupDTO> listOfGymGroups = await _gymGroupService.GetGymGroupsListAsync();
		return View(listOfGymGroups);
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
}
