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

        public CookingPlan GetRecipeByDate(DateTime date)
        {
            return _database.Find<CookingPlan>(date);
        }

        public void InsertCookingPlanTask(CookingPlan cookingPlan)
        {
            _database.Insert(cookingPlan);

            //string insertQuery = "INSERT INTO CookingPlan (UserID, RecipeID, ScheduledDate, Notes) VALUES (@UserID, @RecipeID, @ScheduledDate, @Notes)";
            //return _database.Execute(insertQuery, cookingPlan);

            //_database.Insert(cookingPlan);
            //return cookingPlan.PlanID;
        }
    }
}