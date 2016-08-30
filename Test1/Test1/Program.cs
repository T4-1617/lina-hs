using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Console.ReadLine();
        }

        private static int ReadNum() {
            int num;

            while (true)
            {
                Console.WriteLine("Enter a number.");
                string line = Console.ReadLine();

                if (int.TryParse(line, out num))
                {
                    break;
                }
            }

            return num;
        }
    }
}