using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWebApp.Models
{
    public interface IRepository
    {
        IQueryable<Recipe> Recipes { get; }

        IQueryable<Review> Reviews { get; }


        void SaveRecipe(Recipe recipe);

        Recipe DeleteRecipe(int id);


        void AddReview(Review review);

    }
}
