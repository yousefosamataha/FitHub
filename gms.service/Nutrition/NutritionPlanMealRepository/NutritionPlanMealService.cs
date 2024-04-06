using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;

namespace gms.service.Nutrition.NutritionPlanMealRepository;
public class NutritionPlanMealService : BaseRepository<NutritionPlanMealEntity>, INutritionPlanMealService
{
    private readonly ApplicationDbContext _context;
    public NutritionPlanMealService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
