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

        builder.HasOne(cs => cs.Gym)
               .WithMany()
               .HasForeignKey(cs => cs.GymId);

        builder.HasOne(cs => cs.GymBranch)
               .WithMany()
               .HasForeignKey(cs => cs.BranchId);

        builder.HasOne(cs => cs.ClassLocation)
               .WithMany(cl => cl.ClassSchedules)
               .HasForeignKey(cs => cs.ClassLocationId);

        builder.HasMany(cs => cs.ClassScheduleDays)
               .WithOne(csd => csd.ClassSchedule)
               .HasForeignKey(csd => csd.ClassScheduleId);

        builder.HasMany(cs => cs.StaffClasses)
               .WithOne(sc => sc.ClassSchedule)
               .HasForeignKey(sc => sc.ClassScheduleId);

        builder.HasOne(cs => cs.GymUser)
               .WithOne()
               .HasForeignKey<ClassScheduleEntity>(cs => cs.CreatedById);
    }
}
