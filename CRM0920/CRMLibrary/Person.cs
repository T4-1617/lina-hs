using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMLibrary
{
    public class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string phoneNumber { get; set; }

        public Person()
        {
            // Default values
            this.fName = string.Empty;
            this.lName = string.Empty;
            this.phoneNumber = string.Empty;
        }

        public string GetFullName()
        {
            return string.Format("{0} {1}", fName, lName);
        }

        public override string ToString()
        {
            // Return the full name if person has name
            bool personHasNames = (fName != string.Empty && lName != string.Empty);
            if (personHasNames)
            {
                return GetFullName();
            }

            // Return that it is a person
            return base.ToString();
        }
    }
}
