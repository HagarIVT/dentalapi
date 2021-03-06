// <auto-generated />
using System;
using Dental.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dental.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220411042639_doc")]
    partial class doc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dental.Core.Entities.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAppointment")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorID")
                        .HasColumnType("int");

                    b.HasKey("AppointmentID");

                    b.HasIndex("ClientID");

                    b.HasIndex("DoctorID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Dental.Core.Entities.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Dental.Core.Entities.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorDegree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeTableID")
                        .HasColumnType("int");

                    b.HasKey("DoctorID");

                    b.HasIndex("TimeTableID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Dental.Core.Entities.TimeTable", b =>
                {
                    b.Property<int>("TimeTableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TimeTableID");

                    b.ToTable("TimeTables");
                });

            modelBuilder.Entity("Dental.Core.Entities.Appointment", b =>
                {
                    b.HasOne("Dental.Core.Entities.Client", "Client")
                        .WithMany("Appointment")
                        .HasForeignKey("ClientID");

                    b.HasOne("Dental.Core.Entities.Doctor", "Doctor")
                        .WithMany("Appointment")
                        .HasForeignKey("DoctorID");

                    b.Navigation("Client");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Dental.Core.Entities.Doctor", b =>
                {
                    b.HasOne("Dental.Core.Entities.TimeTable", "TimeTable")
                        .WithMany("Doctors")
                        .HasForeignKey("TimeTableID");

                    b.Navigation("TimeTable");
                });

            modelBuilder.Entity("Dental.Core.Entities.Client", b =>
                {
                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("Dental.Core.Entities.Doctor", b =>
                {
                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("Dental.Core.Entities.TimeTable", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
