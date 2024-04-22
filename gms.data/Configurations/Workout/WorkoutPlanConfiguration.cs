using gms.common.Constants;
using gms.data.Models.Workout;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class WorkoutPlanConfiguration : IEntityTypeConfiguration<WorkoutPlanEntity>
{
	public void Configure(EntityTypeBuilder<WorkoutPlanEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".WorkoutPlan", gmsDbProperties.DbSchema);

		builder.HasKey(wp => wp.Id);

        builder.HasOne(wp => wp.GymBranch)
               .WithMany(gb => gb.WorkoutPlans)
               .HasForeignKey(wp => wp.BranchId);

        builder.HasOne(wp => wp.GymMemberUser)
               .WithMany(gu => gu.MemberWorkoutPlans)
               .HasForeignKey(wp => wp.GymMemberUserId)
			   .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(wp => wp.GymStaffUser)
               .WithMany(gu => gu.StaffWorkoutPlans)
               .HasForeignKey(wp => wp.AssignedByGymStaffUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(wp => wp.WorkoutPlanActivities)
			   .WithOne(wpa => wpa.WorkoutPlan)
			   .HasForeignKey(wpa => wpa.WorkoutPlanId)
			   .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(wp => wp.IsDeleted == false);
	}
}
