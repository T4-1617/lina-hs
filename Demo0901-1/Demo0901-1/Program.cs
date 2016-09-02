using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0901_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get full name
            string fullname = GetName();
            // Print name length
            Console.WriteLine(GetStringCharacterNum(fullname));
            Console.WriteLine(GetStringCharacterNumWithoutSpaces(fullname));

            // Get first and last name
            string firstname = GetFirstName(fullname);
            string lastname = GetLastName(fullname);
            // Print names
            Console.WriteLine(
                string.Format(
                    "Your first name is {0} which consists of {1} characters.",
                    firstname,
                    firstname.Length));
            Console.WriteLine(
                string.Format(
                    "Your last name is {0} which consists of {1} characters.",
                    lastname,
                    lastname.Length));
            Console.WriteLine(
                string.Format(
                    "{0}, {1}",
                    lastname,
                    firstname));
            PrintStringCharEachLine(StringToUppercase(firstname));
            PrintStringCharEachLine(StringToUppercase(lastname));
            string nameReverseLower = ReverseString(StringToLowercase(fullname));
            Console.WriteLine(nameReverseLower);
            Console.WriteLine(EveryOtherUpperLower(fullname));
            Console.WriteLine(StringToLeetSpeech(fullname));




        }

        private static string GetName()
        {
            // Reads a name from the user
            Console.WriteLine("Enter your full name.");
            string name = Console.ReadLine();

            return name;
        }
        private static int GetStringCharacterNum(string s)
        {
            // Get the numerical length of a string
            return s.Length;
        }
        private static int GetStringCharacterNumWithoutSpaces(string s)
        {
            // Get number of characters in a string with all spaces removed
            while (true)
            {
                int index = s.IndexOf(" ");
                if (index != -1)
                {
                    s = s.Remove(index, 1);
                }
                else
                {
                    return s.Length;
                }
            }
        }
        private static string GetFirstName(string s)
        {
            // Get the first name
            int index = s.IndexOf(" ");
            s = s.Substring(0, index);
            return s;
        }
        private static string GetLastName(string s)
        {
            // Get the last name
            int index = s.IndexOf(" ");
            s = s.Substring(index + 1);
            return s;
        }
        private static string StringToLowercase(string s)
        {
            // Makes all characters in a string to lowercase characters
            char[] cA = s.ToCharArray();

            for (int i = 0; i < cA.Count(); i++)
            {
                if (char.IsLetter(cA[i]))
                {
                    cA[i] = char.ToLower(cA[i]);
                }
            }

            return new string(cA);
        }
        private static string StringToUppercase(string s)
        {
            // Makes all characters of a string to uppercase
            char[] cA = s.ToCharArray();

            for (int i = 0; i < cA.Count(); i++)
            {
                if (char.IsLetter(cA[i]))
                {
                    cA[i] = char.ToUpper(cA[i]);
                }
            }

            return new string(cA);
        }
        private static void PrintStringCharEachLine(string s)
        {
            // Prints each character of a string on a separate line
            foreach (char c in s)
            {
                Console.WriteLine(c.ToString());
            }
        }
        private static string ReverseString(string s)
        {
            // Reverses the string
            char[] reverse = s.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
        private static string EveryOtherUpperLower(string s)
        {
            // Every other character in the string is made uppercase or lowercase
            char[] cA = s.ToCharArray();

            for (int i = 0; i < cA.Count(); i++)
            {
                if (char.IsLetter(s[i]))
                {
                    switch (i % 2)
                    {
                        case 0:
                            cA[i] = char.ToUpper(cA[i]);
                            break;
                        case 1:
                            cA[i] = char.ToLower(cA[i]);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new string(cA);
        }
        private static string StringToLeetSpeech(string s)
        {
            // Turns a string to leet speech
            char[] cA = s.ToCharArray();

            for (int i = 0; i < cA.Count(); i++)
            {
                char tempChar = cA[i];
                if (char.IsLetter(cA[i]))
                {
                    tempChar = char.ToUpper(cA[i]);
                }
                switch (tempChar)
                {
                    case 'A':
                        cA[i] = '4';
                        break;
                    case 'E':
                        cA[i] = '3';
                        break;
                    case 'I':
                        cA[i] = '1';
                        break;
                    case 'T':
                        cA[i] = 'T';
                        break;
                    default:
                        break;
                }
            }

            return new string(cA);
        }

    }
}
