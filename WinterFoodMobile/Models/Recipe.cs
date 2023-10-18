using SQLite;

namespace WinterFoodMobile.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int RecipeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public int TotalTime { get; set; }
        public int Servings { get; set; }
        public string Difficulty { get; set; }
        public string ImageURL { get; set; }
        public int CategoryID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
