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

        builder.HasOne(gu => gu.GymBranch)
               .WithMany(g => g.GymUsers)
               .HasForeignKey(gu => gu.BranchId);

        builder.HasMany(gu => gu.GymStaffSpecializations)
               .WithOne(gss => gss.GymStaffUser)
               .HasForeignKey(gss => gss.GymStaffId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.GymMemberMemberships)
               .WithOne(gmm => gmm.GymMemberUser)
               .HasForeignKey(gss => gss.MemberId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.StaffClasses)
               .WithOne(sc => sc.GymStaffUser)
               .HasForeignKey(sc => sc.StaffId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.MemberClasses)
               .WithOne(mc => mc.GymMemberUser)
               .HasForeignKey(mc => mc.GymMemberUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.GymMemberGroups)
               .WithOne(gmg => gmg.GymMemberUser)
               .HasForeignKey(gmg => gmg.GymMemberUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.GymStaffGroups)
               .WithOne(gsg => gsg.GymStaffUser)
               .HasForeignKey(gsg => gsg.GymStaffUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.MemberWorkoutPlans)
               .WithOne(wp => wp.GymMemberUser)
               .HasForeignKey(wp => wp.GymMemberUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.StaffWorkoutPlans)
               .WithOne(wp => wp.GymStaffUser)
               .HasForeignKey(wp => wp.AssignedByGymStaffUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.GymMeasurements)
               .WithOne(gm => gm.GymMemberUser)
               .HasForeignKey(gm => gm.GymMemberUserId);

        builder.HasMany(gu => gu.MemberNutritionPlans)
               .WithOne(np => np.GymMemberUser)
               .HasForeignKey(np => np.GymMemberUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.StaffNutritionPlans)
               .WithOne(np => np.GymStaffUser)
               .HasForeignKey(np => np.AssignedByGymStaffUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.GymNotificationSenderUsers)
               .WithOne(gn => gn.GymSenderUser)
               .HasForeignKey(gn => gn.GymSenderUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gu => gu.GymNotificationReceiverUsers)
               .WithOne(gn =>  gn.GymReceiverUser)
               .HasForeignKey(gn => gn.GymReceiverUserId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
