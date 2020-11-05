using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RecipeWebApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                new Recipe
                {
                    //Id = 1012,
                    Title = "Apple Pie",
                    Description = "",
                    Category = "Dessert",
                    Culture = "Global",
                    Chef = "Joanna",
                    PreparationTime = "1 hr 30 mins",
                    Servings = 8,
                    Yield = "1 - 9 inch pie",
                    AvrgRate = 3,
                    Nutrition = "512 calories; 26.7 g total fat; 31 mg cholesterol; 241 mg sodium. 67.8 g carbohydrates; 3.6 g protein",
                    Direction = @"Step 1
                                  Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste. Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.
                                  Step 2
                                  Place the bottom crust in your pan. Fill with apples, mounded slightly. Cover with a lattice work crust. Gently pour the sugar and butter liquid over the crust. Pour slowly so that it does not run off.
                                  Step 3
                                  Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft.",
                    Ingredient = "1 recipe pastry for a 9 inch double crust pie \r\n" +
                                 "½ cup unsalted butter \r\n" +
                                 "3 tablespoons all-purpose flour \r\n" +
                                 "¼ cup water \r\n" +
                                 "½ cup white sugar \r\n" +
                                 "½ cup packed brown sugar \n\r" +
                                 "8 Granny Smith apples - peeled, cored and sliced \r\n"
                },
                new Recipe
                {
                    //Id = 1013,
                    Title = "Hamburger",
                    Description = "",
                    Category = "Main",
                    Culture = "Global",
                    Chef = "Younga",
                    PreparationTime = "30 mins",
                    Servings = 4,
                    Yield = "4 inch",
                    AvrgRate = 4,
                    Nutrition = "512 calories; 26.7 g total fat; 31 mg cholesterol; 241 mg sodium. 67.8 g carbohydrates; 3.6 g protein",
                    Direction = "Step 1\n" +
                                  "Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste. Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.\n" +
                                  "Step 2\n" +
                                  "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft.",
                    Ingredient = "1 recipe pastry for a 9 inch double crust pie\n\n" +
                                 "½ cup unsalted butter\n\n" +
                                 "3 tablespoons all-purpose flour\n\n" +
                                 "¼ cup water\n\n" +
                                 "½ cup white sugar\n\n" +
                                 "½ cup packed brown sugar\n\n" +
                                 "8 Granny Smith apples - peeled, cored and sliced"
                },
                new Recipe
                {
                    //Id = 1014,
                    Title = "Egg Taco",
                    Description = "",
                    Category = "Main",
                    Culture = "Carabian",
                    Chef = "Jeniffer Lopez",
                    PreparationTime = "45 mins",
                    Servings = 4,
                    Yield = "4 inch",
                    AvrgRate = 3,
                    Nutrition = "512 calories; 26.7 g total fat; 31 mg cholesterol; 241 mg sodium. 67.8 g carbohydrates; 3.6 g protein",
                    Direction = "Step 1\n" +
                                  "Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste. Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.\n" +
                                  "Step 2\n" +
                                  "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft.",
                    Ingredient = "1 recipe pastry for a 9 inch double crust pie\n\n" +
                                 "½ cup unsalted butter\n\n" +
                                 "3 tablespoons all-purpose flour\n\n" +
                                 "¼ cup water\n\n" +
                                 "½ cup white sugar\n\n" +
                                 "½ cup packed brown sugar\n\n" +
                                 "8 Granny Smith apples - peeled, cored and sliced"
                },
                new Recipe
                {
                    //Id = 1015,
                    Title = "Fresh Pasta",
                    Description = "",
                    Category = "Main",
                    Culture = "Italian",
                    Chef = "Basanta",
                    PreparationTime = "45 mins",
                    Servings = 4,
                    Yield = "Large dish",
                    AvrgRate = 5,
                    Nutrition = "512 calories; 26.7 g total fat; 31 mg cholesterol; 241 mg sodium. 67.8 g carbohydrates; 3.6 g protein",
                    Direction = "Step 1\n" +
                                  "Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste. Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.\n" +
                                  "Step 2\n" +
                                  "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft.",
                    Ingredient = "1 recipe pastry for a 9 inch double crust pie\n\n" +
                                 "½ cup unsalted butter\n\n" +
                                 "3 tablespoons all-purpose flour\n\n" +
                                 "¼ cup water\n\n" +
                                 "½ cup white sugar\n\n" +
                                 "½ cup packed brown sugar\n\n" +
                                 "8 Granny Smith apples - peeled, cored and sliced"
                },
                new Recipe
                {
                    //Id = 1016,
                    Title = "Veggie Frittata",
                    Description = "",
                    Category = "Appetizer",
                    Culture = "Carabian",
                    Chef = "Paolo Rossi",
                    PreparationTime = "40 mins",
                    Servings = 4,
                    Yield = "Large dish - 15 inch Dia.",
                    AvrgRate = 2,
                    Nutrition = "512 calories; 26.7 g total fat; 31 mg cholesterol; 241 mg sodium. 67.8 g carbohydrates; 3.6 g protein",
                    Direction = "Step 1\n" +
                                  "Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste. Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.\n" +
                                  "Step 2\n" +
                                  "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft.",
                    Ingredient = "1 recipe pastry for a 9 inch double crust pie\n\n" +
                                 "½ cup unsalted butter\n\n" +
                                 "3 tablespoons all-purpose flour\n\n" +
                                 "¼ cup water\n\n" +
                                 "½ cup white sugar\n\n" +
                                 "½ cup packed brown sugar\n\n" +
                                 "8 Granny Smith apples - peeled, cored and sliced"
                },
                new Recipe
                {
                    //Id = 1017,
                    Title = "Cheesy Toad",
                    Description = "",
                    Category = "Appetizer",
                    Culture = "Chinese",
                    Chef = "John Smith",
                    PreparationTime = "25 mins",
                    Servings = 4,
                    Yield = "Medium Dish",
                    AvrgRate = 4,
                    Nutrition = "512 calories; 26.7 g total fat; 31 mg cholesterol; 241 mg sodium. 67.8 g carbohydrates; 3.6 g protein",
                    Direction = "Step 1\n" +
                                  "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft.",
                    Ingredient = "1 recipe pastry for a 9 inch double crust pie\n\n" +
                                 "½ cup unsalted butter\n\n" +
                                 "3 tablespoons all-purpose flour\n\n" +
                                 "¼ cup water\n\n" +
                                 "½ cup white sugar\n\n" +
                                 "½ cup packed brown sugar\n\n" +
                                 "8 Granny Smith apples - peeled, cored and sliced"
                },
                new Recipe
                {
                    //Id = 1018,
                    Title = "Chello Kabab",
                    Description = "",
                    Category = "Main",
                    Culture = "Persian",
                    Chef = "Maziar H.",
                    PreparationTime = "1h / 45mins",
                    Servings = 4,
                    Yield = "Large Dish of Rice + 8 skewer Kabab",
                    Ingredient="",
                    AvrgRate = 5,
                    Direction = "Step 1\n" +
                                  "Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste. Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.\n" +
                                  "Step 2\n" +
                                  "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft."
                },
                new Recipe
                {
                    //Id = 1019,
                    Title = "Mix Plate Mezza",
                    Description = "",
                    Category = "Appetizer",
                    Culture = "Middle East",
                    Chef = "Sara Abd",
                    PreparationTime = "1h / 30mins",
                    Servings = 4,
                    Yield = "4 plates",
                    Ingredient = "",
                    AvrgRate = 5,
                    Direction = "Step 1\n" +
                                  "Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste. Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.\n" +
                                  "Step 2\n" +
                                  "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft."
                },
                new Recipe
                {
                    //Id = 1020,
                    Title = "Chocolate Ice Cream",
                    Description = "",
                    Category = "Dessert",
                    Culture = "Global",
                    Chef = "Parsa H.",
                    PreparationTime = "155 min",
                    Servings = 4,
                    Yield = "10 scope",
                    Ingredient = "",
                    AvrgRate = 4,
                    Direction = "Step 1\n" +
                                  "Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste. Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.\n" +
                                  "Step 2\n" +
                                  "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F (175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft."
                }
                );

                context.SaveChanges();

            }

            if (!context.Reviews.Any())
            {
                context.Reviews.AddRange(
                    new Review
                    {
                        RecipeId = 1,
                        Name = "Jesica M",
                        Title = "Great Apple Pie",
                        Note = "I changed some stuff and it came out a lot better the 2nd time. I did 2/4c brown and 1/4 white sugar instead of 3/4c white sugar. I put some nutmeg in it also. On top of the latice i mixed 1 egg and some milk and egg",
                        Rate = 4
                    },
                    new Review
                    {
                        RecipeId = 1,
                        Name = "Kim",
                        Title = "Excelent Apple Pie",
                        Note = "This was delicious! I added a few touches to it, also.I mixed the apples with 1 tablespoon of lemon juice, stirred in the sugar and 2 tablespoons of flour to thicken the juices.After adding the top crust, I brushed on an egg wash(1 egg beaten with 1 tablespoon milk)and sprinkled 1 tablespoon of sugar.I placed the glass pie dish on a baking sheet to prevent any spill - over from dripping onto the oven's floor...",
                        Rate = 5
                    },
                    new Review
                    {
                        RecipeId = 1,
                        Name = "Ellen",
                        Title = "The best Apple Pie",
                        Note = "This is a wonderful recipe. I added 1-2 TBLS lemon jiuce, 2 TBLS flour, 1/2 teas vanilla 1/4 teas nutmeg and used brown sugar instead of white. Then mixed the seasonings with the apples before putting it in the ...",
                        Rate = 3
                    },

                    new Review
                    {
                        RecipeId = 2,
                        Name = "Jesica M",
                        Title = "Great Hamburger",
                        Note = "I changed some stuff and it came out a lot better the 2nd time. I did 2/4c brown and 1/4 white sugar instead of 3/4c white sugar. I put some nutmeg in it also. On top of the latice i mixed 1 egg and some milk and egg",
                        Rate = 4
                    },
                    new Review
                    {
                        RecipeId = 2,
                        Name = "Kim",
                        Title = "Excelent Hamburger",
                        Note = "This was delicious! I added a few touches to it, also.I mixed the apples with 1 tablespoon of lemon juice, stirred in the sugar and 2 tablespoons of flour to thicken the juices.After adding the top crust, I brushed on an egg wash(1 egg beaten with 1 tablespoon milk)and sprinkled 1 tablespoon of sugar.I placed the glass pie dish on a baking sheet to prevent any spill - over from dripping onto the oven's floor...",
                        Rate = 5
                    },
                    new Review
                    {
                        RecipeId = 2,
                        Name = "Ellen",
                        Title = "Delicious Hamburger",
                        Note = "This is a wonderful recipe. I added 1-2 TBLS lemon jiuce, 2 TBLS flour, 1/2 teas vanilla 1/4 teas nutmeg and used brown sugar instead of white. Then mixed the seasonings with the apples before putting it in the ...",
                        Rate = 3
                    },

                    new Review
                    {
                        RecipeId = 3,
                        Name = "Jesica M",
                        Title = "Great Egg Taco",
                        Note = "I changed some stuff and it came out a lot better the 2nd time. I did 2/4c brown and 1/4 white sugar instead of 3/4c white sugar. I put some nutmeg in it also. On top of the latice i mixed 1 egg and some milk and egg",
                        Rate = 3
                    },
                    new Review
                    {
                        RecipeId = 3,
                        Name = "Kim",
                        Title = "Excelent Egg Taco",
                        Note = "This was delicious! I added a few touches to it, also.I mixed the apples with 1 tablespoon of lemon juice, stirred in the sugar and 2 tablespoons of flour to thicken the juices.After adding the top crust, I brushed on an egg wash(1 egg beaten with 1 tablespoon milk)and sprinkled 1 tablespoon of sugar.I placed the glass pie dish on a baking sheet to prevent any spill - over from dripping onto the oven's floor...",
                        Rate = 5
                    },
                    new Review
                    {
                        RecipeId = 3,
                        Name = "Ellen",
                        Title = "Delicious Egg Taco",
                        Note = "This is a wonderful recipe. I added 1-2 TBLS lemon jiuce, 2 TBLS flour, 1/2 teas vanilla 1/4 teas nutmeg and used brown sugar instead of white. Then mixed the seasonings with the apples before putting it in the ...",
                        Rate = 4
                    },

                    new Review
                    {
                        RecipeId = 4,
                        Name = "Jesica M",
                        Title = "Great Pasta",
                        Note = "I changed some stuff and it came out a lot better the 2nd time. I did 2/4c brown and 1/4 white sugar instead of 3/4c white sugar. I put some nutmeg in it also. On top of the latice i mixed 1 egg and some milk and egg",
                        Rate = 3
                    },
                    new Review
                    {
                        RecipeId = 4,
                        Name = "Kim",
                        Title = "Excelent Pasta",
                        Note = "This was delicious! I added a few touches to it, also.I mixed the apples with 1 tablespoon of lemon juice, stirred in the sugar and 2 tablespoons of flour to thicken the juices.After adding the top crust, I brushed on an egg wash(1 egg beaten with 1 tablespoon milk)and sprinkled 1 tablespoon of sugar.I placed the glass pie dish on a baking sheet to prevent any spill - over from dripping onto the oven's floor...",
                        Rate = 4
                    },
                    new Review
                    {
                        RecipeId = 4,
                        Name = "Ellen",
                        Title = "Deliciouse Pasta",
                        Note = "This is a wonderful recipe. I added 1-2 TBLS lemon jiuce, 2 TBLS flour, 1/2 teas vanilla 1/4 teas nutmeg and used brown sugar instead of white. Then mixed the seasonings with the apples before putting it in the ...",
                        Rate = 2
                    }
            );

                context.SaveChanges();

            }
        }
    }
}
