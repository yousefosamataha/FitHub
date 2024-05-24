using gms.common.Models.GymCat.GymGeneralSetting;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymGeneralSettingsRepository;
public interface IGymGeneralSettingService : IBaseRepository<GymGeneralSettingEntity>
{
	Task<GeneralSettingDTO> CreateGymGeneralSettingAsync(CreateGeneralSettingDTO newGeneralSetting);

	Task<GeneralSettingDTO> UpdateGymGeneralSettingAsync(GeneralSettingDTO updateGeneralSettingDTO);

	//Task<GeneralSettingDTO> GetGymGeneralSettingAsync();
}
