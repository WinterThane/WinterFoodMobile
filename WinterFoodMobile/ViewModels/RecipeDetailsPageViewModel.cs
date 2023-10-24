using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class RecipeDetailsPageViewModel
    {
        public Recipe RecipeObj { get; set; }
        public string CategoryName { get; set; }

        public RecipeDetailsPageViewModel()
        {            
        }

        public RecipeDetailsPageViewModel(Recipe recipe)
        {
            RecipeObj = recipe;
            var databaseService = new DatabaseService();
            var categoryService = new CategoryService(databaseService.GetConnection());
            CategoryName = categoryService.GetCategoryTask(RecipeObj.CategoryID).Name;
        }
    }
}
