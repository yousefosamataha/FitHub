using gms.data;
using gms.data.Models.Nutrition;
using gms.service.Activity.ActivityCategoryRepository;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Nutrition.NutritionPlanMealRepository;
public class NutritionPlanMealService : BaseRepository<NutritionPlanMealEntity>, INutritionPlanMealService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<ActivityCategoryService> _logger;
	public NutritionPlanMealService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor,
		ILogger<ActivityCategoryService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}
}
