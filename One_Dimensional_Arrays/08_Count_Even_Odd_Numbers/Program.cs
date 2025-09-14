using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Count_Even_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int oddCount = 0;
            int evenCount = 0;

            Console.Write("Array: [ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " ");
                if (array[i] % 2 == 0)
                    evenCount++;
                else 
                    oddCount++;
            }
            Console.WriteLine("]");
            Console.WriteLine($"Odd number: {oddCount}");
            Console.WriteLine($"Even numbers: {evenCount}");
        }
    }
}
