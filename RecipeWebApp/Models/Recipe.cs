using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RecipeWebApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Recipe name.")]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Culture { get; set; }

        public string Category { get; set; }

        [Required(ErrorMessage = "Chef name")]
        public string Chef { get; set; }

        [Required(ErrorMessage = "Preparation Time")]
        public string PreparationTime { get; set; }

        [Required(ErrorMessage = "Servings number")]
        public int Servings { get; set; }

        public string Yield { get; set; }

        [Required(ErrorMessage = "Ingredients")]
        public string Ingredient { get; set; }

        [Required(ErrorMessage = "Direction Steps")]
        public string Direction { get; set; }

        public string Nutrition { get; set; }

        public int AvrgRate { get; set; }

        public DateTime EditDate { get; set; } = DateTime.Now;

    }

}
