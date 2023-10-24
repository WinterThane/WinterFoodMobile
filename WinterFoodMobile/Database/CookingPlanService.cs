using SQLite;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Database
{
    public class CookingPlanService
    {
        private SQLiteConnection _database;

        public CookingPlanService(SQLiteConnection database)
        {
            _database = database;
        }

        public int InsertCookingPlanTask(CookingPlan cookingPlan)
        {
            return _database.Insert(cookingPlan);
        }
    }
}