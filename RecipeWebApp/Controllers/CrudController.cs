using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipeWebApp.Models;

namespace RecipeWebApp.Controllers
{
    public class CrudController : Controller
    {
        private IRepository repository;

        public CrudController(IRepository repo)
        {
            repository = repo;
        }

        [Authorize]
        public ViewResult RecipeEdit(int id) =>
                            View(repository.Recipes
                            .FirstOrDefault(r => r.Id == id));

        [Authorize]
        public ViewResult Create() => View("RecipeEdit", new Recipe());

        [HttpPost]
        [Authorize]
        public IActionResult RecipeEdit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.Title} has been saved!";
                return RedirectToAction("RecipeList", "Home");
            }
            else
            {
                return View(recipe);
            }
        }

        public ViewResult RecipeView(int id)
        {
            return View(repository.Recipes.FirstOrDefault(r => r.Id == id));
        }

        [Authorize]
        [HttpPost]
        public IActionResult DeleteRec(int id)
        {
            Recipe deletedRecipe = repository.DeleteRecipe(id);

            if (deletedRecipe != null)
            {
                TempData["message"] = $"Recipe: {deletedRecipe.Title} was deleted!";
            }

            return RedirectToAction("RecipeList", "Home");
        }


    }
}
