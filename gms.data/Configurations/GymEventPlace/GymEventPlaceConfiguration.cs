//using gms.common.Constants;
//using gms.data.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace gms.data.Configurations.GymEventPlace;
//internal class GymEventPlaceConfiguration : IEntityTypeConfiguration<GymEventPlaceEntity>
//{
//	public void Configure(EntityTypeBuilder<GymEventPlaceEntity> builder)
//	{
//		builder.ToTable(gmsDbProperties.DbTablePrefix + ".gym_event_place", gmsDbProperties.DbSchema);

//		builder.Property(g => g.Place).HasMaxLength(100);
//	}
//}
