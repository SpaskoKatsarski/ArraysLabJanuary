using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] testArr;

            //testArr = new int[3];

            //for (int i = 0; i < testArr.Length; i++)
            //{
            //    testArr[i] = int.Parse(Console.ReadLine());
            //}

            //testArr = new int[5];

            //testArr[3] = 10;
            //testArr[4] = 12310;

            //Console.WriteLine(String.Join(" ", testArr));

            //string[] days =
            //{      
            //    "Monday",
            //    "Tuesday",
            //    "Saturday"
            //};

            //Console.WriteLine(days.Length);

            int[] testArray = new int[3];
            testArray[2] = 1;

            int[] anotherTestArray = new int[5];
            anotherTestArray[2] = 3;

            testArray = anotherTestArray;

            testArray[4] = 3;

            Console.WriteLine(String.Join(" ", testArray));
        }
    }
}
