using gms.common.Models.GymCat.GymStaffSpecialization;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.GymStaffSpecializationRepository;

public class GymStaffSpecializationService : BaseRepository<GymStaffSpecializationEntity>, IGymStaffSpecializationService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public GymStaffSpecializationService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public async Task<bool> CreateNewGymStaffSpecializationAsync(List<CreateGymStaffSpecializationDTO> gymStaffSpecializationsListDto)
	{
		List<GymStaffSpecializationEntity> createGymStaffSpecializationsList = gymStaffSpecializationsListDto.Select(sg => sg.ToEntity()).ToList();
		await AddRangeAsync(createGymStaffSpecializationsList);
		return true;
	}

	public async Task<bool> UpdateGymStaffSpecializationAsync(List<CreateGymStaffSpecializationDTO> updateGymStaffSpecializationsListDto, int staffId)
	{
		List<GymStaffSpecializationEntity> currentGymStaffSpecializationsList = _context.GymStaffSpecializations.Where(mg => mg.GymStaffId == staffId).ToList();
		_context.GymStaffSpecializations.RemoveRange(currentGymStaffSpecializationsList);
		await _context.SaveChangesAsync();
		List<GymStaffSpecializationEntity> newGymStaffSpecializationsList = updateGymStaffSpecializationsListDto.Select(mg => mg.ToEntity()).ToList();
		await AddRangeAsync(newGymStaffSpecializationsList);
		return true;
	}
}
