using gms.common.Constants;
using gms.data.Models.Workout;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Workout;

internal class WorkoutPlanConfiguration : IEntityTypeConfiguration<WorkoutPlanEntity>
{
	public void Configure(EntityTypeBuilder<WorkoutPlanEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".WorkoutPlan", gmsDbProperties.DbSchema);

		builder.HasKey(wp => wp.Id);

		builder.HasMany(wp => wp.WorkoutPlanActivities)
			   .WithOne(wpa => wpa.WorkoutPlan)
			   .HasForeignKey(wpa => wpa.WorkoutPlanId);
	}
}
