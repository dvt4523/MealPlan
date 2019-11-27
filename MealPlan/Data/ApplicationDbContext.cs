using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MealPlan.Models;
namespace MealPlan.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<DishesModel> DishesModels { get; set; }
        public DbSet<RawFoodModel> RawFoodModels { get; set; }

    }
}
