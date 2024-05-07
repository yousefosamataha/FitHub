using gms.common.Models.ActivityCat.Activity;
using gms.common.Models.ActivityCat.MembershipActivity;
using gms.common.ViewModels.Activity;
using gms.service.Activity.ActivityCategoryRepository;
using gms.service.Activity.ActivityRepository;
using gms.service.Activity.MembershipActivityRepository;
using gms.service.Membership.GymMembershipPlanRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class ActivityController : BaseController<ActivityController>
{
	private readonly IActivityService _activityService;
	private readonly IActivityCategoryService _activityCategoryService;
	private readonly IGymMembershipPlanService _gymMembershipPlanService;
	private readonly IMembershipActivityService _membershipActivityService;

	public ActivityController(IActivityService activityService, IActivityCategoryService activityCategoryService, IGymMembershipPlanService gymMembershipPlanService, IMembershipActivityService membershipActivityService)
	{
		_activityService = activityService;
		_activityCategoryService = activityCategoryService;
		_gymMembershipPlanService = gymMembershipPlanService;
		_membershipActivityService = membershipActivityService;
	}

	public async Task<IActionResult> Index()
	{
        List<ActivityDTO> listOfActivities = await _activityService.GetActivitiesListAsync();
        return View(listOfActivities);
	}

	public async Task<IActionResult> AddNewActivity()
    {
		AddNewActivityVM modal = new ();
		modal.ActivityCategories = await _activityCategoryService.GetActivityCategoriesListAsync();
		modal.Memberships = await _gymMembershipPlanService.GetMembershipPlansListAsync();

		return PartialView("_AddNewActivity", modal);
    }

	[HttpPost]
	public async Task<JsonResult> AddNewActivity(AddNewActivityVM activityModal)
    {
		ActivityDTO createdActivityDTO = await _activityService.CreateNewActivityAsync(activityModal.Activity);
		List<CreateMembershipActivityDTO> membershipActivitiesListDTO = new ();
        foreach (var MembershipId in activityModal.MembershipIds)
        {
			membershipActivitiesListDTO.Add(new CreateMembershipActivityDTO()
			{
				ActivityId = createdActivityDTO.Id,
				MembershipPlanId = MembershipId
			});
		}
		await _membershipActivityService.CreateNewMembershipActivityAsync(membershipActivitiesListDTO);

		return Json(new { Success = true, Message = "" });
	}

}
