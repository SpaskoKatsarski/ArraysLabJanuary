using System;
using System.Linq;

namespace T01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(Math.Round(item));
            //}

            int input = int.Parse(Console.ReadLine());

            string[] daysOfTheWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (input != 1 && input != 2 && input != 3 && input != 4 && input != 5 && input != 6 && input != 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfTheWeek[input - 1]);
            }
        }
    }
}
