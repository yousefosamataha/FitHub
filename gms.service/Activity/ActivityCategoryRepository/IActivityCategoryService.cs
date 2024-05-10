using gms.common.Models.ActivityCat.ActivityCategory;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityCategoryRepository;
public interface IActivityCategoryService : IBaseRepository<ActivityCategoryEntity>
{
    Task<bool> CreateNewActivityCategoryAsync(CreateActivityCategoryDTO createActivityCategoryModal);
    Task<List<ActivityCategoryDTO>> GetActivityCategoriesListAsync();
    Task<bool> DeleteActivityCategoryAsync(int activityCategoryId);
    Task<ActivityCategoryDTO> GetByIdAsync(int id);
}
