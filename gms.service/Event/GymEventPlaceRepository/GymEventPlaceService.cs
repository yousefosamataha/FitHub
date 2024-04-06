using gms.data;
using gms.data.Models.Event;
using gms.services.Base;

namespace gms.service.Event.GymEventPlaceRepository;
public class GymEventPlaceService : BaseRepository<GymEventPlaceEntity>, IGymEventPlaceService
{
    private readonly ApplicationDbContext _context;
    public GymEventPlaceService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
