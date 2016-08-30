using System;

namespace NameApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Get first name
            Console.WriteLine("What is your first name?");
            string firstname = StringCapFirst(Console.ReadLine());

            // Get last name
            Console.WriteLine("What is your last name?");
            string lastname = StringCapFirst(Console.ReadLine());

            Console.WriteLine("Hey " + lastname);

        }

        private static string StringCapFirst(string msg)
        {
            /*
                Capitalizes the first letter of a string, intended for names.
            */

            msg = Char.ToUpper(msg[0]) + msg.Substring(1);

            return msg;
        }
    }
}
