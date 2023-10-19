using WinterFoodMobile.Database;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Pages;

public partial class MainMenuPage : ContentPage
{
	public MainMenuPage()
	{
		InitializeComponent();
        
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