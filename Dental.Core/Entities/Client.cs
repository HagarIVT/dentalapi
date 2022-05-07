using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.Entities
{
    public class Client
    {
        public int ClientID { get; set; }

        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }

        public ICollection<Appointment>? Appointment { get; set; }

    }
}
