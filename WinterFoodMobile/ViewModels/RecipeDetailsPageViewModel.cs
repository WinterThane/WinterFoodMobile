using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class RecipeDetailsPageViewModel
    {
        public Recipe RecipeObj { get; set; }

        public RecipeDetailsPageViewModel()
        {            
        }

        public RecipeDetailsPageViewModel(Recipe recipe)
        {
            RecipeObj = recipe;
        }
    }
}
