using Enums.Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assigning an enum to a variable:
            Season seasonSpring = Season.Spring;

            //Get the enum as a string:
            string autumn = Season.Autumn.ToString();
            Console.WriteLine(autumn);

            // or

            Console.WriteLine(seasonSpring);
            Console.WriteLine(Season.Summer);

            //The following will NOT work tho:
            //string summer = Season.Summer;

            Console.WriteLine();

            //Get the enum as an integer:
            int summerCode = (int)Season.Summer; // 1
            Console.WriteLine(summerCode);

            Console.WriteLine();

            //Get an integer as an enum:
            int winterCode = 3;
            Season seasonWinter = (Season)winterCode; //or (Season)3
            Console.WriteLine(seasonWinter);

            Console.ReadKey();
        }
    }
}
