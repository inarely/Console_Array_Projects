using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Transpose_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int[,] transposed = new int[3, 3];

            Console.WriteLine("Matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    transposed[j, i] = matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nTransposed: ");
            for (int i = 0; i < transposed.GetLength(0); i++)
            {
                for (int j = 0; j < transposed.GetLength(1); j++)
                {
                    Console.Write(transposed[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
