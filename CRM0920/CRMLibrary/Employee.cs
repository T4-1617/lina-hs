using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMLibrary
{
    class Employee : Person
    {
        public int employeeNumber { get; set; }
        public string title { get; set; }
        public int salary { get; set; }

        public Employee()
        {
            // ?
        }
    }
}
