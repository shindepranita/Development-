using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduct
{
    public class Test
    {
        public void ArrayProduct(int[] ArrayElement)
        {
            int size = ArrayElement.Length;
            int[] resultArray = new int[size];
            int product = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (ArrayElement[j] != ArrayElement[i])
                    {
                        product = product * ArrayElement[j];
                    }


                }
                resultArray[i] = product;
                product = 1;
            }
            Console.WriteLine("Array after product : ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] ArrayValues = new int[length];

            Console.WriteLine("Enter Values");

            for (int i = 0; i < length; i++)
            {
                ArrayValues[i] = Convert.ToInt32(Console.ReadLine());
            }

            Test obj = new Test();

            obj.ArrayProduct(ArrayValues);
            Console.ReadKey();

        }
    }
}
