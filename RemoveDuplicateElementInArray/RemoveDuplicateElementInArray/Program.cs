using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 2, 3, 4, 5, 5, 5 };
            int[] array2 = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    array2[count] = array[i];
                    count++;
                }

            }
            array2[count] = array[array.Length - 1];



            for (int i = 0; i < count + 1; i++)
            {
                Console.Write(array2[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
