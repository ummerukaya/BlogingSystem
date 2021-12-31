using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloginSystem.Migrations
{
    public partial class BlogingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Authorname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "blogPosts",
                columns: new[] { "Id", "Authorname", "BlogBody", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, "Suny", "abcdefg", new DateTime(2021, 12, 28, 19, 2, 21, 79, DateTimeKind.Local).AddTicks(2634), "Blog post title" },
                    { 2, "Suny", "abcdefg", new DateTime(2021, 12, 28, 19, 2, 21, 80, DateTimeKind.Local).AddTicks(3050), "Blog post title" },
                    { 3, "Suny", "abcdefg", new DateTime(2021, 12, 28, 19, 2, 21, 80, DateTimeKind.Local).AddTicks(3071), "Blog post title" },
                    { 4, "Suny", "abcdefg", new DateTime(2021, 12, 28, 19, 2, 21, 80, DateTimeKind.Local).AddTicks(3075), "Blog post title" },
                    { 5, "Suny", "abcdefg", new DateTime(2021, 12, 28, 19, 2, 21, 80, DateTimeKind.Local).AddTicks(3076), "Blog post title" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogPosts");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
