﻿// <auto-generated />
using Animal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Animal.Migrations
{
    [DbContext(typeof(AnimalContext))]
    [Migration("20220427211057_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Animal.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 5,
                            Breed = "Unknown",
                            Gender = "Female",
                            Name = "Frenchy",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 4,
                            Breed = "Persian",
                            Gender = "Female",
                            Name = "Pickels",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 3,
                            Breed = "Husky",
                            Gender = "Female",
                            Name = "Spot",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 1,
                            Breed = "Great Dane",
                            Gender = "Male",
                            Name = "Bisque",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 2,
                            Breed = "German Shepherd",
                            Gender = "Male",
                            Name = "Chicago",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 5,
                            Breed = "Siamese",
                            Gender = "Male",
                            Name = "Sammy",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 9,
                            Breed = "Bulldog",
                            Gender = "Female",
                            Name = "Baby",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 6,
                            Breed = "Beagle",
                            Gender = "Male",
                            Name = "Rufus",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 10,
                            Breed = "Unknown",
                            Gender = "Male",
                            Name = "Doug",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 1,
                            Breed = "Mixed",
                            Gender = "Female",
                            Name = "Lucy",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
