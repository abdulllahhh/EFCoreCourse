using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 8, 22, 7, 35, 500, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 8, 22, 7, 35, 500, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 8, 22, 7, 35, 496, DateTimeKind.Local).AddTicks(6034));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
