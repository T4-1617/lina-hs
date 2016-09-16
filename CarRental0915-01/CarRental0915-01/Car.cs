using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental0915_01
{
    class Car
    {

        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public bool forRent { get; set; }

        public Car()
        {
            this.make = string.Empty;
            this.model = string.Empty;
            this.color = string.Empty;
            this.forRent = false;
        }

    }
}
