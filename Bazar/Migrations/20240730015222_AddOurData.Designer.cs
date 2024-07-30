﻿// <auto-generated />
using Bazar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bazar.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240730015222_AddOurData")]
    partial class AddOurData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bazar.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruits"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Vegetables"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Dairy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Baked Goods"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Beverages"
                        });
                });

            modelBuilder.Entity("Bazar.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Name = "Apple",
                            Price = 1.20m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Name = "Banana",
                            Price = 0.50m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Name = "Orange",
                            Price = 0.80m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Name = "Broccoli",
                            Price = 1.00m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Name = "Carrot",
                            Price = 0.30m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Name = "Milk",
                            Price = 1.50m
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Name = "Cheese",
                            Price = 2.50m
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4,
                            Name = "Bread",
                            Price = 1.00m
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 4,
                            Name = "Cake",
                            Price = 3.00m
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 5,
                            Name = "Coffee",
                            Price = 4.00m
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 5,
                            Name = "Tea",
                            Price = 2.00m
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 5,
                            Name = "Soda",
                            Price = 1.00m
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 3,
                            Name = "Yogurt",
                            Price = 1.20m
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 2,
                            Name = "Spinach",
                            Price = 0.80m
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 1,
                            Name = "Grapes",
                            Price = 2.00m
                        });
                });

            modelBuilder.Entity("Bazar.Models.Product", b =>
                {
                    b.HasOne("Bazar.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Bazar.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
