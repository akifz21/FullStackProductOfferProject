﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ProductCatalogContext))]
    [Migration("20220811102609_mig11")]
    partial class mig11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OperationClaimId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            Name = "Apple"
                        },
                        new
                        {
                            BrandId = 2,
                            Name = "Samsung"
                        },
                        new
                        {
                            BrandId = 3,
                            Name = "Asus"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Telephone"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Computer"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            Name = "White"
                        },
                        new
                        {
                            ColorId = 2,
                            Name = "Black"
                        },
                        new
                        {
                            ColorId = 3,
                            Name = "Orange"
                        },
                        new
                        {
                            ColorId = 4,
                            Name = "Red"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfferId"), 1L, 1);

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("OfferTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OfferedPrice")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OfferId");

                    b.HasIndex("ProductId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOfferable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSold")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UsingStatusId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("UserId");

                    b.HasIndex("UsingStatusId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            ColorId = 1,
                            Description = "Apple Telefon",
                            InsertTime = new DateTime(2022, 8, 11, 13, 26, 8, 417, DateTimeKind.Local).AddTicks(5083),
                            IsOfferable = true,
                            IsSold = false,
                            Price = 6000,
                            ProductName = "Telefon",
                            UsingStatusId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            BrandId = 3,
                            CategoryId = 2,
                            ColorId = 2,
                            Description = "Asus Vivobook X571GT-HN1012 Intel Core i5 9300H 8GB 512GB SSD GTX1650 Freedos",
                            InsertTime = new DateTime(2022, 8, 11, 13, 26, 8, 417, DateTimeKind.Local).AddTicks(5098),
                            IsOfferable = true,
                            IsSold = false,
                            Price = 8000,
                            ProductName = "Asus Laptop",
                            UsingStatusId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            BrandId = 2,
                            CategoryId = 1,
                            ColorId = 1,
                            Description = "Samsung Galaxy A32 128 GB",
                            InsertTime = new DateTime(2022, 8, 11, 13, 26, 8, 417, DateTimeKind.Local).AddTicks(5101),
                            IsOfferable = true,
                            IsSold = false,
                            Price = 6000,
                            ProductName = "Samsung Telefon",
                            UsingStatusId = 1
                        });
                });

            modelBuilder.Entity("Entities.Concrete.ProductImage", b =>
                {
                    b.Property<int>("ProductImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImageId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            ProductImageId = 1,
                            Date = new DateTime(2022, 8, 11, 13, 26, 8, 417, DateTimeKind.Local).AddTicks(5158),
                            ImagePath = "96b4a457-47f4-4b50-8ff2-e6136b308a3d.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            ProductImageId = 2,
                            Date = new DateTime(2022, 8, 11, 13, 26, 8, 417, DateTimeKind.Local).AddTicks(5169),
                            ImagePath = "9c21406c-7319-42e2-9e07-1aacbbf798fa.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            ProductImageId = 3,
                            Date = new DateTime(2022, 8, 11, 13, 26, 8, 417, DateTimeKind.Local).AddTicks(5170),
                            ImagePath = "94e5554d-ffa6-4d7d-8c3a-297a8681fc8d.jpg",
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("Entities.Concrete.UsingStatus", b =>
                {
                    b.Property<int>("UsingStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsingStatusId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsingStatusId");

                    b.ToTable("UsingStatuses");

                    b.HasData(
                        new
                        {
                            UsingStatusId = 1,
                            Name = "New"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Offer", b =>
                {
                    b.HasOne("Entities.Concrete.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.HasOne("Entities.Concrete.Brand", null)
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Concrete.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Color", null)
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Concrete.UsingStatus", null)
                        .WithMany()
                        .HasForeignKey("UsingStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.ProductImage", b =>
                {
                    b.HasOne("Entities.Concrete.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
