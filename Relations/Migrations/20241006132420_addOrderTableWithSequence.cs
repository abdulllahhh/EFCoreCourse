using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class addOrderTableWithSequence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag");

            migrationBuilder.DropIndex(
                name: "IX_PostTag_tagId",
                table: "PostTag");

            migrationBuilder.CreateSequence<int>(
                name: "orderNumber");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "PostTag",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "TagId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag",
                columns: new[] { "tagId", "postId" });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    orderNumber = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR orderNumber"),
                    ammount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_postId",
                table: "PostTag",
                column: "postId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagId",
                table: "Posts",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag");

            migrationBuilder.DropIndex(
                name: "IX_PostTag_postId",
                table: "PostTag");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TagId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Posts");

            migrationBuilder.DropSequence(
                name: "orderNumber");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "PostTag",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag",
                columns: new[] { "postId", "tagId" });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_tagId",
                table: "PostTag",
                column: "tagId");
        }
    }
}
