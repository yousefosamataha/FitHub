using gms.common.Constants;
using gms.data.Models.Event;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Event;
internal class GymEventPlaceConfiguration : IEntityTypeConfiguration<GymEventPlaceEntity>
{
    public void Configure(EntityTypeBuilder<GymEventPlaceEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymEventPlace", gmsDbProperties.DbSchema);

        builder.HasKey(ep => ep.Id);

        builder.Property(ep => ep.PlaceName)
               .IsRequired()
               .HasMaxLength(256);

        builder.HasMany(ep => ep.GymEventReservations)
               .WithOne(er => er.GymEventPlace)
               .HasForeignKey(er => er.GymEventPlaceId);
    }
}
