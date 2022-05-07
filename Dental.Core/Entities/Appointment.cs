using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.Entities
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime DateAppointment { get; set; }

        [ForeignKey("DoctorID")]
        public int? DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        
        [ForeignKey("ClientID")]
        public int? ClientID { get; set; }
        public Client Client { get; set; }
 

    }
}
