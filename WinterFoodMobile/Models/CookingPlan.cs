using System.ComponentModel.DataAnnotations;

namespace WinterFoodMobile.Models
{
    public class CookingPlan
    {
        [Key]
        public int PlanID { get; set; }
        public int UserID { get; set; }
        public int RecipeID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string? Notes { get; set; }
    }
}
