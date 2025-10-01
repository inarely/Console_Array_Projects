using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Diagonal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } 
            };
            int diagonalSum = 0;
            int secondaryDiagonalSum = 0;
            // Print the matrix
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Sum the diagonal elements
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               diagonalSum += matrix[i, i];
            }
            Console.WriteLine("Sum of diagonal elements: " + diagonalSum);

            // Sum the secondary diagonal elements
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondaryDiagonalSum += matrix[i, matrix.GetLength(0) - 1 - i];
            }
            Console.WriteLine("Sum of secondary diagonal elements: " + secondaryDiagonalSum);
        }
    }
}
