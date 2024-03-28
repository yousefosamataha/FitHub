using gms.common.Constants;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace gms.data.Configurations.Identity;
internal class GymUserConfiguration : IEntityTypeConfiguration<GymUserEntity>
{
    public void Configure(EntityTypeBuilder<GymUserEntity> builder)
    {
        ValueConverter<DateOnly, DateTime> dateOnlyConverter = new(
                                                                    dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
                                                                    dateTime => DateOnly.FromDateTime(dateTime)
                                                                );

        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymUser", gmsDbProperties.DbSchema);

        builder.Property(gu => gu.Address).IsRequired(false);

        builder.Property(gu => gu.City).IsRequired(false);

        builder.Property(gu => gu.BirthDate)
            .HasConversion(dateOnlyConverter)
            .HasColumnType("date");
    }
}
