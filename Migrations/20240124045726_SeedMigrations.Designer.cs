﻿// <auto-generated />
using BulkyWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240124045726_SeedMigrations")]
    partial class SeedMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BulkyWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Horror"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
