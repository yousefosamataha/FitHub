using gms.data;
using gms.data.Models.Class;
using gms.services.Base;

namespace gms.service.Class.ClassScheduleRepository;
public class ClassScheduleService : BaseRepository<ClassScheduleEntity>, IClassScheduleService
{
    private readonly ApplicationDbContext _context;
    public ClassScheduleService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
