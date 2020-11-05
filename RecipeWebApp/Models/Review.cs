using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace RecipeWebApp.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int RecipeId { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please type a title for your review.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please type your review.")]
        public string Note { get; set; }

        public int Rate { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
    }
}
