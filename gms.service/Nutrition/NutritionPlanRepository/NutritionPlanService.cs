using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Nutrition.NutritionPlanRepository;
public class NutritionPlanService : BaseRepository<NutritionPlanEntity>, INutritionPlanService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public NutritionPlanService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
}
