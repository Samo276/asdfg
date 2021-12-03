using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminy.models
{
    public class ShiftList
    {
        public int Id { get; set; }
        public List<Shift> Shifts { get; set; }
        public ShiftList(int id, List<Shift> shifts)
        {
            Id = id;
            Shifts = shifts;
        }
    }
}
