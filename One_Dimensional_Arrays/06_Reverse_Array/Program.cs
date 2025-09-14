using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Console.Write("Array: [ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("] ");

            Console.Write("Reversed: [ ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}
