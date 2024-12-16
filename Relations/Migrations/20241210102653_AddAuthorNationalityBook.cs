using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorNationalityBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "PostTag",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "orderNumber",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR orderNumber",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                    table.ForeignKey(
                        name: "FK_Authors_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "NationalityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 10, 12, 26, 52, 762, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 10, 12, 26, 52, 762, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 10, 12, 26, 52, 758, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.CreateIndex(
                name: "IX_Authors_NationalityId",
                table: "Authors",
                column: "NationalityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "PostTag",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<int>(
                name: "orderNumber",
                table: "orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR orderNumber");

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 8, 22, 11, 4, 845, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 8, 22, 11, 4, 845, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 8, 22, 11, 4, 840, DateTimeKind.Local).AddTicks(9988));
        }
    }
}
