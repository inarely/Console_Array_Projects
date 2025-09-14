using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Grade_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int sum = 0, count = 0;
            int countGoodGrades = 0, countBadGrades = 0, average = 0;

            // Grades Output
            Console.Write("Grades: [ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");

            // Average
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                sum += array[i];
            }
            average = sum / count;
            Console.WriteLine($"\nAverage grade: {average}");

            // Count of great and bad grades
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 9)
                    countGoodGrades++;
                else if (array[i] <= 4)
                    countBadGrades++;
            }
            Console.WriteLine($"\nNumber of excellent grades (9 - 10): {countGoodGrades}");

            // Bad grades & student indexes
            Console.WriteLine($"\nNumber of failing grades (<= 4): {countBadGrades}");
            if (countBadGrades > 0)
            {
                Console.WriteLine("Students who failed:");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= 4)
                        Console.WriteLine($"Student #{i + 1,2}: {array[i],2}");
                }
            }
            else
            {
                Console.WriteLine("No failing students this time!");
            }

            // Grade table
            Console.WriteLine("\nGrade Chart:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1}: ");
                for (int j = 0; j < array[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({array[i]})");
            }

        }
    }
}
