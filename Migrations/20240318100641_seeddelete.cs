using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class seeddelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 107);

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
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001);

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002);

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 113);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3ea17fb-2eee-4174-b784-e3ab03891daa", "d160be12-78ba-4178-a6f8-c726b03786ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7749cc43-d822-4a77-a3a3-5e3b937c7cb0", "7f2fce98-f3e0-4913-8e62-33700c2f7dbd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17cb1f9a-1c0d-4ffe-aa44-3894b3315fb2", "7647d5d2-95c6-41cc-b6b2-741859678db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bf96004d-36b4-4683-8879-d28f4d009249", "642a8f96-bea7-431d-b563-5e16f9c84ffb" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "AdDescription", "Description", "ImageUrl", "IsPublic", "LikesCount", "Price", "SellerIconUrl", "SellerId", "SellerName", "Title", "VideoUrl" },
                values: new object[,]
                {
                    { 100, null, "This is a description for item 1", "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]", false, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1", null },
                    { 101, null, "This is a description for item 2", "[\"https://idlegoodstorage.blob.core.windows.net/image/item2.jpg\"]", false, 20, 50f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 2", null },
                    { 102, null, "This is a description for item 3", "[\"https://idlegoodstorage.blob.core.windows.net/image/item3.jpg\"]", true, 120, 20f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 3", "[\"https://idlegoodstorage.blob.core.windows.net/video/video1.mp4\"]" },
                    { 103, null, "This is a description for item 4", "[\"https://idlegoodstorage.blob.core.windows.net/image/item4.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "User2", "Item 4", null },
                    { 104, null, "This is a description for item 5", "[\"https://idlegoodstorage.blob.core.windows.net/image/item5.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "User2", "Item 5", null },
                    { 105, null, "This is a description for item 6", "[\"https://idlegoodstorage.blob.core.windows.net/image/item6.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "User2", "Item 6", null },
                    { 106, null, "This is a description for item 7", "[\"https://idlegoodstorage.blob.core.windows.net/image/item7.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 7", null },
                    { 107, null, "This is a description for item 8", "[\"https://idlegoodstorage.blob.core.windows.net/image/item8.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 8", null },
                    { 108, null, "This is a description for item 9", "[\"https://idlegoodstorage.blob.core.windows.net/image/item9.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "User2", "Item 9", null },
                    { 109, null, "This is a description for item 10", "[\"https://idlegoodstorage.blob.core.windows.net/image/item10.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "User2", "Item 10", null },
                    { 110, null, "This is a description for item 11", "[\"https://idlegoodstorage.blob.core.windows.net/image/item11.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 11", null },
                    { 111, null, "This is a description for item 12", "[\"https://idlegoodstorage.blob.core.windows.net/image/item12.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 12", null },
                    { 112, null, "This is a description for item 13", "[\"https://idlegoodstorage.blob.core.windows.net/image/item13.jpg\"]", false, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "1", "User1", "Item 13", null },
                    { 113, null, "This is a description for item 14", "[\"https://idlegoodstorage.blob.core.windows.net/image/item14.jpg\"]", false, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "1", "User2", "Item 14", null },
                    { 114, null, "This is a description for item 15", "[\"https://idlegoodstorage.blob.core.windows.net/image/item15.jpg\"]", true, 10, 10f, "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "User2", "Item 15", null }
                });

            migrationBuilder.InsertData(
                table: "TransactionHistory",
                columns: new[] { "TransactionId", "BuyerId", "BuyerName", "ItemId", "ItemId1", "ItemUrl", "SellerId", "SellerName", "Status", "TransactionDate" },
                values: new object[,]
                {
                    { 10000, "1", "User1", 100, null, "[\"https://idlegoodstorage.blob.core.windows.net/image/item1.jpg\"]", "2", "User2", "In Progress", new DateTime(2024, 3, 8, 9, 34, 43, 366, DateTimeKind.Utc).AddTicks(6645) },
                    { 10001, "1", "User1", 101, null, "[\"https://idlegoodstorage.blob.core.windows.net/image/item2.jpg\"]", "2", "User2", "Completed", new DateTime(2024, 3, 13, 9, 34, 43, 366, DateTimeKind.Utc).AddTicks(6652) },
                    { 10002, "2", "User2", 112, null, "[\"https://idlegoodstorage.blob.core.windows.net/image/item13.jpg\"]", "1", "User1", "In Progress", new DateTime(2024, 3, 15, 9, 34, 43, 366, DateTimeKind.Utc).AddTicks(6655) },
                    { 10003, "2", "User2", 113, null, "[\"https://idlegoodstorage.blob.core.windows.net/image/item14.jpg\"]", "1", "User1", "Completed", new DateTime(2024, 3, 15, 9, 34, 43, 366, DateTimeKind.Utc).AddTicks(6657) }
                });
        }
    }
}
