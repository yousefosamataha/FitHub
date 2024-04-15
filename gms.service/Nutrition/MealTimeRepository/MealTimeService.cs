using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;

namespace gms.service.Nutrition.MealTimeRepository;
public class MealTimeService : BaseRepository<MealTimeEntity>, IMealTimeService
{
    private readonly ApplicationDbContext _context;
    public MealTimeService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
