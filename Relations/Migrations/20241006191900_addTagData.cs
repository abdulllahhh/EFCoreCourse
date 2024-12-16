using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class addTagData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "orderNumber",
                table: "orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR orderNumber");

            migrationBuilder.AlterSequence(
                name: "orderNumber",
                incrementBy: 5);

            migrationBuilder.RestartSequence(
                name: "orderNumber",
                startValue: 1000L);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "TagId", "Title" },
                values: new object[,]
                {
                    { "2", "Content of second post", null, "Second Post" },
                    { "9", "Content of first post", null, "First Post" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Id",
                values: new object[]
                {
                    "2",
                    "25"
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "postId", "tagId", "AddedOn" },
                values: new object[,]
                {
                    { "9", "2", new DateTime(2024, 10, 6, 22, 19, 0, 559, DateTimeKind.Local).AddTicks(7837) },
                    { "2", "25", new DateTime(2024, 10, 6, 22, 19, 0, 559, DateTimeKind.Local).AddTicks(7841) },
                    { "9", "25", new DateTime(2024, 10, 6, 22, 19, 0, 559, DateTimeKind.Local).AddTicks(7779) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.AlterColumn<int>(
                name: "orderNumber",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR orderNumber",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterSequence(
                name: "orderNumber",
                oldIncrementBy: 5);

            migrationBuilder.RestartSequence(
                name: "orderNumber",
                startValue: 1L);
        }
    }
}
