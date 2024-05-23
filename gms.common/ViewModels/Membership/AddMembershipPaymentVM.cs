namespace gms.common.ViewModels.Membership;

public class AddMembershipPaymentVM
{
    public int MemberMembershipId { get; set; }
    public decimal Price { get; set; }
    public decimal PaidAmount { get; set; }
    public decimal DueAmount { get; set; }
    public decimal SignupFee { get; set; }
    public decimal Amount { get; set; }
}
