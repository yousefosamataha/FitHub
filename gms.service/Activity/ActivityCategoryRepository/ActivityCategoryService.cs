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

	public async Task<List<ActivityCategoryDTO>> GetActivityCategoriesListAsync()
	{
		List<ActivityCategoryEntity> activityCategoriesList = await FindAllAsync(ac => ac.BranchId == GetBranchId());
		return activityCategoriesList.Select(a => a.ToDTO()).ToList();
	}

	public async Task<ActivityCategoryDTO> GetByIdAsync(int id)
    {
        ActivityCategoryEntity entity = await base.GetByIdAsync(id);

        return entity.ToDTO();
    }
}
