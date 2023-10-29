using SQLite;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Database
{
    public static class RecipeService
    {
        static SQLiteAsyncConnection _database;

        static async Task Init()
        {
            if (_database != null) return;

            _database = new SQLiteAsyncConnection(Config.dbPath);
            await _database.CreateTableAsync<Recipe>();
        }

        public static async Task<IEnumerable<Recipe>> GetAllRecipes()
        {
            await Init();
            return await _database.Table<Recipe>().ToListAsync();
        }

        public static async Task<Recipe> GetRecipeById(int id)
        {
            await Init();
            return await _database.Table<Recipe>().Where(r => r.RecipeID == id).FirstOrDefaultAsync();
        }

        public static async Task InsertRecipe(Recipe recipe)
        {
            await Init();
            await _database.InsertAsync(recipe);
        }

        public static async Task UpdateRecipe(Recipe recipe)
        {
            await Init();
            await _database.UpdateAsync(recipe);
        }
        
        public static async Task DeleteRecipe(int id)
        {
            await Init();
            await _database.DeleteAsync<Recipe>(id);
        }
    }
}
