using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.Entities
{
    public class TimeTable
    {
        public int TimeTableID { get; set; }

        public string Days { get; set; }
        public string Time { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }

    }
}
