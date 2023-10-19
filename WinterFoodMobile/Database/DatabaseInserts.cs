using WinterFoodMobile.Models;

namespace WinterFoodMobile.Database
{
    public class DatabaseInserts
    {
        public List<Recipe> InsertRecipes()
        {
            List<Recipe> list = new List<Recipe>
            {
                new Recipe
                {
                    RecipeID = 1,
                    Title = "Spaghetti Carbonara",
                    Description = "A classic Italian pasta dish with eggs, cheese, pancetta, and pepper.",
                    Instructions = "1. Cook spaghetti\n2. Sauté pancetta\n3. Combine eggs and cheese\n4. Mix all ingredients",
                    PrepTime = 10,
                    CookTime = 15,
                    TotalTime = 25,
                    Servings = 4,
                    Difficulty = "Medium",
                    ImageURL = "http://example.com/spaghetti.jpg",
                    CategoryID = 1,
                    CreatedByUserID = 1,
                    CreatedAt = DateTime.Now
                },
                new Recipe
                {
                    RecipeID = 2,
                    Title = "Chicken Alfredo",
                    Description = "Creamy pasta dish with grilled chicken and Parmesan sauce.",
                    Instructions = "1. Cook fettuccine\n2. Grill chicken\n3. Make Alfredo sauce\n4. Combine all ingredients",
                    PrepTime = 20,
                    CookTime = 25,
                    TotalTime = 45,
                    Servings = 6,
                    Difficulty = "Easy",
                    ImageURL = "http://example.com/alfredo.jpg",
                    CategoryID = 2,
                    CreatedByUserID = 2,
                    CreatedAt = DateTime.Now
                },
                new Recipe
                {
                    RecipeID = 3,
                    Title = "Vegetable Stir-Fry",
                    Description = "A quick and healthy stir-fry with colorful vegetables and tofu.",
                    Instructions = "1. Prepare tofu and veggies\n2. Stir-fry with sauce\n3. Serve hot",
                    PrepTime = 15,
                    CookTime = 10,
                    TotalTime = 25,
                    Servings = 4,
                    Difficulty = "Easy",
                    ImageURL = "http://example.com/stirfry.jpg",
                    CategoryID = 3,
                    CreatedByUserID = 1,
                    CreatedAt = DateTime.Now
                },
                new Recipe
                {
                    RecipeID = 4,
                    Title = "Chocolate Chip Cookies",
                    Description = "Homemade chocolate chip cookies, warm and gooey.",
                    Instructions = "1. Mix ingredients\n2. Shape dough into cookies\n3. Bake until golden brown",
                    PrepTime = 15,
                    CookTime = 10,
                    TotalTime = 25,
                    Servings = 24,
                    Difficulty = "Easy",
                    ImageURL = "http://example.com/cookies.jpg",
                    CategoryID = 4,
                    CreatedByUserID = 2,
                    CreatedAt = DateTime.Now
                },
                new Recipe
                {
                    RecipeID = 5,
                    Title = "Margarita Pizza",
                    Description = "Classic Italian pizza with tomato sauce, mozzarella, and basil.",
                    Instructions = "1. Roll out pizza dough\n2. Spread tomato sauce\n3. Add cheese and basil\n4. Bake until crust is golden",
                    PrepTime = 20,
                    CookTime = 15,
                    TotalTime = 35,
                    Servings = 4,
                    Difficulty = "Medium",
                    ImageURL = "http://example.com/pizza.jpg",
                    CategoryID = 5,
                    CreatedByUserID = 1,
                    CreatedAt = DateTime.Now
                },
                new Recipe
                {
                    RecipeID = 6,
                    Title = "Caesar Salad",
                    Description = "A classic Caesar salad with croutons and creamy dressing.",
                    Instructions = "1. Prepare lettuce\n2. Make dressing\n3. Toss lettuce and dressing\n4. Add croutons",
                    PrepTime = 10,
                    CookTime = 0,
                    TotalTime = 10,
                    Servings = 2,
                    Difficulty = "Easy",
                    ImageURL = "http://example.com/caesar.jpg",
                    CategoryID = 6,
                    CreatedByUserID = 2,
                    CreatedAt = DateTime.Now
                },
                new Recipe
                {
                    RecipeID = 7,
                    Title = "Sushi Rolls",
                    Description = "Homemade sushi rolls with various fillings and soy sauce.",
                    Instructions = "1. Prepare sushi rice and nori\n2. Add fillings\n3. Roll sushi\n4. Slice and serve",
                    PrepTime = 30,
                    CookTime = 0,
                    TotalTime = 30,
                    Servings = 4,
                    Difficulty = "Medium",
                    ImageURL = "http://example.com/sushi.jpg",
                    CategoryID = 7,
                    CreatedByUserID = 1,
                    CreatedAt = DateTime.Now
                },
                new Recipe
                {
                    RecipeID = 8,
                    Title = "Beef Stroganoff",
                    Description = "Creamy beef stroganoff with mushrooms and noodles.",
                    Instructions = "1. Sauté beef and mushrooms\n2. Make stroganoff sauce\n3. Serve over noodles",
                    PrepTime = 15,
                    CookTime = 20,
                    TotalTime = 35,
                    Servings = 4,
                    Difficulty = "Medium",
                    ImageURL = "http://example.com/stroganoff.jpg",
                    CategoryID = 8,
                    CreatedByUserID = 2,
                    CreatedAt = DateTime.Now
                }
            };

            return list;
        }
    }
}
