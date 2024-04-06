using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class PaymentMethodEnumConfiguration : IEntityTypeConfiguration<PaymentMethodEnumEntity>
{
    public void Configure(EntityTypeBuilder<PaymentMethodEnumEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".PaymentMethodEnum", gmsDbProperties.DbSchema);

        builder.HasKey(pm => pm.Id);

        builder.Property(pm => pm.PaymentMethod).IsRequired(true).HasMaxLength(100);

        builder.HasData(GetPaymentMethods());
    }
    public List<PaymentMethodEnumEntity> GetPaymentMethods()
    {
        List<PaymentMethodEnumEntity> paymentMethods = new();
        foreach (var paymentMethod in Enum.GetValues(typeof(PaymentMethodEnum)))
        {
            PaymentMethodEnumEntity newPaymentMethod = new()
            {
                Id = (byte)paymentMethod,
                PaymentMethod = paymentMethod.ToString(),
                CreatedAt = DateTime.UtcNow
            };
            paymentMethods.Add(newPaymentMethod);
        };
        return paymentMethods;
    }
}
