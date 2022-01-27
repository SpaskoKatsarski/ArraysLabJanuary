using System;
using System.Linq;

namespace T05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = Console.ReadLine().Split().Select(int.Parse).Where(evens => evens % 2 == 0).Sum();
            Console.WriteLine(numbers);
        }
    }
}
