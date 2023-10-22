using System.Globalization;

namespace WinterFoodMobile.Converters
{
    public class FavouriteTrueFalseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                if (boolValue)
                {
                    return ImageSource.FromFile("favourite1.png");
                }
            }

            return ImageSource.FromFile("favourite0.png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
