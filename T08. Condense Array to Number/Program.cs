using System;
using System.Linq;

namespace T08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startingArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] condensedArr = new int[startingArr.Length - 1];

            int originalLength = startingArr.Length;

            // 1 2 3 4 
            // 3 3 4
            // 6 4
            // 10

            if (startingArr.Length == 1)
            {
                Console.WriteLine(startingArr[0]);
                return;
            }

            for (int i = 0; i < originalLength - 1; i++)
            {

                for (int j = 0; j < startingArr.Length - 1; j++)
                {
                    condensedArr[j] = startingArr[j] + startingArr[j + 1];
                }

                startingArr = condensedArr;
            }

            Console.WriteLine(condensedArr[0]);
        }
    }
}
