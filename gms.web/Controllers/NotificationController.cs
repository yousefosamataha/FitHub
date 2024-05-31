using gms.common.Models.GymCat.GymNotification;
using gms.service.Gym.GymNotificationRepository;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;
public class NotificationController : BaseController<NotificationController>
{
    private readonly IGymNotificationService _gymNotificationService;
    public NotificationController(IGymNotificationService gymNotificationService)
    {
        _gymNotificationService = gymNotificationService;
    }

    public async Task<IActionResult> Index()
    {
        List<GymNotificationDTO> gymNotifications = await _gymNotificationService.GetGymNotificationListForBranchAsync();
        return View(gymNotifications);
    }
}
