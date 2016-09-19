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
        public bool rented { get; set; }
        public string customer { get; set; }

        public Car()
        {
            this.make = string.Empty;
            this.model = string.Empty;
            this.color = string.Empty;
            this.customer = string.Empty;
            this.rented = false;
        }

        public override string ToString()
        {
            // Returns the car make and model

            if (customer != string.Empty)
            {
                // If the car has a customer, return said customer with the rest
                return string.Format("{0} {1} hired by {2}", make, model, customer);
            }

            return string.Format("{0} {1}", make, model);
        }

    }
}
