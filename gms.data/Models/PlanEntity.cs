using gms.data.Models.Base;

namespace gms.data.Models;

public class PlanEntity : BaseEntity
{
    public required string PlanName { get; set; }
    public int ReminderDays { get; set; }
    public decimal PricePerMonth { get; set; }
    public decimal PricePerYear { get; set; }
    public int MaxBranchNumber { get; set; }
    public int MaxStaffNumberPerBranch { get; set; }
    public int MaxMemberNumberPerBranch { get; internal set; }
}
