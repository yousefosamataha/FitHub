using gms.service.Background;
using Hangfire;

namespace gms.web.Extensions.HangFire;

public static class HangFireJobsExtensions
{
	public static void AddHangFireJobs()
	{
		// Schedule the job
		RecurringJob.AddOrUpdate<MembershipExpirationJob>(
			job => job.CheckExpiringMembershipsAsync(),
			Cron.Hourly);
	}

}