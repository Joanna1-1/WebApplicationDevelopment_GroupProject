using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWebApp.Models
{
    public class EFRepository : IRepository
    {
        private AppDbContext context;

        public EFRepository(AppDbContext ctx) { context = ctx; }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public IQueryable<Review> Reviews => context.Reviews;


        // -------- Add, Edit, and Delete Recipe ---------
        public void SaveRecipe(Recipe recipe)
        {
            if (recipe.Id == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe entry = context.Recipes
                    .FirstOrDefault(r => r.Id == recipe.Id);

                if (entry != null)
                {
                    entry.Title = recipe.Title;
                    entry.Description = recipe.Description;
                    entry.Culture = recipe.Culture;
                    entry.Category = recipe.Category;
                    entry.Chef = recipe.Chef;
                    entry.PreparationTime = recipe.PreparationTime;
                    entry.Servings = recipe.Servings;
                    entry.Yield = recipe.Yield;
                    entry.Ingredient = recipe.Ingredient;
                    entry.Direction = recipe.Direction;
                    entry.Nutrition = recipe.Nutrition;
                    entry.AvrgRate = recipe.AvrgRate;
                }
            }
            context.SaveChanges();
        }


        // -------- Add New Review ---------
        public void AddReview(Review review)
        {
            context.Reviews.Add(review);

            context.SaveChanges();
        }


        public Recipe DeleteRecipe(int id)
        {
            Recipe recipeEntry = context.Recipes
                .FirstOrDefault(r => r.Id == id);

            if (recipeEntry != null)
            {
                context.Recipes.Remove(recipeEntry);
                context.SaveChanges();
            }

            return recipeEntry;
        }

    }
}
