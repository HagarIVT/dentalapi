using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Contract.DTO
{
    public class AppoinmentDTO
    {
        public int ClientID { get; set; }

        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public DateTime DateAppointment { get; set; }

    }
}
