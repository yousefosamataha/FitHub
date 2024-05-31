using gms.common.Models.GymCat.GymNotification;

namespace gms.service.Gym.GymNotificationRepository;
public interface IGymNotificationService
{
    Task<GymNotificationDTO> CreateGymNotificationAsync(CreateGymNotificationDTO newGymNotification);

    Task<GymNotificationDTO> UpdateGymNotificationAsync(UpdateGymNotificationDTO updateGymNotificationDTO);

    Task<bool> DeleteGymNotificationAsync(int gymNotificationId);

    Task<GymNotificationDTO> GetGymNotificationByIdAsync(int gymNotificationId);

    Task<List<GymNotificationDTO>> GetGymNotificationListForGymAsync();

    Task<List<GymNotificationDTO>> GetGymNotificationListForBranchAsync();

    Task<List<GymNotificationDTO>> GetGymNotificationListByUserIdAsync(int userId);

    Task<List<GymNotificationDTO>> GetGymNotificationListForLoggedinUserAsync();
}
