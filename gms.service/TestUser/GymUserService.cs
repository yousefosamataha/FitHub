using gms.common.Models.Identity;
using gms.data;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;

namespace gms.service.TestUser;
public class GymUserService : IGymUserService
{
    private readonly ApplicationDbContext _context;
    public GymUserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<GymUserEntity> GetGymUserByEmail(string email)
    {
        var entity = await _context.Users
                                   .Include(u => u.GymBranch)
                                   .ThenInclude(gb => gb.Gym)
                                   .FirstOrDefaultAsync(u => string.Equals(u.Email.ToLower().Trim(), email.ToLower().Trim()));
        return entity;
    }

    public async Task<GymUserDto> UpdateGymUser(GymUserEntity entity)
    {
        _context.Users.Update(entity);
        await _context.SaveChangesAsync();
        return entity.ToDTO();
    }
}
