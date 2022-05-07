using Microsoft.EntityFrameworkCore.Migrations;

namespace Dental.Infrastructure.Migrations
{
    public partial class tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentID",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeTableID",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                });

            migrationBuilder.CreateTable(
                name: "TimeTables",
                columns: table => new
                {
                    TimeTableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTables", x => x.TimeTableID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Clients_Appointments_AppointmentID",
                        column: x => x.AppointmentID,
                        principalTable: "Appointments",
                        principalColumn: "AppointmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AppointmentID",
                table: "Doctors",
                column: "AppointmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_TimeTableID",
                table: "Doctors",
                column: "TimeTableID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AppointmentID",
                table: "Clients",
                column: "AppointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Appointments_AppointmentID",
                table: "Doctors",
                column: "AppointmentID",
                principalTable: "Appointments",
                principalColumn: "AppointmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_TimeTables_TimeTableID",
                table: "Doctors",
                column: "TimeTableID",
                principalTable: "TimeTables",
                principalColumn: "TimeTableID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Appointments_AppointmentID",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_TimeTables_TimeTableID",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "TimeTables");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_AppointmentID",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_TimeTableID",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AppointmentID",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "TimeTableID",
                table: "Doctors");
        }
    }
}
