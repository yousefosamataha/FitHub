namespace gms.common.Models.NutritionCat.MealIngredient;

public sealed record CreateMealIngredientDTO
{
	public int NutritionPlanMealId { get; set; }

	public required string Title { get; set; }

	public decimal? Calories { get; set; }

	public decimal? ServingSizeG { get; set; }

	public decimal? FatTotalG { get; set; }

	public decimal? FatSaturatedG { get; set; }

	public decimal? ProteinG { get; set; }

	public decimal? SodiumMg { get; set; }

	public decimal? PotassiumMg { get; set; }

	public decimal? CholesterolMg { get; set; }

	public decimal? CarbohydratesTotalG { get; set; }

	public decimal? FiberG { get; set; }

	public decimal? SugarG { get; set; }
}

public sealed record UpdateMealIngredientDTO
{

}

public sealed record MealIngredientDTO
{

}