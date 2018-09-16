using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayName = true;
            while (displayName)
            {
                displayName = FullName();
            }
        }

        private static bool FullName()
        {

            Console.WriteLine("What is your first name?");
            Console.Write("Type name here:");
            string firstName;
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            Console.Write("Type name here:");
            string lastName;
            lastName = Console.ReadLine();

            Console.WriteLine("Choose how to display name:");
            Console.WriteLine("1) First Last");
            Console.WriteLine("2) Last First");
            string result = Console.ReadLine();
            if (result == "1")
            {
                
                Console.WriteLine("Hello, " + FullName1(firstName, lastName));
                Console.ReadLine();
                return true;




            }
            else if (result == "2")
            {
               
                Console.WriteLine("Hello," + FullName2(lastName, firstName));

                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }

        }



        private static string FullName2(string firstName, string lastName)

        {
            string lastFirst = lastName + firstName;
            return lastFirst;





        }
        private static string FullName1(string firstName, string lastName)
        {
            string firstLast = firstName + lastName;
            return firstLast;

        }
    }



}
