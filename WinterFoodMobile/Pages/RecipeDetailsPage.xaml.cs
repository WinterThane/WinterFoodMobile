using WinterFoodMobile.Models;
using WinterFoodMobile.ViewModels;

namespace WinterFoodMobile.Pages;

public partial class RecipeDetailsPage : ContentPage
{
    public RecipeDetailsPage(Recipe recipe)
	{
		InitializeComponent();
        BindingContext = new RecipeDetailsPageViewModel(recipe);
    }
}