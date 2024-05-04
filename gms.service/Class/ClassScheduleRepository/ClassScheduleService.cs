using gms.data;
using gms.data.Models.Class;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Class.ClassScheduleRepository;
public class ClassScheduleService : BaseRepository<ClassScheduleEntity>, IClassScheduleService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ClassScheduleService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

}
