using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace gms.data.Configurations;

internal class GymUserConfiguration : IEntityTypeConfiguration<GymUserEntity>
{
    public void Configure(EntityTypeBuilder<GymUserEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymIdentityUser", gmsDbProperties.DbSchema);
       
        ValueConverter<DateOnly, DateTime> dateOnlyConverter = new(
                                                                    dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
                                                                    dateTime => DateOnly.FromDateTime(dateTime)
                                                                );

        builder.HasKey(gu => gu.Id);

        builder.Property(gu => gu.BirthDate)
               .HasConversion(dateOnlyConverter)
               .HasColumnType("date");

        builder.Property(gu => gu.GymUserTypeId)
               .IsRequired()
               .HasDefaultValue(GymUserTypeEnum.Member);

        //builder.HasOne(gu => gu.Gym)
        //       .WithMany(g => g.GymUsers)
        //       .HasForeignKey(gu => gu.GymId);

        builder.HasMany(gu => gu.GymStaffSpecializations)
               .WithOne(gss => gss.GymStaffUser)
               .HasForeignKey(gss => gss.GymStaffId);

        builder.HasMany(gu => gu.GymBranchUsers)
               .WithOne(gbu => gbu.GymUser)
               .HasForeignKey(gu => gu.GymUserId);

        //builder.HasOne(gu => gu.GymStaffUser)
        //       .WithOne()
        //       .HasForeignKey<GymUserEntity>(gu => gu.CreatedById);
    }
}
