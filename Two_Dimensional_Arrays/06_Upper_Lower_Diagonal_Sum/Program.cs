using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Upper_Lower_Diagonal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]{ 
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 } 
            };
            int upperDiagonalSum = 0;
            int lowerDiagonalSum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        upperDiagonalSum += array[i, j];
                    }
                    else if (i > j)
                    {
                        lowerDiagonalSum += array[i, j];
                    }
                }
            }
            Console.WriteLine($"Upper Diagonal Sum: {upperDiagonalSum}");
            Console.WriteLine($"Lower Diagonal Sum: {lowerDiagonalSum}");
        }
    }
}
