using Dental.Contract;
using Dental.Contract.DTO;
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
    public class AppointmentRepo : IAppointmentRepo
    {

        protected readonly ApplicationDbContext _applicationDbContext;

        public AppointmentRepo(ApplicationDbContext applicationDbContext)

        {
            _applicationDbContext = applicationDbContext;

        }
        public async Task<string> CreateAppointment(ClientAppointmentDTO ClientAppointmentDTO)
        {

            var client = new Client()
            {
                ClientEmail = ClientAppointmentDTO.ClientEmail,
                ClientName = ClientAppointmentDTO.ClientName,
                ClientPhone = ClientAppointmentDTO.ClientPhone,
                
            };
            await _applicationDbContext.Clients.AddAsync(client);
            await _applicationDbContext.SaveChangesAsync();
            var data = new Appointment()
            {
                ClientID=client.ClientID,
                DoctorID=ClientAppointmentDTO.DoctorID,
                DateAppointment=ClientAppointmentDTO.DateAppointment,


            };
            await _applicationDbContext.Appointments.AddAsync(data);
            await _applicationDbContext.SaveChangesAsync();
            return "DONE";
        }

        public async Task<IList<AppointmentDoctorClientDTO>> GetAllAppointment()
        {
            var Appointments = await _applicationDbContext.Appointments.ToListAsync();

            IList<AppointmentDoctorClientDTO> AppointmentDoctorClientDTOList = new List<AppointmentDoctorClientDTO>();

            foreach (var App in Appointments) {
                var client = await _applicationDbContext.Clients.FindAsync(App.ClientID);
                var doctor = await _applicationDbContext.Doctors.FindAsync(App.DoctorID);
                var AppointmentDoctorClientDTO = new AppointmentDoctorClientDTO()
                {
                    DateAppointment = App.DateAppointment,
                    DoctorName=doctor.DoctorName,
                    ClientEmail=client.ClientEmail,
                    ClientName=client.ClientName,
                    ClientPhone=client.ClientPhone,
                };

                AppointmentDoctorClientDTOList.Add(AppointmentDoctorClientDTO);
            }
            return AppointmentDoctorClientDTOList;
        }
    }
}
