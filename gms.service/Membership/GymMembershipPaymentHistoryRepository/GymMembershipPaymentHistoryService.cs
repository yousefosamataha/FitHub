using gms.common.Enums;
using gms.common.Models.MembershipCat.MemberMembership;
using gms.common.Models.MembershipCat.MembershipPaymentHistory;
using gms.data;
using gms.data.Mapper.Membership;
using gms.data.Models.Identity;
using gms.data.Models.Membership;
using gms.service.Identity.GymUserRepository;
using gms.service.Membership.GymMemberMembershipRepository;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace gms.service.Membership.GymMembershipPaymentHistoryRepository;
public class GymMembershipPaymentHistoryService : BaseRepository<GymMembershipPaymentHistoryEntity>, IGymMembershipPaymentHistoryService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IGymUserService _gymUserService;
    private readonly IGymMemberMembershipService _gymMemberMembershipService;
	private readonly ILogger<GymMembershipPaymentHistoryService> _logger;
	public GymMembershipPaymentHistoryService
    (
        ApplicationDbContext context, 
        IHttpContextAccessor httpContextAccessor,
        IGymUserService gymUserService, 
        IGymMemberMembershipService gymMemberMembershipService, 
        ILogger<GymMembershipPaymentHistoryService> logger
    ) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_gymUserService = gymUserService;
		_gymMemberMembershipService = gymMemberMembershipService;
		_logger = logger;
	}

	public async Task<MembershipPaymentHistoryDTO> CreateNewMembershipPaymentAsync(CreateMembershipPaymentHistoryDTO membershipPaymentDto)
    {
        GymMembershipPaymentHistoryEntity newMembershipPaymentEntity = membershipPaymentDto.ToEntity();
        newMembershipPaymentEntity.PaymentMethodId = PaymentMethodEnum.Cash;
        newMembershipPaymentEntity.PaidDate = DateTime.UtcNow;
        await AddAsync(newMembershipPaymentEntity);

        GymMemberMembershipEntity currentMembershipMembershipEntity = await _context.GymMemberMemberships.FirstOrDefaultAsync(mm => mm.Id == membershipPaymentDto.GymMemberMembershipId);
        UpdateMemberMembershipDTO updateMembershipMembership = new()
        {
            Id = membershipPaymentDto.GymMemberMembershipId,
            MemberShipStatusId = StatusEnum.Active,
            PaymentStatusId = StatusEnum.FullyPaid,
            JoiningDate = currentMembershipMembershipEntity.JoiningDate,
            ExpiringDate = currentMembershipMembershipEntity.ExpiringDate
        };
        await _gymMemberMembershipService.UpdateMemberMembershipAsync(updateMembershipMembership);

        GymUserEntity currentUserEntity = await _context.Users.FirstOrDefaultAsync(u => u.Id == currentMembershipMembershipEntity.MemberId);
        currentUserEntity.StatusId = StatusEnum.Active;
        await _gymUserService.UpdateGymUser(currentUserEntity);

        return newMembershipPaymentEntity.ToDTO();
    }
}
