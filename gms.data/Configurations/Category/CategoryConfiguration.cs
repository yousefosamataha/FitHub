//using gms.common.Constants;
//using gms.data.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace gms.data.Configurations.Category;
//internal class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
//{
//	public void Configure(EntityTypeBuilder<CategoryEntity> builder)
//	{
//		builder.ToTable(gmsDbProperties.DbTablePrefix + ".category", gmsDbProperties.DbSchema);
//		builder.HasData(GetCategories());

//		builder.Property(a => a.Name).IsRequired().HasMaxLength(250);
//	}

//	private List<CategoryEntity> GetCategories()
//	{
//		List<CategoryEntity> categories = new();
//		categories.AddRange(new List<CategoryEntity>()
//		{
//			new CategoryEntity()
//			{
//				Id = Guid.NewGuid(),
//				Name = "Regular",
//				CreatedAt = DateTime.Now,
//				IsDeleted = false
//			},
//			new CategoryEntity()
//			{
//				Id = Guid.NewGuid(),
//				Name = "Limited",
//				CreatedAt = DateTime.Now,
//				IsDeleted = false
//			},
//			new CategoryEntity()
//			{
//				Id = Guid.NewGuid(),
//				Name = "Total Gym Exercises for Abs (Abdomininals)",
//				CreatedAt = DateTime.Now,
//				IsDeleted = false
//			},
//			new CategoryEntity()
//			{
//				Id = Guid.NewGuid(),
//				Name = "Total Gym Exercises for Legs",
//				CreatedAt = DateTime.Now,
//				IsDeleted = false
//			},
//			new CategoryEntity()
//			{
//				Id = Guid.NewGuid(),
//				Name = "Total Gym Exercises for Biceps",
//				CreatedAt = DateTime.Now,
//				IsDeleted = false
//			},
//			new CategoryEntity()
//			{
//				Id = Guid.NewGuid(),
//				Name = "Exercise",
//				CreatedAt = DateTime.Now,
//				IsDeleted = false
//			}
//		});
//		return categories;
//	}

//}
