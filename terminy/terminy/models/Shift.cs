using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminy.models
{
    public class Shift
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan ShiftLength { get; set; }

        public Shift(int id, TimeSpan startTime, TimeSpan shiftLength)
        {
            Id = id;
            StartTime = startTime;
            this.ShiftLength = shiftLength;
        }
    }
}
