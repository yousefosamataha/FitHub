using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Nutrition.MealIngredientRepository;
public class MealIngredientService : BaseRepository<MealIngredientEntity>, IMealIngredientService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<MealIngredientService> _logger;
	public MealIngredientService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor, 
		ILogger<MealIngredientService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

}
