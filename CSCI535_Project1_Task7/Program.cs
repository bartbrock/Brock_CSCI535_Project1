using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI535_Project1_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /********* TASK 7 ITERATION CONSTRUCTS *************/
            //----------Part 1------------------------------
            int n = 0;
            int sum = 0;
            Console.WriteLine("number= {0}, sum= {1}", n, sum);
            Console.Write("Please enter a number: ");
            n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("sum= {0}\n", sum);
            Console.ReadKey();
            
            //----------Part 2------------------------------
            int[] MyCollection = { 1, 3, 2, 7, 5, 3, 7, 8, 9 };
            foreach (int i in MyCollection)
            {
                if (i == 3)
                    Console.WriteLine("Found 3!");
            }
            Console.ReadKey();
        }
    }
}
