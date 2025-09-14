using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sum_On_Even_Odd_Positions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int sumEven = 0, sumOdd = 0;
            Console.Write("Array: [ ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " ");
                if (i % 2 == 0)
                    sumOdd += array[i];
                else
                    sumEven += array[i];
            }
            Console.WriteLine("]");
            Console.WriteLine($"\nOdd elements sum: {sumOdd}");
            Console.WriteLine($"Even elements sum: {sumEven}");
        }
    }
}
