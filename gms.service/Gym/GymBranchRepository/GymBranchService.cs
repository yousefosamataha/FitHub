using gms.common.Models.GymCat.Branch;
using gms.data;
using gms.data.Mapper.Gym;
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

    public async Task<BranchDTO> CreateBranchAsync(CreateBranchDTO newBranch)
    {
        GymBranchEntity newBranchEntity = newBranch.ToEntity();
        await AddAsync(newBranchEntity);
        return newBranchEntity.ToDTO();
    }
}
