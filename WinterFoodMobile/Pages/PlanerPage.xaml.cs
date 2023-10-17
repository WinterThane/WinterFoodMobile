namespace WinterFoodMobile.Pages;

public partial class PlanerPage : ContentPage
{
    public PlanerPage()
	{
		InitializeComponent();    
        calendar.SelectedDate = DateTime.Now;
    }

    private void calendar_OnDateSelected(object sender, DateTime e)
    {

    }
}