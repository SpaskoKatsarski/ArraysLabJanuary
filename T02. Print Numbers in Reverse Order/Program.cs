using System;
using System.Linq;

namespace T02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numbers = int.Parse(Console.ReadLine());
            //int[] items = new int[numbers];

            //for (int i = 0; i < items.Length; i++)
            //{
            //    items[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(items);

            //Console.WriteLine(String.Join(" ", items));

            int arr = Console.ReadLine().Split().Select(int.Parse).Where(number => number % 2 == 0).Sum();
            Console.WriteLine(arr);
        }
    }
}
