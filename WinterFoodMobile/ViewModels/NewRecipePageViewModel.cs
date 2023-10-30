using MvvmHelpers;
using MvvmHelpers.Commands;
using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class NewRecipePageViewModel
    {
        public Recipe RecipeObj { get; set; }
        public Category SelectedCategory { get; set; }
        public ObservableRangeCollection<Category> CategoryObj { get; set; }
        public AsyncCommand AddRecipeCommand { get; }

        public NewRecipePageViewModel()
        {
            AddRecipeCommand = new AsyncCommand(AddRecipe);
            RecipeObj = new Recipe();
            CategoryObj = new ObservableRangeCollection<Category>();
            _ = GetCategories();
        }

        async Task GetCategories()
        {
            var categories = await CategoryService.GetAllCategories();
            CategoryObj.AddRange(categories);
        }

        async Task AddRecipe()
        {
            if (RecipeObj != null)
            {
                RecipeObj.CategoryID = SelectedCategory != null ? SelectedCategory.CategoryID : 1;
                await RecipeService.InsertRecipe(RecipeObj);
            }            
        }
    }
}
