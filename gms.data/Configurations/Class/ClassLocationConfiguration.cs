using gms.common.Constants;
using gms.data.Models.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class ClassLocationConfiguration : IEntityTypeConfiguration<ClassLocationEntity>
{
    public void Configure(EntityTypeBuilder<ClassLocationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".ClassLocation", gmsDbProperties.DbSchema);

        builder.HasKey(cl => cl.Id);

        builder.Property(cl => cl.Name).IsRequired().HasMaxLength(256);

        builder.HasOne(cl => cl.GymBranch)
               .WithMany(gb => gb.ClassLocations)
               .HasForeignKey(cl => cl.BranchId);

        builder.HasMany(cl => cl.ClassSchedules)
               .WithOne(cs => cs.ClassLocation)
               .HasForeignKey(cs => cs.ClassLocationId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
