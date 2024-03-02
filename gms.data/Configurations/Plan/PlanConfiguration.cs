using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Plan;

internal class PlanConfiguration : IEntityTypeConfiguration<PlanEntity>
{
    public void Configure(EntityTypeBuilder<PlanEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".SystemPlan", gmsDbProperties.DbSchema);
        builder.Property(p => p.PlanName).IsRequired(true);
        builder.HasData(GetSystemPlans());
    }
    public List<PlanEntity> GetSystemPlans()
    {
        List<PlanEntity> plans = new();
        plans.Add(new PlanEntity()
        {
            Id = 1,
            PlanName = "free_trial",
            ReminderDays = 0,
            PricePerMonth = 0,
            PricePerYear = 0,
            MaxBranchNumber = 1,
            CreatedAt = DateTime.UtcNow,
            MaxMemberNumberPerBranch = 50,
            MaxStaffNumberPerBranch = 20
        });
        plans.Add(new PlanEntity()
        {
            Id = 2,
            PlanName = "startup",
            ReminderDays = 10,
            PricePerMonth = 500,
            PricePerYear = 5000,
            MaxBranchNumber = 3,
            CreatedAt = DateTime.UtcNow,
            MaxMemberNumberPerBranch = 100,
            MaxStaffNumberPerBranch = 30
        });
        plans.Add(new PlanEntity()
        {
            Id = 3,
            PlanName = "business",
            ReminderDays = 10,
            PricePerMonth = 1000,
            PricePerYear = 10000,
            MaxBranchNumber = 5,
            CreatedAt = DateTime.UtcNow,
            MaxMemberNumberPerBranch = 200,
            MaxStaffNumberPerBranch = 40
        });
        plans.Add(new PlanEntity()
        {
            Id = 4,
            PlanName = "enterprise",
            ReminderDays = 10,
            PricePerMonth = 2000,
            PricePerYear = 20000,
            MaxBranchNumber = 10,
            CreatedAt = DateTime.UtcNow,
            MaxMemberNumberPerBranch = 400,
            MaxStaffNumberPerBranch = 50
        });
        return plans;
    }
}
