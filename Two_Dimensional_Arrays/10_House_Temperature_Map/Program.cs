using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_House_Temperature_Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] TemperatureMap = new int[5, 5];

            // Variables for statistics
            int maxTemp = int.MinValue;
            int minTemp = int.MaxValue;
            int averageTemp = 0;
            int count = 0;

            int countForeach = 0;
            int columns = TemperatureMap.GetLength(1);

            // Fill the array with random temperatures and calculate statistics
            Console.WriteLine("Temperature Map:");
            for (int i = 0; i < TemperatureMap.GetLength(0); i++)
            {
                for (int j = 0; j < TemperatureMap.GetLength(1); j++)
                {
                    TemperatureMap[i, j] = rnd.Next(20, 41);
                    Console.Write(TemperatureMap[i, j] + " ");
                    if (TemperatureMap[i, j] > maxTemp)
                        maxTemp = TemperatureMap[i, j];

                    if (TemperatureMap[i, j] < minTemp)
                        minTemp = TemperatureMap[i, j];

                    averageTemp += TemperatureMap[i, j];
                    count++;
                }
                Console.WriteLine();
            }
            // Display statistics
            Console.WriteLine($"\n\nMax Temperature: {maxTemp}");
            Console.WriteLine($"Min Temperature: {minTemp}");
            Console.WriteLine($"Average Temperature: {averageTemp / count}");

            // Display the temperature map again, marking zones above average
            Console.WriteLine("\nZones above average are marked with *:\n");
            int avg = averageTemp / count;
            int printed = 0;
            // Using foreach to iterate through the 2D array
            foreach (int temp in TemperatureMap)
            {
                string star = " ";
                if (temp > avg) star = "*";

                Console.Write($"{temp,2}{star}  "); // Format for better alignment
                printed++;
                if (printed % columns == 0)
                    Console.WriteLine();
            }
        }
    }
}
