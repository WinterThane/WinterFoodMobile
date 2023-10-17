using System.Collections.ObjectModel;
using System.Windows.Input;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.CustomControls;

public partial class CalendarView : StackLayout
{
    public static readonly BindableProperty SelectedDateProperty = BindableProperty.Create(
        nameof(SelectedDate),
        typeof(DateTime),
        declaringType: typeof(CalendarView),
        defaultBindingMode: BindingMode.TwoWay,
        defaultValue: DateTime.Now,
        propertyChanged: SelectedDatePropertyChanged);

    private static void SelectedDatePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (CalendarView)bindable;
        if (newValue != null) 
        {
            var newDate = (DateTime)newValue;

            if (controls._tempDate.Month == newDate.Month && controls._tempDate.Year == newDate.Year)
            {
                var currentDate = controls.Dates.Where(d => d.Date == newDate.Date).FirstOrDefault();
                if (currentDate != null)
                {
                    controls.Dates.ToList().ForEach(d => d.IsCurrentDate = false);
                    currentDate.IsCurrentDate = true;
                }
            }
            {
                controls.BindDates(newDate);
            }            
        }
    }

    public DateTime SelectedDate
    {
        get => (DateTime)GetValue(SelectedDateProperty);
        set => SetValue(SelectedDateProperty, value);
    }

    public static readonly BindableProperty SelectedDateCommandProperty = BindableProperty.Create(
       nameof(SelectedDateCommand),
       typeof(ICommand),
       declaringType: typeof(CalendarView));

    public ICommand SelectedDateCommand
    {
        get => (ICommand)GetValue(SelectedDateCommandProperty);
        set => SetValue(SelectedDateCommandProperty, value);
    }

    public event EventHandler<DateTime> OnDateSelected;
    private DateTime _tempDate;

    public ObservableCollection<CalendarModel> Dates { get; set; } = new ObservableCollection<CalendarModel>();

    public CalendarView()
	{
        InitializeComponent();
        BindDates(DateTime.Now);
    }

    private void BindDates(DateTime date)
    {
        Dates.Clear();
        int daysCount = DateTime.DaysInMonth(date.Year, date.Month);

        for (int day = 1; day <= daysCount; day++)
        {
            Dates.Add(new CalendarModel
            {
                Date = new DateTime(date.Year, date.Month, day)
            });
        }

        var selectedDate = Dates.Where(d => d.Date.Date == SelectedDate.Date).FirstOrDefault();
        if (selectedDate != null)
        {
            selectedDate.IsCurrentDate = true;
            _tempDate = selectedDate.Date;
        }
    }

    public ICommand CurrentDateCommand => new Command<CalendarModel>((currentDate) =>
    {
        _tempDate = currentDate.Date;
        SelectedDate = currentDate.Date;
        OnDateSelected?.Invoke(null, currentDate.Date);
        SelectedDateCommand?.Execute(currentDate.Date);
    });

    public ICommand NextMonthCommand => new Command(() =>
    {
        _tempDate = _tempDate.AddMonths(1);
        BindDates(_tempDate);
    });

    public ICommand PreviousMonthCommand => new Command(() =>
    {
        _tempDate = _tempDate.AddMonths(-1);
        BindDates(_tempDate);
    });
}