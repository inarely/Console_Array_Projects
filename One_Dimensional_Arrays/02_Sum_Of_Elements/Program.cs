using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sum_Of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int sum = 0;

            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " ");
                sum += array[i];
            }
            Console.Write("]");
            Console.WriteLine();

            Console.WriteLine($"The sum of elements is: {sum}");
        }
    }
}
