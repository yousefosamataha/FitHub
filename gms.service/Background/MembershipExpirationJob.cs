using gms.common.Models.GymCat.Branch;
using gms.data;
using gms.data.Models.Gym;
using gms.data.Models.Membership;
using gms.service.Gym.GymBranchRepository;
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
	private readonly IGymBranchService _gymBranchService;
	private readonly ILogger<MembershipExpirationJob> _logger;
	public MembershipExpirationJob
	(
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor,
		IGymMemberMembershipService gymMemberMembershipService,
		IGymNotificationService gymNotificationService,
		IGymGeneralSettingService gymGeneralSettingService,
		IGymBranchService gymBranchService,
		ILogger<MembershipExpirationJob> logger
	)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_gymMemberMembershipService = gymMemberMembershipService;
		_gymNotificationService = gymNotificationService;
		_gymGeneralSettingService = gymGeneralSettingService;
		_gymBranchService = gymBranchService;
		_logger = logger;
	}

	public async Task CheckExpiringMembershipsAsync()
	{
		List<IGrouping<int, GymMemberMembershipEntity>> upcomingExpirations = await _gymMemberMembershipService.GetNeedToReminderMemberShipListAsync();

		foreach (var branchMemberMembershipGroup in upcomingExpirations)
		{
			BranchDTO BranchData = await _gymBranchService.GetBranchByIdAsync(branchMemberMembershipGroup.Key);

			foreach (GymMemberMembershipEntity gymMemberMembership in branchMemberMembershipGroup)
			{
				if (gymMemberMembership.ExpiringDate.AddDays(-BranchData.GeneralSetting.ReminderDays).Date == DateTime.UtcNow.Date)
				{
					GymNotificationEntity notification = new()
					{
						BranchId = BranchData.Id,
						GymSenderUserId = _gymBranchService.GetUserId(),
						GymReceiverUserId = gymMemberMembership.MemberId,
						NotificationTitle = "Membership Expiration Reminder",
						NotificationMessageBody = string.Format(BranchData.GeneralSetting.ReminderMessage, $"{gymMemberMembership.GymMemberUser.FirstName} {gymMemberMembership.GymMemberUser.LastName}", gymMemberMembership.GymMembershipPlan.MembershipName, gymMemberMembership.ExpiringDate.ToString("dd/MM/yyyy")),
						IsReaded = false,
						SendDate = DateTime.UtcNow
					};
					_context.GymNotifications.Add(notification);
					await _context.SaveChangesAsync();
				}
			}
		}
	}
}
