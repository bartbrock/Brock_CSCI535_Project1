using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI535_Project1_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /********* TASK 4 STRUCTURES *************/
            MyStruct foo = new MyStruct();
            Console.Write("Please enter x: ");
            foo.x = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter y: ");
            foo.y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("X= {0}, Y= {1}, X+Y= {2}", foo.x, foo.y, (foo.x + foo.y));
            Console.ReadKey();
        }
    }

    struct MyStruct
    {
        // Used with Task 4
        public int x;
        public int y;
    }

}
