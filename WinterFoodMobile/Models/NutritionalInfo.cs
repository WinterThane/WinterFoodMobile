using System.ComponentModel.DataAnnotations;

namespace WinterFoodMobile.Models
{
    public class NutritionalInfo
    {
        [Key]
        public int NutritionalInfoID { get; set; }
        public int IngredientID { get; set; }
        public float VitaminA { get; set; }
        public float VitaminC { get; set; }
        public float VitaminD { get; set; }
        public float Iron { get; set; }
        public float Calcium { get; set; }
        // Add more properties for other nutrients as needed
    }
}
