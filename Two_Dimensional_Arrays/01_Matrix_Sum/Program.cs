using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Matrix_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sum = 0;
            int[,] matrix = new int[3, 3];

            // Array Initialization and Print
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 11);
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }

            // Sum Calculation
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine($"\nSum of the elements is: {sum}");
        }
    }
}
