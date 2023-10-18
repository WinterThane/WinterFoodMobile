using System.ComponentModel.DataAnnotations;

namespace WinterFoodMobile.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string? Name { get; set; }
    }
}
