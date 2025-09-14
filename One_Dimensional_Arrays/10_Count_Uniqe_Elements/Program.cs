using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Count_Uniqe_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int countOfUniqeElements = 0;
            
            // Array output
            Console.Write("Array: [ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");

            for (int i = 0; i < array.Length;)
            {
                int groupSize = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        groupSize++;
                    else
                        break;
                }
                if (groupSize == 1)
                    countOfUniqeElements++;
                i += groupSize;
            }
            
            Console.WriteLine($"There is {countOfUniqeElements} uniqe Elements.");
        }
    }
}
