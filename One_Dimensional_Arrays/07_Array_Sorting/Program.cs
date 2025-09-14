using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Array_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];

            // Filling the array with random values.
            Console.Write("Array: [ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                    int value = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = value;
                    }
                }
            }
         
            // Sorted array
            Console.Write("\nSorted Array: [ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}
