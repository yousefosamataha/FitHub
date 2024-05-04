using gms.common.Constants;
using gms.data.Models.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Membership;

internal class GymMembershipPlanClassConfiguration : IEntityTypeConfiguration<GymMembershipPlanClassEntity>
{
    public void Configure(EntityTypeBuilder<GymMembershipPlanClassEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymMembershipPlanClass", gmsDbProperties.DbSchema);

        builder.HasKey(gmpc => gmpc.Id);

        builder.HasOne(gmpc => gmpc.MembershipPlan)
               .WithMany(gmp => gmp.MembershipPlanClasses)
               .HasForeignKey(gmpc => gmpc.MembershipPlanId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(gmpc => gmpc.ClassSchedule)
               .WithMany(cs => cs.MembershipPlanClasses)
               .HasForeignKey(gmpc => gmpc.ClassScheduleId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
