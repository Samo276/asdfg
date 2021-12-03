using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terminy.models;
namespace terminy.schematy.brygadowka
{
    public class bryg
    {
        public ShiftList _shiftList { get; set; }
        public Workweek _week { get; set; }
        public List<Group> _employeeGroups { get; set; }
        public bool _rotation { get; set; }
        public bool _overlapping { get; set; }

        public void FetchSampleData(bool rotation, bool overlapping)
        {
            _shiftList = new ShiftList(1,
               new List<Shift> {
               new Shift(1,new TimeSpan(8,0,0),new TimeSpan(8,0,0)),
               new Shift(2, new TimeSpan(14, 0, 0), new TimeSpan(8, 0, 0)),
               new Shift(3, new TimeSpan(22, 0, 0), new TimeSpan(8, 0, 0)),
             });

            _employeeGroups = new List<Group>();
            _employeeGroups.Add(new Group( 1,"A",new List<Employee>(), 6 ,0,1));
            _employeeGroups.Add(new Group(2,"B", new List<Employee>(), 4, 0,2));
            _employeeGroups.Add(new Group(3,"C", new List<Employee>(), 2, 0,3));
            _employeeGroups.Add(new Group(4,"D", new List<Employee>(), 0, 2,3));

            _week = new Workweek(5);

            _rotation = rotation;
            _overlapping = overlapping;
        }

    }
}
