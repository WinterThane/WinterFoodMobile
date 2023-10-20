using System.Reflection;
using WinterFoodMobile.Database;
using WinterFoodMobile.Models;
using WinterFoodMobile.Pages;

namespace WinterFoodMobile
{
    public partial class App : Application
    {
        public List<Recipe> Recipes { get; set; }
        public App()
        {
            InitializeComponent();

            // Run only once
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            using (Stream stream = assembly.GetManifestResourceStream("WinterFoodMobile.Database.wtrecipesdb.db3"))
            {
                using (MemoryStream memoryStream = new())
                {
                    stream.CopyTo(memoryStream);
                    File.WriteAllBytes(DatabaseService.DbPath, memoryStream.ToArray());
                }
            }

            MainPage = new NavigationPage(new MainMenuPage());
            //MainPage = new AppShell();
        }
    }
}