using gms.common.Enums;
using gms.common.Models.MembershipCat.MembershipPaymentHistory;
using gms.data;
using gms.data.Mapper.Membership;
using gms.data.Models.Membership;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Membership.GymMembershipPaymentHistoryRepository;
public class GymMembershipPaymentHistoryService : BaseRepository<GymMembershipPaymentHistoryEntity>, IGymMembershipPaymentHistoryService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymMembershipPaymentHistoryService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<MembershipPaymentHistoryDTO> CreateNewMembershipPaymentAsync(CreateMembershipPaymentHistoryDTO membershipPaymentDto)
    {
        GymMembershipPaymentHistoryEntity newMembershipPaymentEntity = membershipPaymentDto.ToEntity();
        newMembershipPaymentEntity.PaymentMethodId = PaymentMethodEnum.Cash;
        newMembershipPaymentEntity.PaidDate = DateTime.UtcNow;
        var result = await AddAsync(newMembershipPaymentEntity);
        return newMembershipPaymentEntity.ToDTO();
    }
}
