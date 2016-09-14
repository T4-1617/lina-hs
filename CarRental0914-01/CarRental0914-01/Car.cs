using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental0914_01
{
    class Car
    {
        public string make { get; set; }
        public string RegNO { get; set; }
        public bool hired { get; set; }
        public string group { get; set; }

        public Car()
        {
            make = "unknown";
            RegNO = "unique";
            hired = false;
            group = "unknown";
        }
    }
}
