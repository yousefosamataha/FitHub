using gms.common.Constants;
using gms.data.Models.Event;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymEventReservationConfiguration : IEntityTypeConfiguration<GymEventReservationEntity>
{
    public void Configure(EntityTypeBuilder<GymEventReservationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymEventReservation", gmsDbProperties.DbSchema);

        builder.HasKey(er => er.Id);

        builder.Property(er => er.EventName).IsRequired().HasMaxLength(256);

        builder.HasOne(ger => ger.GymBranch)
               .WithMany(gb => gb.GymEventReservations)
               .HasForeignKey(ger => ger.BranchId);

        builder.HasOne(ger => ger.GymLocation)
               .WithMany(gl => gl.GymEventReservations)
               .HasForeignKey(ger => ger.GymLocationId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(ger => ger.IsDeleted == false);
    }
}
