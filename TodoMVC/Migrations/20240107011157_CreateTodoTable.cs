using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoMVC.Migrations
{
    public partial class CreateTodoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "todo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createDate = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local)),
                    isCompleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_todo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "todo");
        }
    }
}
