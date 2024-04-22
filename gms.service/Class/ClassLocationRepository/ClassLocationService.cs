using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Class.ClassLocationRepository;
public class ClassLocationService : BaseRepository<GymLocationEntity>, IClassLocationService
{
    private readonly ApplicationDbContext _context;
    public ClassLocationService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
