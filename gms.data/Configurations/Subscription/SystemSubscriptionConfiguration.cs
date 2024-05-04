using gms.common.Constants;
using gms.data.Models.Subscription;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class SystemSubscriptionConfiguration : IEntityTypeConfiguration<SystemSubscriptionEntity>
{
    public void Configure(EntityTypeBuilder<SystemSubscriptionEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".SystemSubscription", gmsDbProperties.DbSchema);

        builder.HasKey(ss => ss.Id);

        builder.Property(ss => ss.SubscriptionAmount).HasPrecision(18, 2);

        builder.HasOne(ss => ss.Gym)
               .WithMany(g => g.SystemSubscriptions)
               .HasForeignKey(ss => ss.GymId);

        builder.HasMany(ss => ss.SubscriptionPayments)
               .WithOne(sp => sp.SystemSubscription)
               .HasForeignKey(sp => sp.SubscriptionId);
    }
}
