using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Row_Col_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix = new int[3, 3];
            int rowSum = 0;
            int colSum = 0;
            Console.WriteLine("Matrix:");
            // Fill the matrix with random values and calculate row sum
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                    Console.Write($"{matrix[i, j],3}");
                   
                }
                Console.WriteLine();              
            }
            Console.WriteLine();

            // Calculate row sum
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }                
                Console.WriteLine($"Sum of Row {i + 1}: {rowSum}");
            }
            Console.WriteLine();

            // Calculate column sum
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {                                       
                    colSum += matrix[i, j];
                }                
                Console.WriteLine($"Sum of Column {j + 1}: {colSum}");
            }
        }
    }
}
