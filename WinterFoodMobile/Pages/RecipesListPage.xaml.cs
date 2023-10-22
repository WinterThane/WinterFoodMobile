using WinterFoodMobile.Models;

namespace WinterFoodMobile.Pages;

public partial class RecipesListPage : ContentPage
{
	public RecipesListPage()
	{
		InitializeComponent();
	}

    private async void AddToPlan_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is Button button)
        {
            var selectedRecipe = button.BindingContext as Recipe;
            await Navigation.PushAsync(new PlanerPage(selectedRecipe));
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
}