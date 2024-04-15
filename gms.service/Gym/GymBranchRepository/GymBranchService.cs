using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymBranchRepository;
public class GymBranchService : BaseRepository<GymBranchEntity>, IGymBranchService
{
    private readonly ApplicationDbContext _context;
    public GymBranchService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
