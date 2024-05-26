using gms.common.Models.ActivityCat.ActivityCategory;
using gms.data;
using gms.data.Mapper.Activity;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Activity.ActivityCategoryRepository;
public class ActivityCategoryService : BaseRepository<ActivityCategoryEntity>, IActivityCategoryService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<ActivityCategoryService> _logger;
	public ActivityCategoryService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, ILogger<ActivityCategoryService> logger) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<bool> CreateNewActivityCategoryAsync(CreateActivityCategoryDTO createActivityCategoryModal)
	{
		ActivityCategoryEntity activityCategoryEntity = createActivityCategoryModal.ToEntity();
		activityCategoryEntity.BranchId = GetBranchId();
		await AddAsync(activityCategoryEntity);
		return true;
	}

	public async Task<List<ActivityCategoryDTO>> GetActivityCategoriesListAsync()
	{
		List<ActivityCategoryEntity> activityCategoriesList = await FindAllAsync(ac => ac.BranchId == GetBranchId());
		return activityCategoriesList.Select(a => a.ToDTO()).ToList();
	}

	public async Task<bool> DeleteActivityCategoryAsync(int activityCategoryId)
	{
		ActivityCategoryEntity activityCategoryEntity = await FindAsync(ac => ac.Id == activityCategoryId && ac.BranchId == GetBranchId());
		await DeleteAsync(activityCategoryEntity);
		return true;
	}

	public async Task<ActivityCategoryDTO> GetByIdAsync(int id)
	{
		ActivityCategoryEntity entity = await base.GetByIdAsync(id);
		return entity.ToDTO();
	}
}
