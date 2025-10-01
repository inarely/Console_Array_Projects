using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Rotate_Matrix
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
            int transpose;
            int count = 0;

            // Print original matrix
            foreach (int x in matrix)
            {
                Console.Write(x + " ");
                count++;
                if(count % matrix.GetLength(0) == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();

            // Transpose the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    transpose = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = transpose;
                }
            }

            // Reverse each row
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0) / 2; j++)
                {
                    int x = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(0) - 1 - j];
                    matrix[i, matrix.GetLength(0) - 1 - j] = x;
                }
            }

            // Print rotated matrix
            foreach (int x in matrix)
            {
                Console.Write(x + " ");
                count++;
                if (count % matrix.GetLength(0) == 0)
                    Console.WriteLine();
            }
        }
    }
}
