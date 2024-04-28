using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace idleGood_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_AspNetUsers_SellerId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "TransactionHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SellerId",
                table: "TransactionHistory",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemUrl",
                table: "TransactionHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BuyerName",
                table: "TransactionHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BuyerId",
                table: "TransactionHistory",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SellerId",
                table: "Item",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SellerIconUrl",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AdDescription",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "SecurityStamp" },
                values: new object[] { "a7927c31-dbe4-459a-9eec-8023734fe5f5", "user1@coventry.com", "USER1@COVENTRY.COM", "f1376eaf-c99d-4e07-bbc3-0a6d80a7e7f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "SecurityStamp" },
                values: new object[] { "f81e2b3a-6051-4bf9-ba19-3952d3752de5", "user2@coventry.com", "USER2@COVENTRY.COM", "66c21a36-931e-44d7-a7f5-3e78325b0b46" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 100,
                columns: new[] { "AdDescription", "Description", "SellerIconUrl", "VideoUrl" },
                values: new object[] { null, "This is a description for item 1", "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", null });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 101,
                columns: new[] { "AdDescription", "Description", "VideoUrl" },
                values: new object[] { null, "This is a description for item 2", null });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 102,
                columns: new[] { "AdDescription", "Description", "SellerIconUrl", "VideoUrl" },
                values: new object[] { null, "This is a description for item 3", "https://idlegoodstorage.blob.core.windows.net/usericon/icon1.jpg", null });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 103,
                columns: new[] { "AdDescription", "Description", "VideoUrl" },
                values: new object[] { null, "This is a description for item 4", null });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 104,
                columns: new[] { "AdDescription", "Description", "VideoUrl" },
                values: new object[] { null, "This is a description for item 5", null });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 105,
                columns: new[] { "AdDescription", "Description", "VideoUrl" },
                values: new object[] { null, "This is a description for item 6", null });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 106,
                columns: new[] { "AdDescription", "Description", "VideoUrl" },
                values: new object[] { null, "This is a description for item 7", null });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 107,
                columns: new[] { "AdDescription", "Description", "VideoUrl" },
                values: new object[] { null, "This is a description for item 8", null });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10000,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 1, 21, 50, 43, 845, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "TransactionId",
                keyValue: 10001,
                column: "TransactionDate",
                value: new DateTime(2024, 3, 6, 21, 50, 43, 845, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.AddForeignKey(
                name: "FK_Item_AspNetUsers_SellerId",
                table: "Item",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_AspNetUsers_SellerId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AdDescription",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Item");

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "TransactionHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SellerId",
                table: "TransactionHistory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ItemUrl",
                table: "TransactionHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BuyerName",
                table: "TransactionHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BuyerId",
                table: "TransactionHistory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SellerId",
                table: "Item",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SellerIconUrl",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "Password", "SecurityStamp" },
                values: new object[] { "78ba387d-e3d9-4fd7-98ce-792542b79457", "user1@example.com", "USER1@EXAMPLE.COM", "123456", "9b97ce78-aa22-4d50-91ec-1017b389f792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "Password", "SecurityStamp" },
                values: new object[] { "d4d69b29-d1cc-4e45-a945-212f583304ef", "user2@example.com", "USER2@EXAMPLE.COM", "123456", "f74e55d7-5c01-45f7-ae82-9604403e369a" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 100,
                column: "SellerIconUrl",
                value: "https://idlegoodstorage.blob.core.windows.net/usericon/icon2.jpg");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 102,
                column: "SellerIconUrl",
                value: "http://example.com/seller1icon.jpg");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Item_AspNetUsers_SellerId",
                table: "Item",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
