using gms.common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Identity;
internal class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".UserRole", gmsDbProperties.DbSchema);
    }
}
