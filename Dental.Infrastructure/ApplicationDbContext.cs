using Dental.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}
