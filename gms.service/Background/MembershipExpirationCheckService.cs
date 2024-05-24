using gms.data;
using gms.data.Models.Gym;
using gms.data.Models.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace gms.service.Background;
public class MembershipExpirationCheckService : BackgroundService
{
	private readonly IServiceProvider _serviceProvider;

	public MembershipExpirationCheckService(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}
	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		while (!stoppingToken.IsCancellationRequested)
		{
			await CheckExpiringMembershipsAsync();
			await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
		}
	}
	private async Task CheckExpiringMembershipsAsync()
	{
		using (IServiceScope? scope = _serviceProvider.CreateScope())
		{
			ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

			List<GymMemberMembershipEntity> upcomingExpirations = await context.GymMemberMemberships
																			   .Where(m => m.ExpiringDate <= DateTime.UtcNow.AddDays(3) && m.ExpiringDate > DateTime.UtcNow)
																			   .ToListAsync();

			foreach (GymMemberMembershipEntity membership in upcomingExpirations)
			{
				GymNotificationEntity notification = new()
				{
					BranchId = membership.GymMembershipPlan.BranchId,
					GymSenderUserId = 1,
					GymReceiverUserId = membership.MemberId,
					NotificationTitle = "Membership Expiration Reminder",
					NotificationMessageBody = string.Format("Your membership will expire on {ExpiringDate}. Please renew it in time.", membership.ExpiringDate.ToString()),
					IsReaded = false,
					SendDate = DateTime.UtcNow
				};

				context.GymNotifications.Add(notification);
			}

			await context.SaveChangesAsync();
		}
	}
}
