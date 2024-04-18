using gms.common.Constants;
using gms.data.Models.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class ClassScheduleDayConfiguration : IEntityTypeConfiguration<ClassScheduleDayEntity>
{
    public void Configure(EntityTypeBuilder<ClassScheduleDayEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".ClassScheduleDay", gmsDbProperties.DbSchema);

        builder.HasKey(csd => csd.Id);

        builder.HasOne(csd => csd.Gym)
               .WithMany()
               .HasForeignKey(csd => csd.GymId);

        builder.HasOne(csd => csd.GymBranch)
               .WithMany()
               .HasForeignKey(csd => csd.BranchId);

        builder.HasOne(csd => csd.ClassSchedule)
                .WithMany(cs => cs.ClassScheduleDays)
                .HasForeignKey(csd => csd.ClassScheduleId);
    }
}
