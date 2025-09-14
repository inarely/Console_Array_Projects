using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Array_Input_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of Array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the value number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Your array is: [ ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("]");
        }
    }
}
