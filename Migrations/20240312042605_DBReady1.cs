using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DBReady1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "TransactionHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Item",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "e1e9dbfe-75e2-45a7-bf05-e2e0e50875f3", "d3aec1e8-f358-485a-8c06-4e76b92a4626", "User1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "4f707f34-a6f9-4a92-ab7f-f43be38c8a04", "5ece294f-ea7f-415f-83c1-f3c05d9380ce", "User2" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 100,
                columns: new[] { "IsPublic", "SellerId" },
                values: new object[] { false, "2" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 101,
                columns: new[] { "ImageUrl", "IsPublic", "SellerIconUrl" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item2.jpg\"]", false, "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 102,
                columns: new[] { "ImageUrl", "IsPublic", "VideoUrl" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item3.jpg\"]", true, "[\"https://idlegoodstorage.blob.core.windows.net/video/video1.mp4\"]" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 103,
                columns: new[] { "ImageUrl", "IsPublic" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item4.jpg\"]", true });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 104,
                columns: new[] { "ImageUrl", "IsPublic" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item5.jpg\"]", true });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 105,
                columns: new[] { "ImageUrl", "IsPublic" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item6.jpg\"]", true });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 106,
                columns: new[] { "ImageUrl", "IsPublic" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item7.jpg\"]", true });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 107,
                columns: new[] { "ImageUrl", "IsPublic" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item8.jpg\"]", true });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "AdDescription", "Description", "ImageUrl", "IsPublic", "LikesCount", "Price", "SellerIconUrl", "SellerId", "SellerName", "Title", "VideoUrl" },
                values: new object[,]
                {
                    { 108, null, "This is a description for item 9", "[\"https://idlegoodstorage.blob.core.windows.net/image/item9.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1", null },
                    { 109, null, "This is a description for item 10", "[\"https://idlegoodstorage.blob.core.windows.net/image/item10.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1", null },
                    { 110, null, "This is a description for item 11", "[\"https://idlegoodstorage.blob.core.windows.net/image/item11.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1", null },
                    { 111, null, "This is a description for item 12", "[\"https://idlegoodstorage.blob.core.windows.net/image/item12.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1", null },
                    { 112, null, "This is a description for item 13", "[\"https://idlegoodstorage.blob.core.windows.net/image/item13.jpg\"]", false, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "1", "user1", "Item 1", null },
                    { 113, null, "This is a description for item 14", "[\"https://idlegoodstorage.blob.core.windows.net/image/item14.jpg\"]", false, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "1", "user2", "Item 1", null },
                    { 114, null, "This is a description for item 15", "[\"https://idlegoodstorage.blob.core.windows.net/image/item15.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1", null }
                });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                columns: new[] { "BuyerName", "ItemUrl", "SellerName", "Status", "TransactionDate" },
                values: new object[] { "User1", "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]", "User2", "In Progress", new DateTime(2024, 3, 2, 4, 26, 5, 622, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                columns: new[] { "BuyerId", "BuyerName", "ItemId", "ItemUrl", "SellerId", "SellerName", "Status", "TransactionDate" },
                values: new object[] { "1", "User1", 101, "[\"https://idlegoodstorage.blob.core.windows.net/image/item2.jpg\"]", "2", "User2", "Completed", new DateTime(2024, 3, 7, 4, 26, 5, 622, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.InsertData(
                table: "TransactionHistory",
                columns: new[] { "TransactionId", "BuyerId", "BuyerName", "ItemId", "ItemId1", "ItemUrl", "SellerId", "SellerName", "Status", "TransactionDate" },
                values: new object[,]
                {
                    { 10002, "2", "User2", 112, null, "[\"https://idlegoodstorage.blob.core.windows.net/image/item13.jpg\"]", "1", "User1", "In Progress", new DateTime(2024, 3, 9, 4, 26, 5, 622, DateTimeKind.Utc).AddTicks(8007) },
                    { 10003, "2", "User2", 113, null, "[\"https://idlegoodstorage.blob.core.windows.net/image/item14.jpg\"]", "1", "User1", "Completed", new DateTime(2024, 3, 9, 4, 26, 5, 622, DateTimeKind.Utc).AddTicks(8009) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002);

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TransactionHistory");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SelfIntro", "TwoFactorEnabled", "UserIconUrl", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "User1 Address", "a7927c31-dbe4-459a-9eec-8023734fe5f5", "User", "user1@coventry.com", true, false, null, "USER1@COVENTRY.COM", "USER1", null, null, false, "f1376eaf-c99d-4e07-bbc3-0a6d80a7e7f0", "Hi, I'm User1", false, "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "user1" },
                    { "2", 0, "User2 Address", "f81e2b3a-6051-4bf9-ba19-3952d3752de5", "User", "user2@coventry.com", true, false, null, "USER2@COVENTRY.COM", "USER2", null, null, false, "66c21a36-931e-44d7-a7f5-3e78325b0b46", "Hi, I'm User2", false, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "user2" }
                });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 100,
                column: "SellerId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 101,
                columns: new[] { "ImageUrl", "SellerIconUrl" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item10.jpg\"]", "http://example.com/seller2icon.jpg" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 102,
                columns: new[] { "ImageUrl", "VideoUrl" },
                values: new object[] { "[\"https://idlegoodstorage.blob.core.windows.net/image/item11.jpg\"]", null });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 103,
                column: "ImageUrl",
                value: "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 104,
                column: "ImageUrl",
                value: "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 105,
                column: "ImageUrl",
                value: "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 106,
                column: "ImageUrl",
                value: "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 107,
                column: "ImageUrl",
                value: "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                columns: new[] { "BuyerName", "ItemUrl", "SellerName", "TransactionDate" },
                values: new object[] { "Buyer1 Name", "https://example.com/path/to/item1.jpg", "Buyer1 Username", new DateTime(2024, 3, 1, 21, 50, 43, 845, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                columns: new[] { "BuyerId", "BuyerName", "ItemId", "ItemUrl", "SellerId", "SellerName", "TransactionDate" },
                values: new object[] { "2", "Buyer2 Name", 100, "https://example.com/path/to/item2.jpg", "1", "Buyer2 Username", new DateTime(2024, 3, 6, 21, 50, 43, 845, DateTimeKind.Utc).AddTicks(2639) });
        }
    }
}
