using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class AddBookAuthorNationaltyDataAndFixOneToOneRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Authors_NationalityId",
                table: "Authors");

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "NationalityId", "Name" },
                values: new object[,]
                {
                    { 1000, "Russian" },
                    { 2000, "Colombian" },
                    { 3000, "American" },
                    { 4000, "britsh" },
                    { 5000, "Egyptian" }
                });

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 10, 19, 35, 46, 678, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 10, 19, 35, 46, 678, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 10, 19, 35, 46, 674, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name", "NationalityId" },
                values: new object[,]
                {
                    { 1, "Gabrial jesus", 2000 },
                    { 2, "Abdullah Ibrahim", 3000 },
                    { 3, "cr7", 2000 },
                    { 4, "Messi", 5000 },
                    { 5, "abo treka", 1000 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "", 20f },
                    { 2, 3, "head first dp", 20f },
                    { 3, 4, "head first ooa&d", 20f },
                    { 4, 5, "grokking algorithm", 20f },
                    { 5, 2, "c# in a nutshell", 20f },
                    { 6, 3, "pro c# .net development", 20f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_NationalityId",
                table: "Authors",
                column: "NationalityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Authors_NationalityId",
                table: "Authors");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 5000);

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
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_NationalityId",
                table: "Authors",
                column: "NationalityId",
                unique: true);
        }
    }
}
