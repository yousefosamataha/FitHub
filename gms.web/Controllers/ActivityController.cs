using gms.common.Models.ActivityCat.Activity;
using gms.common.Models.ActivityCat.ActivityCategory;
using gms.common.Models.ActivityCat.ActivityVideo;
using gms.common.Models.ActivityCat.MembershipActivity;
using gms.common.Permissions;
using gms.common.ViewModels.Activity;
using gms.data.Mapper.Activity;
using gms.service.Activity.ActivityCategoryRepository;
using gms.service.Activity.ActivityRepository;
using gms.service.Activity.ActivityVideoRepository;
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
	private readonly IActivityVideoService _activityVideoService;

	public ActivityController
	(
		IActivityService activityService,
		IActivityCategoryService activityCategoryService,
		IGymMembershipPlanService gymMembershipPlanService,
		IMembershipActivityService membershipActivityService,
		IActivityVideoService activityVideoService
	)
	{
		_activityService = activityService;
		_activityCategoryService = activityCategoryService;
		_gymMembershipPlanService = gymMembershipPlanService;
		_membershipActivityService = membershipActivityService;
		_activityVideoService = activityVideoService;
	}

	#region Activity
	[Authorize(ActivityPermissions.View)]
	public async Task<IActionResult> Index()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(Index), DateTime.Now.ToString() });

			List<ActivityDTO> listOfActivities = await _activityService.GetActivitiesListAsync();
			return View(listOfActivities);
		}
	}

	[Authorize(ActivityPermissions.Create)]
	public async Task<IActionResult> AddNewActivity()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction},  HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(AddNewActivity), "HttpGet", DateTime.Now.ToString() });

			AddNewActivityVM modal = new();
			modal.ActivityCategories = await _activityCategoryService.GetActivityCategoriesListAsync();
			modal.Memberships = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();

			return PartialView("_AddNewActivity", modal);
		}

	}

	[HttpPost]
	public async Task<JsonResult> AddNewActivity(AddNewActivityVM activityModal)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(AddNewActivity), "HttpPost", DateTime.Now.ToString() });

			ActivityDTO createdActivityDTO = await _activityService.CreateNewActivityAsync(activityModal.Activity);
			List<CreateActivityVideoDTO> ActivityVideosListDTO = new();
			List<CreateMembershipActivityDTO> membershipActivitiesListDTO = new();
			foreach (int MembershipId in activityModal.MembershipIds)
			{
				membershipActivitiesListDTO.Add(new CreateMembershipActivityDTO()
				{
					ActivityId = createdActivityDTO.Id,
					MembershipPlanId = MembershipId
				});
			}
			await _membershipActivityService.CreateNewMembershipActivityAsync(membershipActivitiesListDTO);
			if (activityModal.ActivityVideos is not null)
			{
				foreach (string activityVideoUrl in activityModal.ActivityVideos)
				{
					ActivityVideosListDTO.Add(new CreateActivityVideoDTO()
					{
						ActivityId = createdActivityDTO.Id,
						VideoPath = activityVideoUrl
					});
				}
			}
			await _activityVideoService.CreateNewActivityVideosAsync(ActivityVideosListDTO);

			return Json(new { Success = true, Message = "" });
		}

	}

	[HttpGet]
	[Authorize(ActivityPermissions.Edit)]
	public async Task<IActionResult> EditActivity(int id)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(EditActivity), "HttpGet", DateTime.Now.ToString() });

			UpdateActivityVM modal = new();
			ActivityDTO activity = await _activityService.GetActivityAsync(id);
			modal.ActivityCategories = await _activityCategoryService.GetActivityCategoriesListAsync();
			modal.Memberships = await _gymMembershipPlanService.GetActiveMembershipPlansListAsync();
			modal.Activity = activity.ToUpdateDTO();
			modal.ActivityVideos = new List<string>();
			List<ActivityVideoDTO> ActivityVideosList = await _activityVideoService.GetActivityVideosListAsync(id);
			foreach (var av in ActivityVideosList)
			{
				modal.ActivityVideos.Add(av.VideoPath);
			}

			return PartialView("_EditActivity", modal);
		}
	}

	[HttpPost]
	public async Task<JsonResult> EditActivity(UpdateActivityVM updateActivityDTO)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(EditActivity), "HttpPost", DateTime.Now.ToString() });

			ActivityDTO updatedActivityDTO = await _activityService.UpdateActivityAsync(updateActivityDTO.Activity);
			List<CreateMembershipActivityDTO> updateMembershipActivitiesListDTO = new();
			List<CreateActivityVideoDTO> updateActivityVideosListDTO = new();
			foreach (var MembershipId in updateActivityDTO.MembershipIds)
			{
				updateMembershipActivitiesListDTO.Add(new CreateMembershipActivityDTO()
				{
					ActivityId = updatedActivityDTO.Id,
					MembershipPlanId = MembershipId
				});
			}
			await _membershipActivityService.UpdateMembershipActivityAsync(updateMembershipActivitiesListDTO, updatedActivityDTO.Id);
			if (updateActivityDTO.ActivityVideos is not null)
			{
				foreach (var av in updateActivityDTO.ActivityVideos)
				{
					updateActivityVideosListDTO.Add(new CreateActivityVideoDTO()
					{
						ActivityId = updatedActivityDTO.Id,
						VideoPath = av
					});
				}
			}
			await _activityVideoService.UpdateActivityVideosAsync(updateActivityVideosListDTO, updatedActivityDTO.Id);
			return Json(new { Success = true, Message = "" });
		}

	}

	[HttpGet]
	public async Task<IActionResult> GetActivityMembershipsById(int activityId)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(GetActivityMembershipsById), "HttpGet", DateTime.Now.ToString() });

			List<MembershipActivityDTO> activityMembershipsList = await _membershipActivityService.GetActivityMembershipsListAsync(activityId);

			return Json(new { Success = true, Message = "", Data = activityMembershipsList });
		}

	}

	[HttpPost]
	public async Task<JsonResult> DeleteActivity(int id)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(DeleteActivity), "HttpDelete", DateTime.Now.ToString() });

			await _activityService.DeleteActivityAsync(id);
			return Json(new { Success = true, Message = "" });
		}

	}
	#endregion

	public async Task<IActionResult> ActivityVideos(int activityId)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(ActivityVideos), "HttpGet", DateTime.Now.ToString() });

			List<ActivityVideoDTO> activityVideosList = await _activityVideoService.GetActivityVideosListAsync(activityId);
			return View(activityVideosList);
		}

	}

	#region ActivityCategory
	public async Task<IActionResult> AddNewActivityCategory()
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(AddNewActivityCategory), "HttpGet", DateTime.Now.ToString() });

			ActivityCategoryVM modal = new();

			modal.ActivityCategoryList = await _activityCategoryService.GetActivityCategoriesListAsync();

			return PartialView("_AddNewActivityCategory", modal);
		}

	}

	[HttpPost]
	public async Task<JsonResult> AddNewActivityCategory(CreateActivityCategoryDTO activityCategoryModal)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(AddNewActivityCategory), "HttpPost", DateTime.Now.ToString() });

			await _activityCategoryService.CreateNewActivityCategoryAsync(activityCategoryModal);
			return Json(new { Success = true, Message = "" });
		}

	}

	[HttpPost]
	public async Task<JsonResult> DeleteActivityCategory(int id)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityController), nameof(DeleteActivityCategory), "HttpDelete", DateTime.Now.ToString() });

			await _activityCategoryService.DeleteActivityCategoryAsync(id);
			return Json(new { Success = true, Message = "" });
		}

	}
	#endregion
}
