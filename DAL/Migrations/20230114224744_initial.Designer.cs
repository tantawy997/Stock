﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stock.Context;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppdbContext))]
    [Migration("20230114224744_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CatalogProducts", b =>
                {
                    b.Property<Guid>("CatalogsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CatalogsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CatalogProducts");
                });

            modelBuilder.Entity("DAL.Models.Catalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Catalogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a4c6d84-2dc3-4477-855b-51ccb581db27"),
                            Name = "John"
                        },
                        new
                        {
                            Id = new Guid("7b9beb8e-d7b3-4f1a-bf23-88ecab2ebb4d"),
                            Name = "James"
                        },
                        new
                        {
                            Id = new Guid("9368eaf9-5ed7-480d-807f-cc229b4b8c35"),
                            Name = "Anderson"
                        });
                });

            modelBuilder.Entity("DAL.Models.ProductDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DefualtStock")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("ProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("PurchasePrice")
                        .HasColumnType("real");

                    b.Property<float>("SalesPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("Stock.Models.Products", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("26d8877a-85ea-45da-8322-dfceeffee12f"),
                            description = "",
                            name = "Cold",
                            photo = "",
                            type = "out of stock"
                        },
                        new
                        {
                            Id = new Guid("ee1f2eb0-7f69-4738-acfc-ab19a5244c5f"),
                            description = "",
                            name = "Stress",
                            photo = "",
                            type = "out of stock"
                        },
                        new
                        {
                            Id = new Guid("37923fe5-c699-4ce6-83bc-2e6ac9890c04"),
                            description = "",
                            name = "Headache",
                            photo = "",
                            type = "out of stock"
                        });
                });

            modelBuilder.Entity("CatalogProducts", b =>
                {
                    b.HasOne("DAL.Models.Catalog", null)
                        .WithMany()
                        .HasForeignKey("CatalogsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stock.Models.Products", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Models.ProductDetails", b =>
                {
                    b.HasOne("Stock.Models.Products", null)
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductsId");
                });

            modelBuilder.Entity("Stock.Models.Products", b =>
                {
                    b.Navigation("ProductDetails");
                });
#pragma warning restore 612, 618
        }
    }
}