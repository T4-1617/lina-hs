using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMLibrary
{
    public class Employee : Person
    {
        public int employeeNumber { get; set; }
        public string title { get; set; }
        public int salary { get; set; }

        public Employee()
        {
            // ?
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", GetFullName(), title);
        }
    }
}
