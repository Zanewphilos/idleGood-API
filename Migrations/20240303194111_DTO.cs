using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "ItemTag",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTag", x => new { x.ItemId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ItemTag_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78ba387d-e3d9-4fd7-98ce-792542b79457", "9b97ce78-aa22-4d50-91ec-1017b389f792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4d69b29-d1cc-4e45-a945-212f583304ef", "f74e55d7-5c01-45f7-ae82-9604403e369a" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 2, 22, 19, 41, 10, 257, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 2, 27, 19, 41, 10, 257, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.CreateIndex(
                name: "IX_ItemTag_TagId",
                table: "ItemTag",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemTag");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e18b37f2-c734-4e14-b4c8-4420b7777628", "1e50be8a-b665-4146-b753-a171c5f07597" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85cbde68-f870-4262-9fe3-f83c8cc55dd3", "41fcf17c-c5e1-4172-aca3-ee6f0270894c" });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 2, 22, 0, 4, 42, 640, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 2, 27, 0, 4, 42, 640, DateTimeKind.Utc).AddTicks(1230));
        }
    }
}
