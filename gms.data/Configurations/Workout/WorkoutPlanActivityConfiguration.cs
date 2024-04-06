using gms.common.Constants;
using gms.data.Models.Workout;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class WorkoutPlanActivityConfiguration : IEntityTypeConfiguration<WorkoutPlanActivityEntity>
{
	public void Configure(EntityTypeBuilder<WorkoutPlanActivityEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".WorkoutPlanActivity", gmsDbProperties.DbSchema);

		builder.HasKey(wpa => wpa.Id);

		builder.HasOne(wpa => wpa.WorkoutPlan)
			   .WithMany(wp => wp.WorkoutPlanActivities)
			   .HasForeignKey(wpa => wpa.WorkoutPlanId);

		builder.HasOne(wpa => wpa.Activity)
			   .WithMany(a => a.WorkoutPlanActivities)
			   .HasForeignKey(wpa => wpa.ActivityId);
	}
}
