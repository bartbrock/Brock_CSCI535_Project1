using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI535_Project1_Task6
{
    class Program
    {
        // When accessed by another type, these constants
        // must be referenced via the fully qualified name.
        // Used with Task 6 below.
        public const int myIntConst = 5;
        public const string myStringConst = "I'm a const";

        static void Main(string[] args)
        {
            /********* TASK 6 DEFINING PROGRAM CONSTANTS *************/
            // Scoped constant.
            const string localConst = "I am a rock, I am an island";
            // Use const data.
            Console.WriteLine("myIntConst = {0}\nmyStringConst = {1}", myIntConst, myStringConst);
            Console.WriteLine("Local Constant = {0}", localConst);
            Console.ReadKey();

        }
    }
}
