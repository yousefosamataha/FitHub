using gms.common.Models.Gym;
using gms.data;
using gms.data.Mapping;
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

    public async Task<GymDTO> CreateGym(CreateGymDTO newGym)
    {
        GymEntity newGymEntity = newGym.ToGymEntity();
        await _context.AddAsync(newGymEntity);
        await _context.SaveChangesAsync();
        return (GymDTO)newGymEntity;
    }
}
