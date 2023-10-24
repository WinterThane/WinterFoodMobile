using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class PlanerPageViewModel
    {
        public List<Recipe> Recipes { get; set; }
        public Recipe SelectedRecipe { get; set; }

        public PlanerPageViewModel()
        {
            var databaseService = new DatabaseService();
            var recipeService = new RecipeService(databaseService.GetConnection());
            var cookingPlanService = new CookingPlanService(databaseService.GetConnection());
        }
    }
}
