using gms.data;
using gms.data.Models.Event;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Event.GymEventReservationRepository;
public class GymEventReservationService : BaseRepository<GymEventReservationEntity>, IGymEventReservationService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymEventReservationService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

}
