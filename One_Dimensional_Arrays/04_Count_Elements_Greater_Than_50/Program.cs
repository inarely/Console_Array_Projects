using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Count_Elements_Greater_Than_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[12];
            int count = 0;
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(40, 61);
                Console.Write(array[i] + " ");
                if (array[i] > 50)
                {
                    count++;
                }
            }
            Console.WriteLine("]");
            Console.WriteLine($"There is \"{count}\" elements greater than 50.");
        }
    }
}
