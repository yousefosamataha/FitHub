using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymGeneralSettingsRepository;
public class GymGeneralSettingService : BaseRepository<GymGeneralSettingEntity>, IGymGeneralSettingService
{
    private readonly ApplicationDbContext _context;
    public GymGeneralSettingService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
