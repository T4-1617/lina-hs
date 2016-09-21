using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMLibrary
{
    public class Customer : Person
    {
        public int ID { get; set; }

        public Customer(int ID)
        {
            this.ID = ID;
        }
    }
}
