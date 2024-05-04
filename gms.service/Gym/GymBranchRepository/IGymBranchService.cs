using gms.common.Models.GymCat.Branch;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymBranchRepository;
public interface IGymBranchService : IBaseRepository<GymBranchEntity>
{
    Task<BranchDTO> CreateBranchAsync(CreateBranchDTO newBranch);

    Task<BranchDTO> GetBranchByIdAsync(int branchId);
    Task<BranchDTO> UpdateBranchAsync(BranchDTO updateBranchDTO);
}
