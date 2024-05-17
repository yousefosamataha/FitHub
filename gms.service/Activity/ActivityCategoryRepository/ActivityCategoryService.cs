using FluentResults;
using gms.common.Models.ActivityCat.ActivityCategory;
using gms.data;
using gms.data.Mapper.Activity;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Activity.ActivityCategoryRepository;
public class ActivityCategoryService : BaseRepository<ActivityCategoryEntity>, IActivityCategoryService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public ActivityCategoryService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public async Task<Result> CreateNewActivityCategoryAsync(CreateActivityCategoryDTO createActivityCategoryModal)
	{
		ActivityCategoryEntity activityCategoryEntity = createActivityCategoryModal.ToEntity();
		activityCategoryEntity.BranchId = GetBranchId();
		await AddAsync(activityCategoryEntity);
		return Result.Ok();
	}

	public async Task<Result<List<ActivityCategoryDTO>>> GetActivityCategoriesListAsync()
	{
		List<ActivityCategoryEntity> activityCategoriesList = await FindAllAsync(ac => ac.BranchId == GetBranchId());
		if (activityCategoriesList is null || !activityCategoriesList.Any())
		{
			return Result.Fail(new Error(""));
		}
		return Result.Ok(activityCategoriesList.Select(a => a.ToDTO()).ToList());
	}

	public async Task<Result> DeleteActivityCategoryAsync(int activityCategoryId)
	{
		ActivityCategoryEntity activityCategoryEntity = await FindAsync(ac => ac.Id == activityCategoryId && ac.BranchId == GetBranchId());
		await DeleteAsync(activityCategoryEntity);
		return Result.Ok();
	}

	public async Task<Result<ActivityCategoryDTO>> GetByIdAsync(int id)
	{
		ActivityCategoryEntity entity = await base.GetByIdAsync(id);
		if (entity is null)
		{
			return Result.Fail(new Error(""));
		}
		return Result.Ok(entity.ToDTO());
	}
}
