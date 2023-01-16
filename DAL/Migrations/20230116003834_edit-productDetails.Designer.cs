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
    [Migration("20230116003834_edit-productDetails")]
    partial class editproductDetails
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
                            Id = new Guid("e9048982-5246-437e-b6e5-22914242404a"),
                            Name = "John"
                        },
                        new
                        {
                            Id = new Guid("c1410567-184c-4ed2-a1d6-4a2dd20e3726"),
                            Name = "James"
                        },
                        new
                        {
                            Id = new Guid("62848bbb-7ba9-489a-950e-366bbfd80c4a"),
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

                    b.Property<Guid>("ProductsId")
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
                            Id = new Guid("8b48ea2c-5d6e-453f-9438-4b97b86219f7"),
                            description = "",
                            name = "Cold",
                            photo = "",
                            type = "out of stock"
                        },
                        new
                        {
                            Id = new Guid("cfb8ca34-76e1-47bc-820a-e0ca0370e74c"),
                            description = "",
                            name = "Stress",
                            photo = "",
                            type = "out of stock"
                        },
                        new
                        {
                            Id = new Guid("e01fa83e-61da-46b9-9052-d813a1eebb22"),
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
                    b.HasOne("Stock.Models.Products", "Products")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Stock.Models.Products", b =>
                {
                    b.Navigation("ProductDetails");
                });
#pragma warning restore 612, 618
        }
    }
}