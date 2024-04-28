using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using System.Xml;
using static System.Net.WebRequestMethods;


namespace idleGood_WebAPI.Models
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Item> Item { get; set; }
        public DbSet<TransactionHistory> TransactionHistory { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //this method only for test
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasKey(i => i.ItemId);

            // 配置User和Item之间的一对多关系
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Seller) // Item属于一个User
                .WithMany(u => u.ItemsForSale) // User有多个Item
                .HasForeignKey(i => i.SellerId)
                .OnDelete(DeleteBehavior.Cascade); // 外键是SellerId

            // 配置Item与TransactionHistory的关系
            modelBuilder.Entity<TransactionHistory>()
                .HasOne(th => th.Item)
                .WithMany()
                .HasForeignKey(th => th.ItemId)
                .OnDelete(DeleteBehavior.NoAction);


            // 配置User（Buyer）与TransactionHistory的关系
            modelBuilder.Entity<TransactionHistory>()
                .HasOne(th => th.Buyer)
                .WithMany(u => u.Purchases)
                .HasForeignKey(th => th.BuyerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TransactionHistory>()
                .HasOne(th => th.Seller)
                .WithMany(u => u.Sales)
                .HasForeignKey(th => th.SellerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ItemTag>()
        .HasKey(it => new { it.ItemId, it.TagId });

            modelBuilder.Entity<ItemTag>()
                .HasOne(it => it.Item)
                .WithMany(i => i.ItemTags)
                .HasForeignKey(it => it.ItemId);

            modelBuilder.Entity<ItemTag>()
                .HasOne(it => it.Tag)
                .WithMany(t => t.ItemTags)
                .HasForeignKey(it => it.TagId);



            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = "1", // 使用生成的用户ID
                        UserName = "User1",
                        NormalizedUserName = "USER1",
                        Email = "user1@coventry.com",
                        NormalizedEmail = "USER1@COVENTRY.COM",
                        EmailConfirmed = true,

                        UserIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg",
                        Address = "User1 Address",
                        SelfIntro = "Hi, I'm User1",
                        SecurityStamp = Guid.NewGuid().ToString(), // 生成安全戳
                        ConcurrencyStamp = Guid.NewGuid().ToString() // 生成并发戳

                    },
                    new User
                    {
                        Id = "2",
                        UserName = "User2",
                        NormalizedUserName = "USER2",
                        Email = "user2@coventry.com",
                        NormalizedEmail = "USER2@COVENTRY.COM",
                        EmailConfirmed = true,
                        UserIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
                        Address = "User2 Address",
                        SelfIntro = "Hi, I'm User2",
                        SecurityStamp = Guid.NewGuid().ToString(),
                        ConcurrencyStamp = Guid.NewGuid().ToString()
                    }
                );
            modelBuilder.Entity<Item>().HasData(
        new Item
        {
            ItemId = 100,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item1.jpg"
        },
            Price = 10f,
            Title = "Item 1",
            SellerName = "user2",
            SellerId = "2",
            Description = "This is a description for item 1",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = false
        },
        new Item
        {
            ItemId = 101,
            ImageUrl = new List<string>() {
            "https://idlegoodstorage.blob.core.windows.net/image/item2.jpg"
        },
            Price = 50f,
            Title = "Item 2",
            SellerName = "user2",
            SellerId = "2",
            Description = "This is a description for item 2",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 20,
            IsPublic = false
        },
        new Item
        {
            ItemId = 102,
            ImageUrl = new List<string>() {
            "https://idlegoodstorage.blob.core.windows.net/image/item3.jpg"
            },
            VideoUrl = new List<string>(){
            "https://idlegoodstorage.blob.core.windows.net/video/video1.mp4"
            },
            Price = 20f,
            Title = "Item 3",
            SellerName = "User1",
            SellerId = "1",
            Description = "This is a description for item 3",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg",
            LikesCount = 120,
            IsPublic = true
        },
        new Item
        {
            ItemId = 103,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item4.jpg"
        },
            Price = 10f,
            Title = "Item 4",
            SellerName = "User2",
            SellerId = "2",
            Description = "This is a description for item 4",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = true
        },
        new Item
        {
            ItemId = 104,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item5.jpg"
        },
            Price = 10f,
            Title = "Item 5",
            SellerName = "User2",
            SellerId = "2",
            Description = "This is a description for item 5",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = true
        },
        new Item
        {
            ItemId = 105,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item6.jpg"
        },
            Price = 10f,
            Title = "Item 6",
            SellerName = "User2",
            SellerId = "2",
            Description = "This is a description for item 6",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = true
        },
        new Item
        {
            ItemId = 106,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item7.jpg"
        },
            Price = 10f,
            Title = "Item 7",
            SellerName = "User1",
            SellerId = "1",
            Description = "This is a description for item 7",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg",
            LikesCount = 10,
            IsPublic = true
        },
        new Item
        {
            ItemId = 107,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item8.jpg"
        },
            Price = 10f,
            Title = "Item 8",
            SellerName = "User1",
            SellerId = "1",
            Description = "This is a description for item 8",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg",
            LikesCount = 10,
            IsPublic = true
        },

        new Item
        {
            ItemId = 108,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item9.jpg"
                   },
            Price = 10f,
            Title = "Item 9",
            SellerName = "User2",
            SellerId = "2",
            Description = "This is a description for item 9",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = true
        },
        new Item
        {
            ItemId = 109,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item10.jpg"
                   },
            Price = 10f,
            Title = "Item 10",
            SellerName = "User2",
            SellerId = "2",
            Description = "This is a description for item 10",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = true
        },
        new Item
        {
            ItemId = 110,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item11.jpg"
                              },
            Price = 10f,
            Title = "Item 11",
            SellerName = "User1",
            SellerId = "1",
            Description = "This is a description for item 11",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg",
            LikesCount = 10,
            IsPublic = true
        },

        new Item
        {
            ItemId = 111,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item12.jpg"
            },
            Price = 10f,
            Title = "Item 12",
            SellerName = "User1",
            SellerId = "1",
            Description = "This is a description for item 12",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg",
            LikesCount = 10,
            IsPublic = true
        },

        new Item
        {
            ItemId = 112,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item13.jpg"
                                                    },
            Price = 10f,
            Title = "Item 13",
            SellerName = "User1",
            SellerId = "1",
            Description = "This is a description for item 13",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = false
        },
        new Item
        {
            ItemId = 113,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item14.jpg"
                                                               },
            Price = 10f,
            Title = "Item 14",
            SellerName = "User2",
            SellerId = "1",
            Description = "This is a description for item 14",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = false
        },
        new Item
        {
            ItemId = 114,
            ImageUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item15.jpg"
                                                                                 },
            Price = 10f,
            Title = "Item 15",
            SellerName = "User2",
            SellerId = "2",
            Description = "This is a description for item 15",
            SellerIconUrl = "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg",
            LikesCount = 10,
            IsPublic = true
        }
    );
            modelBuilder.Entity<TransactionHistory>().HasData(
                new TransactionHistory
                {
                    TransactionId = 10000,
                    Status = "In Progress",
                    ItemId = 100,
                    ItemUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item1.jpg", },
                    BuyerId = "1",
                    BuyerName = "User1",
                    SellerId = "2",
                    SellerName = "User2",
                    TransactionDate = DateTime.UtcNow.AddDays(-10)
                },
        new TransactionHistory
        {
            TransactionId = 10001,
            Status = "Completed",
            ItemId = 101,
            ItemUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item2.jpg", },
            BuyerId = "1",
            BuyerName = "User1",
            SellerId = "2",
            SellerName = "User2",
            TransactionDate = DateTime.UtcNow.AddDays(-5)
        },

        new TransactionHistory
        {
            TransactionId = 10002,
            Status = "In Progress",
            ItemId = 112,
            ItemUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item13.jpg", },
            BuyerId = "2",
            BuyerName = "User2",
            SellerId = "1",
            SellerName = "User1",
            TransactionDate = DateTime.UtcNow.AddDays(-3)
        },

        new TransactionHistory
        {
            TransactionId = 10003,
            Status = "Completed",
            ItemId = 113, // 确保这个ID是存在的
            ItemUrl = new List<string>() { "https://idlegoodstorage.blob.core.windows.net/image/item14.jpg", },
            BuyerId = "2", // 确保这个ID是存在的
            BuyerName = "User2",
            SellerId = "1", // 这里假设UserId指的是BuyerId
            SellerName = "User1",
            TransactionDate = DateTime.UtcNow.AddDays(-3)
        }

    );


            

            //generate transaction history
        }
    }
}
    
