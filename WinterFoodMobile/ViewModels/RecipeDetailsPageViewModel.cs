using Microsoft.Maui.Controls.Shapes;
using System.Drawing;
using WinterFoodMobile.Models;

namespace WinterFoodMobile.ViewModels
{
    public class RecipeDetailsPageViewModel
    {
        public Recipe RecipeObj { get; set; }
        public ImageSource FavouriteIMG { get; set; }

        public RecipeDetailsPageViewModel()
        {            
        }

        public RecipeDetailsPageViewModel(Recipe recipe)
        {
            RecipeObj = recipe;
            if (recipe != null)
            {
                if (RecipeObj.Favourite)
                {
                    FavouriteIMG = ImageSource.FromFile("favourite1.png");
                }
                else
                {
                    FavouriteIMG = ImageSource.FromFile("favourite0.png");
                }
            }
        }
    }
}
