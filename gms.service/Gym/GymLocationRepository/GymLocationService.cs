using gms.common.Models.GymCat.GymLocation;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.GymLocationRepository;

public class GymLocationService : BaseRepository<GymLocationEntity>, IGymLocationService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymLocationService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<GymLocationDTO>> GetGymLocationsListAsync()
    {
        List<GymLocationEntity> listOfGymLocations = await FindAllAsync(gl => gl.BranchId == GetBranchId());
        return listOfGymLocations.Select(gl => gl.ToDTO()).ToList();
    }
}
