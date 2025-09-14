using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Replace_Negative_Number_with_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[8];

            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine("Negative numbers Replaced with \"0\"");
            Console.WriteLine();
            Console.Write("New array: [ ");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) array[i] = 0;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}
