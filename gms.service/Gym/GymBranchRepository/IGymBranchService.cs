using gms.common.Models.GymCat.Branch;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymBranchRepository;
public interface IGymBranchService : IBaseRepository<GymBranchEntity>
{
    Task<GymBranchDTO> CreateBranchAsync(CreateBranchDTO newBranch);

    Task<GymBranchDTO> GetBranchByIdAsync(int branchId);
    Task<GymBranchDTO> UpdateBranchAsync(GymBranchDTO updateBranchDTO);
}
