using gms.common.Models.GymCat.GymSpecialization;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.GymSpecializationRepository;

public class GymSpecializationService : BaseRepository<GymSpecializationEntity>, IGymSpecializationService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public GymSpecializationService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public async Task<bool> CreateNewGymSpecializationAsync(CreateGymSpecializationDTO createGymSpecializationModal)
	{
		GymSpecializationEntity gymSpecializationEntity = createGymSpecializationModal.ToEntity();
		gymSpecializationEntity.BranchId = GetBranchId();
		await AddAsync(gymSpecializationEntity);
		return true;
	}

	public async Task<List<GymSpecializationDTO>> GetGymSpecializationsListAsync()
	{
		List<GymSpecializationEntity> listOfGymSpecializations = await FindAllAsync(gs => gs.BranchId == GetBranchId());
		return listOfGymSpecializations.Select(gs => gs.ToDTO()).ToList();
	}

	public async Task<bool> DeleteGymSpecializationAsync(int gymSpecializationId)
	{
		GymSpecializationEntity gymSpecializationEntity = await FindAsync(gs => gs.Id == gymSpecializationId && gs.BranchId == GetBranchId());
		await DeleteAsync(gymSpecializationEntity);
		return true;
	}
}
