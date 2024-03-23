using gms.data.Models.Base;

namespace gms.data.Models.Nutrition;

public class NutritionPlanEntity : BaseEntity
{
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    //public virtual ICollection<NutritionPlanMealEntity> NutritionPlanMeals { get; set; }

    // TODO: Add Relation Entities
    // public int MemberId { get; set; }
    // public int CreatedById { get; set; }
}
