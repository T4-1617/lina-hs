using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0912_02
{
    class Customer
    {
        /// <summary>
        /// Contains the first name of the customer (string)
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Contains the last name of the customer (string)
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Contains the customer id (integer)
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Contains a value indicating the active state of the customer (bool)
        /// </summary>
        public int Active { get; set; }
    }
}
