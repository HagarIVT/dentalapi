using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.Entities
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorPhone { get; set; }
        public string DoctorDegree { get; set; }
        public string DoctorExperience { get; set; }
        public string DoctorDescription { get; set; }
        public string Department { get; set; }

         
        public ICollection<Appointment>? Appointment { get; set; }


        [ForeignKey("TimeTableID")]
        public int? TimeTableID { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}
