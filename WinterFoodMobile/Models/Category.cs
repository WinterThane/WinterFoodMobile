using SQLite;

namespace WinterFoodMobile.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
