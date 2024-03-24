//using gms.common.Constants;
//using gms.data.Models.Class;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace gms.data.Configurations.Class;

//internal class ClassScheduleConfiguration : IEntityTypeConfiguration<ClassScheduleEntity>
//{
//	public void Configure(EntityTypeBuilder<ClassScheduleEntity> builder)
//	{
//		builder.ToTable(gmsDbProperties.DbTablePrefix + ".ClassSchedule", gmsDbProperties.DbSchema);

//		builder.HasKey(cs => cs.Id);

//		builder.HasOne(cs => cs.ClassLocation)
//			   .WithMany(cl => cl.ClassSchedules)
//			   .HasForeignKey(cs => cs.ClassLocationId);

//		builder.HasMany(cs => cs.ClassScheduleDays)
//			   .WithOne(csd => csd.ClassSchedule)
//			   .HasForeignKey(csd => csd.ClassId);
//	}
//}
