using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class releaseversion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "055fd377-3ced-4c49-a2e1-a32cffa454b7", "fa6e2d52-36de-47a6-bd8f-bba9830a31a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "178543ef-d4c5-4d76-ab11-0816f1b0a982", "5777332f-989e-43d2-8d16-6dcdfac28021" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 8, 10, 7, 59, 641, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 13, 10, 7, 59, 641, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 15, 10, 7, 59, 641, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 15, 10, 7, 59, 641, DateTimeKind.Utc).AddTicks(1530));
        }
    }
}
