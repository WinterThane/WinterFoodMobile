using MvvmHelpers;
using MvvmHelpers.Commands;
using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class RecipesListPageViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Recipe> RecipeList { get; set; }
        public AsyncCommand RefreshCommand { get; }       
        public AsyncCommand UpdateRecipeCommand { get; }
        public AsyncCommand RemoveRecipeCommand { get; }

        public RecipesListPageViewModel()
        {
            RecipeList = new ObservableRangeCollection<Recipe>();
            RefreshCommand = new AsyncCommand(Refresh);
            _ = Refresh();
        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(1000);
            RecipeList.Clear();

            var recipes = await RecipeService.GetAllRecipes();
            RecipeList.AddRange(recipes);

            IsBusy = false;
        }
    }
}
