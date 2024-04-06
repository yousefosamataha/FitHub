using gms.data;
using gms.data.Models.Class;
using gms.services.Base;

namespace gms.service.Class.ClassScheduleDayRepository;
public class ClassScheduleDayService : BaseRepository<ClassScheduleDayEntity>, IClassScheduleDayService
{
    private readonly ApplicationDbContext _context;
    public ClassScheduleDayService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
