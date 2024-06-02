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

	public async Task<List<GymBranchDTO>> GetGymBranchesListAsync()
	{
		List<GymBranchEntity> branchesListEntity = await FindAllAsync(gb => gb.GymId == GetGymId());
		return branchesListEntity.Select(b => b.ToDTO()).ToList();
	}

	public async Task<GymBranchDTO> CreateBranchAsync(CreateBranchDTO newBranch)
	{
		GymBranchEntity newBranchEntity = newBranch.ToEntity();
		await AddAsync(newBranchEntity);
		return newBranchEntity.ToDTO();
	}

	public async Task<GymBranchDTO> GetBranchByIdAsync(int branchId)
	{
		GymBranchEntity branchEntity = await FindAsync(gb => gb.Id == branchId, ["Country", "GeneralSetting"]);
		return branchEntity.ToDTO();
	}

	public async Task<GymBranchDTO> UpdateBranchAsync(GymBranchDTO updateBranchDTO)
	{
		GymBranchEntity currentBranchEntity = await _context.GymBranches.FirstOrDefaultAsync(gb => gb.Id == updateBranchDTO.Id);
		GymBranchEntity updatedBranchEntity = updateBranchDTO.ToUpdatedEntity(currentBranchEntity);
		await UpdateAsync(updatedBranchEntity);
		return updatedBranchEntity.ToDTO();
	}
}
