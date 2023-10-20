using SQLite;

namespace WinterFoodMobile.Database
{
    public class DatabaseService
    {
        private SQLiteConnection _database;
        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "wtrecipesdb.db3");

        public DatabaseService()
        {
            _database = new SQLiteConnection(DbPath);
            // Run only once
            //_database.DropTable<Recipe>();
            //_database.CreateTable<Recipe>();
        }      
        
        public SQLiteConnection GetConnection()
        {
            return _database;
        }
    }
}
