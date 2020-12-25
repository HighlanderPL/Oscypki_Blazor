﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oscypki_Blazor.Data;

namespace Oscypki_Blazor.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201224174722_seed_data")]
    partial class seed_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Oscypki_Blazor.Models.Oscypki", b =>
                {
                    b.Property<int>("OscypkiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageThumbnailPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("OscypkiId");

                    b.ToTable("Oscpkis");

                    b.HasData(
                        new
                        {
                            OscypkiId = 1,
                            Description = "Smoked Polish Highlander Cheese made with Cows and Sheep Milk",
                            ImagePath = "img/Oscypek.jpg",
                            ImageThumbnailPath = "img/Oscypek_thumbnail.jpg",
                            Name = "Oscypek",
                            Price = 2m
                        },
                        new
                        {
                            OscypkiId = 2,
                            Description = "A small version of the Smoked Polish Highlander Cheese made with Cows and Sheep Milk",
                            ImagePath = "img/Oscypek.jpg",
                            ImageThumbnailPath = "img/Oscypek_small_thumbnail.jpg",
                            Name = "Small Oscypek",
                            Price = 1m
                        },
                        new
                        {
                            OscypkiId = 3,
                            Description = "Polish Highlander Cheese made with Cows and Sheep Milk in string form",
                            ImagePath = "img/korbacz.jpg",
                            ImageThumbnailPath = "img/korbacz_thumbnail.jpg",
                            Name = "Korbacz",
                            Price = 4m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
