using WinterFoodMobile.Models;

namespace WinterFoodMobile.Pages;

public partial class RecipesListPage : ContentPage
{
    public RecipesListPage()
	{
		InitializeComponent();
    }

    private void AddToPlan_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is Button button)
        {
            var selectedRecipe = button.BindingContext as Recipe;
            // add recipe to planer - direct
        }
    }

    private async void EditRecipe_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is Button button)
        {
            var selectedRecipe = button.BindingContext as Recipe;
            await Navigation.PushAsync(new RecipeDetailsPage(selectedRecipe));
        }
    }

    private async void GoToSettingsPage_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }
}