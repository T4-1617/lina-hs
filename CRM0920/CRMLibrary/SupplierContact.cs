using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMLibrary
{
    class SupplierContact : Person
    {
        public string company { get; set; }

        public SupplierContact(string company)
        {
            this.company = company;
        }
    }
}
