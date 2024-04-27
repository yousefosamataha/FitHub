using gms.common.Models.GymCat.Gym;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.GymRepository;
public class GymService : BaseRepository<GymEntity>, IGymService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }


    public async Task<GymDTO> CreateGymAsync(CreateGymDTO newGym)
    {
        GymEntity newGymEntity = newGym.ToEntity();
        await AddAsync(newGymEntity);
        return newGymEntity.ToDTO();
    }
}
