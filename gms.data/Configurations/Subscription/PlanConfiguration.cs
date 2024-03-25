using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models.Subscription;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Subscription;

internal class PlanConfiguration : IEntityTypeConfiguration<PlanEntity>
{
    public void Configure(EntityTypeBuilder<PlanEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".SystemPlan", gmsDbProperties.DbSchema);

        builder.HasKey(p => p.Id);

        builder.Property(b => b.Id).ValueGeneratedNever();

        builder.Property(p => p.PlanName).IsRequired(true);

        builder.Property(p => p.PricePerMonth).HasPrecision(18, 2);

        builder.Property(p => p.PricePerYear).HasPrecision(18, 2);

        builder.HasData(GetSystemPlans());
    }
    public List<PlanEntity> GetSystemPlans()
    {
        List<PlanEntity> plans = new();
        plans.Add(new PlanEntity()
        {
            Id = (int)PlansEnum.FreeTrial,
            PlanName = PlansEnum.FreeTrial.ToString(),
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
            Id = (int)PlansEnum.Startup,
            PlanName = PlansEnum.Startup.ToString(),
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

            Id = (int)PlansEnum.Business,
            PlanName = PlansEnum.Business.ToString(),
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
            Id = (int)PlansEnum.Enterprise,
            PlanName = PlansEnum.Enterprise.ToString(),
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
