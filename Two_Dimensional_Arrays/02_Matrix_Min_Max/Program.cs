using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Matrix_Min_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix = new int[3, 3];
            int maxDigit = 0;
            int minDigit = 0;
            Console.WriteLine("Matrix 3x3 with random numbers from 1 to 100:\n");
            // Filling the matrix with random numbers and finding min and max
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 101);
                    Console.Write($"{matrix[i, j],3}");
                    if (matrix[i, j] >= maxDigit)
                    {
                        maxDigit = matrix[i, j];
                        minDigit = maxDigit;
                    }
                    else if (matrix[i, j] <= minDigit)
                    {
                        minDigit = matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nMax Digit is: {maxDigit}.\nMin Digit is: {minDigit}");
        }
    }
}
