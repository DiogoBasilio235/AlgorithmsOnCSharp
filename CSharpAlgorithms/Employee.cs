using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Department { get; set; }

        public Employee(string name, int id, string department) {
            this.Name = name;
            this.Id = id;
            this.Department = department;
        }

    }
}
