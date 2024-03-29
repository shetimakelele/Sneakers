﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sneakers.Core.Data.Models;

namespace Sneakers.Core.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sneakers.Core.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chill",
                            Description = "Les paires pour chiller"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Sport",
                            Description = "Les paires Sport"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Rares",
                            Description = "Les paires Rares"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Summer",
                            Description = "Les paires pour l'été"
                        });
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.Commande", b =>
                {
                    b.Property<int>("CommandeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Adresse2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodePostal")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<decimal>("CommandeTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommandeId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.CommandeDetail", b =>
                {
                    b.Property<int>("CommandeDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SneakerId")
                        .HasColumnType("int");

                    b.HasKey("CommandeDetailId");

                    b.HasIndex("CommandeId");

                    b.HasIndex("SneakerId");

                    b.ToTable("CommandeDetails");
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppinfCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartSessionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SneakerId")
                        .HasColumnType("int");

                    b.HasKey("ShoppinfCartItemId");

                    b.HasIndex("SneakerId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.Sneaker", b =>
                {
                    b.Property<int>("SneakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Instock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SneakerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SneakerId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sneakers");

                    b.HasData(
                        new
                        {
                            SneakerId = 1,
                            CategoryId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                            Instock = true,
                            LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                            Price = 109m,
                            ShortDescription = "pour collectionneur",
                            SneakerName = "Elijaah"
                        },
                        new
                        {
                            SneakerId = 2,
                            CategoryId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                            Instock = true,
                            LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                            Price = 109m,
                            ShortDescription = "pour collectionneur",
                            SneakerName = "Cindy"
                        },
                        new
                        {
                            SneakerId = 3,
                            CategoryId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                            Instock = true,
                            LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                            Price = 109m,
                            ShortDescription = "pour collectionneur",
                            SneakerName = "Sheti"
                        },
                        new
                        {
                            SneakerId = 4,
                            CategoryId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                            Instock = true,
                            LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                            Price = 109m,
                            ShortDescription = "pour collectionneur",
                            SneakerName = "Jenevaah"
                        },
                        new
                        {
                            SneakerId = 5,
                            CategoryId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                            Instock = true,
                            LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                            Price = 109m,
                            ShortDescription = "pour collectionneur",
                            SneakerName = "Ezraahn"
                        },
                        new
                        {
                            SneakerId = 6,
                            CategoryId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                            Instock = true,
                            LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                            Price = 109m,
                            ShortDescription = "pour collectionneur",
                            SneakerName = "Aaron"
                        },
                        new
                        {
                            SneakerId = 7,
                            CategoryId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                            Instock = true,
                            LongDescription = "legères, confortables et rares , idéale pour collectionneur ",
                            Price = 109m,
                            ShortDescription = "pour collectionneur",
                            SneakerName = "Williams"
                        },
                        new
                        {
                            SneakerId = 8,
                            CategoryId = 4,
                            ImageUrl = "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ",
                            Instock = true,
                            LongDescription = "Précieuse, confortables et rares , idéale pour votre Maman ",
                            Price = 109m,
                            ShortDescription = "pour Maman",
                            SneakerName = "Rebecca"
                        });
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.CommandeDetail", b =>
                {
                    b.HasOne("Sneakers.Core.Data.Models.Commande", "Commande")
                        .WithMany("CommandeDetails")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sneakers.Core.Data.Models.Sneaker", "Sneaker")
                        .WithMany()
                        .HasForeignKey("SneakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Sneaker");
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Sneakers.Core.Data.Models.Sneaker", "Sneaker")
                        .WithMany()
                        .HasForeignKey("SneakerId");

                    b.Navigation("Sneaker");
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.Sneaker", b =>
                {
                    b.HasOne("Sneakers.Core.Data.Models.Category", "Category")
                        .WithMany("Sneakers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.Category", b =>
                {
                    b.Navigation("Sneakers");
                });

            modelBuilder.Entity("Sneakers.Core.Data.Models.Commande", b =>
                {
                    b.Navigation("CommandeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
