using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Nutrition.NutritionPlanRepository;
public class NutritionPlanService : BaseRepository<NutritionPlanEntity>, INutritionPlanService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<NutritionPlanService> _logger;
	public NutritionPlanService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor, 
		ILogger<NutritionPlanService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}
}
