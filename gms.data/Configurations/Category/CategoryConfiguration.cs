using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Category;
internal class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
{
    public void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".category", gmsDbProperties.DbSchema);

        builder.Property(a => a.Name).IsRequired().HasMaxLength(250);
    }
}
