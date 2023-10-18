using System.ComponentModel.DataAnnotations;

namespace WinterFoodMobile.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? MeasurementUnit { get; set; }
        public string? WikipediaURL { get; set; }
    }
}
