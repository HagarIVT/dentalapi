using Dental.Contract;
using Dental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.Repositories
{
    public interface IDoctorRepo
    {
        Task<List<Doctor>> GetAllDoctors();
        Task<Doctor> GetDoctorByID(int id);
        Task<string> AddDoctor(DoctorDTO DoctorDTO);


    }
}
