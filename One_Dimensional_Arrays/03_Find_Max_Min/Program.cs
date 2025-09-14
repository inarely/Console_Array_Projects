using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Find_Max_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int max = 0, min = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

                if (max < array[i]) max = array[i];
                if (min > array[i]) min = array[i];
                if (array[i] == 0)  min = 0;
            }
            Console.WriteLine($"Max: {max} \nMin: {min}");
        }
    }
}
