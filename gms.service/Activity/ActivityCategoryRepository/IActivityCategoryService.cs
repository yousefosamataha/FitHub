using FluentResults;
using gms.common.Models.ActivityCat.ActivityCategory;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityCategoryRepository;
public interface IActivityCategoryService : IBaseRepository<ActivityCategoryEntity>
{
	Task<Result> CreateNewActivityCategoryAsync(CreateActivityCategoryDTO createActivityCategoryModal);

	Task<Result<List<ActivityCategoryDTO>>> GetActivityCategoriesListAsync();

	Task<Result> DeleteActivityCategoryAsync(int activityCategoryId);

	Task<Result<ActivityCategoryDTO>> GetByIdAsync(int id);
}
