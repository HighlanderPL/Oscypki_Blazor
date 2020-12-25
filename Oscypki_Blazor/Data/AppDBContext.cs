using Microsoft.EntityFrameworkCore;
using Oscypki_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public class AppDbContext : DbContext
    {
      
       public DbSet<Oscypki> Oscpkis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=Oscypek_Store.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oscypki>().HasData(
                 new Oscypki { OscypkiId = 1, Name = "Oscypek", Description = "Smoked Polish Highlander Cheese made with Cows and Sheep Milk", ImagePath = "img/Oscypek.jpg", ImageThumbnailPath = "img/Oscypek_thumbnail.jpg", Price = 2M }

                );
            modelBuilder.Entity<Oscypki>().HasData(
                                new Oscypki { OscypkiId = 2, Name = "Small Oscypek", Description = "A small version of the Smoked Polish Highlander Cheese made with Cows and Sheep Milk", ImagePath = "img/Oscypek.jpg", ImageThumbnailPath = "img/Oscypek_small_thumbnail.jpg", Price = 1M }

                );
            modelBuilder.Entity<Oscypki>().HasData(
                                new Oscypki { OscypkiId = 3, Name = "Korbacz", Description = "Polish Highlander Cheese made with Cows and Sheep Milk in string form", ImagePath = "img/korbacz.jpg", ImageThumbnailPath = "img/korbacz_thumbnail.jpg", Price = 4M }

                );
        }

    }
}
