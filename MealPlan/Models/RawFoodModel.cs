using System;
using System.ComponentModel.DataAnnotations;

namespace MealPlan.Models
{
    public class RawFoodModel
    {
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Fiber { get; set; }
        public enum FoodTag { Meat, Carb, Veggie, Fruit, };
    }
}
