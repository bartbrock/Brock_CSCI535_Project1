using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI535_Project1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*****  TASK 3 BASIC INPUT AND OUTPUT *****/
            // -----Part 1--------------
            int theInt = 90;
            float theFloat = 9.99F;
            string myname = "Bart Brock";
            // Format a string...
            Console.WriteLine("Int is: {0}\nFloat is: {1}\nYou are: {2}", theInt, theFloat, myname);
            Console.ReadLine();
            
            // -----Part 2--------------
            string nameString;
            string ageString;
            Console.Write("Enter your name: ");
            nameString = Console.ReadLine();
            Console.Write("Enter your age: ");
            ageString = Console.ReadLine();
            Console.WriteLine("Hello, {0}! You are {1} years old.", nameString, ageString);
            Console.WriteLine("\n\n\n");
            Console.ReadKey();

        }
    }
}
