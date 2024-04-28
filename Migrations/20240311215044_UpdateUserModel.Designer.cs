﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using idleGood_WebAPI.Models;

#nullable disable

namespace idleGood_WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240311215044_UpdateUserModel")]
    partial class UpdateUserModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("AdDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikesCount")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("SellerIconUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SellerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("SellerId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            ItemId = 100,
                            Description = "This is a description for item 1",
                            ImageUrl = "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]",
                            LikesCount = 10,
                            Price = 10f,
                            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg",
                            SellerId = "1",
                            SellerName = "user2",
                            Title = "Item 1"
                        },
                        new
                        {
                            ItemId = 101,
                            Description = "This is a description for item 2",
                            ImageUrl = "[\"https://idlegoodstorage.blob.core.windows.net/image/item10.jpg\"]",
                            LikesCount = 20,
                            Price = 50f,
                            SellerIconUrl = "http://example.com/seller2icon.jpg",
                            SellerId = "2",
                            SellerName = "user2",
                            Title = "Item 2"
                        },
                        new
                        {
                            ItemId = 102,
                            Description = "This is a description for item 3",
                            ImageUrl = "[\"https://idlegoodstorage.blob.core.windows.net/image/item11.jpg\"]",
                            LikesCount = 120,
                            Price = 20f,
                            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg",
                            SellerId = "1",
                            SellerName = "user2",
                            Title = "Item 12"
                        },
                        new
                        {
                            ItemId = 103,
                            Description = "This is a description for item 4",
                            ImageUrl = "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]",
                            LikesCount = 10,
                            Price = 10f,
                            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
                            SellerId = "2",
                            SellerName = "user2",
                            Title = "Item 1"
                        },
                        new
                        {
                            ItemId = 104,
                            Description = "This is a description for item 5",
                            ImageUrl = "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]",
                            LikesCount = 10,
                            Price = 10f,
                            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
                            SellerId = "2",
                            SellerName = "user2",
                            Title = "Item 1"
                        },
                        new
                        {
                            ItemId = 105,
                            Description = "This is a description for item 6",
                            ImageUrl = "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]",
                            LikesCount = 10,
                            Price = 10f,
                            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
                            SellerId = "2",
                            SellerName = "user2",
                            Title = "Item 1"
                        },
                        new
                        {
                            ItemId = 106,
                            Description = "This is a description for item 7",
                            ImageUrl = "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]",
                            LikesCount = 10,
                            Price = 10f,
                            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
                            SellerId = "2",
                            SellerName = "user2",
                            Title = "Item 1"
                        },
                        new
                        {
                            ItemId = 107,
                            Description = "This is a description for item 8",
                            ImageUrl = "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]",
                            LikesCount = 10,
                            Price = 10f,
                            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
                            SellerId = "2",
                            SellerName = "user2",
                            Title = "Item 1"
                        });
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.ItemTag", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ItemTag");
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.TransactionHistory", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<string>("BuyerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BuyerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.Property<string>("ItemUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SellerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ItemId");

                    b.HasIndex("ItemId1");

                    b.HasIndex("SellerId");

                    b.ToTable("TransactionHistory");

                    b.HasData(
                        new
                        {
                            TransactionId = 10000,
                            BuyerId = "1",
                            BuyerName = "Buyer1 Name",
                            ItemId = 100,
                            ItemUrl = "https://example.com/path/to/item1.jpg",
                            SellerId = "2",
                            SellerName = "Buyer1 Username",
                            TransactionDate = new DateTime(2024, 3, 1, 21, 50, 43, 845, DateTimeKind.Utc).AddTicks(2632)
                        },
                        new
                        {
                            TransactionId = 10001,
                            BuyerId = "2",
                            BuyerName = "Buyer2 Name",
                            ItemId = 100,
                            ItemUrl = "https://example.com/path/to/item2.jpg",
                            SellerId = "1",
                            SellerName = "Buyer2 Username",
                            TransactionDate = new DateTime(2024, 3, 6, 21, 50, 43, 845, DateTimeKind.Utc).AddTicks(2639)
                        });
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelfIntro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIconUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a7927c31-dbe4-459a-9eec-8023734fe5f5",
                            Email = "user1@coventry.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@COVENTRY.COM",
                            NormalizedUserName = "USER1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f1376eaf-c99d-4e07-bbc3-0a6d80a7e7f0",
                            TwoFactorEnabled = false,
                            UserName = "user1",
                            Address = "User1 Address",
                            SelfIntro = "Hi, I'm User1",
                            UserIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f81e2b3a-6051-4bf9-ba19-3952d3752de5",
                            Email = "user2@coventry.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@COVENTRY.COM",
                            NormalizedUserName = "USER2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "66c21a36-931e-44d7-a7f5-3e78325b0b46",
                            TwoFactorEnabled = false,
                            UserName = "user2",
                            Address = "User2 Address",
                            SelfIntro = "Hi, I'm User2",
                            UserIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.Item", b =>
                {
                    b.HasOne("idleGood_WebAPI.Models.User", "Seller")
                        .WithMany("ItemsForSale")
                        .HasForeignKey("SellerId");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.ItemTag", b =>
                {
                    b.HasOne("idleGood_WebAPI.Models.Item", "Item")
                        .WithMany("ItemTags")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("idleGood_WebAPI.Models.Tag", "Tag")
                        .WithMany("ItemTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.TransactionHistory", b =>
                {
                    b.HasOne("idleGood_WebAPI.Models.User", "Buyer")
                        .WithMany("Purchases")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("idleGood_WebAPI.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("idleGood_WebAPI.Models.Item", null)
                        .WithMany("TransactionHistory")
                        .HasForeignKey("ItemId1");

                    b.HasOne("idleGood_WebAPI.Models.User", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Buyer");

                    b.Navigation("Item");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.Item", b =>
                {
                    b.Navigation("ItemTags");

                    b.Navigation("TransactionHistory");
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.Tag", b =>
                {
                    b.Navigation("ItemTags");
                });

            modelBuilder.Entity("idleGood_WebAPI.Models.User", b =>
                {
                    b.Navigation("ItemsForSale");

                    b.Navigation("Purchases");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}