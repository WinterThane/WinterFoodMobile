using SQLite;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Database
{
    public static class CategoryService
    {
        static SQLiteAsyncConnection _database;

        static async Task Init()
        {
            if (_database != null) return;

            _database = new SQLiteAsyncConnection(Config.dbPath);
            await _database.CreateTableAsync<Category>();
        }

        public static async Task<IEnumerable<Category>> GetAllCategories()
        {
            await Init();
            return await _database.Table<Category>().ToListAsync();
        }
    }
}
