namespace WinterFoodMobile.Database
{
    public static class Config
    {
        public static string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "wtrecipesdb.db3");
    }
}
