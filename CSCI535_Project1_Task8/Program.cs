using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace CSCI535_Project1_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
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
}
