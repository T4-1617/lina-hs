using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental0914_01
{

    class Car
    {
        // Car properties
        public string make { get; set; }
        public string RegNO { get; set; }
        public bool hired { get; set; }
        public string group { get; set; }

        // Initialization
        public Car()
        {
            make = "unknown";
            RegNO = "unique";
            hired = false;
            group = "unknown";
        }
    }

}
