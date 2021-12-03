using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminy.models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }

        public Employee(int id, string employeeId, string name)
        {
            Id = id;
            EmployeeId = employeeId;
            Name = name;
        }
    }
}
