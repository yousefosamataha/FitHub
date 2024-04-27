using gms.common.Models.Identity;
using gms.data;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;

namespace gms.service.TestUser;
public class GymUserService : IGymUserService
{
    private readonly ApplicationDbContext _context;
    public GymUserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<GymUserDto> UpdateGymUser(GymUserEntity entity)
    {
        _context.Users.Update(entity);
        await _context.SaveChangesAsync();
        return entity.ToDTO();
    }
}
