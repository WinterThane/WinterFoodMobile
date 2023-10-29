using SQLite;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.Database
{
    public class CookingPlanService
    {
        private readonly SQLiteConnection _database;

        public CookingPlanService(SQLiteConnection database)
        {
            _database = database;
            CreateCookingPlanTable();
        }

        public void CreateCookingPlanTable()
        {
            if (!_database.GetTableInfo("CookingPlan").Any())
            {
                _database.CreateTable<CookingPlan>();
            }
        }

        public List<CookingPlan> GetAllCookingPlans() => _database.Table<CookingPlan>().ToList();
        public CookingPlan GetCookingPlanByDate(DateTime date) => _database.Find<CookingPlan>(date);
        public void InsertCookingPlan(CookingPlan cookingPlan) => _database.Insert(cookingPlan);
        public void UpdateCookingRecipe(CookingPlan cookingPlan) => _database.Update(cookingPlan);
        public void DeleteCookingPlan(int id) => _database.Delete(id);
    }
}