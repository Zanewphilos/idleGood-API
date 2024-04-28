using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DBSeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30cfe503-7d31-48e9-b6f2-c1cfbf540095", "f549af20-70ed-46e9-8b93-17ee9c2bd17d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "439bbffb-7ad2-4762-8cbd-2d7e7836a5c1", "e14f895a-264a-46ff-81b4-c5a69c91d0fe" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 100,
                column: "SellerIconUrl",
                value: "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 101,
                column: "SellerIconUrl",
                value: "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 102,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User1", "Item 3" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 103,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User2", "Item 4" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 104,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User2", "Item 5" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 105,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User2", "Item 6" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 106,
                columns: new[] { "SellerIconUrl", "SellerId", "SellerName", "Title" },
                values: new object[] { "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 7" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 107,
                columns: new[] { "SellerIconUrl", "SellerId", "SellerName", "Title" },
                values: new object[] { "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 8" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 108,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User2", "Item 9" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 109,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User2", "Item 10" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 110,
                columns: new[] { "SellerIconUrl", "SellerId", "SellerName", "Title" },
                values: new object[] { "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 11" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 111,
                columns: new[] { "SellerIconUrl", "SellerId", "SellerName", "Title" },
                values: new object[] { "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", "1", "User1", "Item 12" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 112,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User1", "Item 13" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 113,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User2", "Item 14" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 114,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "User2", "Item 15" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 2, 4, 34, 28, 951, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 7, 4, 34, 28, 951, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 9, 4, 34, 28, 951, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 9, 4, 34, 28, 951, DateTimeKind.Utc).AddTicks(1654));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1e9dbfe-75e2-45a7-bf05-e2e0e50875f3", "d3aec1e8-f358-485a-8c06-4e76b92a4626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f707f34-a6f9-4a92-ab7f-f43be38c8a04", "5ece294f-ea7f-415f-83c1-f3c05d9380ce" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 100,
                column: "SellerIconUrl",
                value: "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 101,
                column: "SellerIconUrl",
                value: "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 102,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user2", "Item 12" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 103,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 104,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 105,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 106,
                columns: new[] { "SellerIconUrl", "SellerId", "SellerName", "Title" },
                values: new object[] { "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 107,
                columns: new[] { "SellerIconUrl", "SellerId", "SellerName", "Title" },
                values: new object[] { "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 108,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 109,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 110,
                columns: new[] { "SellerIconUrl", "SellerId", "SellerName", "Title" },
                values: new object[] { "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 111,
                columns: new[] { "SellerIconUrl", "SellerId", "SellerName", "Title" },
                values: new object[] { "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg", "2", "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 112,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user1", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 113,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 114,
                columns: new[] { "SellerName", "Title" },
                values: new object[] { "user2", "Item 1" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 2, 4, 26, 5, 622, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 7, 4, 26, 5, 622, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 9, 4, 26, 5, 622, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 9, 4, 26, 5, 622, DateTimeKind.Utc).AddTicks(8009));
        }
    }
}
