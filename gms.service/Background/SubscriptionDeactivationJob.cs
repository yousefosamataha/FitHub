using gms.common.Enums;
using gms.data;
using gms.data.Models.Subscription;
using Microsoft.EntityFrameworkCore;

namespace gms.service.Background;

public class SubscriptionDeactivationJob
{
	private readonly ApplicationDbContext _context;

	public SubscriptionDeactivationJob(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task DeactivateSubscriptionAsync(int systemSubscriptionId)
	{
		SystemSubscriptionEntity systemSubscription = await _context.SystemSubscriptions.FirstOrDefaultAsync(ss => ss.Id == systemSubscriptionId);
		if (systemSubscription is not null)
		{
			systemSubscription.SubscriptionStatusId = StatusEnum.InActive;
			await _context.SaveChangesAsync();
		}
	}
}
