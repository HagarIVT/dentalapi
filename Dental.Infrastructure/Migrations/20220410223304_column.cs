using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dental.Infrastructure.Migrations
{
    public partial class column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Appointments_AppointmentID",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Appointments_AppointmentID",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_AppointmentID",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AppointmentID",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AppointmentID",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AppointmentID",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "ClientEmail",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientPhone",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAppointment",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClientID",
                table: "Appointments",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorID",
                table: "Appointments",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Clients_ClientID",
                table: "Appointments",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorID",
                table: "Appointments",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clients_ClientID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorID",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ClientID",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorID",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ClientEmail",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientPhone",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DateAppointment",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentID",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentID",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AppointmentID",
                table: "Doctors",
                column: "AppointmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AppointmentID",
                table: "Clients",
                column: "AppointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Appointments_AppointmentID",
                table: "Clients",
                column: "AppointmentID",
                principalTable: "Appointments",
                principalColumn: "AppointmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Appointments_AppointmentID",
                table: "Doctors",
                column: "AppointmentID",
                principalTable: "Appointments",
                principalColumn: "AppointmentID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
