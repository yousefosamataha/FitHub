using gms.common.Models.GymCat.GymGeneralSetting;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.GymGeneralSettingsRepository;
public class GymGeneralSettingService : BaseRepository<GymGeneralSettingEntity>, IGymGeneralSettingService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<GymGeneralSettingService> _logger;
	public GymGeneralSettingService
	(
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor,
		ILogger<GymGeneralSettingService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<GeneralSettingDTO> CreateGymGeneralSettingAsync(CreateGeneralSettingDTO newGeneralSetting)
	{
		GymGeneralSettingEntity newGeneralSettingEntity = newGeneralSetting.ToEntity();
		await AddAsync(newGeneralSettingEntity);
		return newGeneralSettingEntity.ToDTO();
	}

	//public async Task<GeneralSettingDTO> GetGymGeneralSettingAsync()
	//{
	//	GymGeneralSettingEntity gymGeneralSettingEntity = await _context.GymGeneralSettings.FirstOrDefaultAsync(gg => gg.)
	//}

	public async Task<GeneralSettingDTO> UpdateGymGeneralSettingAsync(GeneralSettingDTO updateGeneralSettingDTO)
	{
		GymGeneralSettingEntity currentGeneralSettingEntity = await _context.GymGeneralSettings.FirstOrDefaultAsync(gs => gs.Id == updateGeneralSettingDTO.Id);
		GymGeneralSettingEntity updatedGeneralSettingEntity = updateGeneralSettingDTO.ToUpdatedEntity(currentGeneralSettingEntity);
		await UpdateAsync(updatedGeneralSettingEntity);
		return updatedGeneralSettingEntity.ToDTO();
	}
}
