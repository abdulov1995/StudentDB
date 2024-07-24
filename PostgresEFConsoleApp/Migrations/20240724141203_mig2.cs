using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDB.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Teachers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
