using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class PlanerPageViewModel
    {
        public List<Recipe> Recipes { get; set; }
        public Recipe PlannedRecipe { get; set; }
        public bool IsListVisible { get; set; }
        public bool IsDetailsVisible { get; set; }

        public PlanerPageViewModel()
        {
            //var databaseService = new DatabaseService();
            //var recipeService = new RecipeService(databaseService.GetConnection());
            //var cookingPlanService = new CookingPlanService(databaseService.GetConnection());

            //Recipes = new List<Recipe>();
            //Recipes.AddRange(recipeService.GetAllRecipes());

            //if (Recipes.Any())
            //{
            //    IsDetailsVisible = false;
            //    IsListVisible = true;
            //}
            //else
            //{
            //    IsDetailsVisible = true;
            //    IsListVisible = false;
            //}
        }

        public void AddRecipeToPlan(Recipe recipe, DateTime date)
        {
            //var databaseService = new DatabaseService();
            //var cookingPlanService = new CookingPlanService(databaseService.GetConnection());

            //var plan = new CookingPlan
            //{
            //    UserID = 1,
            //    RecipeID = recipe.RecipeID,
            //    ScheduledDate = date,
            //    Notes = "xxx"
            //};

            //cookingPlanService.InsertCookingPlan(plan);
        }
    }
}
