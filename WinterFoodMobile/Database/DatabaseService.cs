using SQLite;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Database
{
    public class DatabaseService
    {
        private SQLiteConnection _database;

        public DatabaseService()
        {
            //var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "winterfood.db3");
            //_database = new SQLiteConnection(databasePath);
            //_database.CreateTable<Recipe>();

            //var databaseName = "winterfood.db3";
            //string databasePath = Path.Combine(FileSystem.AppDataDirectory, databaseName);
            //const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite |
            //                              SQLiteOpenFlags.Create |
            //                              SQLiteOpenFlags.SharedCache;
        }      
        
        public SQLiteConnection GetConnection()
        {
            return _database;
        }
    }
}
