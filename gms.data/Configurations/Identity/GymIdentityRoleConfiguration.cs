using gms.common.Constants;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymIdentityRoleConfiguration : IEntityTypeConfiguration<GymIdentityRoleEntity>
{
	public void Configure(EntityTypeBuilder<GymIdentityRoleEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymIdentityRole", gmsDbProperties.DbSchema);

		builder.Property(gr => gr.BranchId).IsRequired();

		builder.HasOne(gr => gr.GymBranch)
			   .WithMany(gb => gb.GymRoles)
			   .HasForeignKey(gr => gr.BranchId)
			   .OnDelete(DeleteBehavior.Restrict);

		builder.Property(gr => gr.IsDeleteable).IsRequired();
		builder.Property(gr => gr.IsUpdateable).IsRequired();
	}
}
