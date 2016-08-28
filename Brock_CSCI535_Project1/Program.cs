using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace Brock_CSCI535_Project1
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
            /*****  TASK 3 BASIC INPUT AND OUTPU *****/
            //int theInt = 90;
            //float theFloat = 9.99F;
            //string myname = "Bart Brock";
            //// Format a string...
            //Console.WriteLine("Int is: {0}\nFloat is: {1}\nYou are: {2}", theInt, theFloat, myname);
            //Console.ReadLine();
            //-------------------
            //string nameString;
            //string ageString;
            //Console.Write("Enter your name: ");
            //nameString = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //ageString = Console.ReadLine();
            //Console.WriteLine("Hello, {0}! You are {1} years old.", nameString, ageString);
            //Console.WriteLine("\n\n\n");
            //Console.ReadKey();

            /********* TASK 4 STRUCTURES *************/
            //MyStruct foo = new MyStruct();
            //Console.Write("Please enter x: ");
            //foo.x = Int32.Parse(Console.ReadLine());
            //Console.Write("Please enter y: ");
            //foo.y = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("X= {0}, Y= {1}, X+Y= {2}", foo.x, foo.y, (foo.x + foo.y));
            //Console.ReadKey();

            /********* TASK 5 CLASS *************/
            //MyClass foo = new MyClass();
            //Console.WriteLine("foo.x= {0}, foo.y= {1}, foo.x+foo.y= {2}", foo.x, foo.y, (foo.x + foo.y));
            //Console.Write("Please enter x: ");
            //foo.x = Int32.Parse(Console.ReadLine());
            //Console.Write("Please enter y: ");
            //foo.y = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("foo.x= {0}, foo.y= {1}, foo.x+foo.y= {2}", foo.x, foo.y, (foo.x + foo.y));
            //Console.ReadKey();

            /********* TASK 6 DEFINING PROGRAM CONSTANTS *************/
            //// Scoped constant.
            //const string localConst = "I am a rock, I am an island";
            //// Use const data.
            //Console.WriteLine("myIntConst = {0}\nmyStringConst = {1}", myIntConst, myStringConst);
            //Console.WriteLine("Local Constant = {0}", localConst);
            //Console.ReadKey();

            /********* TASK 7 ITERATION CONSTRUCTS *************/
            //int n = 0;
            //int sum = 0;
            //Console.WriteLine("number= {0}, sum= {1}", n, sum);
            //Console.Write("Please enter a number: ");
            //n = Int32.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("sum= {0}\n", sum);
            //Console.ReadKey();
            //----------------------------------------
            //int[] MyCollection = { 1, 3, 2, 7, 5, 3, 7, 8, 9 };
            //foreach (int i in MyCollection)
            //{
            //    if (i == 3)
            //        Console.WriteLine("Found 3!");
            //}
            //Console.ReadKey();

            /********* TASK 8 *************/
            int webIndexBase = 0;
            int webIndexStart = 0;
            int webIndexOffset = 0;
            string tempString, condString;
            string baseSearchString = "Currently";
            string condSearchString = "class=\"cond\">";
            string tempSearchString = "class=\"temp\">";

            WebClient myWebClient = new WebClient();
            myWebClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            string webString = myWebClient.DownloadString("http://www.accuweather.com/en/us/charleston-sc/29401/weather-forecast/330678");
            webIndexBase = webString.IndexOf(baseSearchString);

            Console.WriteLine("Press any key to display weather conditon and temperature");
            Console.ReadKey(); Console.WriteLine();

            // Local Weather Condition
            webIndexStart = webString.IndexOf(condSearchString, webIndexBase) + condSearchString.Length;
            webIndexOffset = webString.IndexOf("<", webIndexStart) - webIndexStart;
            condString = webString.Substring(webIndexStart, webIndexOffset);
            Console.WriteLine(condString);

            //// Local weather temperature
            webIndexStart = webString.IndexOf(tempSearchString) + tempSearchString.Length;
            webIndexOffset = webString.IndexOf("<", webIndexStart) - webIndexStart;
            tempString = webString.Substring(webIndexStart, webIndexOffset);
            Console.WriteLine("{0} Degrees", tempString);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }

    struct MyStruct
    {
        // Used with Task 4
        public int x;
        public int y;
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
