using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;

namespace gms.service.Nutrition.MealIngredientRepository;
public class MealIngredientService : BaseRepository<MealIngredientEntity>, IMealIngredientService
{
    private readonly ApplicationDbContext _context;
    public MealIngredientService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
