using Microsoft.EntityFrameworkCore.Migrations;

namespace Dental.Infrastructure.Migrations
{
    public partial class testDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorDegree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
