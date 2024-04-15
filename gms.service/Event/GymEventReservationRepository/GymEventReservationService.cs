using gms.data;
using gms.data.Models.Event;
using gms.services.Base;

namespace gms.service.Event.GymEventReservationRepository;
public class GymEventReservationService : BaseRepository<GymEventReservationEntity>, IGymEventReservationService
{
    private readonly ApplicationDbContext _context;
    public GymEventReservationService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
