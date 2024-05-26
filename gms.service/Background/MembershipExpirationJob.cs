using gms.data;
using gms.data.Models.Gym;
using gms.data.Models.Membership;
using gms.service.Gym.GymGeneralSettingsRepository;
using gms.service.Gym.GymNotificationRepository;
using gms.service.Membership.GymMemberMembershipRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Background;

public class MembershipExpirationJob
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly IGymMemberMembershipService _gymMemberMembershipService;
	private readonly IGymNotificationService _gymNotificationService;
	private readonly IGymGeneralSettingService _gymGeneralSettingService;
	private readonly ILogger<MembershipExpirationJob> _logger;
	public MembershipExpirationJob
	(
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor,
		IGymMemberMembershipService gymMemberMembershipService,
		IGymNotificationService gymNotificationService,
		IGymGeneralSettingService gymGeneralSettingService,
		ILogger<MembershipExpirationJob> logger
	)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_gymMemberMembershipService = gymMemberMembershipService;
		_gymNotificationService = gymNotificationService;
		_gymGeneralSettingService = gymGeneralSettingService;
		_logger = logger;
	}

	public async Task CheckExpiringMembershipsAsync()
	{
		List<GymMemberMembershipEntity> upcomingExpirations = await _gymMemberMembershipService.GetNeedToReminderMemberShipListByReminderDaysAsync(3);

		foreach (GymMemberMembershipEntity membership in upcomingExpirations)
		{
			GymNotificationEntity notification = new()
			{
				BranchId = membership.GymMembershipPlan.BranchId,
				GymSenderUserId = 1,
				GymReceiverUserId = membership.MemberId,
				NotificationTitle = "Membership Expiration Reminder",
				NotificationMessageBody = string.Format("Your membership will expire on {ExpiringDate} Please renew it in time.", membership.ExpiringDate.ToString("dd/MM/yyyy")),
				IsReaded = false,
				SendDate = DateTime.UtcNow
			};
			//await _gymNotificationService.add
			_context.GymNotifications.Add(notification);
		}

		await _context.SaveChangesAsync();
	}
}
