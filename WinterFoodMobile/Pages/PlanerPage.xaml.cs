using WinterFoodMobile.Models;

namespace WinterFoodMobile.Pages;

public partial class PlanerPage : ContentPage
{
    public Recipe RecipeObj { get; set; }

    public PlanerPage()
	{
		InitializeComponent();    
        calendar.SelectedDate = DateTime.Now;
    }

    public PlanerPage(Recipe recipe)
    {
        InitializeComponent();
        RecipeObj = recipe;
        calendar.SelectedDate = DateTime.Now;
    }

    private void calendar_OnDateSelected(object sender, DateTime e)
    {

    }
}