﻿// <auto-generated />
using MealPlan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MealPlan.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191127070025_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MealPlan.Models.DishesModel", b =>
                {
                    b.Property<int>("DishID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calories");

                    b.Property<int>("Fat");

                    b.Property<int>("Fiber");

                    b.Property<int>("Protein");

                    b.HasKey("DishID");

                    b.ToTable("DishesModels");
                });

            modelBuilder.Entity("MealPlan.Models.RawFoodModel", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calories");

                    b.Property<int>("Fat");

                    b.Property<int>("Fiber");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Protein");

                    b.HasKey("FoodID");

                    b.ToTable("RawFoodModels");
                });
#pragma warning restore 612, 618
        }
    }
}
