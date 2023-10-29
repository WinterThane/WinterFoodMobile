using MvvmHelpers;
using MvvmHelpers.Commands;
using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class NewRecipePageViewModel
    {
        public Recipe RecipeObj { get; set; }
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
            //var newRecipe = new Recipe
            //{
            //    Title = "Recipe 1",
            //    Description = "Description for Recipe 1",
            //    Instructions = "Instructions for Recipe 1",
            //    PrepTime = 30,
            //    CookingTime = 60,
            //    Servings = 4,
            //    ImageURL = "https://png.pngtree.com/png-clipart/20190516/original/pngtree-healthy-food-png-image_3776802.jpg",
            //    Favourite = false,
            //    CategoryID = 1
            //};
            if (RecipeObj != null)
            {
                await RecipeService.InsertRecipe(RecipeObj);
            }            
        }
    }
}
