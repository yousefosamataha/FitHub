using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymRepository;
public class GymService : BaseRepository<GymEntity>, IGymService
{
    private readonly ApplicationDbContext _context;
    public GymService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
