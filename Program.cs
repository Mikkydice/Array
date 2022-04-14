using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysofweek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"


            };


            int[] age = { 2, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int num in age)

            Console.WriteLine( num);
            Console.ReadLine();
        }
    }
}
