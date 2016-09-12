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
        public bool Active { get; set; }

        // Instantiate the customer with its default values
        public Customer()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Active = true;
        }
        public Customer(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Active = true;
        }

        /// <summary>
        /// Get the customer's first and last name combined into a full name
        /// </summary>
        /// <returns>Return a string referencing the full name of the customer</returns>
        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}