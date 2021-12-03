using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminy.models
{
    public class Match
    {
        public int shiftID { get; set; }
        public int groupID { get; set; }
        public DateTime ShiftTime { get; set; }

        public Match(int shiftID, int groupID, DateTime shiftTime)
        {
            this.shiftID = shiftID;
            this.groupID = groupID;
            ShiftTime = shiftTime;
        }
    }
}
