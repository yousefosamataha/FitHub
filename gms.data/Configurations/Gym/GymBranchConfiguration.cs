using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;

internal class GymBranchConfiguration : IEntityTypeConfiguration<GymBranchEntity>
{
	public void Configure(EntityTypeBuilder<GymBranchEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymBranch", gmsDbProperties.DbSchema);

		builder.HasKey(gb => gb.Id);

		builder.Property(gb => gb.BranchName).IsRequired().HasMaxLength(256);

		builder.Property(gb => gb.StartYear).IsRequired();
		
		builder.Property(gb => gb.Address).IsRequired();
		
		builder.Property(gb => gb.ContactNumber).IsRequired();
		
		builder.Property(gb => gb.Email).IsRequired();

		//builder.HasOne(gb => gb.Gym).WithMany(g => g.)
	}
}
