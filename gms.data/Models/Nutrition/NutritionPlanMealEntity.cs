using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Nutrition;
public class NutritionPlanMealEntity : BaseEntity
{
	public int NutritionPlanId { get; set; }
	public WeekDayEnum WeekDayId { get; set; }

	public virtual NutritionPlanEntity NutritionPlan { get; set; }

	// TODO: Add Relation Entities
	// public int MealtimeId { get; set; }
	// public Mealtime Mealtime { get; set; }
}
