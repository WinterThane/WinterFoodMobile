using SQLite;

namespace WinterFoodMobile.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement, Unique, NotNull]
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
