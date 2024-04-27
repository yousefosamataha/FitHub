using gms.data;
using gms.data.Models.Class;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Class.ClassScheduleDayRepository;
public class ClassScheduleDayService : BaseRepository<ClassScheduleDayEntity>, IClassScheduleDayService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ClassScheduleDayService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

}
