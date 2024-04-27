using gms.common.Models.GymCat.Branch;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.GymBranchRepository;
public class GymBranchService : BaseRepository<GymBranchEntity>, IGymBranchService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymBranchService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }


    public async Task<BranchDTO> CreateBranchAsync(CreateBranchDTO newBranch)
    {
        GymBranchEntity newBranchEntity = newBranch.ToEntity();
        await AddAsync(newBranchEntity);
        return newBranchEntity.ToDTO();
    }
}
