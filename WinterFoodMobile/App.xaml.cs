using WinterFoodMobile.Pages;

namespace WinterFoodMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainMenuPage());
            //MainPage = new AppShell();
        }
    }
}