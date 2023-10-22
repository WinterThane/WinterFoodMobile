using WinterFoodMobile.Models;
using WinterFoodMobile.ViewModels;

namespace WinterFoodMobile.Pages;

public partial class RecipeDetailsPage : ContentPage
{
    private bool isEditMode = false;

    public RecipeDetailsPage(Recipe recipe)
	{
        InitializeComponent();
        BindingContext = new RecipeDetailsPageViewModel(recipe);        
    }
}