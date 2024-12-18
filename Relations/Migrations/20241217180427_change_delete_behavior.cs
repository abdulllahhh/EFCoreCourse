using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class change_delete_behavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Posts_postId",
                table: "PostTag");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Tags_tagId",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag");

            migrationBuilder.DropIndex(
                name: "IX_PostTag_postId",
                table: "PostTag");

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "10", "1" });

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag",
                columns: new[] { "postId", "tagId" });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "postId", "tagId" },
                values: new object[] { "10", "1" });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "postId", "tagId", "AddedOn" },
                values: new object[,]
                {
                    { "2", "25", new DateTime(2024, 12, 17, 20, 4, 27, 336, DateTimeKind.Local).AddTicks(629) },
                    { "9", "2", new DateTime(2024, 12, 17, 20, 4, 27, 336, DateTimeKind.Local).AddTicks(626) },
                    { "9", "25", new DateTime(2024, 12, 17, 20, 4, 27, 336, DateTimeKind.Local).AddTicks(570) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_tagId",
                table: "PostTag",
                column: "tagId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Posts_postId",
                table: "PostTag",
                column: "postId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Tags_tagId",
                table: "PostTag",
                column: "tagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Posts_postId",
                table: "PostTag");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Tags_tagId",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag");

            migrationBuilder.DropIndex(
                name: "IX_PostTag_tagId",
                table: "PostTag");

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "10", "1" });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "2", "25" });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "2" });

            migrationBuilder.DeleteData(
                table: "PostTag",
                keyColumns: new[] { "postId", "tagId" },
                keyValues: new object[] { "9", "25" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag",
                columns: new[] { "tagId", "postId" });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "postId", "tagId" },
                values: new object[] { "10", "1" });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "postId", "tagId", "AddedOn" },
                values: new object[,]
                {
                    { "9", "2", new DateTime(2024, 12, 16, 21, 4, 21, 755, DateTimeKind.Local).AddTicks(459) },
                    { "2", "25", new DateTime(2024, 12, 16, 21, 4, 21, 755, DateTimeKind.Local).AddTicks(463) },
                    { "9", "25", new DateTime(2024, 12, 16, 21, 4, 21, 755, DateTimeKind.Local).AddTicks(395) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_postId",
                table: "PostTag",
                column: "postId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Posts_postId",
                table: "PostTag",
                column: "postId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Tags_tagId",
                table: "PostTag",
                column: "tagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
