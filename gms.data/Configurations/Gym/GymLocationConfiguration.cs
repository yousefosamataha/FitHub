using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;

internal class GymLocationConfiguration : IEntityTypeConfiguration<GymLocationEntity>
{
    public void Configure(EntityTypeBuilder<GymLocationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymLocation", gmsDbProperties.DbSchema);

        builder.HasKey(gl => gl.Id);

        builder.Property(gl => gl.Name).IsRequired().HasMaxLength(256);

        builder.HasOne(gl => gl.GymBranch)
               .WithMany(gb => gb.GymLocations)
               .HasForeignKey(gl => gl.BranchId);

        builder.HasMany(gl => gl.ClassSchedules)
               .WithOne(cs => cs.GymLocation)
               .HasForeignKey(cs => cs.GymLocationId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gl => gl.GymEventReservations)
               .WithOne(ger => ger.GymLocation)
               .HasForeignKey(ger => ger.GymLocationId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
