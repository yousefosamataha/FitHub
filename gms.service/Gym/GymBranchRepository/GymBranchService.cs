using gms.common.Models.GymCat.Branch;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.GymBranchRepository;
public class GymBranchService : BaseRepository<GymBranchEntity>, IGymBranchService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<GymBranchService> _logger;
	public GymBranchService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor, 
		ILogger<GymBranchService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<BranchDTO> CreateBranchAsync(CreateBranchDTO newBranch)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymBranchService), nameof(CreateBranchAsync), DateTime.Now.ToString() });

			GymBranchEntity newBranchEntity = newBranch.ToEntity();
			await AddAsync(newBranchEntity);
			return newBranchEntity.ToDTO();
		}
		
	}

	public async Task<BranchDTO> GetBranchByIdAsync(int branchId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymBranchService), nameof(GetBranchByIdAsync), DateTime.Now.ToString() });

			GymBranchEntity branchEntity = await FindAsync(gb => gb.Id == branchId, ["Country"]);
			return branchEntity.ToDTO();
		}
		
	}

	public async Task<BranchDTO> UpdateBranchAsync(BranchDTO updateBranchDTO)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymBranchService), nameof(UpdateBranchAsync), DateTime.Now.ToString() });

			GymBranchEntity currentBranchEntity = await _context.GymBranches.FirstOrDefaultAsync(ss => ss.Id == updateBranchDTO.Id);
			GymBranchEntity updatedBranchEntity = updateBranchDTO.ToUpdatedEntity(currentBranchEntity);
			await UpdateAsync(updatedBranchEntity);
			return updatedBranchEntity.ToDTO();
		}
		
	}
}
