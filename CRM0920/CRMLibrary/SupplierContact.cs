using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMLibrary
{
    public class SupplierContact : Person
    {
        public string company { get; set; }

        public SupplierContact(string company)
        {
            this.company = company;
        }

        public override string ToString()
        {
            return string.Format("{0} from {1}", GetFullName(), company);
        }
    }
}
