using SQLite;

namespace WinterFoodMobile.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement, Unique, NotNull]
        public int RecipeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public string PrepTime { get; set; }
        public string CookingTime { get; set; }
        public string Servings { get; set; }
        public string ImageURL { get; set; }
        public byte[] ImageData { get; set; }
        public bool Favourite { get; set; }
        public int CategoryID { get; set; }
    }
}
