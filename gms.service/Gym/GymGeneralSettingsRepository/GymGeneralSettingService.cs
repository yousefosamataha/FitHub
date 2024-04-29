using gms.common.Models.GymCat.GymGeneralSetting;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace gms.service.Gym.GymGeneralSettingsRepository;
public class GymGeneralSettingService : BaseRepository<GymGeneralSettingEntity>, IGymGeneralSettingService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymGeneralSettingService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<GeneralSettingDTO> CreateGymGeneralSettingAsync(CreateGeneralSettingDTO newGeneralSetting)
    {
        GymGeneralSettingEntity newGeneralSettingEntity = newGeneralSetting.ToEntity();
        await AddAsync(newGeneralSettingEntity);
        return newGeneralSettingEntity.ToDTO();
    }

	public async Task<GeneralSettingDTO> UpdateGymGeneralSettingAsync(GeneralSettingDTO updateGeneralSettingDTO)
	{
		GymGeneralSettingEntity currentGeneralSettingEntity = await _context.GymGeneralSettings.FirstOrDefaultAsync(gs => gs.Id == updateGeneralSettingDTO.Id);
		GymGeneralSettingEntity updatedGeneralSettingEntity = updateGeneralSettingDTO.ToUpdatedEntity(currentGeneralSettingEntity);
		await UpdateAsync(updatedGeneralSettingEntity);
		return updatedGeneralSettingEntity.ToDTO();
	}
}
