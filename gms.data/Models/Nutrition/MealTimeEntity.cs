using gms.data.Models.Base;
using gms.data.Models.Gym;

namespace gms.data.Models.Nutrition;

public class MealTimeEntity : BaseEntity
{
    public int BranchId { get; set; }
    public string Name { get; set; }

    // Navigation properties
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual ICollection<NutritionPlanMealEntity> NutritionPlanMeals { get; set; }
}
