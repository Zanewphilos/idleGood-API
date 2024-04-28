using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa7d6131-2942-4fcd-bdff-ffc83dc3f475", "dd4f451c-03df-4f1c-9003-bc96041f8d11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00e863a1-5c66-4640-80da-849b86d272e4", "219e45ba-3896-47a1-9b75-7bf9ce03fcab" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 4, 8, 23, 12, 678, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 9, 8, 23, 12, 678, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 11, 8, 23, 12, 678, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 11, 8, 23, 12, 678, DateTimeKind.Utc).AddTicks(300));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01043a96-be65-4d5a-b00e-952fb64f5a3d", "fa6fb13e-1403-41c8-a7d5-75bf50ed2762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f2cd520-d783-4ad2-9726-d77b3b580f28", "7cf0fda1-6bbe-441f-be5a-ce3794e1a28d" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 3, 3, 0, 18, 496, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 8, 3, 0, 18, 496, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 10, 3, 0, 18, 496, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 10, 3, 0, 18, 496, DateTimeKind.Utc).AddTicks(257));
        }
    }
}
