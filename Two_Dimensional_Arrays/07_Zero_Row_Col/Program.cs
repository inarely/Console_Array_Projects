using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Zero_Row_Col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                { 1, 0, 3 },
                { 4, 5, 6 },
                { 0, 8, 9 },
            };

            // Print initial matrix
            int count = 0;
            foreach (int x in matrix)
            {
                Console.Write(x + " ");
                count++;
                if (count % matrix.GetLength(1) == 0) 
                    Console.WriteLine();
            }
            Console.WriteLine();

            // 1) Find zeros and mark their rows/columns as int.MinValue
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        // Mark entire row
                        for (int k = 0; k < matrix.GetLength(1); k++)
                            if (matrix[i, k] != 0) matrix[i, k] = int.MinValue;

                        // Mark entire column
                        for (int k = 0; k < matrix.GetLength(0); k++)
                            if (matrix[k, j] != 0) matrix[k, j] = int.MinValue;
                    }
                }
            }
            // 2) Replace all marks with zeros
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == int.MinValue) matrix[i, j] = 0;
            }
            // Print modified matrix
            count = 0;
            foreach (int x in matrix)
            {
                Console.Write(x + " ");
                count++;
                if (count % matrix.GetLength(1) == 0) 
                    Console.WriteLine();
            }
        }
    }
}
