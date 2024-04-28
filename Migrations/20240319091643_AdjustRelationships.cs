using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdjustRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_AspNetUsers_SellerId",
                table: "Item");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "495b87e0-7d21-4e92-b9b4-bd73b132a0bb", "6e95c603-5ca7-4262-9aff-73cb9aeaa606" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ab3994b-f91c-415e-8183-035e31eb0b47", "e1ec9cb1-5887-4eae-8aed-626d08fad9f3" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 9, 9, 16, 42, 869, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 14, 9, 16, 42, 869, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 16, 9, 16, 42, 869, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 16, 9, 16, 42, 869, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.AddForeignKey(
                name: "FK_Item_AspNetUsers_SellerId",
                table: "Item",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_AspNetUsers_SellerId",
                table: "Item");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dca5e58e-2668-4bfc-a3a8-ba28ce1a2e3a", "bb8d111b-6496-4f4e-b10e-a0c6ed282e15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cd536a0-b1a9-4a11-a9c9-0a7ed7d8038e", "dad460e1-9a1c-436e-b40e-31b48ae3428a" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 8, 20, 10, 21, 296, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 13, 20, 10, 21, 296, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 15, 20, 10, 21, 296, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 15, 20, 10, 21, 296, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.AddForeignKey(
                name: "FK_Item_AspNetUsers_SellerId",
                table: "Item",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
