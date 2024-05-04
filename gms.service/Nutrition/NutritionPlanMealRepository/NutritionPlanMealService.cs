using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Nutrition.NutritionPlanMealRepository;
public class NutritionPlanMealService : BaseRepository<NutritionPlanMealEntity>, INutritionPlanMealService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public NutritionPlanMealService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
}
