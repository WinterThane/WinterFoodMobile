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

        public static async void AddCategories()
        {
            _database = new SQLiteAsyncConnection(Config.dbPath);
            await _database.DropTableAsync<Category>();
            await _database.CreateTableAsync<Category>();
            await _database.InsertAsync(new Category { Name = "Breakfast" });
            await _database.InsertAsync(new Category { Name = "Main Dish" });
            await _database.InsertAsync(new Category { Name = "Salad" });
            await _database.InsertAsync(new Category { Name = "Dessert" });
        }

        public static async Task<Category> GetCategoryById(int id)
        {
            await Init();
            return await _database.Table<Category>().Where(r => r.CategoryID == id).FirstOrDefaultAsync();
        }

        public static async Task<IEnumerable<Category>> GetAllCategories()
        {
            await Init();
            return await _database.Table<Category>().ToListAsync();
        }
    }
}
