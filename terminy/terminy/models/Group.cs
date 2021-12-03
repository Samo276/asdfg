using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminy.models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Employee> GroupMembers { get; set; }
        public int worktime { get; set; }
        public int freetime { get; set; }
        public int lastshiftId { get; set; }
        public Group(int id, string name, List<Employee> groupMembers)
        {
            Id = id;
            Name = name;
            GroupMembers = groupMembers;
            worktime = 0;
            freetime = 0;
        }

        public Group(int id, string name, List<Employee> groupMembers, int worktime, int freetime) : this(id, name, groupMembers)
        {
            this.worktime = worktime;
            this.freetime = freetime;
        }

        public Group(int id, string name, List<Employee> groupMembers, int worktime, int freetime, int lastshiftId) : this(id, name, groupMembers, worktime, freetime)
        {
            this.lastshiftId = lastshiftId;
        }
    }
}
