using SQLite;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Database
{
    public class RecipeService
    {
        private SQLiteConnection _database;

        public RecipeService(SQLiteConnection database)
        {
            _database = database;
        }

        public List<Recipe> GetAllTask() 
        {
            return _database.Table<Recipe>().ToList();
        }

        public Recipe GetRecipeTask(int id)
        {
            return _database.Find<Recipe>(id);
        }

        public int InsertRecipeTask(Recipe recipe)
        {
            return _database.Insert(recipe);
        }

        public int UpdateRecipeTask(Recipe recipe)
        {
            return _database.Update(recipe);
        }

        public int DeleteRecipeTask(int id)
        {
            return _database.Delete(id);
        }
    }
}
