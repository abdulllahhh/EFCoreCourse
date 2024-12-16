using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class addMockTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MOCK_DATAs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOCK_DATAs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" },
                column: "AddedOn",
                value: new DateTime(2024, 10, 7, 2, 20, 15, 347, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 10, 7, 2, 20, 15, 347, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 10, 7, 2, 20, 15, 347, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "TagId", "Title" },
                values: new object[] { "10", "very much content", null, "title test" });

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Id",
                value: "1");

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "postId", "tagId", "AddedOn" },
                values: new object[] { "10", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MOCK_DATAs");

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "10", "1" });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" },
                column: "AddedOn",
                value: new DateTime(2024, 10, 6, 22, 19, 0, 559, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 10, 6, 22, 19, 0, 559, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 10, 6, 22, 19, 0, 559, DateTimeKind.Local).AddTicks(7779));
        }
    }
}
