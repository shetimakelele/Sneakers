using Microsoft.EntityFrameworkCore;

using Sneakers.Core.Data.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace Sneakers.Core.Data.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Sneaker> Sneakers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Commande> Commandes { get; set; }

        public DbSet<CommandeDetail> CommandeDetails { get; set; }

        // methode qui permet dinitialiser la Base de Donées
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // on verifie si il y a des data sion on les insere

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Chill", Description = "Les paires pour chiller" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 2, CategoryName = "Sport", Description = "Les paires Sport" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 3, CategoryName = "Rares", Description = "Les paires Rares" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 4, CategoryName = "Summer", Description = "Les paires pour l'été" }
                );

            // initialisation produit
            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker
                {
                    SneakerId = 1,
                    SneakerName = "Elijaah",
                    ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                    LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                    Instock = true,
                    ShortDescription = "pour collectionneur",
                    Price = 109,
                    CategoryId = 3
                }
           );

            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker
                {
                    SneakerId = 2,
                    SneakerName = "Cindy",
                    ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                    LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                    Instock = true,
                    ShortDescription = "pour collectionneur",
                    Price = 109,
                    CategoryId = 3
                }
           );

            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker
                {
                    SneakerId = 3,
                    SneakerName = "Sheti",
                    ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                    LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                    Instock = true,
                    ShortDescription = "pour collectionneur",
                    Price = 109,
                    CategoryId = 3
                }
           );

            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker
                {
                    SneakerId = 4,
                    SneakerName = "Jenevaah",
                    ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                    LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                    Instock = true,
                    ShortDescription = "pour collectionneur",
                    Price = 109,
                    CategoryId = 3
                }
           );

            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker
                {
                    SneakerId = 5,
                    SneakerName = "Ezraahn",
                    ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                    LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                    Instock = true,
                    ShortDescription = "pour collectionneur",
                    Price = 109,
                    CategoryId = 3
                }
           );

            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker
                {
                    SneakerId = 6,
                    SneakerName = "Aaron",
                    ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                    LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                    Instock = true,
                    ShortDescription = "pour collectionneur",
                    Price = 109,
                    CategoryId = 3
                }
           );

            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker
                {
                    SneakerId = 7,
                    SneakerName = "Williams",
                    ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                    LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                    Instock = true,
                    ShortDescription = "pour collectionneur",
                    Price = 109,
                    CategoryId = 3
                }
           );

            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker
                {
                    SneakerId = 8,
                    SneakerName = "Rebecca",
                    ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                    LongDescription = "Précieuse, confortables et rares , idéale pour votre Maman ",
                    Instock = true,
                    ShortDescription = "pour Maman",
                    Price = 109,
                    CategoryId = 4
                }
           );







        }
    }
}
