using System.Reflection;
using WinterFoodMobile.Converters;
using WinterFoodMobile.Database;
using WinterFoodMobile.Pages;

namespace WinterFoodMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Run only once
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            using (Stream stream = assembly.GetManifestResourceStream("WinterFoodMobile.Database.wtrecipesdb.db3"))
            {
                using MemoryStream memoryStream = new();
                stream.CopyTo(memoryStream);
                File.WriteAllBytes(Config.dbPath, memoryStream.ToArray());
            }

            Resources.Add("FavouriteTrueFalseConverter", new FavouriteTrueFalseConverter());
            MainPage = new NavigationPage(new MainMenuPage());
            //MainPage = new AppShell();
        }
    }
}