using gms.common.Models.ActivityCat.ActivityCategory;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityCategoryRepository;
public interface IActivityCategoryService : IBaseRepository<ActivityCategoryEntity>
{
	Task<List<ActivityCategoryDTO>> GetActivityCategoriesListAsync();
    Task<ActivityCategoryDTO> GetByIdAsync(int id);
}
