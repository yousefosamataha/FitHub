using gms.common.Models.GymCat.Branch;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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

	public async Task<BranchDTO> GetBranchByIdAsync(int branchId)
	{
		GymBranchEntity branchEntity = await FindAsync(gb => gb.Id == branchId, ["Country", "GeneralSetting"]);
		return branchEntity.ToDTO();
	}

	public async Task<BranchDTO> UpdateBranchAsync(BranchDTO updateBranchDTO)
	{
		GymBranchEntity currentBranchEntity = await _context.GymBranches.FirstOrDefaultAsync(ss => ss.Id == updateBranchDTO.Id);
		GymBranchEntity updatedBranchEntity = updateBranchDTO.ToUpdatedEntity(currentBranchEntity);
		await UpdateAsync(updatedBranchEntity);
		return updatedBranchEntity.ToDTO();
	}
}
