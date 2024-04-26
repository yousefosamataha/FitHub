using gms.common.Models.GymCat.Gym;
using gms.data;
using gms.data.Mapper.Gym;
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

    public async Task<GymDTO> CreateGymAsync(CreateGymDTO newGym)
    {
        GymEntity newGymEntity = newGym.ToEntity();
        // newGymEntity.IsDeleted = false;
        newGymEntity.CreatedAt = DateTime.UtcNow.AddHours(2);
        await AddAsync(newGymEntity);
        return newGymEntity.ToDTO();
    }
}
