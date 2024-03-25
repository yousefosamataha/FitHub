using gms.common.Constants;
using gms.data.Models.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Class;

internal class ClassLocationConfiguration : IEntityTypeConfiguration<ClassLocationEntity>
{
    public void Configure(EntityTypeBuilder<ClassLocationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".ClassLocation", gmsDbProperties.DbSchema);

        builder.HasKey(cl => cl.Id);
        builder.Property(cl => cl.Name).IsRequired().HasMaxLength(256);

        builder.HasMany(cl => cl.ClassSchedules)
               .WithOne(cs => cs.ClassLocation)
               .HasForeignKey(cs => cs.ClassLocationId);
    }
}
