using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Nutrition;
public class NutritionPlanMealEntity : BaseEntity
{
    public int NutritionPlanId { get; set; }
    public int MealTimeId { get; set; }
    public WeekDayEnum WeekDayId { get; set; }

    public virtual NutritionPlanEntity NutritionPlan { get; set; }
    public virtual MealTimeEntity MealTime { get; set; }
    //public virtual ICollection<MealIngredientEntity> MealIngredients { get; set; }
}
