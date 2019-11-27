using System;
using System.ComponentModel.DataAnnotations;

namespace MealPlan.Models
{
    public class DishesModel
    {
        [Key]
        public int DishID { get; set; }
        [Required]
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Fiber { get; set; }
    }
}
