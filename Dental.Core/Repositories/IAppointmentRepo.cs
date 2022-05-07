using Dental.Contract;
using Dental.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.Repositories
{
    public interface IAppointmentRepo
    {
        Task<string> CreateAppointment(ClientAppointmentDTO ClientAppointmentDTO);
        Task<IList<AppointmentDoctorClientDTO>> GetAllAppointment();


    }
}
