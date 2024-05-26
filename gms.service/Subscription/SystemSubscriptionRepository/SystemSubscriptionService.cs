using gms.common.Enums;
using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data;
using gms.data.Mapper.Subscription;
using gms.data.Models.Subscription;
using gms.service.Membership.GymMembershipPlanRepository;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace gms.service.Subscription.SystemSubscriptionRepository;
public class SystemSubscriptionService : BaseRepository<SystemSubscriptionEntity>, ISystemSubscriptionService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<SystemSubscriptionService> _logger;
	public SystemSubscriptionService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, ILogger<SystemSubscriptionService> logger) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<SystemSubscriptionDTO> CreateSystemSubscriptionAsync(CreateSystemSubscriptionDTO newSystemSubscription)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(SystemSubscriptionService), nameof(CreateSystemSubscriptionAsync), DateTime.Now.ToString() });

			SystemSubscriptionEntity systemSubscriptionEntity = newSystemSubscription.ToEntity();
			SystemPlanEntity selectedPlanEntity = await _context.SystemPlans.FirstOrDefaultAsync(p => p.Id == (byte)newSystemSubscription.PlanId);

			if (systemSubscriptionEntity.SubscriptionTypeId == SubscriptionTypeEnum.Monthly)
			{
				systemSubscriptionEntity.SubscriptionAmount = selectedPlanEntity.PricePerMonth;
				systemSubscriptionEntity.SubscriptionStartTime = DateTime.UtcNow;
				if (systemSubscriptionEntity.PlanId == PlansEnum.FreeTrial)
				{
					systemSubscriptionEntity.SubscriptionEndTime = DateTime.UtcNow.AddDays(14);
					systemSubscriptionEntity.SubscriptionStatusId = StatusEnum.Active;
				}
				else
				{
					systemSubscriptionEntity.SubscriptionEndTime = DateTime.UtcNow.AddMonths(1);
					systemSubscriptionEntity.SubscriptionStatusId = StatusEnum.InActive;
				}
			}
			else if (systemSubscriptionEntity.SubscriptionTypeId == SubscriptionTypeEnum.Annually)
			{
				systemSubscriptionEntity.SubscriptionAmount = selectedPlanEntity.PricePerYear;
				systemSubscriptionEntity.SubscriptionStartTime = DateTime.UtcNow;
				if (systemSubscriptionEntity.PlanId == PlansEnum.FreeTrial)
				{
					systemSubscriptionEntity.SubscriptionEndTime = DateTime.UtcNow.AddDays(14);
					systemSubscriptionEntity.SubscriptionStatusId = StatusEnum.Active;
				}
				else
				{
					systemSubscriptionEntity.SubscriptionEndTime = DateTime.UtcNow.AddYears(1);
					systemSubscriptionEntity.SubscriptionStatusId = StatusEnum.InActive;
				}
			}

			await AddAsync(systemSubscriptionEntity);
			return systemSubscriptionEntity.ToDTO();
		}
		
    }

	public async Task<SystemSubscriptionDTO> UpdateSystemSubscriptionAsync(SystemSubscriptionDTO updateSystemSubscriptionDTO)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(SystemSubscriptionService), nameof(UpdateSystemSubscriptionAsync), DateTime.Now.ToString() });

			SystemSubscriptionEntity currentSystemSubscriptionEntity = await _context.SystemSubscriptions.FirstOrDefaultAsync(ss => ss.Id == updateSystemSubscriptionDTO.Id);
			SystemSubscriptionEntity updatedSystemSubscriptionEntity = updateSystemSubscriptionDTO.ToUpdatedEntity(currentSystemSubscriptionEntity);
			await UpdateAsync(updatedSystemSubscriptionEntity);
			return updatedSystemSubscriptionEntity.ToDTO();
		}
		
	}
}
