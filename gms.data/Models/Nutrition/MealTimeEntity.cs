using gms.data.Models.Base.Entities;

namespace gms.data.Models.Nutrition;

public class MealTimeEntity : BaseEntity
{
	public string Name { get; set; }

	public ICollection<NutritionPlanMealEntity> NutritionPlanMeals { get; set; }

	// TODO: Add Relation Entities
	// public int CreatedById { get; set; }
}
