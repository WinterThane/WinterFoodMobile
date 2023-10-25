using WinterFoodMobile.Models;
using WinterFoodMobile.ViewModels;

namespace WinterFoodMobile.Pages;

public partial class PlanerPage : ContentPage
{
    public Recipe SelectedRecipe { get; set; }
    public PlanerPage()
	{
		InitializeComponent();    
        calendar.SelectedDate = DateTime.Now;
    }

    private void AddRecipeToPlan_Tapped(object sender, TappedEventArgs e)
    {
        var vm = new PlanerPageViewModel();
        if (SelectedRecipe != null)
        {
            vm.AddRecipeToPlan(SelectedRecipe, calendar.SelectedDate);
        }
    }

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var list = sender as ListView;
        SelectedRecipe = list.SelectedItem as Recipe;
    }
}