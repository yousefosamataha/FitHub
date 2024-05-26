using gms.common.Enums;
using gms.common.Models.MembershipCat.MemberMembership;
using gms.data;
using gms.data.Mapper.Membership;
using gms.data.Models.Membership;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace gms.service.Membership.GymMemberMembershipRepository;
public class GymMemberMembershipService : BaseRepository<GymMemberMembershipEntity>, IGymMemberMembershipService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<GymMemberMembershipService> _logger;
	public GymMemberMembershipService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor,
		ILogger<GymMemberMembershipService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<List<MemberMembershipDTO>> GetGymMemberMembershipListAsync()
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMemberMembershipService), nameof(GetGymMemberMembershipListAsync), DateTime.Now.ToString() });

			List<GymMemberMembershipEntity> MemberMembershipList = await FindAllAsync(gmm => gmm.GymMemberUser.BranchId == GetBranchId(), ["GymMemberUser", "GymMembershipPlan", "MembershipPaymentHistories"]);
			return MemberMembershipList.Select(gmm => gmm.ToDTO()).ToList();
		}
		
	}

	public async Task<MemberMembershipDTO> GetGymMemberMembershipByIdAsync(int memberMembershipId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMemberMembershipService), nameof(GetGymMemberMembershipByIdAsync), DateTime.Now.ToString() });

			GymMemberMembershipEntity MemberMembership = await FindAsync(gmm => gmm.GymMemberUser.BranchId == GetBranchId() && gmm.Id == memberMembershipId, ["GymMemberUser", "GymMembershipPlan", "MembershipPaymentHistories"]);
			return MemberMembership.ToDTO();
		}
		
	}

	public async Task<MemberMembershipDTO> CreateNewMemberMembershipAsync(CreateMemberMembershipDTO memberMembershipDto, int memberId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMemberMembershipService), nameof(CreateNewMemberMembershipAsync), DateTime.Now.ToString() });

			GymMemberMembershipEntity newMemberMembershipEntity = memberMembershipDto.ToEntity();
			newMemberMembershipEntity.MemberId = memberId;
			newMemberMembershipEntity.MemberShipStatusId = StatusEnum.InActive;
			newMemberMembershipEntity.PaymentStatusId = StatusEnum.NotPaid;
			await AddAsync(newMemberMembershipEntity);
			return newMemberMembershipEntity.ToDTO();
		}
		
	}

	public async Task<MemberMembershipDTO> UpdateMemberMembershipAsync(UpdateMemberMembershipDTO updateMemberMembershipDto)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMemberMembershipService), nameof(UpdateMemberMembershipAsync), DateTime.Now.ToString() });

			GymMemberMembershipEntity currentMembershipMembershipEntity = await _context.GymMemberMemberships.FirstOrDefaultAsync(mm => mm.Id == updateMemberMembershipDto.Id);
			GymMemberMembershipEntity updatedMembershipMembershipEntity = updateMemberMembershipDto.ToUpdatedEntity(currentMembershipMembershipEntity);
			await UpdateAsync(updatedMembershipMembershipEntity);
			return updatedMembershipMembershipEntity.ToDTO();
		}
		
	}

	public async Task<List<IGrouping<int, GymMemberMembershipEntity>>> GetNeedToReminderMemberShipListAsync()
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMemberMembershipService), nameof(GetNeedToReminderMemberShipListAsync), DateTime.Now.ToString() });

			List<IGrouping<int, GymMemberMembershipEntity>> result = await _context.GymMemberMemberships.GroupBy(gmm => gmm.GymMemberUser.BranchId).ToListAsync();
			return result;
		}
		
	}
}
