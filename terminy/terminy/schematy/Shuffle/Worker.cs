using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terminy.models;

namespace terminy.schematy.Shuffle
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int workdays { get; set; }
        public double workload { get; set; }
        public TimeSpan lastShiftEnd { get; set; }

        public Worker(int id, String name)
        {
            Id = id;
            Name = name;
            this.workload = workload;
            this.lastShiftEnd = lastShiftEnd;
        }
    }
}
