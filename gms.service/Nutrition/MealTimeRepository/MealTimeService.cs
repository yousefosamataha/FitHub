using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Nutrition.MealTimeRepository;
public class MealTimeService : BaseRepository<MealTimeEntity>, IMealTimeService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public MealTimeService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
}