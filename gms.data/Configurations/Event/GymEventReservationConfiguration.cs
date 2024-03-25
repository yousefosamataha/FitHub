using gms.common.Constants;
using gms.data.Models.Event;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Event;
internal class GymEventReservationConfiguration : IEntityTypeConfiguration<GymEventReservationEntity>
{
    public void Configure(EntityTypeBuilder<GymEventReservationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymEventReservation", gmsDbProperties.DbSchema);

        builder.HasKey(er => er.Id);

        builder.Property(er => er.EventName)
               .IsRequired()
               .HasMaxLength(256);

        builder.HasOne(er => er.GymEventPlace)
               .WithMany(ep => ep.GymEventReservations)
               .HasForeignKey(ep => ep.GymEventPlaceId);
    }
}
