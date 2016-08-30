using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Get first name
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            // Get last name
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("Hey " + firstname + " " + lastname);


        }
    }
}
