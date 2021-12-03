using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminy.schematy.delegat
{
    public class DeleModel
    {
        public int Id { get; set; }
        public string EmployeeID { get; set; }
        public string Facility_id { get; set; }
        public DateTime DelgationTime { get; set; }
        public TimeSpan DelegationDuration { get; set; }
        public bool Should_RepeatOnInterval { get; set; }
        public bool Should_ReapeatOnday { get; set; }
        public bool Should_RepeatNumberOfTimes { get; set; }
        public TimeSpan RepeatOnInterval { get; set; }
        public DateTime ReapeatOnday { get; set; }
        public int RepeatNumberOfTimes { get; set; }

    }
}
