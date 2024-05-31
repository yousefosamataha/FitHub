using gms.common.Models.GymCat.GymNotification;

namespace gms.service.Gym.GymNotificationRepository;
public interface IGymNotificationService
{
	Task<GymNotificationDTO> CreateGymNotifiacationAsync(CreateGymNotificationDTO newGymNotification);


	Task<List<GymNotificationDTO>> GetGymNotificationListForGymAsync();

	Task<List<GymNotificationDTO>> GetGymNotificationListForBranchAsync();

	Task<List<GymNotificationDTO>> GetGymNotificationListByUserIdhAsync(int userId);

	Task<List<GymNotificationDTO>> GetGymNotificationListForLoggedinUserAsync();
}
