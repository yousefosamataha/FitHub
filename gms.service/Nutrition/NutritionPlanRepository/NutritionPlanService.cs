using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;

namespace gms.service.Nutrition.NutritionPlanRepository;
public class NutritionPlanService : BaseRepository<NutritionPlanEntity>, INutritionPlanService
{
    private readonly ApplicationDbContext _context;
    public NutritionPlanService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
