using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sales_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] sales = new int[6,4];

            int bestStoreIndex = -1;
            int bestStoreSum = 0;

            for (int i = 0; i < sales.GetLength(0); i++) // rows = stores
            {
                for (int j = 0; j < sales.GetLength(1); j++) // columns = months
                {
                    sales[i,j] = rand.Next(1000, 5001); // Random sales between 1000 and 5000
                }
            }
            Console.WriteLine("Sales table (stores & months):");
            for (int i = 0; i < sales.GetLength(0); i++) // rows = stores
            {
                int rowSum = 0;
                Console.Write("Store " + (i + 1) + ": ");
                for (int j = 0; j < sales.GetLength(1); j++) // columns = months
                {
                    Console.Write(sales[i, j] + " ");
                    rowSum += sales[i, j];
                }
                Console.WriteLine(" | Total = " + rowSum);
                if (rowSum > bestStoreSum)
                {
                    bestStoreSum = rowSum;
                    bestStoreIndex = i;
                }
            }
            Console.WriteLine("\nThe store with the highest revenue:");
            Console.WriteLine($"Store {bestStoreIndex + 1} with total sales = {bestStoreSum}");
        }
    }
}
