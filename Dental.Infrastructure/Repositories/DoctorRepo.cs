using Dental.Contract;
using Dental.Core.Entities;
using Dental.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Infrastructure.Repositories
{
    public class DoctorRepo : IDoctorRepo
    {
        protected readonly ApplicationDbContext _applicationDbContext;

        public DoctorRepo(ApplicationDbContext applicationDbContext)

        {
            _applicationDbContext = applicationDbContext;

        }

        public async Task<string> AddDoctor(DoctorDTO DoctorDTO)
        {
            
            var data = new Doctor()
            {
              
                DoctorEmail= DoctorDTO.DoctorEmail,
                DoctorName= DoctorDTO.DoctorName,
                DoctorDegree= DoctorDTO.DoctorDegree,
                DoctorDescription= DoctorDTO.DoctorDescription,
                DoctorExperience = DoctorDTO.DoctorExperience,
                DoctorPhone= DoctorDTO.DoctorPhone,
                

            };
            await _applicationDbContext.Doctors.AddAsync(data);
            await _applicationDbContext.SaveChangesAsync();
            return "DONE";
        }

        public async Task<List<Doctor>> GetAllDoctors()
        {
            var Doctors = await _applicationDbContext.Doctors.ToListAsync(); 

            return Doctors;
        }

        public async Task<Doctor> GetDoctorByID(int id)
        {
            var Doctors = await _applicationDbContext.Doctors.FindAsync(id);

            return Doctors;
        }
 
    }
}
