using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using RecipeWebApp.Models;

namespace RecipeWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View("Home");
        }


        public ViewResult RecipeList()
        {
            return View(repository.Recipes);
        }

        public ViewResult RecipeReview(int id)
        {
            return View(repository.Reviews.Where(r => r.RecipeId == id));
        }

        [HttpPost]
        public IActionResult RecipeReview(Review review)
        {
            if (ModelState.IsValid)
            {
                review.ID = 0;    // -- I don't know why EF assign a value to ID!!, so, it has to set 0.

                repository.AddReview(review);

                CalcAvrgRate(review.RecipeId);  // Calculate Avrg Rating and put in recipe

                TempData["message"] = $"Thank you {review.Name}, your review has been posted successfully!";

                return RedirectToAction("RecipeReview");
            }
            else
            {
                return View(repository.Reviews.Where(r => r.RecipeId == review.ID));
            }
        }

        private void CalcAvrgRate(int recpId)
        {
            int avrg = (int) repository.Reviews
                              .Where(v => v.RecipeId == recpId)
                              .Average(r => r.Rate);
            Recipe recipe = repository.Recipes.FirstOrDefault(r => r.Id == recpId);
            recipe.AvrgRate = avrg;
            repository.SaveRecipe(recipe);
        }


    }
}
