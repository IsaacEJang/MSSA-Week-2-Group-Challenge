using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Challenge
{
    internal class Program
    {
        static int BiggestNumber(int[] arr)
        {
            int max = arr[0];
            int maxInt = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxInt = i;
                }

            }
            return maxInt;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Input 10 numbers and I will tell you the max\n");


            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nThe max is {arr[BiggestNumber(arr)]} found at {BiggestNumber(arr) + 1}");

            Console.ReadKey();
        }

    }
}
