using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Pages;

public partial class MainMenuPage : ContentPage
{
	public MainMenuPage()
	{
		InitializeComponent();
        var databaseService = new DatabaseService();
        var recipeService = new RecipeService(databaseService.GetConnection());

        var recipe = new Recipe
        {
            RecipeID = 1,
            Title = "test recipe",
            Description = "test aaaaaaaaaa",
            Instructions = "1 2 3",
            PrepTime = 10,
            CookTime = 20,
            TotalTime = 50,
            Servings = 3,
            Difficulty = "easy",
            ImageURL = "http",
            CategoryID = 1,
            CreatedByUserID = 1,
            CreatedAt = DateTime.Now
        };

        recipeService.InsertRecipeTask(recipe);
	}

    private async void OnRecipesButtonTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new RecipesListPage());
    }

    private async void OnPlanButtonTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new PlanerPage());
    }
}