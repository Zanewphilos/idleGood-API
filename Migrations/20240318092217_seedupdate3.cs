using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedupdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8c2235b-f194-4ff8-8684-2048a7b07744", "870f3aa4-5254-4dd0-80a1-bcbb0d5c467e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b384707c-b6f1-4d12-9127-43212a39ba84", "95ff1a00-01e1-4206-a4d9-7f2f6e3c850f" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 8, 9, 22, 17, 556, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 13, 9, 22, 17, 556, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10002,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 15, 9, 22, 17, 556, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10003,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 15, 9, 22, 17, 556, DateTimeKind.Utc).AddTicks(6439));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
