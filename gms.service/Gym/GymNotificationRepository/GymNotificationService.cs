using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymNotificationRepository;
public class GymNotificationService : BaseRepository<GymNotificationEntity>, IGymNotificationService
{
    private readonly ApplicationDbContext _context;
    public GymNotificationService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
