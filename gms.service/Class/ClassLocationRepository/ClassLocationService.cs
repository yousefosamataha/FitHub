using gms.data;
using gms.data.Models.Class;
using gms.services.Base;

namespace gms.service.Class.ClassLocationRepository;
public class ClassLocationService : BaseRepository<ClassLocationEntity>, IClassLocationService
{
    private readonly ApplicationDbContext _context;
    public ClassLocationService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
