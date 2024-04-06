using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymMeasurementRepository;
public class GymMeasurementService : BaseRepository<GymMeasurementEntity>, IGymMeasurementService
{
    private readonly ApplicationDbContext _context;
    public GymMeasurementService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
