using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.MeasurementImageRepository;
public class MeasurementImageService : BaseRepository<MeasurementImageEntity>, IMeasurementImageService
{
    private readonly ApplicationDbContext _context;
    public MeasurementImageService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
