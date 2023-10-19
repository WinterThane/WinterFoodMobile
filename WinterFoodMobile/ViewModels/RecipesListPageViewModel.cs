using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class RecipesListPageViewModel
    {
        public List<Recipe> Recipes { get; set; }

        public RecipesListPageViewModel()
        {
            var databaseService = new DatabaseService();
            var recipeService = new RecipeService(databaseService.GetConnection());
            
            DatabaseInserts inserts = new();
            Recipes = new List<Recipe>();
            Recipes = inserts.InsertRecipes();

            foreach (var recipe in Recipes)
            {
                recipeService.InsertRecipeTask(recipe);
            }
            
            Recipes = new List<Recipe>();
            Recipes.AddRange(recipeService.GetAllRecipesTask());
        }
    }
}
