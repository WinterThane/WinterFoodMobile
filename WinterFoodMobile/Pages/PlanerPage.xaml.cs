namespace WinterFoodMobile.Pages;

public partial class PlanerPage : ContentPage
{
	public PlanerPage()
	{
		InitializeComponent();
        PopulateCalendar();
    }

	private static void PopulateCalendar()
	{
        DateTime currentDate = DateTime.Now;
        int year = currentDate.Year;
        int month = currentDate.Month;
        int daysInMonth = DateTime.DaysInMonth(year, month);
        DateTime firstDayOfMonth = new(year, month, 1);
        DayOfWeek firstDayOfWeek = firstDayOfMonth.DayOfWeek;

        for (int row = 1; row <= 6; row++) // 6 rows (maximum to accommodate all possible days)
        {
            for (int col = 0; col < 7; col++) // 7 days (Sunday to Saturday)
            {
                int day = (row - 1) * 7 + col + 1;
                if (day <= daysInMonth && (row > 1 || col >= (int)firstDayOfWeek))
                {
                    // Create a label or button for the day
                    var dayLabel = new Label
                    {
                        Text = day.ToString(),
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                    };

                    // Add a tap gesture recognizer to handle date selection
                    dayLabel.GestureRecognizers.Add(new TapGestureRecognizer
                    {
                        Command = new Command(() =>
                        {
                            // Handle date selection here
                            //HandleDateSelection(day);
                        }),
                    });

                    // Add the label to the calendar grid
                    //calendarGrid.Children.Add(dayLabel, col, row);
                }
            }
        }
    }

    //private void HandleDateSelection(int selectedDay)
    //{
    //    // Clear the previous selection (if any)
    //    foreach (var child in calendarGrid.Children)
    //    {
    //        if (child is Label label)
    //        {
    //            label.BackgroundColor = Color.Transparent;
    //        }
    //    }

    //    // Highlight the selected date
    //    calendarGrid.Children[selectedDay - 1].BackgroundColor = Color.LightBlue;

    //    // Load and display items corresponding to the selected date in the ListView (itemsListView)
    //    LoadItemsForSelectedDate(selectedDay);
    //}
}