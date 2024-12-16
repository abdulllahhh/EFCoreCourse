using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class final_state : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 16, 21, 4, 21, 755, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 16, 21, 4, 21, 755, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" },
                column: "AddedOn",
                value: new DateTime(2024, 12, 16, 21, 4, 21, 755, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "10",
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "2",
                column: "isDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "9",
                column: "isDeleted",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
