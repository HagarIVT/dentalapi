using Microsoft.EntityFrameworkCore.Migrations;

namespace Dental.Infrastructure.Migrations
{
    public partial class doc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Days",
                table: "TimeTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "TimeTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Days",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Doctors");
        }
    }
}
