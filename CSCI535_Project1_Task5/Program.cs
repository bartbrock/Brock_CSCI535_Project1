using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI535_Project1_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /********* TASK 5 CLASS *************/
            MyClass foo = new MyClass();
            Console.WriteLine("foo.x= {0}, foo.y= {1}, foo.x+foo.y= {2}", foo.x, foo.y, (foo.x + foo.y));
            Console.Write("Please enter x: ");
            foo.x = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter y: ");
            foo.y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("foo.x= {0}, foo.y= {1}, foo.x+foo.y= {2}", foo.x, foo.y, (foo.x + foo.y));
            Console.ReadKey();

        }
    }

    class MyClass
    {
        // Used with Task 5
        public int x, y;

        public MyClass()
        {
            x = 0;
            y = 0;
        }
    }
}
