using System.Windows.Input;
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
            
            Recipes = new List<Recipe>();
            Recipes.AddRange(recipeService.GetAllRecipesTask());
        }
    }
}
