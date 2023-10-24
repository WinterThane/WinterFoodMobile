using SQLite;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Database
{
    public class CategoryService
    {
        private SQLiteConnection _database;

        public CategoryService(SQLiteConnection database)
        {
            _database = database;
        }

        public Category GetCategoryTask(int id)
        {
            return _database.Find<Category>(id);
        }
    }
}
