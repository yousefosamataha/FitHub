using gms.common.Constants;
using gms.data.Models.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class ClassScheduleConfiguration : IEntityTypeConfiguration<ClassScheduleEntity>
{
    public void Configure(EntityTypeBuilder<ClassScheduleEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".ClassSchedule", gmsDbProperties.DbSchema);

        builder.HasKey(cs => cs.Id);

        builder.Property(cs => cs.ClassName).IsRequired().HasMaxLength(256);

        builder.Property(cs => cs.ClassFees).HasPrecision(18, 2);

        builder.HasOne(cs => cs.GymBranch)
               .WithMany(gb => gb.ClassSchedules)
               .HasForeignKey(cs => cs.BranchId);

        builder.HasMany(cs => cs.MembershipPlanClasses)
               .WithOne(gmpc => gmpc.ClassSchedule)
               .HasForeignKey(gmpc => gmpc.ClassScheduleId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(cs => cs.GymLocation)
               .WithMany(gl => gl.ClassSchedules)
               .HasForeignKey(cs => cs.GymLocationId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(cs => cs.ClassScheduleDays)
               .WithOne(csd => csd.ClassSchedule)
               .HasForeignKey(csd => csd.ClassScheduleId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(cs => cs.StaffClasses)
               .WithOne(sc => sc.ClassSchedule)
               .HasForeignKey(sc => sc.ClassScheduleId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(cs => cs.MemberClasses)
               .WithOne(mc => mc.ClassSchedule)
               .HasForeignKey(mc => mc.ClassScheduleId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
